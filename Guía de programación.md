# GUÍA DE PROGRAMACIÓN

## Explicar que es y para qué sirve `Console.Write` y `Console.WriteLine`
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
\" o \' - Permite usar comillas dobles o simples dentro de un texto delimitado dentro de ellas sin necesidad de romper el código.
\\ - Muestra una barra invertida en la pantalla.