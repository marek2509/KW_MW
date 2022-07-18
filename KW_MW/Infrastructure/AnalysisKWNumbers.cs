using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_MW.Infrastructure
{
    class AnalysisKWNumbers
    {
        public static class BadanieKsiagWieczystych
        {
            private static List<char> numberDecodingCharArr = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'X', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'W', 'Y', 'Z' };
            private static List<char> numeric = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
       
            public static string FillOldNumber(string inputKWNum, string courtNumber)
            {
                List<char> charCourtNumber = new List<char>();
                charCourtNumber = courtNumber.ToCharArray().ToList();

                List<char> charKWNumber = new List<char>();
                charKWNumber = inputKWNum.Trim().ToUpper().ToCharArray().ToList();

                if (charKWNumber.Count > 8)
                {
                    return "-=#błędny numer#=-";
                }

                foreach (var item in charKWNumber)
                {
                    if (!numeric.Exists(x => x == item))
                    {
                        return "-=#błędny numer#=-";
                    }
                }

                List<int> liczbaSadu = new List<int>();
                List<int> liczbaKsiegi = new List<int>();

                while (charKWNumber.Count < 8)
                {
                    charKWNumber.Insert(0, '0');
                }

                string cyfraKontr = controlDigit(charCourtNumber, charKWNumber);

                StringBuilder sb = new StringBuilder();
                charCourtNumber.ForEach(x => sb.Append(x));
                sb.Append("/");
                charKWNumber.ForEach(x => sb.Append(x));
                sb.Append("/");
                sb.Append(cyfraKontr);
                return sb.ToString();
            }

            public static string CheckKWNumber(string KWNumber, string courtNumber=null, bool isCheckCourtNumber = false)
            {
                List<char> charKWNumer = new List<char>();
                charKWNumer = KWNumber.ToCharArray().ToList();

                if (!(charKWNumer.Count == 15))
                {
                    return "Błędna długość numeru";
                }

                if (!CourtList.listCourt.Exists(x => x.CourtCode == KWNumber.Substring(0, 4)))
                {
                    return "Błędny numer SĄDU";
                }


                if (isCheckCourtNumber && courtNumber != KWNumber.Substring(0, 4))
                {
                    return "Numer SĄDU inny niż wybrany";
                }


                if (charKWNumer[4] != '/' || charKWNumer[13] != '/')
                {
                    return "Brak znaków '/' w odpowiednim miejscu";
                }

                if ( !numeric.Exists(x => x == charKWNumer[5]))
                {
                    return charKWNumer[5] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[6]))
                {
                    return charKWNumer[6] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[7]))
                {
                    return charKWNumer[7] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[8]))
                {
                    return charKWNumer[8] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[9]))
                {
                    return charKWNumer[9] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[10]))
                {
                    return charKWNumer[10] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[11]))
                {
                    return charKWNumer[11] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[12]))
                {
                    return charKWNumer[12] + " <- To nie jest cyfra!";
                }

                if (!numeric.Exists(x => x == charKWNumer[14]))
                {
                    return charKWNumer[14] + " <- To nie jest cyfra!";
                }

                if (!numberDecodingCharArr.Exists(x => x == charKWNumer[0]) || !numberDecodingCharArr.Exists(y => y == charKWNumer[1]) ||
                    !numberDecodingCharArr.Exists(z => z == charKWNumer[2]) || !numberDecodingCharArr.Exists(v => v == charKWNumer[3]))
                {
                    return "Błędny numer SĄDU";
                }


                List<char> charCourtNumber = new List<char>();
                charCourtNumber = charKWNumer.GetRange(0, 4);

                List<char> charKWPartNum = new List<char>();
                charKWPartNum = charKWNumer.GetRange(5, 8);

                List<int> liczbaSadu = new List<int>();
                List<int> liczbaKsiegi = new List<int>();

                string cyfraKontr = controlDigit(charCourtNumber, charKWPartNum);

                if (cyfraKontr[0] == charKWNumer.Last())
                {
                    Console.WriteLine("Zgadza się cyfra kontrolna");
                }
                else
                {
                    return "błędna cyfra kontrolna " + charKWNumer.Last() + " -> " + cyfraKontr[0];
                }
                return "";
            }

            private static List<int> getListCourtLp(List<char> charCourtNumber)
            {
                List<int> liczbaSadu = new List<int>();

                foreach (var a in charCourtNumber)
                {
                    for (int i = 0; i < numberDecodingCharArr.Count; i++)
                    {
                        if (a == numberDecodingCharArr[i])
                            liczbaSadu.Add(i);
                    }
                }
                return liczbaSadu;
            }

            private static List<int> getListKWLp(List<char> charKWNumber) 
            {
                List<int> liczbaKW = new List<int>();

                foreach (var a in charKWNumber)
                {
                    for (int i = 0; i < numberDecodingCharArr.Count; i++)
                    {
                        if (a == numberDecodingCharArr[i])
                        {
                            liczbaKW.Add(i);
                            break;
                        }
                    }
                }
                return liczbaKW;
            }

            private static string controlDigit(List<char> charCourtNumber, List<char> charKWNumber)
            {
                List<int> liczbaSadu = new List<int>();
                List<int> liczbaKsiegi = new List<int>();

                liczbaSadu = getListCourtLp(charCourtNumber); // insert np. BI2P
                liczbaKsiegi = getListKWLp(charKWNumber); // insert np. 00004569

                int sumaKontrolna =
                   liczbaSadu[0] * 1 +
                   liczbaSadu[1] * 3 +
                   liczbaSadu[2] * 7 +
                   liczbaSadu[3] * 1 +

                   liczbaKsiegi[0] * 3 +
                   liczbaKsiegi[1] * 7 +
                   liczbaKsiegi[2] * 1 +
                   liczbaKsiegi[3] * 3 +
                   liczbaKsiegi[4] * 7 +
                   liczbaKsiegi[5] * 1 +
                   liczbaKsiegi[6] * 3 +
                   liczbaKsiegi[7] * 7;

                return (sumaKontrolna % 10).ToString();
            }

        }
    }
}
