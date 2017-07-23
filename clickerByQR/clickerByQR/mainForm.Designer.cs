namespace clickerByQR
{
    partial class mainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.stillImageTabPage = new System.Windows.Forms.TabPage();
            this.liveCameraTabPage = new System.Windows.Forms.TabPage();
            this.generatorAndSettingTabPage = new System.Windows.Forms.TabPage();
            this.mainStillImageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stillImagePictureBox = new System.Windows.Forms.PictureBox();
            this.loadStillImageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stillImageClassCountListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainGeneratorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.qrCodeGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.qrCodePictureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.qrCodePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.qrCodeEmbedText = new System.Windows.Forms.TextBox();
            this.generateQRCodeBtn = new System.Windows.Forms.Button();
            this.saveQRCode = new System.Windows.Forms.Button();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTabControl.SuspendLayout();
            this.stillImageTabPage.SuspendLayout();
            this.generatorAndSettingTabPage.SuspendLayout();
            this.mainStillImageTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stillImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mainGeneratorTableLayoutPanel.SuspendLayout();
            this.qrCodeGeneratorGroupBox.SuspendLayout();
            this.qrCodePictureTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.stillImageTabPage);
            this.mainTabControl.Controls.Add(this.liveCameraTabPage);
            this.mainTabControl.Controls.Add(this.generatorAndSettingTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(887, 536);
            this.mainTabControl.TabIndex = 0;
            // 
            // stillImageTabPage
            // 
            this.stillImageTabPage.Controls.Add(this.mainStillImageTableLayoutPanel);
            this.stillImageTabPage.Location = new System.Drawing.Point(4, 22);
            this.stillImageTabPage.Name = "stillImageTabPage";
            this.stillImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stillImageTabPage.Size = new System.Drawing.Size(879, 510);
            this.stillImageTabPage.TabIndex = 0;
            this.stillImageTabPage.Text = "Still Image";
            this.stillImageTabPage.UseVisualStyleBackColor = true;
            // 
            // liveCameraTabPage
            // 
            this.liveCameraTabPage.Location = new System.Drawing.Point(4, 22);
            this.liveCameraTabPage.Name = "liveCameraTabPage";
            this.liveCameraTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.liveCameraTabPage.Size = new System.Drawing.Size(879, 510);
            this.liveCameraTabPage.TabIndex = 1;
            this.liveCameraTabPage.Text = "Live Camera";
            this.liveCameraTabPage.UseVisualStyleBackColor = true;
            // 
            // generatorAndSettingTabPage
            // 
            this.generatorAndSettingTabPage.Controls.Add(this.mainGeneratorTableLayoutPanel);
            this.generatorAndSettingTabPage.Location = new System.Drawing.Point(4, 22);
            this.generatorAndSettingTabPage.Name = "generatorAndSettingTabPage";
            this.generatorAndSettingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generatorAndSettingTabPage.Size = new System.Drawing.Size(879, 510);
            this.generatorAndSettingTabPage.TabIndex = 2;
            this.generatorAndSettingTabPage.Text = "QR Code Generator";
            this.generatorAndSettingTabPage.UseVisualStyleBackColor = true;
            // 
            // mainStillImageTableLayoutPanel
            // 
            this.mainStillImageTableLayoutPanel.ColumnCount = 2;
            this.mainStillImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainStillImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainStillImageTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.mainStillImageTableLayoutPanel.Controls.Add(this.stillImagePictureBox, 0, 0);
            this.mainStillImageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainStillImageTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainStillImageTableLayoutPanel.Name = "mainStillImageTableLayoutPanel";
            this.mainStillImageTableLayoutPanel.RowCount = 1;
            this.mainStillImageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainStillImageTableLayoutPanel.Size = new System.Drawing.Size(873, 504);
            this.mainStillImageTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.loadStillImageBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(676, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 498);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // stillImagePictureBox
            // 
            this.stillImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stillImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.stillImagePictureBox.Name = "stillImagePictureBox";
            this.stillImagePictureBox.Size = new System.Drawing.Size(667, 498);
            this.stillImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stillImagePictureBox.TabIndex = 1;
            this.stillImagePictureBox.TabStop = false;
            // 
            // loadStillImageBtn
            // 
            this.loadStillImageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadStillImageBtn.Location = new System.Drawing.Point(3, 471);
            this.loadStillImageBtn.Name = "loadStillImageBtn";
            this.loadStillImageBtn.Size = new System.Drawing.Size(188, 24);
            this.loadStillImageBtn.TabIndex = 0;
            this.loadStillImageBtn.Text = "Load Image && Process";
            this.loadStillImageBtn.UseVisualStyleBackColor = true;
            this.loadStillImageBtn.Click += new System.EventHandler(this.loadStillImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stillImageClassCountListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Count Result";
            // 
            // stillImageClassCountListView
            // 
            this.stillImageClassCountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.stillImageClassCountListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stillImageClassCountListView.Location = new System.Drawing.Point(3, 16);
            this.stillImageClassCountListView.Name = "stillImageClassCountListView";
            this.stillImageClassCountListView.Size = new System.Drawing.Size(182, 443);
            this.stillImageClassCountListView.TabIndex = 0;
            this.stillImageClassCountListView.UseCompatibleStateImageBehavior = false;
            this.stillImageClassCountListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Class";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 70;
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif" +
    "; *.png\"";
            this.openImageFileDialog.Title = "Select Image File";
            // 
            // mainGeneratorTableLayoutPanel
            // 
            this.mainGeneratorTableLayoutPanel.ColumnCount = 2;
            this.mainGeneratorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGeneratorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGeneratorTableLayoutPanel.Controls.Add(this.settingGroupBox, 0, 0);
            this.mainGeneratorTableLayoutPanel.Controls.Add(this.qrCodeGeneratorGroupBox, 1, 0);
            this.mainGeneratorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGeneratorTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainGeneratorTableLayoutPanel.Name = "mainGeneratorTableLayoutPanel";
            this.mainGeneratorTableLayoutPanel.RowCount = 1;
            this.mainGeneratorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainGeneratorTableLayoutPanel.Size = new System.Drawing.Size(873, 504);
            this.mainGeneratorTableLayoutPanel.TabIndex = 0;
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(430, 498);
            this.settingGroupBox.TabIndex = 0;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Settings";
            // 
            // qrCodeGeneratorGroupBox
            // 
            this.qrCodeGeneratorGroupBox.Controls.Add(this.qrCodePictureTableLayoutPanel);
            this.qrCodeGeneratorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCodeGeneratorGroupBox.Location = new System.Drawing.Point(439, 3);
            this.qrCodeGeneratorGroupBox.Name = "qrCodeGeneratorGroupBox";
            this.qrCodeGeneratorGroupBox.Size = new System.Drawing.Size(431, 498);
            this.qrCodeGeneratorGroupBox.TabIndex = 1;
            this.qrCodeGeneratorGroupBox.TabStop = false;
            this.qrCodeGeneratorGroupBox.Text = "QR Code Generator";
            // 
            // qrCodePictureTableLayoutPanel
            // 
            this.qrCodePictureTableLayoutPanel.ColumnCount = 1;
            this.qrCodePictureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.qrCodePictureTableLayoutPanel.Controls.Add(this.qrCodePictureBox, 0, 0);
            this.qrCodePictureTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.qrCodePictureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCodePictureTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.qrCodePictureTableLayoutPanel.Name = "qrCodePictureTableLayoutPanel";
            this.qrCodePictureTableLayoutPanel.RowCount = 2;
            this.qrCodePictureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.qrCodePictureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.qrCodePictureTableLayoutPanel.Size = new System.Drawing.Size(425, 479);
            this.qrCodePictureTableLayoutPanel.TabIndex = 0;
            // 
            // qrCodePictureBox
            // 
            this.qrCodePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCodePictureBox.Location = new System.Drawing.Point(3, 3);
            this.qrCodePictureBox.Name = "qrCodePictureBox";
            this.qrCodePictureBox.Size = new System.Drawing.Size(419, 377);
            this.qrCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodePictureBox.TabIndex = 0;
            this.qrCodePictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.qrCodeEmbedText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateQRCodeBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveQRCode, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 386);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 90);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Embed Text :";
            // 
            // qrCodeEmbedText
            // 
            this.qrCodeEmbedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qrCodeEmbedText.Location = new System.Drawing.Point(212, 12);
            this.qrCodeEmbedText.Name = "qrCodeEmbedText";
            this.qrCodeEmbedText.Size = new System.Drawing.Size(204, 20);
            this.qrCodeEmbedText.TabIndex = 1;
            this.qrCodeEmbedText.Text = "y";
            // 
            // generateQRCodeBtn
            // 
            this.generateQRCodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generateQRCodeBtn.Location = new System.Drawing.Point(3, 56);
            this.generateQRCodeBtn.Name = "generateQRCodeBtn";
            this.generateQRCodeBtn.Size = new System.Drawing.Size(203, 23);
            this.generateQRCodeBtn.TabIndex = 2;
            this.generateQRCodeBtn.Text = "Generate QRCode";
            this.generateQRCodeBtn.UseVisualStyleBackColor = true;
            this.generateQRCodeBtn.Click += new System.EventHandler(this.generateQRCodeBtn_Click);
            // 
            // saveQRCode
            // 
            this.saveQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveQRCode.Location = new System.Drawing.Point(212, 56);
            this.saveQRCode.Name = "saveQRCode";
            this.saveQRCode.Size = new System.Drawing.Size(204, 23);
            this.saveQRCode.TabIndex = 3;
            this.saveQRCode.Text = "Save To File (.jpg)";
            this.saveQRCode.UseVisualStyleBackColor = true;
            this.saveQRCode.Click += new System.EventHandler(this.saveQRCode_Click);
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.Filter = "Jpg Image|*.jpg";
            this.saveImageFileDialog.Title = "Save QRCode Image";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 536);
            this.Controls.Add(this.mainTabControl);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.stillImageTabPage.ResumeLayout(false);
            this.generatorAndSettingTabPage.ResumeLayout(false);
            this.mainStillImageTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stillImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.mainGeneratorTableLayoutPanel.ResumeLayout(false);
            this.qrCodeGeneratorGroupBox.ResumeLayout(false);
            this.qrCodePictureTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage stillImageTabPage;
        private System.Windows.Forms.TableLayoutPanel mainStillImageTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button loadStillImageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView stillImageClassCountListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox stillImagePictureBox;
        private System.Windows.Forms.TabPage liveCameraTabPage;
        private System.Windows.Forms.TabPage generatorAndSettingTabPage;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.TableLayoutPanel mainGeneratorTableLayoutPanel;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.GroupBox qrCodeGeneratorGroupBox;
        private System.Windows.Forms.TableLayoutPanel qrCodePictureTableLayoutPanel;
        private System.Windows.Forms.PictureBox qrCodePictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qrCodeEmbedText;
        private System.Windows.Forms.Button generateQRCodeBtn;
        private System.Windows.Forms.Button saveQRCode;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
    }
}

