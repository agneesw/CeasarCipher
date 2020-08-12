namespace WindowsInlämning2
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
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AvailableChiffers = new System.Windows.Forms.ListBox();
            this.ChosedChiffers = new System.Windows.Forms.ListBox();
            this.AddC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(81, 112);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(238, 51);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "Encypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(358, 112);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(289, 51);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 103);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AvailableChiffers
            // 
            this.AvailableChiffers.FormattingEnabled = true;
            this.AvailableChiffers.Location = new System.Drawing.Point(58, 213);
            this.AvailableChiffers.Name = "AvailableChiffers";
            this.AvailableChiffers.Size = new System.Drawing.Size(234, 186);
            this.AvailableChiffers.TabIndex = 4;
            // 
            // ChosedChiffers
            // 
            this.ChosedChiffers.FormattingEnabled = true;
            this.ChosedChiffers.Location = new System.Drawing.Point(420, 213);
            this.ChosedChiffers.Name = "ChosedChiffers";
            this.ChosedChiffers.Size = new System.Drawing.Size(241, 186);
            this.ChosedChiffers.TabIndex = 5;
            // 
            // AddC
            // 
            this.AddC.Location = new System.Drawing.Point(299, 225);
            this.AddC.Name = "AddC";
            this.AddC.Size = new System.Drawing.Size(115, 48);
            this.AddC.TabIndex = 6;
            this.AddC.Text = "Add";
            this.AddC.UseVisualStyleBackColor = true;
            this.AddC.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddC);
            this.Controls.Add(this.ChosedChiffers);
            this.Controls.Add(this.AvailableChiffers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox AvailableChiffers;
        private System.Windows.Forms.ListBox ChosedChiffers;
        private System.Windows.Forms.Button AddC;
        private System.Windows.Forms.Button button1;
    }
}

