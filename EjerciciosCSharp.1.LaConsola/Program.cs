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

Console.Write("Presione <x> para finalizar");
while (Console.ReadKey().Key != ConsoleKey.X);*/

/*punto 4:
 * permita el ingreso de frases finalizando cuando el usuario ingresa fin
 * no lo pude resolver

Console.WriteLine("Escriba fin para terminar");  */

/*punto 5:
 */

        ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do
        {
            cki = Console.ReadKey();
            Console.Write(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);
 
// This example displays output similar to the following:
//       Press any combination of CTL, ALT, and SHIFT, and a console key.
//       Press the Escape (Esc) key to quit:
//
//       a --- You pressed A
//       k --- You pressed ALT+K
//       ► --- You pressed CTL+P
//         --- You pressed RightArrow
//       R --- You pressed SHIFT+R
//                --- You pressed CTL+I
//       j --- You pressed ALT+J
//       O --- You pressed SHIFT+O
//       § --- You pressed CTL+U
