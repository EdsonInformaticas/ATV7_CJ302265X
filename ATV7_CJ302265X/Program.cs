using Microsoft.VisualBasic.FileIO;
using System;

namespace ATV7_CJ302265X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("=========MENU=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - Ex1");
                    Console.WriteLine("2 - Ex2");
                    Console.WriteLine("3 - Ex3");
                    Console.WriteLine("4 - Ex4");
                    Console.WriteLine("5 - Ex5");
                    Console.WriteLine("6 - Ex6");
                    Console.WriteLine("7 - Ex7");

                    op = int.Parse(Console.ReadLine());
                } while (op < 0 || op > 7);

                switch (op)
                {


                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;


                    case 1:
                        {

                            //PROJETO 1
                            int numero, cont = 1;
                            Console.Clear();
                            Console.WriteLine("Até que número deseja contar?");
                            numero = int.Parse(Console.ReadLine());
                            Console.Clear();
                            while (cont <= numero)
                            {
                                Console.WriteLine("{0}", cont); cont++;
                            }
                            Thread.Sleep(2000);
                            break;
                        }

                    case 2:
                        {
                            //PROJETO 2

                            int nmr, cont = 2;
                            Console.Clear();
                            Console.WriteLine("Até q número deseja contar?(os números pares)");
                            nmr = int.Parse(Console.ReadLine());
                            Console.Clear();
                            while (cont <= nmr)
                            {
                                Console.WriteLine("{0}", cont);
                                cont = cont + 2;
                            }
                            Thread.Sleep(2000);
                            break;
                        }

                    case 3:
                        {
                            //PROJETO 3

                            int nmr1, cont = 1000;
                            Console.Clear();
                            Console.WriteLine("Insira um número menor que 1000");
                            nmr1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            while (cont >= nmr1)
                            {
                                Console.WriteLine("{0}", cont);
                                cont = cont - 2;
                            }
                            Thread.Sleep(2000);
                            break;
                        }

                    case 4:
                        {
                            //PROJETO 4

                            int nmr2, cont = 0;
                            Console.Clear();
                            while (cont < 200)
                            {

                                Console.WriteLine("Escreva um número para somar, iremos parar de somar caso a soma dos números seja igual ou maior que 200");
                                nmr2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                cont = cont + nmr2;
                            }
                            Thread.Sleep(2000);
                            break;
                        }

                    case 5:
                        {
                            //PROJETO 5

                            int nmr3, cont = 1;
                            Console.Clear();
                            Console.WriteLine("Digite o número que deseja descobrir os divisores");
                            nmr3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            while (cont < nmr3)
                            {
                                if (nmr3 % cont == 0)
                                    Console.WriteLine("{0}", cont);
                                cont++;
                            }
                            Thread.Sleep(2000);
                            break;
                        }

                    case 6:
                        {
                            //PROJETO 6
                            break;
                        }

                    case 7:
                        {
                            //PROJETO 7
                            int nmr4 = 0, pares = 0, impares = 0;
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Digite um valor, somaremos os ímpares e os pares, se digitar '0' o programa é encerrado");
                                nmr4 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (nmr4 == 0)
                                {
                                    Console.WriteLine("A soma dos números pares é:{0}}\nA soma dos números ímpares é: {1}", pares, impares);
                                    Thread.Sleep(2000);
                                    break;
                                }
                                if (nmr4 % 2 == 0)
                                    pares = pares + nmr4;
                                else
                                    impares = impares + nmr4;

                            }
                            Thread.Sleep(2000);
                            break;
                        }
                }
            } while (op != 0);





        }
    }
}
