using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101); // Número entre 1 e 100
        int tentativa; // Tentativa do jogador
        int tentativas = 0; // Contador de tentativas

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!"); // Mensagem de boas-vindas
        Console.WriteLine("Adivinhe o número entre 1 e 100."); // Instruções

        do
        {
            Console.Write("Digite sua tentativa: "); // Pergunta ao jogador
            string input = Console.ReadLine(); // Leitura da entrada do jogador
            tentativa = int.Parse(input); // Conversão da entrada para um inteiro
            tentativas++; // Incrementa o contador de tentativas

            if (tentativa < numeroSecreto) // Verifica se a tentativa foi menor que o número secreto
                Console.WriteLine(" Muito baixo!"); // Informa ao jogador que a tentativa foi baixa
            else if (tentativa > numeroSecreto) // Verifica se a tentativa foi maior que o número secreto
                Console.WriteLine("Muito alto!"); // Informa ao jogador que a tentativa foi alta
            else // Caso a tentativa seja igual ao número secreto
                Console.WriteLine($" Parabéns! Você acertou em {tentativas} tentativas."); // Informa ao jogador que acertou
        }
        while (tentativa != numeroSecreto); // Enquanto a tentativa for diferente do número secreto
    }
}
