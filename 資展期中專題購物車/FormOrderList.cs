using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中個人專題_訂購單
{
    public partial class FormOrderList : Form
    {
        public int 所選id = 0;
        public string 訂購人資訊 = "";
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            lbl內用.Parent = pictureBox1;
            lbl總價.Parent = pictureBox1;
            SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
            con.Open();
            string strSQL = "select * from commodity where 商品id = @所選id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@所選id", 所選id);
            SqlDataReader reader = cmd.ExecuteReader();

            lbl訂購人資料.Text = "訂購人(電話):" + Globalvar.訂購人資訊;

            foreach (ArrayList 訂購品項 in Globalvar.list訂購品項資料)
            {
                string 早餐品項 = (string)訂購品項[0];
                int 早餐單價 = (int)訂購品項[1];
                int 早餐份數 = (int)訂購品項[2];
                int 總價格 = (int)訂購品項[3];
                
               
                string 單品資料 = string.Format("{0} {1}元 {2}份 {3} 元  ", 早餐品項, 早餐單價, 早餐份數, 總價格);

                listBox訂購商品列表.Items.Add(單品資料);

            }

            reader.Close();
            con.Close();
            計算訂單總價();
        }

       
        void 計算訂單總價()
        {
            int 訂單總價 = 0;

            foreach (ArrayList 訂購品項 in Globalvar.list訂購品項資料)
            {
                string 早餐品項 = (string)訂購品項[0];
                int 早餐單價 = (int)訂購品項[1];
                int 早餐份數 = (int)訂購品項[2];
                int 總價格 = (int)訂購品項[3];

                訂單總價 += 總價格;
            }
            lbl總價.Text = string.Format("訂單總價:{0}元", 訂單總價);


            if ((Globalvar.is外帶 == true) && (Globalvar.list訂購品項資料.Count > 0))
            {
                lbl內用.Text = "外帶";
            }
            else
            {
                lbl內用.Text = "內用";
            }
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購商品列表.SelectedIndices.Count > 0)//SelectedIndices複數的索引值
            {
                for (int i = (listBox訂購商品列表.SelectedIndices.Count - 1); i >= 0; i -= 1)
                {
                    Globalvar.list訂購品項資料.RemoveAt(listBox訂購商品列表.SelectedIndices[i]);
                    listBox訂購商品列表.Items.RemoveAt(listBox訂購商品列表.SelectedIndices[i]);
                }

                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            listBox訂購商品列表.Items.Clear();
            Globalvar.list訂購品項資料.Clear();
            Globalvar.訂購人資訊 = "";
        
            計算訂單總價();
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn輸出訂購單txt_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\user\Desktop";
            Random myRnd = new Random();
            int rndNum = myRnd.Next(1000, 10000);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + rndNum + "訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            }
            else
            {
                return;
            }


            /////訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("************早餐店訂購單************");
            list訂單資訊.Add("-----------------------------------");
            if ((Globalvar.is外帶 == true) && (Globalvar.list訂購品項資料.Count > 0))
            {
                list訂單資訊.Add($"訂購時間:{DateTime.Now.ToString()} 訂購人:{Globalvar.訂購人資訊} ,外帶"); 
            }
            else
            {
                list訂單資訊.Add($"訂購時間:{DateTime.Now.ToString()} 訂購人:{Globalvar.訂購人資訊} ,內用");
            }
            list訂單資訊.Add("-----------------------------------");
            list訂單資訊.Add("          <<<<<<<<訂購品項>>>>>>>>     ");
            foreach (ArrayList 訂購品項 in Globalvar.list訂購品項資料)
            {
                string 早餐品項 = (string)訂購品項[0];
                int 早餐單價 = (int)訂購品項[1];
                int 早餐份數 = (int)訂購品項[2];
                int 總價格 = (int)訂購品項[3];
               

                string 單品資料 = string.Format("{0} {1}元 {2}份 總價格:{3}元", 早餐品項, 早餐單價, 早餐份數, 總價格);

                list訂單資訊.Add(單品資料);
            }

            list訂單資訊.Add("----------------------------------------");
            
            list訂單資訊.Add($"{lbl總價.Text}");
            list訂單資訊.Add("=========================================");
            list訂單資訊.Add("*************   謝謝光臨   ***************");
            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

    }
}


