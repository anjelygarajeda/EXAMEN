using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Datos.Mapping.Cliente
{
    class ClienteMap
    {
        builder.ToTable("Cliente)
                .HasKey(c => c.Cliente);
        builder.Property(c => c.nombre)
                .HasMaxLength(100);
        builder.Property(c => c.tipo_cliente)
                .HasMaxLength(20);
        builder.Property(c => c.Nit)
            
            builder.Property(c => c.Id_Telefono);

            
    }
}
