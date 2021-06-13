using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroApp
{
    public partial class Form1 : Form
    {
        public Thread to;
        public Form1()
        {
            InitializeComponent();

            //значок в трее
            notifyIcon1.Visible = false;

            startAnalysBool = false;

            //максимальный и предыдущий ID



            //Thread t = new Thread(() => AnalysProcess(startAnalysBool, servName, DBName, prevID, maxID));
            // поток для выполнения анализа
            to = new Thread(() => AnalysProcess(startAnalysBool, servName, DBName, modelName, prevID, maxID));
        }

        bool startAnalysBool;

        /// <summary>
        /// Инициализируем формы
        /// </summary>
        CreateModelForm CreateModel = new CreateModelForm();
        RetrainModelForm RetrainModel = new RetrainModelForm();
        LoadModelForm LoadModel = new LoadModelForm();
        DBParamsForm DBParams = new DBParamsForm();


        //имя сервера
        string servName;
        //имя БД
        string DBName;
        //имя модели
        string modelName;

        //потом переопределяются, присваивание необходимо для работы потока
        int maxID = 1;
        int prevID = 1;



        //переменная показывающая начало анализа или его конец


        /// <summary>
        /// Обработчик нажатия на кнопку "Создать модель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModel.Owner = this;
            CreateModel.StartPosition = FormStartPosition.CenterParent;
            CreateModel.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Дообучить модель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetrainModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetrainModel.Owner = this;
            RetrainModel.StartPosition = FormStartPosition.CenterParent;
            RetrainModel.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Загрузить модель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel.Owner = this;
            LoadModel.StartPosition = FormStartPosition.CenterParent;
            LoadModel.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //делаем недоступными меню объектов
            ModelToolStripMenuItem.Enabled = false;
            AnalysToolStripMenuItem.Enabled = false;
            //label1.Text = DBParams.SrvName;
        }

        public bool modelEnable(bool a)
        {
             return ModelToolStripMenuItem.Enabled = a;
        }

        /// <summary>
        /// Обработчик кнопки выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //диалоговое окошко при нажатии кнопки "Выход"
            DialogResult exit = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (exit == DialogResult.Yes)
            {
                to.Abort();
                Application.Exit();
            }
            else if (exit == DialogResult.No)
                this.Activate();
            
        }

        /// <summary>
        /// Обработка нажатия на значок в трее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // разворачиваем окно в нормальный размер
            this.WindowState = FormWindowState.Normal;

            // скрываем значок из треи
            notifyIcon1.Visible = false;


            // делает окошко вновь видимым при развертывании из треи
            this.Visible = true;
            this.ShowInTaskbar = true;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // убираем окно из панели задач
                this.ShowInTaskbar = false;

                // значок появляется в трее
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = notifyIcon1.Icon;
                // показ уведомления о том, что оно в трее
                notifyIcon1.ShowBalloonTip(
                    10000,
                    "Система поиска аномалий",
                    "Приложение продолжит работу в фоновом режиме.",
                    ToolTipIcon.Info
                    );
            }

            // убирает иконку из треи
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        /// <summary>
        /// Обработка нажатия на крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // при нажатии на крестик сворачивает в трею
           if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
                // показ уведомления о том, что оно в трее
                notifyIcon1.ShowBalloonTip(
                    10000,
                    "Система поиска аномалий",
                    "Приложение продолжит работу в фоновом режиме.",
                    ToolTipIcon.Info
                    );
            }
        }
        /// <summary>
        /// Функция для анализа базы данных на различные значения
        /// </summary>
        /// <param name="startAnalysBool"></param>
        /// <param name="servName"></param>
        /// <param name="DBName"></param>
        /// <param name="modelName"></param>
        /// <param name="prevID"></param>
        /// <param name="maxID"></param>
        public void AnalysProcess(bool startAnalysBool, string servName, string DBName, string modelName, int prevID, int maxID)
        {
            while (startAnalysBool == true)
            {
                //создаем новый процесс
                var psi = new ProcessStartInfo();
                //устанавливаем путь до exe питона
                psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";
                //путь до исполняемого скрипта
                var script7 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\findMaxID.py";
                var script8 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\analys.py";

                var results = "";

                psi.Arguments = string.Format("{0} {1} {2}", script7, servName, DBName);

                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;

                //снова ищем максимальный ID
                using (var process2 = Process.Start(psi))
                {
                    // на чтении эрроров программа завистает, так как однопоточная
                    //errors = process.StandardError.ReadToEnd();
                    results = process2.StandardOutput.ReadToEnd();
                }

                maxID = Convert.ToInt32(results);
                
                //servName = servNameLabel.Text;
                //DBName = DBNameLabel.Text;

                //аргументы в питон скрипт
                psi.Arguments = string.Format("{0} {1} {2} {3} {4} {5}", script8, servName, DBName, modelName, maxID, prevID);

                //разные необхожимые настройки
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;

                var results2 = "";

                //var errors = "";
                //var resultsPSII = "";
                // процесс как раз на анализ данных в БД
                using (var process3 = Process.Start(psi))
                {
                    // на чтении эрроров программа завистает, так как однопоточная
                    //errors = process.StandardError.ReadToEnd();
                    results2 = process3.StandardOutput.ReadToEnd();
                    process3.WaitForExit();
                }

                //приравниваем предыдущий айдишник максимальному
                prevID = maxID;
                //ждем 10 секунд
                Thread.Sleep(10000);
                if (this.startAnalysBool == false)
                {
                    to.Abort();
                    break;
                }
                  
            }
        }


        /// <summary>
        /// Обработка нажатия на кнопку "Начать анализ"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartAnalysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servName = servNameLabel.Text;
            DBName = DBNameLabel.Text;
            modelName = modelNameLabel.Text;

            //создаем новый процесс
            var psi = new ProcessStartInfo();
            //устанавливаем путь до exe питона
            psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";
            //путь до исполняемого скрипта

            var script7 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\findMaxID.py";

            //аргументы в питон скрипт
            psi.Arguments = string.Format("{0} {1} {2}", script7, servName, DBName);

            //разные необхожимые настройки
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            //var errors = "";
            var results = "";


            // процесс как раз
            using (var process = Process.Start(psi))
            {
                // на чтении эрроров программа завистает, так как однопоточная
                //errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            maxID = Convert.ToInt32(results);
            prevID = maxID;

            if (results.Length > 0)
            {
                DialogResult startAnalys = MessageBox.Show(
                    "Начат анализ данных",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (startAnalys == DialogResult.OK)
                {
                    //сворачиваем окошко
                    this.WindowState = FormWindowState.Minimized;

                    // убираем окошко из панели задач
                    this.ShowInTaskbar = false;

                    // добавляем значок в трею
                    notifyIcon1.Visible = true;

                    //запускаем анализ файлов
                    startAnalysBool = true;

                    notifyIcon1.ShowBalloonTip(
                       10000,
                       "Система поиска аномалий",
                       "Система поиска аномалий запущена. Ведется анализ данных.",
                       ToolTipIcon.Info
                       );

                    //Thread t = new Thread(() => AnalysProcess(startAnalysBool, servName, DBName,modelName, prevID, maxID));
                    //t.Start();
                    //to = new Thread(() => AnalysProcess(startAnalysBool, servName, DBName, prevID, maxID));
                    //to.Start();
                    to.Start();

                    Thread.Sleep(10000);
                    //t.Abort();

                   // t.Join();
                }
            }
            else
            {
                DialogResult startAnalys = MessageBox.Show(
                   "Ошибка, анализ данных не был начат",
                   "Внимание",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }
                
            
        }

        /// <summary>
        /// Обработчик кнопки остановки анализа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void остановитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //убиваем процесс
            //to.Abort();
            //to.Join();
            DialogResult stopAnalys = MessageBox.Show(
                "Анализ данных остановлен",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (stopAnalys == DialogResult.OK)
            {
                startAnalysBool = false;
                AnalysProcess(startAnalysBool, servName, DBName, modelName, prevID, maxID);
                this.Activate();
            }
        }
        /// <summary>
        /// Обработчик нажатия на кнопку "Параметры БД"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBConnParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBParams.StartPosition = FormStartPosition.CenterParent;
            //это необходимо для изменения доступности компонентов меню ModelToolStripMenuItem.Enabled
            DBParams.Owner = this;
            DBParams.ShowDialog();
        }

    }
}
