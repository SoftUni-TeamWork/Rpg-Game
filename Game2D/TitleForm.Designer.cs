namespace Game2D
{
    partial class TitleForm
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
            this.TitleTrue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTrue
            // 
            this.TitleTrue.AutoSize = true;
            this.TitleTrue.Location = new System.Drawing.Point(256, 215);
            this.TitleTrue.Name = "TitleTrue";
            this.TitleTrue.Size = new System.Drawing.Size(136, 13);
            this.TitleTrue.TabIndex = 0;
            this.TitleTrue.Text = "Title TO DO: Write som title";
            this.TitleTrue.Click += new System.EventHandler(this.TitleTrue_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 657);
            this.Controls.Add(this.TitleTrue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleForm";
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Title_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleTrue;
    }
}