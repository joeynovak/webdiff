namespace WebDiff.Forms
{
   partial class SelectConfigForm
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
         this.configsListBox = new System.Windows.Forms.ListBox();
         this.cancelButton = new System.Windows.Forms.Button();
         this.okButton = new System.Windows.Forms.Button();
         this.newButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.editButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // configsListBox
         // 
         this.configsListBox.FormattingEnabled = true;
         this.configsListBox.Location = new System.Drawing.Point(25, 30);
         this.configsListBox.Name = "configsListBox";
         this.configsListBox.Size = new System.Drawing.Size(333, 355);
         this.configsListBox.TabIndex = 0;
         this.configsListBox.SelectedIndexChanged += new System.EventHandler(this.configsListBox_SelectedIndexChanged);
         // 
         // cancelButton
         // 
         this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cancelButton.Location = new System.Drawing.Point(283, 415);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 1;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // okButton
         // 
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.okButton.Location = new System.Drawing.Point(202, 415);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 2;
         this.okButton.Text = "Ok";
         this.okButton.UseVisualStyleBackColor = true;
         this.okButton.Click += new System.EventHandler(this.okButton_Click);
         // 
         // newButton
         // 
         this.newButton.Location = new System.Drawing.Point(25, 415);
         this.newButton.Name = "newButton";
         this.newButton.Size = new System.Drawing.Size(75, 23);
         this.newButton.TabIndex = 3;
         this.newButton.Text = "New";
         this.newButton.UseVisualStyleBackColor = true;
         this.newButton.Click += new System.EventHandler(this.newButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 13);
         this.label1.TabIndex = 4;
         this.label1.Text = "Select a Config";
         // 
         // editButton
         // 
         this.editButton.Enabled = false;
         this.editButton.Location = new System.Drawing.Point(106, 415);
         this.editButton.Name = "editButton";
         this.editButton.Size = new System.Drawing.Size(75, 23);
         this.editButton.TabIndex = 5;
         this.editButton.Text = "Edit";
         this.editButton.UseVisualStyleBackColor = true;
         this.editButton.Click += new System.EventHandler(this.editButton_Click);
         // 
         // SelectConfigForm
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cancelButton;
         this.ClientSize = new System.Drawing.Size(386, 457);
         this.Controls.Add(this.editButton);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.newButton);
         this.Controls.Add(this.okButton);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.configsListBox);
         this.MaximumSize = new System.Drawing.Size(402, 496);
         this.Name = "SelectConfigForm";
         this.Text = "Select a Config";
         this.Load += new System.EventHandler(this.SelectConfigForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox configsListBox;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Button newButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button editButton;
   }
}