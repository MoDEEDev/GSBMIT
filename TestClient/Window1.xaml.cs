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

namespace TestClient
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        ServiceReference1.MunicipalityandPropertyClient GetService()
        {
            ServiceReference1.MunicipalityandPropertyClient client = new ServiceReference1.MunicipalityandPropertyClient();
            client.ClientCredentials.UserName.UserName = txtUser.Text;
            client.ClientCredentials.UserName.Password = txtPass.Password;
            return client;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                ServiceReference1.MunicipalityandPropertyClient client = GetService();
                ServiceReference1.MunicipalityInfo mi = client.getMunicipalityInfoByMunicipalityName(txtOrgName.Text.Trim());
                List<ServiceReference1.MunicipalityInfo> LMI = new List<ServiceReference1.MunicipalityInfo>();
                LMI.Add(mi);
                CompaniesGrid.ItemsSource = LMI;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
