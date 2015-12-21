using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.Navigate("http://google.com.tw");
            this.WindowState = FormWindowState.Maximized;
        }


        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(toolStripComboBoxUrl.Text);
        }


        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            updateState();

        }
        private void updateState() 
        {
            //上一頁跟下一頁的按鈕控制項 吐出bool
            toolStripButtonBack.Enabled = webBrowser.CanGoBack;
            toolStripButtonNext.Enabled = webBrowser.CanGoForward;
            if (webBrowser.Url != null)
                toolStripComboBoxUrl.Text = webBrowser.Url.ToString();
        }
        //輸入網址
        private void toolStripComboBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                webBrowser.Navigate(toolStripComboBoxUrl.Text);
        }
        //顯示原始碼
        private void toolStripButtonSource_Click(object sender, EventArgs e)
        {
            FormSource formSource = new FormSource();
            string html = webBrowser.DocumentText;
            formSource.setSource(html);
            formSource.Visible = true;
        }
    }
}
