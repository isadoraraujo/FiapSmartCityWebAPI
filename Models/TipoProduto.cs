namespace FiapSmartCityWebAPI.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }

        public List<Produto> Produtos { get; set; }

        public TipoProduto()
        {
            this.Produtos = new List<Produto>();
        }
        public void Adiciona(Produto produto)
        {
            this.Produtos.Add(produto);
        }
        public void Remove(long id)
        {
            Produto produto = Produtos.FirstOrDefault(p => p.IdProduto == id);

            Produtos.Remove(produto);
        }
        public void Altera(Produto produto)
        {
            Remove(produto.IdProduto);
            Adiciona(produto);
        }
    }
}