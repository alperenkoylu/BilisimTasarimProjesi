namespace ImageSteganographyLinearLSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbLayer1 = new System.Windows.Forms.PictureBox();
            this.pbLayer2 = new System.Windows.Forms.PictureBox();
            this.pbLayer3 = new System.Windows.Forms.PictureBox();
            this.pbLayer4 = new System.Windows.Forms.PictureBox();
            this.pbLayer5 = new System.Windows.Forms.PictureBox();
            this.pbLayer6 = new System.Windows.Forms.PictureBox();
            this.pbLayer7 = new System.Windows.Forms.PictureBox();
            this.pbLayer8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gboxMessage = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblImageName = new System.Windows.Forms.Label();
            this.pboxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer8)).BeginInit();
            this.gboxMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.SystemColors.Control;
            this.pbOriginal.Image = ((System.Drawing.Image)(resources.GetObject("pbOriginal.Image")));
            this.pbOriginal.Location = new System.Drawing.Point(12, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(256, 256);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbLayer1
            // 
            this.pbLayer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer1.Location = new System.Drawing.Point(274, 12);
            this.pbLayer1.Name = "pbLayer1";
            this.pbLayer1.Size = new System.Drawing.Size(128, 128);
            this.pbLayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer1.TabIndex = 2;
            this.pbLayer1.TabStop = false;
            this.pbLayer1.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer2
            // 
            this.pbLayer2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer2.Location = new System.Drawing.Point(408, 12);
            this.pbLayer2.Name = "pbLayer2";
            this.pbLayer2.Size = new System.Drawing.Size(128, 128);
            this.pbLayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer2.TabIndex = 3;
            this.pbLayer2.TabStop = false;
            this.pbLayer2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer3
            // 
            this.pbLayer3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer3.Location = new System.Drawing.Point(542, 12);
            this.pbLayer3.Name = "pbLayer3";
            this.pbLayer3.Size = new System.Drawing.Size(128, 128);
            this.pbLayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer3.TabIndex = 4;
            this.pbLayer3.TabStop = false;
            this.pbLayer3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer4
            // 
            this.pbLayer4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer4.Location = new System.Drawing.Point(676, 12);
            this.pbLayer4.Name = "pbLayer4";
            this.pbLayer4.Size = new System.Drawing.Size(128, 128);
            this.pbLayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer4.TabIndex = 5;
            this.pbLayer4.TabStop = false;
            this.pbLayer4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer5
            // 
            this.pbLayer5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer5.Location = new System.Drawing.Point(274, 169);
            this.pbLayer5.Name = "pbLayer5";
            this.pbLayer5.Size = new System.Drawing.Size(128, 128);
            this.pbLayer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer5.TabIndex = 6;
            this.pbLayer5.TabStop = false;
            this.pbLayer5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer6
            // 
            this.pbLayer6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer6.Location = new System.Drawing.Point(408, 169);
            this.pbLayer6.Name = "pbLayer6";
            this.pbLayer6.Size = new System.Drawing.Size(128, 128);
            this.pbLayer6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer6.TabIndex = 7;
            this.pbLayer6.TabStop = false;
            this.pbLayer6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer7
            // 
            this.pbLayer7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer7.Location = new System.Drawing.Point(542, 169);
            this.pbLayer7.Name = "pbLayer7";
            this.pbLayer7.Size = new System.Drawing.Size(128, 128);
            this.pbLayer7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer7.TabIndex = 8;
            this.pbLayer7.TabStop = false;
            this.pbLayer7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbLayer8
            // 
            this.pbLayer8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbLayer8.Location = new System.Drawing.Point(676, 169);
            this.pbLayer8.Name = "pbLayer8";
            this.pbLayer8.Size = new System.Drawing.Size(128, 128);
            this.pbLayer8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayer8.TabIndex = 9;
            this.pbLayer8.TabStop = false;
            this.pbLayer8.Click += new System.EventHandler(this.pb_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(274, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Layer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(405, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Second Layer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(539, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Third Layer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(673, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fourth Layer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(271, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fifth Layer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(405, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sixth Layer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(539, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Seventh Layer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(673, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Eighth Layer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Original Image";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxMessage
            // 
            this.gboxMessage.Controls.Add(this.btnSave);
            this.gboxMessage.Controls.Add(this.txtMessage);
            this.gboxMessage.Location = new System.Drawing.Point(12, 326);
            this.gboxMessage.Name = "gboxMessage";
            this.gboxMessage.Size = new System.Drawing.Size(792, 198);
            this.gboxMessage.TabIndex = 21;
            this.gboxMessage.TabStop = false;
            this.gboxMessage.Text = "Message";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(664, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 173);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Message";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(6, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(652, 173);
            this.txtMessage.TabIndex = 20;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblImageName
            // 
            this.lblImageName.ForeColor = System.Drawing.Color.Red;
            this.lblImageName.Location = new System.Drawing.Point(12, 300);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(256, 23);
            this.lblImageName.TabIndex = 22;
            this.lblImageName.Text = "Image Name";
            this.lblImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxPreview
            // 
            this.pboxPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxPreview.Location = new System.Drawing.Point(810, 12);
            this.pboxPreview.Name = "pboxPreview";
            this.pboxPreview.Size = new System.Drawing.Size(512, 512);
            this.pboxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPreview.TabIndex = 23;
            this.pboxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 536);
            this.Controls.Add(this.pboxPreview);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.gboxMessage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLayer8);
            this.Controls.Add(this.pbLayer7);
            this.Controls.Add(this.pbLayer6);
            this.Controls.Add(this.pbLayer5);
            this.Controls.Add(this.pbLayer4);
            this.Controls.Add(this.pbLayer3);
            this.Controls.Add(this.pbLayer2);
            this.Controls.Add(this.pbLayer1);
            this.Controls.Add(this.pbOriginal);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear LSB Image Stegonagraphy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayer8)).EndInit();
            this.gboxMessage.ResumeLayout(false);
            this.gboxMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbLayer1;
        private System.Windows.Forms.PictureBox pbLayer2;
        private System.Windows.Forms.PictureBox pbLayer3;
        private System.Windows.Forms.PictureBox pbLayer4;
        private System.Windows.Forms.PictureBox pbLayer5;
        private System.Windows.Forms.PictureBox pbLayer6;
        private System.Windows.Forms.PictureBox pbLayer7;
        private System.Windows.Forms.PictureBox pbLayer8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gboxMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pboxPreview;
    }
}

