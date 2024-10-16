using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks; // для задержки в миллисекундах
using System.Windows.Forms;

namespace ParallProcessDemo
{    
    public partial class Form1 : Form
    {
        Task[] tasks = new Task[3]; // Массив задач        
        Label currentLable; // Перменная для хранения текущего поля вывода
        // Сущность для передачи сообщения об отмене, Класс для работы с процессом
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        // Токен - это устр-во (программный код) для авторизации            
        static CancellationToken token = cancellationTokenSource.Token; 
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void btnCownDown_Click(object sender, EventArgs e)
        {
            int num = 0;
            Task taskTmp; // Временный эл. для хранения задания
            if (currentLable == null)
            {
                currentLable = lbCountDown001;                
            }
            else
            {
                if (currentLable == lbCountDown001)
                {
                    currentLable = lBCountDown002;
                    num = 1;
                }
                else
                    if (currentLable == lBCountDown002)
                    {
                        currentLable = lbCountDown003;
                        num = 2;
                    }
                    else
                    {
                        currentLable = lbCountDown001;
                        num = 0;
                    }
            }
            if (tasks[num] != null)
            {
                taskTmp = tasks[num];
                taskClose();
                //tasks[num] = CountDown003(currentLable);
                //taskTmp.Dispose(); // Завершает задачу, не разрушая данные
            }            
            tasks[num] = CountDown003(currentLable);
            tasks[num].Start();
            //CountDown001(currentLable);
            //CountDown002(currentLable);            
        }
        private void CountDown001(Label _label)
        {
            int _start = 10;
            // Таймер для изменения события (указываем конкретно, с какого пространства имён timer)
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true; // Активируем таймер
            timer.Interval = 100; // Интервал 0,1 сек
            timer.Tick += (object _sender, EventArgs _e) => // сигнатура с лямбда-выражением (ф.без имени)
            {
                if (_start == 0)
                {
                    timer.Enabled = false; // Деактивируем таймер
                }
               _label.Text = _start.ToString();
                Thread.Sleep(900); // Закрытие потока программы на время в миллисекундах
                _start--;
            };
        }
        private void CountDown002(Label _label) // Три потока будут работать параллельно
        {
            int _start = 30;
            // Создаём задание () - не принимает аргументы, {} - что-то делает
            Task task = new Task(() => 
            {
                while (_start > 0)
                {
                    _label.Text = _start.ToString();
                    Thread.Sleep(1000); // Закрытие потока программы на время в миллисекундах
                    _start--;
                }
            } );
            task.Start(); // Запускаем экземпляр класса task
        }

        private Task CountDown003(Label _label) // Три потока будут работать параллельно
        {               
            // Создаём задание () - не принимает аргументы, {} - что-то делает
            var task = Task.Run(() => taskCountDown(_label, token)); // Токен передаём в конструктор задачи
            return task;
        }

        private void taskClose(Task task)
        {
            
            cancellationTokenSource.Cancel();
        }

        private Task taskCountDown(Label _label, CancellationToken token)
        {
            int _start = 30;            
            // Создаём задание () - не принимает аргументы, {} - что-то делает
            Task task = new Task(() =>
            {
                while (_start > 0)
                {
                    if (token.IsCancellationRequested) // Если поступил запрос на завершение процесса
                    {
                        // MessageBox.Show($"Процесс для {_label.Name} завершён {DateTime.Now}!");
                        tbInfo.Text = $"Процесс для {_label.Name} завершён {DateTime.Now}!";
                        return;
                    }
                    _label.Text = _start.ToString();
                    Thread.Sleep(1000); // Закрытие потока программы на время в миллисекундах
                    _start--;
                }
            }, token); // Токен передаём в конструктор задачи
            return task;
        }

        private void btnGetStatuses_Click(object sender, EventArgs e)
        {
            if (tasks[0] != null) lbStatusTask001.Text = tasks[0].Status.ToString();
            if (tasks[1] != null) lbStatusTask002.Text = tasks[1].Status.ToString();
            if (tasks[2] != null) lbStatusTask003.Text = tasks[2].Status.ToString();
        }
    }
}
