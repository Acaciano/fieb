using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SouFieb.Models
{
    [Table("Evento")]
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
    }
}
