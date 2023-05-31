namespace 期中個人專題_訂購單
{
    partial class FormLogin
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
            this.btn登入 = new System.Windows.Forms.Button();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(217, 417);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(147, 64);
            this.btn登入.TabIndex = 13;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(189, 367);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(152, 29);
            this.txt密碼.TabIndex = 12;
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(189, 288);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(152, 29);
            this.txt帳號.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(34, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "帳號/手機號碼";
            // 
            // btn註冊
            // 
            this.btn註冊.BackColor = System.Drawing.Color.Cyan;
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(39, 417);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(147, 64);
            this.btn註冊.TabIndex = 15;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = false;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::期中個人專題_訂購單.Properties.Resources.Krusty_Krab_230b;
            this.pictureBox2.Location = new System.Drawing.Point(13, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::期中個人專題_訂購單.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(58, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 515);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}