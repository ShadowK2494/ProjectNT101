namespace ProjectNT101
{
    partial class RootForm
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
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnPlayfair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRSA
            // 
            this.btnRSA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnRSA.Location = new System.Drawing.Point(223, 179);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(265, 86);
            this.btnRSA.TabIndex = 0;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = false;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlayfair.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnPlayfair.Location = new System.Drawing.Point(223, 289);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(265, 86);
            this.btnPlayfair.TabIndex = 1;
            this.btnPlayfair.Text = "Playfair";
            this.btnPlayfair.UseVisualStyleBackColor = false;
            this.btnPlayfair.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "Project NT101";
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayfair);
            this.Controls.Add(this.btnRSA);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnPlayfair;
        private System.Windows.Forms.Label label1;
    }
}

