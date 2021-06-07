using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Datos.Mapping.Cliente
{
    class TelefonoClienteMap
    {
        public void Configure(EntityTypeBuilder<TelefonoCliente> builder)
        {
            builder.ToTable("TelefonoCliente")
                .HasKey(c => c.Id_TelefonoCliente);
            builder.Property(c => c.Tel_Personal)
                .HasMaxLength(8);
            builder.Property(c => c.Tel_Casa)
                .HasMaxLength(8);
        }
    }
}
