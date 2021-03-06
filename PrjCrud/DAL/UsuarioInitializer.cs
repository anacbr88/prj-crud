﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrjCrud.Models;

namespace PrjCrud.DAL
{
    public class UsuarioInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<UsuarioContext>
    {
        protected override void Seed(UsuarioContext context)
        {
            var usuarios = new List<Usuario>
            {
                new Usuario{Id=1,Nome="Mariana Ribeiro",Sexo="F",Login="mribeiro",Senha=SecurityPasswd.GenerateSHA256String("123456"),DataNascimento=DateTime.Parse("2008-12-01")},
                new Usuario{Id=2,Nome="Arthur Araujo",Sexo="M",Login="aaraujo",Senha=SecurityPasswd.GenerateSHA256String("654321"),DataNascimento=DateTime.Parse("2016-11-07")},
                new Usuario{Id=3,Nome="Julia Santos",Sexo="F",Login="jsantos",Senha=SecurityPasswd.GenerateSHA256String("987654"),DataNascimento=DateTime.Parse("2010-06-10")}

            };
            usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();
        }
    }
}