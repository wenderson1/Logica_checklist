using System;
using System.Collections.Generic;

namespace Tcc_logica
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha, quantidade;
            Dictionary<int, string> checklist = new Dictionary<int, string>()
            {
                {0, "Qual seu nome?"},
                {1, "Qual sua idade?" },
                {2, "Qual seu sobrenome?"},
                {3, "Qual seus sonhos?"}
            };

            Dictionary<int, string> resposta = new Dictionary<int, string>()
            {
                {0,"Seu nome é Wenderson" },
                {1,"Sua idade é 22" },
                {2,"Seu sobrenome é Farias" },
                {3, "Seus sonhos é ser feliz e realizado" }
            };

            Dictionary<int, string> acerto = new Dictionary<int, string>();

            foreach (KeyValuePair<int, string> item in checklist)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                Console.WriteLine("Respota: ");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Proxima");
                    Console.WriteLine(" ");
                    acerto.Add(item.Key, item.Value);
                    resposta.Remove(item.Key);
                }
                if (escolha == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(resposta[item.Key]);
                    Console.WriteLine(" ");

                }
                if (escolha == -1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ok");
                    resposta.Remove(item.Key);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Imprimindo as perguntas acertadas");          
            foreach (KeyValuePair<int, string> x in acerto)
            {
                Console.WriteLine();
                Console.WriteLine(x.Key + x.Value);
            }

            Console.WriteLine("Imprimindo as respostas que voce não sabe");
            foreach (KeyValuePair<int, string> x in resposta)
            {
                Console.WriteLine();
                Console.WriteLine(x.Key + x.Value);
            }

            Console.WriteLine();

            Console.WriteLine("Quantidade de items no dicionario de respotas de acerto");
            Console.WriteLine(acerto.Count);

            Console.WriteLine();

            Console.WriteLine("Quantidade de items no dicionario de respotas de acerto");            
            Console.WriteLine(resposta.Count);



            quantidade = acerto.Count + resposta.Count;
            var porcentagem = (Convert.ToDouble(acerto.Count) / Convert.ToDouble(quantidade)) * 100;

            Console.WriteLine(porcentagem);
            Console.WriteLine("Quantidade de respostas certas e sua porcentagem");
            Console.WriteLine(acerto.Count + " / " + quantidade + " porcentagem de aceitação: " + porcentagem.ToString("0.00") + "%");
            Console.ReadLine();
        }
    }
}
