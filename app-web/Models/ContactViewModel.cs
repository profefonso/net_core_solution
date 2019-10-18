using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using app_core;

namespace app_web.Models
{
    public class ContactoViewModel : Contacto
    {   

        [TempData]
        public string ErrorMessage { get; set; }

        [Required(ErrorMessage = "El Campo Email es Obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un Email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Campo Telefono es Obligatorio")]
        [StringLength(10, ErrorMessage = "Ingrese un numero con no mas de 10 digitos.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese su edad")]
        [Range(0, 99, ErrorMessage = "La edad debe ser un numero entre 0 y 99")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Su comentario es muy valioso para nosotros")]
        [StringLength(1000, ErrorMessage = "El comentario debe ser mas descriptivo.")]
        public string Comentario { get; set; }
    }
}