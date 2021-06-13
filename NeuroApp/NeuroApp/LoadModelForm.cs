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
    public partial class LoadModelForm : Form
    {
        public LoadModelForm()
        {
            InitializeComponent();
        }


        //номер проекта
        int projectNumber;
        //номер модели
        int modelNumber;
        //имя сервера
        string servName;
        //имя БД
        string DBName;

        string modelName; //= "model";

        private void LoadModelButton1_Click(object sender, EventArgs e)
        {

            //для обращения к родительской форме
            Form1 main = this.Owner as Form1;

            //имя сервера
            servName = main.servNameLabel.Text;
            //имя БД
            DBName = main.DBNameLabel.Text;

            projectNumber = Convert.ToInt32(LoadModelProjectNumberTextBox.Text);
            modelNumber = Convert.ToInt32(LoadModelModelNumberTextBox.Text);

            //создаем новый процесс
            var psi = new ProcessStartInfo();
            //устанавливаем путь до exe питона
            psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";

            //путь до исполняемого скрипта

            var script5 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\loadModelTest.py";

            //аргументы в питон скрипт
            psi.Arguments = string.Format("{0} {1} {2} {3} {4}", script5, servName, DBName, projectNumber, modelNumber);

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
                "Ошибка загрузки модели",
                "Загрузка обученной модели",
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
                "Модель успешно загружена",
                "Загрузка обученной модели",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);


                if (OkResults == DialogResult.OK)
                {
                    //делаем пункт Дообучить доступным
                    (this.Owner as Form1).RetrainModelToolStripMenuItem.Enabled = true;

                    //создаем имя модели и присваиваем лейблу
                    modelName = "model" + projectNumber + modelNumber + ".h5";
                    main.modelNameLabel.Text = modelName;
                    modelName = "";

                    (this.Owner as Form1).AnalysToolStripMenuItem.Enabled = true;

                    Close();
                    this.Activate();
                }
            }

            Close();
        }
    }
}
