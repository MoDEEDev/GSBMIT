using ServiceTestClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
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

namespace ServiceTestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ServiceReference1.MITServiceClient GetService()
        {
            ServiceReference1.MITServiceClient client = new ServiceReference1.MITServiceClient();
            client.ClientCredentials.UserName.UserName = txtUser.Text;
            client.ClientCredentials.UserName.Password = txtPass.Password;
            return client;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.CentralRegistration[] results = client.getRegisteryInfoByIndividualNationalNumber(txtNationalityID.Text);
            CompaniesGrid.ItemsSource = results;
            if (results != null)
            {
                PurposesGrid.ItemsSource = results[0].strRegisteryPurposes;
            }
        }
        private void Button_Click_new(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.CentralRegistration result = client.getRegisteryInfoByEstablishmentNationalNumber(txtNationalityID_Copy.Text);
            ServiceReference1.CentralRegistration[] results = new ServiceReference1.CentralRegistration[1];
            results[0] = result;
            CompaniesGrid.ItemsSource = results;
            if (results != null)
            {
                PurposesGrid.ItemsSource = results[0].strRegisteryPurposes;
                TradeMarksGrid.ItemsSource = results[0].lstTradeMarks;
                //if (results[0].lstTradeMarks != null)
                //{
                //    BitmapImage bi = new BitmapImage();
                //    bi.BeginInit();
                //    bi.StreamSource = new MemoryStream(results[0].lstTradeMarks[0].tms_pict);
                //    bi.EndInit();
                //    Image img = new Image();
                //    ImageViewer1.Source = bi;
                //}
            }
        }

        private void Button_Click_old(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.CentralRegistration result = client.getIndividualRegistry(Convert.ToInt64(txtNationalityID_Copy.Text));
            ServiceReference1.CentralRegistration[] results = new ServiceReference1.CentralRegistration[1];
            results[0] = result;
            CompaniesGrid.ItemsSource = results;
            //CompaniesGrid.ItemsSource = results;
            //if (results != null)
            //{
            //    PurposesGrid.ItemsSource = results[0].strRegisteryPurposes;
            //    TradeMarksGrid.ItemsSource = results[0].lstTradeMarks;

            //}
        }

        private void TradeMark_Changed(object sender, SelectionChangedEventArgs e)
        {
            TradeMark details = (TradeMark)(((System.Windows.Controls.DataGrid)(sender)).CurrentItem);
            if (details != null)
            {
                ServiceReference1.MITServiceClient client = GetService();
                ServiceReference1.TradeMarksLogo test = client.getTradeMarkLogoBy(details.decTradeMarkNo.ToString(), details.dist.ToString());
                if (test != null)
                {
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(test.tms_pict);
                    bi.EndInit();
                    Image img = new Image();
                    ImageViewer1.Source = bi;
                }
            }
        }

        private void Button_Click_TM_LOGO(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.TradeMarksLogo test = client.getTradeMarkLogoBy(txtTrdMark.Text, txtDist.Text);
            if (test != null)
            {
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(test.tms_pict);
                bi.EndInit();
                Image img = new Image();
                ImageViewer1.Source = bi;
            }
        }

        private void Button_Click_ccd(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.ccd_name[] result = client.getccd_name(txtNationalityID_ccd.Text);
         //   ServiceReference1.ccd_name[] results = new ServiceReference1.ccd_name[1];
        //    results[0] = result;
            CompaniesGrid.ItemsSource = result;

        }

        private void Button_Click_ccdMark(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.Logo_mark[] result = client.getccd_mark(txtNationalityID_ccdMark.Text, "66");
            ServiceReference1.Logo_mark[] results = new ServiceReference1.Logo_mark[1];
            results = result;
            CompaniesGrid.ItemsSource = results;
            DataGridTemplateColumn one = new DataGridTemplateColumn();
            FrameworkElementFactory imageFactory = new FrameworkElementFactory(typeof(Image));
            imageFactory.SetBinding(Image.SourceProperty, new Binding(Convert.ToString(result[1].Logo_data)));

            DataTemplate dataTemplate = new DataTemplate();
            dataTemplate.VisualTree = imageFactory;
            one.CellTemplate = dataTemplate;
            CompaniesGrid.Columns.Add(one);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(result[0].Logo_data);
            bi.EndInit();
            Image img = new Image();
            ImageViewer1.Source = bi;

        }

        private void Button_Click_TM_old(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.TradeMark[] result = client.getTradeMark(txtTrdMark.Text, Convert.ToInt32(txtDist.Text));
            //ServiceReference1.CentralRegistration[] results = new ServiceReference1.CentralRegistration[1];
            //results = result;
            CompaniesGrid.ItemsSource = result;
           
        }

        private void Button_Click_getInstitute(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.InstituteInformation result = client.GetInstitiuteInfobyIDNumber(txtIDNumber.Text);
            ServiceReference1.InstituteInformation[] results = new ServiceReference1.InstituteInformation[1];
            results[0] = result;
            if (result != null)
            {
                InstitutionsGrid.ItemsSource = results;
            }            
        }

        private void Button_Click_getModifications(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.Modifications[] result = client.getModificationsByRegistrationNoGover(txtregNo.Text);
            InstitutionsGrid.ItemsSource = result;
        }

        private void Button_Click_getIntendeds(object sender, RoutedEventArgs e)
        {
            ServiceReference1.MITServiceClient client = GetService();
            ServiceReference1.Intended[] result = client.getIntendedBySharedCode(txtSharedCode.Text);
            InstitutionsGrid.ItemsSource = result;
        }


    }
}
