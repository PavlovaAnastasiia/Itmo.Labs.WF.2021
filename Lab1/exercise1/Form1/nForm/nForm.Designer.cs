
using System;

namespace nForm
{
    partial class nForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(411, 84);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(129, 24);
            this.checkBoxClose.TabIndex = 0;
            this.checkBoxClose.Text = "checkBoxClose";
            this.checkBoxClose.UseVisualStyleBackColor = true;
   
            nForm.checkBoxClose.CheckedChanged += new System.EventHandler(this.checkBoxClose_CheckedChanged);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(179, 125);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(94, 29);
            this.close.TabIndex = 1;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.checkBoxClose);
            this.Name = "nForm";
            this.Text = "nForm";
            this.Load += new System.EventHandler(this.nForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBoxClose_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxClose;
        private System.Windows.Forms.Button close;
    }
}

