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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Collections;

namespace GroupProject
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BudgetContext dc = new BudgetContext();
        BudgetContext budgetContext = null;

        public MainWindow()
        {
            InitializeComponent();
            budgetContext = new BudgetContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
