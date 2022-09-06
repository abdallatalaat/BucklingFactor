
namespace BucklingFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ga_isdirect = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a_stiffness = new System.Windows.Forms.GroupBox();
            this.a_beam2_End = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.a_beam1_End = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.a_beam2_L = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.a_beam2_I = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.a_beam1_L = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.a_beam1_I = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a_col2_L = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a_col2_I = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ga_direct = new System.Windows.Forms.TextBox();
            this.ga_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_stiffness = new System.Windows.Forms.GroupBox();
            this.b_beam2_End = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.b_beam1_End = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.b_beam2_L = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.b_beam2_I = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.b_beam1_L = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.b_beam1_I = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.b_col2_L = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.b_col2_I = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gb_isdirect = new System.Windows.Forms.RadioButton();
            this.gb_direct = new System.Windows.Forms.TextBox();
            this.gb_label = new System.Windows.Forms.Label();
            this.m_stiffness = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.m_L = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.m_I = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.is_no_sway = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.k_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.a_stiffness.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.b_stiffness.SuspendLayout();
            this.m_stiffness.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ga_isdirect
            // 
            this.ga_isdirect.AutoSize = true;
            this.ga_isdirect.Checked = true;
            this.ga_isdirect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ga_isdirect.Location = new System.Drawing.Point(5, 19);
            this.ga_isdirect.Name = "ga_isdirect";
            this.ga_isdirect.Size = new System.Drawing.Size(67, 17);
            this.ga_isdirect.TabIndex = 20;
            this.ga_isdirect.Text = "Input Ga";
            this.ga_isdirect.UseVisualStyleBackColor = true;
            this.ga_isdirect.CheckedChanged += new System.EventHandler(this.ga_isdirect_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.a_stiffness);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.ga_isdirect);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End A";
            // 
            // a_stiffness
            // 
            this.a_stiffness.Controls.Add(this.a_beam2_End);
            this.a_stiffness.Controls.Add(this.label26);
            this.a_stiffness.Controls.Add(this.a_beam1_End);
            this.a_stiffness.Controls.Add(this.label1);
            this.a_stiffness.Controls.Add(this.label10);
            this.a_stiffness.Controls.Add(this.a_beam2_L);
            this.a_stiffness.Controls.Add(this.label11);
            this.a_stiffness.Controls.Add(this.label12);
            this.a_stiffness.Controls.Add(this.a_beam2_I);
            this.a_stiffness.Controls.Add(this.label13);
            this.a_stiffness.Controls.Add(this.label6);
            this.a_stiffness.Controls.Add(this.a_beam1_L);
            this.a_stiffness.Controls.Add(this.label7);
            this.a_stiffness.Controls.Add(this.label8);
            this.a_stiffness.Controls.Add(this.a_beam1_I);
            this.a_stiffness.Controls.Add(this.label9);
            this.a_stiffness.Controls.Add(this.label4);
            this.a_stiffness.Controls.Add(this.a_col2_L);
            this.a_stiffness.Controls.Add(this.label5);
            this.a_stiffness.Controls.Add(this.label3);
            this.a_stiffness.Controls.Add(this.a_col2_I);
            this.a_stiffness.Controls.Add(this.label2);
            this.a_stiffness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.a_stiffness.Enabled = false;
            this.a_stiffness.Location = new System.Drawing.Point(3, 59);
            this.a_stiffness.Name = "a_stiffness";
            this.a_stiffness.Size = new System.Drawing.Size(195, 255);
            this.a_stiffness.TabIndex = 2;
            this.a_stiffness.TabStop = false;
            // 
            // a_beam2_End
            // 
            this.a_beam2_End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_beam2_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_beam2_End.FormattingEnabled = true;
            this.a_beam2_End.ItemHeight = 13;
            this.a_beam2_End.Items.AddRange(new object[] {
            " ",
            "Hinged",
            "Fixed"});
            this.a_beam2_End.Location = new System.Drawing.Point(103, 224);
            this.a_beam2_End.Name = "a_beam2_End";
            this.a_beam2_End.Size = new System.Drawing.Size(50, 21);
            this.a_beam2_End.TabIndex = 61;
            this.a_beam2_End.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 227);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "Beam 2 End";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_beam1_End
            // 
            this.a_beam1_End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_beam1_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_beam1_End.FormattingEnabled = true;
            this.a_beam1_End.Items.AddRange(new object[] {
            " ",
            "Hinged",
            "Fixed"});
            this.a_beam1_End.Location = new System.Drawing.Point(103, 134);
            this.a_beam1_End.Name = "a_beam1_End";
            this.a_beam1_End.Size = new System.Drawing.Size(50, 21);
            this.a_beam1_End.TabIndex = 6;
            this.a_beam1_End.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Beam 1 End";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "cm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_beam2_L
            // 
            this.a_beam2_L.Location = new System.Drawing.Point(103, 197);
            this.a_beam2_L.Name = "a_beam2_L";
            this.a_beam2_L.Size = new System.Drawing.Size(50, 20);
            this.a_beam2_L.TabIndex = 8;
            this.a_beam2_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Beam 2 Length";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "cm4";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_beam2_I
            // 
            this.a_beam2_I.Location = new System.Drawing.Point(103, 171);
            this.a_beam2_I.Name = "a_beam2_I";
            this.a_beam2_I.Size = new System.Drawing.Size(50, 20);
            this.a_beam2_I.TabIndex = 7;
            this.a_beam2_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Beam 2 Inertia";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "cm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_beam1_L
            // 
            this.a_beam1_L.Location = new System.Drawing.Point(103, 107);
            this.a_beam1_L.Name = "a_beam1_L";
            this.a_beam1_L.Size = new System.Drawing.Size(50, 20);
            this.a_beam1_L.TabIndex = 5;
            this.a_beam1_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Beam 1 Length";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "cm4";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_beam1_I
            // 
            this.a_beam1_I.Location = new System.Drawing.Point(103, 81);
            this.a_beam1_I.Name = "a_beam1_I";
            this.a_beam1_I.Size = new System.Drawing.Size(50, 20);
            this.a_beam1_I.TabIndex = 4;
            this.a_beam1_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Beam 1 Inertia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "cm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_col2_L
            // 
            this.a_col2_L.Location = new System.Drawing.Point(103, 45);
            this.a_col2_L.Name = "a_col2_L";
            this.a_col2_L.Size = new System.Drawing.Size(50, 20);
            this.a_col2_L.TabIndex = 3;
            this.a_col2_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Column 2 Length";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "cm4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a_col2_I
            // 
            this.a_col2_I.Location = new System.Drawing.Point(103, 19);
            this.a_col2_I.Name = "a_col2_I";
            this.a_col2_I.Size = new System.Drawing.Size(50, 20);
            this.a_col2_I.TabIndex = 2;
            this.a_col2_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Column 2 Inertia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(5, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.Text = "Input Stiffness Properties";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ga_direct
            // 
            this.ga_direct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ga_direct.Location = new System.Drawing.Point(456, 178);
            this.ga_direct.Name = "ga_direct";
            this.ga_direct.Size = new System.Drawing.Size(50, 20);
            this.ga_direct.TabIndex = 0;
            this.ga_direct.TextChanged += new System.EventHandler(this.update_k);
            // 
            // ga_label
            // 
            this.ga_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ga_label.AutoSize = true;
            this.ga_label.Location = new System.Drawing.Point(430, 182);
            this.ga_label.Name = "ga_label";
            this.ga_label.Size = new System.Drawing.Size(20, 13);
            this.ga_label.TabIndex = 1;
            this.ga_label.Text = "Ga";
            this.ga_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_stiffness);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.gb_isdirect);
            this.groupBox2.Location = new System.Drawing.Point(215, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 317);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End B";
            // 
            // b_stiffness
            // 
            this.b_stiffness.Controls.Add(this.b_beam2_End);
            this.b_stiffness.Controls.Add(this.label14);
            this.b_stiffness.Controls.Add(this.b_beam1_End);
            this.b_stiffness.Controls.Add(this.label15);
            this.b_stiffness.Controls.Add(this.label16);
            this.b_stiffness.Controls.Add(this.b_beam2_L);
            this.b_stiffness.Controls.Add(this.label17);
            this.b_stiffness.Controls.Add(this.label18);
            this.b_stiffness.Controls.Add(this.b_beam2_I);
            this.b_stiffness.Controls.Add(this.label19);
            this.b_stiffness.Controls.Add(this.label20);
            this.b_stiffness.Controls.Add(this.b_beam1_L);
            this.b_stiffness.Controls.Add(this.label21);
            this.b_stiffness.Controls.Add(this.label22);
            this.b_stiffness.Controls.Add(this.b_beam1_I);
            this.b_stiffness.Controls.Add(this.label23);
            this.b_stiffness.Controls.Add(this.label24);
            this.b_stiffness.Controls.Add(this.b_col2_L);
            this.b_stiffness.Controls.Add(this.label25);
            this.b_stiffness.Controls.Add(this.label31);
            this.b_stiffness.Controls.Add(this.b_col2_I);
            this.b_stiffness.Controls.Add(this.label32);
            this.b_stiffness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_stiffness.Enabled = false;
            this.b_stiffness.Location = new System.Drawing.Point(3, 59);
            this.b_stiffness.Name = "b_stiffness";
            this.b_stiffness.Size = new System.Drawing.Size(195, 255);
            this.b_stiffness.TabIndex = 2;
            this.b_stiffness.TabStop = false;
            // 
            // b_beam2_End
            // 
            this.b_beam2_End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_beam2_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.b_beam2_End.FormattingEnabled = true;
            this.b_beam2_End.ItemHeight = 13;
            this.b_beam2_End.Items.AddRange(new object[] {
            " ",
            "Hinged",
            "Fixed"});
            this.b_beam2_End.Location = new System.Drawing.Point(103, 224);
            this.b_beam2_End.Name = "b_beam2_End";
            this.b_beam2_End.Size = new System.Drawing.Size(50, 21);
            this.b_beam2_End.TabIndex = 83;
            this.b_beam2_End.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 82;
            this.label14.Text = "Beam 2 End";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_beam1_End
            // 
            this.b_beam1_End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_beam1_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.b_beam1_End.FormattingEnabled = true;
            this.b_beam1_End.ItemHeight = 13;
            this.b_beam1_End.Items.AddRange(new object[] {
            " ",
            "Hinged",
            "Fixed"});
            this.b_beam1_End.Location = new System.Drawing.Point(103, 134);
            this.b_beam1_End.Name = "b_beam1_End";
            this.b_beam1_End.Size = new System.Drawing.Size(50, 21);
            this.b_beam1_End.TabIndex = 81;
            this.b_beam1_End.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Beam 1 End";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(159, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "cm";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_beam2_L
            // 
            this.b_beam2_L.Location = new System.Drawing.Point(103, 197);
            this.b_beam2_L.Name = "b_beam2_L";
            this.b_beam2_L.Size = new System.Drawing.Size(50, 20);
            this.b_beam2_L.TabIndex = 16;
            this.b_beam2_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 77;
            this.label17.Text = "Beam 2 Length";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(159, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "cm4";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_beam2_I
            // 
            this.b_beam2_I.Location = new System.Drawing.Point(103, 171);
            this.b_beam2_I.Name = "b_beam2_I";
            this.b_beam2_I.Size = new System.Drawing.Size(50, 20);
            this.b_beam2_I.TabIndex = 15;
            this.b_beam2_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Beam 2 Inertia";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "cm";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_beam1_L
            // 
            this.b_beam1_L.Location = new System.Drawing.Point(103, 107);
            this.b_beam1_L.Name = "b_beam1_L";
            this.b_beam1_L.Size = new System.Drawing.Size(50, 20);
            this.b_beam1_L.TabIndex = 13;
            this.b_beam1_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 71;
            this.label21.Text = "Beam 1 Length";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(159, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 70;
            this.label22.Text = "cm4";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_beam1_I
            // 
            this.b_beam1_I.Location = new System.Drawing.Point(103, 81);
            this.b_beam1_I.Name = "b_beam1_I";
            this.b_beam1_I.Size = new System.Drawing.Size(50, 20);
            this.b_beam1_I.TabIndex = 12;
            this.b_beam1_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "Beam 1 Inertia";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(159, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 67;
            this.label24.Text = "cm";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_col2_L
            // 
            this.b_col2_L.Location = new System.Drawing.Point(103, 45);
            this.b_col2_L.Name = "b_col2_L";
            this.b_col2_L.Size = new System.Drawing.Size(50, 20);
            this.b_col2_L.TabIndex = 11;
            this.b_col2_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "Column 2 Length";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(159, 22);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 13);
            this.label31.TabIndex = 64;
            this.label31.Text = "cm4";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_col2_I
            // 
            this.b_col2_I.Location = new System.Drawing.Point(103, 19);
            this.b_col2_I.Name = "b_col2_I";
            this.b_col2_I.Size = new System.Drawing.Size(50, 20);
            this.b_col2_I.TabIndex = 10;
            this.b_col2_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(11, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 13);
            this.label32.TabIndex = 62;
            this.label32.Text = "Column 2 Inertia";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(5, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Input Stiffness Properties";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gb_isdirect
            // 
            this.gb_isdirect.AutoSize = true;
            this.gb_isdirect.Checked = true;
            this.gb_isdirect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gb_isdirect.Location = new System.Drawing.Point(5, 19);
            this.gb_isdirect.Name = "gb_isdirect";
            this.gb_isdirect.Size = new System.Drawing.Size(67, 17);
            this.gb_isdirect.TabIndex = 22;
            this.gb_isdirect.Text = "Input Gb";
            this.gb_isdirect.UseVisualStyleBackColor = true;
            this.gb_isdirect.CheckedChanged += new System.EventHandler(this.gb_isdirect_CheckedChanged);
            // 
            // gb_direct
            // 
            this.gb_direct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_direct.Location = new System.Drawing.Point(456, 204);
            this.gb_direct.Name = "gb_direct";
            this.gb_direct.Size = new System.Drawing.Size(50, 20);
            this.gb_direct.TabIndex = 1;
            this.gb_direct.TextChanged += new System.EventHandler(this.update_k);
            // 
            // gb_label
            // 
            this.gb_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_label.AutoSize = true;
            this.gb_label.Location = new System.Drawing.Point(430, 208);
            this.gb_label.Name = "gb_label";
            this.gb_label.Size = new System.Drawing.Size(20, 13);
            this.gb_label.TabIndex = 1;
            this.gb_label.Text = "Gb";
            this.gb_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_stiffness
            // 
            this.m_stiffness.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_stiffness.Controls.Add(this.label27);
            this.m_stiffness.Controls.Add(this.m_L);
            this.m_stiffness.Controls.Add(this.label28);
            this.m_stiffness.Controls.Add(this.label29);
            this.m_stiffness.Controls.Add(this.m_I);
            this.m_stiffness.Controls.Add(this.label30);
            this.m_stiffness.Enabled = false;
            this.m_stiffness.Location = new System.Drawing.Point(8, 322);
            this.m_stiffness.Name = "m_stiffness";
            this.m_stiffness.Size = new System.Drawing.Size(408, 46);
            this.m_stiffness.TabIndex = 5;
            this.m_stiffness.TabStop = false;
            this.m_stiffness.Text = "Member Stiffness Properties";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(371, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 13);
            this.label27.TabIndex = 63;
            this.label27.Text = "cm";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_L
            // 
            this.m_L.Location = new System.Drawing.Point(315, 20);
            this.m_L.Name = "m_L";
            this.m_L.Size = new System.Drawing.Size(50, 20);
            this.m_L.TabIndex = 19;
            this.m_L.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(223, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 13);
            this.label28.TabIndex = 61;
            this.label28.Text = "Member Length";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(160, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 13);
            this.label29.TabIndex = 60;
            this.label29.Text = "cm4";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_I
            // 
            this.m_I.BackColor = System.Drawing.SystemColors.Window;
            this.m_I.Location = new System.Drawing.Point(104, 20);
            this.m_I.Name = "m_I";
            this.m_I.Size = new System.Drawing.Size(50, 20);
            this.m_I.TabIndex = 18;
            this.m_I.TextChanged += new System.EventHandler(this.update_k);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 13);
            this.label30.TabIndex = 58;
            this.label30.Text = "Member Inertia";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.is_no_sway);
            this.groupBox3.Location = new System.Drawing.Point(422, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 53);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sway Case";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButton4.Location = new System.Drawing.Point(3, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(194, 17);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.Text = "Sway Permitted (Unbraced)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.update_k);
            // 
            // is_no_sway
            // 
            this.is_no_sway.AutoSize = true;
            this.is_no_sway.Checked = true;
            this.is_no_sway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.is_no_sway.Dock = System.Windows.Forms.DockStyle.Top;
            this.is_no_sway.Location = new System.Drawing.Point(3, 16);
            this.is_no_sway.Name = "is_no_sway";
            this.is_no_sway.Size = new System.Drawing.Size(194, 17);
            this.is_no_sway.TabIndex = 24;
            this.is_no_sway.Text = "Sway Prevented (Braced)";
            this.is_no_sway.UseVisualStyleBackColor = true;
            this.is_no_sway.CheckedChanged += new System.EventHandler(this.update_k);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BucklingFactor.Properties.Resources.Buckling_figure;
            this.pictureBox1.Location = new System.Drawing.Point(422, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(531, 178);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 25);
            this.label33.TabIndex = 66;
            this.label33.Text = "k = ";
            // 
            // k_label
            // 
            this.k_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.k_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.k_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_label.ForeColor = System.Drawing.Color.Red;
            this.k_label.Location = new System.Drawing.Point(531, 199);
            this.k_label.Name = "k_label";
            this.k_label.Size = new System.Drawing.Size(85, 25);
            this.k_label.TabIndex = 67;
            this.k_label.Text = "0.0000";
            this.k_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.k_label, "Copy to Clipboard");
            this.k_label.Click += new System.EventHandler(this.k_label_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(515, 355);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(112, 13);
            this.label34.TabIndex = 68;
            this.label34.Text = "Abdalla Talaat© 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(629, 373);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.k_label);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.gb_direct);
            this.Controls.Add(this.gb_label);
            this.Controls.Add(this.ga_direct);
            this.Controls.Add(this.ga_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.m_stiffness);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BucklingFactor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.a_stiffness.ResumeLayout(false);
            this.a_stiffness.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.b_stiffness.ResumeLayout(false);
            this.b_stiffness.PerformLayout();
            this.m_stiffness.ResumeLayout(false);
            this.m_stiffness.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ga_isdirect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ga_direct;
        private System.Windows.Forms.Label ga_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox a_stiffness;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox a_beam2_L;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox a_beam2_I;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox a_beam1_L;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox a_beam1_I;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a_col2_L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a_col2_I;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox b_stiffness;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox gb_direct;
        private System.Windows.Forms.Label gb_label;
        private System.Windows.Forms.RadioButton gb_isdirect;
        private System.Windows.Forms.GroupBox m_stiffness;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox m_L;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox m_I;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton is_no_sway;
        private System.Windows.Forms.ComboBox a_beam1_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox a_beam2_End;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox b_beam2_End;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox b_beam1_End;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox b_beam2_L;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox b_beam2_I;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox b_beam1_L;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox b_beam1_I;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox b_col2_L;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox b_col2_I;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label k_label;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label34;

        public void Calculate_k()
        {
            
            double G_a = 0;
            double G_b = 0;
            double k_value = 0;
            double col1_ratio = 0;


            // Define Ga case
            if (ga_isdirect.Checked) { try { G_a = double.Parse(ga_direct.Text); } catch { } }
            else
            {
                
                double a_col2_ratio = 0;
                double a_beam1_ratio = 0;
                double a_beam2_ratio = 0;

                try { col1_ratio = double.Parse(m_I.Text) / double.Parse(m_L.Text); } catch { }
                try { a_col2_ratio = double.Parse(a_col2_I.Text) / double.Parse(a_col2_L.Text); } catch { }
                try { a_beam1_ratio = get_beam_factor(a_beam1_End) * double.Parse(a_beam1_I.Text) / double.Parse(a_beam1_L.Text); } catch { }
                try { a_beam2_ratio = get_beam_factor(a_beam2_End) * double.Parse(a_beam2_I.Text) / double.Parse(a_beam2_L.Text); } catch { }


                try { G_a = (col1_ratio+ a_col2_ratio)/(a_beam1_ratio+a_beam2_ratio); } catch { }
                if ((a_beam1_ratio + a_beam2_ratio) == 0) { G_a = 1000; }

                


            }
            // Define Gb case
            if (gb_isdirect.Checked) { try { G_b = double.Parse(gb_direct.Text); } catch { } }
            else
            {
                double b_col2_ratio = 0;
                double b_beam1_ratio = 0;
                double b_beam2_ratio = 0;

                try { col1_ratio = double.Parse(m_I.Text) / double.Parse(m_L.Text); } catch { }
                try { b_col2_ratio = double.Parse(b_col2_I.Text) / double.Parse(b_col2_L.Text); } catch { }
                try { b_beam1_ratio = get_beam_factor(b_beam1_End) * double.Parse(b_beam1_I.Text) / double.Parse(b_beam1_L.Text); } catch { }
                try { b_beam2_ratio = get_beam_factor(b_beam2_End) * double.Parse(b_beam2_I.Text) / double.Parse(b_beam2_L.Text); } catch { }


                try { G_b = (col1_ratio + b_col2_ratio) / (b_beam1_ratio + b_beam2_ratio); } catch { }
                if ((b_beam1_ratio + b_beam2_ratio) == 0) { G_b = 1000; }
            }
            
            if (is_no_sway.Checked) { k_value = Program.Bisector(double.Parse(k_label.Text), Program.Buckling_Equation_NoSway, new double[] { G_a, G_b }, new double[] { 0.5, 1 }); }
            else { k_value = Program.Bisector(double.Parse(k_label.Text), Program.Buckling_Equation_Sway, new double[] { G_a, G_b }, new double[] { 1, 1000 });  }

            if (!ga_isdirect.Checked) { ga_direct.Text = G_a.ToString(); }
            if (!gb_isdirect.Checked) { gb_direct.Text = G_b.ToString(); }
            k_label.Text = string.Format("{0:0.0000}", k_value);
        }

        double get_beam_factor(System.Windows.Forms.ComboBox c)
        {
            if (is_no_sway.Checked)
            {
                if (c.Text == "Fixed") { return 2; }
                else if(c.Text == "Hinged") { return 1.5; }
                
            }
            else
            {
                if (c.Text == "Fixed") { return 0.5; }
                else if (c.Text == "Hinged") { return 0.75; }
            }
            return 1;
            
        }
    }
}

