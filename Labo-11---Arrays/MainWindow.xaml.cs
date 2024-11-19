using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_11___Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] numbers = { 100, 50, 20, 60, 90, 80 };

        int max;
        int min;

        StringBuilder sb = new StringBuilder();

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] minmax = ReturnSmallestAndBiggest(numbers);
            sb.AppendLine($"Het kleinste getal is {minmax[0]}");
            sb.AppendLine($"Het grootste getal is {minmax[1]}");


            outputTextBox.Text = StringSmallestAndBiggest(numbers);
            outputTextBox.Text = "-------------------------------------";
            outputTextBox.Text = OrderSmallestToBiggest(numbers);
        }

        private string StringSmallestAndBiggest(int[] numbers)
        {
            max = numbers[0];
            min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            sb.AppendLine($"In het totaal zijn er {numbers.Length} getallen");
            sb.AppendLine($"Het kleinste getal is {min}");
            sb.AppendLine($"Het grootste getal is {max}");

            return sb.ToString();
        }

        private string OrderSmallestToBiggest(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (int number in numbers)
            { 
                sb.AppendLine(number.ToString());
            }

            return sb.ToString();
        }

        private int[] ReturnSmallestAndBiggest(int[] numberArray)
        {
            max = numberArray[0];
            min = numberArray[0];

            int[] minmax = new int[2] { min, max };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberArray[i] < min)
                {
                    min = numbers[i];
                    minmax[0] = numbers[i];
                }

                if (numberArray[i] > max)
                {
                    max = numbers[i];
                    minmax[1] = numbers[i];
                }
            }

            return minmax;
           
        }
    }
}