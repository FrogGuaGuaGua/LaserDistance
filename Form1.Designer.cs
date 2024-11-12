namespace LaserDistance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            COM_comboBox = new ComboBox();
            openPortButton = new Button();
            label2 = new Label();
            baudRate_comboBox = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            setZero_button = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            zero_textBox1 = new TextBox();
            current_textBox1 = new TextBox();
            diff_textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            zero_textBox2 = new TextBox();
            current_textBox2 = new TextBox();
            diff_textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            zero_textBox3 = new TextBox();
            current_textBox3 = new TextBox();
            diff_textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            zero_textBox4 = new TextBox();
            current_textBox4 = new TextBox();
            diff_textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox5 = new GroupBox();
            zero_textBox5 = new TextBox();
            current_textBox5 = new TextBox();
            diff_textBox5 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox6 = new GroupBox();
            zero_textBox6 = new TextBox();
            current_textBox6 = new TextBox();
            diff_textBox6 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            qualityJudge_textBox = new TextBox();
            average_textBox = new TextBox();
            variance_textBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label23 = new Label();
            help_button = new Button();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "COM号：";
            // 
            // COM_comboBox
            // 
            COM_comboBox.FormattingEnabled = true;
            COM_comboBox.Location = new Point(69, 12);
            COM_comboBox.Name = "COM_comboBox";
            COM_comboBox.Size = new Size(87, 25);
            COM_comboBox.TabIndex = 1;
            // 
            // openPortButton
            // 
            openPortButton.Location = new Point(389, 13);
            openPortButton.Name = "openPortButton";
            openPortButton.Size = new Size(75, 23);
            openPortButton.TabIndex = 2;
            openPortButton.Text = "打开";
            openPortButton.UseVisualStyleBackColor = true;
            openPortButton.Click += openPortButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 16);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "波特率：";
            // 
            // baudRate_comboBox
            // 
            baudRate_comboBox.FormattingEnabled = true;
            baudRate_comboBox.Location = new Point(239, 12);
            baudRate_comboBox.Name = "baudRate_comboBox";
            baudRate_comboBox.Size = new Size(121, 25);
            baudRate_comboBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(510, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // setZero_button
            // 
            setZero_button.Location = new Point(13, 81);
            setZero_button.Name = "setZero_button";
            setZero_button.Size = new Size(143, 23);
            setZero_button.TabIndex = 6;
            setZero_button.Text = "将当前读数设为零点";
            setZero_button.UseVisualStyleBackColor = true;
            setZero_button.Click += setZero_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 53);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 7;
            label3.Text = "零点";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 8;
            label4.Text = "实时读数";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 18);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 9;
            label5.Text = "差值";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(zero_textBox1);
            groupBox1.Controls.Add(current_textBox1);
            groupBox1.Controls.Add(diff_textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(13, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 76);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "传感器1";
            // 
            // zero_textBox1
            // 
            zero_textBox1.Location = new Point(68, 53);
            zero_textBox1.MaximumSize = new Size(50, 17);
            zero_textBox1.MinimumSize = new Size(40, 17);
            zero_textBox1.Name = "zero_textBox1";
            zero_textBox1.Size = new Size(50, 17);
            zero_textBox1.TabIndex = 10;
            zero_textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox1
            // 
            current_textBox1.Location = new Point(68, 36);
            current_textBox1.MaximumSize = new Size(50, 17);
            current_textBox1.MinimumSize = new Size(40, 17);
            current_textBox1.Name = "current_textBox1";
            current_textBox1.Size = new Size(50, 17);
            current_textBox1.TabIndex = 10;
            current_textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox1
            // 
            diff_textBox1.Location = new Point(68, 18);
            diff_textBox1.MaximumSize = new Size(50, 17);
            diff_textBox1.MinimumSize = new Size(40, 0);
            diff_textBox1.Name = "diff_textBox1";
            diff_textBox1.Size = new Size(50, 17);
            diff_textBox1.TabIndex = 10;
            diff_textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(zero_textBox2);
            groupBox2.Controls.Add(current_textBox2);
            groupBox2.Controls.Add(diff_textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(188, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 76);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "传感器2";
            // 
            // zero_textBox2
            // 
            zero_textBox2.Location = new Point(68, 53);
            zero_textBox2.MaximumSize = new Size(50, 17);
            zero_textBox2.MinimumSize = new Size(40, 17);
            zero_textBox2.Name = "zero_textBox2";
            zero_textBox2.Size = new Size(50, 17);
            zero_textBox2.TabIndex = 10;
            zero_textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox2
            // 
            current_textBox2.Location = new Point(68, 36);
            current_textBox2.MaximumSize = new Size(50, 17);
            current_textBox2.MinimumSize = new Size(40, 17);
            current_textBox2.Name = "current_textBox2";
            current_textBox2.Size = new Size(50, 17);
            current_textBox2.TabIndex = 10;
            current_textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox2
            // 
            diff_textBox2.Location = new Point(68, 18);
            diff_textBox2.MaximumSize = new Size(50, 17);
            diff_textBox2.MinimumSize = new Size(40, 0);
            diff_textBox2.Name = "diff_textBox2";
            diff_textBox2.Size = new Size(50, 17);
            diff_textBox2.TabIndex = 10;
            diff_textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 18);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 9;
            label6.Text = "差值";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 53);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 7;
            label7.Text = "零点";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 36);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 8;
            label8.Text = "实时读数";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zero_textBox3);
            groupBox3.Controls.Add(current_textBox3);
            groupBox3.Controls.Add(diff_textBox3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(356, 115);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(139, 76);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "传感器3";
            // 
            // zero_textBox3
            // 
            zero_textBox3.Location = new Point(68, 53);
            zero_textBox3.MaximumSize = new Size(50, 17);
            zero_textBox3.MinimumSize = new Size(40, 17);
            zero_textBox3.Name = "zero_textBox3";
            zero_textBox3.Size = new Size(50, 17);
            zero_textBox3.TabIndex = 10;
            zero_textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox3
            // 
            current_textBox3.Location = new Point(68, 36);
            current_textBox3.MaximumSize = new Size(50, 17);
            current_textBox3.MinimumSize = new Size(40, 17);
            current_textBox3.Name = "current_textBox3";
            current_textBox3.Size = new Size(50, 17);
            current_textBox3.TabIndex = 10;
            current_textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox3
            // 
            diff_textBox3.Location = new Point(68, 18);
            diff_textBox3.MaximumSize = new Size(50, 17);
            diff_textBox3.MinimumSize = new Size(40, 0);
            diff_textBox3.Name = "diff_textBox3";
            diff_textBox3.Size = new Size(50, 17);
            diff_textBox3.TabIndex = 10;
            diff_textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 18);
            label9.Name = "label9";
            label9.Size = new Size(32, 17);
            label9.TabIndex = 9;
            label9.Text = "差值";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 53);
            label10.Name = "label10";
            label10.Size = new Size(32, 17);
            label10.TabIndex = 7;
            label10.Text = "零点";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 36);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 8;
            label11.Text = "实时读数";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(zero_textBox4);
            groupBox4.Controls.Add(current_textBox4);
            groupBox4.Controls.Add(diff_textBox4);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(13, 207);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(139, 76);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "传感器4";
            // 
            // zero_textBox4
            // 
            zero_textBox4.Location = new Point(68, 53);
            zero_textBox4.MaximumSize = new Size(50, 17);
            zero_textBox4.MinimumSize = new Size(40, 17);
            zero_textBox4.Name = "zero_textBox4";
            zero_textBox4.Size = new Size(50, 17);
            zero_textBox4.TabIndex = 10;
            zero_textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox4
            // 
            current_textBox4.Location = new Point(68, 36);
            current_textBox4.MaximumSize = new Size(50, 17);
            current_textBox4.MinimumSize = new Size(40, 17);
            current_textBox4.Name = "current_textBox4";
            current_textBox4.Size = new Size(50, 17);
            current_textBox4.TabIndex = 10;
            current_textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox4
            // 
            diff_textBox4.Location = new Point(68, 19);
            diff_textBox4.MaximumSize = new Size(50, 17);
            diff_textBox4.MinimumSize = new Size(40, 0);
            diff_textBox4.Name = "diff_textBox4";
            diff_textBox4.Size = new Size(50, 17);
            diff_textBox4.TabIndex = 10;
            diff_textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 19);
            label12.Name = "label12";
            label12.Size = new Size(32, 17);
            label12.TabIndex = 9;
            label12.Text = "差值";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 53);
            label13.Name = "label13";
            label13.Size = new Size(32, 17);
            label13.TabIndex = 7;
            label13.Text = "零点";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 36);
            label14.Name = "label14";
            label14.Size = new Size(56, 17);
            label14.TabIndex = 8;
            label14.Text = "实时读数";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(zero_textBox5);
            groupBox5.Controls.Add(current_textBox5);
            groupBox5.Controls.Add(diff_textBox5);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label17);
            groupBox5.Location = new Point(188, 207);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(139, 76);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "传感器5";
            // 
            // zero_textBox5
            // 
            zero_textBox5.Location = new Point(68, 53);
            zero_textBox5.MaximumSize = new Size(50, 17);
            zero_textBox5.MinimumSize = new Size(40, 17);
            zero_textBox5.Name = "zero_textBox5";
            zero_textBox5.Size = new Size(50, 17);
            zero_textBox5.TabIndex = 10;
            zero_textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox5
            // 
            current_textBox5.Location = new Point(68, 36);
            current_textBox5.MaximumSize = new Size(50, 17);
            current_textBox5.MinimumSize = new Size(40, 17);
            current_textBox5.Name = "current_textBox5";
            current_textBox5.Size = new Size(50, 17);
            current_textBox5.TabIndex = 10;
            current_textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox5
            // 
            diff_textBox5.Location = new Point(68, 19);
            diff_textBox5.MaximumSize = new Size(50, 17);
            diff_textBox5.MinimumSize = new Size(40, 0);
            diff_textBox5.Name = "diff_textBox5";
            diff_textBox5.Size = new Size(50, 17);
            diff_textBox5.TabIndex = 10;
            diff_textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(30, 19);
            label15.Name = "label15";
            label15.Size = new Size(32, 17);
            label15.TabIndex = 9;
            label15.Text = "差值";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(30, 53);
            label16.Name = "label16";
            label16.Size = new Size(32, 17);
            label16.TabIndex = 7;
            label16.Text = "零点";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 36);
            label17.Name = "label17";
            label17.Size = new Size(56, 17);
            label17.TabIndex = 8;
            label17.Text = "实时读数";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(zero_textBox6);
            groupBox6.Controls.Add(current_textBox6);
            groupBox6.Controls.Add(diff_textBox6);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label19);
            groupBox6.Controls.Add(label20);
            groupBox6.Location = new Point(356, 207);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(139, 76);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "传感器6";
            // 
            // zero_textBox6
            // 
            zero_textBox6.Location = new Point(68, 53);
            zero_textBox6.MaximumSize = new Size(50, 17);
            zero_textBox6.MinimumSize = new Size(40, 17);
            zero_textBox6.Name = "zero_textBox6";
            zero_textBox6.Size = new Size(50, 17);
            zero_textBox6.TabIndex = 10;
            zero_textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // current_textBox6
            // 
            current_textBox6.Location = new Point(68, 36);
            current_textBox6.MaximumSize = new Size(50, 17);
            current_textBox6.MinimumSize = new Size(40, 17);
            current_textBox6.Name = "current_textBox6";
            current_textBox6.Size = new Size(50, 17);
            current_textBox6.TabIndex = 10;
            current_textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // diff_textBox6
            // 
            diff_textBox6.Location = new Point(68, 19);
            diff_textBox6.MaximumSize = new Size(50, 17);
            diff_textBox6.MinimumSize = new Size(40, 0);
            diff_textBox6.Name = "diff_textBox6";
            diff_textBox6.Size = new Size(50, 17);
            diff_textBox6.TabIndex = 10;
            diff_textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(30, 19);
            label18.Name = "label18";
            label18.Size = new Size(32, 17);
            label18.TabIndex = 9;
            label18.Text = "差值";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(30, 53);
            label19.Name = "label19";
            label19.Size = new Size(32, 17);
            label19.TabIndex = 7;
            label19.Text = "零点";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 36);
            label20.Name = "label20";
            label20.Size = new Size(56, 17);
            label20.TabIndex = 8;
            label20.Text = "实时读数";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 15F);
            label21.Location = new Point(19, 325);
            label21.Name = "label21";
            label21.Size = new Size(132, 27);
            label21.TabIndex = 11;
            label21.Text = "差值的平均值";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft YaHei UI", 15F);
            label22.Location = new Point(39, 355);
            label22.Name = "label22";
            label22.Size = new Size(112, 27);
            label22.TabIndex = 11;
            label22.Text = "差值的方差";
            // 
            // qualityJudge_textBox
            // 
            qualityJudge_textBox.Location = new Point(332, 291);
            qualityJudge_textBox.Multiline = true;
            qualityJudge_textBox.Name = "qualityJudge_textBox";
            qualityJudge_textBox.Size = new Size(152, 89);
            qualityJudge_textBox.TabIndex = 12;
            // 
            // average_textBox
            // 
            average_textBox.Font = new Font("Microsoft YaHei UI", 15F);
            average_textBox.Location = new Point(157, 326);
            average_textBox.MaximumSize = new Size(80, 24);
            average_textBox.MinimumSize = new Size(80, 24);
            average_textBox.Name = "average_textBox";
            average_textBox.Size = new Size(80, 24);
            average_textBox.TabIndex = 13;
            average_textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // variance_textBox
            // 
            variance_textBox.Font = new Font("Microsoft YaHei UI", 15F);
            variance_textBox.Location = new Point(157, 356);
            variance_textBox.MaximumSize = new Size(80, 24);
            variance_textBox.MinimumSize = new Size(80, 24);
            variance_textBox.Name = "variance_textBox";
            variance_textBox.Size = new Size(80, 24);
            variance_textBox.TabIndex = 13;
            variance_textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(308, 383);
            label23.Name = "label23";
            label23.Size = new Size(200, 17);
            label23.TabIndex = 14;
            label23.Text = "Developed By HKUST(GZ) MDMF";
            // 
            // help_button
            // 
            help_button.Location = new Point(13, 44);
            help_button.Name = "help_button";
            help_button.Size = new Size(118, 23);
            help_button.TabIndex = 15;
            help_button.Text = "如何查看COM号？";
            help_button.UseVisualStyleBackColor = true;
            help_button.Click += help_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 428);
            Controls.Add(help_button);
            Controls.Add(label23);
            Controls.Add(variance_textBox);
            Controls.Add(average_textBox);
            Controls.Add(qualityJudge_textBox);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(setZero_button);
            Controls.Add(statusStrip1);
            Controls.Add(baudRate_comboBox);
            Controls.Add(label2);
            Controls.Add(openPortButton);
            Controls.Add(COM_comboBox);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "多点激光测距";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox COM_comboBox;
        private Button openPortButton;
        private Label label2;
        private ComboBox baudRate_comboBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button setZero_button;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox current_textBox1;
        private TextBox diff_textBox1;
        private TextBox zero_textBox1;
        private GroupBox groupBox2;
        private TextBox zero_textBox2;
        private TextBox current_textBox2;
        private TextBox diff_textBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox zero_textBox3;
        private TextBox current_textBox3;
        private TextBox diff_textBox3;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox4;
        private TextBox zero_textBox4;
        private TextBox current_textBox4;
        private TextBox diff_textBox4;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox5;
        private TextBox zero_textBox5;
        private TextBox current_textBox5;
        private TextBox diff_textBox5;
        private Label label15;
        private Label label16;
        private Label label17;
        private GroupBox groupBox6;
        private TextBox zero_textBox6;
        private TextBox current_textBox6;
        private TextBox diff_textBox6;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox qualityJudge_textBox;
        private TextBox average_textBox;
        private TextBox variance_textBox;
        private System.Windows.Forms.Timer timer1;
        private Label label23;
        private Button help_button;
    }
}
