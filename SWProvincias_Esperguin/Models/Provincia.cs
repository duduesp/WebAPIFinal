using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWProvincias_Esperguin.Models
{
    [Table("Provincia")]
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get;set; }

        public List<Ciudad> Ciudades { get; set; }
    }
}
