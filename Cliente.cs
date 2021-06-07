using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Cliente
{
    class Cliente
    {
        public int idCliente { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Tipo_cliente { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 5, ErrorMessage = "Error")]
        public string Nit { get; set; }

    //realcion con la tabla telefonoCliente
    public TelefonoCliente Telefonos { get; set; }
    //relacion con la tabla Usuario
    public ICollection<Usuario> usuarios { get; set; }
}
}
