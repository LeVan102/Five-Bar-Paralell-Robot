
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Axis0_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Axis1_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Axis2_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_Status = new System.Windows.Forms.Timer(this.components);
            this.button_XServoOn = new System.Windows.Forms.Button();
            this.label_XMEL = new System.Windows.Forms.Label();
            this.label_XPEL = new System.Windows.Forms.Label();
            this.label_YPEL = new System.Windows.Forms.Label();
            this.label_YMEL = new System.Windows.Forms.Label();
            this.label_ZPEL = new System.Windows.Forms.Label();
            this.label_ZMEL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_YServoOn = new System.Windows.Forms.Button();
            this.button_ZServoOn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.radio001 = new System.Windows.Forms.RadioButton();
            this.radio005 = new System.Windows.Forms.RadioButton();
            this.radio05 = new System.Windows.Forms.RadioButton();
            this.radio02 = new System.Windows.Forms.RadioButton();
            this.radio01 = new System.Windows.Forms.RadioButton();
            this.radio20 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.Grd_Vitri = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.cell = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Vitri)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Z-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Z+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "10";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Axis0_toolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.Axis1_toolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.Axis2_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel1.Text = "X:";
            // 
            // Axis0_toolStripStatusLabel
            // 
            this.Axis0_toolStripStatusLabel.Name = "Axis0_toolStripStatusLabel";
            this.Axis0_toolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.Axis0_toolStripStatusLabel.Text = "0";
            this.Axis0_toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel2.Text = "Y:";
            // 
            // Axis1_toolStripStatusLabel
            // 
            this.Axis1_toolStripStatusLabel.Name = "Axis1_toolStripStatusLabel";
            this.Axis1_toolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.Axis1_toolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabel3.Text = "Z";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // Axis2_toolStripStatusLabel
            // 
            this.Axis2_toolStripStatusLabel.Name = "Axis2_toolStripStatusLabel";
            this.Axis2_toolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.Axis2_toolStripStatusLabel.Text = "0";
            // 
            // timer_Status
            // 
            this.timer_Status.Enabled = true;
            this.timer_Status.Tick += new System.EventHandler(this.timer_Status_Tick);
            // 
            // button_XServoOn
            // 
            this.button_XServoOn.Location = new System.Drawing.Point(492, 28);
            this.button_XServoOn.Name = "button_XServoOn";
            this.button_XServoOn.Size = new System.Drawing.Size(89, 130);
            this.button_XServoOn.TabIndex = 5;
            this.button_XServoOn.Text = "X ON";
            this.button_XServoOn.UseVisualStyleBackColor = true;
            this.button_XServoOn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_XMEL
            // 
            this.label_XMEL.AutoSize = true;
            this.label_XMEL.Location = new System.Drawing.Point(62, 221);
            this.label_XMEL.Name = "label_XMEL";
            this.label_XMEL.Size = new System.Drawing.Size(29, 13);
            this.label_XMEL.TabIndex = 6;
            this.label_XMEL.Text = "MEL";
            // 
            // label_XPEL
            // 
            this.label_XPEL.AutoSize = true;
            this.label_XPEL.Location = new System.Drawing.Point(62, 195);
            this.label_XPEL.Name = "label_XPEL";
            this.label_XPEL.Size = new System.Drawing.Size(27, 13);
            this.label_XPEL.TabIndex = 7;
            this.label_XPEL.Text = "PEL";
            // 
            // label_YPEL
            // 
            this.label_YPEL.AutoSize = true;
            this.label_YPEL.Location = new System.Drawing.Point(95, 195);
            this.label_YPEL.Name = "label_YPEL";
            this.label_YPEL.Size = new System.Drawing.Size(27, 13);
            this.label_YPEL.TabIndex = 9;
            this.label_YPEL.Text = "PEL";
            // 
            // label_YMEL
            // 
            this.label_YMEL.AutoSize = true;
            this.label_YMEL.Location = new System.Drawing.Point(95, 221);
            this.label_YMEL.Name = "label_YMEL";
            this.label_YMEL.Size = new System.Drawing.Size(29, 13);
            this.label_YMEL.TabIndex = 8;
            this.label_YMEL.Text = "MEL";
            // 
            // label_ZPEL
            // 
            this.label_ZPEL.AutoSize = true;
            this.label_ZPEL.Location = new System.Drawing.Point(128, 195);
            this.label_ZPEL.Name = "label_ZPEL";
            this.label_ZPEL.Size = new System.Drawing.Size(27, 13);
            this.label_ZPEL.TabIndex = 11;
            this.label_ZPEL.Text = "PEL";
            // 
            // label_ZMEL
            // 
            this.label_ZMEL.AutoSize = true;
            this.label_ZMEL.Location = new System.Drawing.Point(128, 221);
            this.label_ZMEL.Name = "label_ZMEL";
            this.label_ZMEL.Size = new System.Drawing.Size(29, 13);
            this.label_ZMEL.TabIndex = 10;
            this.label_ZMEL.Text = "MEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // button_YServoOn
            // 
            this.button_YServoOn.Location = new System.Drawing.Point(576, 28);
            this.button_YServoOn.Name = "button_YServoOn";
            this.button_YServoOn.Size = new System.Drawing.Size(88, 130);
            this.button_YServoOn.TabIndex = 15;
            this.button_YServoOn.Text = "Y ON";
            this.button_YServoOn.UseVisualStyleBackColor = true;
            this.button_YServoOn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_ZServoOn
            // 
            this.button_ZServoOn.Location = new System.Drawing.Point(659, 28);
            this.button_ZServoOn.Name = "button_ZServoOn";
            this.button_ZServoOn.Size = new System.Drawing.Size(80, 130);
            this.button_ZServoOn.TabIndex = 16;
            this.button_ZServoOn.Text = "Z ON";
            this.button_ZServoOn.UseVisualStyleBackColor = true;
            this.button_ZServoOn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Y-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 36);
            this.button5.TabIndex = 18;
            this.button5.Text = "Y+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(408, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 36);
            this.button6.TabIndex = 20;
            this.button6.Text = "X+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(299, 308);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 37);
            this.button7.TabIndex = 19;
            this.button7.Text = "X-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(380, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 130);
            this.button8.TabIndex = 21;
            this.button8.Text = "Clear Alarm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // radio001
            // 
            this.radio001.AutoSize = true;
            this.radio001.Location = new System.Drawing.Point(243, 401);
            this.radio001.Name = "radio001";
            this.radio001.Size = new System.Drawing.Size(46, 17);
            this.radio001.TabIndex = 29;
            this.radio001.Text = "0.01";
            this.radio001.UseVisualStyleBackColor = true;
            // 
            // radio005
            // 
            this.radio005.AutoSize = true;
            this.radio005.Location = new System.Drawing.Point(288, 401);
            this.radio005.Name = "radio005";
            this.radio005.Size = new System.Drawing.Size(46, 17);
            this.radio005.TabIndex = 26;
            this.radio005.Text = "0.05";
            this.radio005.UseVisualStyleBackColor = true;
            // 
            // radio05
            // 
            this.radio05.AutoSize = true;
            this.radio05.Location = new System.Drawing.Point(423, 401);
            this.radio05.Name = "radio05";
            this.radio05.Size = new System.Drawing.Size(40, 17);
            this.radio05.TabIndex = 28;
            this.radio05.Text = "0.5";
            this.radio05.UseVisualStyleBackColor = true;
            // 
            // radio02
            // 
            this.radio02.AutoSize = true;
            this.radio02.Location = new System.Drawing.Point(380, 401);
            this.radio02.Name = "radio02";
            this.radio02.Size = new System.Drawing.Size(40, 17);
            this.radio02.TabIndex = 27;
            this.radio02.Text = "0.2";
            this.radio02.UseVisualStyleBackColor = true;
            // 
            // radio01
            // 
            this.radio01.AutoSize = true;
            this.radio01.Location = new System.Drawing.Point(334, 401);
            this.radio01.Name = "radio01";
            this.radio01.Size = new System.Drawing.Size(40, 17);
            this.radio01.TabIndex = 25;
            this.radio01.Text = "0.1";
            this.radio01.UseVisualStyleBackColor = true;
            // 
            // radio20
            // 
            this.radio20.AutoSize = true;
            this.radio20.Location = new System.Drawing.Point(550, 401);
            this.radio20.Name = "radio20";
            this.radio20.Size = new System.Drawing.Size(37, 17);
            this.radio20.TabIndex = 24;
            this.radio20.Text = "20";
            this.radio20.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Location = new System.Drawing.Point(507, 401);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(37, 17);
            this.radio10.TabIndex = 23;
            this.radio10.Text = "10";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(470, 401);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(31, 17);
            this.radio1.TabIndex = 22;
            this.radio1.TabStop = true;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // Grd_Vitri
            // 
            this.Grd_Vitri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Vitri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z});
            this.Grd_Vitri.ContextMenuStrip = this.contextMenuStrip1;
            this.Grd_Vitri.Location = new System.Drawing.Point(745, 28);
            this.Grd_Vitri.Name = "Grd_Vitri";
            this.Grd_Vitri.Size = new System.Drawing.Size(347, 180);
            this.Grd_Vitri.TabIndex = 30;
            this.Grd_Vitri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Vitri_CellClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem,
            this.insertRowToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 180);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gotoToolStripMenuItem.Text = "Move To...";
            this.gotoToolStripMenuItem.Click += new System.EventHandler(this.gotoToolStripMenuItem_Click);
            // 
            // insertRowToolStripMenuItem
            // 
            this.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem";
            this.insertRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.insertRowToolStripMenuItem.Text = "Insert Row";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.button_Add);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem.Text = "Delete...";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(745, 216);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 31;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.button_Add);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(892, 216);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 32;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(1017, 216);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 33;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(745, 268);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 34;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(892, 268);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 35;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Home
            // 
            this.button_Home.Location = new System.Drawing.Point(1017, 268);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(75, 23);
            this.button_Home.TabIndex = 37;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // cell
            // 
            this.cell.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cell.Location = new System.Drawing.Point(850, 325);
            this.cell.Name = "cell";
            this.cell.Size = new System.Drawing.Size(117, 20);
            this.cell.TabIndex = 38;
            this.cell.Text = "Current";
            this.cell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cell.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 517);
            this.Controls.Add(this.cell);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.Grd_Vitri);
            this.Controls.Add(this.radio001);
            this.Controls.Add(this.radio005);
            this.Controls.Add(this.radio05);
            this.Controls.Add(this.radio02);
            this.Controls.Add(this.radio01);
            this.Controls.Add(this.radio20);
            this.Controls.Add(this.radio10);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_ZServoOn);
            this.Controls.Add(this.button_YServoOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_ZPEL);
            this.Controls.Add(this.label_ZMEL);
            this.Controls.Add(this.label_YPEL);
            this.Controls.Add(this.label_YMEL);
            this.Controls.Add(this.label_XPEL);
            this.Controls.Add(this.label_XMEL);
            this.Controls.Add(this.button_XServoOn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Vitri)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Axis0_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Axis1_toolStripStatusLabel;
        private System.Windows.Forms.Timer timer_Status;
        private System.Windows.Forms.Button button_XServoOn;
        private System.Windows.Forms.Label label_XMEL;
        private System.Windows.Forms.Label label_XPEL;
        private System.Windows.Forms.Label label_YPEL;
        private System.Windows.Forms.Label label_YMEL;
        private System.Windows.Forms.Label label_ZPEL;
        private System.Windows.Forms.Label label_ZMEL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_YServoOn;
        private System.Windows.Forms.Button button_ZServoOn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel Axis2_toolStripStatusLabel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton radio001;
        private System.Windows.Forms.RadioButton radio005;
        private System.Windows.Forms.RadioButton radio05;
        private System.Windows.Forms.RadioButton radio02;
        private System.Windows.Forms.RadioButton radio01;
        private System.Windows.Forms.RadioButton radio20;
        private System.Windows.Forms.RadioButton radio10;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.DataGridView Grd_Vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.TextBox cell;
    }
}

