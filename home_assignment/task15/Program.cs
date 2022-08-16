Console.WriteLine("введите день недели цифрой от 1 до 7: ");
int x = int.Parse(Console.ReadLine());
if(x<=7) 
{
    if(x<6)
    Console.WriteLine("будний день, иди батрачить!");
    else
    Console.WriteLine("ура, выходной!");
}
else Console.WriteLine("На Земле в неделе только 7 дней, хитрюга");