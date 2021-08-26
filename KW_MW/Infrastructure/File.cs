using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KW_MW.Infrastructure
{
    public static class File
    {

            public static string PobierzSciezke()
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                if (!(Properties.Settings.Default.FilePath.Equals("") || Properties.Settings.Default.FilePath.Equals(null)))
                {
                    dlg.InitialDirectory = Properties.Settings.Default.FilePath.ToString().Substring(0, Properties.Settings.Default.FilePath.LastIndexOf("\\"));
                }
                dlg.DefaultExt = ".txt";
                dlg.Filter = "All files(*.*) | *.*|TXT Files (*.txt)|*.txt";

                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    try
                    {
                        ustawProperties(dlg.FileName);
                    }
                    catch (Exception esa)
                    {
                        var resultat = MessageBox.Show(esa.ToString() + " Przerwać?", "ERROR", MessageBoxButton.YesNo);

                        if (resultat == MessageBoxResult.Yes)
                        {
                            Application.Current.Shutdown();
                        }
                    }
                }
                return dlg.FileName;
            }


            public static void ustawProperties(string FileName)
            {
                Properties.Settings.Default.FilePath = FileName;
                Properties.Settings.Default.Save();
            }

            public static List<string> OtworzPlik()
            {
                List<string> calyOdczzytanyTextLinie = new List<string>();
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.DefaultExt = ".edz";
                dlg.Filter = "All files(*.*) | *.*|TXT Files (*.txt)|*.txt| CSV(*.csv)|*.csv| EDZ(*.edz)|*.edz";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    calyOdczzytanyTextLinie = odczytZPlikuLinie(dlg.FileName).ToList();
                }
                return calyOdczzytanyTextLinie;
            }

            private static string[] odczytZPlikuLinie(string a) //odczyt z pliku z wyjatkami niepowodzenia należy podać ścieżkę, zwraca tablicę odczytaną z pliku
            {
                string[] all = null;
                //string[] lines = null;
                try
                {
                    all = System.IO.File.ReadAllLines(a, Encoding.Default);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Do dupy: {0}", e.Message);
                    MessageBox.Show("Błąd odcztu pliku txt lub csv.\nUpewnij się, że plik, \nktóry chcesz otworzyć jest zamknięty!", "ERROR", MessageBoxButton.OK);
                }
                return all;
            }

        public static List<KWModel> odczytajParametry()
        {
            List<KWModel> modelKW = new List<KWModel>();
            List<string> listaParametrów = new List<string>();
            var item = OtworzPlik();
            try
            {
                for (int i = 0; i < item.Count; i++)
                {
                    int columnCount =  item[i].Split('\t').ToList().Count;

                    modelKW.Add(new KWModel()
                    {
                        KW = item[i].Split('\t').ToList()[0],
                        OtherInfo = columnCount > 1 ? item[i].Split('\t').ToList()[1] : ""
                    });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return modelKW;
        }
        //koniec class

    }
}
