namespace ProjectNT101
{
    partial class Playfair
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textMatrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textKey = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Solution :";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDecrypt.Location = new System.Drawing.Point(718, 338);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(206, 67);
            this.buttonDecrypt.TabIndex = 20;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(227, 422);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(697, 122);
            this.textOutput.TabIndex = 19;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEncrypt.Location = new System.Drawing.Point(718, 266);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(206, 67);
            this.buttonEncrypt.TabIndex = 18;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textMatrix
            // 
            this.textMatrix.Location = new System.Drawing.Point(227, 301);
            this.textMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.textMatrix.Multiline = true;
            this.textMatrix.Name = "textMatrix";
            this.textMatrix.ReadOnly = true;
            this.textMatrix.Size = new System.Drawing.Size(470, 103);
            this.textMatrix.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Matrix :";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(227, 266);
            this.textKey.Margin = new System.Windows.Forms.Padding(4);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(470, 22);
            this.textKey.TabIndex = 15;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(227, 123);
            this.textInput.Margin = new System.Windows.Forms.Padding(4);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInput.Size = new System.Drawing.Size(697, 122);
            this.textInput.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Text Input :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 42);
            this.label1.TabIndex = 44;
            this.label1.Text = "Playfair Cipher";
            // 
            // Playfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1035, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textMatrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Playfair";
            this.Text = "Playfair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textMatrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}