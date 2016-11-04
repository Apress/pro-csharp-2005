namespace ExoticControls
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageTrackBars = new System.Windows.Forms.TabPage();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.lblCurrColor = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.pagePanels = new System.Windows.Forms.TabPage();
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtUpperText = new System.Windows.Forms.TextBox();
            this.txtNormalText = new System.Windows.Forms.TextBox();
            this.btnHidePanel = new System.Windows.Forms.Button();
            this.btnShowPanel = new System.Windows.Forms.Button();
            this.pageUpDown = new System.Windows.Forms.TabPage();
            this.lblCurrSel = new System.Windows.Forms.Label();
            this.btnGetSelections = new System.Windows.Forms.Button();
            this.lblNumericUpDown = new System.Windows.Forms.Label();
            this.lblDomainUpDown = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.pageErrorProvider = new System.Windows.Forms.TabPage();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblErrorInstructions = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pageTreeView = new System.Windows.Forms.TabPage();
            this.lblNodeInfo = new System.Windows.Forms.Label();
            this.treeViewCars = new System.Windows.Forms.TreeView();
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.pageWebBrowser = new System.Windows.Forms.TabPage();
            this.btnGO = new System.Windows.Forms.Button();
            this.myWebBrowser = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.tooManyCharactersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.pageTrackBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.pagePanels.SuspendLayout();
            this.panelTextBoxes.SuspendLayout();
            this.pageUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.pageErrorProvider.SuspendLayout();
            this.pageTreeView.SuspendLayout();
            this.pageWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tooManyCharactersErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageTrackBars);
            this.tabControl1.Controls.Add(this.pagePanels);
            this.tabControl1.Controls.Add(this.pageUpDown);
            this.tabControl1.Controls.Add(this.pageErrorProvider);
            this.tabControl1.Controls.Add(this.pageTreeView);
            this.tabControl1.Controls.Add(this.pageWebBrowser);
            this.tabControl1.Location = new System.Drawing.Point(13, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // pageTrackBars
            // 
            this.pageTrackBars.Controls.Add(this.lblGreen);
            this.pageTrackBars.Controls.Add(this.lblRed);
            this.pageTrackBars.Controls.Add(this.blueTrackBar);
            this.pageTrackBars.Controls.Add(this.lblBlue);
            this.pageTrackBars.Controls.Add(this.greenTrackBar);
            this.pageTrackBars.Controls.Add(this.redTrackBar);
            this.pageTrackBars.Controls.Add(this.lblCurrColor);
            this.pageTrackBars.Controls.Add(this.colorBox);
            this.pageTrackBars.Location = new System.Drawing.Point(4, 22);
            this.pageTrackBars.Name = "pageTrackBars";
            this.pageTrackBars.Padding = new System.Windows.Forms.Padding(3);
            this.pageTrackBars.Size = new System.Drawing.Size(636, 341);
            this.pageTrackBars.TabIndex = 0;
            this.pageTrackBars.Text = "Track Bars";
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Arial", 15F);
            this.lblGreen.Location = new System.Drawing.Point(17, 111);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(72, 32);
            this.lblGreen.TabIndex = 25;
            this.lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Arial", 15F);
            this.lblRed.Location = new System.Drawing.Point(17, 66);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(72, 32);
            this.lblRed.TabIndex = 24;
            this.lblRed.Text = "Red:";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(95, 151);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(310, 45);
            this.blueTrackBar.TabIndex = 18;
            this.blueTrackBar.TickFrequency = 5;
            this.blueTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Arial", 15F);
            this.lblBlue.Location = new System.Drawing.Point(17, 151);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(72, 32);
            this.lblBlue.TabIndex = 23;
            this.lblBlue.Text = "Blue:";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(95, 111);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(310, 45);
            this.greenTrackBar.TabIndex = 20;
            this.greenTrackBar.TickFrequency = 5;
            this.greenTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(95, 71);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(310, 45);
            this.redTrackBar.TabIndex = 19;
            this.redTrackBar.TickFrequency = 5;
            this.redTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // lblCurrColor
            // 
            this.lblCurrColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCurrColor.Location = new System.Drawing.Point(21, 209);
            this.lblCurrColor.Name = "lblCurrColor";
            this.lblCurrColor.Size = new System.Drawing.Size(392, 40);
            this.lblCurrColor.TabIndex = 17;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Blue;
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorBox.Location = new System.Drawing.Point(21, 7);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(384, 56);
            this.colorBox.TabIndex = 16;
            this.colorBox.TabStop = false;
            // 
            // pagePanels
            // 
            this.pagePanels.Controls.Add(this.panelTextBoxes);
            this.pagePanels.Controls.Add(this.btnHidePanel);
            this.pagePanels.Controls.Add(this.btnShowPanel);
            this.pagePanels.Location = new System.Drawing.Point(4, 22);
            this.pagePanels.Name = "pagePanels";
            this.pagePanels.Padding = new System.Windows.Forms.Padding(3);
            this.pagePanels.Size = new System.Drawing.Size(488, 341);
            this.pagePanels.TabIndex = 1;
            this.pagePanels.Text = "Panels";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Controls.Add(this.lblInstructions);
            this.panelTextBoxes.Controls.Add(this.txtUpperText);
            this.panelTextBoxes.Controls.Add(this.txtNormalText);
            this.panelTextBoxes.Location = new System.Drawing.Point(111, 7);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(294, 187);
            this.panelTextBoxes.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(4, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(122, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter Some Text below...";
            // 
            // txtUpperText
            // 
            this.txtUpperText.Location = new System.Drawing.Point(4, 59);
            this.txtUpperText.Name = "txtUpperText";
            this.txtUpperText.Size = new System.Drawing.Size(100, 20);
            this.txtUpperText.TabIndex = 1;
            // 
            // txtNormalText
            // 
            this.txtNormalText.Location = new System.Drawing.Point(3, 33);
            this.txtNormalText.Name = "txtNormalText";
            this.txtNormalText.Size = new System.Drawing.Size(101, 20);
            this.txtNormalText.TabIndex = 0;
            this.txtNormalText.TextChanged += new System.EventHandler(this.txtNormalText_TextChanged);
            // 
            // btnHidePanel
            // 
            this.btnHidePanel.Location = new System.Drawing.Point(7, 37);
            this.btnHidePanel.Name = "btnHidePanel";
            this.btnHidePanel.Size = new System.Drawing.Size(75, 23);
            this.btnHidePanel.TabIndex = 1;
            this.btnHidePanel.Text = "Hide Panel";
            this.btnHidePanel.Click += new System.EventHandler(this.btnHidePanel_Click);
            // 
            // btnShowPanel
            // 
            this.btnShowPanel.Location = new System.Drawing.Point(7, 7);
            this.btnShowPanel.Name = "btnShowPanel";
            this.btnShowPanel.Size = new System.Drawing.Size(75, 23);
            this.btnShowPanel.TabIndex = 0;
            this.btnShowPanel.Text = "Show Panel";
            this.btnShowPanel.Click += new System.EventHandler(this.btnShowPanel_Click);
            // 
            // pageUpDown
            // 
            this.pageUpDown.Controls.Add(this.lblCurrSel);
            this.pageUpDown.Controls.Add(this.btnGetSelections);
            this.pageUpDown.Controls.Add(this.lblNumericUpDown);
            this.pageUpDown.Controls.Add(this.lblDomainUpDown);
            this.pageUpDown.Controls.Add(this.numericUpDown);
            this.pageUpDown.Controls.Add(this.domainUpDown);
            this.pageUpDown.Location = new System.Drawing.Point(4, 22);
            this.pageUpDown.Name = "pageUpDown";
            this.pageUpDown.Padding = new System.Windows.Forms.Padding(3);
            this.pageUpDown.Size = new System.Drawing.Size(488, 341);
            this.pageUpDown.TabIndex = 2;
            this.pageUpDown.Text = "Up Down Controls";
            // 
            // lblCurrSel
            // 
            this.lblCurrSel.BackColor = System.Drawing.Color.Linen;
            this.lblCurrSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrSel.Location = new System.Drawing.Point(16, 180);
            this.lblCurrSel.Name = "lblCurrSel";
            this.lblCurrSel.Size = new System.Drawing.Size(256, 48);
            this.lblCurrSel.TabIndex = 5;
            // 
            // btnGetSelections
            // 
            this.btnGetSelections.Location = new System.Drawing.Point(16, 136);
            this.btnGetSelections.Name = "btnGetSelections";
            this.btnGetSelections.Size = new System.Drawing.Size(136, 24);
            this.btnGetSelections.TabIndex = 4;
            this.btnGetSelections.Text = "Get Current Selections";
            this.btnGetSelections.Click += new System.EventHandler(this.btnGetSelections_Click);
            // 
            // lblNumericUpDown
            // 
            this.lblNumericUpDown.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNumericUpDown.Location = new System.Drawing.Point(8, 80);
            this.lblNumericUpDown.Name = "lblNumericUpDown";
            this.lblNumericUpDown.Size = new System.Drawing.Size(221, 32);
            this.lblNumericUpDown.TabIndex = 3;
            this.lblNumericUpDown.Text = "Numeric UpDown Control";
            // 
            // lblDomainUpDown
            // 
            this.lblDomainUpDown.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblDomainUpDown.Location = new System.Drawing.Point(8, 24);
            this.lblDomainUpDown.Name = "lblDomainUpDown";
            this.lblDomainUpDown.Size = new System.Drawing.Size(221, 32);
            this.lblDomainUpDown.TabIndex = 2;
            this.lblDomainUpDown.Text = "Domain UpDown Control";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(235, 80);
            this.numericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ThousandsSeparator = true;
            this.numericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // domainUpDown
            // 
            this.domainUpDown.Items.Add("Another Selection");
            this.domainUpDown.Items.Add("Final Selection");
            this.domainUpDown.Items.Add("Selection One");
            this.domainUpDown.Items.Add("Third Selection");
            this.domainUpDown.Location = new System.Drawing.Point(235, 24);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.Size = new System.Drawing.Size(168, 20);
            this.domainUpDown.Sorted = true;
            this.domainUpDown.TabIndex = 0;
            this.domainUpDown.Text = "Some Item";
            this.domainUpDown.Wrap = true;
            // 
            // pageErrorProvider
            // 
            this.pageErrorProvider.Controls.Add(this.txtInput);
            this.pageErrorProvider.Controls.Add(this.lblErrorInstructions);
            this.pageErrorProvider.Controls.Add(this.btnValidate);
            this.pageErrorProvider.Location = new System.Drawing.Point(4, 22);
            this.pageErrorProvider.Name = "pageErrorProvider";
            this.pageErrorProvider.Padding = new System.Windows.Forms.Padding(3);
            this.pageErrorProvider.Size = new System.Drawing.Size(488, 341);
            this.pageErrorProvider.TabIndex = 3;
            this.pageErrorProvider.Text = "Error Provider";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(159, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(181, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // lblErrorInstructions
            // 
            this.lblErrorInstructions.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblErrorInstructions.Location = new System.Drawing.Point(8, 8);
            this.lblErrorInstructions.Name = "lblErrorInstructions";
            this.lblErrorInstructions.Size = new System.Drawing.Size(376, 56);
            this.lblErrorInstructions.TabIndex = 2;
            this.lblErrorInstructions.Text = "The following text box only allows 5 characters.  Try to enter more...";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(16, 72);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(112, 32);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "OK";
            // 
            // pageTreeView
            // 
            this.pageTreeView.Controls.Add(this.lblNodeInfo);
            this.pageTreeView.Controls.Add(this.treeViewCars);
            this.pageTreeView.Location = new System.Drawing.Point(4, 22);
            this.pageTreeView.Name = "pageTreeView";
            this.pageTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.pageTreeView.Size = new System.Drawing.Size(488, 341);
            this.pageTreeView.TabIndex = 4;
            this.pageTreeView.Text = "Tree View";
            // 
            // lblNodeInfo
            // 
            this.lblNodeInfo.AutoSize = true;
            this.lblNodeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNodeInfo.Location = new System.Drawing.Point(230, 6);
            this.lblNodeInfo.Name = "lblNodeInfo";
            this.lblNodeInfo.Size = new System.Drawing.Size(74, 15);
            this.lblNodeInfo.TabIndex = 1;
            this.lblNodeInfo.Text = "Tree View Info";
            // 
            // treeViewCars
            // 
            this.treeViewCars.ImageIndex = 0;
            this.treeViewCars.ImageList = this.imageListTreeView;
            this.treeViewCars.Location = new System.Drawing.Point(6, 6);
            this.treeViewCars.Name = "treeViewCars";
            this.treeViewCars.SelectedImageIndex = 0;
            this.treeViewCars.Size = new System.Drawing.Size(206, 251);
            this.treeViewCars.TabIndex = 0;
            this.treeViewCars.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCars_AfterSelect);
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.Images.SetKeyName(0, "CarNode.bmp");
            this.imageListTreeView.Images.SetKeyName(1, "SpeedNode.bmp");
            this.imageListTreeView.Images.SetKeyName(2, "RadioNode.bmp");
            // 
            // pageWebBrowser
            // 
            this.pageWebBrowser.Controls.Add(this.btnGO);
            this.pageWebBrowser.Controls.Add(this.myWebBrowser);
            this.pageWebBrowser.Controls.Add(this.txtUrl);
            this.pageWebBrowser.Controls.Add(this.lblURL);
            this.pageWebBrowser.Location = new System.Drawing.Point(4, 22);
            this.pageWebBrowser.Name = "pageWebBrowser";
            this.pageWebBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.pageWebBrowser.Size = new System.Drawing.Size(488, 341);
            this.pageWebBrowser.TabIndex = 5;
            this.pageWebBrowser.Text = "Web Browser";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(366, 7);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(46, 23);
            this.btnGO.TabIndex = 3;
            this.btnGO.Text = "Go!";
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // myWebBrowser
            // 
            this.myWebBrowser.Location = new System.Drawing.Point(8, 37);
            this.myWebBrowser.Name = "myWebBrowser";
            this.myWebBrowser.Size = new System.Drawing.Size(622, 298);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(111, 7);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(248, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://www.intertechtraining.com";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(7, 7);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(97, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "Please Enter a URL";
            // 
            // tooManyCharactersErrorProvider
            // 
            this.tooManyCharactersErrorProvider.BlinkRate = 500;
            this.tooManyCharactersErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.tooManyCharactersErrorProvider.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Exotic Controls";
            this.tabControl1.ResumeLayout(false);
            this.pageTrackBars.ResumeLayout(false);
            this.pageTrackBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.pagePanels.ResumeLayout(false);
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            this.pageUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.pageErrorProvider.ResumeLayout(false);
            this.pageErrorProvider.PerformLayout();
            this.pageTreeView.ResumeLayout(false);
            this.pageTreeView.PerformLayout();
            this.pageWebBrowser.ResumeLayout(false);
            this.pageWebBrowser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tooManyCharactersErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageTrackBars;
        private System.Windows.Forms.TabPage pagePanels;
        private System.Windows.Forms.TabPage pageUpDown;
        private System.Windows.Forms.TabPage pageErrorProvider;
        private System.Windows.Forms.TabPage pageTreeView;
        private System.Windows.Forms.TabPage pageWebBrowser;
        private System.Windows.Forms.Label lblNumericUpDown;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label lblDomainUpDown;
        private System.Windows.Forms.Label lblCurrColor;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Button btnShowPanel;
        private System.Windows.Forms.Button btnHidePanel;
        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtUpperText;
        private System.Windows.Forms.TextBox txtNormalText;
        private System.Windows.Forms.Label lblCurrSel;
        private System.Windows.Forms.Button btnGetSelections;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.DomainUpDown domainUpDown;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblErrorInstructions;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TreeView treeViewCars;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.WebBrowser myWebBrowser;
        private System.Windows.Forms.Label lblNodeInfo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ErrorProvider tooManyCharactersErrorProvider;
        private System.Windows.Forms.ImageList imageListTreeView;
    }
}

