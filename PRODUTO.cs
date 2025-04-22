using System;

public class Produto
{
    // Campos privados
    private string nome;
    private double preco;
    private int quantidadetotal;

    // Propriedades públicas com encapsulamento
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    // Propriedade de escrita para quantidade
    public int Quantidade
    {
        set { AdicionarEstoque(value); }
    }

    // Propriedade de leitura para quantidadetotal
    public int QuantidadeTotal
    {
        get { return quantidadetotal; }
    }

    // Método para adicionar ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            quantidadetotal += quantidade;
        }
    }

    // Método para remover do estoque
    public void RemoverEstoque(int qtde)
    {
        if (qtde <= quantidadetotal)
        {
            quantidadetotal -= qtde;
        }
        else
        {
            Console.WriteLine("Erro: Estoque insuficiente para remover a quantidade solicitada.");
        }
    }

    // Método que retorna o valor total em estoque
    public double ValorTotalEmEstoque()
    {
        return preco * quantidadetotal;
    }
}
