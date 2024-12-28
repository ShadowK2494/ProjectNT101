namespace ProjectNT101
{
    partial class RSA
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
            this.tbE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiaima = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCiphertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.pbDecode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(871, 249);
            this.tbE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(218, 22);
            this.tbE.TabIndex = 56;
            this.tbE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(830, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "e:";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(871, 218);
            this.tbQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(218, 22);
            this.tbQ.TabIndex = 50;
            this.tbQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(830, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "q:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(988, 295);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 39);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(870, 186);
            this.tbP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(218, 22);
            this.tbP.TabIndex = 51;
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "p:";
            // 
            // btnGiaima
            // 
            this.btnGiaima.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaima.Location = new System.Drawing.Point(899, 419);
            this.btnGiaima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiaima.Name = "btnGiaima";
            this.btnGiaima.Size = new System.Drawing.Size(154, 39);
            this.btnGiaima.TabIndex = 48;
            this.btnGiaima.Text = "GIẢI MÃ";
            this.btnGiaima.UseVisualStyleBackColor = false;
            this.btnGiaima.Click += new System.EventHandler(this.btnGiaima_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ciphertext:";
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Location = new System.Drawing.Point(498, 180);
            this.tbCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCiphertext.Size = new System.Drawing.Size(296, 336);
            this.tbCiphertext.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Plaintext :";
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(80, 180);
            this.tbPlaintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlaintext.Size = new System.Drawing.Size(296, 336);
            this.tbPlaintext.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 43;
            this.label1.Text = "Simple RSA";
            // 
            // btnMahoa
            // 
            this.btnMahoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMahoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMahoa.Location = new System.Drawing.Point(899, 367);
            this.btnMahoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(154, 39);
            this.btnMahoa.TabIndex = 42;
            this.btnMahoa.Text = "MÃ HÓA";
            this.btnMahoa.UseVisualStyleBackColor = false;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // pbCode
            // 
            this.pbCode.BackgroundImage = global::ProjectNT101.Properties.Resources.muitenphai;
            this.pbCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCode.Location = new System.Drawing.Point(411, 295);
            this.pbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(53, 71);
            this.pbCode.TabIndex = 55;
            this.pbCode.TabStop = false;
            // 
            // pbDecode
            // 
            this.pbDecode.BackgroundImage = global::ProjectNT101.Properties.Resources.muitentrai;
            this.pbDecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDecode.Location = new System.Drawing.Point(411, 295);
            this.pbDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDecode.Name = "pbDecode";
            this.pbDecode.Size = new System.Drawing.Size(53, 71);
            this.pbDecode.TabIndex = 54;
            this.pbDecode.TabStop = false;
            // 
            // SimpleRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1168, 578);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.pbDecode);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGiaima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCiphertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlaintext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMahoa);
            this.Name = "RSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.PictureBox pbDecode;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiaima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCiphertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMahoa;
    }
}