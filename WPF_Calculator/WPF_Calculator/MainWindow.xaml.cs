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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int number1ToStore = 0;
        public int number2ToStore = 0;
        public char operatorToStore = ' ';
        public bool istGleichToStore = false;
        public int ergebnisToStore = 0;
        public Button getNumbers;
        public bool buttonWithNumber1ToStoreIsClicked = false;


        public MainWindow()
        {
            InitializeComponent();
        
            btnNumber0.Click += Button_Click;
            btnNumber1.Click += Button_Click;
            btnNumber2.Click += Button_Click;
            btnNumber3.Click += Button_Click;
            btnNumber4.Click += Button_Click;
            btnNumber5.Click += Button_Click;
            btnNumber6.Click += Button_Click;
            btnNumber7.Click += Button_Click;
            btnNumber8.Click += Button_Click;
            btnNumber9.Click += Button_Click;


            opIstGleich.Click += Button_Click;
            opPlus.Click += Button_Click;
            opMinus.Click += Button_Click;
            opMal.Click += Button_Click;
            opDividiert.Click += Button_Click;

            opClear.Click += Button_Click;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             getNumbers = (Button)sender;
            switch (getNumbers.Content.ToString())
            {
                case "_1":
                    Ergebnis.Text = "1";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 1;
                        buttonWithNumber1ToStoreIsClicked = true; 
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 1;
                    }
                    break;
                case "_2":
                    Ergebnis.Text = "2";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 2;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 2;
                    }
                    break;
                case "_3":
                    Ergebnis.Text = "3";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 3;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 3;
                    }
                    break;
                case "_4":
                    Ergebnis.Text = "4";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 4;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 4;
                    }
                    break;
                case "_5":
                    Ergebnis.Text = "5";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 5;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 5;
                    }
                    break;
                case "_6":
                    Ergebnis.Text = "6";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 6;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 6;
                    }
                    break;
                case "_7":
                    Ergebnis.Text = "7";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 7;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 7;
                    }
                    break;
                case "_8":
                    Ergebnis.Text = "8";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 8;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 8;
                    }
                    break;
                case "_9":
                    Ergebnis.Text = "9";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 9;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 9;
                    }
                    break;
                case "_0":
                    Ergebnis.Text = "0";
                    if (!buttonWithNumber1ToStoreIsClicked)
                    {
                        number1ToStore = 0;
                        buttonWithNumber1ToStoreIsClicked = true;
                    }
                    else if (buttonWithNumber1ToStoreIsClicked)
                    {
                        number2ToStore = 0;
                    }
                    break;
                case "_+":
                    Ergebnis.Text = "+";
                    operatorToStore = '+';
                    break;
                case "_-":
                    Ergebnis.Text = "-";
                    operatorToStore = '-';
                    break;
                case "_*":
                    Ergebnis.Text = "*";
                    operatorToStore = '*';
                    break;
                case "_/":
                    Ergebnis.Text = "/";
                    operatorToStore = '/'; 
                    break;
                case "_C":
                    number2ToStore = 0;
                    ergebnisToStore = 0;
                    number1ToStore = 0;
                    Ergebnis.Text = " ";
                    buttonWithNumber1ToStoreIsClicked = false;
                    break;
                case "_=":
                  
                    if (operatorToStore == '+')
                    {
                        ergebnisToStore = number1ToStore + number2ToStore;
                        Ergebnis.Text = ergebnisToStore.ToString();

                    }
                    else if (operatorToStore == '-')
                    {
                        ergebnisToStore = number1ToStore - number2ToStore;
                        Ergebnis.Text = ergebnisToStore.ToString();

                    }
                    else if (operatorToStore == '*')
                    {
                       ergebnisToStore = number1ToStore * number2ToStore;
                       Ergebnis.Text = ergebnisToStore.ToString();

                    }
                    if (operatorToStore == '/')
                    {
                        if(number2ToStore != 0) { 
                            ergebnisToStore = number1ToStore / number2ToStore;
                            Ergebnis.Text = ergebnisToStore.ToString();
                        }
                        else 
                        {
                            Ergebnis.Text = "Teilen durch 0 nicht möglich";
                        }

                    }
                    
                    break;
                default:
                    break;

              }
          
            }
        

      
    }
}
