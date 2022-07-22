using System;

namespace App
{
    class Programa
    {
        static void Main(string[] args)

        {
            string numero = "";
            Console.WriteLine("Seleccione la opcion que desea realizar");
            Console.WriteLine("1.- Palindomo\n2.- Suma nones\n3.- Teorema\n4.- Lista enlazada ");
            numero = (Console.ReadLine());

            switch (numero)
            {
                case "1":
                    palindromo();
                    break;
                case "2":
                    SumaNones();
                    break;
                case "3":
                    Triangulo();
                    break;
            }

        }


        public static void palindromo()
        {
            string palabra = "";

            Console.WriteLine("Ingrese la palabra que desea validar");
            palabra = Console.ReadLine();


            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            string palabra2 = String.Concat(letras);

            if (palabra == palabra2)
            {
                Console.WriteLine("Si es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindroma");
            }
        }



        public static void SumaNones()
        {


            int impares = 0, pares = 0;


            for (int i = 0; i < 100; i++)
            {



                if (i % 2 == 0)
                {
                    pares = pares + i;
                }
                else
                {
                    impares = impares + i;
                }
            }

            Console.WriteLine(impares);
            Console.WriteLine(pares);



        }

        public static void Triangulo()
        {
            int a = 0;
            int b = 0;
            int c = 0;


            Console.WriteLine("Ingrese el valor de los catetos");
            Console.WriteLine("ingrese el primer Cateto");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo Cateto");
            b = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                c = a * a + b * b;
                Console.WriteLine("el valor de la hipotenusa es " + c);

            }
            else
            {
                Console.WriteLine("tienes que tener un valor en ambos catetos ");

            }
        }

    }

}