using System;

class Program2{
    static void Main(string[] args) {
        // Define a string a ser invertida
        string original = "Hello, world!";

        // Converte a string em um array de caracteres
        char[] caracteres = original.ToCharArray();

        // Define as variáveis de controle dos índices
        int inicio = 0;
        int fim = caracteres.Length - 1;

        // Loop para inverter os caracteres
        while (inicio < fim) {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Atualiza os índices
            inicio++;
            fim--;
        }

        // Converte o array de caracteres de volta para uma string
        string invertida = new string(caracteres);

        // Imprime a string invertida
        Console.WriteLine(invertida);
    }
}