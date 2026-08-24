// VARIABLES DE TIPO EXPLICITO - Agregar 2 más
Console.WriteLine("Variables de tipo explicito");
sbyte sbyteVal = 1;
Console.WriteLine("Tipo de sbyteVal: " + sbyteVal.GetType());

string stringVal = "Papoi";
Console.WriteLine("Tipo de stringVal: " + stringVal.GetType());
bool boolVal = true;
Console.WriteLine("Tipo de boolVal: " + boolVal.GetType());
Console.WriteLine("------------------------");

// VARIABLES DE TIPO IMPLICITO - Agregar 2 más
Console.WriteLine("Variables de tipo implicito");
var num1 = 1;
Console.WriteLine("Tipo de num1: " + num1.GetType());

var num2 = 1_000_000_000_000_000_000;
Console.WriteLine("Tipo de num2: " + num2.GetType());

var num3 = ("Texto tipo implicito");
Console.WriteLine("Tipo de texto: " + num3.GetType());
var decimalImp = 3.1416;
Console.WriteLine("Tipo de decimalImp: " + decimalImp.GetType());
Console.WriteLine("------------------------");

// CONSTANTES - Agregar 2 más
Console.WriteLine("Constantes");
const sbyte MIN_VALUE_SBYTE = -128;
Console.WriteLine("Tipo de MIN_VALUE_sbyte: " + MIN_VALUE_SBYTE.GetType());

const sbyte MAX_VALUE_SBYTE = 127;
Console.WriteLine("Tipo de MAX_VALUE_sbyte: " + MAX_VALUE_SBYTE.GetType());
const string MIN_VALUE_STRING = "Papoi";
Console.WriteLine("Tipo de string: " + MIN_VALUE_STRING.GetType());

