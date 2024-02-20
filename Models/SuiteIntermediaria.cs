using System;

namespace DesafioProjetoHospedagem.Models
{
    public class SuiteIntermediaria
    {
        public SuiteIntermediaria() { }

        public SuiteIntermediaria(string tipoIntermediaria, decimal valorDiariaI)
        {
            TipoIntermediaria = tipoIntermediaria;
            ValorDiariaI = valorDiariaI;
        }

        public string TipoIntermediaria;
        public decimal ValorDiariaI;

        public void EscolherSuiteIntermediaria()
        {
           string nomeResponsavel = "";

            do
            {
                Console.WriteLine($"Digite o seu nome:");
                nomeResponsavel = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomeResponsavel) || !ÉApenasLetras(nomeResponsavel))
                {
                    Console.WriteLine("Nome não pode ser vazio, ou contendo caractéres. Por favor, digite novamente.");
                }

            } while (string.IsNullOrWhiteSpace(nomeResponsavel) || !ÉApenasLetras(nomeResponsavel));

            Console.WriteLine($"Por quantos dias você ficou hospedado? Caso tenha sido por 10 dias ou mais, você ganha 10% de desconto.");
            int diasReservados = int.Parse(Console.ReadLine());

            decimal valorDiariaI = 185M;
            decimal total = diasReservados * valorDiariaI;
            decimal valorComDesconto = 0;
            decimal percentualDesconto = 0.10M;

            if (diasReservados >= 10)
            {
                valorComDesconto = total - (total * percentualDesconto);
                Console.WriteLine($"Obrigado por ter garantido sua Suíte Intermediária conosco!\n Com o desconto de 10% garantido pelos 10 dias de hospedagem, seu valor final foi de {valorComDesconto:C}");
            }
            else
            {
                Console.WriteLine($"Obrigado por ter garantido sua Suíte Intermediária conosco!\n O valor total da sua hospedagem foi de {total:C}");
            }
        }

        private bool ÉApenasLetras(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
    }
    }
}
