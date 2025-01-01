using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        public Form1()
        {
            InitializeComponent();

            //initialize the comand box with the predefined filters
            List<FilterBase2D> filterList = new List<FilterBase2D>();

            filterList.Add(new NoFilter());
            filterList.Add(new SobelFilter());
            filterList.Add(new PrewittFilter());

            cmbEdgeDetMethod.DataSource = filterList;
            cmbEdgeDetMethod.DisplayMember = "FilterName";
            cmbEdgeDetMethod.SelectedIndex = 0;
        }

        private void btnOpenOrgImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                //fit the original image to the preview picture box 
                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;

                FilterBase2D filter = null;

                if (cmbEdgeDetMethod.SelectedItem is FilterBase2D)
                {
                    filter = (FilterBase2D)cmbEdgeDetMethod.SelectedItem;
                }

                ApplyFilter(true, filter);
            }
        }

        private void btnSaveResImage_Click(object sender, EventArgs e)
        {
            FilterBase2D filter = null;

            if (cmbEdgeDetMethod.SelectedItem is FilterBase2D)
            {
                filter = (FilterBase2D)cmbEdgeDetMethod.SelectedItem;
            }
            ApplyFilter(false, filter); //apply the filter on the original image(preview=false)

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        public void ApplyFilter(bool preview, FilterBase2D filter)
        {
            if (previewBitmap == null)
            {
                return;
            }

           if (filter.FilterName == "NoFilter")
            {
                picPreview.Image = previewBitmap;
                resultBitmap = originalBitmap;
                return;
            }

            if (preview == true)
            {
                picPreview.Image = previewBitmap.ConvolutionFilter(filter);
            }
            else
            {
                resultBitmap = originalBitmap.ConvolutionFilter(filter);
            }
        }

        private void SelectedFilterIndexChangedEventHandler(object sender, EventArgs e)
        {
            FilterBase2D filter = null;

            if (cmbEdgeDetMethod.SelectedItem is FilterBase2D)
            {
                filter = (FilterBase2D)cmbEdgeDetMethod.SelectedItem;
            }
            ApplyFilter(true, filter);
        }
    }
}
