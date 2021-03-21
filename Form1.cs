using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Double n = Convert.ToDouble(textBox1.Text);
      Double eps = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы " + Environment.NewLine;
      double a = 1, b = 1;
      double i = 1, ch = 0, p = 1, s = 0;
      int m = 0;
      if (radioButton2.Checked) m = 1;
      switch (m)
      {
        case 0:
          for (i = 1; i <= n; i++)
          {
            a *= i;
            b *= 0.1;
          }
          while (ch <= eps)
          {
            ch = 1 / (2 * n + a);
            s += ch;
            i++;
          }
          textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
          break;
        case 1:
          for (i = 1; i <= n; i++)
          {
            ch = 0.5 * (2 + b);
            p *= ch;
          }
          textBox2.Text += "При n = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
          break;
      }
    }
  }
}
