namespace LanchesM.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }


        // relacinamento para listar os lanches
        public List<Lanche> Lanches { get; set; }

    }
}
