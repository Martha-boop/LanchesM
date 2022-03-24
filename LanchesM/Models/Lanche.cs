using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesM.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado")]
        [Display(Name ="Nome do Lanche")]
        [StringLength(80,MinimumLength =10,ErrorMessage ="O {0} deve ter no minimo {1} e no meximo {2}")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        [StringLength(20,  ErrorMessage = "A descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="A descrição pode exeder {1} caracteres")]
        public string DescrisaoCurta { get; set; }


        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [StringLength(20, ErrorMessage = "A descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada pode exeder {1} caracteres")]
        public string DescrisaoDetalhada { get; set; }


        [Required(ErrorMessage = "O Preço do lanche deve ser informado")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O Preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho da imagem normal")]
        [StringLength(200,  ErrorMessage = "O {0} deve ter no minimo {1} caracteres")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Caminho da imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no minimo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque{ get; set; }



        // é para fazer o relacinamento entre as tabelas lanches e categoria 
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria{ get; set; }
    }
}
