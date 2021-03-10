
namespace WindowsFormsT1
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
            this.btnCatchMeIfYouCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchMeIfYouCan
            // 
            this.btnCatchMeIfYouCan.BackgroundImage = global::WindowsFormsT1.Properties.Resources.Race;
            this.btnCatchMeIfYouCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatchMeIfYouCan.Location = new System.Drawing.Point(114, 168);
            this.btnCatchMeIfYouCan.Name = "btnCatchMeIfYouCan";
            this.btnCatchMeIfYouCan.Size = new System.Drawing.Size(250, 100);
            this.btnCatchMeIfYouCan.TabIndex = 0;
            this.btnCatchMeIfYouCan.UseVisualStyleBackColor = true;
            this.btnCatchMeIfYouCan.Click += new System.EventHandler(this.btnCatchMeIfYouCan_Click);
            this.btnCatchMeIfYouCan.MouseHover += new System.EventHandler(this.btnCatchMeIfYouCan_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnCatchMeIfYouCan);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Windows Forms 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchMeIfYouCan;
    }
}

