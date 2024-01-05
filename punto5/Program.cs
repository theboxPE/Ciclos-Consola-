/* PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTRE EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0
int x;
int b;
b = 0;

Console.WriteLine("Digite un numero:");

x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El numero ingresado " + x + " llevado hasta su ultima expresion 0 es: ");

while (x>=b) {
Console.WriteLine(x);

x = x - 1;
}

Console.ReadKey();
*/

//do while
int x;
int b;
b = 0;

Console.WriteLine("Digite un numero:");

x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El numero ingresado " + x + " llevado hasta su ultima expresion 0 es: ");

 do{
    Console.WriteLine(x);
    x = x - 1;
 }

while (x>=b);

Console.ReadKey();