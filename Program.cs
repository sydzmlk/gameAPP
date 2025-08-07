using GameApp;
using System.ComponentModel.Design;
using System.Diagnostics;
int value = 0;
int count = 3;
int count2 = 2;
for (; ; )
{
    try
    {
        Gamerandom gamerandom = new Gamerandom();
        int result = gamerandom.getRandom(1, 20);
        Menu menu = new Menu();
        Base @base = new Base();
        int cavab = Convert.ToInt32(Console.ReadLine());
        if (cavab > 4) Console.WriteLine("Secdiyiniz reqem 0-3 araliginda olmalidir!");
        switch (cavab)
        {
            case 1:
                @base.Hardway(result);
                Console.WriteLine("Cavabinizi daxil edin:");
                int answer1 = Convert.ToInt32(Console.ReadLine());
                if (answer1 == result) { value += 10; Console.WriteLine($"Tebrikler cavabiniz dogrudur: {answer1},Toplam baliniz: {value}"); }
                if (answer1 != result) { Console.WriteLine($"Cavabiniz yalnisdir: {answer1},Toplam baliniz: {value}");
                    Console.WriteLine($"Dogru cavab: {result}");
                }
                int a = yesOrNo();
                if (a == 1) Console.WriteLine("-----------------------------------------------------------------------");
                if (a == 2) { Console.WriteLine("Cixisiniz icra olunur..."); return; }
                break;
                case 2:
                Base case2 = new case2();
                case2.Hardway(result);
                bool resume2 = getanswer2(result);
                int b = yesOrNo();
                if (b == 2) { Console.WriteLine("Cixisiniz icra olunur..."); return; }
                break;
            case 3:
                Base case3 = new case3();
                case3.Hardway(result);
                bool resume = getanswer(result);
                int c = yesOrNo();
                if (c == 2) { Console.WriteLine("Cixisiniz icra olunur..."); return; }
                break;
            case 4:
                Console.WriteLine("Cixisiniz icra olunur...");
                return;

        }


    }
    catch
    {
        Console.WriteLine("Boslug ve ya herf daxil ede bilmezsiniz!!!");
        Console.WriteLine("---------------------------------------------------");
    }
}

int yesOrNo()
{
    Console.WriteLine("Oyuna davam etmek isteyirsiniz mi?");
    Console.WriteLine("1-Beli");
    Console.WriteLine("2-Xeyr");
    int result = Convert.ToInt32(Console.ReadLine());
    if (result != 1 && result != 2)
    {
        Console.WriteLine("Cavabiniz uygun gelmediyi ucun,cixisiniz icra olundu...");
    }
    return result;
}
bool getanswer(int x)
{
    Console.WriteLine("Cavabiniz nedir?");
    int answer1 = Convert.ToInt32(Console.ReadLine());
    if (answer1 == x)
    {
        value += 3;
        Console.WriteLine($"Tebrikler cavabiniz dogrudur :{answer1} Toplam baliniz :{value}");
        return false; 
    }

    count--;
    Console.WriteLine($"Cavabiniz sehvdir:{answer1} qalan cehd haqqiniz: {count}");
    if (count == 0)
    {
        Console.WriteLine("Cehd haqqiniz bitdi, oyun bitdi!");
        return true; 
    }

    int answer2 = Convert.ToInt32(Console.ReadLine());
    if (answer2 == x)
    {
        value += 3;
        Console.WriteLine($"Tebrikler cavabiniz dogrudur :{answer2} Toplam baliniz :{value}");
        return false;
    }

    count--;
    Console.WriteLine($"Cavabiniz sehvdir:{answer2} qalan cehd haqqiniz: {count}");
    if (count == 0)
    {
        Console.WriteLine("Cehd haqqiniz bitdi, oyun bitdi!");
        return true;
    }
    int answer3 = Convert.ToInt32(Console.ReadLine());
    if (answer3 == x)
    {
        value += 3;
        Console.WriteLine($"Tebrikler cavabiniz dogrudur :{answer3} Toplam baliniz :{value}");
        return false;
    }

    count--;
    Console.WriteLine($"Cavabiniz sehvdir:{answer3} qalan cehd haqqiniz: {count}");
    if (count == 0)
    {
        Console.WriteLine($"Cehd haqqiniz bitdi!Dogru cavab: {x} Toplam baliniz: {value}");
        return true;
    }

    return false;
}

bool getanswer2(int x)
{
    Console.WriteLine("Cavabiniz nedir?");
    int answer1 = Convert.ToInt32(Console.ReadLine());
    if (answer1 == x)
    {
        value += 5;
        Console.WriteLine($"Tebrikler cavabiniz dogrudur :{answer1} Toplam baliniz :{value}");
        return false;
    }

    count2--;
    Console.WriteLine($"Cavabiniz sehvdir:{answer1} qalan cehd haqqiniz: {count2}");
    if (count2 == 0)
    {
        Console.WriteLine("Cehd haqqiniz bitdi, oyun bitdi!");
        return true;
    }

    int answer2 = Convert.ToInt32(Console.ReadLine());
    if (answer2 == x)
    {
        value += 5;
        Console.WriteLine($"Tebrikler cavabiniz dogrudur :{answer2} Toplam baliniz :{value}");
        return false;
    }
    count2--;
    Console.WriteLine($"Cavabiniz sehvdir:{answer2} qalan cehd haqqiniz: {count2}");
    if (count2 == 0)
    {
        Console.WriteLine($"Cehd haqqiniz bitdi!Dogru cavab: {x} Toplam baliniz: {value}");
        return true;
    }
    return false ;
}

