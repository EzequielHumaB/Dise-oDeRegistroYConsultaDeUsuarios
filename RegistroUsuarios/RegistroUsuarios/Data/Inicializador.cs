using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Data
{
    public class Inicializador
    {
        public static void Inicializar(RegistroUsuariosContext registroUsuariosContext)
        {
            registroUsuariosContext.Database.EnsureCreated();
            if(registroUsuariosContext.Categoria.Any())
            {
                return; 
            }

            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Wilson Contreras",Descripcion="Arquitecto", FechaCreacion=DateTime.Now},
                new Categoria{Nombre="Leonard Maria",Descripcion="Abogado", FechaCreacion=DateTime.Now}
            };

            foreach(Categoria c in categorias)
            {
                registroUsuariosContext.Categoria.Add(c);
            }

            registroUsuariosContext.SaveChanges();

        }
    }
}
