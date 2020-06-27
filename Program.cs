using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Aval_Aula03_YF
{
    class Program
    {

        // ========================
        /* 1. Crie um procedimento que calcule a soma e a média de 10 números inteiros e maiores que zero, 
           definidos pelo utilizador (utilizar os métodos int.Parse() ou int.TryParse() na conversão dos 
           valores);  */
        static void Aula3_EX1()
        {
            //definição do array  
            int[] valores = new int[10];
            //preencher valores do array com 10 números inteiros  
            int contador = 0; string valor = "";
            int numero = 0;
            do
            {
                Console.WriteLine("defina o {0}º valor do array", contador + 1);
                valor = Console.ReadLine();
                if (int.TryParse(valor, out numero) == true)
                {
                    if (numero > 0)
                    { //valor inteiro positivo  - adicionar valor ao array 
                        valores[contador] = numero;
                        contador++;
                    }
                }

            } while (contador < 10);
            //soma e a média dos valores definidos;  
            Console.WriteLine(); Console.WriteLine("soma e a média dos valores definidos");
            Console.WriteLine("\tsoma = {0}", valores.Sum());
            Console.WriteLine("\tmédia = {0}", valores.Average());
            Console.WriteLine();
            Console.WriteLine("pressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================
        /* 2. Crie uma função booleana que determina se um número N, inteiro maior que zero, é um número 
            primo; um número primo só é divisível por ele próprio e por um; utilizar os métodos int.Parse() 
            ou int.TryParse() na conversão do valor; */
        static void Aula3_EX2()
        {
            //definição do numero de entrada 
            string numero_in = "";
            int numero_out = 0;

            Console.WriteLine("Escreva um número {0} ");
            numero_in = Console.ReadLine();
            if (int.TryParse(numero_in, out numero_out) == true)
            {
                if (numero_out > 0) // valor inteiro positivo
                {
                    for (int i = 2; i < numero_out; i++)
                    {
                        if (numero_out % i == 0)
                        {
                            Console.WriteLine("não é primo");
                            Console.WriteLine("pressione uma tecla para terminar...");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("primo");
                }
            }
            Console.WriteLine();
            Console.WriteLine("pressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================
        /* 3. Crie um procedimento que permita ler uma equação de 2º grau (ax2 + bx + c) e apresentar as 
        soluções para x, considerando as fórmulas:  
         * x1 = -b + sqrt(b^2 - 4ac) / 2a
         * x2 = -b - sqrt(b^2 - 4ac) / 2a  
        Considere que: 
         * Se  < 0, a equação é impossível;  
         * Se  = 0, a equação tem apenas uma solução; 
         * Se  > 0, a equação tem duas soluções; */
        static void Aula3_EX3()
        {

            //preencher valores das variaveis a, b e c  
            int a_out = 0, b_out = 0, c_out = 0;
            double x1 = 0, x2 = 0, delta = 0;

            Console.WriteLine("Escreva o valor de a");
            int.TryParse(Console.ReadLine(), out a_out);

            Console.WriteLine("Escreva o valor de b");
            int.TryParse(Console.ReadLine(), out b_out);

            Console.WriteLine("Escreva o valor de c");
            int.TryParse(Console.ReadLine(), out c_out);


            delta = (b_out * b_out) - (4 * a_out * c_out);

            if (delta < 0)
                Console.WriteLine("Imposs.");
            else if (delta == 0)
                Console.WriteLine("uma raiz = {0}", -b_out / (2 * a_out));
            else
            {
                x1 = (-b_out - Math.Sqrt(delta)) / (2 * a_out);
                x2 = (-b_out + Math.Sqrt(delta)) / (2 * a_out);

                Console.WriteLine("duas raizes x1 = {0} e x2 = {1}", x1, x2);
            }

            Console.WriteLine("pressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================
        /* 4.  Crie uma função do tipo double que calcule de forma recursiva o factorial de um número N, inteiro 
        maior que zero, definido pelo utilizador; utilizar os métodos int.Parse() ou int.TryParse() 
        na conversão do valor; */
        static long Factorial(long numero_out)
        {
            if ((numero_out == 0) || (numero_out == 1)) return 1;
            //          else return (numero_out * Factorial (numero_out - 1));
            //numero_out = (numero_out * Factorial(numero_out - 1));
            //Console.WriteLine("O resultado é = {0}", numero_out);
            return numero_out * Factorial(numero_out - 1);
        }

        static void Aula3_EX4()
        {
            //definição do numero de entrada 
            string numero_in = "";
            long numero_out = 0;

            Console.WriteLine("Escreva um número, de preferência Inteiro Positivo e até 15 {0} ");
            numero_in = Console.ReadLine();
            if (long.TryParse(numero_in, out numero_out) == true)
            {
                if (numero_out >= 0) // valor inteiro positivo
                    Console.WriteLine("O resultado final é = {0}", Factorial(numero_out));
            }
            Console.WriteLine("pressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================
        //5. Fibonacci

        private static long CalculateFibonacci(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
        static void Aula3_EX5()
        {
            long numero_in = 0;
            //            Console.WriteLine("Escreva um número positivo inteiro e menor 48");
            //            Console.WriteLine("Se escrever uma letra ou um número negativo o sw fica à espera de um número positivo");

            //            Console.WriteLine("defina o {0}º valor do array", contador + 1);
            //            number = Console.ReadLine();
            //            if (int.TryParse(numero_in, out numero_out) == true)
            try
            {
                Console.Write("Escreva o número: ");
                numero_in = long.Parse(Console.ReadLine());

                Console.WriteLine("Fibonacci({0}) é {1}", numero_in, CalculateFibonacci(numero_in));
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor Inválido!");
            }
            catch (Exception)
            {
                Console.WriteLine("Algo correu mesmo muito mal");
            }

            // return 0;
            Console.WriteLine("Pressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================
        private static long QuadradoPerfeito(long n)
        {
            if (n < 4) return 0;
            return 1 + 3;
        }
        static void Aula3_EX6()
        {
            //definição do numero de entrada 
            string numero_in = "";
            int numero_out = 0;
            int numero2_out = 0;

            Console.WriteLine("Escreva um número inteiro > 0");
            numero_in = Console.ReadLine();
            if (int.TryParse(numero_in, out numero_out) == true)
            {
                if (numero_out > 0) // valor inteiro positivo
                {
                    for (int i = 1; i < numero_out; i++) //está mal !!!
                    {
                        numero2_out = numero_out + i;     //está mal !!!
                        Console.WriteLine("i = {0}", i);
                        Console.WriteLine("numero_out = {0}", numero_out);
                        Console.WriteLine("numero2_out = {0}", numero2_out);

                    }
                    {
                        Console.WriteLine("O quadrado é: {0}", numero2_out);
                        Console.WriteLine("A raíz quadrada é: {0}", Math.Sqrt(numero2_out));
                        //                        Console.WriteLine("pressione uma tecla para terminar...");
                        //                        Console.ReadLine();
                        //                        return;
                    }

                }
                else
                    Console.WriteLine("Escreveu zero");
            }
            else
                Console.WriteLine("Escreveu um valor incorrecto...");

            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para terminar...");
            Console.ReadLine();

        }

        // ========================
        static void Aula3_EX7()
        {
            // definiçao da matriz e inicializaçao
            int[,] matriz = new int[4, 4];
            int linha = 0, coluna = 0;
            string valor = "";
            int numero = 0;

            // Soma dos valores para verificaçao de QuadradoMagico
            int soma = 0, NaoEquadradoMagico = 0;
            int somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0, somaLinha4 = 0;
            int somaColuna1 = 0, somaColuna2 = 0, somaColuna3 = 0, somaColuna4 = 0;
            int somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;
            string NaoEquadradoMagicoTexto = "";

            do
            {
                Console.WriteLine("Escreva o valor para a posiçao {0},{1}", linha + 1, coluna + 1);
                valor = Console.ReadLine();
                if (int.TryParse(valor, out numero) == true)
                {
                    matriz[linha, coluna] = numero;
                    coluna++;
                }
                if (coluna == 4)
                {
                    linha++;
                    coluna = 0;
                }
            } while ((linha < 4) && (coluna < 4));

            // valores definidos correctamente para a matriz
            Console.WriteLine("\n M A T R I Z");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            // Soma dos conteudos das Linhas
            for (int j = 0; j < 4; j++)
            {
                somaLinha1 = somaLinha1 + matriz[0, j];
            }
            soma = somaLinha1;

            for (int j = 0; j < 4; j++)
            {
                somaLinha2 = somaLinha2 + matriz[1, j];
            }

            if (somaLinha2 == soma)
            {
                soma = somaLinha2;
                for (int j = 0; j < 4; j++)
                {
                    somaLinha3 = somaLinha3 + matriz[2, j];
                }
            }
            else
            {
                NaoEquadradoMagico = 2;
            }

            if (somaLinha3 == soma)
            {
                soma = somaLinha3;
                for (int j = 0; j < 4; j++)
                {
                    somaLinha4 = somaLinha4 + matriz[3, j];
                }
            }
            else
            {
                NaoEquadradoMagico = 3;
            }

            Console.WriteLine();
            Console.WriteLine("Somas das Linhas: {0},\t {1},\t {2},\t {3}", +somaLinha1, +somaLinha2,
                                                                            +somaLinha3, +somaLinha4);
            if (somaLinha4 == soma)
            {
                soma = somaLinha4;

                // Soma dos conteudos das Colunas
                for (int i = 0; i < 4; i++)
                {
                    somaColuna1 = somaColuna1 + matriz[i, 0];
                }
            }
            else
            {
                NaoEquadradoMagico = 4;
            }

            if (somaColuna1 == soma)
            {
                soma = somaColuna1;
                for (int i = 0; i < 4; i++)
                {
                    somaColuna2 = somaColuna2 + matriz[i, 1];
                }
            }
            else
            {
                NaoEquadradoMagico = 5;
            }

            if (somaColuna2 == soma)
            {
                soma = somaColuna2;
                for (int i = 0; i < 4; i++)
                {
                    somaColuna3 = somaColuna3 + matriz[i, 2];
                }
            }
            else
            {
                NaoEquadradoMagico = 6;
            }

            if (somaColuna3 == soma)
            {
                soma = somaColuna3;
                for (int i = 0; i < 4; i++)
                {
                    somaColuna4 = somaColuna4 + matriz[i, 3];
                }

                Console.WriteLine();
                Console.WriteLine("Somas das Colunas: {0},\t {1},\t {2},\t {3}", +somaColuna1, +somaColuna2,
                                                                                 +somaColuna3, +somaColuna4);
            }
            else
            {
                NaoEquadradoMagico = 7;
            }

            if (somaColuna4 == soma)
            {
                soma = somaColuna4;

                // valores da diagonal principal
                Console.WriteLine();
                Console.WriteLine("Valores da Diagonal Principal:");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("{0},\t", matriz[i, i]);
                    somaDiagonalPrincipal += matriz[i, i];
                }
                Console.Write("Soma da Diagonal Principal {0}", +somaDiagonalPrincipal);
            }
            else
            {
                NaoEquadradoMagico = 8;
            }

            if (somaDiagonalPrincipal == soma)
            {
                soma = somaDiagonalPrincipal;

                // valores da diagonal secundária
                Console.WriteLine();
                Console.WriteLine("\nValores da Diagonal Secundária:");
                for (int i = 3; i >= 0; i--)
                {
                    Console.Write("{0},\t", matriz[i, 3 - i]);
                    somaDiagonalSecundaria += matriz[i, 3 - i];
                }
                Console.Write("Soma da Diagonal Secundária {0}", +somaDiagonalSecundaria);
            }
            else
            {
                NaoEquadradoMagico = 9;
            }

            Console.WriteLine();
            Console.WriteLine();
            if (somaDiagonalSecundaria == soma)
                Console.WriteLine("\nPARABÉNS, É UM QUADRADO MÁGICO!!! {0}", +soma);
            else
            {
                NaoEquadradoMagico = 10; // É SEMPRE EXECUTADO, NEC VERIFICAR !!!
            }

            //switch (NaoEquadradoMagico)
            //{
            //    case 1:
            //        NaoEquadradoMagicoTexto = "Erro de SW 1, necessário debug";
            //        break;
            //    case 2:
            //        NaoEquadradoMagicoTexto = "Soma Linha 2 <> Soma linha 1";
            //        break;
            //    case 3:
            //        NaoEquadradoMagicoTexto = "Soma Linha 3 <> Soma linha 2";
            //        break;
            //    case 4:
            //        NaoEquadradoMagicoTexto = "Soma Linha 4 <> Soma linha 3";
            //        break;
            //    case 5:
            //        NaoEquadradoMagicoTexto = "Soma Coluna 1 <> Soma linha 4";
            //        break;
            //    case 6:
            //        NaoEquadradoMagicoTexto = "Soma Coluna 2 <> Soma Coluna 1";
            //        break;
            //    case 7:
            //        NaoEquadradoMagicoTexto = "Soma Coluna 3 <> Soma Coluna 2";
            //        break;
            //    case 8:
            //        NaoEquadradoMagicoTexto = "Soma Coluna 4 <> Soma Coluna 3";
            //        break;
            //    case 9:
            //        NaoEquadradoMagicoTexto = "Soma Diagonal Principal <> Soma Coluna 4";
            //        break;
            //    case 10:
            //        NaoEquadradoMagicoTexto = "Soma Diagonal Secundária <> Soma Diagonal Principal";
            //        break;
            //    //default:
            //    //    NaoEquadradoMagicoTexto = "Erro de SW, necessário debug";
            //}

            //if (NaoEquadradoMagico == 1)
            //    NaoEquadradoMagicoTexto = "Erro de SW 1, necessário debug";
            //else if (NaoEquadradoMagico ==2)
            //    NaoEquadradoMagicoTexto = "Soma Linha 2 <> Soma linha 1";
            //else if (NaoEquadradoMagico ==3)
            //    NaoEquadradoMagicoTexto = "Soma Linha 3 <> Soma linha 2";
            //else if (NaoEquadradoMagico ==4)
            //    NaoEquadradoMagicoTexto = "Soma Linha 4 <> Soma linha 3";
            //else if (NaoEquadradoMagico ==5)
            //    NaoEquadradoMagicoTexto = "Soma Coluna 1 <> Soma linha 4";
            //else if (NaoEquadradoMagico ==6)
            //    NaoEquadradoMagicoTexto = "Soma Coluna 2 <> Soma Coluna 1";
            //else if (NaoEquadradoMagico ==7)
            //    NaoEquadradoMagicoTexto = "Soma Coluna 3 <> Soma Coluna 2";
            //else if (NaoEquadradoMagico ==8)
            //    NaoEquadradoMagicoTexto = "Soma Coluna 4 <> Soma Coluna 3";
            //else if (NaoEquadradoMagico ==9)
            //    NaoEquadradoMagicoTexto = "Soma Diagonal Principal <> Soma Coluna 4";
            //else if (NaoEquadradoMagico ==10)
            //    NaoEquadradoMagicoTexto = "Soma Diagonal Secundária <> Soma Diagonal Principal";
            //else
            //    NaoEquadradoMagicoTexto = "Erro de SW, necessário debug";
            //}

            //if (NaoEquadradoMagicoTexto != "")
            //{
            if (NaoEquadradoMagico > 1 && NaoEquadradoMagico < 11)
            {
                Console.Write("\nOhhh, NAO é um quadrado mágico; \nFalhou na ");
                Console.WriteLine(NaoEquadradoMagico);
            }
            //}

            Console.WriteLine();
            Console.WriteLine("\nPressione uma tecla para terminar...");
            Console.ReadLine();
        }

        // ========================

        static void Aula3_EX8()
        {
            //definição do array
            int[][] valores = new int[4][];
            //inicializar arrays
            //preecher valores do array com números inteiros
            valores[0] = new int[4];
            valores[1] = new int[6];
            valores[2] = new int[10];
            valores[3] = new int[5];
            int linha = 0, coluna = 0;
            string valor = "";
            int numero = 0;
            do
            {
                do
                {
                    Console.WriteLine("defina o valor para a posição {0},{1}",
                    linha + 1, coluna + 1);
                    valor = Console.ReadLine();
                    if (int.TryParse(valor, out numero) == true)
                    {
                        //valor inteiro - adicionar à matriz
                        valores[linha][coluna] = numero;
                        coluna++;
                    }
                } while (coluna < valores[linha].Length);
                linha++;
                coluna = 0;
            } while (linha < 4);
            //valores definidos

            Console.WriteLine("\nvalores definidos");

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < valores[i].Length; j++)
                {

                    Console.Write("{0}\t", valores[i][j]);

                }

                Console.WriteLine();

            }
            //soma e a média dos valores definidos;
            int soma = 0;

            double media = 0;

            int total = 0;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < valores[i].Length; j++)
                {

                    soma = soma + valores[i][j];

                    total++;

                }

            }
            media = (double)soma / total;
            //valores máximo e mínimo;
            int maximo = int.MinValue, minimo = int.MaxValue;

            Console.WriteLine();

            Console.WriteLine("soma e a média dos valores definidos");

            Console.WriteLine("\tsoma = {0}", soma);

            Console.WriteLine("\tmédia = {0}", media);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    if (valores[i][j] > maximo)
                        maximo = valores[i][j];
                    if (valores[i][j] < minimo)
                        minimo = valores[i][j];
                }
            }

            Console.WriteLine();
            Console.WriteLine("valores máximo e mínimo");
            Console.WriteLine("\tmáximo = {0}", maximo);
            Console.WriteLine("\tmínimo = {0}", minimo);

            //total de valores positivos, negativos e iguais a zero;
            int total_positivos = 0, total_negativos = 0, total_zero = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    if (valores[i][j] < 0)
                        total_negativos++;
                    else if (valores[i][j] == 0)
                        total_zero++;
                    else
                        total_positivos++;
                }
            }

            Console.WriteLine();

            Console.WriteLine("total de valores positivos, negativos e iguais a zero");

            Console.WriteLine("\tnegativos = {0}", total_negativos);

            Console.WriteLine("\tiguais a zero = {0}", total_zero);

            Console.WriteLine("\tpositivos = {0}", total_positivos);

            Console.WriteLine();

            Console.WriteLine("pressione uma tecla para terminar...");

            Console.ReadLine();

        }

        // ========================

        static void Main(string[] args)
        {
            // Aula3_EX1();
            // Aula3_EX2();
            // Aula3_EX3();
            // Aula3_EX4();
            // Aula3_EX5(); // CalculateFibonacci
            // Aula3_EX6(); // Quadrado Perfeito - Método Chines
            // Aula3_EX7(); // Matriz Quadrada
            Aula3_EX8(); // Jagged Array
        }
    }
}
