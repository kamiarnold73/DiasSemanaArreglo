namespace DiasSemanaArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string[] diasSemana = new string[7];

            diasSemana[0] = "Lunes";
            diasSemana[1] = "Martes";
            diasSemana[2] = "Miercoles";
            diasSemana[3] = "Jueves";
            diasSemana[4] = "Viernes";
            diasSemana[5] = "Sabado";
            diasSemana[6] = "Domingo";

            string imput = Console.ReadLine();
            int.TryParse(imput, out int result);

            if (result > 0 && result <= 7)
            {
                Console.WriteLine(diasSemana[result-1]);
            }
            else 
            {
                Console.WriteLine("El dato es incorrecto");
            }
        }
    }
}
