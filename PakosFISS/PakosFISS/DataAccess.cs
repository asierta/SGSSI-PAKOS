using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;


namespace PakosFISS
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;
        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
            System.IO.Path.Combine(config.DirectorioDB, "Usuarios.db3"));
            connection.CreateTable<Usuario>();
        }
        public void InsertUsuario(Usuario Usuario)
        {
            connection.Insert(Usuario);
        }
        public void UpdateUsuario(Usuario Usuario)
        {
            connection.Update(Usuario);
        }
        public void DeleteUsuario(Usuario Usuario)
        {
            connection.Delete(Usuario);
        }
        public Usuario GetUsuario(string IDUsuario)
        {
            return connection.Table<Usuario>().FirstOrDefault(c => c.NombreUsuario == IDUsuario
            );
        }
        public List<Usuario> GetUsuarios()
        {
            return connection.Table<Usuario>().OrderBy(c => c.NombreUsuario).ToList();
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}

    