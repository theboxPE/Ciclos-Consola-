/* PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.
int a;
int b;

Console.WriteLine("Digite un numero");
a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Digite un numero");
b = Convert.ToInt32 (Console.ReadLine());

if(a>b) 
{
while (a>=b){
    Console.WriteLine("La secuencia de "+ a);
a--;
} 

}

else 
{
while (a<=b){
    Console.WriteLine("La secuencia de "+ a);
    a++;
}

}

Console.ReadKey();
*/

//do while
int a;
int b;

Console.WriteLine("Digite un numero");
a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Digite un numero");
b = Convert.ToInt32 (Console.ReadLine());

if(a>b) 
{
do {
    Console.WriteLine("La secuencia de "+ a);
a--;
} 
while (a>=b);
}

else 

do{
    Console.WriteLine("La secuencia de "+ a);
    a++;
}
while (a<=b);


Console.ReadKey();