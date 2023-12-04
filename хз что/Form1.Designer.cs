namespace typingSpeed
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

    
        private void InitializeComponent()
        {
            this.labelTextOriginal = new System.Windows.Forms.Label();
            this.textBoxTextType = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
         
            this.labelTextOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextOriginal.Location = new System.Drawing.Point(64, 36);
            this.labelTextOriginal.Name = "labelTextOriginal";
            this.labelTextOriginal.Size = new System.Drawing.Size(653, 52);
            this.labelTextOriginal.TabIndex = 0;
            this.labelTextOriginal.Text = "A contango market implies oil traders believe crude prices will rally in the futu" +
    "re, encouraging them to store oil now and to sell at a later date.";
      
            this.textBoxTextType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextType.Location = new System.Drawing.Point(68, 110);
            this.textBoxTextType.Multiline = true;
            this.textBoxTextType.Name = "textBoxTextType";
            this.textBoxTextType.Size = new System.Drawing.Size(611, 103);
            this.textBoxTextType.TabIndex = 1;
            this.textBoxTextType.TextChanged += new System.EventHandler(this.textBoxTextType_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::typingSpeed.Properties.Resources.closeRed;
            this.pictureBoxClose.Location = new System.Drawing.Point(617, 294);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.textBoxTextType);
            this.Controls.Add(this.labelTextOriginal);
            this.Name = "Form1";
            this.Text = "Typing Speed Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextOriginal;
        private System.Windows.Forms.TextBox textBoxTextType;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}