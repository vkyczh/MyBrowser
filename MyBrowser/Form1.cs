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
    public partial class Form1 : Form
    {
        private readonly string _root;
        private readonly MyClass _myClass;
        public Form1()
        {
            _root = AppDomain.CurrentDomain.BaseDirectory;
            _myClass = new MyClass();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEvent();
            webKitBrowser1.AllowDownloads = true;
            webKitBrowser1.GetScriptManager.ScriptObject = _myClass;
            webKitBrowser1.Navigate(HttpUtility.UrlPathEncode(string.Format("file:///{0}Pages//Index.html", _root)).Replace("\\", "//"));
        }

        private void btnExecuteScript_Click(object sender, EventArgs e)
        {
            
           var r =  webKitBrowser1.GetScriptManager.EvaluateScript("myScript(5);");
        }

        private void AddEvent()
        {
            webKitBrowser1.Navigating += new WebKitBrowserNavigatingEventHandler(NavigatingHanler);
            webKitBrowser1.ShowJavaScriptAlertPanel += new ShowJavaScriptAlertPanelEventHandler(delegate(object o, ShowJavaScriptAlertPanelEventArgs e)
            {
                MessageBox.Show(e.Message);
            });
            webKitBrowser1.ShowJavaScriptConfirmPanel += new ShowJavaScriptConfirmPanelEventHandler(delegate(object o, ShowJavaScriptConfirmPanelEventArgs e)
            {
                e.ReturnValue = MessageBox.Show(e.Message, "", MessageBoxButtons.OKCancel) == DialogResult.OK;
            });
            webKitBrowser1.NewWindowCreated+=new NewWindowCreatedEventHandler(newWindowCreatedHandler);
        }

        private void NavigatingHanler(object sender, WebKitBrowserNavigatingEventArgs e)
        {
            //if(e.Url.AbsolutePath.EndsWith("Index.html"))
            //    return;
            //var w = new FormWeb(e.Url.AbsoluteUri);
            //w.Show();
            //e.Cancel = true;
        }

        public void newWindowCreatedHandler(object sender, NewWindowCreatedEventArgs e)
        {
            var w = new FormNewWeb(e.WebKitBrowser);
            w.Show();
        }
    }

    [ComVisible(true)]
    public class MyClass
    {
        public void Hi(string info)
        {
            MessageBox.Show(info);
        }

        public void Hello()
        {
            MessageBox.Show("Hello");
        }
    }
}
