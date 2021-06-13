namespace NeuroApp
{
    partial class CreateModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateModelForm));
            this.CreateModelLabel1 = new System.Windows.Forms.Label();
            this.CreateModelProjectNumberTextBox = new System.Windows.Forms.TextBox();
            this.CreateModelSampleNumberTextBox = new System.Windows.Forms.TextBox();
            this.CreateModelLabel2 = new System.Windows.Forms.Label();
            this.CreateModelLabel3 = new System.Windows.Forms.Label();
            this.CreateModelButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateModelLabel1
            // 
            this.CreateModelLabel1.AutoSize = true;
            this.CreateModelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateModelLabel1.Location = new System.Drawing.Point(81, 9);
            this.CreateModelLabel1.Name = "CreateModelLabel1";
            this.CreateModelLabel1.Size = new System.Drawing.Size(142, 17);
            this.CreateModelLabel1.TabIndex = 0;
            this.CreateModelLabel1.Text = "Задайте параметры";
            // 
            // CreateModelProjectNumberTextBox
            // 
            this.CreateModelProjectNumberTextBox.Location = new System.Drawing.Point(113, 55);
            this.CreateModelProjectNumberTextBox.Name = "CreateModelProjectNumberTextBox";
            this.CreateModelProjectNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreateModelProjectNumberTextBox.TabIndex = 1;
            // 
            // CreateModelSampleNumberTextBox
            // 
            this.CreateModelSampleNumberTextBox.Location = new System.Drawing.Point(113, 105);
            this.CreateModelSampleNumberTextBox.Name = "CreateModelSampleNumberTextBox";
            this.CreateModelSampleNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreateModelSampleNumberTextBox.TabIndex = 2;
            // 
            // CreateModelLabel2
            // 
            this.CreateModelLabel2.AutoSize = true;
            this.CreateModelLabel2.Location = new System.Drawing.Point(13, 58);
            this.CreateModelLabel2.Name = "CreateModelLabel2";
            this.CreateModelLabel2.Size = new System.Drawing.Size(85, 13);
            this.CreateModelLabel2.TabIndex = 3;
            this.CreateModelLabel2.Text = "Номер проекта";
            // 
            // CreateModelLabel3
            // 
            this.CreateModelLabel3.AutoSize = true;
            this.CreateModelLabel3.Location = new System.Drawing.Point(13, 108);
            this.CreateModelLabel3.Name = "CreateModelLabel3";
            this.CreateModelLabel3.Size = new System.Drawing.Size(88, 13);
            this.CreateModelLabel3.TabIndex = 4;
            this.CreateModelLabel3.Text = "Номер выборки";
            // 
            // CreateModelButton1
            // 
            this.CreateModelButton1.Location = new System.Drawing.Point(101, 157);
            this.CreateModelButton1.Name = "CreateModelButton1";
            this.CreateModelButton1.Size = new System.Drawing.Size(75, 23);
            this.CreateModelButton1.TabIndex = 5;
            this.CreateModelButton1.Text = "OK";
            this.CreateModelButton1.UseVisualStyleBackColor = true;
            this.CreateModelButton1.Click += new System.EventHandler(this.CreateModelButton1_Click);
            // 
            // CreateModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 192);
            this.Controls.Add(this.CreateModelButton1);
            this.Controls.Add(this.CreateModelLabel3);
            this.Controls.Add(this.CreateModelLabel2);
            this.Controls.Add(this.CreateModelSampleNumberTextBox);
            this.Controls.Add(this.CreateModelProjectNumberTextBox);
            this.Controls.Add(this.CreateModelLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateModelForm";
            this.Text = "Создание модели";
            this.Load += new System.EventHandler(this.CreateModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateModelLabel1;
        private System.Windows.Forms.TextBox CreateModelProjectNumberTextBox;
        private System.Windows.Forms.TextBox CreateModelSampleNumberTextBox;
        private System.Windows.Forms.Label CreateModelLabel2;
        private System.Windows.Forms.Label CreateModelLabel3;
        private System.Windows.Forms.Button CreateModelButton1;
    }
}