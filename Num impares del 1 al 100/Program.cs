/* PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
int x;
x = 1;
			
while (x<=100) {
Console.WriteLine(x);

x = x + 2;

}
Console.ReadKey();
*/

//do while
int x;
x = 0;

do
{
    if (x % 2 == 1)
    {
        Console.WriteLine(x);
         
    }
    x++;
} while (x<=100);

Console.ReadKey();