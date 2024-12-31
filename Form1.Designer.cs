namespace ImageEdgeDetection
{
    partial class Form1
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOrgImage = new System.Windows.Forms.Button();
            this.btnSaveResImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOrgImage
            // 
            this.btnOpenOrgImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOrgImage.Location = new System.Drawing.Point(12, 618);
            this.btnOpenOrgImage.Name = "btnOpenOrgImage";
            this.btnOpenOrgImage.Size = new System.Drawing.Size(160, 46);
            this.btnOpenOrgImage.TabIndex = 15;
            this.btnOpenOrgImage.Text = "Load Image";
            this.btnOpenOrgImage.UseVisualStyleBackColor = true;
            this.btnOpenOrgImage.Click += new System.EventHandler(this.btnOpenOrgImage_Click);
            // 
            // btnSaveResImag
            // 
            this.btnSaveResImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResImage.Location = new System.Drawing.Point(452, 618);
            this.btnSaveResImage.Name = "btnSaveResImage";
            this.btnSaveResImage.Size = new System.Drawing.Size(160, 46);
            this.btnSaveResImage.TabIndex = 16;
            this.btnSaveResImage.Text = "Save Image";
            this.btnSaveResImage.UseVisualStyleBackColor = true;
            this.btnSaveResImage.Click += new System.EventHandler(this.btnSaveResImage_Click);
            // 
            // cmbEdgeDetMethod
            // 
            this.cmbEdgeDetMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetMethod.FormattingEnabled = true;
            this.cmbEdgeDetMethod.Location = new System.Drawing.Point(178, 627);
            this.cmbEdgeDetMethod.Name = "cmbEdgeDetMethod";
            this.cmbEdgeDetMethod.Size = new System.Drawing.Size(268, 32);
            this.cmbEdgeDetMethod.TabIndex = 17;
            this.cmbEdgeDetMethod.SelectedIndexChanged += new System.EventHandler(this.SelectedFilterIndexChangedEventHandler);
            // 
            // MainForm
            // 

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 672);
            this.Controls.Add(this.cmbEdgeDetMethod);
            this.Controls.Add(this.btnSaveResImage);
            this.Controls.Add(this.btnOpenOrgImage);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Edge detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOrgImage;
        private System.Windows.Forms.Button btnSaveResImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetMethod;
    }
}

