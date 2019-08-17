using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator : ContentPage
    {
        private string number1 = String.Empty;
        private ArrayList display = new ArrayList();
        private int mathOperation = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void DeleteFirstTime(string number)
        {
            lblResultado.Text = number;
        }

        private void Button1_clicked(object sender, EventArgs e)
        {
            var number = "1";
            lblResultado.Text += number;
        }

        private void Button2_clicked(object sender, EventArgs e)
        {
            var number = "2";
            lblResultado.Text += number;
        }

        private void Button3_clicked(object sender, EventArgs e)
        {
            var number = "3";
            lblResultado.Text += number;
        }

        private void deleteLabel(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void ButtonPlus_clicked(object sender, EventArgs e)
        {
            string operationSign = "+";
            mathOperation = 1;
            number1 = lblResultado.Text;
            lblResultado.Text += operationSign;
            display.Add(number1);
            display.Add(operationSign);
            lblResultado.Text = "";
        }

        private void Button6_clicked(object sender, EventArgs e)
        {
            var number = "6";
            lblResultado.Text += number;
        }

        private void Button5_clicked(object sender, EventArgs e)
        {
            var number = "5";
            lblResultado.Text += number;
        }

        private void Button4_clicked(object sender, EventArgs e)
        {
            var number = "4";
            lblResultado.Text += number;
        }

        private void ButtonMultiply_clicked(object sender, EventArgs e)
        {
            string operationSign = "*";
            mathOperation = 1;
            number1 = lblResultado.Text;
            lblResultado.Text += operationSign;
            display.Add(number1);
            display.Add(operationSign);
            lblResultado.Text = "";
        }

        private void Button9_clicked(object sender, EventArgs e)
        {
            var number = "9";
            lblResultado.Text += number;
        }

        private void Button8_clicked(object sender, EventArgs e)
        {
            var number = "8";
            lblResultado.Text += number;
        }

        private void Button7_clicked(object sender, EventArgs e)
        {
            var number = "7";
            lblResultado.Text += number;
        }

        private void ButtonMinus_clicked(object sender, EventArgs e)
        {
            string operationSign = "-";
            mathOperation = 1;
            number1 = lblResultado.Text;
            lblResultado.Text += operationSign;
            display.Add(number1);
            display.Add(operationSign);
            lblResultado.Text = "";
        }

        private void ButtonDivide_clicked(object sender, EventArgs e)
        {
            string operationSign = "/";
            mathOperation = 1;
            number1 = lblResultado.Text;
            lblResultado.Text += operationSign;
            display.Add(number1);
            display.Add(operationSign);
            lblResultado.Text = "";
        }

        private void ButtonNegativeAndPositive_clicked(object sender, EventArgs e)
        {
            var number = "-";
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += "-";
            }
            else
            {
                DeleteFirstTime(number);
            }
        }

        private void Button0_clicked(object sender, EventArgs e)
        {
            var number = "0";
            lblResultado.Text += number;
        }

        private void ButtonPoint_clicked(object sender, EventArgs e)
        {
            var number = ".";
            if (lblResultado.Text != "0")
            {
                lblResultado.Text += ".";
            }
            else
            {
                DeleteFirstTime(number);
            }
        }

        private void ButtonEquals_clicked(object sender, EventArgs e)
        {
            lblResultado.Text = operationArrayManager(display);
        }

        private string operationArrayManager(ArrayList array)
        {
            display.Add(lblResultado.Text);
            string result = "";
            int resultInt = 0;
            int numberInt = 0;

            for (int i = 0; i < array.Count; i++)
            {
                switch (array[i])
                {
                    case "+":
                        numberInt += resultInt + int.Parse(array[i++].ToString());
                        i++;
                        break;

                    case "-":
                        numberInt -= resultInt + int.Parse(array[i++].ToString());
                        i++;
                        break;

                    case "*":
                        numberInt *= resultInt + int.Parse(array[i++].ToString());
                        i++;
                        break;

                    case "/":
                        numberInt /= resultInt + int.Parse(array[i++].ToString());
                        i++;
                        break;

                    default:
                        resultInt = Int32.Parse(array[i].ToString());
                        break;
                }
            }
            display.Clear();
            result = numberInt.ToString();
            return result;
        }
    }
}