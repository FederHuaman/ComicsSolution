using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Comics.Domain.Entities
{
    public class Comic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Año { get; set; }
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Foto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
    }
}
