using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Vehiculo
    {
        //Metodo mostrar vehiculos
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarVehiculos()
        {
            string QryMostrarVehiculos = "exec usp_vehiculos_select;";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarVehiculos, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarVehiculos = new DataTable();
            adapter.Fill(dtMostrarVehiculos);
            db_conexion.MtdCerrarConexion();
            return dtMostrarVehiculos;
        }

        //Metodo agregar vehiculos
        public void MtdAgregarVehiculos(string Marca, string Modelo, int Anio, decimal Precio, string Estado)
        {
            db_conexion.MtdAbrirConexion();
            string Usp_crear = "usp_vehiculos_insert";
            SqlCommand cmd_InsertarVehiculos = new SqlCommand(Usp_crear, db_conexion.MtdAbrirConexion());

            cmd_InsertarVehiculos.CommandType = CommandType.StoredProcedure;
            cmd_InsertarVehiculos.Parameters.AddWithValue("@Marca", Marca);
            cmd_InsertarVehiculos.Parameters.AddWithValue("@Modelo", Modelo);
            cmd_InsertarVehiculos.Parameters.AddWithValue("@Anio", Anio);
            cmd_InsertarVehiculos.Parameters.AddWithValue("@Precio", Precio);
            cmd_InsertarVehiculos.Parameters.AddWithValue("@Estado", Estado);

            cmd_InsertarVehiculos.ExecuteNonQuery();
        }

        //Metodo actualizar vehiculo

        public int MtdActualizarVehiculos(int VehiculoID, string Marca, string Modelo, int Anio, decimal Precio, string Estado)
        {
            int vContarRegistrosAfectados = 0;

            string vUspEditarVehiculos = "usp_Vehiculo_update";
            SqlCommand commEditarVehiculos = new SqlCommand(vUspEditarVehiculos, db_conexion.MtdAbrirConexion());
            commEditarVehiculos.CommandType = CommandType.StoredProcedure;

            commEditarVehiculos.Parameters.AddWithValue("@VehiculoID", VehiculoID);
            commEditarVehiculos.Parameters.AddWithValue("@Marca", Marca);
            commEditarVehiculos.Parameters.AddWithValue("@Modelo", Modelo);
            commEditarVehiculos.Parameters.AddWithValue("@Anio", Anio);
            commEditarVehiculos.Parameters.AddWithValue("@Precio", Precio);
            commEditarVehiculos.Parameters.AddWithValue("@Estado", Estado);


            vContarRegistrosAfectados = commEditarVehiculos.ExecuteNonQuery();
            return vContarRegistrosAfectados;
        }

        //Metodo Eliminar vehiculo
        public void MtdEliminarVehiculo(int VehiculoID)
        {
            string usp_eliminar = "usp_Vehiculo_delete";
            SqlCommand cmdUspEliminar = new SqlCommand(usp_eliminar, db_conexion.MtdAbrirConexion());
            cmdUspEliminar.CommandType = CommandType.StoredProcedure;
            cmdUspEliminar.Parameters.AddWithValue("@VehiculoID", VehiculoID);
            cmdUspEliminar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }

        //Metodo para obtener el ultimo ID
        public int ObtenerUltimoID()
        {
            int ultimoID = 0;
            try
            {
                SqlCommand cmd_UltimoID = new SqlCommand("SELECT TOP 1 VehiculoID FROM tblVehiculos ORDER BY VehiculoID DESC", db_conexion.MtdAbrirConexion());
                SqlDataReader reader = cmd_UltimoID.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    ultimoID = Convert.ToInt32(reader["VehiculoID"]);
                }

                reader.Close();
                db_conexion.MtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el último código de cuenta: " + ex.Message);
            }

            return ultimoID;
        }


    }
}
