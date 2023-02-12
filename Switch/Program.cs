namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int a = (value / 10)*10;
            int b = value % 10;

            if(value > 9 && value < 20)
            {

                switch (value)
                {
                   
                    case 10:
                        Console.Write("десять");
                        break;
                    case 11:
                        Console.Write("одиннадцать");
                        break;
                    case 12:
                        Console.Write("двенадцать");
                        break;
                    case 13:
                        Console.Write("тринадцать");
                        break;
                    case 14:
                        Console.Write("четырнадцать");
                        break;
                    case 15:
                        Console.Write("пятнадцать");
                        break;
                    case 16:
                        Console.Write("шестнадцать");
                        break;
                    case 17:
                        Console.Write("семнадцать");
                        break;
                    case 18:
                        Console.Write("восемнадцать");
                        break;
                    case 19:
                        Console.Write("девятнатцать");
                        break;
                }
            } else
            {
                switch (a)
                {
                    case 1:
                        Console.Write("один");
                        break;
                    case 2:
                        Console.Write("два");
                        break;
                    case 3:
                        Console.Write("три");
                        break;
                    case 4:
                        Console.Write("четыре");
                        break;
                    case 5:
                        Console.Write("пять");
                        break;
                    case 6:
                        Console.Write("шесть");
                        break;
                    case 7:
                        Console.Write("семь");
                        break;
                    case 8:
                        Console.Write("восемь");
                        break;
                    case 9:
                        Console.Write("девять");
                        break;
                    case 10:
                        Console.Write("десять");
                        break;
                    case 11:
                        Console.Write("одиннадцать");
                        break;
                    case 12:
                        Console.Write("двенадцать");
                        break;
                    case 13:
                        Console.Write("тринадцать");
                        break;
                    case 14:
                        Console.Write("четырнадцать");
                        break;
                    case 15:
                        Console.Write("пятнадцать");
                        break;
                    case 16:
                        Console.Write("шестнадцать");
                        break;
                    case 17:
                        Console.Write("семнадцать");
                        break;
                    case 18:
                        Console.Write("восемнадцать");
                        break;
                    case 19:
                        Console.Write("девятнатцать");
                        break;
                    case 20:
                        Console.Write("двадцать");
                        break;
                    case 30:
                        Console.Write("тридцать");
                        break;
                    case 40:
                        Console.Write("сорок");
                        break;
                    case 50:
                        Console.Write("пятьдесят");
                        break;
                    case 60:
                        Console.Write("шестьдесят");
                        break;
                    case 70:
                        Console.Write("семьдесят");
                        break;
                    case 80:
                        Console.Write("восемьдесят");
                        break;
                    case 90:
                        Console.Write("девяносто");
                        break;


                }
                switch (b)
                {
                    case 1:
                        Console.Write("один");
                        break;
                    case 2:
                        Console.Write("два");
                        break;
                    case 3:
                        Console.Write("три");
                        break;
                    case 4:
                        Console.Write("четыре");
                        break;
                    case 5:
                        Console.Write("пять");
                        break;
                    case 6:
                        Console.Write("шесть");
                        break;
                    case 7:
                        Console.Write("семь");
                        break;
                    case 8:
                        Console.Write("восемь");
                        break;
                    case 9:
                        Console.Write("девять");
                        break;
                    case 10:
                        Console.Write("десять");
                        break;
                    case 11:
                        Console.Write("одиннадцать");
                        break;
                    case 12:
                        Console.Write("двенадцать");
                        break;
                    case 13:
                        Console.Write("тринадцать");
                        break;
                    case 14:
                        Console.Write("четырнадцать");
                        break;
                    case 15:
                        Console.Write("пятнадцать");
                        break;
                    case 16:
                        Console.Write("шестнадцать");
                        break;
                    case 17:
                        Console.Write("семнадцать");
                        break;
                    case 18:
                        Console.Write("восемнадцать");
                        break;
                    case 19:
                        Console.Write("девятнатцать");
                        break;
                    case 20:
                        Console.Write("двадцать");
                        break;
                    case 30:
                        Console.Write("тридцать");
                        break;
                    case 40:
                        Console.Write("сорок");
                        break;
                    case 50:
                        Console.Write("пятьдесят");
                        break;
                    case 60:
                        Console.Write("шестьдесят");
                        break;
                    case 70:
                        Console.Write("семьдесят");
                        break;
                    case 80:
                        Console.Write("восемьдесят");
                        break;
                    case 90:
                        Console.Write("девяносто");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}