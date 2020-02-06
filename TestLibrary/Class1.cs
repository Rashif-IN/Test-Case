using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLibrary
{
    public class TestCase
    {

        

        //number 1
        public int JumKar(string str)
        {
            return str.Length;
        }

        //number2
        public char Grade(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80 && score < 90)
            {
                return 'B';
            }
            else if (score >= 70 && score < 80)
            {
                return 'C';
            }
            else if (score >= 60 && score < 70)
            {
                return 'D';
            }
            else
            {
                return 'E';
            }
        }

        //number3
        public string GanjilGenap(int num)
        {
            if (num % 2 == 0)
            {
                return "genap";
            }
            else
            {
                return "ganjil";
            }
        }

        //number4
        public string kabisat(int tahun)
        {
            if (tahun % 4 == 0)
            {
                if (tahun % 100 == 0)
                {
                    if (tahun % 400 == 0)
                    {
                        return "kabisat";
                    }
                    else
                    {
                        return "bukan kabisat";
                    }
                }
                else
                {
                    return "kabisat";
                }
            }
            else
            {
                return "bukan kabisat";
            }
        }

        //number5
        public string RatingFilm(int usia)
        {
            if (usia >= 21)
            {
                return "dewasa";
            }
            else if (usia >= 13 && usia < 21)
            {
                return "remaja";
            }
            else if (usia >= 9 && usia < 13)
            {
                return "bimbingan orang tua";
            }
            else
            {
                return "semua umur";
            }
        }

        //number6
        public int[] LoopRange(int start, int end)
        {
            int arLeng = end - start;
            int[] ar = new int[arLeng + 1];

            for (int i = start; i <= end; i++)
            {
                ar[i - start] = i;

            }

            return ar;
        }

        //number7
        public List<int> BilGanjil()
        {
            List<int> ans = new List<int>();

            int[] ar = new int[50];
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

        //number8
        public string[] OddEvenMul()
        {
            string[] ar = new string[1000];
            for (int i = 0; i < 1000; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    if ((i + 1) % 100 == 0)
                    {
                        ar[i] = $"{i + 1}. Kelipatan Seratus";
                    }
                    else
                    {
                        ar[i] = $"{i + 1}. Genap";
                    }
                }
                else if ((i + 1) % 5 == 0)
                {
                    if (i + 1 % 100 == 0)
                    {
                        ar[i] = $"{i + 1}. Kelipatan Seratus";
                    }
                    else
                    {
                        ar[i] = $"{i + 1}. Kelipatan lima";
                    }
                }
                else
                {
                    ar[i] = $"{i + 1}. Ganjil";
                }
            }
            return ar;
        }

        //number 9
        public string BalikKata(string kalimat)
        {
            string[] Kalimat = kalimat.Split(' ');
            Array.Reverse(Kalimat);
            return String.Join(" ", Kalimat);
        }

        //number 10
        public string[] AddArray(string[] ar, string first, string last)
        {
            string[] NewAr = new string[ar.Length + 2];
            for (int i = 0; i < NewAr.Length; i++)
            {
                if (i == 0)
                {
                    NewAr[i] = first;
                }
                else if (i == NewAr.Length - 1)
                {
                    NewAr[i] = last;
                }
                else
                {
                    NewAr[i] = ar[i - 1];
                }
            }
            return NewAr;
        }
    }



}

