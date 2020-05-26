using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Form form = new Form1();
            form.DialogResult = DialogResult.Retry;

            while (form.DialogResult == DialogResult.Retry)
            {
                form.DialogResult = DialogResult.OK;
                form = new Form1();
                Application.Run(form);
            }
        }
    }
}
