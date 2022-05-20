// See https://aka.ms/new-console-template for more information



//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".





//string pregunta = "S";
//int contador = 0;

//while (pregunta.ToUpper()!="N")
//{
//    contador++;
//    Console.Write("cual es tu nombre?");

//    string nombre = Console.ReadLine();
//    Console.WriteLine("Hola" + nombre);
//    Console.WriteLine("deseas continuar? (S/N)");
//    pregunta = Console.ReadLine();

//    if (pregunta.ToUpper()!="N")
//    {
//        Console.WriteLine("no valida");
//    }else if (pregunta.ToUpper() != "S")
//    {
//        Console.WriteLine("no valida");

//    }
//    //
//}
//    Console.WriteLine("Programa Finalizado Correctamente");



//------------------------------------------------------------


//ejemplo Alternativo


//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".


//var opcionElegida = "S";

//while (opcionElegida.ToUpper()=="S")
//{
//    //borrar la pantalla
//    Console.Clear();
//    //pekdir nombre
//    Console.WriteLine("Cual es su nobre?");
//    var nombrePersona = Console.ReadLine();

//    Console.WriteLine($"¡Hola {nombrePersona}!");
//    Console.WriteLine("Desea continuar? S/N");
//    opcionElegida = Console.ReadLine();
//}

//if (opcionElegida.ToUpper() == "N")
//{
//    Console.WriteLine("Programa finalizado correctamente");

//}

//else
//{
//    Console.WriteLine("Opcion no valida");
//}





//------------------------------------ Alternativo con Do While -------------------------------------------------



//string opcionElegida;
//do
//{
//    //borrar la pantalla
//    Console.Clear();
//    //pekdir nombre
//    Console.WriteLine("Cual es su nobre?");
//    var nombrePersona = Console.ReadLine();

//    Console.WriteLine($"¡Hola {nombrePersona}!");
//    Console.WriteLine("Desea continuar? S/N");
//    opcionElegida = Console.ReadLine();
//}
//while (opcionElegida.ToUpper() == "S");

//if (opcionElegida.ToUpper() == "N")
//{
//    Console.WriteLine("Programa finalizado correctamente");

//}

//else
//{
//    Console.WriteLine("Opcion no valida");
//}

//-------------------------------------------------------------------------------------- Ejercicio 5 -------------------------------------------------
//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.

//Nota:
//Obviamente hay que hacer un bucle y crear un contador de intentos.
//Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int contador=0;
//pekdir nombre
Console.WriteLine("Ingresa un número");
int numeroIngresado =  int.Parse(Console.ReadLine());


while (numeroIngresado == numeroSecreto)
    contador++;

if (numeroIngresado > numeroSecreto)
    {
        
        while (numeroIngresado > numeroSecreto)
        {
            
            Console.WriteLine("Es mas abajo");
            Console.WriteLine("Elige otro numero menor");
            numeroIngresado = int.Parse(Console.ReadLine());
            
        }

        if (numeroIngresado < numeroSecreto)
        {
            while (numeroIngresado < numeroSecreto)
            {

                Console.WriteLine("el numero secreto es muy mayor");
                Console.WriteLine("Elige otro numero mayor");
                numeroIngresado = int.Parse(Console.ReadLine());

            }

        }
    
}
if (numeroIngresado < numeroSecreto)
{
    while (numeroIngresado < numeroSecreto)
    {

        Console.WriteLine("el numero secreto es muy mayor");
        Console.WriteLine("Elige otro numero mayor");
        numeroIngresado = int.Parse(Console.ReadLine());

    }

}
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto} ");
Console.WriteLine($"Lo has logrado en {contador} intentos!!");








