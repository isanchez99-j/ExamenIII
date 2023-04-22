using Postgrest.Attributes;
using Postgrest.Models;

namespace NotasApp.Models
{
    [Table("notas")]
    class Nota : BaseModel
    {
        [PrimaryKey("id")]
        public int idNota { get; set; }
        [Column("desc")]
        public string desc { get; set; }
        [Column("fecha")]
        public string fecha { get; set; }
        [Column("audioUrl")]
        public string audioUrl { get; set; }
        [Column("imgUrl")]
        public string imgUrl { get; set; }
    }
}

