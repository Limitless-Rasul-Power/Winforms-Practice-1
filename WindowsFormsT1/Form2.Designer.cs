
namespace WindowsFormsT1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBaku = new System.Windows.Forms.Button();
            this.btnLondon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(141, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnBaku
            // 
            this.btnBaku.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBaku.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBaku.Location = new System.Drawing.Point(1, 521);
            this.btnBaku.Name = "btnBaku";
            this.btnBaku.Size = new System.Drawing.Size(377, 38);
            this.btnBaku.TabIndex = 1;
            this.btnBaku.Text = "Baku";
            this.btnBaku.UseVisualStyleBackColor = false;
            this.btnBaku.Click += new System.EventHandler(this.btnBaku_Click);
            // 
            // btnLondon
            // 
            this.btnLondon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLondon.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLondon.Location = new System.Drawing.Point(384, 521);
            this.btnLondon.Name = "btnLondon";
            this.btnLondon.Size = new System.Drawing.Size(399, 38);
            this.btnLondon.TabIndex = 2;
            this.btnLondon.Text = "London";
            this.btnLondon.UseVisualStyleBackColor = true;
            this.btnLondon.Click += new System.EventHandler(this.btnLondon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLondon);
            this.Controls.Add(this.btnBaku);
            this.Controls.Add(this.lblWelcome);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Forms 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBaku;
        private System.Windows.Forms.Button btnLondon;
    }
}