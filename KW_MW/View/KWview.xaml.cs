using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

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
            Console.WriteLine(Properties.Settings.Default.selectedIdxCourtList);
            comboBoxCourt.SelectedIndex = Properties.Settings.Default.selectedIdxCourtList;
        }

        private void MenuItem_Click_OpneFile(object sender, RoutedEventArgs e)
        {
            KWFromFile = Infrastructure.FileOperation.ReadTheParametrs();
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
            dataGridFromFile.Items.Refresh();
        }

        private void CheckKwNumber_Click(object sender, RoutedEventArgs e)
        {
            string selectedValueComboCourt = Infrastructure.CourtList.getCodeFromComboBox(comboBoxCourt.SelectedValue.ToString());
            Console.WriteLine(selectedValueComboCourt);

            foreach (var kw in KWFromFile)
            {
                kw.Result = Infrastructure.AnalysisKWNumbers.BadanieKsiagWieczystych.CheckKWNumber(kw.KW, selectedValueComboCourt, (bool)checkBoxSpr.IsChecked);
                Console.WriteLine(kw.Result);
            }
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
               checkBoxSpr.IsChecked = true;
        }

        private void ComboBoxCourt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Properties.Settings.Default.selectedIdxCourtList = comboBoxCourt.SelectedIndex;
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.selectedIdxCourtList);
            Console.WriteLine(comboBoxCourt.SelectedIndex);
        }

        private void MenuItem_Click_SaveToFile(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[KW]\t[OtherInfo]\t[Result]");
            KWFromFile.ForEach(x => sb.AppendLine(x.KW + "\t" + x.OtherInfo + "\t" + x.Result));
            Infrastructure.FileOperation.SaveToFile(sb.ToString());
        }
    }
}
