using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ZXing.Multi.QrCode;
using ZXing;
using ZXing.Common;

namespace clickerByQR
{
    public partial class mainForm : Form
    {
        QRCodeMultiReader qrCodesReader = new QRCodeMultiReader();
        IDictionary<DecodeHintType, object> qrCodeReaderParams;
        class interestedQRString
        {
            public string codeString;
            public int count;
        }
        List<interestedQRString> interestedQRStrings = new List<interestedQRString>();

        public mainForm()
        {
            InitializeComponent();
            qrCodeReaderParams = new Dictionary<DecodeHintType, object>();
            qrCodeReaderParams.Add(DecodeHintType.TRY_HARDER, true);
        }
        private List<Result> detectAndRecognieQRCode(Mat inputImage)
        {
            BinaryBitmap binaryBitmap = new BinaryBitmap(new HybridBinarizer(new BitmapLuminanceSource(inputImage.Bitmap)));

            Result[] tempResult = qrCodesReader.decodeMultiple(binaryBitmap, qrCodeReaderParams);
            if (tempResult != null)
                return tempResult.ToList<Result>();
            else
                return new List<Result>();
        }

        private void updateDisplayListView(ListView targetUpdateListView, List<Result> qrCodeRecognizeResults)
        {
            targetUpdateListView.Items.Clear();
            for (int interestedQRStringNo = 0; interestedQRStringNo < interestedQRStrings.Count; interestedQRStringNo++)
            {
                interestedQRStrings[interestedQRStringNo].count = qrCodeRecognizeResults.Count(elem => elem.Text == interestedQRStrings[interestedQRStringNo].codeString);
                string[] classCountItem = { interestedQRStrings[interestedQRStringNo].codeString, interestedQRStrings[interestedQRStringNo].count.ToString() };
                var listViewItem = new ListViewItem(classCountItem);
                targetUpdateListView.Items.Add(listViewItem);
            }
        }
        private void loadStillImage_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Mat inputImage = new Mat(openImageFileDialog.FileName);
                    CvInvoke.Resize(inputImage, inputImage, new Size(), 2, 2, Emgu.CV.CvEnum.Inter.Lanczos4);
                    updateDisplayListView(stillImageClassCountListView, detectAndRecognieQRCode(inputImage));
                    stillImagePictureBox.Image = inputImage.Bitmap;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
