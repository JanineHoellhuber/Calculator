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


        public MainWindow()
        {
            InitializeComponent();
        
            //variablen für zustand speicherung  (btn1 und btn2 die gedrückt wurden)
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
            object getNumbers = sender.ToString();

            switch (getNumbers)
            {
                case "System.Windows.Controls.Button: _1":
                    Ergebnis.Text = "1";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 1;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 1;
                    }
                    break;
                case "System.Windows.Controls.Button: _2":
                    Ergebnis.Text = "2";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 2;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 2;
                    }
                    break;
                case "System.Windows.Controls.Button: _3":
                    Ergebnis.Text = "3";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 3;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 3;
                    }
                    break;
                case "System.Windows.Controls.Button: _4":
                    Ergebnis.Text = "4";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 4;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 4;
                    }
                    break;
                case "System.Windows.Controls.Button: _5":
                    Ergebnis.Text = "5";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 5;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 5;
                    }
                    break;
                case "System.Windows.Controls.Button: _6":
                    Ergebnis.Text = "6";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 6;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 6;
                    }
                    break;
                case "System.Windows.Controls.Button: _7":
                    Ergebnis.Text = "7";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 7;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 7;
                    }
                    break;
                case "System.Windows.Controls.Button: _8":
                    Ergebnis.Text = "8";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 8;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 8;
                    }
                    break;
                case "System.Windows.Controls.Button: _9":
                    Ergebnis.Text = "9";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 9;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 9;
                    }
                    break;
                case "System.Windows.Controls.Button: _0":
                    Ergebnis.Text = "0";
                    if (number1ToStore == 0)
                    {
                        number1ToStore = 0;
                    }
                    else if (number2ToStore == 0)
                    {
                        number2ToStore = 0;
                    }
                    break;
                case "System.Windows.Controls.Button: _+":
                    Ergebnis.Text = "+";
                    operatorToStore = '+';
                    break;
                case "System.Windows.Controls.Button: _-":
                    Ergebnis.Text = "-";
                    operatorToStore = '-';
                    break;
                case "System.Windows.Controls.Button: _*":
                    Ergebnis.Text = "*";
                    operatorToStore = '*';
                    break;
                case "System.Windows.Controls.Button: _/":
                    Ergebnis.Text = "/";
                    operatorToStore = '/'; 
                    break;
                case "System.Windows.Controls.Button: _C":
                    number2ToStore = 0;
                    ergebnisToStore = 0;
                    number1ToStore = 0;
                    Ergebnis.Text = " ";
                    break;
                case "System.Windows.Controls.Button: _=":
                  
                    if (number1ToStore != 0 && number2ToStore != 0 && operatorToStore == '+')
                    {
                        ergebnisToStore = number1ToStore + number2ToStore;
                        Ergebnis.Text = number1ToStore + "+" + number2ToStore + "=" + ergebnisToStore.ToString();

                    }
                    else if (number1ToStore != 0 && number2ToStore != 0 && operatorToStore == '-')
                    {
                        ergebnisToStore = number1ToStore - number2ToStore;
                        Ergebnis.Text = number1ToStore + "-" + number2ToStore + "=" + ergebnisToStore.ToString();

                    }
                    else if (number1ToStore != 0 && number2ToStore != 0 && operatorToStore == '*')
                    {
                        if (number1ToStore == 0 || number2ToStore == 0)
                        {
                            ergebnisToStore = 0;
                        }
                        else {
                            ergebnisToStore = number1ToStore * number2ToStore;
                        }
                        Ergebnis.Text = number1ToStore + "*" + number2ToStore + "=" + ergebnisToStore.ToString();

                    }
                    if (number1ToStore != 0 && number2ToStore != 0 && operatorToStore == '/')
                    {
                        if (number1ToStore == 0 || number2ToStore == 0)
                        {
                            ergebnisToStore = 0;
                        }
                        else
                        {
                            ergebnisToStore = number1ToStore / number2ToStore;
                        }
                        Ergebnis.Text = number1ToStore + "/" + number2ToStore + "=" + ergebnisToStore.ToString();

                    }
                    
                    break;
                default:
                    break;

              }
          
            }
        

      
    }
}
