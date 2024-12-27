
Console.WriteLine("**********************************SORU1***************************************");

Console.WriteLine("Merhaba \nNasılsın ? \nİyiyim \nSen Nasılsın ?");

Console.WriteLine("*************************SORU2************************************************");

int number = 5;
string text = "Gamze";

Console.WriteLine(number + "\n" + text);


Console.WriteLine("**********************************SORU3**************************************");

Random rnd = new Random();
int number2 = rnd.Next(1, 10);

Console.WriteLine(number2);

Console.WriteLine("*******************************SORU4********************************************");

Random rand = new Random();
int number3 = rnd.Next(1, 10);

int remainder = number3 % 3;
Console.WriteLine("--> rastgele üretilen sayı: " + number3 + "  --> 3 ile bölümünden kalan: " + remainder);

Console.WriteLine("*********************SORU5***********************************************");

Console.WriteLine("Lütfen yaşınızı giriniz.");

int age = int.Parse(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("+");
}
else if (age < 18)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("*");
}

Console.WriteLine("*****************************SORU6*****************************************");
int i = 0;
while (i < 10)
{
    Console.WriteLine($" {i + 1}.Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
    i++;
}

Console.WriteLine("*******************************SORU7***************************************");

Console.WriteLine("Bir metinsel ifade giriniz.");
string input1 = Console.ReadLine();

Console.WriteLine("Bir metinsel ifade giriniz.");
string input2 = Console.ReadLine();

string temp = input1;
input1 = input2;
input2 = temp;

Console.WriteLine($"input1: {input1} \ninput2: {input2}");

Console.WriteLine("***************************SORU8**************************************");

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();


Console.WriteLine("*************************SORU9*******************************************");

int sum(int a, int b)
{
    return a + b;
}
int result = sum(5, 7);
Console.WriteLine(result);


Console.WriteLine("*****************************SORU10**************************************");

string BoolToString()
{
    Console.Write("Lütfen true veya false girin: ");
    bool userInput = bool.Parse(Console.ReadLine());

    if (userInput==true)
    {
        return "Kullanıcı doğruyu seçti.";
    }
    else
    {
        return "Kullanıcı yanlışı seçti.";
    }
}


string result2 = BoolToString();
Console.WriteLine("Sonuç: " + result2);

Console.WriteLine("******************************SORU11******************************************");

int Age()
{
    Console.WriteLine("yaşınız nedir");
    int age1 = int.Parse(Console.ReadLine());

    Console.WriteLine("yaşınız nedir");
    int age2 = int.Parse(Console.ReadLine());

    Console.WriteLine("yaşınız nedir");
    int age3 = int.Parse(Console.ReadLine());

    int min = Math.Min(age1, age2);

    int minAge = Math.Min(min, age3);

    return minAge;

}

Console.WriteLine("En küçük yaş: " + Age());

Console.WriteLine("*******************************SORU12*****************************************");


int maxNum(int maxNumber)
{
    int[] dizi = new int[0]; 
    Console.WriteLine("İstediğiniz kadar sayı girebilirsiniz (tamam yazınca bitirebilirsiniz):");

    while (true) 
    {
        string input = Console.ReadLine()?.ToLower(); 

        if (input == "tamam") 
        {
            break;
        }
        else if (int.TryParse(input, out int number5)) 
        {
       
            Array.Resize(ref dizi, dizi.Length + 1);
            dizi[dizi.Length - 1] = number5;

            
            if (number5 > maxNumber)
            {
                maxNumber = number5;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş yaptınız. Lütfen bir sayı girin.");
        }
    }
    
    return maxNumber;
}

int maxNumber = int.MinValue; 

Console.WriteLine("Dizideki en büyük sayı: " + maxNum(maxNumber));


Console.WriteLine("*****************************SORU13*****************************************");

void Change()
{
    Console.WriteLine("Lütfen bir isim giriniz");
    string name1 = Console.ReadLine();

    Console.WriteLine("Lütfen bir isim giriniz");
    string name2 = Console.ReadLine();

    string temp = name1;
    name1 = name2;
    name2 = temp;

    Console.WriteLine("yeni name1: "+name1+"\nyeni name2: "+name2);
}

Change();


Console.WriteLine("********************************SORU14********************************");

bool TekCift()
{
    Console.WriteLine("bir sayı giriniz");
    int sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0)
    {
        Console.WriteLine("girilen sayı çifttir.");
        return true;
    }
    else
    {
        Console.WriteLine("girilen sayı tektir");
        return false;
    }

}

Console.WriteLine(TekCift());


Console.WriteLine("******************************SORU15*********************************");

double YolHesabı()

{
    Console.WriteLine("bir hız değeri giriniz (km/h cinsiden)");
    double hız = double.Parse(Console.ReadLine());

    Console.WriteLine("bir zaman değeri giriniz.('h'saat cinsinden)");
    double zaman = double.Parse(Console.ReadLine());

    double yol = hız * zaman;

    return yol;

}

Console.WriteLine("gidilen yol "+YolHesabı()+" km");

Console.WriteLine("*******************************SORU16********************************");


double DaireAlani(double yaricap)
{
    double pi = 3.14;
    double alan = pi * yaricap * yaricap;

    return alan;

}

Console.WriteLine("DAİRENİN ALANI= "+DaireAlani(5));


Console.WriteLine("*****************************SORU17********************************");

string text5 = "Zaman bir GeRi SayIm";
string upperCaseText = text5.ToUpper();
string lowerCaseText = text5.ToLower();

Console.WriteLine(upperCaseText); 
Console.WriteLine(lowerCaseText);


Console.WriteLine("*******************************SORU18***************************************");

string text2 = "   selamlar   ";
text2 = text2.Trim();

Console.WriteLine(text2); 