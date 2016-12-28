namespace WebDiff.Forms
{
    partial class SessionForm
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
         this.urlTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.closeButton = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // urlTextBox
         // 
         this.urlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.urlTextBox.Location = new System.Drawing.Point(3, 28);
         this.urlTextBox.Multiline = true;
         this.urlTextBox.Name = "urlTextBox";
         this.urlTextBox.Size = new System.Drawing.Size(520, 581);
         this.urlTextBox.TabIndex = 1;
         this.urlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 5);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(58, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Found Urls";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // closeButton
         // 
         this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.closeButton.Enabled = false;
         this.closeButton.Location = new System.Drawing.Point(409, 7);
         this.closeButton.Name = "closeButton";
         this.closeButton.Size = new System.Drawing.Size(102, 23);
         this.closeButton.TabIndex = 4;
         this.closeButton.Text = "Close";
         this.closeButton.UseVisualStyleBackColor = true;
         this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.urlTextBox, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 657);
         this.tableLayoutPanel1.TabIndex = 5;
         this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.closeButton);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(3, 615);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(520, 39);
         this.panel1.TabIndex = 3;
         // 
         // SessionForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(526, 657);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "SessionForm";
         this.Text = "Crawling Progress";
         this.Load += new System.EventHandler(this.SessionFrm_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Panel panel1;
   }
}

