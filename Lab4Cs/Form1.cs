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

namespace Lab4Cs
{
    public partial class Form1 : Form
    {

        int n, m;

        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }


        public Form1()
        {
            InitializeComponent();


            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void save_Click(object sender, EventArgs e)
        {
            //метод вызывает окно диалога 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                File.WriteAllText(filename, info.Text);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            //метод вызывает окно диалога 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = File.ReadAllText(filename);
                info.Text = fileText;
                MessageBox.Show("Файл открыт");
            }
        }

        public void Start1_Click(object sender, EventArgs e)
        {
            info.Text = "";
            excp.Text = "";

            try
            {
                N = Convert.ToInt32(OupN.Text);
                M = Convert.ToInt32(OupM.Text);

                double avgsqure = 0;
                double min = 0;

                Triangle[] tring = new Triangle[N];

                for (int i = 0; i < N; i++)
                {
                    do
                    {
                        tring[i] = new Triangle();
                        tring[i].Lenght();
                        tring[i].IsExists();
                        if (tring[i].exist == true)
                        {
                            tring[i].Angle();
                            tring[i].Perimetr();
                            tring[i].Square();
                        }
                    } while (tring[i].exist == false);

                    min = tring[0].perimetr;
                    avgsqure += tring[i].square;
                }
                avgsqure /= N;


                for (int i = 0; i < N; i++)
                {
                    if (tring[i].perimetr < min)
                    {
                        min = tring[i].perimetr;
                    }
                }

                double max = 0;
                RightTriangle[] all = new RightTriangle[M];

                for (int i = 0; i < M; i++)
                {
                    do
                    {
                        all[i] = new RightTriangle();
                        all[i].Lenght();
                        all[i].IsExists();
                        if (all[i].exist)
                        {
                            if (all[i].isRight())
                            {
                                all[i].Angle();
                                all[i].Perimetr();
                                all[i].Square();
                            }
                        }
                    } while (!all[i].isRight() || !all[i].exist);
                }


                int count = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (all[i].lenght[j] > max)
                        {
                            max = all[i].lenght[j];
                            count = i + 1;
                        }
                    }
                }
             
                for (int i = 0; i < N; i++)
                {
                    info.Text += $"Треугольник #{i + 1}\n";
                    info.Text += tring[i].PrintData();
                }

                for (int i = 0; i < M; i++)
                {
                    info.Text += $"Прямоугольный треугольник #{i + 1}\n";
                    info.Text += all[i].PrintData();
                }
                info.Text += "Cредняя площадь  = ";
                info.Text += avgsqure.ToString("n1");
                info.Text += "\nМинимальный периметр  = ";
                info.Text += min.ToString("n1");
                info.Text += "\nПрямоуголный треугольник с наибольшей гипотенузой под номером ";
                info.Text += count.ToString("n0");

            }
            catch (Exception exc)
            {
                excp.Text = "Неверно заданый формат.\nВведите число.";
            }
        }
    }
}
