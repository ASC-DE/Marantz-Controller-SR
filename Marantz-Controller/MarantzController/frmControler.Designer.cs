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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControler));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstSend = new System.Windows.Forms.ListBox();
            this.lstReceive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSEND = new System.Windows.Forms.CheckBox();
            this.butReset = new System.Windows.Forms.Button();
            this.txtFrontRight = new System.Windows.Forms.TextBox();
            this.txtFrontLeft = new System.Windows.Forms.TextBox();
            this.txtSubwoofer = new System.Windows.Forms.TextBox();
            this.txtBalanceFrontRear = new System.Windows.Forms.TextBox();
            this.txtBassLeft = new System.Windows.Forms.TextBox();
            this.txtMasterVolume = new System.Windows.Forms.TextBox();
            this.txtMasterBalance = new System.Windows.Forms.TextBox();
            this.txtCenterVolume = new System.Windows.Forms.TextBox();
            this.txtBassRight = new System.Windows.Forms.TextBox();
            this.txtBackRight = new System.Windows.Forms.TextBox();
            this.txtRearBalance = new System.Windows.Forms.TextBox();
            this.txtScrollLegend = new System.Windows.Forms.TextBox();
            this.txtBackLeft = new System.Windows.Forms.TextBox();
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
            this.zMasterVolume = new System.Windows.Forms.HScrollBar();
            this.zBackRight = new System.Windows.Forms.VScrollBar();
            this.zBackLeft = new System.Windows.Forms.VScrollBar();
            this.zCenterVolume = new System.Windows.Forms.VScrollBar();
            this.zBassRight = new System.Windows.Forms.VScrollBar();
            this.zBassLeft = new System.Windows.Forms.VScrollBar();
            this.zMasterBalance = new System.Windows.Forms.HScrollBar();
            this.zRearBalance = new System.Windows.Forms.HScrollBar();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.treeView1.Size = new System.Drawing.Size(723, 733);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // lstSend
            // 
            this.lstSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSend.FormattingEnabled = true;
            this.lstSend.ItemHeight = 15;
            this.lstSend.Location = new System.Drawing.Point(0, 0);
            this.lstSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSend.Name = "lstSend";
            this.lstSend.Size = new System.Drawing.Size(640, 94);
            this.lstSend.TabIndex = 2;
            this.lstSend.SelectedIndexChanged += new System.EventHandler(this.LstSend_SelectedIndexChanged);
            // 
            // lstReceive
            // 
            this.lstReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstReceive.HideSelection = false;
            this.lstReceive.Location = new System.Drawing.Point(0, 103);
            this.lstReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstReceive.Name = "lstReceive";
            this.lstReceive.Size = new System.Drawing.Size(640, 662);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstReceive);
            this.splitContainer1.Panel2.Controls.Add(this.lstSend);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 763);
            this.splitContainer1.SplitterDistance = 737;
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
            this.tabControl1.Size = new System.Drawing.Size(737, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVolume
            // 
            this.tabVolume.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabVolume.Controls.Add(this.label17);
            this.tabVolume.Controls.Add(this.label16);
            this.tabVolume.Controls.Add(this.label9);
            this.tabVolume.Controls.Add(this.chkSEND);
            this.tabVolume.Controls.Add(this.butReset);
            this.tabVolume.Controls.Add(this.txtFrontRight);
            this.tabVolume.Controls.Add(this.txtFrontLeft);
            this.tabVolume.Controls.Add(this.txtSubwoofer);
            this.tabVolume.Controls.Add(this.txtBalanceFrontRear);
            this.tabVolume.Controls.Add(this.txtBassLeft);
            this.tabVolume.Controls.Add(this.txtMasterVolume);
            this.tabVolume.Controls.Add(this.txtMasterBalance);
            this.tabVolume.Controls.Add(this.txtCenterVolume);
            this.tabVolume.Controls.Add(this.txtBassRight);
            this.tabVolume.Controls.Add(this.txtBackRight);
            this.tabVolume.Controls.Add(this.txtRearBalance);
            this.tabVolume.Controls.Add(this.txtScrollLegend);
            this.tabVolume.Controls.Add(this.txtBackLeft);
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
            this.tabVolume.Controls.Add(this.zBackRight);
            this.tabVolume.Controls.Add(this.zBackLeft);
            this.tabVolume.Controls.Add(this.zCenterVolume);
            this.tabVolume.Controls.Add(this.zBassRight);
            this.tabVolume.Controls.Add(this.zBassLeft);
            this.tabVolume.Controls.Add(this.zMasterBalance);
            this.tabVolume.Controls.Add(this.zRearBalance);
            this.tabVolume.Location = new System.Drawing.Point(4, 24);
            this.tabVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVolume.Size = new System.Drawing.Size(729, 735);
            this.tabVolume.TabIndex = 1;
            this.tabVolume.Text = "Volume";
            this.tabVolume.Click += new System.EventHandler(this.TabVolume_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Subwoofer 1";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Front Right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 114);
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
            this.chkSEND.Location = new System.Drawing.Point(631, 22);
            this.chkSEND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSEND.Name = "chkSEND";
            this.chkSEND.Size = new System.Drawing.Size(60, 19);
            this.chkSEND.TabIndex = 33;
            this.chkSEND.Text = "SEND";
            this.toolTip1.SetToolTip(this.chkSEND, "Send commnds to Marantz");
            this.chkSEND.UseVisualStyleBackColor = false;
            this.chkSEND.CheckedChanged += new System.EventHandler(this.chkSEND_CheckedChanged);
            // 
            // butReset
            // 
            this.butReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butReset.BackColor = System.Drawing.SystemColors.Control;
            this.butReset.Location = new System.Drawing.Point(628, 47);
            this.butReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(87, 28);
            this.butReset.TabIndex = 32;
            this.butReset.Text = "RESET";
            this.toolTip1.SetToolTip(this.butReset, "Reset everything to initial values");
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // txtFrontRight
            // 
            this.txtFrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrontRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtFrontRight.Location = new System.Drawing.Point(512, 54);
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
            this.txtFrontLeft.Location = new System.Drawing.Point(140, 54);
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
            this.txtSubwoofer.Location = new System.Drawing.Point(18, 14);
            this.txtSubwoofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubwoofer.Multiline = true;
            this.txtSubwoofer.Name = "txtSubwoofer";
            this.txtSubwoofer.Size = new System.Drawing.Size(57, 56);
            this.txtSubwoofer.TabIndex = 34;
            this.txtSubwoofer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalanceFrontRear
            // 
            this.txtBalanceFrontRear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalanceFrontRear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBalanceFrontRear.Location = new System.Drawing.Point(656, 193);
            this.txtBalanceFrontRear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalanceFrontRear.Multiline = true;
            this.txtBalanceFrontRear.Name = "txtBalanceFrontRear";
            this.txtBalanceFrontRear.Size = new System.Drawing.Size(57, 56);
            this.txtBalanceFrontRear.TabIndex = 29;
            this.txtBalanceFrontRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBassLeft
            // 
            this.txtBassLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBassLeft.BackColor = System.Drawing.Color.LightBlue;
            this.txtBassLeft.Location = new System.Drawing.Point(148, 645);
            this.txtBassLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBassLeft.Multiline = true;
            this.txtBassLeft.Name = "txtBassLeft";
            this.txtBassLeft.Size = new System.Drawing.Size(57, 56);
            this.txtBassLeft.TabIndex = 29;
            this.txtBassLeft.Text = "100\r\n188.8 >\r\n199.9 <";
            this.txtBassLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMasterVolume
            // 
            this.txtMasterVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMasterVolume.BackColor = System.Drawing.Color.Thistle;
            this.txtMasterVolume.Location = new System.Drawing.Point(517, 267);
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
            this.txtMasterBalance.Location = new System.Drawing.Point(517, 368);
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
            this.txtCenterVolume.Location = new System.Drawing.Point(332, 24);
            this.txtCenterVolume.Margin = new System.Windows.Forms.Padding(0);
            this.txtCenterVolume.Multiline = true;
            this.txtCenterVolume.Name = "txtCenterVolume";
            this.txtCenterVolume.Size = new System.Drawing.Size(57, 56);
            this.txtCenterVolume.TabIndex = 29;
            this.txtCenterVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBassRight
            // 
            this.txtBassRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBassRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtBassRight.Location = new System.Drawing.Point(522, 645);
            this.txtBassRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBassRight.Multiline = true;
            this.txtBassRight.Name = "txtBassRight";
            this.txtBassRight.Size = new System.Drawing.Size(57, 56);
            this.txtBassRight.TabIndex = 29;
            this.txtBassRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackRight
            // 
            this.txtBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackRight.BackColor = System.Drawing.Color.LightBlue;
            this.txtBackRight.Location = new System.Drawing.Point(624, 502);
            this.txtBackRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBackRight.Multiline = true;
            this.txtBackRight.Name = "txtBackRight";
            this.txtBackRight.Size = new System.Drawing.Size(57, 56);
            this.txtBackRight.TabIndex = 29;
            this.txtBackRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRearBalance
            // 
            this.txtRearBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRearBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtRearBalance.Location = new System.Drawing.Point(447, 516);
            this.txtRearBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRearBalance.Multiline = true;
            this.txtRearBalance.Name = "txtRearBalance";
            this.txtRearBalance.Size = new System.Drawing.Size(57, 56);
            this.txtRearBalance.TabIndex = 29;
            this.txtRearBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScrollLegend
            // 
            this.txtScrollLegend.BackColor = System.Drawing.Color.DarkGray;
            this.txtScrollLegend.Location = new System.Drawing.Point(66, 186);
            this.txtScrollLegend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScrollLegend.Multiline = true;
            this.txtScrollLegend.Name = "txtScrollLegend";
            this.txtScrollLegend.Size = new System.Drawing.Size(196, 56);
            this.txtScrollLegend.TabIndex = 29;
            // 
            // txtBackLeft
            // 
            this.txtBackLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBackLeft.BackColor = System.Drawing.Color.LightBlue;
            this.txtBackLeft.Location = new System.Drawing.Point(46, 502);
            this.txtBackLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBackLeft.Multiline = true;
            this.txtBackLeft.Name = "txtBackLeft";
            this.txtBackLeft.Size = new System.Drawing.Size(57, 56);
            this.txtBackLeft.TabIndex = 29;
            this.txtBackLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(612, 253);
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
            this.label5.Location = new System.Drawing.Point(116, 704);
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
            this.label10.Location = new System.Drawing.Point(488, 704);
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
            this.label8.Location = new System.Drawing.Point(340, 242);
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
            this.label6.Location = new System.Drawing.Point(146, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Master Balance Left/Right";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(144, 312);
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
            this.label3.Location = new System.Drawing.Point(626, 484);
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
            this.label2.Location = new System.Drawing.Point(16, 484);
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
            this.label1.Location = new System.Drawing.Point(228, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surround Balance";
            // 
            // zBalanceFrontRear
            // 
            this.zBalanceFrontRear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zBalanceFrontRear.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.zBalanceFrontRear.Location = new System.Drawing.Point(631, 88);
            this.zBalanceFrontRear.Name = "zBalanceFrontRear";
            this.zBalanceFrontRear.Size = new System.Drawing.Size(18, 158);
            this.zBalanceFrontRear.TabIndex = 17;
            this.toolTip1.SetToolTip(this.zBalanceFrontRear, "set balance between everything in front of you and everything behind you ");
            this.zBalanceFrontRear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBalanceFrontRear_Scroll);
            // 
            // zMasterVolume
            // 
            this.zMasterVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zMasterVolume.Location = new System.Drawing.Point(148, 332);
            this.zMasterVolume.Name = "zMasterVolume";
            this.zMasterVolume.Size = new System.Drawing.Size(428, 18);
            this.zMasterVolume.TabIndex = 16;
            this.zMasterVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZMasterVolume_Scroll);
            // 
            // zBackRight
            // 
            this.zBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zBackRight.Location = new System.Drawing.Point(692, 502);
            this.zBackRight.Name = "zBackRight";
            this.zBackRight.Size = new System.Drawing.Size(18, 196);
            this.zBackRight.TabIndex = 15;
            this.zBackRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBackRight_Scroll);
            // 
            // zBackLeft
            // 
            this.zBackLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zBackLeft.Location = new System.Drawing.Point(20, 502);
            this.zBackLeft.Name = "zBackLeft";
            this.zBackLeft.Size = new System.Drawing.Size(18, 196);
            this.zBackLeft.TabIndex = 14;
            this.zBackLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBackLeft_Scroll);
            // 
            // zCenterVolume
            // 
            this.zCenterVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zCenterVolume.Location = new System.Drawing.Point(350, 88);
            this.zCenterVolume.Name = "zCenterVolume";
            this.zCenterVolume.Size = new System.Drawing.Size(19, 151);
            this.zCenterVolume.TabIndex = 13;
            this.zCenterVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZCenterVolume_Scroll);
            // 
            // zBassRight
            // 
            this.zBassRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zBassRight.Location = new System.Drawing.Point(588, 503);
            this.zBassRight.Name = "zBassRight";
            this.zBassRight.Size = new System.Drawing.Size(18, 196);
            this.zBassRight.TabIndex = 12;
            this.zBassRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBassRight_Scroll);
            // 
            // zBassLeft
            // 
            this.zBassLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zBassLeft.Location = new System.Drawing.Point(120, 503);
            this.zBassLeft.Name = "zBassLeft";
            this.zBassLeft.Size = new System.Drawing.Size(18, 196);
            this.zBassLeft.TabIndex = 9;
            this.zBassLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZBassLeft_Scroll);
            // 
            // zMasterBalance
            // 
            this.zMasterBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zMasterBalance.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.zMasterBalance.Location = new System.Drawing.Point(148, 431);
            this.zMasterBalance.Name = "zMasterBalance";
            this.zMasterBalance.Size = new System.Drawing.Size(428, 18);
            this.zMasterBalance.TabIndex = 8;
            this.toolTip1.SetToolTip(this.zMasterBalance, "change balance between everything on the left-side and everything on the right si" +
        "de");
            this.zMasterBalance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZMasterBalance_Scroll);
            // 
            // zRearBalance
            // 
            this.zRearBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zRearBalance.Location = new System.Drawing.Point(228, 580);
            this.zRearBalance.Name = "zRearBalance";
            this.zRearBalance.Size = new System.Drawing.Size(277, 18);
            this.zRearBalance.TabIndex = 7;
            this.toolTip1.SetToolTip(this.zRearBalance, "set balance between left-surround and right-surround");
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
            this.tabCommands.Size = new System.Drawing.Size(729, 737);
            this.tabCommands.TabIndex = 0;
            this.tabCommands.Text = "Commands";
            // 
            // frmControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 763);
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
        private System.Windows.Forms.HScrollBar zMasterVolume;
        private System.Windows.Forms.VScrollBar zBackRight;
        private System.Windows.Forms.VScrollBar zBackLeft;
        private System.Windows.Forms.VScrollBar zCenterVolume;
        private System.Windows.Forms.VScrollBar zBassRight;
        private System.Windows.Forms.VScrollBar zBassLeft;
        private System.Windows.Forms.HScrollBar zMasterBalance;
        private System.Windows.Forms.HScrollBar zRearBalance;
        private System.Windows.Forms.TextBox txtBalanceFrontRear;
        private System.Windows.Forms.TextBox txtBassLeft;
        private System.Windows.Forms.TextBox txtMasterVolume;
        private System.Windows.Forms.TextBox txtMasterBalance;
        private System.Windows.Forms.TextBox txtCenterVolume;
        private System.Windows.Forms.TextBox txtBassRight;
        private System.Windows.Forms.TextBox txtBackRight;
        private System.Windows.Forms.TextBox txtRearBalance;
        private System.Windows.Forms.TextBox txtBackLeft;
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
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtScrollLegend;
        private System.Windows.Forms.CheckBox chkSEND;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
    }
}