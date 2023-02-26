// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora Basica!");
while (true)
{
    Console.WriteLine($"Eliga la oparacion a realizar\n");
    Console.WriteLine($"Opcion 1: Suma");
    Console.WriteLine($"Opcion 2: Resta");
    Console.WriteLine($"Opcion 3: Divicion");
    Console.WriteLine($"Opcion 4: Multiplicacion");
    Console.WriteLine($"\nOpcion 5: Salir");
    try
    {
        var tarea = int.Parse(Console.ReadLine());
        if (tarea >= 1 && tarea <= 5)
        {
            if (tarea.Equals(5)) break;
            realizarOperacion(tarea);
        }
        else
            Console.WriteLine($"\nOperacion invalida");
    }
    catch
    {
        Console.WriteLine($"\nOperacion invalida");
    }
    Console.WriteLine($"\nPara continuar presione enter");
    Console.ReadLine();
    Console.Clear();
}
Console.Clear();
Console.WriteLine($"\nAdios, vuelve pronto");
void realizarOperacion(int tarea)
{
    String operacion = "";
    double num1 = 0, num2 = 0, res = 0;
    Console.Write($"\nPrimer numero: ");
    num1 = double.Parse(Console.ReadLine());
    Console.Write($"\nSegundo numero: ");
    num2 = double.Parse(Console.ReadLine());
    switch (tarea)
    {
        case 1: res = num1 + num2; operacion = " + "; break;
        case 2: res = num1 - num2; operacion = " - "; break;
        case 3: res = num1 / num2; operacion = " / "; break;
        case 4: res = num1 * num2; operacion = " * "; break;
        default: break;
    }
    Console.Write($"\nEl resultado de la operacion: {num1}{operacion}{num2} = {res} ");
}