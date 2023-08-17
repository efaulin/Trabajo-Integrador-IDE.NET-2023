using Microsoft.Data.SqlClient;

namespace Datos.Old
{
    public class Persona
    {
        /*static SqlConnection conn = BBDD.Conexion();
        public static List<Entidad.Persona> getAll()
        {
            List<Entidad.Persona> lstPersonas = new List<Entidad.Persona>();
            SqlCommand sqlCommand = conn.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Personas";
            conn.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                Entidad.Persona persona = new Entidad.Persona(
                    (int)dr["id"],
                    (string)dr["nombre"],
                    (string)dr["apellido"],
                    (string)dr["tipoDocumento"],
                    (string)dr["numeroDocumento"]);

                lstPersonas.Add(persona);
            }
            conn.Close();
            return lstPersonas;
        }*/
    }
}