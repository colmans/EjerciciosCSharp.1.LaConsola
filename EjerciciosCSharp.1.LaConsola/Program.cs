// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//punto 1 y punto 2
Console.WriteLine("Por favor ingrese un comentario");
string ingresoDelUsuario= Console.ReadLine();
Console.WriteLine("Usted a escrito" + " " + ingresoDelUsuario);
//cree el repositorio siguiendo las instrucciones
Console.WriteLine("Gracias por su colaboracion ");


/*punto 3: 
 Lea las teclas presionadas y finalice al presionar la tecla “X”
 metodo console.readkey
Obtiene la siguiente tecla de carácter o de función presionada por el usuario
 */
Console.Write("Presione <Enter> para finalizar");
while (Console.ReadKey().Key != ConsoleKey.Enter) ;
