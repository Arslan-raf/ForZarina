using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace программка_по_ИБ
{
    public partial class Form1 : Form
    {

        int minute, second;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            minute = 0;
            second = 0;
            second_label.Text = "00";
            minute_label.Text = "00";
            


        }

        private void Start_button_Click(object sender, EventArgs e)
        {

            task_label.Text = "Произошел киберинцидент! Срочно решите проблему!";

            minute = 0;
            second = 0;
            minute_label.Text = "00";
            second_label.Text = "00";
            
            timer1.Start();

            if (timer1.Enabled)
            {

                go_button.Enabled = true;
                stop_button.Enabled = true;

            }
            Start_button.Enabled = false;

        }


        private void stop_button_Click(object sender, EventArgs e)
        {

            label1.Enabled = true;
            label3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            label4.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;

            result_button.Enabled = true;
            timer1.Stop();
            

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_button_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            textBox2.Enabled = true;
            solution_label.Enabled = true;
            textBox1.Enabled = true;
            Start_button.Enabled = true;

            if (radioButton1.Checked)
            {
                textBox2.Text = "Статья 272. Неправомерный доступ к компьютерной информации";
                textBox1.Text = "Штраф в размере до двухсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев, либо исправительные работы на срок до одного года, либо ограничение свободы на срок до двух лет, либо принудительные работы на срок до двух лет, либо лишение свободы на тот же срок";
            }

            if (radioButton2.Checked)
            {
                textBox2.Text = "Статья 273. Создание, использование и распространение вредоносных компьютерных программ";
                textBox1.Text = "Ограничение свободы на срок до четырех лет, либо принудительные работы на срок до четырех лет, либо лишение свободы на тот же срок со штрафом в размере до двухсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев";
            }




        }




        //обработчик таймера (timer1)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minute<3)
            {
                if (second < 59)
                {
                    second++;
                    if (second < 10) { second_label.Text = "0" + second.ToString(); }
                    else { second_label.Text = second.ToString(); }
                }

                else
                {

                        minute++;
                        minute_label.Text = "0" + minute.ToString();
                    second = 0;
                    second_label.Text = "00" ;

                    if (minute == 1)
                        {

                            algorithm_label2.Text = "Вы не успели решить пролему за минуту. Угроза переходит на 2 уровень \n";
                        algorithm_label2.Text += "1)сделать что-то что-то \n";
                        algorithm_label2.Text += "2)сделать то \n";
                        algorithm_label2.Text += "3)сделать сё \n";

                    }

                        if (minute == 2)
                        {

                            algorithm_label2.Text = "Вы не успели решить пролему за 2 минуту. Угроза переходит на 3 уровень \n";
                        algorithm_label2.Text += "1) попробуй  \n";
                        algorithm_label2.Text += "2) давай  \n";
                        algorithm_label2.Text += "3) ну же \n";


                    }
                }


            }
            else
            {
                timer1.Stop();
                MessageBox.Show("время закончилось");
                
            }
        }


    }
}
