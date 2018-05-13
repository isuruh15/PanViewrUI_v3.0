﻿namespace PanViewrUI_v3._0
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mapSegment = new System.Windows.Forms.PictureBox();
            this.btnResolution = new System.Windows.Forms.Button();
            this.btnCamOrder = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapSegment)).BeginInit();
            this.SuspendLayout();
            // 
            // mapSegment
            // 
            this.mapSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapSegment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapSegment.BackgroundImage")));
            this.mapSegment.Location = new System.Drawing.Point(12, 151);
            this.mapSegment.Name = "mapSegment";
            this.mapSegment.Size = new System.Drawing.Size(459, 184);
            this.mapSegment.TabIndex = 0;
            this.mapSegment.TabStop = false;
            // 
            // btnResolution
            // 
            this.btnResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolution.Location = new System.Drawing.Point(481, 215);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Size = new System.Drawing.Size(163, 51);
            this.btnResolution.TabIndex = 1;
            this.btnResolution.Text = "Resolution";
            this.btnResolution.UseVisualStyleBackColor = true;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click);
            // 
            // btnCamOrder
            // 
            this.btnCamOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamOrder.Location = new System.Drawing.Point(665, 213);
            this.btnCamOrder.Name = "btnCamOrder";
            this.btnCamOrder.Size = new System.Drawing.Size(153, 53);
            this.btnCamOrder.TabIndex = 2;
            this.btnCamOrder.Text = "Camera Order";
            this.btnCamOrder.UseVisualStyleBackColor = true;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.Location = new System.Drawing.Point(665, 282);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(153, 53);
            this.btnShutDown.TabIndex = 4;
            this.btnShutDown.Text = "Shut Down";
            this.btnShutDown.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(481, 284);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 51);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 359);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCamOrder);
            this.Controls.Add(this.btnResolution);
            this.Controls.Add(this.mapSegment);
            this.Name = "Main";
            this.Text = "Pan Viwer";
            ((System.ComponentModel.ISupportInitialize)(this.mapSegment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapSegment;
        private System.Windows.Forms.Button btnResolution;
        private System.Windows.Forms.Button btnCamOrder;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnStart;
    }
}

