// Problema 14: Paisaje en ASCII

// Desarrolla un programa que muestre en la consola un pequeño paisaje utilizando únicamente caracteres ASCII y colores.
// La representación debe aparecer completa al ejecutar el programa y conservar una estructura similar a la del documento.


//                                 \  |  /
//                                  .-*-.
//                                 ☼   ---
//                                  `-*-'
//                                 /  |  \
//
//                         /\                    /\
//                        /  \       /\         /  \
//                       /    \     /  \       /    \
//                      /______\___/____\_____/______\
//
//                                 /\     /\
//                                / \    / \
//                              /____\ /____\
//                              | [] | | [] |
//                              |____| |____|
//
//                    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// El paisaje debe utilizar diferentes colores en la consola para distinguir sus elementos. Como mínimo, el
// cielo o sol, las montañas, las construcciones y el agua o suelo deben utilizar colores distintos.

// ANÁLISIS
// PROBLEMA: Desarrollar un programa que muestre un paisaje hecho con carácteres ASCII y colores. El paisaje debe usar diferentes
// colores para poder distinguir el sol, montañas, construcciones y el agua.
// OBJETIVO: Asignar color a los carácteres ASCII.
// ENTRADAS: No tengo.
// SALIDAS: Casita.

//PROGRAMA:

//SOL:

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("                                                       ");
Console.ForegroundColor  = ConsoleColor.Yellow;
Console.WriteLine("                        \\  |  /                       ");
Console.ForegroundColor  = ConsoleColor.Yellow;
Console.WriteLine("                         .-*-.                         ");
Console.ForegroundColor  = ConsoleColor.Yellow;
Console.WriteLine("                       ☼   ---                         ");
Console.ForegroundColor  = ConsoleColor.Yellow;
Console.WriteLine("                         `-*-'                         ");
Console.ForegroundColor  = ConsoleColor.Yellow;
Console.WriteLine("                        /  |  \\                       ");
Console.WriteLine("                                                       ");
Console.ResetColor();

// MONTAÑAS:

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                /\\                    /\\             ");
Console.ForegroundColor  = ConsoleColor.Green;
Console.WriteLine("               /  \\       /\\         /  \\           ");
Console.ForegroundColor  = ConsoleColor.Green;
Console.WriteLine("              /    \\     /  \\       /    \\          ");
Console.ForegroundColor  = ConsoleColor.Green;
Console.WriteLine("             /______\\___/____\\_____/______\\         ");

// CASAS:

Console.WriteLine("                                                       ");
Console.ForegroundColor  = ConsoleColor.DarkRed;
Console.WriteLine("                        /\\      /\\                   ");
Console.ForegroundColor  = ConsoleColor.DarkRed;
Console.WriteLine("                       /  \\    /  \\                  ");
Console.ForegroundColor  = ConsoleColor.DarkRed;
Console.WriteLine("                      /____\\  /____\\                 ");
Console.ForegroundColor  = ConsoleColor.Black;
Console.WriteLine("                      | [] |  | [] |                   ");
Console.ForegroundColor  = ConsoleColor.Black;
Console.WriteLine("                      |____|  |____|                   ");
Console.WriteLine("                                                       ");
Console.ResetColor();

// AGUA:

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("           ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~        ");
Console.Write("                                                       ");
Console.ResetColor();
