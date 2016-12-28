using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using OpenQA.Selenium;
using WebDiff.Data;
using WebDiff.Properties;

namespace WebDiff.Forms
{
   public partial class SessionForm : Form, ICrawlProgressListener
   {
      private WebDiff webDiff;
      private Config _config;
      private string _originalText;

      public SessionForm(Config config)
      {
         InitializeComponent();
         _config = config;
      }

      public void Crawl() {          
         _originalText = this.Text;
         this.Text += " Crawling...";
         //Build list of urls to crawl and allowed domains.
         List<string> list = new List<string>(urlTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
         HashSet<string> domains = new HashSet<string>();
         
         foreach (var uri in _config.AllowedDomains)
         {
            domains.Add(UrlCleaner.UrlCleaner.GetUri(uri).Host);
         }

         webDiff = new WebDiff(_config);
         webDiff.RegisterProgressListener(this);
         webDiff.SavePicturesToPath = Properties.Settings.Default.DefaultPicturePath + "\\" + DateTime.Now.ToFileTimeUtc() + "\\";
         Directory.CreateDirectory(webDiff.SavePicturesToPath);

         
            webDiff.Crawl();


         closeButton.Enabled = true;
         webDiff.Close();

         SaveSessionToMongo();
         this.Text = _originalText;
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void CloseButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public void SaveSessionToMongo()
      {         
         Session session = new Session();
         session.Time = DateTime.Now;
         session.Urls = webDiff.CrawledDomainUrlsAsUrlObjects.ToArray();
         //session.AllowedDomains = webDiff.AllowedDomains.ToArray();
         //session.Title = session.ToString();
         session.ConfigAtTimeOfSession = _config;
         session.Config = _config._id;

         DataSource.GetInstance().Save(session);
      }

      public void UrlCrawled(string url)
      {
         this.urlTextBox.AppendText(url + "\r\n");
      }

      private void SessionFrm_Load(object sender, EventArgs e)
      {

      }

      private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}
