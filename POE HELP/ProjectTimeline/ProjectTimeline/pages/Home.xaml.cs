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

                txtDuration.Text = objPr.Duration.ToString();
                objPr.calcEstimatedCost(150);

                txtEstCost.Text = objPr.EstimatedCost.ToString();

                MessageBox.Show(objPr.ToString());
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

          


        }
    }
}
