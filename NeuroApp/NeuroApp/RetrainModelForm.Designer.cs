namespace NeuroApp
{
    partial class RetrainModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrainModelForm));
            this.RetrainModelButton1 = new System.Windows.Forms.Button();
            this.RetrainModelLabel1 = new System.Windows.Forms.Label();
            this.RetrainModelLabel4 = new System.Windows.Forms.Label();
            this.RetrainModelSampleNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RetrainModelNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RetrainModelButton1
            // 
            this.RetrainModelButton1.Location = new System.Drawing.Point(103, 187);
            this.RetrainModelButton1.Name = "RetrainModelButton1";
            this.RetrainModelButton1.Size = new System.Drawing.Size(75, 23);
            this.RetrainModelButton1.TabIndex = 11;
            this.RetrainModelButton1.Text = "OK";
            this.RetrainModelButton1.UseVisualStyleBackColor = true;
            this.RetrainModelButton1.Click += new System.EventHandler(this.RetrainModelButton1_Click);
            // 
            // RetrainModelLabel1
            // 
            this.RetrainModelLabel1.AutoSize = true;
            this.RetrainModelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RetrainModelLabel1.Location = new System.Drawing.Point(72, 19);
            this.RetrainModelLabel1.Name = "RetrainModelLabel1";
            this.RetrainModelLabel1.Size = new System.Drawing.Size(142, 17);
            this.RetrainModelLabel1.TabIndex = 6;
            this.RetrainModelLabel1.Text = "Задайте параметры";
            // 
            // RetrainModelLabel4
            // 
            this.RetrainModelLabel4.AutoSize = true;
            this.RetrainModelLabel4.Location = new System.Drawing.Point(14, 126);
            this.RetrainModelLabel4.Name = "RetrainModelLabel4";
            this.RetrainModelLabel4.Size = new System.Drawing.Size(88, 13);
            this.RetrainModelLabel4.TabIndex = 13;
            this.RetrainModelLabel4.Text = "Номер выборки";
            // 
            // RetrainModelSampleNumberTextBox
            // 
            this.RetrainModelSampleNumberTextBox.Location = new System.Drawing.Point(114, 123);
            this.RetrainModelSampleNumberTextBox.Name = "RetrainModelSampleNumberTextBox";
            this.RetrainModelSampleNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.RetrainModelSampleNumberTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Модель:";
            // 
            // RetrainModelNameLabel
            // 
            this.RetrainModelNameLabel.AutoSize = true;
            this.RetrainModelNameLabel.Location = new System.Drawing.Point(82, 66);
            this.RetrainModelNameLabel.Name = "RetrainModelNameLabel";
            this.RetrainModelNameLabel.Size = new System.Drawing.Size(35, 13);
            this.RetrainModelNameLabel.TabIndex = 15;
            this.RetrainModelNameLabel.Text = "label2";
            // 
            // RetrainModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.RetrainModelNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RetrainModelLabel4);
            this.Controls.Add(this.RetrainModelSampleNumberTextBox);
            this.Controls.Add(this.RetrainModelButton1);
            this.Controls.Add(this.RetrainModelLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetrainModelForm";
            this.Text = "Дообучение модели";
            this.Activated += new System.EventHandler(this.RetrainModelForm_Activated);
            this.Load += new System.EventHandler(this.RetrainModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetrainModelButton1;
        private System.Windows.Forms.Label RetrainModelLabel1;
        private System.Windows.Forms.Label RetrainModelLabel4;
        private System.Windows.Forms.TextBox RetrainModelSampleNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RetrainModelNameLabel;
    }
}