namespace _20240203_Fruit_KorteA
{
    partial class Form_FruitList
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
            this.listbox_fruits = new System.Windows.Forms.ListBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_fruits
            // 
            this.listbox_fruits.Dock = System.Windows.Forms.DockStyle.Left;
            this.listbox_fruits.FormattingEnabled = true;
            this.listbox_fruits.ItemHeight = 16;
            this.listbox_fruits.Location = new System.Drawing.Point(0, 0);
            this.listbox_fruits.Name = "listbox_fruits";
            this.listbox_fruits.Size = new System.Drawing.Size(295, 445);
            this.listbox_fruits.TabIndex = 0;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(347, 37);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(193, 40);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Betöltés";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(347, 83);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(193, 40);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(347, 263);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(193, 40);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Módosítás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(347, 217);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(193, 40);
            this.button_insert.TabIndex = 4;
            this.button_insert.Text = "Új";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(347, 309);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(193, 40);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_FruitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 445);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.listbox_fruits);
            this.Name = "Form_FruitList";
            this.Text = "Fruits";
            this.Load += new System.EventHandler(this.Form_FruitList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.ListBox listbox_fruits;
    }
}

