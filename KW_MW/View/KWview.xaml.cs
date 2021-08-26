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

namespace KW_MW.View
{
    /// <summary>
    /// Logika interakcji dla klasy KWview.xaml
    /// </summary>
    public partial class KWview : Window
    {
        List<KWModel> KWFromFile = new List<KWModel>();
        public KWview()
        {
            InitializeComponent();
            comboBoxCourt.ItemsSource = Infrastructure.CourtList.ListCourtToComboBox();
            radioGenerateKW.IsChecked = true;
            dataGridFromFile.ItemsSource = KWFromFile;

        }

        private void MenuItem_Click_OpneFile(object sender, RoutedEventArgs e)
        {
            KWFromFile = Infrastructure.File.odczytajParametry();
            dataGridFromFile.ItemsSource = KWFromFile;
        }

        private void GenerateKwNumber_Click(object sender, RoutedEventArgs e)
        {
            string selectedValueComboCourt =  Infrastructure.CourtList.getCodeFromComboBox(comboBoxCourt.SelectedValue.ToString());
            Console.WriteLine(selectedValueComboCourt);

            foreach (var kw in KWFromFile)
            {
              kw.Result =  Infrastructure.AnalysisKWNumbers.BadanieKsiagWieczystych.FillOldNumber(kw.KW, selectedValueComboCourt);
              Console.WriteLine(kw.Result);
            }


            //dataGridFromFile.ItemsSource = KWFromFile;
            dataGridFromFile.Items.Refresh();
        }

        private void CheckKwNumber_Click(object sender, RoutedEventArgs e)
        {
            string selectedValueComboCourt = Infrastructure.CourtList.getCodeFromComboBox(comboBoxCourt.SelectedValue.ToString());
            Console.WriteLine(selectedValueComboCourt);

            foreach (var kw in KWFromFile)
            {
                kw.Result = Infrastructure.AnalysisKWNumbers.BadanieKsiagWieczystych.CheckKWNumber(kw.KW);
                Console.WriteLine(kw.Result);
            }


            //dataGridFromFile.ItemsSource = KWFromFile;
            dataGridFromFile.Items.Refresh();
        }



        private void RadioCheckKW_Checked(object sender, RoutedEventArgs e)
        {
            checkKwNumber.Visibility = Visibility.Visible;
            generateKwNumber.Visibility = Visibility.Collapsed;

        }
        private void RadioGenerateKW_Checked(object sender, RoutedEventArgs e)
        {
               checkKwNumber.Visibility = Visibility.Collapsed;
               generateKwNumber.Visibility = Visibility.Visible;
        }
    }
}
