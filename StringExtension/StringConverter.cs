using System;
using System.Text;

namespace StringExtension
{
    public class StringConverter
    {
        public string Convert(string source, int count)
        {
            StringBuilder str = new StringBuilder(source.Trim());
            StringBuilder lstr = new StringBuilder();
            StringBuilder rstr = new StringBuilder();
            int k_ident = 0;

            if (source is null)
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(str.ToString()))
            {
                throw new ArgumentException();
            }
            if (count < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            // Закончили проверки
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        rstr.Append(str[i]);
                    }
                    else
                    {
                        lstr.Append(str[i]);
                    }
                }
                str.Clear();
                str.Append(rstr);
                str.Append(lstr);
                lstr.Clear();
                rstr.Clear();
                if (str.ToString() == source)
                {
                    k_ident = j+1;
                    break;
                }
            }
            if (k_ident != 0)
            {

                int n = count % k_ident;
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            rstr.Append(str[i]);
                        }
                        else
                        {
                            lstr.Append(str[i]);
                        }
                    }
                    str.Clear();
                    str.Append(rstr);
                    str.Append(lstr);
                    lstr.Clear();
                    rstr.Clear();
                }
            }


            return str.ToString();
        }
    }
}