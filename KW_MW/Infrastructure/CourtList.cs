using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_MW.Infrastructure
{
    static class CourtList
    {
        public static List<Court> listCourt = new List<Court>
        {
            new Court() { Id = 1, CourtCode = "BB1B", CourtName = "w Bielsku-Białej "},
            new Court() { Id = 2, CourtCode = "BB1C", CourtName = "w Cieszynie "},
            new Court() { Id = 3, CourtCode = "BB1Z", CourtName = "w Żywcu "},
            new Court() { Id = 4, CourtCode = "BI1B", CourtName = "w Białymstoku "},
            new Court() { Id = 5, CourtCode = "BI1P", CourtName = "w Bielsku Podlaskim "},
            new Court() { Id = 6, CourtCode = "BI1S", CourtName = "w Sokółce "},
            new Court() { Id = 7, CourtCode = "BI2P", CourtName = "w Bielsku Podlaskim – wydział zamiejscowy z siedzibą w Hajnówce "},
            new Court() { Id = 8, CourtCode = "BI3P", CourtName = "w Bielsku Podlaskim – wydział zamiejscowy z siedzibą w Siemiatyczach "},
            new Court() { Id = 9, CourtCode = "BY1B", CourtName = "w Bydgoszczy "},
            new Court() { Id = 10, CourtCode = "BY1I", CourtName = "w Inowrocławiu "},
            new Court() { Id = 11, CourtCode = "BY1M", CourtName = "w Inowrocławiu – wydział zamiejscowy z siedzibą w Mogilnie "},
            new Court() { Id = 12, CourtCode = "BY1N", CourtName = "w Nakle nad Notecią "},
            new Court() { Id = 13, CourtCode = "BY1S", CourtName = "w Świeciu "},
            new Court() { Id = 14, CourtCode = "BY1T", CourtName = "w Tucholi "},
            new Court() { Id = 15, CourtCode = "BY1U", CourtName = "w Szubinie "},
            new Court() { Id = 16, CourtCode = "BY1Z", CourtName = "w Szubinie – wydział zamiejscowy z siedzibą w Żninie "},
            new Court() { Id = 17, CourtCode = "BY2T", CourtName = "w Tucholi – wydział zamiejscowy z siedzibą w Sępólnie Krajeńskim "},
            new Court() { Id = 18, CourtCode = "CZ1C", CourtName = "w Częstochowie "},
            new Court() { Id = 19, CourtCode = "CZ1L", CourtName = "w Lublińcu "},
            new Court() { Id = 20, CourtCode = "CZ1M", CourtName = "w Myszkowie "},
            new Court() { Id = 21, CourtCode = "CZ1Z", CourtName = "w Zawierciu "},
            new Court() { Id = 22, CourtCode = "CZ2C", CourtName = "w Częstochowie – wydział zamiejscowy z siedzibą w Kłobucku "},
            new Court() { Id = 23, CourtCode = "EL1B", CourtName = "w Braniewie "},
            new Court() { Id = 24, CourtCode = "EL1D", CourtName = "w Działdowie "},
            new Court() { Id = 25, CourtCode = "EL1E", CourtName = "w Elblągu "},
            new Court() { Id = 26, CourtCode = "EL1I", CourtName = "w Iławie "},
            new Court() { Id = 27, CourtCode = "EL1N", CourtName = "w Iławie – wydział zamiejscowy z siedzibą w Nowym Mieście Lubawskim "},
            new Court() { Id = 28, CourtCode = "EL1O", CourtName = "w Ostródzie "},
            new Court() { Id = 29, CourtCode = "EL2O", CourtName = "w Ostródzie – wydział zamiejscowy z siedzibą w Morągu "},
            new Court() { Id = 30, CourtCode = "GD1A", CourtName = "w Starogardzie Gdańskim "},
            new Court() { Id = 31, CourtCode = "GD1E", CourtName = "w Kościerzynie "},
            new Court() { Id = 32, CourtCode = "GD1G", CourtName = "Gdańsk-Północ w Gdańsku "},
            new Court() { Id = 33, CourtCode = "GD1I", CourtName = "w Kwidzynie "},
            new Court() { Id = 34, CourtCode = "GD1M", CourtName = "w Malborku "},
            new Court() { Id = 35, CourtCode = "GD1R", CourtName = "w Kartuzach "},
            new Court() { Id = 36, CourtCode = "GD1S", CourtName = "w Sopocie "},
            new Court() { Id = 37, CourtCode = "GD1T", CourtName = "w Tczewie "},
            new Court() { Id = 38, CourtCode = "GD1W", CourtName = "w Wejherowie "},
            new Court() { Id = 39, CourtCode = "GD1Y", CourtName = "w Gdyni "},
            new Court() { Id = 40, CourtCode = "GD21", CourtName = "w Kwidzynie – wydział zamiejscowy z siedzibą w Sztumie "},
            new Court() { Id = 41, CourtCode = "GD2M", CourtName = "w Malborku – wydział zamiejscowy z siedzibą w Nowym Dworze Gdańskim "},
            new Court() { Id = 42, CourtCode = "GD2W", CourtName = "w Wejherowie – wydział zamiejscowy z siedzibą w Pucku "},
            new Court() { Id = 43, CourtCode = "GL1G", CourtName = "w Gliwicach "},
            new Court() { Id = 44, CourtCode = "GL1J", CourtName = "w Jastrzębiu-Zdroju "},
            new Court() { Id = 45, CourtCode = "GL1R", CourtName = "w Raciborzu "},
            new Court() { Id = 46, CourtCode = "GL1S", CourtName = "w Rudzie Śląskiej "},
            new Court() { Id = 47, CourtCode = "GL1T", CourtName = "w Tarnowskich Górach "},
            new Court() { Id = 48, CourtCode = "GL1W", CourtName = "w Wodzisławiu Śląskim "},
            new Court() { Id = 49, CourtCode = "GL1X", CourtName = "w Żorach "},
            new Court() { Id = 50, CourtCode = "GL1Y", CourtName = "w Rybniku "},
            new Court() { Id = 51, CourtCode = "GL1Z", CourtName = "w Zabrzu "},
            new Court() { Id = 52, CourtCode = "KA1B", CourtName = "w Będzinie "},
            new Court() { Id = 53, CourtCode = "KA1C", CourtName = "w Chorzowie "},
            new Court() { Id = 54, CourtCode = "KA1D", CourtName = "w Dąbrowie Górniczej "},
            new Court() { Id = 55, CourtCode = "KA1I", CourtName = "w Siemianowicach Śląskich "},
            new Court() { Id = 56, CourtCode = "KA1J", CourtName = "w Jaworznie "},
            new Court() { Id = 57, CourtCode = "KA1K", CourtName = "Katowice-Wschód w Katowicach "},
            new Court() { Id = 58, CourtCode = "KA1L", CourtName = "w Mysłowicach "},
            new Court() { Id = 59, CourtCode = "KA1M", CourtName = "w Mikołowie "},
            new Court() { Id = 60, CourtCode = "KA1P", CourtName = "w Pszczynie "},
            new Court() { Id = 61, CourtCode = "KA1S", CourtName = "w Sosnowcu "},
            new Court() { Id = 62, CourtCode = "KA1T", CourtName = "w Tychach "},
            new Court() { Id = 63, CourtCode = "KA1Y", CourtName = "w Bytomiu "},
            new Court() { Id = 64, CourtCode = "KI1B", CourtName = "w Busku-Zdroju "},
            new Court() { Id = 65, CourtCode = "KI1I", CourtName = "w Busku-Zdroju – wydział zamiejscowy z siedzibą w Kazimierzy Wielkiej "},
            new Court() { Id = 66, CourtCode = "KI1P", CourtName = "w Busku-Zdroju – wydział zamiejscowy "},
            new Court() { Id = 67, CourtCode = "LM1G", CourtName = "w Grajewie "},
            new Court() { Id = 68, CourtCode = "LM1L", CourtName = "w Łomży "},
            new Court() { Id = 69, CourtCode = "LM1W", CourtName = "w Wysokiem Mazowieckiem "},
            new Court() { Id = 70, CourtCode = "LM1Z", CourtName = "w Zambrowie "},
            new Court() { Id = 71, CourtCode = "OL1B", CourtName = "w Mrągowie – wydział zamiejscowy z siedzibą w Biskupcu"},
            new Court() { Id = 72, CourtCode = "OL1C", CourtName = "w Olecku "},
            new Court() { Id = 73, CourtCode = "OL1E", CourtName = "w Ełku "},
            new Court() { Id = 74, CourtCode = "OL1G", CourtName = "w Giżycku "},
            new Court() { Id = 75, CourtCode = "OL1K", CourtName = "w Kętrzynie "},
            new Court() { Id = 76, CourtCode = "OL1L", CourtName = "w Bartoszycach – wydział zamiejscowy z siedzibą w Lidzbarku Warmińskim"},
            new Court() { Id = 77, CourtCode = "OL1M", CourtName = "w Mrągowie "},
            new Court() { Id = 78, CourtCode = "OL1N", CourtName = "w Olsztynie – wydział zamiejscowy z siedzibą w Nidzicy"},
            new Court() { Id = 79, CourtCode = "OL1O", CourtName = "w Olsztynie "},
            new Court() { Id = 80, CourtCode = "OL1P", CourtName = "w Piszu "},
            new Court() { Id = 81, CourtCode = "OL1S", CourtName = "w Szczytnie "},
            new Court() { Id = 82, CourtCode = "OL1Y", CourtName = "w Bartoszycach "},
            new Court() { Id = 83, CourtCode = "OL2G", CourtName = "w Giżycku – wydział zamiejscowy z siedzibą w Węgorzewie "},
            new Court() { Id = 84, CourtCode = "OS1M", CourtName = "w Ostrowi Mazowieckiej "},
            new Court() { Id = 85, CourtCode = "OS1O", CourtName = "w Ostrołęce "},
            new Court() { Id = 86, CourtCode = "OS1P", CourtName = "w Przasnyszu "},
            new Court() { Id = 87, CourtCode = "OS1U", CourtName = "w Pułtusku "},
            new Court() { Id = 88, CourtCode = "OS1W", CourtName = "w Wyszkowie "},
            new Court() { Id = 89, CourtCode = "SL1B", CourtName = "w Lęborku – wydział zamiejscowy z siedzibą w Bytowie "},
            new Court() { Id = 90, CourtCode = "SL1C", CourtName = "w Chojnicach "},
            new Court() { Id = 91, CourtCode = "SL1L", CourtName = "w Lęborku "},
            new Court() { Id = 92, CourtCode = "SL1M", CourtName = "w Słupsku – wydział zamiejscowy z siedzibą w Miastku"},
            new Court() { Id = 93, CourtCode = "SL1S", CourtName = "w Słupsku "},
            new Court() { Id = 94, CourtCode = "SL1Z", CourtName = "w Człuchowie "},
            new Court() { Id = 95, CourtCode = "SU1A", CourtName = "w Augustowie "},
            new Court() { Id = 96, CourtCode = "SU1N", CourtName = "w Augustowie – wydział zamiejscowy z siedzibą w Sejnach"},
            new Court() { Id = 97, CourtCode = "SU1S", CourtName = "w Suwałkach "},
            new Court() { Id = 98, CourtCode = "TO1B", CourtName = "w Brodnicy "},
            new Court() { Id = 99, CourtCode = "TO1C", CourtName = "w Chełmnie "},
            new Court() { Id = 100, CourtCode = "TO1G", CourtName = "w Brodnicy – wydział zamiejscowy z siedzibą w Gołubiu-Dobrzyniu"},
            new Court() { Id = 101, CourtCode = "TO1T", CourtName = "w Toruniu "},
            new Court() { Id = 102, CourtCode = "TO1U", CourtName = "w Grudziądzu "},
            new Court() { Id = 103, CourtCode = "TO1W", CourtName = "w Chełmnie – wydział zamiejscowy z siedzibą w Wąbrzeźnie "},
            new Court() { Id = 104, CourtCode = "WL1A", CourtName = "w Aleksandrowie Kujawskim "},
            new Court() { Id = 105, CourtCode = "WL1L", CourtName = "w Lipnie "},
            new Court() { Id = 106, CourtCode = "WL1R", CourtName = "w Aleksandrowie Kujawskim – wydział zamiejscowy z siedzibą w Radziejowie "},
            new Court() { Id = 107, CourtCode = "WL1W", CourtName = "we Włocławku "},
            new Court() { Id = 108, CourtCode = "WL1Y", CourtName = "w Lipnie – wydział zamiejscowy z siedzibą w Rypinie "},
        };

        public static List<string> ListCourtToComboBox()
        {
            List<string> listCourtComboBox = new List<string>();
            listCourt.ForEach(x => listCourtComboBox.Add(x.CourtCode + "\n" + x.CourtName));
            return listCourtComboBox;
        }

        public static string getCodeFromComboBox(string textFromComboBox)
        {
            return textFromComboBox.Substring(0, 4);
        }

        public class Court
        {
            public int Id { get; set; }
            public string CourtCode { get; set; }
            public string CourtName { get; set; }
        }
    }


}
