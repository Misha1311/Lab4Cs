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

        public int n, m;

        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }

        Triangle[] tring;
        RightTriangle[] all;
        double avgsqure = 0;
        double min = 0;
        double max = 0;
        int count;


        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public void save_Click(object sender, EventArgs e)
        {
            //метод вызывает окно диалога 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //получаем имя выбранный файл также получаем путь
                string filename = saveFileDialog1.FileName;
                //файловый поток
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                //бинарный записователь 
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

                bw.Write(N);
                bw.Write(M);

                for (int i = 0; i < N; i++)
                {
                    tring[i].Write(bw);
                }
                for (int i = 0; i < M; i++)
                {
                    all[i].Write(bw);
                }

                bw.Close();
                fs.Close();
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
                //файловый поток
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                //бинарный  считователь
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

                int numN = br.ReadInt32();
                N = numN;
                int numM = br.ReadInt32();
                M = numM;
                //инициализируем массив кол-вом значенний 
                tring = new Triangle[numN];
                all = new RightTriangle[numM];

                for (int i = 0; i < numN; i++)
                {
                    //Считываем значения с файла
                    tring[i] = new Triangle();
                    tring[i] = tring[i].Read(br);
                }
                for (int i = 0; i < numM; i++)
                {
                    all[i] = new RightTriangle();
                    all[i] = all[i].Read(br);
                }

                calculate();
                Out();
                br.Close();
                fs.Close();

                MessageBox.Show("Файл открыт");
            }
        }


        public void Start1_Click(object sender, EventArgs e)
        {
            calca();
        }

        private void calca()
        {
            info.Text = "";
            excp.Text = "";

            try
            {
                N = Convert.ToInt32(OupN.Text);
                M = Convert.ToInt32(OupM.Text);

                tring = new Triangle[N];

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
                }

                all = new RightTriangle[M];

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

                calculate();
                Out();
            }
            catch (Exception exc)
            {
                excp.Text = "Не верный формат!\nВведите число!";
            }

        }

        private void calculate()
        {
            for (int i = 0; i < N; i++)
            {
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


            count = 0;
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
        }

        private void Out()
        {
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
    }
}
