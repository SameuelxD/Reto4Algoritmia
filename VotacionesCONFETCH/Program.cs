internal class Program
{
    private static void Main(string[] args)
    {
        bool bandera1 = true;
        int opcion;
        int cantidadUniversidades = 0;
        List<string> Universidades = new List<string>();
        bool bandera2 = true;
        List<string> votos = new List<string>();
        while (bandera1)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Ingresar cantidad de universidades que participan.");
            Console.WriteLine("2.Ingresar nombres de cada universidad.");
            Console.WriteLine("3.Ingresar votos de alumnos.");
            Console.WriteLine("4.Mostrar resultados finales de la votacion.");
            Console.WriteLine("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    if (cantidadUniversidades == 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de Universidades que participan: ");
                        cantidadUniversidades = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Error ya se ingreso una cantidad de universidades");
                    }
                    break;
                case 2:
                    if (bandera2)
                    {
                        for (int i = 0; i <= cantidadUniversidades; i++)
                        {
                            Console.WriteLine($"Ingrese el nombre de la Universidad {i + 1}");
                            string nombreUniversidad = Console.ReadLine();
                            Universidades.Add(nombreUniversidad);
                        }
                        bandera2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Error ya se ingresaron los nombres de las Universidades");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Ingrese el nombre de la Universidad para agregar votos: ");
                    string universidad = Console.ReadLine();
                    if (Universidades.Contains(universidad) && !votos.Contains(universidad))
                    {
                        votos.Add(universidad);
                        Console.WriteLine("Ingrese el voto para el alumno");
                        string voto = Console.ReadLine();
                        while (voto != "X" || voto == "A" || voto == "R" || voto == "N" || voto == "B")
                        {
                            Console.WriteLine("Ingrese el voto para el alumno");
                            voto = Console.ReadLine();
                            votos.Add(voto);
                        }
                    }

                    break;
                case 4:
                    Console.WriteLine($"Numero de Universidades: {cantidadUniversidades}");
                    for(int j=0;j<=Universidades.Count();j++)
                    {
                        Console.WriteLine($"Universidad: {Universidades[j]}");
                        for(int i=0;i<=votos.Count();i++){
                            Console.WriteLine($"Voto {i+1}: {votos[i]}");
                        }

                    }
                break;

            }


        }
    }
}