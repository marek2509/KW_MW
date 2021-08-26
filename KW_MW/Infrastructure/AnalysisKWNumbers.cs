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
            /*
            public static string SprawdzCyfreKontrolna(string KsiegaWieczysta, string OtherTextToReport) // zwraca null gdy księga jest ok lub wypisuje komunikat
            {
                StringBuilder errorSB = new StringBuilder();
                if (KsiegaWieczysta == null || KsiegaWieczysta == "")
                {
                    errorSB.Append("");
                    goto koniec;
                }
                int sumaKontrolna;

                char[] textBox1 = new char[15];

                KsiegaWieczysta = KsiegaWieczysta.Trim();


                textBox1 = KsiegaWieczysta.ToCharArray();

                if (textBox1.Length != 15)
                {
                    errorSB.Append("Problem z ksiega: " + KsiegaWieczysta + "\n");
                    goto koniec;
                }
                for (int i = 5; i < 13; i++)
                {
                    try
                    {

                        if (textBox1[i] == '0' || textBox1[i] == '1' || textBox1[i] == '2' || textBox1[i] == '3' || textBox1[i] == '4' || textBox1[i] == '5' || textBox1[i] == '6' || textBox1[i] == '7' || textBox1[i] == '8' || textBox1[i] == '9')
                        {

                        }
                        else
                        {

                            errorSB.Append("\nElement ->" + textBox1[i] + " <-jest nie poprawny w ksiedze nr " + KsiegaWieczysta );

                        }
                    }
                    catch
                    {
                        errorSB.Append("problem z ksiega: " + KsiegaWieczysta + "\n");
                    }
                }

                int[] liczbaSadu = new int[4];
                int[] liczbaKsiegi = new int[8];
                //   Console.WriteLine(liczbaKsiegi[3] + " kurla");
                //string[] Foo = s1.Split(new char[] { ' ' });
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < numberDecodingCharArr.Count; i++)
                    {
                        if (textBox1[j].Equals(numberDecodingCharArr[i]))
                        {
                            liczbaSadu[j] = i;
                            //Console.WriteLine("LK" + liczbaSadu[j]);
                        }
                    }
                }

                int koncowa = 7;
                for (int j = 12; j >= 5; j--)
                {
                    for (int i = 0; i < numberDecodingCharArr.Count; i++)
                    {
                        if (j == 4 || j == 13) continue;
                        if (textBox1[j].Equals(numberDecodingCharArr[i]))
                        {
                            liczbaKsiegi[koncowa] = i;
                            // Console.WriteLine("LK" + liczbaKsiegi[j]);
                            koncowa--;
                        }
                    }
                }



                sumaKontrolna = liczbaSadu[0] * 1 + liczbaSadu[1] * 3 + liczbaSadu[2] * 7 + liczbaSadu[3] * 1 + liczbaKsiegi[0] * 3 + liczbaKsiegi[1] * 7 + liczbaKsiegi[2] * 1 + liczbaKsiegi[3] * 3 + liczbaKsiegi[4] * 7 + liczbaKsiegi[5] * 1 + liczbaKsiegi[6] * 3 + liczbaKsiegi[7] * 7;
                string cyfraKontr = (sumaKontrolna % 10).ToString();

                if (cyfraKontr[0] == KsiegaWieczysta[KsiegaWieczysta.Length - 1])
                {

                }
                else
                {
                    errorSB.Append("\nZły nr KW, poprawna cyfra kontrolna =" + sumaKontrolna % 10 + " w KW " + KsiegaWieczysta + " w obrębie nr ");
                }
            //  Console.WriteLine("CYFRA KONTROLNA " + sumaKontrolna%10 + "KW: " + KsiegaWieczysta);
            koniec:
                return errorSB.ToString();
            }

            public static bool SprawdzCyfreKontrolnaBool(string KsiegaWieczysta) // zwraca true gdy księga jest ok
            {
                StringBuilder errorSB = new StringBuilder();
                if (KsiegaWieczysta == null || KsiegaWieczysta == "")
                {
                    return false;
                }
                int sumaKontrolna;

                char[] textBox1 = new char[15];

                KsiegaWieczysta = KsiegaWieczysta.Trim();


                textBox1 = KsiegaWieczysta.ToCharArray();

                if (textBox1.Length != 15)
                {
                    return false;
                }
                for (int i = 5; i < 13; i++)
                {
                    try
                    {

                        if (textBox1[i] == '0' || textBox1[i] == '1' || textBox1[i] == '2' || textBox1[i] == '3' || textBox1[i] == '4' || textBox1[i] == '5' || textBox1[i] == '6' || textBox1[i] == '7' || textBox1[i] == '8' || textBox1[i] == '9')
                        {

                        }
                        else
                        {

                            return false;

                        }
                    }
                    catch
                    {
                        return false;
                    }
                }

                int[] liczbaSadu = new int[4];
                int[] liczbaKsiegi = new int[8];

                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < numberDecodingCharArr.Length; i++)
                    {
                        if (textBox1[j].Equals(numberDecodingCharArr[i]))
                        {
                            liczbaSadu[j] = i;
                        }
                    }
                }

                int koncowa = 7;
                for (int j = 12; j >= 5; j--)
                {
                    for (int i = 0; i < numberDecodingCharArr.Length; i++)
                    {
                        if (j == 4 || j == 13) continue;
                        if (textBox1[j].Equals(numberDecodingCharArr[i]))
                        {
                            liczbaKsiegi[koncowa] = i;
                            koncowa--;
                        }
                    }
                }

                sumaKontrolna = liczbaSadu[0] * 1 + liczbaSadu[1] * 3 + liczbaSadu[2] * 7 + liczbaSadu[3] * 1 + liczbaKsiegi[0] * 3 + liczbaKsiegi[1] * 7 + liczbaKsiegi[2] * 1 + liczbaKsiegi[3] * 3 + liczbaKsiegi[4] * 7 + liczbaKsiegi[5] * 1 + liczbaKsiegi[6] * 3 + liczbaKsiegi[7] * 7;
                string cyfraKontr = (sumaKontrolna % 10).ToString();

                if (cyfraKontr[0] == KsiegaWieczysta[KsiegaWieczysta.Length - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            */



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

            public static string CheckKWNumber(string KWNumber)
            {
                //KWNumber = KWNumber.ToUpper();
                List<char> charKWNumer = new List<char>();
                charKWNumer = KWNumber.ToCharArray().ToList();

                ////////////////////////////////////
                ///

                if (!(charKWNumer.Count == 15))
                {
                    return "Błędna długość numeru";
                }


                if (!CourtList.listCourt.Exists(x => x.CourtCode == KWNumber.Substring(0, 4)))
                {
                    return "Błędny numer SĄDU";
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


                if (!numberDecodingCharArr.Exists(x => x == charKWNumer[0]) ||
               !numberDecodingCharArr.Exists(y => y == charKWNumer[1]) ||
               !numberDecodingCharArr.Exists(z => z == charKWNumer[2]) ||
               !numberDecodingCharArr.Exists(v => v == charKWNumer[3]))
                {
                    return "Błędny numer SĄDU";
                }
                //////////////////////////////////////////////// kontrolA^^^^

                List<char> charCourtNumber = new List<char>();
                charCourtNumber = charKWNumer.GetRange(0, 4);

                List<char> charKWPartNum = new List<char>();
                charKWPartNum = charKWNumer.GetRange(5, 8);

                charCourtNumber.ForEach(x => Console.Write(x));
                Console.WriteLine();
                charKWPartNum.ForEach(x => Console.Write(x));
                Console.WriteLine();


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

                StringBuilder sb = new StringBuilder();
                charCourtNumber.ForEach(x => sb.Append(x));
                sb.Append("/");
                charKWPartNum.ForEach(x => sb.Append(x));
                sb.Append("/");
                sb.Append(cyfraKontr);
                return "ok.";
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
