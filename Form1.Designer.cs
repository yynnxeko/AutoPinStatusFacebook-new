namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbLinkBaiCanGhim = new System.Windows.Forms.RichTextBox();
            this.lblUid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuongDanThuMucProfiles = new System.Windows.Forms.TextBox();
            this.txtUidPassProxy2Fa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.chkSaveLogin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobsNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link bài cần ghim:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rtbLinkBaiCanGhim
            // 
            this.rtbLinkBaiCanGhim.Location = new System.Drawing.Point(21, 329);
            this.rtbLinkBaiCanGhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbLinkBaiCanGhim.Name = "rtbLinkBaiCanGhim";
            this.rtbLinkBaiCanGhim.Size = new System.Drawing.Size(646, 127);
            this.rtbLinkBaiCanGhim.TabIndex = 4;
            this.rtbLinkBaiCanGhim.Text = "";
            this.rtbLinkBaiCanGhim.TextChanged += new System.EventHandler(this.rtbLinkBaiCanGhim_TextChanged);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(240, 69);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(94, 20);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "UID|Pass|2Fa:\r\n";
            this.lblUid.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đường dẫn thư mục profiles:";
            // 
            // txtDuongDanThuMucProfiles
            // 
            this.txtDuongDanThuMucProfiles.Location = new System.Drawing.Point(21, 244);
            this.txtDuongDanThuMucProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuongDanThuMucProfiles.Name = "txtDuongDanThuMucProfiles";
            this.txtDuongDanThuMucProfiles.Size = new System.Drawing.Size(646, 27);
            this.txtDuongDanThuMucProfiles.TabIndex = 7;
            this.txtDuongDanThuMucProfiles.TextChanged += new System.EventHandler(this.txtDuongDanThuMucProfiles_TextChanged);
            // 
            // txtUidPassProxy2Fa
            // 
            this.txtUidPassProxy2Fa.Location = new System.Drawing.Point(371, 65);
            this.txtUidPassProxy2Fa.Name = "txtUidPassProxy2Fa";
            this.txtUidPassProxy2Fa.Size = new System.Drawing.Size(295, 27);
            this.txtUidPassProxy2Fa.TabIndex = 10;
            this.txtUidPassProxy2Fa.TextChanged += new System.EventHandler(this.txtUidPassProxy2Fa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Thời gian nghỉ để chuyển link: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(240, 480);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 27);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thời gian lặp lại job pin: ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(240, 539);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(137, 27);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // chkSaveLogin
            // 
            this.chkSaveLogin.AutoSize = true;
            this.chkSaveLogin.Location = new System.Drawing.Point(371, 119);
            this.chkSaveLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSaveLogin.Name = "chkSaveLogin";
            this.chkSaveLogin.Size = new System.Drawing.Size(159, 24);
            this.chkSaveLogin.TabIndex = 23;
            this.chkSaveLogin.Text = "Lưu nhớ đăng nhập";
            this.chkSaveLogin.UseVisualStyleBackColor = true;
            this.chkSaveLogin.CheckedChanged += new System.EventHandler(this.cbSaveLogin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số lần lặp lại job:";
            // 
            // txtJobsNumber
            // 
            this.txtJobsNumber.Location = new System.Drawing.Point(528, 539);
            this.txtJobsNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobsNumber.Name = "txtJobsNumber";
            this.txtJobsNumber.Size = new System.Drawing.Size(45, 27);
            this.txtJobsNumber.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJobsNumber);
            this.Controls.Add(this.chkSaveLogin);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUidPassProxy2Fa);
            this.Controls.Add(this.txtDuongDanThuMucProfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbLinkBaiCanGhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Auto Pin Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label2;
        private RichTextBox rtbLinkBaiCanGhim;
        private Label lblUid;
        private Label label3;
        private TextBox txtDuongDanThuMucProfiles;
        private TextBox txtUidPassProxy2Fa;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private CheckBox chkSaveLogin;
        private Label label1;
        private TextBox txtJobsNumber;
    }
}