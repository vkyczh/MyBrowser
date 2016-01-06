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
    public partial class FormNewWeb : Form
    {
        private readonly string Root;
        private readonly MyClass MyClass;
        private string _url;
        private WebKitBrowser _webKitBrowser;
        public FormNewWeb(WebKitBrowser webKitBrowser)
        {
            _webKitBrowser = webKitBrowser;
            InitializeComponent();
            Root = AppDomain.CurrentDomain.BaseDirectory;
            MyClass = new MyClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitWebBrowser();
        }

        private void InitWebBrowser()
        {
            AddEvent();
            _webKitBrowser.Dock = DockStyle.Fill;
            //必须先添加到控件再设置ScriptObject属性
            _webKitBrowser.Name = "OpenWebKitSharp";
            pContent.Controls.Add(_webKitBrowser);
            _webKitBrowser.GetScriptManager.ScriptObject = MyClass;
            
        }

        private void btnExecuteScript_Click(object sender, EventArgs e)
        {
           var r =  _webKitBrowser.GetScriptManager.EvaluateScript("myScript(5);");
        }

        private void AddEvent()
        {
            _webKitBrowser.Navigating += new WebKitBrowserNavigatingEventHandler(NavigatingHanler);
        }

        private void NavigatingHanler(object sender, WebKitBrowserNavigatingEventArgs e)
        {
            
        }
    }

   
}
