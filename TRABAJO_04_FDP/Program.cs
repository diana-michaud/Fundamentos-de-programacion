// Generar un programa que declare un entero e imprima la vida del jugador.
// 1.1 Genera un programa que declare un entero e imprima el mana del jugador.
// Pedir el nombre del jugador.
// Pedir el apodo del jugador e imprimirlo entre comillas dobles.

Console.Write("Apodo: ");
string apodo = Console.ReadLine();

Console.Write("Papoi \"La rana\" \n");

Console.Write("HP: ");
string HP = Console.ReadLine();

Console.Write("MP: ");
string MP = Console.ReadLine();


Console.WriteLine("----------------");

// Pedir MP, si es correcto, imprimir la tabla; si es incorrecto, no.

// 1. Pedir MO}
Console.Write("MP: ");
string mpBien = Console.ReadLine();
// 2. Validar que sea un numero entero
bool mpCorrecto = int.TryParse(MP, out int mp);
// 3. Si si es entero, mostrar la tabla
if (mpCorrecto)
{
    Console.WriteLine("n");
    Console.WriteLine(nombre + "\" + apodo + "\"");
    Console.WriteLine("HP: " + HP);
    Console.WriteLine("MP: " + MP);
}
// 4. Si no es entero, mostrar mensaje de error



