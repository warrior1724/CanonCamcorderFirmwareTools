﻿namespace HF10_Bitmap_Viewer {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.nudPos = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDecimalValues = new System.Windows.Forms.Label();
            this.lblBitmapHeader = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.flpBitmaps = new System.Windows.Forms.FlowLayoutPanel();
            this.cbFixedWidth = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOneByte = new System.Windows.Forms.RadioButton();
            this.rbFourByte = new System.Windows.Forms.RadioButton();
            this.rbTwoByte = new System.Windows.Forms.RadioButton();
            this.btnNext20 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbSymbolsImages = new System.Windows.Forms.CheckBox();
            this.pbMediumZoom = new HF10_Bitmap_Viewer.PictureBoxEx();
            this.pbZoomed = new HF10_Bitmap_Viewer.PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 9);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(95, 14);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 13);
            this.lblFilename.TabIndex = 1;
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.Color.Magenta;
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOriginal.Location = new System.Drawing.Point(12, 39);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(100, 96);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOriginal.TabIndex = 2;
            this.pbOriginal.TabStop = false;
            // 
            // nudPos
            // 
            this.nudPos.Hexadecimal = true;
            this.nudPos.Location = new System.Drawing.Point(98, 339);
            this.nudPos.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPos.Name = "nudPos";
            this.nudPos.Size = new System.Drawing.Size(120, 20);
            this.nudPos.TabIndex = 4;
            // 
            // nudWidth
            // 
            this.nudWidth.Enabled = false;
            this.nudWidth.Hexadecimal = true;
            this.nudWidth.Location = new System.Drawing.Point(98, 365);
            this.nudWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(54, 20);
            this.nudWidth.TabIndex = 5;
            // 
            // nudHeight
            // 
            this.nudHeight.Enabled = false;
            this.nudHeight.Hexadecimal = true;
            this.nudHeight.Location = new System.Drawing.Point(98, 391);
            this.nudHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(54, 20);
            this.nudHeight.TabIndex = 6;
            this.nudHeight.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // lblDecimalValues
            // 
            this.lblDecimalValues.AutoSize = true;
            this.lblDecimalValues.Location = new System.Drawing.Point(13, 422);
            this.lblDecimalValues.Name = "lblDecimalValues";
            this.lblDecimalValues.Size = new System.Drawing.Size(77, 13);
            this.lblDecimalValues.TabIndex = 10;
            this.lblDecimalValues.Text = "decimal values";
            this.lblDecimalValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBitmapHeader
            // 
            this.lblBitmapHeader.AutoSize = true;
            this.lblBitmapHeader.Location = new System.Drawing.Point(13, 443);
            this.lblBitmapHeader.Name = "lblBitmapHeader";
            this.lblBitmapHeader.Size = new System.Drawing.Size(63, 13);
            this.lblBitmapHeader.TabIndex = 12;
            this.lblBitmapHeader.Text = "bmp header";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(109, 502);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "find next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(12, 502);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(91, 23);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "<- history back";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(12, 531);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(91, 23);
            this.btnClearHistory.TabIndex = 15;
            this.btnClearHistory.Text = "clear history";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // flpBitmaps
            // 
            this.flpBitmaps.AutoScroll = true;
            this.flpBitmaps.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.flpBitmaps.BackColor = System.Drawing.Color.Black;
            this.flpBitmaps.Location = new System.Drawing.Point(228, 39);
            this.flpBitmaps.Name = "flpBitmaps";
            this.flpBitmaps.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flpBitmaps.Size = new System.Drawing.Size(614, 549);
            this.flpBitmaps.TabIndex = 16;
            // 
            // cbFixedWidth
            // 
            this.cbFixedWidth.AutoSize = true;
            this.cbFixedWidth.Location = new System.Drawing.Point(162, 367);
            this.cbFixedWidth.Name = "cbFixedWidth";
            this.cbFixedWidth.Size = new System.Drawing.Size(60, 17);
            this.cbFixedWidth.TabIndex = 17;
            this.cbFixedWidth.Text = "manual";
            this.cbFixedWidth.UseVisualStyleBackColor = true;
            this.cbFixedWidth.CheckedChanged += new System.EventHandler(this.cbFixedWidth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOneByte);
            this.groupBox1.Controls.Add(this.rbFourByte);
            this.groupBox1.Controls.Add(this.rbTwoByte);
            this.groupBox1.Location = new System.Drawing.Point(16, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alignment";
            // 
            // rbOneByte
            // 
            this.rbOneByte.AutoSize = true;
            this.rbOneByte.Location = new System.Drawing.Point(6, 15);
            this.rbOneByte.Name = "rbOneByte";
            this.rbOneByte.Size = new System.Drawing.Size(54, 17);
            this.rbOneByte.TabIndex = 2;
            this.rbOneByte.TabStop = true;
            this.rbOneByte.Text = "1 byte";
            this.rbOneByte.UseVisualStyleBackColor = true;
            this.rbOneByte.CheckedChanged += new System.EventHandler(this.ByteAlign_CheckedChanged);
            // 
            // rbFourByte
            // 
            this.rbFourByte.AutoSize = true;
            this.rbFourByte.Checked = true;
            this.rbFourByte.Location = new System.Drawing.Point(126, 15);
            this.rbFourByte.Name = "rbFourByte";
            this.rbFourByte.Size = new System.Drawing.Size(54, 17);
            this.rbFourByte.TabIndex = 1;
            this.rbFourByte.TabStop = true;
            this.rbFourByte.Text = "4 byte";
            this.rbFourByte.UseVisualStyleBackColor = true;
            this.rbFourByte.CheckedChanged += new System.EventHandler(this.ByteAlign_CheckedChanged);
            // 
            // rbTwoByte
            // 
            this.rbTwoByte.AutoSize = true;
            this.rbTwoByte.Location = new System.Drawing.Point(66, 15);
            this.rbTwoByte.Name = "rbTwoByte";
            this.rbTwoByte.Size = new System.Drawing.Size(54, 17);
            this.rbTwoByte.TabIndex = 0;
            this.rbTwoByte.Text = "2 byte";
            this.rbTwoByte.UseVisualStyleBackColor = true;
            this.rbTwoByte.CheckedChanged += new System.EventHandler(this.ByteAlign_CheckedChanged);
            // 
            // btnNext20
            // 
            this.btnNext20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext20.Location = new System.Drawing.Point(109, 531);
            this.btnNext20.Name = "btnNext20";
            this.btnNext20.Size = new System.Drawing.Size(109, 23);
            this.btnNext20.TabIndex = 19;
            this.btnNext20.Text = "find next 50 ->";
            this.btnNext20.UseVisualStyleBackColor = true;
            this.btnNext20.Click += new System.EventHandler(this.btnNext20_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(595, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "by Mario Guggenberger <mg@protyposis.net>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "color palette browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSymbolsImages
            // 
            this.cbSymbolsImages.AutoSize = true;
            this.cbSymbolsImages.Checked = true;
            this.cbSymbolsImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbolsImages.Location = new System.Drawing.Point(162, 392);
            this.cbSymbolsImages.Name = "cbSymbolsImages";
            this.cbSymbolsImages.Size = new System.Drawing.Size(63, 17);
            this.cbSymbolsImages.TabIndex = 23;
            this.cbSymbolsImages.Text = "symbols";
            this.cbSymbolsImages.UseVisualStyleBackColor = true;
            // 
            // pbMediumZoom
            // 
            this.pbMediumZoom.BackColor = System.Drawing.Color.Magenta;
            this.pbMediumZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMediumZoom.Location = new System.Drawing.Point(118, 39);
            this.pbMediumZoom.Name = "pbMediumZoom";
            this.pbMediumZoom.Size = new System.Drawing.Size(100, 96);
            this.pbMediumZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMediumZoom.TabIndex = 11;
            this.pbMediumZoom.TabStop = false;
            // 
            // pbZoomed
            // 
            this.pbZoomed.BackColor = System.Drawing.Color.Magenta;
            this.pbZoomed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbZoomed.Location = new System.Drawing.Point(12, 141);
            this.pbZoomed.Name = "pbZoomed";
            this.pbZoomed.Size = new System.Drawing.Size(206, 192);
            this.pbZoomed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZoomed.TabIndex = 3;
            this.pbZoomed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 613);
            this.Controls.Add(this.cbSymbolsImages);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNext20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbFixedWidth);
            this.Controls.Add(this.flpBitmaps);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBitmapHeader);
            this.Controls.Add(this.pbMediumZoom);
            this.Controls.Add(this.lblDecimalValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudPos);
            this.Controls.Add(this.pbZoomed);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnLoadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HF10/HV30 Bitmap Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.NumericUpDown nudPos;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDecimalValues;
        private System.Windows.Forms.Label lblBitmapHeader;
        private PictureBoxEx pbZoomed;
        private PictureBoxEx pbMediumZoom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.FlowLayoutPanel flpBitmaps;
        private System.Windows.Forms.CheckBox cbFixedWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFourByte;
        private System.Windows.Forms.RadioButton rbTwoByte;
        private System.Windows.Forms.Button btnNext20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbSymbolsImages;
        private System.Windows.Forms.RadioButton rbOneByte;
    }
}

