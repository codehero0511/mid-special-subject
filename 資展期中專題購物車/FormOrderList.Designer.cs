namespace 期中個人專題_訂購單
{
    partial class FormOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            this.lbl內用 = new System.Windows.Forms.Label();
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn輸出訂購單txt = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.listBox訂購商品列表 = new System.Windows.Forms.ListBox();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl內用
            // 
            this.lbl內用.BackColor = System.Drawing.Color.Transparent;
            this.lbl內用.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl內用.Location = new System.Drawing.Point(80, 448);
            this.lbl內用.Name = "lbl內用";
            this.lbl內用.Size = new System.Drawing.Size(79, 45);
            this.lbl內用.TabIndex = 20;
            this.lbl內用.Text = "內用";
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉表單.Location = new System.Drawing.Point(635, 458);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(199, 81);
            this.btn關閉表單.TabIndex = 19;
            this.btn關閉表單.Text = "關閉表單";
            this.btn關閉表單.UseVisualStyleBackColor = true;
            this.btn關閉表單.Click += new System.EventHandler(this.btn關閉表單_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(377, 458);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(199, 81);
            this.btn清除所有品項.TabIndex = 18;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn輸出訂購單txt
            // 
            this.btn輸出訂購單txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單txt.Location = new System.Drawing.Point(635, 371);
            this.btn輸出訂購單txt.Name = "btn輸出訂購單txt";
            this.btn輸出訂購單txt.Size = new System.Drawing.Size(199, 81);
            this.btn輸出訂購單txt.TabIndex = 17;
            this.btn輸出訂購單txt.Text = "輸出訂購單txt";
            this.btn輸出訂購單txt.UseVisualStyleBackColor = true;
            this.btn輸出訂購單txt.Click += new System.EventHandler(this.btn輸出訂購單txt_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.FlatAppearance.BorderSize = 0;
            this.btn移除所選品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(377, 371);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(199, 81);
            this.btn移除所選品項.TabIndex = 16;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.BackColor = System.Drawing.Color.Transparent;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(32, 397);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(212, 39);
            this.lbl總價.TabIndex = 15;
            this.lbl總價.Text = "總價000000元";
            // 
            // listBox訂購商品列表
            // 
            this.listBox訂購商品列表.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購商品列表.FormattingEnabled = true;
            this.listBox訂購商品列表.ItemHeight = 26;
            this.listBox訂購商品列表.Location = new System.Drawing.Point(12, 101);
            this.listBox訂購商品列表.Name = "listBox訂購商品列表";
            this.listBox訂購商品列表.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox訂購商品列表.Size = new System.Drawing.Size(607, 264);
            this.listBox訂購商品列表.TabIndex = 14;
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.AutoSize = true;
            this.lbl訂購人資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl訂購人資料.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(24, 60);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(117, 27);
            this.lbl訂購人資料.TabIndex = 13;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "選購商品列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 47);
            this.label2.TabIndex = 22;
            this.label2.Text = "選購商品列表";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl內用);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn輸出訂購單txt);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.listBox訂購商品列表);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormOrderList";
            this.Text = "FormOrderList";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl內用;
        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn輸出訂購單txt;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.ListBox listBox訂購商品列表;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}