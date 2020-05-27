using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int rowHeight = 22;
        int colWidth = 44;

        string p1 = "";//переменная 1
        string p2 = "";//переменная 2
        public static bool flag = false;//+-*/
        char ch;
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 270;
            this.Height = 420;
        }

        private void calc_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calc_tab.TabIndex == 1)
            {
                this.Width = 530;
                this.Height = 430;
                calc_tab.TabIndex = 0;
            }

            else
            {
                this.Width = 270;
                this.Height = 420;
                calc_tab.TabIndex = 1;
            }
        }

        private void matrix_calc_Click(object sender, EventArgs e)
        {

        }

        //строки матрицы А
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            //очистка матриц
            this.dataGridView1.Rows.Clear();
            this.dataGridView3.Rows.Clear();

            //видимость матриц

            this.dataGridView1.Visible = true;
            this.dataGridView3.Visible = false;


            //задаем кол-во столбцов
            this.dataGridView1.ColumnCount = comboBox4.SelectedIndex+2;
            //this.dataGridView3.ColumnCount = comboBox2.SelectedIndex + 2;

            //добавляем строки
            for (int i=0; i< comboBox1.SelectedIndex + 2; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView3.Rows.Add();
            }

            //устанавливаем размеры строк
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = colWidth;
                

                dataGridView1.Width = colWidth * this.dataGridView1.ColumnCount;
                

                dataGridView1.Height = rowHeight * this.dataGridView1.RowCount;

            }
        }

        //Столбцы матрицы А
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            //очистка матриц
            this.dataGridView1.Rows.Clear();
            this.dataGridView3.Rows.Clear();

            //видимость матриц

            this.dataGridView1.Visible = true;
            this.dataGridView3.Visible = false;


            //задаем кол-во столбцов
            this.dataGridView1.ColumnCount = comboBox4.SelectedIndex + 2;
            //this.dataGridView3.ColumnCount = comboBox2.SelectedIndex + 2;

            //добавляем строки
            for (int i = 0; i < comboBox1.SelectedIndex + 2; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView3.Rows.Add();
            }

            //устанавливаем размеры строк
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = colWidth;


                dataGridView1.Width = colWidth * this.dataGridView1.ColumnCount;


                dataGridView1.Height = rowHeight * this.dataGridView1.RowCount;

            }
        }

        //Строки матрицы B
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            //очистка матриц
            this.dataGridView2.Rows.Clear();
            this.dataGridView3.Rows.Clear();

            //видимость матриц

            this.dataGridView2.Visible = true;
            this.dataGridView3.Visible = false;



            //задаем кол-во столбцов
            this.dataGridView2.ColumnCount = comboBox5.SelectedIndex + 2;
            //this.dataGridView3.ColumnCount = comboBox2.SelectedIndex + 2;

            //добавляем строки
            for (int i = 0; i < comboBox3.SelectedIndex + 2; i++)
            {
                this.dataGridView2.Rows.Add();
            }

            //устанавливаем размеры строк
            for (int i = 0; i < this.dataGridView2.ColumnCount; i++)
            {
                dataGridView2.Columns[i].Width = colWidth;


                dataGridView2.Width = colWidth * this.dataGridView2.ColumnCount;


                dataGridView2.Height = rowHeight * this.dataGridView2.RowCount;

            }
        }

        //Столбцы матрицы В
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            //очистка матриц
            this.dataGridView2.Rows.Clear();
            

            //видимость матриц

            this.dataGridView2.Visible = true;
            this.dataGridView3.Visible = false;



            //задаем кол-во столбцов
            this.dataGridView2.ColumnCount = comboBox5.SelectedIndex + 2;
            //this.dataGridView3.ColumnCount = comboBox2.SelectedIndex + 2;

            //добавляем строки
            for (int i = 0; i < comboBox3.SelectedIndex + 2; i++)
            {
                this.dataGridView2.Rows.Add();
            }

            //устанавливаем размеры строк
            for (int i = 0; i < this.dataGridView2.ColumnCount; i++)
            {
                dataGridView2.Columns[i].Width = colWidth;


                dataGridView2.Width = colWidth * this.dataGridView2.ColumnCount;


                dataGridView2.Height = rowHeight * this.dataGridView2.RowCount;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex<3)
            {
                label3.Visible = false;
                label5.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = false;

            }
            else
            {
                dataGridView2.Visible = false;
                label3.Visible = true;
                label5.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //очистка матриц
            this.dataGridView1.Rows.Clear();
            this.dataGridView2.Rows.Clear();
            this.dataGridView3.Rows.Clear();
            dataGridView3.Visible = false;

            //задаем кол-во столбцов
            this.dataGridView1.ColumnCount = comboBox4.SelectedIndex + 2;
            this.dataGridView2.ColumnCount = comboBox5.SelectedIndex + 2;

            //добавляем строки
            for (int i = 0; i < comboBox1.SelectedIndex + 2; i++)
            {
                this.dataGridView1.Rows.Add();
            }

            for (int i = 0; i < comboBox3.SelectedIndex + 2; i++)
            {
                this.dataGridView2.Rows.Add();
            }

            textBox1.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Rows.Clear();
            this.dataGridView3.ColumnCount = dataGridView2.ColumnCount;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                this.dataGridView3.Rows.Add();
            }

            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                dataGridView3.Columns[i].Width = colWidth;

                dataGridView3.Width = colWidth * this.dataGridView2.ColumnCount;

                dataGridView3.Height = rowHeight * this.dataGridView1.RowCount;
            }

            dataGridView3.Visible = true;
            //умножение матриц
            if (comboBox2.SelectedIndex == 0)
            {
                if (dataGridView1.ColumnCount != dataGridView2.RowCount)
                {
                    this.warning_label.Visible = true;
                }
                else
                {
                    warning_label.Visible = false;
                    int m = dataGridView1.RowCount;
                    int q = dataGridView2.ColumnCount;
                    int n = dataGridView2.RowCount;
                    dataGridView3.Visible = true;
                    int value;
                    for (int i = 0; i < m; i++)
                    for (int j = 0; j < q; j++)
                    {
                        dataGridView3[j, i].Value = 0;
                        for (int k = 0; k < n; k++)
                        {
                            value = Convert.ToInt32(dataGridView3[j, i].Value);
                            value += Convert.ToInt32(dataGridView1[k, i].Value) *
                                     Convert.ToInt32(dataGridView2[j, k].Value);
                            dataGridView3[j, i].Value = value;
                        }
                    }
                }
            }

            //умножение матрицы на число
            if (comboBox2.SelectedIndex == 5)
            {
                warning_label.Visible = false;
                int m = dataGridView1.RowCount;
                int q = dataGridView1.ColumnCount;
                dataGridView3.Visible = true;
                double value;
                for (int i = 0; i < m; i++)
                for (int j = 0; j < q; j++)
                {
                    value = Convert.ToInt32(dataGridView1[j, i].Value);
                    value *= Convert.ToDouble(textBox1.Text);
                    dataGridView3[j, i].Value = value;
                }
            }

            //деление матрицы на число
            if (comboBox2.SelectedIndex == 6)
            {
                warning_label.Visible = false;
                int m = dataGridView1.RowCount;
                int q = dataGridView1.ColumnCount;
                dataGridView3.Visible = true;
                double value;
                for (int i = 0; i < m; i++)
                for (int j = 0; j < q; j++)
                {
                    value = Convert.ToInt32(dataGridView1[j, i].Value);
                    value /= Convert.ToInt32(textBox1.Text);
                    dataGridView3[j, i].Value = value;
                }
            }

            if (comboBox2.SelectedIndex == 1)
            {
                if (dataGridView1.ColumnCount != dataGridView2.RowCount)
                {
                    this.warning_label.Visible = true;
                    dataGridView3.Visible = false;
                }
                else
                {
                    warning_label.Visible = false;
                    int m = dataGridView1.RowCount;
                    int q = dataGridView1.ColumnCount;
                    dataGridView3.Visible = true;
                    double value;
                    for (int i = 0; i < m; i++)
                    for (int j = 0; j < q; j++)
                    {
                        value = Convert.ToDouble(dataGridView1[j, i].Value);
                        value += Convert.ToDouble(dataGridView2[j, i].Value);
                        dataGridView3[j, i].Value = value;
                    }
                }
            }

            if (comboBox2.SelectedIndex == 2)
            {
                if (dataGridView1.ColumnCount != dataGridView2.RowCount)
                {
                    this.warning_label.Visible = true;
                    dataGridView3.Visible = false;
                }
                else
                {
                    warning_label.Visible = false;
                    int m = dataGridView1.RowCount;
                    int q = dataGridView1.ColumnCount;
                    dataGridView3.Visible = true;
                    double value;
                    for (int i = 0; i < m; i++)
                    for (int j = 0; j < q; j++)
                    {
                        value = Convert.ToDouble(dataGridView1[j, i].Value);
                        value -= Convert.ToDouble(dataGridView2[j, i].Value);
                        dataGridView3[j, i].Value = value;
                    }
                }
            }

            //сложение матрицы с числом
            if (comboBox2.SelectedIndex == 3)
            {
                warning_label.Visible = false;
                int m = dataGridView1.RowCount;
                int q = dataGridView1.ColumnCount;
                dataGridView3.Visible = true;
                double value;
                for (int i = 0; i < m; i++)
                for (int j = 0; j < q; j++)
                {
                    value = Convert.ToInt32(dataGridView1[j, i].Value);
                    value += Convert.ToDouble(textBox1.Text);
                    dataGridView3[j, i].Value = value;
                }
            }

            //вычитание из матрицы числа
            if (comboBox2.SelectedIndex == 4)
            {
                warning_label.Visible = false;
                int m = dataGridView1.RowCount;
                int q = dataGridView1.ColumnCount;
                dataGridView3.Visible = true;
                double value;
                for (int i = 0; i < m; i++)
                for (int j = 0; j < q; j++)
                {
                    value = Convert.ToInt32(dataGridView1[j, i].Value);
                    value -= Convert.ToDouble(textBox1.Text);
                    dataGridView3[j, i].Value = value;
                }
            }
        

    
            
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "1";
            }
            else
            {
                p1 = textBox2.Text += "1";
            }
        }
        private void two_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "2";
            }
            else
            {
                p1 = textBox2.Text += "2";
            }
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "3";
            }
            else
            {
                p1 = textBox2.Text += "3";
            }
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "4";
            }
            else
            {
                p1 = textBox2.Text += "4";
            }
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "5";
            }
            else
            {
                p1 = textBox2.Text += "5";
            }
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "6";
            }
            else
            {
                p1 = textBox2.Text += "6";
            }
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "7";
            }
            else
            {
                p1 = textBox2.Text += "7";
            }
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "8";
            }
            else
            {
                p1 = textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "9";
            }
            else
            {
                p1 = textBox2.Text += "9";
            }
            
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += "0";
            }
            else
            {
                p1 = textBox2.Text += "0";
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {  
            flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '+';
            textBox4.Text = "+";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                flag = true;
                plus_btn.Enabled = false;
                minus_btn.Enabled = false;
                multiply_btn.Enabled = false;
                divide_btn.Enabled = false;
                percent_btn.Enabled = false;
                sqrt_btn.Enabled = false;
                hex_btn.Enabled = false;
                bin_btn.Enabled = false;
                button4.Enabled = false;
                ch = '-';
                textBox4.Text = "-";
                point_btn.Enabled = !point_btn.Enabled;
            }
            else
            {
                textBox2.Text += "-";                    
            }
           
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '*';
            textBox4.Text = "*";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '/';
            textBox4.Text = "/";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void button16_Click(object sender, EventArgs e)
        {           
            switch (ch)
            {
                case '+':
                    double pl = Convert.ToDouble(p1) + Convert.ToDouble(p2);
                    textBox5.Text = Convert.ToString(pl);
                    break;
                case '-':
                    double mi = Convert.ToDouble(p1) - Convert.ToDouble(p2);
                    textBox5.Text = Convert.ToString(mi);
                    break;
                case '*':
                    double mu = Convert.ToDouble(p1) * Convert.ToDouble(p2);
                    textBox5.Text = Convert.ToString(mu);
                    break;
                case '%':
                    double pe = Convert.ToDouble(p1) % Convert.ToDouble(p2);
                    textBox5.Text = Convert.ToString(pe);
                    break;
                case 's':
                    double ss = Math.Sqrt(Convert.ToDouble(p1));
                    textBox5.Text = Convert.ToString(ss);
                    break;

                case '!':
                    int num = int.Parse(p1);
                    int factorial = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;                                            
                    }
                    textBox5.Text = Convert.ToString(factorial);
                    break;

                case '2':
                    int bi = int.Parse(p1);
                    textBox5.Text = Convert.ToString(bi, 2);                   
                    break;

                case 'h':
                    int he = int.Parse(p1);
                    textBox5.Text = Convert.ToString(he, 16);
                    break;

                case '/':
                    if (p2 != "0")
                    {
                        double di = Convert.ToDouble(p1) / Convert.ToDouble(p2);
                        textBox5.Text = Convert.ToString(di);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Делить на 0 нельзя!!!");
                        this.DialogResult = DialogResult.Retry;
                        this.Close();
                        break;
                    }
            }
            flag = false;
        }       

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void point_btn_Click(object sender, EventArgs e)
        {
            point_btn.Enabled = !point_btn.Enabled;
            if (flag && textBox4.Text != "")
            {
                p2 = textBox3.Text += ",";
            }
            else
            {
                p1 = textBox2.Text += ",";
            }
        }

        private void percent_btn_Click(object sender, EventArgs e)
        {
            flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '%';
            textBox4.Text = "%";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void sqrt_btn_Click(object sender, EventArgs e)
        {
            //flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = 's';
            textBox4.Text = "sqrt";
            textBox3.Text = "-";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '!';
            textBox4.Text = "fact";
            textBox3.Text = "-";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void bin_btn_Click(object sender, EventArgs e)
        {
            //flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = '2';
            textBox4.Text = "bin";
            textBox3.Text = "-";
            point_btn.Enabled = !point_btn.Enabled;
        }

        private void hex_btn_Click(object sender, EventArgs e)
        {
            //flag = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            multiply_btn.Enabled = false;
            divide_btn.Enabled = false;
            percent_btn.Enabled = false;
            sqrt_btn.Enabled = false;
            hex_btn.Enabled = false;
            bin_btn.Enabled = false;
            button4.Enabled = false;
            ch = 'h';
            textBox4.Text = "hex";
            textBox3.Text = "-";
            point_btn.Enabled = !point_btn.Enabled;
        }
    }
}
