// EJEMPLO: Obtener y mostrar los valores mínimos y máximos de un tipo de dato
sbyte minValueSbyte = sbyte.MinValue;
sbyte maxValueSbyte = sbyte.MaxValue;

Console.WriteLine("SBYTE:");
Console.WriteLine("MinValueSbyte: " + minValueSbyte);
Console.WriteLine("MaxValueSbyte: " + maxValueSbyte);

// Símbolo de la suma? +
// Símbolo de la resta -
// Símbolo de la multiplicación *
// Símbolo de la división /

// EJERCICIO 1: Utilizar dos tipos de datos diferentes al anterior,
// uno entero y otro decimal, y mostrar sus valores min y max.
// 1. Mostrar los valores mínimos y máximos
// 2. Multiplicar el valor máximo por 10 y mostrar el resultado
// 3. Multiplicar el valor mínimo por 10 y mostrar el resultado


// TIPO DE ENTERO: Byte

Byte minValueByte = byte.MinValue;
Byte maxValueByte = byte.MaxValue;

Console.WriteLine("BYTE");
Console.WriteLine("MinValue: " + minValueByte);
Console.WriteLine("MaxValue: " + maxValueByte);

Console.WriteLine(Byte.MinValue * 10);
Console.WriteLine(Byte.MaxValue * 10);


// TIPO DE ENTERO: Int

int minValueInt = int.MinValue;
int maxValueInt = int.MaxValue;

Console.WriteLine("INT");
Console.WriteLine("MinValue: " + minValueInt);
Console.WriteLine("MaxValue: " + maxValueInt);

Console.WriteLine(minValueInt * 10);
Console.WriteLine(maxValueInt * 10);


