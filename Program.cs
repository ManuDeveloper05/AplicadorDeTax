using System.Runtime.InteropServices;

namespace AplicadorDeTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* CALCULADORA DE IMPUESTOS SOBRE LAS VENTAS *******");

            Console.WriteLine("Ingrese el importe");
           string cantidad = Console.ReadLine();
            double importe = int.Parse(cantidad);
            Console.WriteLine("Ingrese el codigo de region (En letras)");
            string region= Console.ReadLine();
            region = region.ToUpper();
            // Convertir entrada a mayuscula

            switch (region)
            {
                case "HU":
                    
                    Console.WriteLine("Debe pagar "+ ((importe*0.27)+importe) + " con impuestos aplicados");
                    break;

                case "HR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.25) + importe) + " con impuestos aplicados");
                    break;

                case "DK":

                    Console.WriteLine("Debe pagar " + ((importe * 0.25) + importe) + " con impuestos aplicados");
                    break;

                case "NO":

                    Console.WriteLine("Debe pagar " + ((importe * 0.25) + importe) + " con impuestos aplicados");
                    break;

                case "SE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.25) + importe) + " con impuestos aplicados");
                    break;

                case "FI":

                    Console.WriteLine("Debe pagar " + ((importe * 0.24) + importe) + " con impuestos aplicados");
                    break;

                case "IS":

                    Console.WriteLine("Debe pagar " + ((importe * 0.24) + importe) + " con impuestos aplicados");
                    break;

                case "RO":

                    Console.WriteLine("Debe pagar " + ((importe * 0.24) + importe) + " con impuestos aplicados");
                    break;

                case "GR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.23) + importe) + " con impuestos aplicados");
                    break;

                case "IE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.23) + importe) + " con impuestos aplicados");
                    break;

                case "PL":

                    Console.WriteLine("Debe pagar " + ((importe * 0.23) + importe) + " con impuestos aplicados");
                    break;

                case "PT":

                    Console.WriteLine("Debe pagar " + ((importe * 0.23) + importe) + " con impuestos aplicados");
                    break;

                case "IT":

                    Console.WriteLine("Debe pagar " + ((importe * 0.22) + importe) + " con impuestos aplicados");
                    break;


                case "UY":

                    Console.WriteLine("Debe pagar " + ((importe * 0.22) + importe) + " con impuestos aplicados");
                    break;


                case "UE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.216) + importe) + " con impuestos aplicados");
                    break;

                case "AR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.21) + importe) + " con impuestos aplicados");
                    break;

                case "BE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.21) + importe) + " con impuestos aplicados");
                    break;

                case "NL":

                    Console.WriteLine("Debe pagar " + ((importe * 0.21) + importe) + " con impuestos aplicados");
                    break;

                case "ES":

                    Console.WriteLine("Debe pagar " + ((importe * 0.21) + importe) + " con impuestos aplicados");
                    break;

                case "FR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.20) + importe) + " con impuestos aplicados");
                    break;

                case "MA":

                    Console.WriteLine("Debe pagar " + ((importe * 0.20) + importe) + " con impuestos aplicados");
                    break;

                case "GB":

                    Console.WriteLine("Debe pagar " + ((importe * 0.20) + importe) + " con impuestos aplicados");
                    break;

                case "CL":

                    Console.WriteLine("Debe pagar " + ((importe * 0.19) + importe) + " con impuestos aplicados");
                    break;

                case "DE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.19) + importe) + " con impuestos aplicados");
                    break;

                case "BR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.17) + importe) + " con impuestos aplicados");
                    break;

                case "PE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.18) + importe) + " con impuestos aplicados");
                    break;

                case "DO":

                    Console.WriteLine("Debe pagar " + ((importe * 0.18) + importe) + " con impuestos aplicados");
                    break;

                case "RU":

                    Console.WriteLine("Debe pagar " + ((importe * 0.18) + importe) + " con impuestos aplicados");
                    break;

                case "CN":

                    Console.WriteLine("Debe pagar " + ((importe * 0.17) + importe) + " con impuestos aplicados");
                    break;

                case "MX":

                    Console.WriteLine("Debe pagar " + ((importe * 0.16) + importe) + " con impuestos aplicados");
                    break;

                case "CO":

                    Console.WriteLine("Debe pagar " + ((importe * 0.16) + importe) + " con impuestos aplicados");
                    break;

                case "HN":

                    Console.WriteLine("Debe pagar " + ((importe * 0.15) + importe) + " con impuestos aplicados");
                    break;

                case "NI":

                    Console.WriteLine("Debe pagar " + ((importe * 0.15) + importe) + " con impuestos aplicados");
                    break;

                case "IN":

                    Console.WriteLine("Debe pagar " + ((importe * 0.12) + importe) + " con impuestos aplicados");
                    break;

                case "ZA":

                    Console.WriteLine("Debe pagar " + ((importe * 0.14) + importe) + " con impuestos aplicados");
                    break;

                case "BO":

                    Console.WriteLine("Debe pagar " + ((importe * 0.13) + importe) + " con impuestos aplicados");
                    break;

                case "CR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.13) + importe) + " con impuestos aplicados");
                    break;

                case "SV":

                    Console.WriteLine("Debe pagar " + ((importe * 0.13) + importe) + " con impuestos aplicados");
                    break;

                case "EC":

                    Console.WriteLine("Debe pagar " + ((importe * 0.12) + importe) + " con impuestos aplicados");
                    break;

                case "GT":

                    Console.WriteLine("Debe pagar " + ((importe * 0.12) + importe) + " con impuestos aplicados");
                    break;

                case "VE":

                    Console.WriteLine("Debe pagar " + ((importe * 0.12) + importe) + " con impuestos aplicados");
                    break;

                case "PR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.115) + importe) + " con impuestos aplicados");
                    break;

                case "AU":

                    Console.WriteLine("Debe pagar " + ((importe * 0.10) + importe) + " con impuestos aplicados");
                    break;

                case "KR":

                    Console.WriteLine("Debe pagar " + ((importe * 0.10) + importe) + " con impuestos aplicados");
                    break;

                case "PY":

                    Console.WriteLine("Debe pagar " + ((importe * 0.10) + importe) + " con impuestos aplicados");
                    break;

                case "JP":

                    Console.WriteLine("Debe pagar " + ((importe * 0.8) + importe) + " con impuestos aplicados");
                    break;

                case "CH":

                    Console.WriteLine("Debe pagar " + ((importe * 0.8) + importe) + " con impuestos aplicados");
                    break;

                case "PA":

                    Console.WriteLine("Debe pagar " + ((importe * 0.7) + importe) + " con impuestos aplicados");
                    break;

                case "CA":

                    Console.WriteLine("Debe pagar " + ((importe * 0.5) + importe) + " con impuestos aplicados");
                    break;

                case "US":

                    Console.WriteLine("Debe pagar " + ((importe * 0.117) + importe) + " con impuestos aplicados");
                    break;


            }
        }
        


        
    }
}