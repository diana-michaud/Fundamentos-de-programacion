// Variables de tipo explicito
sbyte sbyteVal = 1;
Console.WriteLine("Tipo de sbyteVal: " + sbyteVal.GetType());

// Variables de tipo implicito
var num1 = 1;
Console.WriteLine("Tipo de num1: " + num1.GetType());

var num2 = 1_000_000_000_000_000_000;
Console.WriteLine("Tipo de num2: " + num2.GetType());

// Constantes
const sbyte MIN_VALUE_SBYTE = -128;
Console.WriteLine("Tipo de MIN_VALUE_sbyte: " + MIN_VALUE_SBYTE.GetType());
