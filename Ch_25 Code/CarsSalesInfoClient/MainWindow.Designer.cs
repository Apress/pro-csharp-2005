namespace CarsSalesInfoClient
{
    partial class MainWindow
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
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetTagLines = new System.Windows.Forms.Button();
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.btnGetAllDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.Location = new System.Drawing.Point(13, 38);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(461, 106);
            this.inventoryDataGridView.TabIndex = 0;
            this.inventoryDataGridView.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // btnGetTagLines
            // 
            this.btnGetTagLines.Location = new System.Drawing.Point(14, 165);
            this.btnGetTagLines.Name = "btnGetTagLines";
            this.btnGetTagLines.Size = new System.Drawing.Size(120, 23);
            this.btnGetTagLines.TabIndex = 2;
            this.btnGetTagLines.Text = "Get Tag Lines";
            this.btnGetTagLines.Click += new System.EventHandler(this.btnGetTagLines_Click);
            // 
            // listBoxTags
            // 
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.Location = new System.Drawing.Point(157, 165);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(317, 56);
            this.listBoxTags.TabIndex = 3;
            // 
            // btnGetAllDetails
            // 
            this.btnGetAllDetails.Location = new System.Drawing.Point(13, 197);
            this.btnGetAllDetails.Name = "btnGetAllDetails";
            this.btnGetAllDetails.Size = new System.Drawing.Size(121, 23);
            this.btnGetAllDetails.TabIndex = 4;
            this.btnGetAllDetails.Text = "Get Details";
            this.btnGetAllDetails.Click += new System.EventHandler(this.btnGetAllDetails_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 243);
            this.Controls.Add(this.btnGetAllDetails);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.btnGetTagLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventoryDataGridView);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Info Client";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetTagLines;
        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.Button btnGetAllDetails;
    }
}

