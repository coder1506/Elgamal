
namespace DaoDinhDuc_btl_elgamal
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
            System.Windows.Forms.TabPage tab1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.genKeyBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtxt = new System.Windows.Forms.TextBox();
            this.atxt = new System.Windows.Forms.TextBox();
            this.ptxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSignatureBtn = new System.Windows.Forms.Button();
            this.fileCheck = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.signingBtn = new System.Windows.Forms.Button();
            this.signature = new System.Windows.Forms.TextBox();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.ytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ktxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            tab1 = new System.Windows.Forms.TabPage();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(this.splitContainer1);
            tab1.Location = new System.Drawing.Point(4, 24);
            tab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tab1.Name = "tab1";
            tab1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tab1.Size = new System.Drawing.Size(1134, 510);
            tab1.TabIndex = 0;
            tab1.Text = "Chữ kí số elgamal";
            tab1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.genKeyBtn);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.checkSignatureBtn);
            this.splitContainer1.Panel2.Controls.Add(this.fileCheck);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.signingBtn);
            this.splitContainer1.Panel2.Controls.Add(this.signature);
            this.splitContainer1.Panel2.Controls.Add(this.pathFile);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.resetBtn);
            this.splitContainer1.Panel2.Controls.Add(this.ytxt);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.ktxt);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitContainer1.Size = new System.Drawing.Size(1128, 506);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 2);
            this.label10.TabIndex = 4;
            // 
            // genKeyBtn
            // 
            this.genKeyBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genKeyBtn.Location = new System.Drawing.Point(86, 347);
            this.genKeyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genKeyBtn.Name = "genKeyBtn";
            this.genKeyBtn.Size = new System.Drawing.Size(203, 28);
            this.genKeyBtn.TabIndex = 3;
            this.genKeyBtn.Text = "Tạo khoá ngẫu nhiên";
            this.genKeyBtn.UseVisualStyleBackColor = true;
            this.genKeyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.xtxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(24, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoá bí mật (x)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // xtxt
            // 
            this.xtxt.Location = new System.Drawing.Point(211, 38);
            this.xtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtxt.Name = "xtxt";
            this.xtxt.Size = new System.Drawing.Size(110, 26);
            this.xtxt.TabIndex = 3;
            this.xtxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số nguyên x =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dtxt);
            this.groupBox1.Controls.Add(this.atxt);
            this.groupBox1.Controls.Add(this.ptxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoá công khai(p,a,d)";
            // 
            // dtxt
            // 
            this.dtxt.Location = new System.Drawing.Point(210, 86);
            this.dtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtxt.Name = "dtxt";
            this.dtxt.Size = new System.Drawing.Size(110, 26);
            this.dtxt.TabIndex = 5;
            // 
            // atxt
            // 
            this.atxt.Location = new System.Drawing.Point(211, 56);
            this.atxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(110, 26);
            this.atxt.TabIndex = 4;
            // 
            // ptxt
            // 
            this.ptxt.Location = new System.Drawing.Point(211, 26);
            this.ptxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptxt.Name = "ptxt";
            this.ptxt.Size = new System.Drawing.Size(110, 26);
            this.ptxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "(d = a ^ x mod p) số d =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số (alpha) a = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số nguyên tố p =";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo khoá";
            // 
            // checkSignatureBtn
            // 
            this.checkSignatureBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkSignatureBtn.Location = new System.Drawing.Point(578, 409);
            this.checkSignatureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSignatureBtn.Name = "checkSignatureBtn";
            this.checkSignatureBtn.Size = new System.Drawing.Size(147, 36);
            this.checkSignatureBtn.TabIndex = 16;
            this.checkSignatureBtn.Text = "kiểm tra chữ ký";
            this.checkSignatureBtn.UseVisualStyleBackColor = true;
            this.checkSignatureBtn.Click += new System.EventHandler(this.checkSignatureBtn_Click);
            // 
            // fileCheck
            // 
            this.fileCheck.Location = new System.Drawing.Point(68, 406);
            this.fileCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileCheck.MaximumSize = new System.Drawing.Size(395, 38);
            this.fileCheck.MinimumSize = new System.Drawing.Size(395, 38);
            this.fileCheck.Multiline = true;
            this.fileCheck.Name = "fileCheck";
            this.fileCheck.Size = new System.Drawing.Size(395, 38);
            this.fileCheck.TabIndex = 15;
            this.fileCheck.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::DaoDinhDuc_btl_elgamal.Properties.Resources.uploadimg;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(460, 405);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 41);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(68, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(268, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Chọn file thực hiện kiểm ra chữ ký số :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(68, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tệp chữ kí vào file văn bản được gửi đi:";
            // 
            // signingBtn
            // 
            this.signingBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signingBtn.Location = new System.Drawing.Point(604, 104);
            this.signingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signingBtn.Name = "signingBtn";
            this.signingBtn.Size = new System.Drawing.Size(121, 36);
            this.signingBtn.TabIndex = 11;
            this.signingBtn.Text = "ký lên văn bản";
            this.signingBtn.UseVisualStyleBackColor = true;
            this.signingBtn.Click += new System.EventHandler(this.signingBtn_Click);
            // 
            // signature
            // 
            this.signature.Location = new System.Drawing.Point(68, 184);
            this.signature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signature.Multiline = true;
            this.signature.Name = "signature";
            this.signature.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.signature.Size = new System.Drawing.Size(657, 169);
            this.signature.TabIndex = 10;
            // 
            // pathFile
            // 
            this.pathFile.Location = new System.Drawing.Point(68, 102);
            this.pathFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathFile.Multiline = true;
            this.pathFile.Name = "pathFile";
            this.pathFile.Size = new System.Drawing.Size(395, 39);
            this.pathFile.TabIndex = 9;
            this.pathFile.TextChanged += new System.EventHandler(this.pathFile_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DaoDinhDuc_btl_elgamal.Properties.Resources.uploadimg;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(460, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 41);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(3, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(748, 2);
            this.label11.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(68, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chọn file thực hiện ký :";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(642, 37);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(82, 31);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Chọn lại";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ytxt
            // 
            this.ytxt.Location = new System.Drawing.Point(496, 37);
            this.ytxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ytxt.Name = "ytxt";
            this.ytxt.Size = new System.Drawing.Size(106, 23);
            this.ytxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(337, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y = (a ^ k mod p) Y =";
            // 
            // ktxt
            // 
            this.ktxt.Location = new System.Drawing.Point(202, 37);
            this.ktxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ktxt.Name = "ktxt";
            this.ktxt.Size = new System.Drawing.Size(106, 23);
            this.ktxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(68, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số ngẫu nhiên k =";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thực hiện ký";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1134, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin tác giả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(271, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(443, 31);
            this.label16.TabIndex = 2;
            this.label16.Text = "Trường đại học Công Nghiệp Hà Nội";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(383, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 31);
            this.label15.TabIndex = 1;
            this.label15.Text = "KTPM01 - k13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(339, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tác giả: Đào Đình Đức";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1134, 510);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Hướng dẫn sử dụng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(278, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(486, 24);
            this.label21.TabIndex = 4;
            this.label21.Text = "B4:kích vào nút kiểm tra chữ ký để xác thực nội dung";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(278, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(289, 24);
            this.label20.TabIndex = 3;
            this.label20.Text = "B3:chọn file để kiểm tra chữ ký";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(278, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(491, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "B2:chọn file cần ký,rồi kích vào nút ký để thực hiện ký";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(278, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "B1:Tạo khoá";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(330, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(244, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "Hướng dẫn sử dụng";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "upLoadFileDialog";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 544);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CHỮ KÍ SỐ - ELGAMAL";
            tab1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox xtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dtxt;
        private System.Windows.Forms.TextBox atxt;
        private System.Windows.Forms.TextBox ptxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button genKeyBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox ytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ktxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.Button checkSignatureBtn;
        private System.Windows.Forms.TextBox fileCheck;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button signingBtn;
        private System.Windows.Forms.TextBox signature;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

