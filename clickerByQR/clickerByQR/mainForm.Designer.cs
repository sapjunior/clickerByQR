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
            this.mainTabControl.SuspendLayout();
            this.stillImageTabPage.SuspendLayout();
            this.mainStillImageTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stillImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.mainStillImageTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stillImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}

