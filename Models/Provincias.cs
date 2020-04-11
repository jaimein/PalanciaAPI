using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Palancia.Models
{
    [Table("provincias")]
    public partial class Provincias
    {
        public Provincias()
        {
            Poblaciones = new HashSet<Poblaciones>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nombre", TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Column("cusualt", TypeName = "varchar(20)")]
        public string Cusualt { get; set; }
        [Column("fmod", TypeName = "datetime")]
        public DateTime? Fmod { get; set; }
        [Column("cusumod", TypeName = "varchar(20)")]
        public string Cusumod { get; set; }
        [Column("falt", TypeName = "datetime")]
        public DateTime? Falt { get; set; }
        [Column("id_comunidad", TypeName = "int(11)")]
        public int? IdComunidad { get; set; }

        [ForeignKey(nameof(IdComunidad))]
        [InverseProperty(nameof(Comunidades.Provincias))]
        public virtual Comunidades IdComunidadNavigation { get; set; }
        [InverseProperty("IdProvinciaNavigation")]
        public virtual ICollection<Poblaciones> Poblaciones { get; set; }
    }
}
