using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中個人專題_訂購單
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
      
        private void btn菜單Menu_Click(object sender, EventArgs e)
        {
           
            Menu MyMenu = new Menu();
            MyMenu.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
         
        }

        private void btn會員表單_Click(object sender, EventArgs e)
        {
           members Mymembers = new members();
            Mymembers.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            FormOrderList formOrderList = new FormOrderList();
            formOrderList.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            Products MyProducts = new Products();
            MyProducts.ShowDialog();
        }

        private void btn員工資料_Click(object sender, EventArgs e)
        {
            Persons MyPersons = new Persons();
            MyPersons.ShowDialog();
        }

        

        private void btn登出_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
