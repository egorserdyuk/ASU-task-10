namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calc_tab = new System.Windows.Forms.TabControl();
            this.generic_calc = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.hex_btn = new System.Windows.Forms.Button();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.divide_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.res_btn = new System.Windows.Forms.Button();
            this.percent_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.point_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.sign_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.matrix_calc = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bin_btn = new System.Windows.Forms.Button();
            this.calc_tab.SuspendLayout();
            this.generic_calc.SuspendLayout();
            this.matrix_calc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calc_tab
            // 
            this.calc_tab.Controls.Add(this.generic_calc);
            this.calc_tab.Controls.Add(this.matrix_calc);
            this.calc_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calc_tab.Location = new System.Drawing.Point(0, 0);
            this.calc_tab.Name = "calc_tab";
            this.calc_tab.SelectedIndex = 0;
            this.calc_tab.Size = new System.Drawing.Size(514, 393);
            this.calc_tab.TabIndex = 1;
            this.calc_tab.SelectedIndexChanged += new System.EventHandler(this.calc_tab_SelectedIndexChanged);
            // 
            // generic_calc
            // 
            this.generic_calc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generic_calc.Controls.Add(this.bin_btn);
            this.generic_calc.Controls.Add(this.button4);
            this.generic_calc.Controls.Add(this.hex_btn);
            this.generic_calc.Controls.Add(this.sqrt_btn);
            this.generic_calc.Controls.Add(this.richTextBox1);
            this.generic_calc.Controls.Add(this.divide_btn);
            this.generic_calc.Controls.Add(this.multiply_btn);
            this.generic_calc.Controls.Add(this.minus_btn);
            this.generic_calc.Controls.Add(this.plus_btn);
            this.generic_calc.Controls.Add(this.res_btn);
            this.generic_calc.Controls.Add(this.percent_btn);
            this.generic_calc.Controls.Add(this.clear_btn);
            this.generic_calc.Controls.Add(this.backspace);
            this.generic_calc.Controls.Add(this.point_btn);
            this.generic_calc.Controls.Add(this.zero_btn);
            this.generic_calc.Controls.Add(this.sign_btn);
            this.generic_calc.Controls.Add(this.nine_btn);
            this.generic_calc.Controls.Add(this.eight_btn);
            this.generic_calc.Controls.Add(this.seven_btn);
            this.generic_calc.Controls.Add(this.six_btn);
            this.generic_calc.Controls.Add(this.five_btn);
            this.generic_calc.Controls.Add(this.four_btn);
            this.generic_calc.Controls.Add(this.three_btn);
            this.generic_calc.Controls.Add(this.two_btn);
            this.generic_calc.Controls.Add(this.one_btn);
            this.generic_calc.Location = new System.Drawing.Point(4, 22);
            this.generic_calc.Name = "generic_calc";
            this.generic_calc.Padding = new System.Windows.Forms.Padding(1);
            this.generic_calc.Size = new System.Drawing.Size(506, 367);
            this.generic_calc.TabIndex = 0;
            this.generic_calc.Text = "Обычный";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(66, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 23;
            this.button4.Text = "n!";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // hex_btn
            // 
            this.hex_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hex_btn.FlatAppearance.BorderSize = 0;
            this.hex_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hex_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hex_btn.Location = new System.Drawing.Point(4, 144);
            this.hex_btn.Margin = new System.Windows.Forms.Padding(1);
            this.hex_btn.Name = "hex_btn";
            this.hex_btn.Size = new System.Drawing.Size(60, 40);
            this.hex_btn.TabIndex = 22;
            this.hex_btn.Text = "HEX";
            this.hex_btn.UseVisualStyleBackColor = false;
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sqrt_btn.FlatAppearance.BorderSize = 0;
            this.sqrt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt_btn.Location = new System.Drawing.Point(66, 144);
            this.sqrt_btn.Margin = new System.Windows.Forms.Padding(1);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.Size = new System.Drawing.Size(60, 40);
            this.sqrt_btn.TabIndex = 21;
            this.sqrt_btn.Text = "√";
            this.sqrt_btn.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(246, 98);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "\n";
            // 
            // divide_btn
            // 
            this.divide_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divide_btn.FlatAppearance.BorderSize = 0;
            this.divide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide_btn.Location = new System.Drawing.Point(190, 144);
            this.divide_btn.Margin = new System.Windows.Forms.Padding(1);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(60, 40);
            this.divide_btn.TabIndex = 19;
            this.divide_btn.Text = "/";
            this.divide_btn.UseVisualStyleBackColor = false;
            // 
            // multiply_btn
            // 
            this.multiply_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multiply_btn.FlatAppearance.BorderSize = 0;
            this.multiply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply_btn.Location = new System.Drawing.Point(190, 186);
            this.multiply_btn.Margin = new System.Windows.Forms.Padding(1);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(60, 40);
            this.multiply_btn.TabIndex = 18;
            this.multiply_btn.Text = "*";
            this.multiply_btn.UseVisualStyleBackColor = false;
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minus_btn.FlatAppearance.BorderSize = 0;
            this.minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_btn.Location = new System.Drawing.Point(190, 228);
            this.minus_btn.Margin = new System.Windows.Forms.Padding(1);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(60, 40);
            this.minus_btn.TabIndex = 17;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = false;
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plus_btn.FlatAppearance.BorderSize = 0;
            this.plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_btn.Location = new System.Drawing.Point(190, 270);
            this.plus_btn.Margin = new System.Windows.Forms.Padding(1);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(60, 40);
            this.plus_btn.TabIndex = 16;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            // 
            // res_btn
            // 
            this.res_btn.BackColor = System.Drawing.Color.LightGray;
            this.res_btn.FlatAppearance.BorderSize = 0;
            this.res_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.res_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_btn.Location = new System.Drawing.Point(190, 312);
            this.res_btn.Margin = new System.Windows.Forms.Padding(1);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(60, 40);
            this.res_btn.TabIndex = 15;
            this.res_btn.Text = "=";
            this.res_btn.UseVisualStyleBackColor = false;
            this.res_btn.Click += new System.EventHandler(this.button16_Click);
            // 
            // percent_btn
            // 
            this.percent_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.percent_btn.FlatAppearance.BorderSize = 0;
            this.percent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_btn.Location = new System.Drawing.Point(128, 144);
            this.percent_btn.Margin = new System.Windows.Forms.Padding(1);
            this.percent_btn.Name = "percent_btn";
            this.percent_btn.Size = new System.Drawing.Size(60, 40);
            this.percent_btn.TabIndex = 14;
            this.percent_btn.Text = "%";
            this.percent_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.Location = new System.Drawing.Point(128, 102);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(1);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(60, 40);
            this.clear_btn.TabIndex = 13;
            this.clear_btn.Text = "CE";
            this.clear_btn.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.Location = new System.Drawing.Point(190, 102);
            this.backspace.Margin = new System.Windows.Forms.Padding(1);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(60, 40);
            this.backspace.TabIndex = 12;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = false;
            // 
            // point_btn
            // 
            this.point_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.point_btn.FlatAppearance.BorderSize = 0;
            this.point_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_btn.Location = new System.Drawing.Point(128, 312);
            this.point_btn.Margin = new System.Windows.Forms.Padding(1);
            this.point_btn.Name = "point_btn";
            this.point_btn.Size = new System.Drawing.Size(60, 40);
            this.point_btn.TabIndex = 11;
            this.point_btn.Text = ",";
            this.point_btn.UseVisualStyleBackColor = false;
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.Color.White;
            this.zero_btn.FlatAppearance.BorderSize = 0;
            this.zero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero_btn.Location = new System.Drawing.Point(66, 312);
            this.zero_btn.Margin = new System.Windows.Forms.Padding(1);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(60, 40);
            this.zero_btn.TabIndex = 10;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            // 
            // sign_btn
            // 
            this.sign_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sign_btn.FlatAppearance.BorderSize = 0;
            this.sign_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_btn.Location = new System.Drawing.Point(4, 312);
            this.sign_btn.Margin = new System.Windows.Forms.Padding(1);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(60, 40);
            this.sign_btn.TabIndex = 9;
            this.sign_btn.Text = "+/-";
            this.sign_btn.UseVisualStyleBackColor = false;
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.Color.White;
            this.nine_btn.FlatAppearance.BorderSize = 0;
            this.nine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine_btn.Location = new System.Drawing.Point(128, 186);
            this.nine_btn.Margin = new System.Windows.Forms.Padding(1);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(60, 40);
            this.nine_btn.TabIndex = 8;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.Color.White;
            this.eight_btn.FlatAppearance.BorderSize = 0;
            this.eight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight_btn.Location = new System.Drawing.Point(66, 186);
            this.eight_btn.Margin = new System.Windows.Forms.Padding(1);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(60, 40);
            this.eight_btn.TabIndex = 7;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.Color.White;
            this.seven_btn.FlatAppearance.BorderSize = 0;
            this.seven_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven_btn.Location = new System.Drawing.Point(4, 186);
            this.seven_btn.Margin = new System.Windows.Forms.Padding(1);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(60, 40);
            this.seven_btn.TabIndex = 6;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.Color.White;
            this.six_btn.FlatAppearance.BorderSize = 0;
            this.six_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six_btn.Location = new System.Drawing.Point(128, 228);
            this.six_btn.Margin = new System.Windows.Forms.Padding(1);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(60, 40);
            this.six_btn.TabIndex = 5;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.Color.White;
            this.five_btn.FlatAppearance.BorderSize = 0;
            this.five_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five_btn.Location = new System.Drawing.Point(66, 228);
            this.five_btn.Margin = new System.Windows.Forms.Padding(1);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(60, 40);
            this.five_btn.TabIndex = 4;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.Color.White;
            this.four_btn.FlatAppearance.BorderSize = 0;
            this.four_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four_btn.Location = new System.Drawing.Point(4, 228);
            this.four_btn.Margin = new System.Windows.Forms.Padding(1);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(60, 40);
            this.four_btn.TabIndex = 3;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.Color.White;
            this.three_btn.FlatAppearance.BorderSize = 0;
            this.three_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three_btn.Location = new System.Drawing.Point(128, 270);
            this.three_btn.Margin = new System.Windows.Forms.Padding(1);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(60, 40);
            this.three_btn.TabIndex = 2;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.Color.White;
            this.two_btn.FlatAppearance.BorderSize = 0;
            this.two_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_btn.Location = new System.Drawing.Point(66, 270);
            this.two_btn.Margin = new System.Windows.Forms.Padding(1);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(60, 40);
            this.two_btn.TabIndex = 1;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.Color.White;
            this.one_btn.FlatAppearance.BorderSize = 0;
            this.one_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_btn.Location = new System.Drawing.Point(4, 270);
            this.one_btn.Margin = new System.Windows.Forms.Padding(1);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(60, 40);
            this.one_btn.TabIndex = 0;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            // 
            // matrix_calc
            // 
            this.matrix_calc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.matrix_calc.Controls.Add(this.button2);
            this.matrix_calc.Controls.Add(this.button1);
            this.matrix_calc.Controls.Add(this.label4);
            this.matrix_calc.Controls.Add(this.dataGridView3);
            this.matrix_calc.Controls.Add(this.textBox1);
            this.matrix_calc.Controls.Add(this.label3);
            this.matrix_calc.Controls.Add(this.dataGridView2);
            this.matrix_calc.Controls.Add(this.comboBox2);
            this.matrix_calc.Controls.Add(this.label2);
            this.matrix_calc.Controls.Add(this.dataGridView1);
            this.matrix_calc.Controls.Add(this.comboBox1);
            this.matrix_calc.Controls.Add(this.label1);
            this.matrix_calc.Location = new System.Drawing.Point(4, 22);
            this.matrix_calc.Name = "matrix_calc";
            this.matrix_calc.Padding = new System.Windows.Forms.Padding(3);
            this.matrix_calc.Size = new System.Drawing.Size(506, 367);
            this.matrix_calc.TabIndex = 1;
            this.matrix_calc.Text = "Матрицы";
            this.matrix_calc.Click += new System.EventHandler(this.matrix_calc_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(430, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 15;
            this.button2.Text = "Результат";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(430, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.Location = new System.Drawing.Point(14, 225);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 40;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView3.Size = new System.Drawing.Size(65, 65);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Column5";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(336, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите число";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(246, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 40;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(65, 65);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column5";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A*B",
            "A+B",
            "A-B",
            "A+Число",
            "A-Число",
            "A*Число",
            "A/Число"});
            this.comboBox2.Location = new System.Drawing.Point(124, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите действие";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(14, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(65, 65);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(150, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размерность матрицы A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bin_btn
            // 
            this.bin_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bin_btn.FlatAppearance.BorderSize = 0;
            this.bin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bin_btn.Location = new System.Drawing.Point(4, 102);
            this.bin_btn.Margin = new System.Windows.Forms.Padding(1);
            this.bin_btn.Name = "bin_btn";
            this.bin_btn.Size = new System.Drawing.Size(60, 40);
            this.bin_btn.TabIndex = 24;
            this.bin_btn.Text = "BIN";
            this.bin_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(514, 393);
            this.Controls.Add(this.calc_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calc_tab.ResumeLayout(false);
            this.generic_calc.ResumeLayout(false);
            this.matrix_calc.ResumeLayout(false);
            this.matrix_calc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl calc_tab;
        private System.Windows.Forms.TabPage generic_calc;
        private System.Windows.Forms.TabPage matrix_calc;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Button percent_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button point_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button sign_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button hex_btn;
        private System.Windows.Forms.Button sqrt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bin_btn;
    }
}

