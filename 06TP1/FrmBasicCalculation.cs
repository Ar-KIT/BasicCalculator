using System;
using CalculatorPrivateAssembly;
using System.Windows.Forms;

namespace _06TP1
{
    public partial class FrmBasicCalculation : Form
    {
        public FrmBasicCalculation()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);

                // Get selected operation from ComboBox
                string operation = cbOperator.SelectedItem.ToString();
                float result = 0;

                // Perform calculation based on selected operation
                switch (operation)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Division(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.");
                        return;
                }
                lblTotal.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
