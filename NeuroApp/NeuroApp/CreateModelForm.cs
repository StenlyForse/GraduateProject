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
    public partial class CreateModelForm : Form
    {
 

        public CreateModelForm()
        {
            InitializeComponent();
        }

        private void CreateModelForm_Load(object sender, EventArgs e)
        {
   
        }

        //номер проекта
        int projectNumber;
        //номер выборки
        int sampleNumber;
        //имя сервера
        string servName;
        //имя БД
        string DBName;





        private void CreateModelButton1_Click(object sender, EventArgs e)
        {
            //для обращения к родительской форме
            Form1 main = this.Owner as Form1;

            //номер проекта
            projectNumber = Convert.ToInt32(CreateModelProjectNumberTextBox.Text);
            //номер выборки
            sampleNumber = Convert.ToInt32(CreateModelSampleNumberTextBox.Text);

            //имя сервера
            servName = main.servNameLabel.Text;
            //имя БД
            DBName = main.DBNameLabel.Text;



            //создаем новый процесс
            var psi = new ProcessStartInfo();
            //устанавливаем путь до exe питона
            psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";

            //путь до исполняемого скрипта
           
            var script4 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\createModelTest.py";

            //аргументы в питон скрипт
            psi.Arguments = string.Format("{0} {1} {2} {3} {4}", script4, servName, DBName, projectNumber, sampleNumber);

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
                errors,
                "Ошибка создания модели",
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
                "Модель успешно создана",
                "Создание обученной модели",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);


                if (OkResults == DialogResult.OK)
                {
                    Close();
                    this.Activate();
                }
            }

        }

        
    }
}
