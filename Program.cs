using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
        }

        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координати миші: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            if (e.Button == MouseButtons.Right)
            {
                message = "Ви натиснули праву кнопку миші.";
            }
            if (e.Button == MouseButtons.Left)
            {
                message = "Ви натиснули ліву кнопку миші.";
            }
            message += "\n" + CoordinatesToString(e);

            string caption = "Клік";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    internal static class Program
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
        }
    }
}
