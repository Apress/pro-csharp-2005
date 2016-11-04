namespace CarDataSetViewer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.carInventoryGridView = new System.Windows.Forms.DataGridView();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.txtRowToRemove = new System.Windows.Forms.TextBox();
            this.txtMakeToGet = new System.Windows.Forms.TextBox();
            this.btnGetMakes = new System.Windows.Forms.Button();
            this.btnChangeBeemersToColts = new System.Windows.Forms.Button();
            this.dataGridColtsView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColtsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Cars in DataTable";
            // 
            // carInventoryGridView
            // 
            this.carInventoryGridView.Location = new System.Drawing.Point(12, 93);
            this.carInventoryGridView.Name = "carInventoryGridView";
            this.carInventoryGridView.Size = new System.Drawing.Size(392, 150);
            this.carInventoryGridView.TabIndex = 1;
            this.carInventoryGridView.Text = "dataGridView1";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(12, 13);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveRow.TabIndex = 2;
            this.btnRemoveRow.Text = "Remove Row #";
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // txtRowToRemove
            // 
            this.txtRowToRemove.Location = new System.Drawing.Point(120, 15);
            this.txtRowToRemove.Name = "txtRowToRemove";
            this.txtRowToRemove.Size = new System.Drawing.Size(100, 20);
            this.txtRowToRemove.TabIndex = 3;
            // 
            // txtMakeToGet
            // 
            this.txtMakeToGet.Location = new System.Drawing.Point(120, 44);
            this.txtMakeToGet.Name = "txtMakeToGet";
            this.txtMakeToGet.Size = new System.Drawing.Size(100, 20);
            this.txtMakeToGet.TabIndex = 5;
            // 
            // btnGetMakes
            // 
            this.btnGetMakes.Location = new System.Drawing.Point(12, 42);
            this.btnGetMakes.Name = "btnGetMakes";
            this.btnGetMakes.Size = new System.Drawing.Size(101, 23);
            this.btnGetMakes.TabIndex = 4;
            this.btnGetMakes.Text = "Get These Makes";
            this.btnGetMakes.Click += new System.EventHandler(this.btnGetMakes_Click);
            // 
            // btnChangeBeemersToColts
            // 
            this.btnChangeBeemersToColts.Location = new System.Drawing.Point(245, 15);
            this.btnChangeBeemersToColts.Name = "btnChangeBeemersToColts";
            this.btnChangeBeemersToColts.Size = new System.Drawing.Size(159, 23);
            this.btnChangeBeemersToColts.TabIndex = 6;
            this.btnChangeBeemersToColts.Text = "Change BMW to Colts";
            this.btnChangeBeemersToColts.Click += new System.EventHandler(this.btnChangeBeemersToColts_Click);
            // 
            // dataGridColtsView
            // 
            this.dataGridColtsView.Location = new System.Drawing.Point(12, 266);
            this.dataGridColtsView.Name = "dataGridColtsView";
            this.dataGridColtsView.Size = new System.Drawing.Size(392, 150);
            this.dataGridColtsView.TabIndex = 8;
            this.dataGridColtsView.Text = "dataGridView1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Colts Only View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 433);
            this.Controls.Add(this.dataGridColtsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeBeemersToColts);
            this.Controls.Add(this.txtMakeToGet);
            this.Controls.Add(this.btnGetMakes);
            this.Controls.Add(this.txtRowToRemove);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.carInventoryGridView);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Car Data Table";
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColtsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView carInventoryGridView;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.TextBox txtRowToRemove;
        private System.Windows.Forms.TextBox txtMakeToGet;
        private System.Windows.Forms.Button btnGetMakes;
        private System.Windows.Forms.Button btnChangeBeemersToColts;
        private System.Windows.Forms.DataGridView dataGridColtsView;
        private System.Windows.Forms.Label label2;
    }
}

