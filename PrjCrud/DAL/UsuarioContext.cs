using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrjCrud.Models;
using System.Data.Entity;

namespace PrjCrud.DAL
{
    public class UsuarioContext: DbContext
    {
        public UsuarioContext() : base("UsuarioContext")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

      }
}