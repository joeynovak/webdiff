using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDiff.Data;

namespace WebDiff.Forms
{
   public partial class SelectConfigForm : Form
   {
      public SelectConfigForm()
      {
         InitializeComponent();
      }

      public Config SelectedConfig => configsListBox.SelectedItem as Config;

      private void SelectConfigForm_Load(object sender, EventArgs e)
      {
         List<Config> configs = DataSource.GetInstance().GetAll<Config>();
         foreach (var config in configs)
         {
            if(config.Title != null)
               this.configsListBox.Items.Add(config);
         }
      }

      private void newButton_Click(object sender, EventArgs e)
      {
         ConfigForm form = new ConfigForm();
         DialogResult dr = form.ShowDialog(this);
         if (dr == DialogResult.OK)
         {
            this.configsListBox.Items.Add(form.Config);
            this.configsListBox.SelectedItem = form.Config;
         }        
      }

      private void editButton_Click(object sender, EventArgs e)
      {
         ConfigForm form = new ConfigForm();
         form.Config = SelectedConfig;
         DialogResult dr = form.ShowDialog(this);   
         if(dr == DialogResult.OK)
            configsListBox.Items[configsListBox.SelectedIndex] = configsListBox.SelectedItem;      
      }

      private void configsListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (configsListBox.SelectedIndex != -1)
            editButton.Enabled = true;
         else
            editButton.Enabled = false;
      }

      private void okButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void cancelButton_Click(object sender, EventArgs e)
      {

      }
   }
}
