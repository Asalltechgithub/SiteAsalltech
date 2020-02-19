﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp6.Models
{
    public class Usuario
    {   
        [Key]
        public int Id { get; set; }
        
        
        public GrupoUsuario Grupo { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Numeros de Caracteres Exedido", ErrorMessageResourceName = "Error", MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
       
        

    }
}
