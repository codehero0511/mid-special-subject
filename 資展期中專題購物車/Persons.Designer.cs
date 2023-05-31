namespace 期中個人專題_訂購單
{
    partial class Persons
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
            this.dgv員工資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt權限 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.btn上一筆 = new System.Windows.Forms.Button();
            this.btn下一筆 = new System.Windows.Forms.Button();
            this.btn最後一筆 = new System.Windows.Forms.Button();
            this.btn第一筆 = new System.Windows.Forms.Button();
            this.txt薪資 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn資料筆數 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料列表)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv員工資料列表
            // 
            this.dgv員工資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv員工資料列表.Location = new System.Drawing.Point(570, 78);
            this.dgv員工資料列表.Name = "dgv員工資料列表";
            this.dgv員工資料列表.RowTemplate.Height = 24;
            this.dgv員工資料列表.Size = new System.Drawing.Size(385, 215);
            this.dgv員工資料列表.TabIndex = 0;
            this.dgv員工資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv員工資料列表_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.btn清空欄位);
            this.groupBox2.Controls.Add(this.btn刪除資料);
            this.groupBox2.Controls.Add(this.btn新增資料);
            this.groupBox2.Controls.Add(this.btn資料修改);
            this.groupBox2.Controls.Add(this.btn資料搜尋);
            this.groupBox2.Controls.Add(this.btn資料筆數);
            this.groupBox2.Controls.Add(this.dgv員工資料列表);
            this.groupBox2.Controls.Add(this.txt權限);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn重新整理);
            this.groupBox2.Controls.Add(this.btn上一筆);
            this.groupBox2.Controls.Add(this.btn下一筆);
            this.groupBox2.Controls.Add(this.btn最後一筆);
            this.groupBox2.Controls.Add(this.btn第一筆);
            this.groupBox2.Controls.Add(this.txt薪資);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 619);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // txt權限
            // 
            this.txt權限.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt權限.Location = new System.Drawing.Point(125, 280);
            this.txt權限.Name = "txt權限";
            this.txt權限.Size = new System.Drawing.Size(150, 33);
            this.txt權限.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "權限";
            // 
            // btn重新整理
            // 
            this.btn重新整理.Location = new System.Drawing.Point(6, 495);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(159, 53);
            this.btn重新整理.TabIndex = 38;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = true;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // btn上一筆
            // 
            this.btn上一筆.Location = new System.Drawing.Point(145, 421);
            this.btn上一筆.Name = "btn上一筆";
            this.btn上一筆.Size = new System.Drawing.Size(139, 53);
            this.btn上一筆.TabIndex = 37;
            this.btn上一筆.Text = "上一筆";
            this.btn上一筆.UseVisualStyleBackColor = true;
            this.btn上一筆.Click += new System.EventHandler(this.btn上一筆_Click);
            // 
            // btn下一筆
            // 
            this.btn下一筆.Location = new System.Drawing.Point(0, 421);
            this.btn下一筆.Name = "btn下一筆";
            this.btn下一筆.Size = new System.Drawing.Size(139, 53);
            this.btn下一筆.TabIndex = 36;
            this.btn下一筆.Text = "下一筆";
            this.btn下一筆.UseVisualStyleBackColor = true;
            this.btn下一筆.Click += new System.EventHandler(this.btn下一筆_Click);
            // 
            // btn最後一筆
            // 
            this.btn最後一筆.Location = new System.Drawing.Point(145, 344);
            this.btn最後一筆.Name = "btn最後一筆";
            this.btn最後一筆.Size = new System.Drawing.Size(139, 53);
            this.btn最後一筆.TabIndex = 35;
            this.btn最後一筆.Text = "最後一筆";
            this.btn最後一筆.UseVisualStyleBackColor = true;
            this.btn最後一筆.Click += new System.EventHandler(this.btn最後一筆_Click);
            // 
            // btn第一筆
            // 
            this.btn第一筆.Location = new System.Drawing.Point(0, 344);
            this.btn第一筆.Name = "btn第一筆";
            this.btn第一筆.Size = new System.Drawing.Size(139, 53);
            this.btn第一筆.TabIndex = 34;
            this.btn第一筆.Text = "第一筆";
            this.btn第一筆.UseVisualStyleBackColor = true;
            this.btn第一筆.Click += new System.EventHandler(this.btn第一筆_Click);
            // 
            // txt薪資
            // 
            this.txt薪資.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt薪資.Location = new System.Drawing.Point(125, 219);
            this.txt薪資.Name = "txt薪資";
            this.txt薪資.Size = new System.Drawing.Size(150, 33);
            this.txt薪資.TabIndex = 33;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(125, 154);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(150, 33);
            this.txt電話.TabIndex = 28;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(125, 99);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(150, 33);
            this.txt姓名.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(132, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 21);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(15, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "員工薪資";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "員工電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "員工姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "員工id";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(333, 492);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(159, 53);
            this.btn清空欄位.TabIndex = 46;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Location = new System.Drawing.Point(333, 405);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(159, 53);
            this.btn刪除資料.TabIndex = 45;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            // 
            // btn新增資料
            // 
            this.btn新增資料.Location = new System.Drawing.Point(333, 325);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(159, 53);
            this.btn新增資料.TabIndex = 44;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            // 
            // btn資料修改
            // 
            this.btn資料修改.Location = new System.Drawing.Point(333, 253);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(159, 53);
            this.btn資料修改.TabIndex = 43;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn資料搜尋.Location = new System.Drawing.Point(333, 176);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(159, 53);
            this.btn資料搜尋.TabIndex = 42;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            // 
            // btn資料筆數
            // 
            this.btn資料筆數.Location = new System.Drawing.Point(333, 99);
            this.btn資料筆數.Name = "btn資料筆數";
            this.btn資料筆數.Size = new System.Drawing.Size(159, 53);
            this.btn資料筆數.TabIndex = 41;
            this.btn資料筆數.Text = "資料筆數";
            this.btn資料筆數.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::期中個人專題_訂購單.Properties.Resources.pngtree_cute_colorful_watercolor_love_background_image_717289;
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(994, 592);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 630);
            this.Controls.Add(this.groupBox2);
            this.Name = "Persons";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.Persons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料列表)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv員工資料列表;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.Button btn上一筆;
        private System.Windows.Forms.Button btn下一筆;
        private System.Windows.Forms.Button btn最後一筆;
        private System.Windows.Forms.Button btn第一筆;
        private System.Windows.Forms.TextBox txt薪資;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt權限;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Button btn資料筆數;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}