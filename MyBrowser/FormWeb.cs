using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.Util;
using System.Windows.Forms;
using WebKit;
namespace MyBrowser
{
    public partial class FormWeb : Form
    {
        private readonly string Root;
        private readonly MyClass MyClass;
        private string _url;
        
        public FormWeb(string url)
        {
            InitializeComponent();
            Root = AppDomain.CurrentDomain.BaseDirectory;
            MyClass = new MyClass();
            _url = url;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEvent();
            webKitBrowser1.GetScriptManager.ScriptObject = MyClass;
            webKitBrowser1.Navigate(_url);
        }

        private void btnExecuteScript_Click(object sender, EventArgs e)
        {
            
           var r =  webKitBrowser1.GetScriptManager.EvaluateScript("myScript(5);");
        }

        private void AddEvent()
        {
            webKitBrowser1.Navigating += new WebKitBrowserNavigatingEventHandler(NavigatingHanler);
        }

        private void NavigatingHanler(object sender, WebKitBrowserNavigatingEventArgs e)
        {
            
        }
    }

   
}
