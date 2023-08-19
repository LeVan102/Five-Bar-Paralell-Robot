using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        [DllImport("MDSP.dll")]
        public static extern short MDSP_initial(int CardType, int CardNo);//Card Type = 1: la card PCI8366 (xem tron .h file)
        [DllImport("MDSP.dll")]
        public static extern short MDSP_close(int Card);

        [DllImport("MDSP.dll")]
        public static extern short get_base_addr(int Card, ref ushort BaseAddr);

        [DllImport("MDSP.dll")]
        public static extern Int16 understand_mdsp(Int16 Card, ref UInt32 Version, ref UInt32 Date);
        [DllImport("MDSP.dll")]
        public static extern short set_servo_on(short Axis, short ON_OFF);
        #region Single Motion - Single axis P to P motion
        [DllImport("MDSP.dll")]
        public static extern short start_tr_move(short Axis, double Dist, double StrVel, double MaxVel, double FinVel, double Tacc, double Tdec);

        [DllImport("MDSP.dll")]
        public static extern short start_sr_move(short Axis, double Dist, double StrVel, double MaxVel, double FinVel, double Tacc, double Tdec, double Tlacc, double Tldec);

        [DllImport("MDSP.dll")]
        public static extern short start_ta_move(short Axis, double Pos, double StrVel, double MaxVel, double FinVel, double Tacc, double Tdec);
        [DllImport("MDSP.dll")]
        public static extern short start_sa_move(short Axis, double Pos, double StrVel, double MaxVel, double FinVel, double Tacc, double Tdec, double Tlacc, double Tldec);
        //tr: relative trapezoidal profile move
        //sr: S-curve Relative move
        //ta: absolute trapezoidal profile move
        //sa: absolute S-curve profile move
        //Axis: axis index designated to move or change position.
        //Dist: specified relative distance to move in unit of mm.
        //Pos: specified absolute position to move in unit of mm.
        //StrVel: starting velocity, in unit of mm per second.
        //MaxVel: maximum velocity, in unit of mm per second.
        //FinVel: final velocity, in unit of mm per second.
        //Tacc: specified total acceleration time in unit of second
        //Tlacc: specified linear acceleration time in unit of second
        //Tdec: specified deceleration time in unit of second.
        //Tldec: specified linear deceleration time in unit of second.
        #endregion
        #region Single Motion - Multi axes P to P motion
        [DllImport("MDSP.dll")]
        public static extern int start_tr_move_all(int Length, ref short Axis, ref double Dist, ref double StrVel, ref double MaxVel, ref double FinVel, ref double Tacc, ref double Tdec);
        [DllImport("MDSP.dll")]
        public static extern int start_sr_move_all(int Length, ref short Axis, ref double Dist, ref double StrVel, ref double MaxVel, ref double FinVel, ref double Tacc, ref double Tdec, ref double Tlacc, ref double Tldec);
        [DllImport("MDSP.dll")]
        public static extern int start_ta_move_all(int Length, ref short Axis, ref double Pos, ref double StrVel, ref double MaxVel, ref double FinVel, ref double Tacc, ref double Tdec);

        [DllImport("MDSP.dll")]
        public static extern int start_sa_move_all(int Length, ref short Axis, ref double Pos,
            ref double StrVel, ref double MaxVel, ref double FinVel, ref double Tacc, ref double Tdec, ref double Tlacc, ref double Tldec);
        #endregion

        #region Position control and feedback
        [DllImport("MDSP.dll")]
        public static extern int get_position(short Axis, ref double Pos_F, ref double Pos_C);

        [DllImport("MDSP.dll")]
        public static extern int set_position(short Axis, double Pos);
        [DllImport("MDSP.dll")]
        public static extern int get_target_pos(short Axis, ref double TargetPos);
        [DllImport("MDSP.dll")]
        public static extern int get_move_ratio(short Axis, ref Single PulsePerMM);
        [DllImport("MDSP.dll")]
        public static extern int set_move_ratio(short Axis, Single PulsePerMM);
        [DllImport("MDSP.dll")]
        public static extern int get_fb_position(short Axis, ref double Pos_F);
        [DllImport("MDSP.dll")]
        public static extern int shift_position(short Axis, double shiftMM);
        #endregion
        #region Motion Status
        [DllImport("MDSP.dll")]
        public static extern short motion_status(short Axis, ref ushort MotionStatus);
        [DllImport("MDSP.dll")]
        public static extern short axis_status(short Axis, ref ushort AxisStatus);
        [DllImport("MDSP.dll")]
        public static extern short motion_done(short Axis);
        #endregion

        #region IO Status
        [DllImport("MDSP.dll")]
        public static extern short set_PEL_config(short Axis, short Logic, short Mode);
        [DllImport("MDSP.dll")]
        public static extern short set_MEL_config(short Axis, short Logic, short Mode);
        [DllImport("MDSP.dll")]
        public static extern short set_ORG_config(short Axis, short Logic);
        [DllImport("MDSP.dll")]
        public static extern short set_EMG_config(short Card, short Logic);
        [DllImport("MDSP.dll")]
        public static extern short get_PEL_status(short Axis, ref short Status);
        [DllImport("MDSP.dll")]
        public static extern short get_MEL_status(short Axis, ref short Status);
        [DllImport("MDSP.dll")]
        public static extern short get_ORG_status(short Axis, ref short Status);
        [DllImport("MDSP.dll")]
        public static extern short get_EMG_status(short Card, ref short Status);
        #endregion

        #region  Alarm get and set
        [DllImport("MDSP.dll")]
        public static extern short get_alarm_no(short Axis,ref byte AlarmNo);
        [DllImport("MDSP.dll")]
        public static extern short alarm_reset(short Axis);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MDSP_initial(1, 0);//1: la card PCI8366 (xem tron .h file),
            set_move_ratio(0, 13107.2f);
            set_move_ratio(1, 13107.2f);
            set_move_ratio(2, 13107.2f);
            set_MEL_config(0, 1, 1); //Axis 0 ActiveControl High Mode 1: Gentle Slowdown 0: imediatly
            set_PEL_config(0, 1, 1);
            set_MEL_config(1, 1, 1); //ActiveControl High Mode 1: Gentle Slowdown 0: imediatly
            set_PEL_config(1, 1, 1);
            set_MEL_config(2, 1, 1); //ActiveControl High Mode 1: Gentle Slowdown 0: imediatly
            set_PEL_config(2, 1, 1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MDSP_close(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort BaseAddr = 0;
            uint Version = 0;
            uint Date = 0;
            short Card = 0;
            double Pos_F = 123f, Pos_C = 123f;
            float[] PulsePerMM = new float[3] { 0, 0, 0 };
            get_base_addr(Card, ref BaseAddr);
            understand_mdsp(Card, ref Version, ref Date);
            for (short i = 0; i < 3; i++)
                get_move_ratio(i, ref PulsePerMM[i]);
            get_position(0, ref Pos_F, ref Pos_C);
            button1.Text = BaseAddr.ToString() + "  Version:" + Version.ToString() + "    Date:" + Date.ToString()
                + "\n Pulse/mm:" + PulsePerMM[0].ToString() + "  " + PulsePerMM[1].ToString() + "  " + PulsePerMM[2].ToString()
                + "\nAxis Pos(Feedback,Command):  " + Pos_F.ToString() + " adhg " + Pos_C.ToString();
            ;

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Status_Tick(object sender, EventArgs e)
        {
            double PosF = 0;
            get_fb_position(0, ref PosF);
            Axis0_toolStripStatusLabel.Text = Math.Round(PosF, 5).ToString();
            get_fb_position(1, ref PosF);
            Axis1_toolStripStatusLabel.Text = Math.Round(PosF, 5).ToString();
            get_fb_position(2, ref PosF);
            Axis2_toolStripStatusLabel.Text = Math.Round(PosF, 5).ToString();

            Label[] label_PEL = {label_XPEL, label_YPEL, label_ZPEL };
            Label[] label_MEL = { label_XMEL, label_YMEL, label_ZMEL };
            short Status = 0;
            for (short i =0;i<3;i++)
            { 
            get_MEL_status(i, ref Status);
            if (Status == 1) label_MEL[i].BackColor = Color.Red;
            else label_MEL[i].BackColor = Color.Green;
            get_PEL_status(i, ref Status);
            if (Status == 1) label_PEL[i].BackColor = Color.Red;
            else label_PEL[i].BackColor = Color.Green;
                
            }
            Button[] button_ServoOn = { button_XServoOn, button_YServoOn, button_ZServoOn };
            ushort AxisStatus =0;
            for (short i = 0; i < 3; i++)
            {
                axis_status(i, ref AxisStatus);
                if (AxisStatus != 0) { button_ServoOn[i].BackColor = Color.Gray; button8.BackColor = Color.Red; }
                else { button_ServoOn[i].BackColor = Color.Red; button8.BackColor = Color.Gray; }
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            int i = start_tr_move(0, float.Parse(textBox1.Text), 0, 50, 0, 0.1, 0.2);
            button3.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int i = start_tr_move(0, -1 * float.Parse(textBox1.Text), 0, 50, 0, 0.1, 0.2);
            //button2.Text = i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (short i =0; i<3;i++) alarm_reset(i);
            ushort AxisStatus = 0;
            axis_status(0, ref AxisStatus);
            if (AxisStatus != 0)
            {
                short i = set_servo_on(0, 1);
                if (i != 0) button_XServoOn.Text = i.ToString();
                i = set_servo_on(1, 1);
                if (i != 0) button_XServoOn.Text = i.ToString();
                i = set_servo_on(2, 1);
                if (i != 0) button_XServoOn.Text = i.ToString();
            }
            else 
            {
                for (short j =0; j<3; j++) set_servo_on(j, 0);
            }
        }
        float _distance=0f;
        private void button6_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            
            if (radio001.Checked) _distance = 0.01f;
            if (radio005.Checked) _distance = 0.05f;
            if (radio01.Checked) _distance = 0.1f;
            if (radio02.Checked) _distance = 0.2f;
            if (radio05.Checked) _distance = 0.5f;
            if (radio1.Checked) _distance = 1f;
            if (radio10.Checked) _distance = 10f;
            if (radio20.Checked) _distance = 20f;
            switch (bt.Text.Trim())
                {
                case "X-":
                    start_tr_move(0, -1 * _distance, 0, 50, 0, 0.1, 0.2);
                    break;
                case "X+":
                    start_tr_move(0, _distance, 0, 50, 0, 0.1, 0.2);
                    break;
                case "Y-":
                    start_tr_move(1, -1 * _distance, 0, 50, 0, 0.1, 0.2);
                    break;
                case "Y+":
                    start_tr_move(1, _distance, 0, 50, 0, 0.1, 0.2);
                    break;
                case "Z-":
                    start_tr_move(2, -1*_distance, 0, 50, 0, 0.1, 0.2);
                    break;
                case "Z+":
                    start_tr_move(2, _distance, 0, 50, 0, 0.1, 0.2);
                    break;
                default:
                    break;
            }
           
            //int i = start_tr_move(1,  float.Parse(textBox1.Text), 0, 50, 0, 0.1, 0.2);
            //button2.Text = i.ToString();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (short i = 0; i < 3; i++) alarm_reset(i);
        }

        private void button_Add(object sender, EventArgs e)
        {
            Grd_Vitri.Rows.Add(Axis0_toolStripStatusLabel.Text, Axis1_toolStripStatusLabel.Text, Axis2_toolStripStatusLabel.Text);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Grd_Vitri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Choose Row");
            }
            else
            {
                Grd_Vitri.Rows.Remove(Grd_Vitri.CurrentRow);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Grd_Vitri.Rows.Clear();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (Grd_Vitri.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in Grd_Vitri.Rows)
                    {
                        string rowText = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowText += cell.Value + "\t"; // Sử dụng ký tự tab để phân tách các ô
                        }
                        sw.WriteLine(rowText.TrimEnd('\t')); // Ghi dòng vào file
                    }
                }
                MessageBox.Show("Dữ liệu đã được ghi vào file văn bản.");
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //cell.Text = "Load file";
                string filePath = openFileDialog.FileName;

                // Read the lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Clear existing rows in the DataGridView
                Grd_Vitri.Rows.Clear();

                // Populate DataGridView with data from the text file
                foreach (string line in lines)
                {
                    string[] values = line.Split('\t'); // Assuming data is tab-separated
                    Grd_Vitri.Rows.Add(values);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grd_Vitri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell.Text = Grd_Vitri.CurrentCell.RowIndex.ToString() + ":" + Grd_Vitri.CurrentCell.ColumnIndex.ToString();
            cell.Text = Grd_Vitri.CurrentCell.Value.GetType().ToString();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            Int16 _axis = (Int16)Grd_Vitri.CurrentCell.ColumnIndex;
            Double _distance = Double.Parse(Grd_Vitri.CurrentCell.Value.ToString());
            start_ta_move(_axis,  _distance, 0, 50, 0, 0.1, 0.2);
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int16 _axis = (Int16)Grd_Vitri.CurrentCell.ColumnIndex;
            Double _distance = Double.Parse(Grd_Vitri.CurrentCell.Value.ToString());
            start_ta_move(_axis, _distance, 0, 50, 0, 0.1, 0.2);
        }
    }
}
