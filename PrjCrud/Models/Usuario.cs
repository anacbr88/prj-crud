using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrjCrud.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage =("O campo Nome é obrigatório"))]
        public string Nome { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [Required(ErrorMessage = ("O campo Sexo é obrigatório"))]
        public string Sexo { get; set; }
        [Required(ErrorMessage = ("O campo Login é obrigatório"))]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = ("O campo Senha é obrigatório"))]
        public string Senha { get; set; }
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = ("O campo Data de Nascimento é obrigatório"))]
        public DateTime DataNascimento { get; set; }
    }
}