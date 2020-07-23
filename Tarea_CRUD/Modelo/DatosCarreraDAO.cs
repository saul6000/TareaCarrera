using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace Tarea_CRUD.Modelo


{
   
   public class DatosCarreraDAO
    {
        private static string cadenaConexion = "Server=JOHNDAY;database=TI2020;user id=sa; password=123456;";
        public static int creacion(DatosCarrera datosCarrera)
        {


            //1 Configurar la  conexion de datos con una fuente de datos 
            // string cadenaConexion = "Server=JOHNDAY;database=TI2020;user id=sa; password=123456;";
            //definir un objeto tipo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2 Definir la opercion a realizar en el motor BDD
            //Escribir sentecia SQL
            string sql = "insert into DatosCarrera(Codigo,Materia,Creditos,Carrera," + "Nivel) values(@codigo,@materia,@creditos,@carrera,@nivel)";
            // definir un comando para ejecutar esa sentencia sql (operacion a realizar)
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text; //valor por defecto 
            comando.Parameters.AddWithValue("@codigo",datosCarrera.Codigo );
            comando.Parameters.AddWithValue("@materia",datosCarrera.Materia);
            comando.Parameters.AddWithValue("@creditos",datosCarrera.Creditos);
            comando.Parameters.AddWithValue("@carrera",datosCarrera.Carrera);
            comando.Parameters.AddWithValue("@nivel", datosCarrera.Nivel);
          
            
            //3 Se habre la conexion y se ejecuta el comando 
            conn.Open();

            int x = comando.ExecuteNonQuery();
            //4 cerra la conexion 
            conn.Close();

            return x;
        }
        public static DataTable getAll()
        {

            //1. definir y configurar conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2. Definir y Cinfigurar la operacion a realizar en el motor de BDD 
            //escribir sentencia sql
            string sql = "select  Codigo Código,Materia,Creditos Créditos,Carrera,Nivel,FechaCreacion " + "from DatosCarrera " +
                "order by Codigo,Materia";
            //2.1 Definir un adptador de datos: es un puente que permite pasa los datos de muestra , hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            //3 recuperamos los datos 
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
        public static Boolean existecodigo(string codigo)
        {

            //1. definir y configurar conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2. Definir y Cinfigurar la operacion a realizar en el motor de BDD 
            //escribir sentencia sql
            string sql = "select Codigo " + "from DatosCarrera " + "where Codigo=@codigo";
            //2.1 Definir un adptador de datos: es un puente que permite pasa los datos de muestra , hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codigo", codigo);
            //3 recuperamos los datos 
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Boolean existe = false;
            if (dt.Rows.Count > 0)
                existe = true;
            return existe;

        }
        public static int btbdelete(string codigo)

        {
            SqlConnection conn = new SqlConnection(cadenaConexion);


            string sql = "delete from DatosCarrera  where Codigo=@codigo";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@codigo", codigo);
            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public static DatosCarrera getcarrera(String scedula)
        {

            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "select Codigo,Materia,Creditos,Carrera,Nivel " +
                "from DatosCarrera " +
                "where Codigo=@codigo " +
                "order by Codigo,Materia";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codigo", scedula);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            DatosCarrera carrera = new DatosCarrera();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {

                    carrera.Codigo = fila["Codigo"].ToString();
                    carrera.Materia = fila["Materia"].ToString();
                    carrera.Creditos = int.Parse(fila["Creditos"].ToString());
                    carrera.Carrera = fila["Carrera"].ToString();
                    carrera.Nivel = int.Parse(fila["Nivel"].ToString());
                    
                    break; //abandonar bucle


                }
            }
            return carrera;
        }
        public static int update(DatosCarrera datosCarrera)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);


            string sql = " UPDATE DatosCarrera SET Materia=@materia, Creditos=@credito, Carrera=@carrera,Nivel=@nivel WHERE Codigo=@Codigo";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@Codigo", datosCarrera.Codigo);
            comando.Parameters.AddWithValue("@materia", datosCarrera.Materia);
            comando.Parameters.AddWithValue("@credito", datosCarrera.Creditos);
            comando.Parameters.AddWithValue("@carrera", datosCarrera.Carrera);
            comando.Parameters.AddWithValue("@nivel", datosCarrera.Nivel);
            
            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;
        }

    }
}
