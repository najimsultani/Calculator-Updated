using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//name - Najim sultani 
//date 3-8-23
//Assignment - Text Boxes, Labels, and Buttons

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PreviewKeyDown += MainWindow_PreviewKeyDown;
        }
        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {//closes the program
            if (e.Key == Key.K)
            {//when I press K
                Close();//close
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)//button for numbers to use Add
        {//show this when you see add
            lblAddSub.Content = "+";
            //string for number user enters
            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            double val1,val2 = 0;
            //true or false
            bool Val1IsANumber = double.TryParse(value1, out val1);
            bool Val2IsANumber = double.TryParse(value2, out val2);


            if (Val1IsANumber&& Val2IsANumber)
            {
                double btnAdd = (val1 + val2);
                txtValueResualt.Text = (val1 + val2).ToString();
            }
            else
            {//enters some thing else
                MessageBox.Show("Please Try Again");
            }


        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            lblAddSub.Content = "-";
            //Use for Subtraction
            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            double val1, val2 = 0;

            bool Val1IsANumber = double.TryParse(value1, out val1);
            bool Val2IsANumber = double.TryParse(value2, out val2);

            if (Val1IsANumber && Val2IsANumber)
            {
                double btnSub =  (val1 - val2);
                txtValueResualt.Text = (val1 - val2).ToString();
            }
            else
            {
                MessageBox.Show("Please Try Again");
            }

        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {//use this for multiplication
            lblMultDivi.Content = "*";

            string value3 = txtValue3.Text;
            string value4 = txtValue4.Text;

            double val3, val4 = 0;

            bool Val1IsANumber = double.TryParse(value3, out val3);
            bool Val2IsANumber = double.TryParse(value4, out val4);

            if (Val1IsANumber && Val2IsANumber)
            {
                double btnMult = (val3 * val4);
                txtValueResault2.Text = (val3 * val4).ToString();
            }
            else
            {
                MessageBox.Show("Please Try Again");
            }

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            lblMultDivi.Content = "/";
            //Use for Division
            string value3 = txtValue3.Text;
            string value4 = txtValue4.Text;

            double val3, val4 = 0;//they are equal to zero

            bool Val1IsANumber = double.TryParse(value3, out val3);
            bool Val2IsANumber = double.TryParse(value4, out val4);

            if (Val1IsANumber && Val2IsANumber)
            {//true use this
                double btnDiv = (val3 / val4);
                txtValueResault2.Text = (val3 / val4).ToString();
            }
            else
            {//false use type this
                MessageBox.Show("Please Try Again");
            }

        }

        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {//to find the average of both results 
         
            double result1, result2 = 0;
            //true or false
            bool result1IsANumber = double.TryParse(txtValueResualt.Text, out result1);
            bool result2IsANumber = double.TryParse(txtValueResault2.Text, out result2);

            if (result1IsANumber && result2IsANumber)
            {
                double average = (result1 + result2) / 2;
               txtAverage.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("Please Try Again");
            }


        }
        
    }
}
