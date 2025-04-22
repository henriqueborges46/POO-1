using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        // Definindo nome e preço
        produto.Nome = "Camisa Polo";
        produto.Preco = 79.90;

        // Adicionando ao estoque
        produto.Quantidade = 10; // Isso chama o setter e usa AdicionarEstoque

        // Exibe o valor total em estoque
        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
        Console.WriteLine($"Quantidade total em estoque: {produto.QuantidadeTotal}");
        Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");

        // Remover 3 unidades
        produto.RemoverEstoque(3);

        Console.WriteLine("\nApós remover 3 unidades:");
        Console.WriteLine($"Quantidade total em estoque: {produto.QuantidadeTotal}");
        Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");
    }
}
