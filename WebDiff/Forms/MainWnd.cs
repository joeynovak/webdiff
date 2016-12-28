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
        DataSource dataSource = new DataSource();
        public MainWnd()
        {
            InitializeComponent();
            loadSessions();
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
            SessionForm sessionForm = new SessionForm(config);
            sessionForm.Show(this);
         sessionForm.Crawl();
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
            loadSessions();
        }

        private void loadSessions()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<Session> sessions = dataSource.GetAll<Session>();
            listBox1.Items.AddRange(sessions.ToArray());
            listBox2.Items.AddRange(sessions.ToArray());
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void fetchPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prompt First...
            CompareResults results = WebDiff.CompareSessions((Session) listBox1.SelectedItem, (Session) listBox2.SelectedItem);
           DataSource.GetInstance().Save(results);
            MessageBox.Show("Saved To Mongo");

        }

      private void MainWnd_Load(object sender, EventArgs e)
      {
         List<Config> configs = DataSource.GetInstance().GetAll<Config>();
         foreach (var config in configs)
         {
            if(config.Title != null)
               configList.Items.Add(config);
         }
      }

      private void configList_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }    
}
