namespace LibraryManager
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnGoHome = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 20, 0, 0);
            label1.Size = new Size(439, 115);
            label1.TabIndex = 0;
            label1.Text = "...Hoş Geldiniz...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(23, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(23, 42);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(73, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 99);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(73, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 99);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifre";
            // 
            // btnGoHome
            // 
            btnGoHome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGoHome.Location = new Point(96, 393);
            btnGoHome.Name = "btnGoHome";
            btnGoHome.Size = new Size(240, 53);
            btnGoHome.TabIndex = 7;
            btnGoHome.Text = "Giriş";
            btnGoHome.UseVisualStyleBackColor = true;
            btnGoHome.Click += btnGoHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 474);
            Controls.Add(btnGoHome);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Girişi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGoHome;
    }
}
