using System;
using System.Drawing;
namespace Quiz
{
    
    partial class Form_Examination
    {
        
        Random random = new Random();
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
            this.SuspendLayout();
            // 
            // Form_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Name = "Form_Examination";
            this.Text = "Проверка знаний";
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = ClientSize;
            this.MinimumSize = ClientSize;
            this.Icon = Properties.Resources.icon;

        }
        

        

        #endregion
    }
}