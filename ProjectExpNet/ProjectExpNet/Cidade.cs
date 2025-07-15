using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
    public class Cidade
    {
        [Key] // Define a chave primária
        [Column("CIDADEID")]
        public int CidadeId { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("ESTADOID")]
        public string EstadoId { get; set; }
    }
}
