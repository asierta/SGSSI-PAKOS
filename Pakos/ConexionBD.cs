using System;
using System.Data.SqlClient;

public class accesodatosSQL{
private SqlConnection conexion;
private SqlCommand comando;
    public String conectar() {
        try {
            conexion.ConnectionString = "Server=tcp:pakos.database.windows.net,1433;Initial Catalog=Pakos;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            conexion.Open();
        }
        catch (Exception ex){
            return "ERROR DE CONEXIÓN: " + ex.Message;
        }
        return "CONEXION OK";
    }

    public void cerrarConexion() {
        conexion.Close();
    }
}