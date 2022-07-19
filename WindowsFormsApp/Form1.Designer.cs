namespace WindowsFormsApp
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxEmoji = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(284, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Emoji App";
            // 
            // textBoxEmoji
            // 
            this.textBoxEmoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmoji.Location = new System.Drawing.Point(449, 155);
            this.textBoxEmoji.Multiline = true;
            this.textBoxEmoji.Name = "textBoxEmoji";
            this.textBoxEmoji.ReadOnly = true;
            this.textBoxEmoji.Size = new System.Drawing.Size(208, 157);
            this.textBoxEmoji.TabIndex = 1;
            this.textBoxEmoji.Text = "❓";
            this.textBoxEmoji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(131, 155);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(225, 157);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Click me for a surprise!";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxEmoji);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxEmoji;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

