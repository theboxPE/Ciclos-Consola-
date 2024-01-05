/* PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.
Console.WriteLine("Digite un numero:");
int num;
num = Convert.ToInt32(Console.ReadLine());

int resul;  
resul= num*5;
if (resul%2==0){
    while(num!=resul+1){
        Console.WriteLine(num);
        num++;
    }
}
else
if (resul%2!=0){
    while(resul!=num-1){
        Console.WriteLine(resul);
        resul--;
 }
}
*/

//do while
int num;
int resul;
Console.WriteLine("Digite un numero:");

num = Convert.ToInt32(Console.ReadLine());

  
resul= num*5;

if (resul%2==0)
    do{
        Console.WriteLine(num);
        num++;
    }
while(num!=resul+1);

else
if (resul%2!=0)
    do{
        Console.WriteLine(resul);
        resul--;
 }

while(resul!=num-1);

Console.ReadKey();