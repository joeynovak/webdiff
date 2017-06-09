using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WebDiff.Data;

namespace WebDiff.Forms
{
   public partial class CrawlProgressForm : Form, ICrawlProgressListener
   {
      private WebDiffMainClass _webDiffMainClass;
      private Config _config;
      private string _originalText;

      public CrawlProgressForm(Config config)
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
            if(uri.Trim() != "")
               domains.Add(UrlCleaner.UrlCleaner.GetUri(uri.Trim()).Host);
         }

         _webDiffMainClass = new WebDiffMainClass(_config);
         _webDiffMainClass.RegisterProgressListener(this);
         _webDiffMainClass.SavePicturesToPath = Properties.Settings.Default.DefaultPicturePath + "\\" + DateTime.Now.ToFileTimeUtc() + "\\";
         Directory.CreateDirectory(_webDiffMainClass.SavePicturesToPath);

         
            _webDiffMainClass.Crawl();


         closeButton.Enabled = true;
         _webDiffMainClass.Close();

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
         session.Urls = _webDiffMainClass.CrawledDomainUrlsAsUrlObjects.ToArray();
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
