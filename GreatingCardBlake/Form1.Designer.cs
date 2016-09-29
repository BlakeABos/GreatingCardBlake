namespace GreatingCardBlake
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
            this.aries = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.greetingButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aries)).BeginInit();
            this.SuspendLayout();
            // 
            // aries
            // 
            this.aries.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aries.ErrorImage = global::GreatingCardBlake.Properties.Resources.aries_zodiac_sign;
            this.aries.Image = global::GreatingCardBlake.Properties.Resources.download;
            this.aries.InitialImage = global::GreatingCardBlake.Properties.Resources.aries_zodiac_sign;
            this.aries.Location = new System.Drawing.Point(12, 12);
            this.aries.Name = "aries";
            this.aries.Size = new System.Drawing.Size(260, 195);
            this.aries.TabIndex = 0;
            this.aries.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playButton.Location = new System.Drawing.Point(0, -3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(286, 264);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "shhhhh";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // greetingButton
            // 
            this.greetingButton.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.greetingButton.Location = new System.Drawing.Point(68, 219);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(152, 33);
            this.greetingButton.TabIndex = 2;
            this.greetingButton.Text = "Greetings !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.greetingButton);
            this.Controls.Add(this.aries);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Greatings";
            ((System.ComponentModel.ISupportInitialize)(this.aries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aries;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label greetingButton;
    }
}

