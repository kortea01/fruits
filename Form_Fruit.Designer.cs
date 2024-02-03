using System;

namespace _20240203_Fruit_KorteA
{
    partial class Form_Fruit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Menny = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(152, 42);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(72, 30);
            this.textBox_Id.TabIndex = 1;
            this.textBox_Id.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(152, 110);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(221, 30);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mennyiség";
            // 
            // textBox_Menny
            // 
            this.textBox_Menny.Location = new System.Drawing.Point(158, 204);
            this.textBox_Menny.Name = "textBox_Menny";
            this.textBox_Menny.Size = new System.Drawing.Size(221, 30);
            this.textBox_Menny.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Menny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_Fruit";
            this.Text = "Form_Fruit";
            this.Load += new System.EventHandler(this.Form_Fruit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Menny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}