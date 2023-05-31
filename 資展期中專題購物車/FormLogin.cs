using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中個人專題_訂購單
{
    public partial class FormLogin : Form
    {
        FormMain formMain;
        public FormLogin()
        {
            InitializeComponent();
            formMain = new FormMain();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb;//SQL連結字串建立器
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "breakfast"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證

            Globalvar.strbreakfastconnectionString = scsb.ConnectionString;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != ""))
            {
                string str帳號 = txt帳號.Text.Trim();
                string str密碼 = txt密碼.Text.Trim();

                SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
                con.Open();
                string strSQL = "select * from Users where Username = @str帳號  and Password = @str密碼;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@str密碼", str密碼);
                cmd.Parameters.AddWithValue("@str帳號", str帳號);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {         
                    this.Visible = false;
                    formMain.ShowDialog();
                    this.Close();
                    this.Dispose();               
                }
                else
                {                    
                    MessageBox.Show("請確認帳號密碼正確");

                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");

            }
           
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != ""))
            {
                string str帳號 = txt帳號.Text.Trim();
                string str密碼 = txt密碼.Text.Trim();
                SqlConnection con = new SqlConnection(Globalvar.strbreakfastconnectionString);
                con.Open();
                string strSQL = "insert into  Users values(@str帳號, @str密碼)";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@str帳號", str帳號);
                cmd.Parameters.AddWithValue("@str密碼", str密碼);

                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                MessageBox.Show($"註冊完畢,請重新登入");
                txt帳號.Clear();
                txt密碼.Clear();
            }
            else
            {
                MessageBox.Show("帳號與密碼必填");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 取消關閉表單的預設行為，因為我們要手動處理關閉事件
            e.Cancel = true;

            //關閉表單
            Close();
        }
    }
}
