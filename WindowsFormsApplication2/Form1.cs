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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int rowHeight = 22;
            int colWidth = 44;

            //очистка матриц
            this.dataGridView1.Rows.Clear();
            this.dataGridView2.Rows.Clear();
            this.dataGridView3.Rows.Clear();

            //видимость матриц

            this.dataGridView1.Visible = true;

            if (comboBox2.SelectedIndex<3)
            {
                this.dataGridView2.Visible = true;
            }
            

            //задаем кол-во столбцов
            this.dataGridView1.ColumnCount = comboBox1.SelectedIndex+2;
            this.dataGridView2.ColumnCount = comboBox1.SelectedIndex + 2;

            //добавляем строки
            for (int i=0; i<comboBox1.SelectedIndex+2; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView2.Rows.Add();
            }

            //устанавливаем размеры строк
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = colWidth;
                dataGridView2.Columns[i].Width = colWidth;

                dataGridView1.Width = colWidth * this.dataGridView1.ColumnCount;
                dataGridView2.Width = colWidth * this.dataGridView2.ColumnCount;

                dataGridView1.Height = rowHeight * this.dataGridView1.ColumnCount;
                dataGridView2.Height = rowHeight * this.dataGridView2.ColumnCount;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex<3)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                label3.Visible = false;
                textBox1.Visible = false;
            }
            else
            {
                dataGridView2.Visible = false;
                label3.Visible = true;
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

            //задаем кол-во столбцов
            this.dataGridView1.ColumnCount = comboBox1.SelectedIndex + 2;
            this.dataGridView2.ColumnCount = comboBox1.SelectedIndex + 2;

            //добавляем строки
            for (int i = 0; i < comboBox1.SelectedIndex + 2; i++)
            {
                this.dataGridView1.Rows.Add();
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
    }
}
