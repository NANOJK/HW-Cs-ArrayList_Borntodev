using System;
using System.Collections;
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

namespace ArrayList_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //Add

            //Observe for Blank
            if (Input.Text == "")
            {
                MessageBox.Show("Please Insert Data In TextBox");
            }
            else
            {
                //Observe for *
                if (Input.Text == "*")
                {
                    MessageBox.Show("* is Keyword, Cannot insert *");
                    Input.Text = "";
                }
                else
                {
                    arrayList.Add(Input.Text);
                    MessageBox.Show("Add " + "\"" + Input.Text + "\"" + " Complete !!!");
                    Input.Text = "";
                }
            }
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            //Remove

            //Observe for blank
            if (Input.Text == "")
            {
                MessageBox.Show("Please Insert Data In TextBox");
            }
            else
            {
                //Observe for *
                if (Input.Text == "*")
                {
                    arrayList.Clear();
                    MessageBox.Show("Remove All Complete !!!");
                    Input.Text = "";
                }
                else
                {
                    //Observe for incorrect data
                    if (arrayList.Contains(Input.Text) == true)
                    {
                        arrayList.Remove((Input.Text));
                        MessageBox.Show("Remove " + "\"" + Input.Text + "\"" + " Complete !!!");
                        Input.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Input, " + Input.Text + " is not member in arrayList !!!");
                        Input.Text = "";
                    }
                }      
            } 
        }

        private void Button_Click_ShowAll(object sender, RoutedEventArgs e)
        {
            //Show All

            if (arrayList.Count == 0)
            {
                MessageBox.Show("Not have any Data in ArrayList !!!");
                Output.Text = "";
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
              
                foreach (string Data in arrayList)
                {
                    stringBuilder = stringBuilder.Append(Data + " , ");
                    Output.Text = stringBuilder.ToString() ;
                }

                string finalOutput = Output.Text.Substring(0, Output.Text.Length - 2);

                Output.Text = finalOutput;
            }
        }
    }
}
