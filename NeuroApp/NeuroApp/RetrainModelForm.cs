using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroApp
{
    public partial class RetrainModelForm : Form
    {
        public RetrainModelForm()
        {
            InitializeComponent();

        }



        //имя сервера
        string servName;
        //имя БД
        string DBName;
        //имя модели
        string modelName;

        //номер проекта
        //int projectNumber;
        //номер выборки
        int sampleNumber;

        private void RetrainModelForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Событие открытия(активации) формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetrainModelForm_Activated(object sender, EventArgs e)
        {

            //для обращения к родительской форме
            Form1 main = this.Owner as Form1;
            //подгрузка имени модели на лейбл
            RetrainModelNameLabel.Text = main.modelNameLabel.Text;

            //имя сервера
            servName = main.servNameLabel.Text;
            //имя БД
            DBName = main.DBNameLabel.Text;
        }

        private void RetrainModelButton1_Click(object sender, EventArgs e)
        {
            //projectNumber = Convert.ToInt32(RetrainModelProjectNumberTextBox.Text);
            sampleNumber = Convert.ToInt32(RetrainModelSampleNumberTextBox.Text);

            modelName = RetrainModelNameLabel.Text;

            //создаем новый процесс
            var psi = new ProcessStartInfo();
            //устанавливаем путь до exe питона
            psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";
            //путь до исполняемого скрипта

            var script6 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\retrainModelTest.py";

            //аргументы в питон скрипт
            psi.Arguments = string.Format("{0} {1} {2} {3} {4}", script6, servName, DBName, sampleNumber, modelName);

            //разные необхожимые настройки
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            var errors = "";
            var results = "";


            // процесс как раз
            using (var process = Process.Start(psi))
            {
                // на чтении эрроров программа завистает, так как однопоточная
                //errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            if (results.Length <= 0)
            {
                // показываем окно об ошибке
                DialogResult ErrorsResults = MessageBox.Show(
                "Ошибка дообучения модели",
                "Дообучение модели",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (ErrorsResults == DialogResult.OK)
                {
                    Close();
                    this.Activate();
                }
            }

            if (results.Length > 0)
            {
                DialogResult OkResults = MessageBox.Show(
                "Модель успешно дообучена",
                "Дообучение модели",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);


                if (OkResults == DialogResult.OK)
                {
                    //делаем пункт Дообучить доступным
                    (this.Owner as Form1).AnalysToolStripMenuItem.Enabled = true;
                    Close();
                    this.Activate();
                }
            }

            Close();
        }

        
    }
}
