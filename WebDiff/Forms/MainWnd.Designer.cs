using WebDiff.Controls;

namespace WebDiff.Forms
{
   partial class MainWnd
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.refreshSessionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1 = new System.Windows.Forms.Panel();
         this.button1 = new System.Windows.Forms.Button();
         this.configLabel = new System.Windows.Forms.Label();
         this.configList = new System.Windows.Forms.ComboBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.sessionsSplitContainer = new System.Windows.Forms.SplitContainer();
         this.sessionBrowser1 = new WebDiff.Controls.SessionBrowser();
         this.urlRightClickContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.openUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sessionBrowser2 = new WebDiff.Controls.SessionBrowser();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.sessionBrowser2pictureBox = new System.Windows.Forms.PictureBox();
         this.sessionBrowser1pictureBox = new System.Windows.Forms.PictureBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.tableLayoutPanel1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sessionsSplitContainer)).BeginInit();
         this.sessionsSplitContainer.Panel1.SuspendLayout();
         this.sessionsSplitContainer.Panel2.SuspendLayout();
         this.sessionsSplitContainer.SuspendLayout();
         this.urlRightClickContextMenuStrip.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sessionBrowser2pictureBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sessionBrowser1pictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 407);
         this.tableLayoutPanel1.TabIndex = 0;
         this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(703, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.refreshSessionListToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // newSessionToolStripMenuItem
         // 
         this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
         this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.newSessionToolStripMenuItem.Text = "New Session";
         this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
         // 
         // refreshSessionListToolStripMenuItem
         // 
         this.refreshSessionListToolStripMenuItem.Name = "refreshSessionListToolStripMenuItem";
         this.refreshSessionListToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.refreshSessionListToolStripMenuItem.Text = "Refresh Session List";
         this.refreshSessionListToolStripMenuItem.Click += new System.EventHandler(this.refreshSessionListToolStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.button1);
         this.panel1.Controls.Add(this.configLabel);
         this.panel1.Controls.Add(this.configList);
         this.panel1.Location = new System.Drawing.Point(3, 28);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(697, 24);
         this.panel1.TabIndex = 3;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(320, 1);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(132, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Compare Sessions";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.compareSessionButton_Clicked);
         // 
         // configLabel
         // 
         this.configLabel.AutoSize = true;
         this.configLabel.Location = new System.Drawing.Point(9, 7);
         this.configLabel.Name = "configLabel";
         this.configLabel.Size = new System.Drawing.Size(40, 13);
         this.configLabel.TabIndex = 3;
         this.configLabel.Text = "Config:";
         // 
         // configList
         // 
         this.configList.FormattingEnabled = true;
         this.configList.Location = new System.Drawing.Point(55, 3);
         this.configList.Name = "configList";
         this.configList.Size = new System.Drawing.Size(259, 21);
         this.configList.TabIndex = 2;
         this.configList.SelectedIndexChanged += new System.EventHandler(this.configList_SelectedIndexChanged);
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(3, 58);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.sessionsSplitContainer);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
         this.splitContainer1.Size = new System.Drawing.Size(697, 346);
         this.splitContainer1.SplitterDistance = 172;
         this.splitContainer1.TabIndex = 5;
         // 
         // sessionsSplitContainer
         // 
         this.sessionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionsSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.sessionsSplitContainer.Name = "sessionsSplitContainer";
         // 
         // sessionsSplitContainer.Panel1
         // 
         this.sessionsSplitContainer.Panel1.Controls.Add(this.sessionBrowser1);
         // 
         // sessionsSplitContainer.Panel2
         // 
         this.sessionsSplitContainer.Panel2.Controls.Add(this.sessionBrowser2);
         this.sessionsSplitContainer.Size = new System.Drawing.Size(697, 172);
         this.sessionsSplitContainer.SplitterDistance = 345;
         this.sessionsSplitContainer.TabIndex = 1;
         // 
         // sessionBrowser1
         // 
         this.sessionBrowser1.ContextMenuStrip = this.urlRightClickContextMenuStrip;
         this.sessionBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionBrowser1.Location = new System.Drawing.Point(0, 0);
         this.sessionBrowser1.Name = "sessionBrowser1";
         this.sessionBrowser1.PictureBox = null;
         this.sessionBrowser1.Size = new System.Drawing.Size(345, 172);
         this.sessionBrowser1.TabIndex = 0;
         this.sessionBrowser1.TreeViewContextMenuStrip = null;
         // 
         // urlRightClickContextMenuStrip
         // 
         this.urlRightClickContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUrlToolStripMenuItem});
         this.urlRightClickContextMenuStrip.Name = "urlRightClickContextMenuStrip";
         this.urlRightClickContextMenuStrip.Size = new System.Drawing.Size(180, 26);
         this.urlRightClickContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.urlRightClickContextMenuStrip_Opening);
         // 
         // openUrlToolStripMenuItem
         // 
         this.openUrlToolStripMenuItem.Name = "openUrlToolStripMenuItem";
         this.openUrlToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
         this.openUrlToolStripMenuItem.Text = "Open Url In Browser";
         this.openUrlToolStripMenuItem.Click += new System.EventHandler(this.openUrlToolStripMenuItem_Click);
         // 
         // sessionBrowser2
         // 
         this.sessionBrowser2.ContextMenuStrip = this.urlRightClickContextMenuStrip;
         this.sessionBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionBrowser2.Location = new System.Drawing.Point(0, 0);
         this.sessionBrowser2.Name = "sessionBrowser2";
         this.sessionBrowser2.PictureBox = null;
         this.sessionBrowser2.Size = new System.Drawing.Size(348, 172);
         this.sessionBrowser2.TabIndex = 0;
         this.sessionBrowser2.TreeViewContextMenuStrip = null;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel2.Controls.Add(this.sessionBrowser2pictureBox, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.sessionBrowser1pictureBox, 0, 0);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 170);
         this.tableLayoutPanel2.TabIndex = 4;
         // 
         // sessionBrowser2pictureBox
         // 
         this.sessionBrowser2pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionBrowser2pictureBox.Location = new System.Drawing.Point(351, 3);
         this.sessionBrowser2pictureBox.Name = "sessionBrowser2pictureBox";
         this.sessionBrowser2pictureBox.Size = new System.Drawing.Size(343, 164);
         this.sessionBrowser2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.sessionBrowser2pictureBox.TabIndex = 2;
         this.sessionBrowser2pictureBox.TabStop = false;
         // 
         // sessionBrowser1pictureBox
         // 
         this.sessionBrowser1pictureBox.BackColor = System.Drawing.SystemColors.Control;
         this.sessionBrowser1pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.sessionBrowser1pictureBox.Location = new System.Drawing.Point(3, 3);
         this.sessionBrowser1pictureBox.Name = "sessionBrowser1pictureBox";
         this.sessionBrowser1pictureBox.Size = new System.Drawing.Size(342, 164);
         this.sessionBrowser1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.sessionBrowser1pictureBox.TabIndex = 0;
         this.sessionBrowser1pictureBox.TabStop = false;
         this.sessionBrowser1pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // panel2
         // 
         this.panel2.Location = new System.Drawing.Point(270, 625);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(200, 100);
         this.panel2.TabIndex = 4;
         // 
         // MainWnd
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(703, 407);
         this.Controls.Add(this.tableLayoutPanel1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainWnd";
         this.Text = "MainWnd";
         this.Load += new System.EventHandler(this.MainWnd_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.sessionsSplitContainer.Panel1.ResumeLayout(false);
         this.sessionsSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.sessionsSplitContainer)).EndInit();
         this.sessionsSplitContainer.ResumeLayout(false);
         this.urlRightClickContextMenuStrip.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.sessionBrowser2pictureBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sessionBrowser1pictureBox)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem refreshSessionListToolStripMenuItem;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label configLabel;
      private System.Windows.Forms.ComboBox configList;
      private System.Windows.Forms.SplitContainer sessionsSplitContainer;
      private SessionBrowser sessionBrowser1;
      private SessionBrowser sessionBrowser2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.PictureBox sessionBrowser2pictureBox;
      private System.Windows.Forms.PictureBox sessionBrowser1pictureBox;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.ContextMenuStrip urlRightClickContextMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem openUrlToolStripMenuItem;
   }
}