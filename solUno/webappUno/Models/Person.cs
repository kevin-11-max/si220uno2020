﻿

namespace webappUno.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Person
    { 
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        [Display(Name ="Nombre completo")]
        [StringLength(100, ErrorMessage ="Maximo 100 caracteres")]
        public string Name { get; set; }

        [Display(Name ="carnet de identidad")]
        public string Document { get; set; }

    }
}