// Это старое решение, не из первого дз, просто задание похожее, я немного его поменяла.
/*Console.Write("Insert a number: ");

int day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
case 1: Console.WriteLine("No, it's a weekday");
break;
case 2: Console.WriteLine("No, it's a weekday");
break;
case 3: Console.WriteLine("No, it's a weekday");
break;
case 4: Console.WriteLine("No, it's a weekday");
break;
case 5: Console.WriteLine("No, it's a weekday");
break;
case 6: Console.WriteLine("Yes, It's a day off");
break;
case 7: Console.WriteLine("Yes, It's a day off");
break;
default: Console.WriteLine("Error");
break;    
}*/
// Вот это новое решение, покороче, оба работают
Console.Write("Write a day number: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x < 6)
{
    System.Console.WriteLine("No, it's a weekday");
}
else
{
    System.Console.WriteLine("Yes, It's a day off");
} 




