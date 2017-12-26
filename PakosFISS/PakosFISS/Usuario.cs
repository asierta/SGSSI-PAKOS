using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace PakosFISS
{
    class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public string NombreUsuario{get;set;}
        public string Password{get;set;}
        public string Correo{get;set;}
        public string DireccionEthereum { get; set; } 
    }
}
