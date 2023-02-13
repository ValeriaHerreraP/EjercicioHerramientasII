//Numero sin cifras repetidas y debe ingrear el numero con 5 cifras, no debe repetir valores
//El numero debe ser de 5 cifras, si no debe salir error la persona debe adivinarlo
//debe mostrar los numeros que son literalmente iguales, si esta en la misma posicion debe colocar un mas y al que no un menos
// si no lo adivino debe volver a intentar.

int verdad = 0;
int [] numeroReal = {1,2,3,8,9};
int[] numeros = new int[5];
int num1;

do
{

    Console.WriteLine("Ingrese el numero misterioso:");
    int numMisterioso = int.Parse(Console.ReadLine());

    if (numMisterioso > 9999 && numMisterioso <= 99999)
    {
        for (int i = 4; i >= 0; i--)
        {
            num1 = numMisterioso % 10;
            numeros[i] = num1;
            numMisterioso = numMisterioso / 10;
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            for (int f = (i + 1); f < numeros.Length; f++)
            {
                if (numeros[i] == numeros[f])
                {
                    Console.WriteLine("Ingreso dos números iguales, debes ingresar nuevamente el número. ");

                }

            }

            if (i == 4)
            {
                verdad = 2;
            }

        }

        if (verdad == 2)
        {
            verdad = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int f = 0; f < numeroReal.Length; f++)
                {
                    if (i == f)
                    {
                        if (numeros[i] == numeroReal[f])
                        {
                            Console.WriteLine("Num: {0} (+)", numeroReal[i]);
                        }

                    }
                    else if (numeros[i] == numeroReal[f])
                    {
                        Console.WriteLine(" Num: {0} (-)", numeroReal[i]);

                    }

                }

            }

        }
        else
        {
            Console.WriteLine("Error");
        }


    }

    for (int k = 0; k < numeroReal.Length; k ++)
    {
        if (numeroReal[k] == numeros[k])
        {
            verdad = 1;
        }
        else
        {
            verdad = 0;
            k = 5;
        }
    }

    if(verdad == 1)
    {
        Console.WriteLine("FELICITACIONES HAZ ADIVINADO EL NUMERO MISTERIOSO.");
    }

} while (verdad == 0) ;
        

