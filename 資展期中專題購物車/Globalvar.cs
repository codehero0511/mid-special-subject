using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中個人專題_訂購單
{
    internal class Globalvar
    {
        public static string 訂購人資訊 = "";// static 靜態變數,可以靜態執行且不會消失
        public static List<ArrayList> list訂購品項資料 = new List<ArrayList>();
        public static bool is外帶 = false;
        public static string strbreakfastconnectionString = "";
        //public static bool is登入認證成功 = false;
        public static int 權限 = 0;//一般會員:10000,特殊會員:5000 ,店員:1000,店長:100,Sys:10
        public static string 使用者名稱 = "";
        
    }
}
