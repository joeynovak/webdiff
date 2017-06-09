using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using WebDiff.Data;

namespace WebDiff.Forms
{
   public partial class MainWnd : Form
   {       
      public MainWnd()
      {
         InitializeComponent();
         UpdateSessionLists();
         sessionBrowser1.PictureBox = sessionBrowser1pictureBox;
         sessionBrowser2.PictureBox = sessionBrowser2pictureBox;
         sessionBrowser1.TreeViewContextMenuStrip = urlRightClickContextMenuStrip;
         sessionBrowser2.TreeViewContextMenuStrip = urlRightClickContextMenuStrip;
      }

      private void groupBox2_Enter(object sender, EventArgs e)
      {

      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         
      }

      private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Config config = SelectConfig();
         if (config != null)
         {
            CrawlProgressForm crawlProgressForm = new CrawlProgressForm(config);
            crawlProgressForm.Show(this);
            crawlProgressForm.Crawl();
         }
      }

      private Config SelectConfig()
      {
         SelectConfigForm form = new SelectConfigForm();
         DialogResult dr = form.ShowDialog(this);
         if (dr == DialogResult.OK)
            return form.SelectedConfig;
         else
            return null;
      }

      private void refreshSessionListToolStripMenuItem_Click(object sender, EventArgs e)
      {
         UpdateSessionLists();
      }

      private void UpdateSessionLists()
      {
         sessionBrowser1.LoadSessions();
         sessionBrowser2.LoadSessions();
      }

      private void fetchPhotosToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void compareSessionButton_Clicked(object sender, EventArgs e)
      {
         //Prompt First...
         CompareResults results = WebDiffMainClass.CompareSessions(sessionBrowser1.SelectedSession, sessionBrowser1.SelectedSession);
         DataSource.GetInstance().Save(results);
         MessageBox.Show("Saved To Mongo");

      }

      private void MainWnd_Load(object sender, EventArgs e)
      {
         List<Config> configs = DataSource.GetInstance().GetAll<Config>();
         configList.Items.Clear();
         configList.Items.Add("*");
         foreach (var config in configs)
         {
            if (config.Title != null)
               configList.Items.Add(config);
         }
      }

      private void configList_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (configList.SelectedItem is string && (configList.SelectedItem as string) == "*")
         {
            sessionBrowser1.FilterOnConfig(null);
            sessionBrowser2.FilterOnConfig(null);
         }
         else
         {
            sessionBrowser1.FilterOnConfig(configList.SelectedItem as Config);
            sessionBrowser2.FilterOnConfig(configList.SelectedItem as Config);
         }         
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
      {

      }

      private void urlRightClickContextMenuStrip_Opening(object sender, CancelEventArgs e)
      {

      }

      private void openUrlToolStripMenuItem_Click(object sender, EventArgs e)
      {
         System.Diagnostics.Process.Start(((sender as ToolStripMenuItem).Owner.Tag as Url).Uri);
      }
   }
}
