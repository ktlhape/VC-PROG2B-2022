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
using ProjectTimeline.classes;
using System.Configuration;

namespace ProjectTimeline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        pages.Home pgHome = new pages.Home();
        pages.ManageProject pgManage = new pages.ManageProject();
        public Employee myEmployee = new Employee();
        public MainWindow()
        {
            InitializeComponent();        
            frmNav.Content = pgHome;
        
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            frmNav.Content = pgHome;
        }

        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            frmNav.Content = pgManage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Employee em = (Employee)this.Tag;
            this.Title = $"Welcome {em.Name}: ({em.EmployeeNum})";  
        }
    }
}
