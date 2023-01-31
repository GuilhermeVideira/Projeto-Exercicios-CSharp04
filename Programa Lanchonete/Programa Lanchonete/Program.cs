using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu, menu1, menu2;
            double l1 = 0, l2 = 0, l3 = 0, l4 = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, total = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL\n\n1-Lanches\n2-Bebidas\n3-Conta\n0-Sair\n\nDigite sua opção: ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU LANCHES\n\n1-X-TUDO R$ 10,00\n2-X-EGG R$ 7,00\n3-X-SALADA R$ 6,00\n4-BAURU R$ 5,00\n0-Sair\n\nDigite sua opção: ");
                            menu1 = int.Parse(Console.ReadLine());
                            switch (menu1)
                            {
                                case 1:
                                    l1++;
                                    break;
                                case 2:
                                    l2++;
                                    break;
                                case 3:
                                    l3++;
                                    break;
                                case 4:
                                    l4++;
                                    break;
                            }
                        } while (menu1 != 0);

                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU BEBIDAS\n\n1-COCA-COLA R$ 8,00\n2-GUARANÁ R$ 7,00\n3-FANTA R$ 6,00\n4-SODA R$ 5,00\n0-Sair\n\nDigite sua opção: ");
                            menu2 = int.Parse(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    b1++;
                                    break;
                                case 2:
                                    b2++;
                                    break;
                                case 3:
                                    b3++;
                                    break;
                                case 4:
                                    b4++;
                                    break;
                            }
                        } while (menu2 != 0);


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("CONTA");
                        Console.WriteLine("Produto              Qtd      Valor");
                        if (l1 > 0)
                        {
                            Console.WriteLine("X-TUDO               {0,3} {1,10:N2}", l1, l1 * 10);
                            total += l1 * 10;
                        }
                        if (l2 > 0)
                        {
                            Console.WriteLine("X-EGG                {0,3} {1,10:N2}", l2, l2 * 7);
                            total += l2 * 7;
                        }
                        if (l3 > 0)
                        {
                            Console.WriteLine("X-SALADA             {0,3} {1,10:N2}", l3, l3 * 6);
                            total += l3 * 6;
                        }
                        if (l4 > 0)
                        {
                            Console.WriteLine("BAURU                {0,3} {1,10:N2}", l4, l4 * 5);
                            total += l4 * 5;
                        }
                        if (b1 > 0)
                        {
                            Console.WriteLine("COCA-COLA            {0,3} {1,10:N2}", b1, b1 * 8);
                            total += b1 * 10;
                        }
                        if (b2 > 0)
                        {
                            Console.WriteLine("GUARANÁ              {0,3} {1,10:N2}", b2, b2 * 7);
                            total += b2 * 7;
                        }
                        if (b3 > 0)
                        {
                            Console.WriteLine("FANTA                {0,3} {1,10:N2}", b3, b3 * 6);
                            total += b3 * 6;
                        }
                        if (b4 > 0)
                        {
                            Console.WriteLine("SODA                 {0,3} {1,10:N2}", b4, b4 * 5);
                            total += b4 * 5;
                        }
                        Console.WriteLine("TOTAL                    {0,10:N2}", total);
                        Console.WriteLine();
                        Console.Write("Pressione uma tecla...");
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
    }
}
