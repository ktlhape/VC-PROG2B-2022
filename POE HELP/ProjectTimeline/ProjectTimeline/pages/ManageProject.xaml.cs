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
using ProjectTimeline.pages;

namespace ProjectTimeline.pages
{
    /// <summary>
    /// Interaction logic for ManageProject.xaml
    /// </summary>
    public partial class ManageProject : Page
    {
        public ManageProject()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            foreach (Project x in Project.prList)
            {
                lstDisplay.Items.Add(x.ToString());
            }
        }
    }
}
