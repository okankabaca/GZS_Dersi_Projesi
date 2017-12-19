using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZS_Proje
{
    public class Class1
    {
        public static int olculenboy;
        public static double olculennabiz;
        public static Boolean spor = false;
        public static int yas;
        public static string cinsiyet = "";


        public static string boysonuc(int boy) //Nabız sonuç fonk
        {
            string sonuc;
            if (cinsiyet=="Kadın")
            {
                if (yas>=0&& yas <=2)
                {
                    if (boy<85 && boy >50)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 85)
                    {
                        sonuc = "Boyunuz yaşınıza göre "+ ((boy-85).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((50 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >=3 && yas<=6)
                {
                    if (boy < 90 && boy > 105)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 105)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 105).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((90 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >= 7 && yas <= 9)
                {
                    if (boy < 95 && boy > 120)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 120)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 120).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((95 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >= 10 && yas <= 12)
                {
                    if (boy < 100 && boy > 130)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 130)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 130).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((100 - boy).ToString()) + " cm kısa";
                    }

                }
                else if (yas >= 13 && yas <= 16)
                {
                    if (boy < 120 && boy > 160)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 160)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 160).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((120 - boy).ToString()) + " cm kısa";
                    }
                }
                else
                {
                    if (boy < 160 && boy > 170)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 170)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 170).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((160 - boy).ToString()) + " cm kısa";
                    }
                }
            }
            else
            {
                if (yas >= 0 && yas <= 2)
                {
                    if (boy < 85 && boy > 50)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 85)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 85).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((50 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >= 3 && yas <= 6)
                {
                    if (boy < 90 && boy > 105)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 105)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 105).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((90 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >= 7 && yas <= 9)
                {
                    if (boy < 95 && boy > 120)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 120)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 120).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((95 - boy).ToString()) + " cm kısa";
                    }
                }
                else if (yas >= 10 && yas <= 12)
                {
                    if (boy < 100 && boy > 130)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 130)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 130).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((100 - boy).ToString()) + " cm kısa";
                    }

                }
                else if (yas >= 13 && yas <= 16)
                {
                    if (boy < 120 && boy > 160)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 160)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 160).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((120 - boy).ToString()) + " cm kısa";
                    }
                }
                else
                {
                    if (boy < 160 && boy > 180)
                    {
                        sonuc = "Boyunuz yaşınıza göre normal";
                    }
                    else if (boy >= 180)
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((boy - 180).ToString()) + " cm uzun";
                    }
                    else
                    {
                        sonuc = "Boyunuz yaşınıza göre " + ((160 - boy).ToString()) + " cm kısa";
                    }
                }
            }

            return sonuc;
        }




            public static string nabizsonuc(double nabiz) //Nabız sonuç fonk
        {
            string sonuc;
            if (spor)
            {
                if (nabiz >= 40 && nabiz <= 60)
                {
                    sonuc = "Nabzınız normal.";
                }
                else if (nabiz < 40)
                {
                    sonuc = ("Nabzınız normalden " + (40 - nabiz).ToString() + " düşük.");
                }
                else
                {
                    sonuc = ("Nabzınız normalden " + (nabiz - 60).ToString() + " yüksek.");
                }
            }
            else if (yas == 0)
            {
                if (nabiz >= 100 && nabiz <= 160)
                {
                    sonuc = "Nabzınız normal.";
                }
                else if (nabiz < 100)
                {
                    sonuc = ("Nabzınız normalden " + (100 - nabiz).ToString() + " düşük.");
                }
                else
                {
                    sonuc = ("Nabzınız normalden " + (nabiz - 160).ToString() + " yüksek.");
                }
            }


            else if (yas>=1&&yas<=10) {
                if (Convert.ToInt32(nabiz) >= 70 && Convert.ToInt32(nabiz) <= 120)
                {
                    sonuc = "Nabzınız normal.";
                }
                else if (nabiz < 70)
                {
                    sonuc = ("Nabzınız normalden " + (70 - nabiz).ToString() + " düşük.");
                }
                else
                {
                    
                    sonuc = ("Nabzınız normalden " + (nabiz - 120).ToString() + " yüksek.");
                }
            }
                   
          else if (yas>=11 && yas <= 17)
            {
                if (nabiz >= 60 && nabiz <= 100)
                {
                    sonuc = "Nabzınız normal.";
                }
                else if (nabiz < 60)
                {
                    sonuc = ("Nabzınız normalden " + (60 - nabiz).ToString() + " düşük.");
                }
                else
                {
                    sonuc = ("Nabzınız normalden " + (nabiz - 100).ToString() + " yüksek.");
                }
            }


            else
            {
                if (nabiz >= 60 && nabiz <= 100)
                {
                    sonuc = "Nabzınız normal.";
                }
                else if (nabiz < 60)
                {
                    sonuc = ("Nabzınız normalden " + (60 - nabiz).ToString() + " düşük.");
                }
                else
                {
                    sonuc = ("Nabzınız normalden " + (nabiz - 100).ToString() + " yüksek.");
                }
            }
                                       
                return sonuc;
        } //Nabız sonuç fonk



    }
}
