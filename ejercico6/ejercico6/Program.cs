//Realizar un programa en C# que obtenga el promedio de calificaciones de un grupo 
//de N alumnos

public class ejercicio6
{
    static void Main(string[] args)
    {
        Console.Write("ingrese la cantidad de alumnos:");

        int cantidadAlumnos = int.Parse(Console.ReadLine());

        double sumaCalificcaciones = 0;

        for (int i = 0; i <= cantidadAlumnos; i++) ;
        {
            Console.Write("ingrese la cantidad de alumnos{i}:");

            double calificacion = double.Parse(Console.ReadLine());

            sumaCalificcaciones += calificacion;

        }

        double promedio = sumaCalificcaciones / cantidadAlumnos;

        Console.Write($"el promedio de calificaciones es {promedio}");





    }

}