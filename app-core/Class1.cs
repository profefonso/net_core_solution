using System;

namespace app_core
{
    public interface Contacto
    {
        string Email { get; set; }
        string Telefono { get; set; }
        int Edad { get; set; }
        string Comentario { get; set; }
    }
}
