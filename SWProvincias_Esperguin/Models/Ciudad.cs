using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWProvincias_Esperguin.Models
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }


        [Column(TypeName ="varchar(50)")]
        [Required]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ProvinciaId { get; set; }

        public Provincia Provincia { get; set; }
    }
}
