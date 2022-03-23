namespace LanchesM.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescrisaoCurta { get; set; }
        public string DescrisaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque{ get; set; }



        // é para fazer o relacinamento entre as tabelas lanches e categoria 
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria{ get; set; }
    }
}
