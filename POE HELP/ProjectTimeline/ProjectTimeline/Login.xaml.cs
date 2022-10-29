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
using System.Windows.Shapes;
using ProjectTimeline.classes;

namespace ProjectTimeline
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        MainWindow main = new MainWindow();
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            int empNum = Convert.ToInt32(txtEmpNum.Text);

            string pass = txtPassword.Password.ToString();
            Employee em = new Employee();
            em.getEmployee(empNum);
            

            if (empNum == em.EmployeeNum && pass.Equals(em.Password))
            {
                main.Tag = em;
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect details");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
