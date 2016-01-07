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
        private WebKitBrowser webKitBrowser1;
        private bool _separatePressd;
        public Form1()
        {
            _root = AppDomain.CurrentDomain.BaseDirectory;
            _myClass = new MyClass();
           
            InitializeComponent();
            InitWebKitBrowser();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void InitWebKitBrowser()
        {
            webKitBrowser1 = new WebKitBrowser();
            webKitBrowser1.Dock = DockStyle.Fill;
            pContent.Controls.Add(webKitBrowser1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.AllowDrop = true;
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

        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveBrowser();
        }

        private void MoveBrowser()
        {
            var f = new FormTemp();
            f.Show();
            f.Left = MousePosition.X-40;
            f.Top = MousePosition.Y-10;
            f.Controls.Add(webKitBrowser1);
            f.FormClosing += (s, ce) => { pContent.Controls.Add(webKitBrowser1); };
            ReleaseCapture();
            SendMessage(f.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            var c = e.Data.GetData("System.Windows.Forms.Button") as Control;
            var p = groupBox1.PointToClient(MousePosition);
            c.Left = p.X;
            c.Top = p.Y;
           groupBox1.Controls.Add(c);
        }

        private void btnSeparate_MouseDown(object sender, MouseEventArgs e)
        {
            _separatePressd = true;
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btnSeparate_MouseUp(object sender, MouseEventArgs e)
        {
            //_dragPressd = false;
        }

        private void btnSeparate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_separatePressd)
            {
                var cp = btnSeparate.PointToClient(MousePosition);
                if (cp.Y >= btnSeparate.Height)//鼠标按下移动超出按钮底部
                {
                    _separatePressd = false;
                    MoveBrowser();
                }
            }
        }

        private void btnSeparate_Click(object sender, EventArgs e)
        {
            _separatePressd = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1, DragDropEffects.Move);
        }

   
        private void button1_Click(object sender, EventArgs e)
        {

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
