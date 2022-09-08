
namespace Restanta.View
{
    partial class MainScreenview
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
            this.btnHotels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHotels
            // 
            this.btnHotels.Location = new System.Drawing.Point(224, 72);
            this.btnHotels.Name = "btnHotels";
            this.btnHotels.Size = new System.Drawing.Size(325, 68);
            this.btnHotels.TabIndex = 0;
            this.btnHotels.Text = "Hotels";
            this.btnHotels.UseVisualStyleBackColor = true;
            // 
            // MainScreenview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHotels);
            this.Name = "MainScreenview";
            this.Text = "MainScreenview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHotels;
    }
}