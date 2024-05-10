
namespace CalcularSumProd.Class
{
    public class CalcSP
    {
        public void CalcularSumProd() 
        {
            decimal numero1 = 0;
            decimal numero2 = 0;
            decimal numero3 = 0;
            decimal numero4 = 0;
            decimal suma = 0;
            decimal producto = 0;
            try
            {
                Console.WriteLine("Ingrese el primer numero: ");
                numero1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer numero: ");
                numero3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto numero: ");
                numero4 = decimal.Parse(Console.ReadLine());

                suma = (numero1 + numero2);
                producto = (numero3 * numero4);

                Console.WriteLine($"La suma del primer y el segundo numero es: { suma}");
                Console.WriteLine($"El producto del tercer y cuarto numero es: { producto}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error: { ex.Message }");
            }
            

        }
    }
}
