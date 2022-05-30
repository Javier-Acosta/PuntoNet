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

//-------------------------------------------------------------------------------------- Ejercicio 6 -------------------------------------------------
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

//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);
//int contador=0;
////pekdir nombre
//Console.WriteLine("Ingresa un número");
//int numeroIngresado =  int.Parse(Console.ReadLine());


//while (numeroIngresado == numeroSecreto)
//    contador++;

//if (numeroIngresado > numeroSecreto)
//    {

//        while (numeroIngresado > numeroSecreto)
//        {

//            Console.WriteLine("Es mas abajo");
//            Console.WriteLine("Elige otro numero menor");
//            numeroIngresado = int.Parse(Console.ReadLine());

//        }

//        if (numeroIngresado < numeroSecreto)
//        {
//            while (numeroIngresado < numeroSecreto)
//            {

//                Console.WriteLine("el numero secreto es muy mayor");
//                Console.WriteLine("Elige otro numero mayor");
//                numeroIngresado = int.Parse(Console.ReadLine());

//            }

//        }

//}
//if (numeroIngresado < numeroSecreto)
//{
//    while (numeroIngresado < numeroSecreto)
//    {

//        Console.WriteLine("el numero secreto es muy mayor");
//        Console.WriteLine("Elige otro numero mayor");
//        numeroIngresado = int.Parse(Console.ReadLine());

//    }

//}
//Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto} ");
//Console.WriteLine($"Lo has logrado en {contador} intentos!!");



//--------------------------------------------------------------------Ejercicio 7 -------------------------------------------------------------------




//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.



//int[] numeros = new int[10];
//Console.WriteLine($"Por favor ingrese {numeros.Length} números");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"por favor ingresar el número: {i+1}");
//    numeros[i] = int.Parse(Console.ReadLine());
//}

//// La Suma
//int suma = 0;
//for (int i = 0; i < 10; i++)
//{
//    suma+=numeros[i];
//}


////El Mayor
//int mayor=numeros.Length;

//for (int i = 0; i < numeros.Length; i++)
//{
//    if (numeros[i] > mayor)
//    {
//        mayor= numeros[i];
//    }
//}

////El Menor
//int menor=numeros.Length;
//for (int i = 0; i < numeros.Length; i++)
//{
//    if (numeros[i] < menor)

//    {
//        menor= numeros[i];
//    }


//}


//// El Promedio
//int promedio=numeros.Length;

//for (int i = 0; i < numeros.Length; i++)
//{
//    promedio = suma / 10;
//}


//// Mostrar por pantalla

//Console.WriteLine($"el mayor es : {mayor}");
//Console.WriteLine($"el menor es : {menor}");
//Console.WriteLine($"el promedio es : {promedio}");
//Console.WriteLine($"la suma de todos los número es {suma}");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Estos son todos los numeros ingresados {numeros[i]}");
//}


//------------------------------------------------------ Clase 8 ----------------------------------------------------------

//Console.WriteLine("Ingrese las notas de los examenes");

//Console.WriteLine("Ingrese la cantidad de alumnos");
//int cantidadAlumnos = int.Parse(Console.ReadLine());
//Console.WriteLine("ingrese la cantidad de notas por alumnos");
//int cantidadNotas = int.Parse(Console.ReadLine());


//int[,] notas = new int[cantidadNotas, cantidadAlumnos];
////Cantidad filas
//int lengthFiles=notas.GetUpperBound(0)+1;
////Cantidad de columnas  
//int legnthColumnas = notas.GetUpperBound(1) + 1;



//for (int columna = 0; columna < legnthColumnas; columna++)
//{
//    Console.WriteLine();
//    Console.WriteLine($"NOtas del Alumno N°: {columna +1}");

//    for (int filas = 0; filas < lengthFiles; filas++)
//    {
//        Console.WriteLine($"Cargue la nota N: {filas+1}:");
//        notas[filas,columna] = int.Parse(Console.ReadLine());
//    }
//}



////Recorrer las columnas
//for (int columna = 0; columna < legnthColumnas; columna++)
//{
//    Console.WriteLine("===================================");
//    Console.WriteLine();
//    Console.WriteLine($"NOtas del Alumno N°: {columna + 1}");

//    for (int filas = 0; filas < lengthFiles; filas++)
//    {
//        Console.WriteLine($"la nota N° {filas +1}:");
//        Console.WriteLine(notas[filas,columna]);
//    }
//}


//Console.ReadKey();

//------------------------------------------------------ Ejercicio 8 -----------------------------------------------

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios

//Console.WriteLine("Ingrese el tamaño de fila");
//int fila =int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese numero de columna");
//int columna = int.Parse(Console.ReadLine());
//int[,] numeros = new int[fila,columna];

//double promedio = numeros.Length;

////Cantidad filas
//int lengthFiles = numeros.GetUpperBound(0) +1;
////Cantidad de columnas  
//int legnthColumnas = numeros.GetUpperBound(1) +1;

//for (int col = 0; col < legnthColumnas; col++)
//{
//    Console.WriteLine();
//    Console.WriteLine($"valor ingresado {col +1}:");

//    for (int fil = 0; fil < lengthFiles; fil++)
//    {
//        Console.WriteLine($"ingrese número{fil+1}");
//        numeros[fil,col] = int.Parse(Console.ReadLine());
//    }

//}
//    // El Promedio


//    for (int i = 0; i < legnthColumnas; i++)
//    {
//        promedio = fila / columna;
//    }


//for (int col = 0; col < legnthColumnas; col++)
//{
//    Console.WriteLine();
//    Console.WriteLine("===============================");
//    Console.WriteLine($"valor ingresado {col + 1}:");

//    for (int fil = 0; fil < lengthFiles; fil++)
//    {
//        Console.WriteLine($"ingrese número{fil + 1}");
//        Console.WriteLine(numeros[fil,col]);
//        Console.WriteLine($"El promedio es : {promedio}");
//    }
//}
//Console.ReadKey();


//------------------------------------------------- Clase 9 --------------------------------------------------
// repaso 




// Control + RR  - para modificar todo ala vez

//Console.WriteLine("Ingrese cantidad de numeros pr,omos deseados");
//var n = int.Parse(Console.ReadLine());

//int[] primos = new int[n];
//int posicion=0;
//int aux=0;
//int numero = 1;
//while (posicion < primos.Length)
//{
//    aux = 0;
//    for (int i = 1; i <= numero; i++)
//    {
//        if (numero%i ==0)
//        {
//            aux++;
//        }

//    }
//        if (aux==2)
//        {
//            primos[posicion]= numero;
//            posicion++;
//        }
//        numero++;
        

//}
//foreach (int i in primos)
//{
//    Console.WriteLine(i);
//}
//Console.ReadKey();  



//---------------------------------------------------------------- Clase 10 ---------------------------

//Array 
//    listas
//    cola
//    pila
//    diccionario


//var miArray = new int[10];

//var ListaNombres= new List<string>();
//Console.WriteLine("Bienvenido a Listas.");
//Console.WriteLine("Sleccione una de las siguientes opciones");
//Console.WriteLine("1-Agregar un elemento");
//var entradaUsuario = Console.ReadLine();

//switch (entradaUsuario)
//{
//    //default:
//}
//var nuevoNombre = Console.ReadLine();
