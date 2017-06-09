namespace WebDiff.Controls
{
   partial class SessionBrowser
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.sessionListBox = new System.Windows.Forms.ListBox();
         this.urlTreeView = new System.Windows.Forms.TreeView();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 539);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(3, 3);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.sessionListBox);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.urlTreeView);
         this.splitContainer1.Size = new System.Drawing.Size(314, 533);
         this.splitContainer1.SplitterDistance = 104;
         this.splitContainer1.TabIndex = 0;
         // 
         // sessionListBox
         // 
         this.sessionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionListBox.FormattingEnabled = true;
         this.sessionListBox.Location = new System.Drawing.Point(0, 0);
         this.sessionListBox.Name = "sessionListBox";
         this.sessionListBox.Size = new System.Drawing.Size(104, 533);
         this.sessionListBox.TabIndex = 2;
         this.sessionListBox.SelectedIndexChanged += new System.EventHandler(this.sessionListBox_SelectedIndexChanged);
         // 
         // urlTreeView
         // 
         this.urlTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.urlTreeView.Location = new System.Drawing.Point(0, 0);
         this.urlTreeView.Name = "urlTreeView";
         this.urlTreeView.Size = new System.Drawing.Size(206, 533);
         this.urlTreeView.TabIndex = 1;
         this.urlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.urlTreeView_AfterSelect);
         // 
         // SessionBrowser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "SessionBrowser";
         this.Size = new System.Drawing.Size(320, 539);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.ListBox sessionListBox;
      private System.Windows.Forms.TreeView urlTreeView;
   }
}
