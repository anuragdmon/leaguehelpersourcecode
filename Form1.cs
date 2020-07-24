using AutoUpdaterDotNET;
using CefSharp;
using CefSharp.WinForms;
using LeagueHelperClass;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace LeagueBuildHelper
{
    public partial class Form1 : Form, LeagueApplicationVer
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }
        public Assembly ApplicationAssembly => Assembly.GetExecutingAssembly();

        ChromiumWebBrowser chrome;

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            //txtUrl.Text = "www.google.com";
            //chrome = new ChromiumWebBrowser(txtUrl.Text);
            this.pContainer.Controls.Add(chrome);
            chrome = new ChromiumWebBrowser("https://www.vedapanchakarma.com/sharpUpdate/downloads/changelog/preview.html");
            this.pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
            txtUrl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUrl.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                txtUrl.Text = txtUrl.Text.ToString();
            }));
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text == "wukong")
            {
                var url = "https://app.mobalytics.gg/lol/champions/monkeyking/build";
                chrome.Load(url);
            }
            else
            {
                var url = "https://app.mobalytics.gg/lol/champions/" + txtUrl.Text.ToString() + "/build";
                chrome.Load(url);
            }
        }
        private void btnCounter_Click(object sender, EventArgs e)
        {
            var url = "http://www.championcounter.com/" + txtUrl.Text.ToString();
            chrome.Load(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var summoner = "https://euw.op.gg/summoner/userName=" + txtSummoner.Text.ToString();
            chrome.Load(summoner);
        }

        private void btnEuw_Click(object sender, EventArgs e)
        {
            txtPing.Text = "";
            Ping ping = new Ping();
            PingReply reply = ping.Send("185.82.209.9");
            txtPing.AppendText(reply.RoundtripTime.ToString());
            if (reply.RoundtripTime > 120)
            {
                txtPing.BackColor = Color.Yellow;
            }
            else
            {
                txtPing.BackColor = Color.LawnGreen;
            }
            if (reply.RoundtripTime > 210)
            {
                txtPing.BackColor = Color.Red;
            }
            else
            {
                txtPing.BackColor = Color.Yellow;
            }
        }

        private void btnGarena_Click(object sender, EventArgs e)
        {
            txtPing.Text = "";
            Ping ping = new Ping();
            PingReply reply = ping.Send("dynamodb.ap-southeast-1.amazonaws.com");
            txtPing.AppendText(reply.RoundtripTime.ToString());
            if (reply.RoundtripTime < 120)
            {
                txtPing.BackColor = Color.LawnGreen;
            }
            else
            {
                txtPing.BackColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://www.vedapanchakarma.com/sharpUpdate/downloads/AutoUpdater.xml");
        }
    }
}
