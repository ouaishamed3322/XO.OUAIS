namespace xo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.play = new System.Windows.Forms.Button();
            this.pvp = new System.Windows.Forms.Button();
            this.pvc = new System.Windows.Forms.Button();
            this.rtm = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.DodgerBlue;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play.Location = new System.Drawing.Point(145, 75);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(91, 48);
            this.play.TabIndex = 10;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pvp
            // 
            this.pvp.BackColor = System.Drawing.Color.DodgerBlue;
            this.pvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pvp.Location = new System.Drawing.Point(3, 21);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(174, 48);
            this.pvp.TabIndex = 1;
            this.pvp.Text = "player vs player";
            this.pvp.UseVisualStyleBackColor = false;
            this.pvp.Click += new System.EventHandler(this.pvp_Click);
            // 
            // pvc
            // 
            this.pvc.BackColor = System.Drawing.Color.DodgerBlue;
            this.pvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pvc.Location = new System.Drawing.Point(100, 131);
            this.pvc.Name = "pvc";
            this.pvc.Size = new System.Drawing.Size(174, 48);
            this.pvc.TabIndex = 2;
            this.pvc.Text = "play vs computer";
            this.pvc.UseVisualStyleBackColor = false;
            this.pvc.Click += new System.EventHandler(this.pvc_Click);
            // 
            // rtm
            // 
            this.rtm.BackColor = System.Drawing.Color.DodgerBlue;
            this.rtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtm.Location = new System.Drawing.Point(188, 253);
            this.rtm.Name = "rtm";
            this.rtm.Size = new System.Drawing.Size(174, 48);
            this.rtm.TabIndex = 3;
            this.rtm.Text = "RETURN TO MENU";
            this.rtm.UseVisualStyleBackColor = false;
            this.rtm.Click += new System.EventHandler(this.rtm_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(145, 131);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 48);
            this.exit.TabIndex = 4;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 313);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rtm);
            this.Controls.Add(this.pvc);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.play);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pvp;
        private System.Windows.Forms.Button pvc;
        private System.Windows.Forms.Button rtm;
        private System.Windows.Forms.Button exit;
    }
}