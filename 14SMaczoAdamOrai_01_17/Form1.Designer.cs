namespace _14SMaczoAdamOrai_01_17
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
            this.hibaBox = new System.Windows.Forms.TextBox();
            this.bejelentesBox = new System.Windows.Forms.TextBox();
            this.leirasBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hibaBox
            // 
            this.hibaBox.Location = new System.Drawing.Point(64, 22);
            this.hibaBox.Name = "hibaBox";
            this.hibaBox.Size = new System.Drawing.Size(131, 20);
            this.hibaBox.TabIndex = 0;
            this.hibaBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bejelentesBox
            // 
            this.bejelentesBox.Location = new System.Drawing.Point(80, 63);
            this.bejelentesBox.Name = "bejelentesBox";
            this.bejelentesBox.Size = new System.Drawing.Size(100, 20);
            this.bejelentesBox.TabIndex = 1;
            this.bejelentesBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // leirasBox
            // 
            this.leirasBox.Location = new System.Drawing.Point(64, 102);
            this.leirasBox.Multiline = true;
            this.leirasBox.Name = "leirasBox";
            this.leirasBox.Size = new System.Drawing.Size(131, 78);
            this.leirasBox.TabIndex = 2;
            this.leirasBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(91, 205);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OKÉS";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 252);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.leirasBox);
            this.Controls.Add(this.bejelentesBox);
            this.Controls.Add(this.hibaBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hibaBox;
        private System.Windows.Forms.TextBox bejelentesBox;
        private System.Windows.Forms.TextBox leirasBox;
        private System.Windows.Forms.Button okButton;
    }
}

