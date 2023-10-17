namespace OrdenaEjercicio04;

///<summary>
///
/// 
/// </summary>
/// 

class Pogram
{


    static void Main(String[] args)
    {

        int Valor01, Valor02, Valor03;

        Console.WriteLine("Introduzca un Primer Numero");
        Valor01 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca un Segundo Numero");
        Valor02 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca un Tercer Numero");
        Valor03 = int.Parse(Console.ReadLine());


        if (Valor02 > Valor01 && Valor02 > Valor03)
        {

            if (Valor01 > Valor03)
            {
                Console.WriteLine(Valor02);
                Console.WriteLine(Valor01);
                Console.WriteLine(Valor03);
            }


            else

            {
                Console.WriteLine(Valor02);
                Console.WriteLine(Valor03);
                Console.WriteLine(Valor01);
            }

        }


        if (Valor03 > Valor01 && Valor03 > Valor02)
        {

            if (Valor01 > Valor02)
            {
                Console.WriteLine(Valor03);
                Console.WriteLine(Valor01);
                Console.WriteLine(Valor02);
            }


            else

            {
                Console.WriteLine(Valor03);
                Console.WriteLine(Valor02);
                Console.WriteLine(Valor01);
            }

        }

    }
}



