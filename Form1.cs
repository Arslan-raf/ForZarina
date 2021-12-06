using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Рафиков_СРВ
{
    public partial class Form1 : Form
    {

        int minute, second;
        int minute2, second2;
        int active;

        public Form1()
        {
            InitializeComponent();
          
            timer1.Interval = 500;
            minute = 0;
            second = 0;
          //  second_label.Text = "00";
            //minute_label.Text = "00";
            timer2.Enabled = true;

            active = 0;
            Random r = new Random();
            int[] kek = new int[11];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void algorithm_label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void result_button_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            textBox2.Enabled = true;
            label23.Enabled = true;
            label24.Enabled = true;
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

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void calculation_Click(object sender, EventArgs e)
        {
            double total1_1;
            double total2_2;
            double total3_3;
            double total4_4;
            double expenses1;

            double cost1_1 = Convert.ToDouble(cost1.Text);
            double cost2_2 = Convert.ToDouble(cost2.Text);
            double cost3_3 = Convert.ToDouble(cost3.Text);
            double cost4_4 = Convert.ToDouble(cost4.Text);

            double quantity_PC = Convert.ToDouble(quantity_textBox1.Text);
            double quantity_server = Convert.ToDouble(quantity_textBox2.Text);
            double quantity_network = Convert.ToDouble(quantity_textBox3.Text);
            double quantity_fw = Convert.ToDouble(quantity_textBox4.Text);

            total1_1 = cost1_1 * quantity_PC;
            total2_2 = cost2_2 * quantity_server;
            total3_3 = cost3_3 * quantity_network;
            total4_4 = cost4_4 * quantity_fw;

            total1.Text = Convert.ToString(total1_1);
            total2.Text = Convert.ToString(total2_2);
            total3.Text = Convert.ToString(total3_3);
            total4.Text = Convert.ToString(total4_4);
            expenses1 = total1_1 + total2_2 + total3_3 + total4_4;
            expenses.Text = Convert.ToString(expenses1);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;
            minute2 = 0;
            second2 = 0;
            minute_label.Text = "00";
            second_label.Text = "00";


            timer1.Start();
            algorithm_label2.Text = "Уровень угрозы 1. Попробуйте проделать следующий алгоритм: \n";
            algorithm_label2.Text += "1)сделать что-то что-то 1 \n";
            algorithm_label2.Text += "2)сделать то  1 \n";
            algorithm_label2.Text += "3)сделать сё  1 \n";

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
           

            result_button.Enabled = true;
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minute < 3)
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
                    second_label.Text = "00";

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
                MessageBox.Show("Время закончилось",  "Сообщение");

            }
        }

        private void go_over_button_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2 /*needed tab*/;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                date_time.Text = DateTime.Now.ToString();

                if (timer2.Enabled)
                {
                    if (second2 < 59)
                    {
                        second2++;
                        if (second2 == 30)
                        {
                            active = 0;
                            Random r = new Random();
                            //int kek = r.Next(2);
                            int[] kek = new int[11];
                            for (int i = 0; i < kek.Length; i++)
                            {
                                kek[i] = r.Next(2);

                            }

                            if (kek[0] == 1)
                            {
                                pk_textBox1.ForeColor = Color.Red;

                            }
                            else pk_textBox1.ForeColor = Color.ForestGreen;

                            if (kek[1] == 1)
                            {
                                pk_textBox2.ForeColor = Color.Red;

                            }
                            else pk_textBox2.ForeColor = Color.ForestGreen;
                            if (kek[2] == 1)
                            {
                                pk_textBox3.ForeColor = Color.Red;

                            }
                            else pk_textBox3.ForeColor = Color.ForestGreen;
                            if (kek[3] == 1)
                            {
                                pk_textBox4.ForeColor = Color.Red;

                            }
                            else pk_textBox4.ForeColor = Color.ForestGreen;
                            if (kek[4] == 1)
                            {
                                pk_textBox5.ForeColor = Color.Red;

                            }
                            else pk_textBox5.ForeColor = Color.ForestGreen;
                            if (kek[5] == 1)
                            {
                                server_textBox1.ForeColor = Color.Red;

                            }
                            else server_textBox1.ForeColor = Color.ForestGreen;

                            if (kek[6] == 1)
                            {
                                server_textBox2.ForeColor = Color.Red;

                            }
                            else server_textBox2.ForeColor = Color.ForestGreen;

                            if (kek[7] == 1)
                            {
                                network_devices_textBox1.ForeColor = Color.Red;

                            }
                            else network_devices_textBox1.ForeColor = Color.ForestGreen;
                            if (kek[8] == 1)
                            {
                                network_devices_textBox2.ForeColor = Color.Red;

                            }
                            else network_devices_textBox2.ForeColor = Color.ForestGreen;


                            if (kek[9] == 1)
                            {
                                firewall_textBox1.ForeColor = Color.Red;

                            }
                            else firewall_textBox1.ForeColor = Color.ForestGreen;

                            if (kek[10] == 1)
                            {
                                firewall_textBox2.ForeColor = Color.Red;

                            }
                            else firewall_textBox2.ForeColor = Color.ForestGreen;

                            if (pk_textBox1.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (pk_textBox2.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (pk_textBox3.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (pk_textBox4.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (pk_textBox5.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }



                            if (server_textBox1.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (server_textBox2.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (network_devices_textBox1.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (network_devices_textBox2.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }
                            if (firewall_textBox1.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }

                            if (firewall_textBox2.ForeColor == Color.ForestGreen)
                            {
                                active++;
                            }



                            active_textBox.Text = Convert.ToString(active);
                            active_textBox2.Text = Convert.ToString(11 - active);
                             label2.Visible = true;
                            go_over_button.Visible = true;

                        }
                    }
                    else
                    {
                        minute2++;
                        second2 = 0;
                    }
                }

            
        }
    }
}
