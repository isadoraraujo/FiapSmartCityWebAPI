using FiapSmartCityWebAPI.Models;
using System.Collections.Generic;

namespace FiapSmartCityWebAPI.DAL
{
    public class TipoProdutoDAL
    {
        private static Dictionary<long, TipoProduto> bancoTipoProduto = new Dictionary<long, TipoProduto>();
        private static int contadorBanco = 2;

        static TipoProdutoDAL()
        {
            TipoProduto EnergiaSolar = new TipoProduto();
            EnergiaSolar.IdTipo = 1;
            EnergiaSolar.DescricaoTipo = "Energia Solar";
            EnergiaSolar.Comercializado = true;

            Produto FotoVoltatica = new Produto();
            FotoVoltatica.IdProduto = 800;
            FotoVoltatica.NomeProduto = "Energia Solar Fotovoltatica";
            FotoVoltatica.Caracteristicas = @"A tecnologia fotovoltaica (FV) 
                                            converte diretamente os raios 
                                            solares em eletricidade";
            FotoVoltatica.PrecoMedio = 4000.00;
            FotoVoltatica.Logotipo = @"data:image/jpeg;base64";
            FotoVoltatica.Ativo = true;

            EnergiaSolar.Adiciona(FotoVoltatica);

            TipoProduto tinta = new TipoProduto();
            tinta.IdTipo = 2;
            tinta.DescricaoTipo = "Tinta";
            tinta.Comercializado = true;

            bancoTipoProduto.Add(1, EnergiaSolar);
            bancoTipoProduto.Add(2, tinta);
        }

        public void Inserir(TipoProduto TipoProduto)
        {
            contadorBanco++;
            TipoProduto.IdTipo = contadorBanco;
            bancoTipoProduto.Add(contadorBanco, TipoProduto);
        }

        public TipoProduto Consultar(int IdTipo)
        {
            return bancoTipoProduto[IdTipo];
        }

        public IList<TipoProduto> Listar()
        {
            return new List<TipoProduto>(bancoTipoProduto.Values);
        }

        public void Excluir(int IdTipo)
        {
            bancoTipoProduto.Remove(IdTipo);
        }

        public void Alterar(TipoProduto tipoProduto)
        {
            bancoTipoProduto[tipoProduto.IdTipo] = tipoProduto;
        }
    }
}