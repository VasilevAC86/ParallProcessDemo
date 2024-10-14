using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks; // для задержки в миллисекундах
using System.Windows.Forms;

namespace ParallProcessDemo
{
    public partial class Form1 : Form
    {
        // Перменная для хранения текущего поля вывода
        Label currentLable;
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void btnCownDown_Click(object sender, EventArgs e)
        {
            if (currentLable == null)
            {
                currentLable = lbCountDown001;
            }
            else
            {
                if (currentLable == lbCountDown001)                
                    currentLable = lBCountDown002;                
                else
                    if (currentLable == lBCountDown002)
                        currentLable = lbCountDown003;                
                    else
                        currentLable = lbCountDown001;
            }
            //CountDown001(currentLable);
            CountDown002(currentLable);
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
    }
}
