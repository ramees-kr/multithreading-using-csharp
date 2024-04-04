using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci.Threads
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (!int.TryParse(txtNumber.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear previous output
            listBoxOutput.Items.Clear();

            // Generate Fibonacci numbers in the background
            await GenerateFibonacciNumbersAsync(count);
        }


        private async Task GenerateFibonacciNumbersAsync(int count)
        {
            object lockObject = new object(); 

            for (int i = 0; i < count; i++)
            {
                int fibonacci_n = await Task.Run(() => GenerateFibonacciNumber(i));

                lock (lockObject)
                {
                    listBoxOutput.Items.Add(fibonacci_n);
                }
            }
        }

        private int GenerateFibonacciNumber(int number)
        {
            if (number <= 1)
                return number;
            else
                return GenerateFibonacciNumber(number - 1) + GenerateFibonacciNumber(number - 2);
        }
    }
}
