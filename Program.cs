using System; // Importa o namespace System, que contém as classes fundamentais do .NET

class Program { // Define a classe Program
    static void Main() { // Define o método Main, que é o ponto de entrada do programa
        Console.Write("Informe um número inteiro: "); // Exibe uma mensagem solicitando que o usuário informe um número inteiro
        int numero = int.Parse(Console.ReadLine()); // Lê o número informado pelo usuário e o converte para o tipo int, armazenando-o na variável numero
        
        int a = 0, b = 1, c = 0; // Inicializa as variáveis a, b e c com os valores iniciais da sequência de Fibonacci
        bool pertence = false; // Inicializa a variável pertence como false, indicando que o número informado ainda não foi encontrado na sequência
        
        while (c < numero) { // Enquanto o valor atual da sequência for menor que o número informado pelo usuário
            c = a + b; // Calcula o próximo valor da sequência como a soma dos valores anteriores
            a = b; // Atribui o valor de b para a, preparando o cálculo do próximo valor da sequência
            b = c; // Atribui o valor de c para b, preparando o cálculo do próximo valor da sequência
            
            if (c == numero) { // Se o valor atual da sequência for igual ao número informado pelo usuário
                pertence = true; // Define a variável pertence como true, indicando que o número foi encontrado na sequência
                break; // Interrompe o laço de repetição
            }
        }
        
        if (pertence) { // Se o número informado pelo usuário pertence à sequência de Fibonacci
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci."); // Exibe uma mensagem informando que o número pertence à sequência
        } else { // Caso contrário
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci."); // Exibe uma mensagem informando que o número não pertence à sequência
        }
    }
}