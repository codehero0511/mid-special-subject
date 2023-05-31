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
    public partial class Persons : Form
    {
        SqlConnectionStringBuilder scsb;//SQL連結字串建立器
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果

        public Persons()
        {
            InitializeComponent();
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            產生員工資料列表DGV();
        }
        void 產生員工資料列表DGV()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//伺服器名稱(@:不考慮特殊字元
            scsb.InitialCatalog = "breakfast";//資料庫名稱
            scsb.IntegratedSecurity = true; //WINDOWs驗證

            strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select * from Persons;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv員工資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }


        private void btn第一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 1 * from Persons ORDER BY 員工id ASC";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["員工id"].ToString();
                txt姓名.Text = reader["員工姓名"].ToString();
                txt電話.Text = reader["員工電話"].ToString();
                txt薪資.Text = reader["員工薪資"].ToString();
                txt權限.Text = reader["權限"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 1 * from Persons ORDER BY 員工id  desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["員工id"].ToString();
                txt姓名.Text = reader["員工姓名"].ToString();
                txt電話.Text = reader["員工電話"].ToString();
                txt薪資.Text = reader["員工薪資"].ToString();
                txt權限.Text = reader["權限"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select  * from Persons WHERE 員工id > @ID ORDER BY 員工id ASC";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", lblID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["員工id"].ToString();
                txt姓名.Text = reader["員工姓名"].ToString();
                txt電話.Text = reader["員工電話"].ToString();
                txt薪資.Text = reader["員工薪資"].ToString();
                txt權限.Text = reader["權限"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select  * from Persons WHERE 員工id < @ID ORDER BY 員工id  desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", lblID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lblID.Text = reader["員工id"].ToString();
                txt姓名.Text = reader["員工姓名"].ToString();
                txt電話.Text = reader["員工電話"].ToString();
                txt薪資.Text = reader["員工薪資"].ToString();
                txt權限.Text = reader["權限"].ToString();
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

            string strSQL = "select * from  Persons;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv員工資料列表.DataSource = dt;
                return;
            }
            reader.Close();
            con.Close();
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString); //建立SqlConnection的物件
            con.Open();//開啟SQLConnection
            string strSQL = "select top(100)* from Persons";//建立SQL語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int 員工id = (int)reader["員工id"];
                string 員工姓名 = reader["員工姓名"].ToString();
                string 員工電話 = reader["員工電話"].ToString();
                string 員工薪資 = reader["員工薪資"].ToString();
                int 權限 = (int)reader["權限"];


                strMsg += $"{員工id} ,{員工姓名} ,{員工電話} {員工薪資} 元 權限:{權限} \n";
                count += 1;
            }
            strMsg += "員工資料筆數:" + count ;

            reader.Close();//關閉
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from Persons where 員工姓名 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt姓名.Text.Trim()}%");//Trim:去前後的空白
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["員工id"].ToString();
                    txt姓名.Text = reader["員工姓名"].ToString();
                    txt電話.Text = reader["員工電話"].ToString();
                    txt薪資.Text =reader["員工薪資"].ToString();
                    txt權限.Text = reader["權限"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }

                reader.Close();//關閉
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入員工姓名搜尋關鍵字");
            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if ((intID > 0) && (txt姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update Persons set 員工姓名=@NewName,員工電話=@NewTelephone,員工薪資 =@NewPrice,權限 =@NewPermission where 員工id =@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                cmd.Parameters.AddWithValue("@NewTelephone", txt電話.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPrice", txt薪資.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPermission", txt薪資.Text.Trim());
                cmd.Parameters.AddWithValue("@SearchID", intID);
               
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"員工資料修改成功,{rows}筆資料受影響");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt薪資.Text != "") && (txt權限.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into Persons values(@NewName,@NewTelephone,@NewPrice,@NewPermission);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                cmd.Parameters.AddWithValue("@NewTelephone", txt電話.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPrice", txt薪資.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPrice", txt薪資.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPermission", txt權限.Text.Trim());
                //int intPrice = 0;
                //Int32.TryParse(txt薪資.Text.Trim(), out intPrice);
                //cmd.Parameters.AddWithValue("@NewPrice", intPrice);

                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                MessageBox.Show($"員工基本資料新增完畢,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("員工姓名,員工電話,員工薪資必填");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from Persons where 員工id =@DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"員工基本資料已刪除,{rows}筆資料受影響");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt薪資.Clear();
        }

        private void dgv員工資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv員工資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);

                if (selectedID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from Persons where 員工id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", selectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["員工id"].ToString();
                        txt姓名.Text = reader["員工姓名"].ToString();
                        txt電話.Text = reader["員工電話"].ToString();
                        txt薪資.Text = reader["員工薪資"].ToString();
                        txt權限.Text = reader["權限"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
