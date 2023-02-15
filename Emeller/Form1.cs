using System;
using System.IO;
using System.Windows.Forms;

namespace Emeller
{
    public partial class Hesablama : Form
    {
        public Hesablama()
        {
            InitializeComponent();
        }

        double _firstNumber;
        double _secondNumber;
        double result;
        string operation;

        

        private void btnToplama_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGöster.Text, out _firstNumber))
            {
                MessageBox.Show("Düzgün ededi daxil edin:");
                return;
            }

            //   FirstNumber = Convert.ToDouble(txtGöster.Text);
            operation = "+";
            lblQeyd.Text = txtGöster.Text;
            txtGöster.Clear();

        }

        private void btnÇıxma_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGöster.Text, out _firstNumber))
            {
                MessageBox.Show("Düzgün ededi daxil edin:");
                return;

            }


            operation = "-";
            lblQeyd.Text = txtGöster.Text;

            txtGöster.Clear();

        }

        private void btnVurma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGöster.Text, out _firstNumber))
            {
                MessageBox.Show("Düzgün ededi daxil edin:");
                return;
            }

            operation = "*";
            lblQeyd.Text = txtGöster.Text;
            txtGöster.Clear();
        }

        private void btnBölmə_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGöster.Text, out _firstNumber))
            {
                MessageBox.Show("Düzgün ededi daxil edin:");
                return;
            }

            operation = "/";
            lblQeyd.Text = txtGöster.Text;
            txtGöster.Clear();
        }

        private void btnCavab_Click(object sender, EventArgs e)
        {
            _secondNumber = Convert.ToDouble(txtGöster.Text);
            if (operation == "+")
            {

                result = _firstNumber + _secondNumber;
                txtGöster.Text = Convert.ToString(result);
                lblQeyd.Text = _firstNumber + "+" + _secondNumber + "=";
            }

            if (operation == "-")
            {
                result = _firstNumber - _secondNumber;
                txtGöster.Text = Convert.ToString(result);
                lblQeyd.Text = _firstNumber + "-" + _secondNumber + "=";
            }

            if (operation == "*")
            {
                result = _firstNumber * _secondNumber;
                txtGöster.Text = Convert.ToString(result);
                lblQeyd.Text = _firstNumber + "*" + _secondNumber + "=";

            }
            if (operation == "/")
            {
                if (_secondNumber == 0)
                {
                    MessageBox.Show("0 - a bölmə yoxdur");
                }
                else
                {
                    result = _firstNumber / _secondNumber;
                    txtGöster.Text = Convert.ToString(result);
                    lblQeyd.Text = _firstNumber + "/" + _secondNumber + "=";
                }
            }

        }

        private void btnNfy_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter w = File.AppendText(@"C:\Users\User\Documents\C# Tasks\\Emeller\Emeller\TextFile1.txt"))
                {
                    w.WriteLine(result);
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblQeyd.ResetText();
            txtGöster.Clear();
        }


    }

}
