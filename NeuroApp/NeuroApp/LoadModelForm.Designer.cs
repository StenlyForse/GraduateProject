namespace NeuroApp
{
    partial class LoadModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadModelForm));
            this.LoadModelButton1 = new System.Windows.Forms.Button();
            this.LoadModelLabel3 = new System.Windows.Forms.Label();
            this.LoadModelLabel2 = new System.Windows.Forms.Label();
            this.LoadModelModelNumberTextBox = new System.Windows.Forms.TextBox();
            this.LoadModelProjectNumberTextBox = new System.Windows.Forms.TextBox();
            this.LoadModelLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadModelButton1
            // 
            this.LoadModelButton1.Location = new System.Drawing.Point(106, 174);
            this.LoadModelButton1.Name = "LoadModelButton1";
            this.LoadModelButton1.Size = new System.Drawing.Size(75, 23);
            this.LoadModelButton1.TabIndex = 11;
            this.LoadModelButton1.Text = "OK";
            this.LoadModelButton1.UseVisualStyleBackColor = true;
            this.LoadModelButton1.Click += new System.EventHandler(this.LoadModelButton1_Click);
            // 
            // LoadModelLabel3
            // 
            this.LoadModelLabel3.AutoSize = true;
            this.LoadModelLabel3.Location = new System.Drawing.Point(18, 125);
            this.LoadModelLabel3.Name = "LoadModelLabel3";
            this.LoadModelLabel3.Size = new System.Drawing.Size(82, 13);
            this.LoadModelLabel3.TabIndex = 10;
            this.LoadModelLabel3.Text = "Номер модели";
            // 
            // LoadModelLabel2
            // 
            this.LoadModelLabel2.AutoSize = true;
            this.LoadModelLabel2.Location = new System.Drawing.Point(18, 75);
            this.LoadModelLabel2.Name = "LoadModelLabel2";
            this.LoadModelLabel2.Size = new System.Drawing.Size(85, 13);
            this.LoadModelLabel2.TabIndex = 9;
            this.LoadModelLabel2.Text = "Номер проекта";
            // 
            // LoadModelModelNumberTextBox
            // 
            this.LoadModelModelNumberTextBox.Location = new System.Drawing.Point(118, 122);
            this.LoadModelModelNumberTextBox.Name = "LoadModelModelNumberTextBox";
            this.LoadModelModelNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoadModelModelNumberTextBox.TabIndex = 8;
            // 
            // LoadModelProjectNumberTextBox
            // 
            this.LoadModelProjectNumberTextBox.Location = new System.Drawing.Point(118, 72);
            this.LoadModelProjectNumberTextBox.Name = "LoadModelProjectNumberTextBox";
            this.LoadModelProjectNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoadModelProjectNumberTextBox.TabIndex = 7;
            // 
            // LoadModelLabel1
            // 
            this.LoadModelLabel1.AutoSize = true;
            this.LoadModelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadModelLabel1.Location = new System.Drawing.Point(86, 26);
            this.LoadModelLabel1.Name = "LoadModelLabel1";
            this.LoadModelLabel1.Size = new System.Drawing.Size(142, 17);
            this.LoadModelLabel1.TabIndex = 6;
            this.LoadModelLabel1.Text = "Задайте параметры";
            // 
            // LoadModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoadModelButton1);
            this.Controls.Add(this.LoadModelLabel3);
            this.Controls.Add(this.LoadModelLabel2);
            this.Controls.Add(this.LoadModelModelNumberTextBox);
            this.Controls.Add(this.LoadModelProjectNumberTextBox);
            this.Controls.Add(this.LoadModelLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadModelForm";
            this.Text = "Загрузка модели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadModelButton1;
        private System.Windows.Forms.Label LoadModelLabel3;
        private System.Windows.Forms.Label LoadModelLabel2;
        private System.Windows.Forms.TextBox LoadModelModelNumberTextBox;
        private System.Windows.Forms.TextBox LoadModelProjectNumberTextBox;
        private System.Windows.Forms.Label LoadModelLabel1;
    }
}