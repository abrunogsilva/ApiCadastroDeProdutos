using System;

namespace apiPrimeiraAplicacao.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int quantidade { get; set; }
        public decimal valor { get; set; }
        
    }
}