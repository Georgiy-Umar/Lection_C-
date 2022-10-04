Console.Write("Enter a number of the weeks day (from 1 to 7): ");
int weekDay = Convert.ToInt32(Console.ReadLine());
while (weekDay < 1| weekDay > 7) 
{
    Console.WriteLine("You did Enter the incorrect number, repeat your enter!: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 1) Console.WriteLine("Monday");
else if (weekDay == 2) Console.WriteLine("Tuesday");
else if (weekDay == 3) Console.WriteLine("Thirsday");
else if (weekDay == 4) Console.WriteLine("Wednesday");
else if (weekDay == 5) Console.WriteLine("Friday");
else if (weekDay == 6) Console.WriteLine("Saturday");
else if (weekDay == 7) Console.WriteLine("Sunday");

    Console.WriteLine("Great! Thank you Umar");