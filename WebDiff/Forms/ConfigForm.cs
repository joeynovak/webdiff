using Stn.Lib.CsMissingMethods.String;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDiff.Data;

namespace WebDiff.Forms
{
   public partial class ConfigForm : Form
   {
      public Config Config = new Config();

      public ConfigForm()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void label4_Click(object sender, EventArgs e)
      {

      }

      private void textBox3_TextChanged(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         UpdateConfig();
         DataSource.GetInstance().Save(Config);
         Close();
      }

      private void UpdateUi()
      {
         allowedCrawlDomainsTextBox.Text = "";
         linkedPagesAllowedDomainsTextBox.Text = "";
         startUrlsTextBox.Text = "";
         titleTextBox.Text = "";

         if (Config.AllowedDomains != null)
            allowedCrawlDomainsTextBox.Text = string.Join("\r\n", Config.AllowedDomains);

         if(Config.CapturePagesLinkedInTheseDomains != null)
            linkedPagesAllowedDomainsTextBox.Text = string.Join("\r\n", Config.CapturePagesLinkedInTheseDomains);

         if(Config.StartUrls != null)
            startUrlsTextBox.Text = string.Join("\r\n", Config.StartUrls);         

         titleTextBox.Text = Config.Title;
      }

      private void UpdateConfig()
      {
         
         List<string> startUrls = new List<string>();
         List<string> captureLinkedPagesOnlyDomains = new List<string>();
         List<string> allowedDomains = new List<string>();
         foreach (var startUrl in startUrlsTextBox.Text.Split("\r\n"))         
            if(startUrl.Trim() != "")
               startUrls.Add(startUrl.Trim());                     

         foreach (var captureLinkedPagesInDomain in linkedPagesAllowedDomainsTextBox.Text.Split("\r\n"))
            if (captureLinkedPagesInDomain.Trim() != "")
               captureLinkedPagesOnlyDomains.Add(captureLinkedPagesInDomain.Trim());

         foreach (var allowedDomain in allowedCrawlDomainsTextBox.Text.Split("\r\n"))
            if (allowedDomain.Trim() != "")
               allowedDomains.Add(allowedDomain.Trim());

         Config.AllowedDomains = allowedDomains.ToArray();
         Config.CapturePagesLinkedInTheseDomains = captureLinkedPagesOnlyDomains.ToArray();
         Config.StartUrls = startUrls.ToArray();
         Config.Title = titleTextBox.Text;         
      }

      private void ConfigForm_Shown(object sender, EventArgs e)
      {
         UpdateUi();
      }

      private void ConfigForm_Load(object sender, EventArgs e)
      {

      }
   }
}
