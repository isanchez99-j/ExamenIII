using Postgrest.Attributes;
using Postgrest.Models;

namespace NotasApp.Models
{
    [Table("historial")]
    class Historial : BaseModel
    {
        [PrimaryKey("idCompra")]
        public int idCompra { get; set; }
        [Column("descripcion")]
        public string descripcion { get; set; }
        [Column("fecha")]
        public string fecha { get; set; }
        [Column("total")]
        public string total { get; set; }
        [Column("lugar")]
        public string lugar { get; set; }
        [Column("correoComprador")]
        public string correoComprador { get; set; }
        [Column("idPelicula")]
        public int idPelicula { get; set; }
        [Column("tarjeta")]
        public string tarjeta { get; set; }
        [Column("idUser")]
        public string idUser { get; set; }

    }
}

