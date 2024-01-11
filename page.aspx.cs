//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Services.Description;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace K_Project
//{
//    public partial class page : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                throw new ApplicationException("Throw error");
//            }
//            catch (Exception ee)
//            {
//                Label1.Text = "Sorry, an Error occured.please try Again later.";
               
//            }

//        }

//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string path = "~/" + DateTime.Today.ToString("dd-MM-yy") + ".txt";
//                if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
//                {
//                    File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();
//                }
//                using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
//                {
//                    w.WriteLine("\r\nLog Entry :");
//                    w.WriteLine("{0}", DateTime.Now.ToString(CultureInfo.InvariantCulture));
//                    string err = "Error in:" + System.Web.HttpContext.Current.Request.Url.ToString() +
//                        ".\n\nError Message:" + Message;
//                    w.WriteLine(err);
//                    w.WriteLine("=========================================================");
//                    w.Flush();
//                    w.Close();

//                }


                


//            }
//    }
//    }
//}