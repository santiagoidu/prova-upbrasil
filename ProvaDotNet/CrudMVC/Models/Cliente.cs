using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    [Table("Clientes")]
    public class Cliente              
    {   
        public int Id { get; set; }

        [Required]
        [Display(Name ="Matrícula")]
        public int Matricula { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        
        [Display(Name ="Data de Nascimento")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(100)]
        public string Empresa { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Cargo")]
        public string Funcao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}