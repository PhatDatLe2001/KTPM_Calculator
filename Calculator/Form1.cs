using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("+");
            txtKQ.Text = ketQua.ToString();
        }

        private void btLuyThua_Click(object sender, EventArgs e)
        {
            int n;
            double x, ketQua;
            n = int.Parse(txtSo2.Text);
            x = double.Parse(txtSo1.Text);
            ketQua = Cau1.Power(x, n);
            txtKQ.Text = ketQua.ToString();
        }
    }
}
