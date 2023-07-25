using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic;
using Entidad;

namespace Datos.Old
{
    public class BBDD
    {
        /*static string sCnn =
            @"data source=.\SQLEXPRESS; " +
            "initial catalog=TPI2023TM03; " +
            "Encrypt=false;" +
            "user ID=net; Password=net";

        static SqlConnection conn = new SqlConnection(sCnn);

        public static SqlConnection Conexion()
        {
            return conn;
        }

        //Prueba
        public static void select(string atributo, string tabla)
        {
            SqlCommand sqlCommand = conn.CreateCommand();
            sqlCommand.CommandText = "SELECT " + atributo + " FROM " + tabla;
            conn.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["nombre"].ToString());
            }
            conn.Close();
        }*/

        #region Arrays para probar funcionamiento
        //Habitacion
        static List<string[]> _arrayHabitacion = new List<string[]>()
        {
            new string[] {"1", "1", "true", "12", "0"},
            new string[] {"2", "2", "true", "25", "0"},
            new string[] {"3", "3", "true", "201", "2"},
            new string[] {"4", "1", "true", "311", "3"}
        };

        //Tipo Habitacion
        static List<string[]> _arrayTipoHabitacion = new List<string[]>()
        {
            new string[] {"1", "Delux"},
            new string[] {"2", "Simple"},
            new string[] {"3", "Doble"},
            new string[] {"4", "Triple"}
        };

        //Relacion TipoHabitacion<>Habitacion
        static List<string[]> _arrayRelacionTipoHabitacionHabitacion = new List<string[]>()
        {
            new string[] {"1", "2"},
            new string[] {"2", "3"},
            new string[] {"3", "4"},
            new string[] {"4", "1"}
        };

        //TipHab_Precio
        static List<string[]> _arrayTipHab_precio = new List<string[]>()
        {
            new string[] {"1", "01/01/2023", "15.50"},
            new string[] {"2", "03/04/2023", "5.00"},
            new string[] {"3", "05/05/2023", "9.50"},
            new string[] {"4", "24/06/2023", "13.50"}
        };

        //Relacion TipoHabitacion<>TipHab_Precio
        static List<string[]> _arrayRelacionTipoHabitacionTipHab_Precio = new List<string[]>()
        {
            new string[] {"1", "1"},
            new string[] {"2", "2"},
            new string[] {"3", "3"},
            new string[] {"4", "4"}
        };
        #endregion

        #region Metodos para los arrays
        public static List<string[]> ArrayHabitacion() { return _arrayHabitacion; }
        public static List<string[]> ArrayTipoHabitacion() { return _arrayTipoHabitacion; }
        public static List<string[]> ArrayTipHab_Precio() { return _arrayTipHab_precio; }
        public static List<string[]> ArrayTipoHabitacionHabitacion() { return _arrayRelacionTipoHabitacionHabitacion; }
        public static List<string[]> ArrayTipoHabitacionTipHab_Precio() { return _arrayRelacionTipoHabitacionTipHab_Precio; }

        #endregion
    }
}
