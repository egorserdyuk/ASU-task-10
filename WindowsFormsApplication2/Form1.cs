﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

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
                                value += Convert.ToInt32(dataGridView1[k, i].Value) * Convert.ToInt32(dataGridView2[j, k].Value);
                                dataGridView3[j, i].Value = value;
                            }
                        }
                }
            }
            
        }


    }
}
