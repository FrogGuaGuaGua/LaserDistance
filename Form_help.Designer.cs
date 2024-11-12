namespace LaserDistance
{
    partial class Form_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_help));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 17);
            label1.TabIndex = 0;
            label1.Text = "1.打开设备管理器 (先按Win+X，再按M键)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 33);
            label2.Name = "label2";
            label2.Size = new Size(224, 17);
            label2.TabIndex = 0;
            label2.Text = "2.找到 端口(COM和LPT)，展开这一项。";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 57);
            label3.Name = "label3";
            label3.Size = new Size(308, 17);
            label3.TabIndex = 0;
            label3.Text = "3.找到 USB Serial Port，后面的COM号就是所需要的。";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 637);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 2;
            label4.Text = "(By 蒋力夫)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 81);
            label5.Name = "label5";
            label5.Size = new Size(324, 17);
            label5.TabIndex = 0;
            label5.Text = "4.如果不知道要不要改波特率，请保持默认值115200不变。";
            // 
            // Form_help
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 658);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_help";
            Text = "如何查看COM号";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}