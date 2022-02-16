using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesCSharpEstruturasDeControle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                                                                       ");
            Console.WriteLine("********************* Estrutura IF ************************************");
            Console.WriteLine("                                                                       ");



            int idade = 17;
            bool acompanhado = false;
            if (idade >= 18 && acompanhado) // nessa estrutura de controle não tem ponto e virgula (;)  ex  if (idade >= 18 && acompanhado);
            {
                Console.WriteLine("pode entrar");
            }

            if (idade<=18 && acompanhado)
            {
                Console.WriteLine("é menor de idade, mas esta acompanhado");
            }

            if (idade <=18 && !acompanhado)
            {
                Console.WriteLine("Não pode entrar");
            }


            Console.WriteLine("                                                                       ");
            Console.WriteLine("********************* Estrutura IF/ELSE ************************************");
            Console.WriteLine("                                                                       ");

            int idade2 = 20;

            if (idade2 >= 18)
            {
                Console.WriteLine("pode entrar ");
            }
            else
            {
                Console.WriteLine("não pode entrar"); 
            }

            Console.WriteLine("                                                                       ");
            Console.WriteLine("********************* Estrutura IF/ELSE IF ************************************");
            Console.WriteLine("                                                                       ");

            var idade3 = 8;

            if (idade3 >= 0 && idade3 <= 6)
            {
                Console.WriteLine("criança");
            }
            else if (idade3 >= 7 && idade3 <= 15) {

                Console.WriteLine("pré adolecente");
            }
            else if (idade3 >= 16 && idade3 <= 20) 
            {
                Console.WriteLine("adolecente");
            }
            else { 
                Console.WriteLine("VERIFICAR"); 
            }




            Console.ReadLine();


        }
    }
}
