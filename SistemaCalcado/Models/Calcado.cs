using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCalcado.Models
{
    [Table("Calcado")]
    public class Calcado
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Column("Cor")]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Column("Tamanho")]
        [Display(Name = "Tamanho")]
        public int Tamanho { get; set; }

    }
}
