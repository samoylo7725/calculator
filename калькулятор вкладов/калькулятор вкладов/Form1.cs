using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_вкладов
{
     public partial class Form1 : Form
    {
        public static class Globals //создаётся общий класс к которому будут присвоены переменные//
        {
            public static int sum=100000,bank=0,srok=0,ttype=0,sbertype=0,sberpodtype=0;//используемые глобалные переменные//
        }
        public Form1()//создание формы//
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)//проверка на изменение элемента выбора//
        {
            //выбор банка с появлением зависимых элементов//
            if (checkedListBox1.SelectedIndex == 0)
            {
                checkedListBox3.Visible = false;//изменение не видимости зависимого элемента//
                checkedListBox2.Visible = true; //изменение видимости зависимого элемента//
                Globals.bank = 0;//изменение глобальной переменной//
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                checkedListBox5.Visible = false;//изменение не видимости зависимого элемента//
                checkedListBox3.Visible = true; //изменение видимости зависимого элемента//
                checkedListBox2.Visible = false;//изменение не видимости зависимого элемента//
                Globals.bank = 1;//изменение глобальной переменной//
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)//проверка на изменение элемента выбора//
        {
            //выбор типа вклада//
            checkedListBox4.Visible = true;
            
            if (checkedListBox2.SelectedIndex == 0)
            {
                checkedListBox5.Visible = true;
                Globals.sbertype = 0;
            }
            else if (checkedListBox2.SelectedIndex == 1)
            {
                checkedListBox5.Visible =false;
                Globals.sbertype = 1;
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)//проверка на изменение элемента выбора//
        {
            //выбор типа вклада//
            checkedListBox4.Visible = true;
            if (checkedListBox3.SelectedIndex == 0)
            {
                checkedListBox5.Visible = false;
                Globals.ttype = 2;
            }
            else if (checkedListBox3.SelectedIndex == 1)
            {
                checkedListBox5.Visible = false;
                Globals.ttype = 3;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Globals.sum = Convert.ToInt32(textBox1.Text);//присваивание переменной суммы//
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)//проверка на изменение элемента выбора//
        {
            //выбор срока вклада//
            if (checkedListBox4.SelectedIndex == 0)//3 месяца//
            {
                Globals.srok = 0;
            }
            else if (checkedListBox4.SelectedIndex == 1)//6 месяцев//
            {
                Globals.srok = 1;
            }
            else if (checkedListBox4.SelectedIndex == 2)//12 месяцев//
            {
                Globals.srok = 2;
            }
        }
        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)//проверка на изменение элемента выбора//
        {
            //выбор подтипа вклада сбербанка//
            if (checkedListBox4.SelectedIndex == 0)
            {
                Globals.sberpodtype = 0;
            }
            else if (checkedListBox4.SelectedIndex == 1)
            {
                Globals.sberpodtype = 1;
            }
            else if (checkedListBox4.SelectedIndex == 2)
            {
                Globals.sberpodtype = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)//нажате кнопки активирует пересчёт//
        {
            //глобальная проверка//
            if (Globals.bank == 0)//банк//
            {
                if (Globals.sbertype == 0)//тип вклада//
                {
                    if (Globals.srok == 0)//срок вклада//
                    {
                        if (Globals.sberpodtype == 0)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 4), 1));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 1)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 4), 1));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 2)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 4), 1));//общий расчёт с округлением до сотых//
                        }

                    }
                    else if (Globals.srok == 1)//срок вклада//
                    {
                        if (Globals.sberpodtype == 0)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 2), 2));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 1)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 2), 2));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 2)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 / 2), 2));//общий расчёт с округлением до сотых//
                        }
                        
                    }
                    else if (Globals.srok == 2)//срок вклада//
                    {
                        if (Globals.sberpodtype == 0)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 ), 2));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 1)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 ), 2));//общий расчёт с округлением до сотых//
                        }
                        else if (Globals.sberpodtype == 2)//подтип вклада//
                        {
                            label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.155 ), 2));//общий расчёт с округлением до сотых//
                        }

                    }
                }
                else if (Globals.sbertype == 1)//тип вклада//
                {
                    if (Globals.srok == 0)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.19 / 4), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 1)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.19 / 2), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 2)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.19 ), 2));//общий расчёт с округлением до сотых//
                    }
                }
            }
            else if (Globals.bank == 1)//банк//
            {
                if (Globals.ttype == 2)//тип вклада//
                {
                    if (Globals.srok == 0)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.1724 / 4), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 1)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.1761 / 2), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 2)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.138), 2));//общий расчёт с округлением до сотых//
                    }
             
                }
                else if (Globals.ttype == 3)//тип вклада//
                {
                    if (Globals.srok == 0)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.193 / 4), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 1)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.1922 / 2), 2));//общий расчёт с округлением до сотых//
                    }
                    else if (Globals.srok == 2)//срок вклада//
                    {
                        label1.Text = Convert.ToString(Math.Round(Globals.sum * (1 + 0.1838), 2));//общий расчёт с округлением до сотых//
                    }
                    
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(0);//стирание итога//
        }

        private void button3_Click(object sender, EventArgs e)//информационная кнопка//
        {
            if (label2.Visible == false)
            {
                label2.Visible = true;//появлене информации//
            }
            else
            {
                label2.Visible = false;
            }
        }

        
    }
}
