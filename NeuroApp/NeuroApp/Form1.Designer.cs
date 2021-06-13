namespace NeuroApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DBConnParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetrainModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartAnalysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.servNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataBaseToolStripMenuItem,
            this.ModelToolStripMenuItem,
            this.AnalysToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBConnParamsToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.DataBaseToolStripMenuItem.Text = "База данных";
            // 
            // DBConnParamsToolStripMenuItem
            // 
            this.DBConnParamsToolStripMenuItem.Name = "DBConnParamsToolStripMenuItem";
            this.DBConnParamsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DBConnParamsToolStripMenuItem.Text = "Параметры подключения";
            this.DBConnParamsToolStripMenuItem.Click += new System.EventHandler(this.DBConnParamsToolStripMenuItem_Click);
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateModelToolStripMenuItem,
            this.LoadModelToolStripMenuItem,
            this.RetrainModelToolStripMenuItem});
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ModelToolStripMenuItem.Text = "Модель";
            // 
            // CreateModelToolStripMenuItem
            // 
            this.CreateModelToolStripMenuItem.Name = "CreateModelToolStripMenuItem";
            this.CreateModelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CreateModelToolStripMenuItem.Text = "Создать";
            this.CreateModelToolStripMenuItem.Click += new System.EventHandler(this.CreateModelToolStripMenuItem_Click);
            // 
            // LoadModelToolStripMenuItem
            // 
            this.LoadModelToolStripMenuItem.Name = "LoadModelToolStripMenuItem";
            this.LoadModelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadModelToolStripMenuItem.Text = "Загрузить";
            this.LoadModelToolStripMenuItem.Click += new System.EventHandler(this.LoadModelToolStripMenuItem_Click);
            // 
            // RetrainModelToolStripMenuItem
            // 
            this.RetrainModelToolStripMenuItem.Enabled = false;
            this.RetrainModelToolStripMenuItem.Name = "RetrainModelToolStripMenuItem";
            this.RetrainModelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RetrainModelToolStripMenuItem.Text = "Дообучить";
            this.RetrainModelToolStripMenuItem.Click += new System.EventHandler(this.RetrainModelToolStripMenuItem_Click);
            // 
            // AnalysToolStripMenuItem
            // 
            this.AnalysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartAnalysToolStripMenuItem,
            this.остановитьToolStripMenuItem});
            this.AnalysToolStripMenuItem.Enabled = false;
            this.AnalysToolStripMenuItem.Name = "AnalysToolStripMenuItem";
            this.AnalysToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.AnalysToolStripMenuItem.Text = "Анализ";
            // 
            // StartAnalysToolStripMenuItem
            // 
            this.StartAnalysToolStripMenuItem.Name = "StartAnalysToolStripMenuItem";
            this.StartAnalysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartAnalysToolStripMenuItem.Text = "Начать";
            this.StartAnalysToolStripMenuItem.Click += new System.EventHandler(this.StartAnalysToolStripMenuItem_Click);
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.остановитьToolStripMenuItem.Text = "Остановить";
            this.остановитьToolStripMenuItem.Click += new System.EventHandler(this.остановитьToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Поиск аномалий";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // servNameLabel
            // 
            this.servNameLabel.AutoSize = true;
            this.servNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servNameLabel.Location = new System.Drawing.Point(113, 34);
            this.servNameLabel.Name = "servNameLabel";
            this.servNameLabel.Size = new System.Drawing.Size(96, 13);
            this.servNameLabel.TabIndex = 1;
            this.servNameLabel.Text = "Нет подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сервер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "База данных:";
            // 
            // DBNameLabel
            // 
            this.DBNameLabel.AutoSize = true;
            this.DBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBNameLabel.Location = new System.Drawing.Point(113, 62);
            this.DBNameLabel.Name = "DBNameLabel";
            this.DBNameLabel.Size = new System.Drawing.Size(96, 13);
            this.DBNameLabel.TabIndex = 4;
            this.DBNameLabel.Text = "Нет подключения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Модель:";
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelNameLabel.Location = new System.Drawing.Point(116, 91);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(78, 13);
            this.modelNameLabel.TabIndex = 6;
            this.modelNameLabel.Text = "Не загружена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 216);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DBNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система поиска аномалий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartAnalysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DBConnParamsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AnalysToolStripMenuItem;
        public System.Windows.Forms.Label servNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label DBNameLabel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label modelNameLabel;
        public System.Windows.Forms.ToolStripMenuItem RetrainModelToolStripMenuItem;
    }
}

