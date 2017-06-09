using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using WebDiff.Data;

namespace WebDiff.Controls
{
   public partial class SessionBrowser : UserControl
   {
      private Config _filterConfig;
      public PictureBox PictureBox { get; set; } = null;
      public ContextMenuStrip TreeViewContextMenuStrip { get; set; } = null;
      public SessionBrowser()
      {
         InitializeComponent();
      }

      public Session SelectedSession
      {
         get { return sessionListBox.SelectedItem as Session; }
      }

      public void FilterOnConfig(Config config)
      {
         _filterConfig = config;
         LoadSessions();
      }
      
      private void sessionListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (sessionListBox.SelectedItem == null)
            return;

         urlTreeView.Nodes.Clear();
         if ((sessionListBox.SelectedItem as Session).Urls == null)
         {
            TreeNode node = new TreeNode("No Urls in this Session");
            urlTreeView.Nodes.Add(node);
         }
         else
         {
            foreach (var url in (sessionListBox.SelectedItem as Session).Urls)
            {
               if (url.Uri == "")
                  continue;

               TreeNode node = new TreeNode(url.Uri);
               node.Tag = url;
               node.ContextMenuStrip = TreeViewContextMenuStrip;
               urlTreeView.Nodes.Add(node);
            }
         }
            
         
         
      }

      public void LoadSessions()
      {       
         sessionListBox.Items.Clear();
         List<Session> sessions;
         if (_filterConfig != null)
         {
            sessions = DataSource.GetInstance().GetAllForConfig<Session>(_filterConfig);
         }
         else
         {
            sessions = DataSource.GetInstance().GetAll<Session>();
         }
         foreach (var session in sessions)
         {
            sessionListBox.Items.Add(session);
         }
      }

      private void urlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
      {
         if (urlTreeView.SelectedNode.Tag is Url && PictureBox != null)
         {
            PictureBox.ImageLocation = (urlTreeView.SelectedNode.Tag as Url).PicturePath;
         }

         TreeViewContextMenuStrip.Tag = urlTreeView.SelectedNode.Tag;
      }
   }  
}
