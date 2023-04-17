using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static Regex regGroup = new Regex(@"^\+\d-\d{3,4}-\d{3}-\d{2}-\d{2}$");
        private static Regex regDate = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
        private static Regex regGroup = new Regex("^[0-9]{1,2}\\-[0-9]{1,2}\\.[0-9]{4}$");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tb1.Text) < 10)
            {
                tb1.Text = "10";
            }
        }

        private void Btncheck_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
           
            if (errors.Length > 0)
            {
                System.Windows.MessageBox.Show(errors.ToString());
            }
            else
            {
                if (CheackMaskGroup(MasksGroup.Text))
                {
                    System.Windows.MessageBox.Show(MasksGroup.Text);
                }
                
            }
            if (errors.Length > 0)
            {
                System.Windows.MessageBox.Show(errors.ToString());
            }
            else
            {
                if (CheackMaskDate(MasksDate.Text))
                {
                    System.Windows.MessageBox.Show(MasksDate.Text);
                }

            }
        }

        public static bool CheackTBText(String value)
        {
            if (value == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheackTBGroup(String value)
        {
            if (value == "__-__.___")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheackTBDate(String value)
        {
            if (value == "__/__/____")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheackMaskGroup(String value)
        {
            if (!regGroup.IsMatch(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheackMaskDate(String value)
        {
            if (!regDate.IsMatch(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
