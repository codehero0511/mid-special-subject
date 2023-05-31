namespace 期中個人專題_訂購單
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn員工資料 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn會員表單 = new System.Windows.Forms.Button();
            this.btn菜單Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn登出 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn員工資料
            // 
            this.btn員工資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工資料.Location = new System.Drawing.Point(512, 183);
            this.btn員工資料.Margin = new System.Windows.Forms.Padding(2);
            this.btn員工資料.Name = "btn員工資料";
            this.btn員工資料.Size = new System.Drawing.Size(213, 91);
            this.btn員工資料.TabIndex = 20;
            this.btn員工資料.Text = "員工資料維護";
            this.btn員工資料.UseVisualStyleBackColor = true;
            this.btn員工資料.Click += new System.EventHandler(this.btn員工資料_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(278, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "早餐訂購系統";
            // 
            // btn商品管理
            // 
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(300, 278);
            this.btn商品管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(208, 82);
            this.btn商品管理.TabIndex = 18;
            this.btn商品管理.Text = "商品維護";
            this.btn商品管理.UseVisualStyleBackColor = true;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(76, 278);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(220, 82);
            this.btn訂單管理.TabIndex = 17;
            this.btn訂單管理.Text = "訂購單";
            this.btn訂單管理.UseVisualStyleBackColor = true;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn會員表單
            // 
            this.btn會員表單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員表單.Location = new System.Drawing.Point(300, 183);
            this.btn會員表單.Margin = new System.Windows.Forms.Padding(2);
            this.btn會員表單.Name = "btn會員表單";
            this.btn會員表單.Size = new System.Drawing.Size(208, 91);
            this.btn會員表單.TabIndex = 16;
            this.btn會員表單.Text = "會員資料維護表單";
            this.btn會員表單.UseVisualStyleBackColor = true;
            this.btn會員表單.Click += new System.EventHandler(this.btn會員表單_Click);
            // 
            // btn菜單Menu
            // 
            this.btn菜單Menu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn菜單Menu.Location = new System.Drawing.Point(76, 183);
            this.btn菜單Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn菜單Menu.Name = "btn菜單Menu";
            this.btn菜單Menu.Size = new System.Drawing.Size(220, 91);
            this.btn菜單Menu.TabIndex = 15;
            this.btn菜單Menu.Text = "菜單Menu";
            this.btn菜單Menu.UseVisualStyleBackColor = true;
            this.btn菜單Menu.Click += new System.EventHandler(this.btn菜單Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::期中個人專題_訂購單.Properties.Resources.C1436845601664;
            this.pictureBox1.Location = new System.Drawing.Point(2, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn登出
            // 
            this.btn登出.BackColor = System.Drawing.Color.LightCoral;
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(680, 11);
            this.btn登出.Margin = new System.Windows.Forms.Padding(2);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(109, 59);
            this.btn登出.TabIndex = 22;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.btn菜單Menu);
            this.Controls.Add(this.btn員工資料);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn會員表單);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn員工資料;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn會員表單;
        private System.Windows.Forms.Button btn菜單Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn登出;
    }
}

