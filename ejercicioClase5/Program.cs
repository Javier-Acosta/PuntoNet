// See https://aka.ms/new-console-template for more information



//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".


 


string pregunta = "S";
int contador = 0;

while (pregunta.ToUpper()!="N")
{
    contador++;
    Console.Write("cual es tu nombre?");

    string nombre = Console.ReadLine();
    Console.WriteLine("Hola" + nombre);
    Console.WriteLine("deseas continuar? (S/N)");
    pregunta = Console.ReadLine();
    
    if (pregunta.ToUpper()!="N")
    {
        Console.WriteLine("no valida");
    }else if (pregunta.ToUpper() != "S")
    {
        Console.WriteLine("no valida");
        
    }
    //
}
    Console.WriteLine("Programa Finalizado Correctamente");


