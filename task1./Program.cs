using System.Drawing;

namespace task1_;

class Program
{
    static void Main(string[] args)


    {/////Tapşırıq1 ATM Bankomatik tətbiqi
     //Sizdən bir proqram təminatı istənilir.Proqram təminatında ATM üçün kart şifrə sorğulama prosesinin
     //hazırlanması əhatə edilməlidir.
     //Proqram başladıldığında sizdən şifrə girmənizi tələb edilir.Şifrə doğru isə sistemə daxil olursunuz və sizin
     //balansını ekrana yazır
     //Şifrə səhv daxil etdikdə proqram təminatı sizdən 2 dəfə yenidən cəhd etmənizi istəyir yenidən səhv
     //cəhdlərin sayı 3-ü keçdikdə kartınız proqram təminatı tərəfindən bloklandığı yazılır.
     //Əgər siz 2-ci və ya 3-ci cəhdinizdə doğru şifrə girsəniz proqram səhv cəhdlərin sayğacını sıfırlayacaqdır.
     //Sizin yenidən 3 səhv cəhd haqqı qazanmış olursunuz.
     //Proqram təminatını hazırlarkən ola biləcək bütün ssenarilər nəzərə alınmalıdır.




        bool flag = true;
        int cehdSayi = 3;
        int balans = 1000;
        int sifre = 1234;

        while (flag)
        {



            Console.WriteLine("zehmet olmasa sifrenizi daxil edin");
            int userSifre = int.Parse(Console.ReadLine());

            if (userSifre == sifre)
            {
                cehdSayi = 3;
                Console.WriteLine("sizin balansiniz:" + balans);

            }


            else
            {
                Console.WriteLine("sifre yanlisdi tekrar cehd edin");
                cehdSayi--;
                Console.WriteLine("sizin qalan cehdinizin sayi:"+cehdSayi);
                

            }

            if (cehdSayi==0)
            {
                Console.WriteLine("3 defeden artiq sehv sifre yazdiginiz ucun  kartiniz bloklanmisdir");

                flag = false;
            }

            Console.WriteLine("sistemden cixmaq isdeyirsizmi(y/n)");

            char cavab = char.Parse(Console.ReadLine());
            if (cavab=='y')
            {
                flag = false;
            }
            
            
        }
        Console.WriteLine("siz sistemden cixdiniz");
            
    }
}










