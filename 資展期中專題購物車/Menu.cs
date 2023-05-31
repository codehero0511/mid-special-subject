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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        ///-------------------------------------------------------
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();
        ///-------------------------------------------------------
        int 所選份數;
        int 所選早餐單價;
        int 總價格;
        string 所選早餐品項;
        bool is外帶;
        int 所選id;
        ///-------------------------------------------------------
        private void Menu_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "breakfast";
            scsb.IntegratedSecurity = true;
            Globalvar.strbreakfastconnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
            con.Open();
            string strSQL1 = $"SELECT * FROM commodity; ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string num = reader1["商品名稱"].ToString();
                listName.Add(num);
            }
            reader1.Close();
            con.Close();


            con.Open();
            string strSQL3 = $"SELECT * FROM commodity; ";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string name = reader3["商品名稱"].ToString();
                string num = reader3["商品價格"].ToString();
                string mix = $"{name} {num}元";
                listBox早餐品項.Items.Add(mix);
            }
            reader3.Close();
            con.Close();



            //預設值
            txt份數.Text = "";
            所選份數 = 1;
            radio內用.Checked = true;
            is外帶 = true;

            讀取資料庫();
                                
            
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
            con.Open();
            string strSQL = "select * from commodity";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read() == true)
            {
                listID.Add((int)reader["商品id"]);
                listName.Add(reader["商品名稱"].ToString());
                listPrice.Add((int)reader["商品價格"]);
                count += 1;
            }
            reader.Close();
            con.Close();
        }
        
        void 計算所選早餐品項總價()//早餐品項方法
        {

            if (listBox早餐品項.SelectedIndex > -1)
            {
                總價格 = 所選早餐單價 * 所選份數 ;
                lbl早餐總價.Text = string.Format("{0}元", 總價格);
            }
           
        }

        private void txt份數_TextChanged_(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
            con.Open();
            string strSQL = $"select * from commodity where 商品id = @所選id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@所選id", listBox早餐品項.SelectedIndex);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                int temp = (int)reader["商品價格"];
                總價格 = temp * 所選份數;
                lbl早餐單價.Text = string.Format($"{temp}元");
                lbl早餐總價.Text = string.Format($"{總價格}元");
            }
           
            if (txt份數.Text != "")
            {
                //所選id = (int)listBox早餐品項.SelectedItems[0];
                bool is份數正確 = Int32.TryParse(txt份數.Text, out 所選份數);

                if ((is份數正確 == false) || (所選份數 <= 0))
                {
                    MessageBox.Show("份數輸入不正確,最少一份");
                    所選份數 = 1;
                    txt份數.Text = "1";
                }
                計算所選早餐品項總價();
            }
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            if (txt訂購人.Text != "")
            {

                ArrayList 單品項訂購資訊 = new ArrayList();
                單品項訂購資訊.Add(所選早餐品項);
                單品項訂購資訊.Add(所選早餐單價);
                單品項訂購資訊.Add(所選份數);
                單品項訂購資訊.Add(總價格);
                單品項訂購資訊.Add(is外帶);

                Globalvar.訂購人資訊 = txt訂購人.Text;
                Globalvar.list訂購品項資料.Add(單品項訂購資訊);

                if (radio外帶.Checked == true)
                {
                    Globalvar.is外帶 = true;
                }
                else
                {
                    Globalvar.is外帶 = false;
                }
                MessageBox.Show("品項加入訂購單");
            }
            else
            {
                MessageBox.Show("請輸入訂購人");
            }

        }

        private void btn查看訂單_Click(object sender, EventArgs e)
        {
            FormOrderList myOrderListForm = new FormOrderList();
            Globalvar.訂購人資訊 = txt訂購人.Text;
            myOrderListForm.訂購人資訊 = txt訂購人.Text;           
            myOrderListForm.ShowDialog();
            
        }

        private void listBox早餐品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox早餐品項.SelectedIndex > -1)//SelectedIndex所選項目的索引值
            {
                所選早餐品項 = listName[listBox早餐品項.SelectedIndex];
                所選早餐單價 = listPrice[listBox早餐品項.SelectedIndex];
                lbl早餐單價.Text = string.Format("{0}元", 所選早餐單價);
               
                計算所選早餐品項總價();
            }
        }

       
    }
}
