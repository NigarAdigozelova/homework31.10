
#region 1-10 aralığında olan cüt ədədlərin ədədi ortasını tapan alqoritm yazın.
//int n = 10;
//int count = 0;
//float sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum = sum + i;
//        count++;
//    }
//}
//float avarage = sum / count;
//Console.WriteLine(avarage);
#endregion
#region Ədədin mərtəbələrinin cəmini tapan alqoritm (məsələn: 123 - 1+2+3).
int num = 123;
int rem = 0;
int sum = 0;

while (num > 0)
{
    rem = num % 10;
    sum = sum + rem;
    num = num / 10;   
}
Console.WriteLine(sum);


#endregion
