using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
    public class Telefone
    {
        [Key] // Define a chave primária
        [Column("CNPJ_CPF")]
        public string CnpjCpf{ get; set; }

        [Column("DDD")]
        public int Ddd { get; set; }
    }
}