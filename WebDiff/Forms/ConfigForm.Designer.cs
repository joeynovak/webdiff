namespace WebDiff.Forms
{
   partial class ConfigForm
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
         this.titleTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.startUrlsTextBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.Compare = new System.Windows.Forms.TextBox();
         this.linkedPagesAllowedDomainsTextBox = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.allowedCrawlDomainsTextBox = new System.Windows.Forms.TextBox();
         this.saveButton = new System.Windows.Forms.Button();
         this.cancelButton = new System.Windows.Forms.Button();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.SuspendLayout();
         // 
         // titleTextBox
         // 
         this.titleTextBox.Location = new System.Drawing.Point(51, 12);
         this.titleTextBox.Name = "titleTextBox";
         this.titleTextBox.Size = new System.Drawing.Size(274, 20);
         this.titleTextBox.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(27, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Title";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // startUrlsTextBox
         // 
         this.startUrlsTextBox.AcceptsReturn = true;
         this.startUrlsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.startUrlsTextBox.Location = new System.Drawing.Point(6, 23);
         this.startUrlsTextBox.Multiline = true;
         this.startUrlsTextBox.Name = "startUrlsTextBox";
         this.startUrlsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.startUrlsTextBox.Size = new System.Drawing.Size(566, 110);
         this.startUrlsTextBox.TabIndex = 4;
         this.startUrlsTextBox.Text = "http://www.obdlink.com";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 7);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(50, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Start Urls";
         // 
         // Compare
         // 
         this.Compare.AcceptsReturn = true;
         this.Compare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.Compare.Location = new System.Drawing.Point(6, 26);
         this.Compare.Multiline = true;
         this.Compare.Name = "Compare";
         this.Compare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.Compare.Size = new System.Drawing.Size(566, 67);
         this.Compare.TabIndex = 7;
         this.Compare.Text = "http://www.obdlink.com";
         // 
         // linkedPagesAllowedDomainsTextBox
         // 
         this.linkedPagesAllowedDomainsTextBox.AutoSize = true;
         this.linkedPagesAllowedDomainsTextBox.Location = new System.Drawing.Point(3, 10);
         this.linkedPagesAllowedDomainsTextBox.Name = "linkedPagesAllowedDomainsTextBox";
         this.linkedPagesAllowedDomainsTextBox.Size = new System.Drawing.Size(230, 13);
         this.linkedPagesAllowedDomainsTextBox.TabIndex = 8;
         this.linkedPagesAllowedDomainsTextBox.Text = "Only Compare Linked Pages In These Domains";
         this.linkedPagesAllowedDomainsTextBox.Click += new System.EventHandler(this.label3_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(164, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "Allow Crawling of These Domains";
         this.label4.Click += new System.EventHandler(this.label4_Click);
         // 
         // allowedCrawlDomainsTextBox
         // 
         this.allowedCrawlDomainsTextBox.AcceptsReturn = true;
         this.allowedCrawlDomainsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.allowedCrawlDomainsTextBox.Location = new System.Drawing.Point(6, 25);
         this.allowedCrawlDomainsTextBox.Multiline = true;
         this.allowedCrawlDomainsTextBox.Name = "allowedCrawlDomainsTextBox";
         this.allowedCrawlDomainsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.allowedCrawlDomainsTextBox.Size = new System.Drawing.Size(566, 52);
         this.allowedCrawlDomainsTextBox.TabIndex = 9;
         this.allowedCrawlDomainsTextBox.Text = "http://www.obdlink.com";
         this.allowedCrawlDomainsTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
         // 
         // saveButton
         // 
         this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.saveButton.Location = new System.Drawing.Point(428, 373);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(75, 23);
         this.saveButton.TabIndex = 11;
         this.saveButton.Text = "Save";
         this.saveButton.UseVisualStyleBackColor = true;
         this.saveButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // cancelButton
         // 
         this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cancelButton.Location = new System.Drawing.Point(509, 373);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 12;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.splitContainer1.Location = new System.Drawing.Point(12, 38);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.label2);
         this.splitContainer1.Panel1.Controls.Add(this.startUrlsTextBox);
         this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
         this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.splitContainer1.Size = new System.Drawing.Size(579, 329);
         this.splitContainer1.SplitterDistance = 145;
         this.splitContainer1.TabIndex = 13;
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.linkedPagesAllowedDomainsTextBox);
         this.splitContainer2.Panel1.Controls.Add(this.Compare);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.label4);
         this.splitContainer2.Panel2.Controls.Add(this.allowedCrawlDomainsTextBox);
         this.splitContainer2.Size = new System.Drawing.Size(579, 180);
         this.splitContainer2.SplitterDistance = 96;
         this.splitContainer2.TabIndex = 0;
         // 
         // ConfigForm
         // 
         this.AcceptButton = this.saveButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cancelButton;
         this.ClientSize = new System.Drawing.Size(603, 403);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.saveButton);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.titleTextBox);
         this.Name = "ConfigForm";
         this.Text = "Edit Config";
         this.Load += new System.EventHandler(this.ConfigForm_Load);
         this.Shown += new System.EventHandler(this.ConfigForm_Shown);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel1.PerformLayout();
         this.splitContainer2.Panel2.ResumeLayout(false);
         this.splitContainer2.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox titleTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox startUrlsTextBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox Compare;
      private System.Windows.Forms.Label linkedPagesAllowedDomainsTextBox;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox allowedCrawlDomainsTextBox;
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.SplitContainer splitContainer2;
   }
}