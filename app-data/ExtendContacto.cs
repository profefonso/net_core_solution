using System;
using System.ComponentModel.DataAnnotations;
using app_core;
using Microsoft.EntityFrameworkCore;

namespace app_data
{
    public class ExtendContacto : Contacto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public string Comentario { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}