using ProjectTimeline.classes;
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

namespace ProjectTimeline.pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }
        //public static Project pr = new Project();
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string prCode, prName;
            DateTime sDate, eDate;
        

            try
            {
                prCode = txtPrCode.Text;
                prName = txtPrName.Text;

                sDate = dpStartDate.SelectedDate.Value;
                eDate = dpEndDate.SelectedDate.Value;

                Project objPr = new Project(prCode, prName, sDate, eDate);

                //Project.prList.Add(objPr);              
                txtDuration.Text = $"{objPr.Duration} days";
                objPr.calcEstimatedCost(150);

                objPr.AddProject();
                txtEstCost.Text = objPr.EstimatedCost.ToString("c2");
                MessageBox.Show($"Project {objPr.ProjectName} has been added");
                clearScreen();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void clearScreen()
        {
            txtDuration.Clear();
            txtEstCost.Clear();
            txtPrCode.Clear();
            txtPrName.Clear();
            dpEndDate.SelectedDate = DateTime.Today;
            dpStartDate.SelectedDate = DateTime.Today;
            txtPrCode.Focus();
        }
    }
}
