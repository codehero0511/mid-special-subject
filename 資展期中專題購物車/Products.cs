using System;
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
    public partial class Products : Form
    {
        SqlConnectionStringBuilder scsb;//SQL連結字串建立器
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            產生商品資料列表DGV();
        }

        void 產生商品資料列表DGV()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//伺服器名稱(@:不考慮特殊字元
            scsb.InitialCatalog = "breakfast";//資料庫名稱
            scsb.IntegratedSecurity = true; //WINDOWs驗證

            strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select * from commodity;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv商品資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn商品筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString); //建立SqlConnection的物件
            con.Open();//開啟SQLConnection
            string strSQL = "select top(100)* from commodity";//建立SQL語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int 商品id = (int)reader["商品id"];
                string 商品名稱 = reader["商品名稱"].ToString();              
                int 商品價格 = (int)reader["商品價格"];

                strMsg += $"{商品id} ,{商品名稱} ,{商品價格} 元\n";
                count += 1;
            }
            strMsg += "資料筆數:" + count;

            reader.Close();//關閉
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btn商品搜尋_Click(object sender, EventArgs e)
        {
            if (txt商品名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from commodity where 商品名稱 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt商品名稱.Text.Trim()}%");//Trim:去前後的空白
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["商品id"].ToString();
                    txt商品名稱.Text = reader["商品名稱"].ToString();
                    txt商品價格.Text = reader["商品價格"].ToString();                   
                }
                else
                {
                    MessageBox.Show("查無此商品");
                    清空欄位();
                }

                reader.Close();//關閉
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入商品搜尋關鍵字");
            }
        }

        private void btn修改商品_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if ((intID > 0) && (txt商品名稱.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update commodity set 商品名稱=@NewName,商品價格=@NewPrice where 商品id =@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPrice", txt商品價格.Text.Trim());               
                cmd.Parameters.AddWithValue("@SearchID", intID);               
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"商品資料修改成功,{rows}筆資料受影響");
            }
        }

        private void btn新增商品資料_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into commodity values(@NewName,@NewPrice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPrice", txt商品價格.Text.Trim());
                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                MessageBox.Show($"商品資料新增完畢,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("商品名稱與價格必填");
            }
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from commodity where 商品id =@DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"商品資料已刪除,{rows}筆資料受影響");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 清空欄位()
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();          
        }

        private void dgv商品資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv商品資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);

                if (selectedID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from commodity where 商品id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", selectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["商品id"].ToString();
                        txt商品名稱.Text = reader["商品名稱"].ToString();
                        txt商品價格.Text = reader["商品價格"].ToString();                       
                    }
                    else
                    {
                        MessageBox.Show("查無此商品");
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn第一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 1 * from commodity ORDER BY 商品id ASC";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["商品id"].ToString();
                txt商品名稱.Text = reader["商品名稱"].ToString();
                txt商品價格.Text = reader["商品價格"].ToString();              
            }
            reader.Close();
            con.Close();
        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 1 * from commodity ORDER BY 商品id desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["商品id"].ToString();
                txt商品名稱.Text = reader["商品名稱"].ToString();
                txt商品價格.Text = reader["商品價格"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select  * from commodity WHERE 商品id > @ID ORDER BY 商品id ASC";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", lblID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["商品id"].ToString();
                txt商品名稱.Text = reader["商品名稱"].ToString();
                txt商品價格.Text = reader["商品價格"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select  * from commodity WHERE 商品id < @ID ORDER BY 商品id desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", lblID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["商品id"].ToString();
                txt商品名稱.Text = reader["商品名稱"].ToString();
                txt商品價格.Text = reader["商品價格"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//伺服器名稱(@:不考慮特殊字元
            scsb.InitialCatalog = "breakfast";//資料庫名稱
            scsb.IntegratedSecurity = true; //WINDOWs驗證

            strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select * from commodity;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv商品資料列表.DataSource = dt;
                return;
            }
            reader.Close();
            con.Close();

        }
    }
}
