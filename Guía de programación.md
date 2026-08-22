# GUÍA DE PROGRAMACIÓN

### Explicar que es y para qué sirve `Console.Write` y `Console.WriteLine`
`Console.Write` y `Console.WriteLine` son comandos que sirven para mostrar cualquier texto en la pantalla. La diferencia principal es que `Console.Write` deja el cursor en la misma linea, y `Console.WriteLine` te lleva a la siguiente linea de forma automática en cuanto terminas de escribir.

CÓDIGO
```csharp
Console.Write("Hola");
Console.Write(", ");
Console.Write("Diana!");
```
-----

### SECUENCIAS DE ESCAPE
Una secuencia de escape se usa para representar caracteres especiales, saltos de linea.

```csharp
\n - Crea un salto de linea.
\t - Inserta una tabulación horizontal (Espacio grande).
\" o \' - Permite usar comillas dobles o simples dentro de un texto delimitado dentro de ellas sin 
necesidad de romper el código.
\\ - Muestra una barra invertida en la pantalla.
```
-----

### COLORES DE FONDO Y TEXTO
Los colores de fondo y texto sirven para dar alertas visuales instantáneas (como rojo para error o verde para éxito) y guiar la vista del usuario para que el programa sea más fácil de leer.
```csharp
- Console.ForegroundColor - Sirve para cambiar el color del texto. Todo lo escrito en la linea
siguiente de este comando, tendrá el color que elija.
- Console.BackgroundColor - Sirve para cambiar el color del fondo de las letras. Funciona como un 
marcador y resaltador de textos.
- Console.Color.(Color) - Es la lista de colores predefinidos. Por ejemplo: "Yellow", "Red", 
"Dark blue", "Green", etc.
- Console.ReserColor() - Apaga el color que estabas usando y regrsa al color base. Te permite pintar
una palabra de un color y asegurarte de que la siguiente palabra vuelva a la normalidad 
automáticamente.
```