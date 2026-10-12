namespace MarantzController
{
    partial class frmControler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControler));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstSend = new System.Windows.Forms.ListBox();
            this.lstReceive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.zFrontLeftVolume = new System.Windows.Forms.VScrollBar();
            this.zFrontRightVolume = new System.Windows.Forms.VScrollBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSEND = new System.Windows.Forms.CheckBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.txtFrontRight = new System.Windows.Forms.TextBox();
            this.txtFrontLeft = new System.Windows.Forms.TextBox();
            this.txtSubwoofer = new System.Windows.Forms.TextBox();
            this.txtBalanceFrontRear = new System.Windows.Forms.TextBox();
            this.txtSurrLeft = new System.Windows.Forms.TextBox();
            this.txtMasterVolume = new System.Windows.Forms.TextBox();
            this.txtMasterBalance = new System.Windows.Forms.TextBox();
            this.txtCenterVolume = new System.Windows.Forms.TextBox();
            this.txtSurrRight = new System.Windows.Forms.TextBox();
            this.txtSurrBackRight = new System.Windows.Forms.TextBox();
            this.txtRearBalance = new System.Windows.Forms.TextBox();
            this.txtScrollLegend = new System.Windows.Forms.TextBox();
            this.txtSurrBackLeft = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zBalanceFrontRear = new System.Windows.Forms.VScrollBar();
            this.zMasterVolume = new System.Windows.Forms.VScrollBar();
            this.zSurrRightVolume = new System.Windows.Forms.VScrollBar();
            this.zSurrLeftVolume = new System.Windows.Forms.VScrollBar();
            this.zCenterVolume = new System.Windows.Forms.VScrollBar();
            this.zSurrBackRightVolume = new System.Windows.Forms.VScrollBar();
            this.zSurrBackLeftVolume = new System.Windows.Forms.VScrollBar();
            this.zMasterBalance = new System.Windows.Forms.HScrollBar();
            this.zRearBalance = new System.Windows.Forms.HScrollBar();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxCMD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabVolume.SuspendLayout();
            this.tabCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 2);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(675, 732);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // lstSend
            // 
            this.lstSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSend.FormattingEnabled = true;
            this.lstSend.ItemHeight = 15;
            this.lstSend.Location = new System.Drawing.Point(0, 24);
            this.lstSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSend.Name = "lstSend";
            this.lstSend.Size = new System.Drawing.Size(691, 79);
            this.lstSend.TabIndex = 2;
            // 
            // lstReceive
            // 
            this.lstReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstReceive.HideSelection = false;
            this.lstReceive.Location = new System.Drawing.Point(0, 104);
            this.lstReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstReceive.Name = "lstReceive";
            this.lstReceive.Size = new System.Drawing.Size(691, 614);
            this.lstReceive.TabIndex = 3;
            this.lstReceive.UseCompatibleStateImageBehavior = false;
            this.lstReceive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Send / Receive ";
            this.columnHeader1.Width = 1000;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCMD);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.lstReceive);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.lstSend);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1390, 762);
            this.splitContainer1.SplitterDistance = 690;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabCommands);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 762);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVolume
            // 
            this.tabVolume.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabVolume.Controls.Add(this.zFrontLeftVolume);
            this.tabVolume.Controls.Add(this.zFrontRightVolume);
            this.tabVolume.Controls.Add(this.label17);
            this.tabVolume.Controls.Add(this.label16);
            this.tabVolume.Controls.Add(this.label9);
            this.tabVolume.Controls.Add(this.chkSEND);
            this.tabVolume.Controls.Add(this.ButtonReset);
            this.tabVolume.Controls.Add(this.txtFrontRight);
            this.tabVolume.Controls.Add(this.txtFrontLeft);
            this.tabVolume.Controls.Add(this.txtSubwoofer);
            this.tabVolume.Controls.Add(this.txtBalanceFrontRear);
            this.tabVolume.Controls.Add(this.txtSurrLeft);
            this.tabVolume.Controls.Add(this.txtMasterVolume);
            this.tabVolume.Controls.Add(this.txtMasterBalance);
            this.tabVolume.Controls.Add(this.txtCenterVolume);
            this.tabVolume.Controls.Add(this.txtSurrRight);
            this.tabVolume.Controls.Add(this.txtSurrBackRight);
            this.tabVolume.Controls.Add(this.txtRearBalance);
            this.tabVolume.Controls.Add(this.txtScrollLegend);
            this.tabVolume.Controls.Add(this.txtSurrBackLeft);
            this.tabVolume.Controls.Add(this.label11);
            this.tabVolume.Controls.Add(this.label5);
            this.tabVolume.Controls.Add(this.label10);
            this.tabVolume.Controls.Add(this.label8);
            this.tabVolume.Controls.Add(this.label6);
            this.tabVolume.Controls.Add(this.label4);
            this.tabVolume.Controls.Add(this.label3);
            this.tabVolume.Controls.Add(this.label2);
            this.tabVolume.Controls.Add(this.label1);
            this.tabVolume.Controls.Add(this.zBalanceFrontRear);
            this.tabVolume.Controls.Add(this.zMasterVolume);
            this.tabVolume.Controls.Add(this.zSurrRightVolume);
            this.tabVolume.Controls.Add(this.zSurrLeftVolume);
            this.tabVolume.Controls.Add(this.zCenterVolume);
            this.tabVolume.Controls.Add(this.zSurrBackRightVolume);
            this.tabVolume.Controls.Add(this.zSurrBackLeftVolume);
            this.tabVolume.Controls.Add(this.zMasterBalance);
            this.tabVolume.Controls.Add(this.zRearBalance);
            this.tabVolume.Location = new System.Drawing.Point(4, 24);
            this.tabVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVolume.Size = new System.Drawing.Size(682, 734);
            this.tabVolume.TabIndex = 1;
            this.tabVolume.Text = "Volume";
            // 
            // zFrontLeftVolume
            // 
            this.zFrontLeftVolume.Location = new System.Drawing.Point(109, 52);
            this.zFrontLeftVolume.Name = "zFrontLeftVolume";
            this.zFrontLeftVolume.Size = new System.Drawing.Size(19, 148);
            this.zFrontLeftVolume.TabIndex = 39;
            this.zFrontLeftVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZFrontLeftVolume_Scroll);
            // 
            // zFrontRightVolume
            // 
            this.zFrontRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zFrontRightVolume.Location = new System.Drawing.Point(556, 52);
            this.zFrontRightVolume.Name = "zFrontRightVolume";
            this.zFrontRightVolume.Size = new System.Drawing.Size(19, 148);
            this.zFrontRightVolume.TabIndex = 38;
            this.zFrontRightVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZFrontRightVolume_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Subwoofer 1";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(483, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Front Right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Front Left";
            // 
            // chkSEND
            // 
            this.chkSEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSEND.AutoSize = true;
            this.chkSEND.BackColor = System.Drawing.Color.Transparent;
            this.chkSEND.Location = new System.Drawing.Point(616, 8);
            this.chkSEND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSEND.Name = "chkSEND";
            this.chkSEND.Size = new System.Drawing.Size(60, 19);
            this.chkSEND.TabIndex = 33;
            this.chkSEND.Text = "SEND";
            this.chkSEND.UseVisualStyleBackColor = false;
            this.chkSEND.CheckedChanged += new System.EventHandler(this.chkSEND_CheckedChanged);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Location = new System.Drawing.Point(300, 332);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(88, 41);
            this.ButtonReset.TabIndex = 32;
            this.ButtonReset.Text = "RESET\r\nChannel Vol";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // txtFrontRight
            // 
            this.txtFrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrontRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtFrontRight.Location = new System.Drawing.Point(487, 52);
            this.txtFrontRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrontRight.Multiline = true;
            this.txtFrontRight.Name = "txtFrontRight";
            this.txtFrontRight.Size = new System.Drawing.Size(57, 56);
            this.txtFrontRight.TabIndex = 31;
            this.txtFrontRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFrontLeft
            // 
            this.txtFrontLeft.BackColor = System.Drawing.Color.LightBlue;
            this.txtFrontLeft.Location = new System.Drawing.Point(140, 52);
            this.txtFrontLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrontLeft.Multiline = true;
            this.txtFrontLeft.Name = "txtFrontLeft";
            this.txtFrontLeft.Size = new System.Drawing.Size(57, 56);
            this.txtFrontLeft.TabIndex = 30;
            this.txtFrontLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubwoofer
            // 
            this.txtSubwoofer.BackColor = System.Drawing.Color.LightBlue;
            this.txtSubwoofer.Location = new System.Drawing.Point(12, 12);
            this.txtSubwoofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubwoofer.Multiline = true;
            this.txtSubwoofer.Name = "txtSubwoofer";
            this.txtSubwoofer.Size = new System.Drawing.Size(57, 56);
            this.txtSubwoofer.TabIndex = 34;
            this.txtSubwoofer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalanceFrontRear
            // 
            this.txtBalanceFrontRear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBalanceFrontRear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBalanceFrontRear.Location = new System.Drawing.Point(36, 313);
            this.txtBalanceFrontRear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalanceFrontRear.Multiline = true;
            this.txtBalanceFrontRear.Name = "txtBalanceFrontRear";
            this.txtBalanceFrontRear.Size = new System.Drawing.Size(57, 56);
            this.txtBalanceFrontRear.TabIndex = 29;
            this.txtBalanceFrontRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSurrLeft
            // 
            this.txtSurrLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSurrLeft.BackColor = System.Drawing.Color.LightBlue;
            this.txtSurrLeft.Location = new System.Drawing.Point(140, 652);
            this.txtSurrLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurrLeft.Multiline = true;
            this.txtSurrLeft.Name = "txtSurrLeft";
            this.txtSurrLeft.Size = new System.Drawing.Size(57, 56);
            this.txtSurrLeft.TabIndex = 29;
            this.txtSurrLeft.Text = "100\r\n188.8 >\r\n199.9 <";
            this.txtSurrLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMasterVolume
            // 
            this.txtMasterVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMasterVolume.BackColor = System.Drawing.Color.Thistle;
            this.txtMasterVolume.Location = new System.Drawing.Point(589, 313);
            this.txtMasterVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasterVolume.Multiline = true;
            this.txtMasterVolume.Name = "txtMasterVolume";
            this.txtMasterVolume.Size = new System.Drawing.Size(57, 56);
            this.txtMasterVolume.TabIndex = 29;
            this.txtMasterVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMasterBalance
            // 
            this.txtMasterBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMasterBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMasterBalance.Location = new System.Drawing.Point(496, 360);
            this.txtMasterBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasterBalance.Multiline = true;
            this.txtMasterBalance.Name = "txtMasterBalance";
            this.txtMasterBalance.Size = new System.Drawing.Size(57, 56);
            this.txtMasterBalance.TabIndex = 29;
            this.txtMasterBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCenterVolume
            // 
            this.txtCenterVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCenterVolume.BackColor = System.Drawing.Color.LightBlue;
            this.txtCenterVolume.Location = new System.Drawing.Point(316, 24);
            this.txtCenterVolume.Margin = new System.Windows.Forms.Padding(0);
            this.txtCenterVolume.Multiline = true;
            this.txtCenterVolume.Name = "txtCenterVolume";
            this.txtCenterVolume.Size = new System.Drawing.Size(57, 56);
            this.txtCenterVolume.TabIndex = 29;
            this.txtCenterVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSurrRight
            // 
            this.txtSurrRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurrRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtSurrRight.Location = new System.Drawing.Point(488, 652);
            this.txtSurrRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurrRight.Multiline = true;
            this.txtSurrRight.Name = "txtSurrRight";
            this.txtSurrRight.Size = new System.Drawing.Size(57, 56);
            this.txtSurrRight.TabIndex = 29;
            this.txtSurrRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSurrBackRight
            // 
            this.txtSurrBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurrBackRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtSurrBackRight.Location = new System.Drawing.Point(589, 512);
            this.txtSurrBackRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurrBackRight.Multiline = true;
            this.txtSurrBackRight.Name = "txtSurrBackRight";
            this.txtSurrBackRight.Size = new System.Drawing.Size(57, 56);
            this.txtSurrBackRight.TabIndex = 29;
            this.txtSurrBackRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRearBalance
            // 
            this.txtRearBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRearBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtRearBalance.Location = new System.Drawing.Point(424, 516);
            this.txtRearBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRearBalance.Multiline = true;
            this.txtRearBalance.Name = "txtRearBalance";
            this.txtRearBalance.Size = new System.Drawing.Size(57, 56);
            this.txtRearBalance.TabIndex = 29;
            this.txtRearBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScrollLegend
            // 
            this.txtScrollLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScrollLegend.BackColor = System.Drawing.Color.DarkGray;
            this.txtScrollLegend.Location = new System.Drawing.Point(256, 256);
            this.txtScrollLegend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScrollLegend.Multiline = true;
            this.txtScrollLegend.Name = "txtScrollLegend";
            this.txtScrollLegend.Size = new System.Drawing.Size(176, 56);
            this.txtScrollLegend.TabIndex = 29;
            // 
            // txtSurrBackLeft
            // 
            this.txtSurrBackLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSurrBackLeft.BackColor = System.Drawing.Color.LightBlue;
            this.txtSurrBackLeft.Location = new System.Drawing.Point(38, 512);
            this.txtSurrBackLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurrBackLeft.Multiline = true;
            this.txtSurrBackLeft.Name = "txtSurrBackLeft";
            this.txtSurrBackLeft.Size = new System.Drawing.Size(57, 56);
            this.txtSurrBackLeft.TabIndex = 29;
            this.txtSurrBackLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(8, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Front Rear Balance";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(108, 711);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Surround Back Left";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(456, 712);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Surround Back Right";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(324, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Center";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(125, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Master Balance Left/Right";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(585, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Master Volume";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(582, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Surround Right";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Surround Left";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(205, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surround Balance Left/Right";
            // 
            // zBalanceFrontRear
            // 
            this.zBalanceFrontRear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zBalanceFrontRear.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.zBalanceFrontRear.Enabled = false;
            this.zBalanceFrontRear.Location = new System.Drawing.Point(12, 208);
            this.zBalanceFrontRear.Name = "zBalanceFrontRear";
            this.zBalanceFrontRear.Size = new System.Drawing.Size(18, 158);
            this.zBalanceFrontRear.TabIndex = 17;
            this.zBalanceFrontRear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBalanceFrontRear_Scroll);
            // 
            // zMasterVolume
            // 
            this.zMasterVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zMasterVolume.Location = new System.Drawing.Point(653, 213);
            this.zMasterVolume.Name = "zMasterVolume";
            this.zMasterVolume.Size = new System.Drawing.Size(18, 158);
            this.zMasterVolume.TabIndex = 16;
            this.zMasterVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZMasterVolume_Scroll);
            // 
            // zSurrRightVolume
            // 
            this.zSurrRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zSurrRightVolume.Location = new System.Drawing.Point(653, 512);
            this.zSurrRightVolume.Name = "zSurrRightVolume";
            this.zSurrRightVolume.Size = new System.Drawing.Size(18, 196);
            this.zSurrRightVolume.TabIndex = 15;
            this.zSurrRightVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBackRight_Scroll);
            // 
            // zSurrLeftVolume
            // 
            this.zSurrLeftVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zSurrLeftVolume.Location = new System.Drawing.Point(12, 512);
            this.zSurrLeftVolume.Name = "zSurrLeftVolume";
            this.zSurrLeftVolume.Size = new System.Drawing.Size(18, 196);
            this.zSurrLeftVolume.TabIndex = 14;
            this.zSurrLeftVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBackLeft_Scroll);
            // 
            // zCenterVolume
            // 
            this.zCenterVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zCenterVolume.Location = new System.Drawing.Point(336, 84);
            this.zCenterVolume.Name = "zCenterVolume";
            this.zCenterVolume.Size = new System.Drawing.Size(18, 120);
            this.zCenterVolume.TabIndex = 13;
            this.zCenterVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZCenterVolume_Scroll);
            // 
            // zSurrBackRightVolume
            // 
            this.zSurrBackRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zSurrBackRightVolume.Location = new System.Drawing.Point(556, 512);
            this.zSurrBackRightVolume.Name = "zSurrBackRightVolume";
            this.zSurrBackRightVolume.Size = new System.Drawing.Size(18, 196);
            this.zSurrBackRightVolume.TabIndex = 12;
            this.zSurrBackRightVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZSurrBackRightVolume_Scroll);
            // 
            // zSurrBackLeftVolume
            // 
            this.zSurrBackLeftVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zSurrBackLeftVolume.Location = new System.Drawing.Point(112, 512);
            this.zSurrBackLeftVolume.Name = "zSurrBackLeftVolume";
            this.zSurrBackLeftVolume.Size = new System.Drawing.Size(18, 196);
            this.zSurrBackLeftVolume.TabIndex = 9;
            this.zSurrBackLeftVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZSurrBackLeftVolume_Scroll);
            // 
            // zMasterBalance
            // 
            this.zMasterBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zMasterBalance.Cursor = System.Windows.Forms.Cursors.Default;
            this.zMasterBalance.Location = new System.Drawing.Point(127, 421);
            this.zMasterBalance.Name = "zMasterBalance";
            this.zMasterBalance.Size = new System.Drawing.Size(428, 18);
            this.zMasterBalance.TabIndex = 8;
            this.zMasterBalance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZMasterBalance_Scroll);
            // 
            // zRearBalance
            // 
            this.zRearBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zRearBalance.Location = new System.Drawing.Point(205, 580);
            this.zRearBalance.Name = "zRearBalance";
            this.zRearBalance.Size = new System.Drawing.Size(277, 18);
            this.zRearBalance.TabIndex = 7;
            this.zRearBalance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZRearBalance_Scroll);
            // 
            // tabCommands
            // 
            this.tabCommands.BackColor = System.Drawing.Color.Transparent;
            this.tabCommands.Controls.Add(this.treeView1);
            this.tabCommands.Location = new System.Drawing.Point(4, 22);
            this.tabCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCommands.Size = new System.Drawing.Size(681, 736);
            this.tabCommands.TabIndex = 0;
            this.tabCommands.Text = "Commands";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(511, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 28);
            this.button3.TabIndex = 41;
            this.button3.Text = "N";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxCMD
            // 
            this.textBoxCMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCMD.BackColor = System.Drawing.Color.Black;
            this.textBoxCMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMD.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCMD.Location = new System.Drawing.Point(148, 726);
            this.textBoxCMD.Multiline = true;
            this.textBoxCMD.Name = "textBoxCMD";
            this.textBoxCMD.Size = new System.Drawing.Size(359, 24);
            this.textBoxCMD.TabIndex = 40;
            this.textBoxCMD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(539, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Save RX/TX to txrxlog.txt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Clear Send / Receive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(140, 722);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 28);
            this.panel1.TabIndex = 42;
            // 
            // frmControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 765);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmControler";
            this.Text = "Marantz Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControler_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.frmControler_ResizeEnd);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabVolume.ResumeLayout(false);
            this.tabVolume.PerformLayout();
            this.tabCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstSend;
        private System.Windows.Forms.ListView lstReceive;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCommands;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.VScrollBar zBalanceFrontRear;
        private System.Windows.Forms.VScrollBar zMasterVolume;
        private System.Windows.Forms.VScrollBar zSurrRightVolume;
        private System.Windows.Forms.VScrollBar zSurrLeftVolume;
        private System.Windows.Forms.VScrollBar zCenterVolume;
        private System.Windows.Forms.VScrollBar zSurrBackRightVolume;
        private System.Windows.Forms.VScrollBar zSurrBackLeftVolume;
        private System.Windows.Forms.HScrollBar zMasterBalance;
        private System.Windows.Forms.HScrollBar zRearBalance;
        private System.Windows.Forms.TextBox txtBalanceFrontRear;
        private System.Windows.Forms.TextBox txtSurrLeft;
        private System.Windows.Forms.TextBox txtMasterVolume;
        private System.Windows.Forms.TextBox txtMasterBalance;
        private System.Windows.Forms.TextBox txtCenterVolume;
        private System.Windows.Forms.TextBox txtSurrRight;
        private System.Windows.Forms.TextBox txtSurrBackRight;
        private System.Windows.Forms.TextBox txtRearBalance;
        private System.Windows.Forms.TextBox txtSurrBackLeft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrontRight;
        private System.Windows.Forms.TextBox txtFrontLeft;
        private System.Windows.Forms.TextBox txtSubwoofer;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtScrollLegend;
        private System.Windows.Forms.CheckBox chkSEND;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar zFrontLeftVolume;
        private System.Windows.Forms.VScrollBar zFrontRightVolume;
    }
}