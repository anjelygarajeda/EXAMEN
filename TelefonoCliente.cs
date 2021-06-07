using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Cliente
{
    class TelefonoCliente
    {
        public int Id_TelefonoCliente { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "el numero maximo de caracteres es de 8")]
        public string Tel_Personal { get; set; }


        [Required]
        [StringLength(11, ErrorMessage = "el numero maximo de caracteres es de 8")]
        public string Tel_Casa { get; set; }
    }
}
