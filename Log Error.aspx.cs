using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.IO;

namespace K_Project
{
    public partial class Log_Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var i = 5;
                var j = 0;
                var r = i / j;
                Label1.Text = r.ToString();
            }
            catch (DivideByZeroException ex)
            {
                Label1.Text = "Sorry,an error Occured.please try again later.";
                this.Logerror(ex.ToString());
            }

        }   
        public void Logerror(string msg)
        {
            try
            {
                string eventlog = "App";
                string eventsource = "kajal";
                 if (!EventLog.SourceExists(eventsource))
                {
                    EventLog.CreateEventSource(eventsource, eventlog);
                }
                using (EventLog mylog = new EventLog(eventlog))
                {
                    mylog.Source = eventsource;
                    string error = "\r\nLog written at :" + DateTime.Now.ToString() +
                        "\r\nError occurred on page:" +
                        System.Web.HttpContext.Current.Request.Url.ToString() +
                        "\r\n\nHere is the actual error:\n" + msg;
                    mylog.WriteEntry(error, EventLogEntryType.Error);

                }
            }
            catch(Exception ex)
            {
                this.Logerror(ex.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = string.Format("Errorfile_{0}.txt", DateTime.Now.ToString("MM.dd.YYYY"));
                string path = Server.MapPath("~/File/") + filename;
                if (System.IO.File.Exists(path))
                {
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    Response.AppendHeader("Content-Dispostion", "attachment; filename" + filename);
                    Response.TransmitFile(path);
                    Response.End();
                }
                else
                {
                    Label1.Text = "No error log file available for download.";
                }

            }
            catch (Exception ex) 
                
                 {
                    Label1.Text = "An error oocurred while trying to download the log file.";
                this.Logerror(ex.ToString());   
                    
                }
            }
            


        }

    }


            



                



            
                    
    




                
            

        
    
