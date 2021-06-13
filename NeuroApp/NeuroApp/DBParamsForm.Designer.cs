namespace NeuroApp
{
    partial class DBParamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBParamsForm));
            this.DBParamsLabel1 = new System.Windows.Forms.Label();
            this.DBParamsLabel2 = new System.Windows.Forms.Label();
            this.DBParamsLabel3 = new System.Windows.Forms.Label();
            this.DBParamsConnButton = new System.Windows.Forms.Button();
            this.DBParamsServNameComboBox = new System.Windows.Forms.ComboBox();
            this.DBParamsDBNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DBParamsLabel1
            // 
            this.DBParamsLabel1.AutoSize = true;
            this.DBParamsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBParamsLabel1.Location = new System.Drawing.Point(126, 28);
            this.DBParamsLabel1.Name = "DBParamsLabel1";
            this.DBParamsLabel1.Size = new System.Drawing.Size(205, 16);
            this.DBParamsLabel1.TabIndex = 0;
            this.DBParamsLabel1.Text = "Параметры подключения к БД";
            // 
            // DBParamsLabel2
            // 
            this.DBParamsLabel2.AutoSize = true;
            this.DBParamsLabel2.Location = new System.Drawing.Point(21, 100);
            this.DBParamsLabel2.Name = "DBParamsLabel2";
            this.DBParamsLabel2.Size = new System.Drawing.Size(102, 13);
            this.DBParamsLabel2.TabIndex = 3;
            this.DBParamsLabel2.Text = "Название сервера";
            // 
            // DBParamsLabel3
            // 
            this.DBParamsLabel3.AutoSize = true;
            this.DBParamsLabel3.Location = new System.Drawing.Point(21, 164);
            this.DBParamsLabel3.Name = "DBParamsLabel3";
            this.DBParamsLabel3.Size = new System.Drawing.Size(76, 13);
            this.DBParamsLabel3.TabIndex = 4;
            this.DBParamsLabel3.Text = "Название БД";
            // 
            // DBParamsConnButton
            // 
            this.DBParamsConnButton.Location = new System.Drawing.Point(325, 234);
            this.DBParamsConnButton.Name = "DBParamsConnButton";
            this.DBParamsConnButton.Size = new System.Drawing.Size(102, 23);
            this.DBParamsConnButton.TabIndex = 5;
            this.DBParamsConnButton.Text = "Подключиться";
            this.DBParamsConnButton.UseVisualStyleBackColor = true;
            this.DBParamsConnButton.Click += new System.EventHandler(this.DBParamsConnButton_Click);
            // 
            // DBParamsServNameComboBox
            // 
            this.DBParamsServNameComboBox.FormattingEnabled = true;
            this.DBParamsServNameComboBox.Items.AddRange(new object[] {
            "LAPTOP-0O3M29HG\\SQLEXPRESS"});
            this.DBParamsServNameComboBox.Location = new System.Drawing.Point(129, 97);
            this.DBParamsServNameComboBox.Name = "DBParamsServNameComboBox";
            this.DBParamsServNameComboBox.Size = new System.Drawing.Size(202, 21);
            this.DBParamsServNameComboBox.TabIndex = 6;
            // 
            // DBParamsDBNameComboBox
            // 
            this.DBParamsDBNameComboBox.FormattingEnabled = true;
            this.DBParamsDBNameComboBox.Items.AddRange(new object[] {
            "NeuroApp"});
            this.DBParamsDBNameComboBox.Location = new System.Drawing.Point(129, 161);
            this.DBParamsDBNameComboBox.Name = "DBParamsDBNameComboBox";
            this.DBParamsDBNameComboBox.Size = new System.Drawing.Size(202, 21);
            this.DBParamsDBNameComboBox.TabIndex = 7;
            // 
            // DBParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 269);
            this.Controls.Add(this.DBParamsDBNameComboBox);
            this.Controls.Add(this.DBParamsServNameComboBox);
            this.Controls.Add(this.DBParamsConnButton);
            this.Controls.Add(this.DBParamsLabel3);
            this.Controls.Add(this.DBParamsLabel2);
            this.Controls.Add(this.DBParamsLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBParamsForm";
            this.Text = "Параметры подключения к БД";
            this.Load += new System.EventHandler(this.DBParamsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DBParamsLabel1;
        private System.Windows.Forms.Label DBParamsLabel2;
        private System.Windows.Forms.Label DBParamsLabel3;
        private System.Windows.Forms.Button DBParamsConnButton;
        public System.Windows.Forms.ComboBox DBParamsServNameComboBox;
        public System.Windows.Forms.ComboBox DBParamsDBNameComboBox;
    }
}