namespace Game2D
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pingvinPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pingvinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(125, 261);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(100, 23);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Start New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(125, 303);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit The Game";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pingvinPicture
            // 
            this.pingvinPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pingvinPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pingvinPicture.ErrorImage")));
            this.pingvinPicture.Image = ((System.Drawing.Image)(resources.GetObject("pingvinPicture.Image")));
            this.pingvinPicture.Location = new System.Drawing.Point(-13, -1);
            this.pingvinPicture.Name = "pingvinPicture";
            this.pingvinPicture.Size = new System.Drawing.Size(403, 399);
            this.pingvinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pingvinPicture.TabIndex = 2;
            this.pingvinPicture.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 398);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.pingvinPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pingvinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pingvinPicture;
    }
}