using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int m = 5;
        int n = 5;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Button button = new Button();
                    button.Location = new Point((j + 1) * 50, (i+1) * 40);
                    button.Height = 40;
                    button.Width = 50;
                    button.Text = (1 + j + i * 5).ToString();
                    button.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    button.Click += new EventHandler(Button_Click);
                    Controls.Add(button);
                }
            }

        }
        private void Button_Click(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Hide();
        }
    }
}
