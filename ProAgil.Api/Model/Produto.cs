namespace ProAgil.Api.Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string nome { get; set; }
        public int qtd {get; set;}
        public string dataCompra {get; set;}
        public string imagemUrl {get; set;}
    }
}