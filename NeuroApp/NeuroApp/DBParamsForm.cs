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
    public partial class DBParamsForm : Form
    {
        

        public DBParamsForm()
        {
            InitializeComponent();
        }


        // название сервера
        string serverName;

        // имя базы данных
        string DBName;


        private void DBParamsForm_Load(object sender, EventArgs e)
        {
            DBParamsServNameComboBox.Text = serverName;
            DBParamsDBNameComboBox.Text = DBName;
        }

        /// <summary>
        /// Кнопка сохранения, которую я удалил за ненадобностью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBParamsSaveButton_Click(object sender, EventArgs e)
        {

        }

        //Form1 frm1 = new Form1();

        private void DBParamsConnButton_Click(object sender, EventArgs e)
        {
            // для того, чтобы отсюда обратиться к главной форме
            Form1 main = this.Owner as Form1;

            serverName = DBParamsServNameComboBox.Text;
            DBName = DBParamsDBNameComboBox.Text;

            

            //создаем новый процесс
            var psi = new ProcessStartInfo();
            //устанавливаем путь до exe питона
            psi.FileName = @"C:\Users\Alex\PycharmProjects\kerasNeuralTest\venv\Scripts\python.exe";

            //путь до исполняемого скрипта

            var script3 = @"C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\DBTest.py";

            //аргументы в питон скрипт
            psi.Arguments = string.Format("{0} {1} {2}", script3, serverName, DBName);

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
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            //MessageBox.Show(results);
            // если длина ошибки больше нуля (то есть ошибка присутствует)
            if (errors.Length > 0)
            {
                // показываем окно об ошибке
                DialogResult ErrorsResults = MessageBox.Show(
                errors,
                "Ошибка подключения",
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

            //если длина результатов больше нуля (там мы получаем максимальный ID из одной таблицы
            //так что при удачном подключении он будет больше нуля) то показываем окно об успешном подключении
            if (results.Length > 0)
            {
                DialogResult OkResults = MessageBox.Show(
                "Подключение к базе данных успешно",
                "Подключение к базе данных",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                //делаем пункт меню модель доступным

                (this.Owner as Form1).ModelToolStripMenuItem.Enabled = true;

                //Назначаем имя сервера лейблу
                main.servNameLabel.Text = serverName;
                //Назначаем имя БД лейблу
                main.DBNameLabel.Text = DBName;


                if (OkResults == DialogResult.OK)
                {
                    //frm1.label1.Text = SrvName;
                    Close();
                    this.Activate();
                }
            }
        }

        public string SrvName
        {
            get { return serverName; }
            //set { DBParamsServNameComboBox.Text = value; }
        }


    }
}
