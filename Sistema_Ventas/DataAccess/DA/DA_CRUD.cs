using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.DA
{
   public class DA_CRUD
    {

       int precio = 0;

       #region Insertar

       public bool DA_InsertarProducto(string cod, string des, string pre ) {

           precio = Convert.ToInt32(pre); // convertimos el precio a interger porque viene desde el form como string

           SqlConnection conexion = CadenaConexion();
        
          string sintaxis = "INSERT INTO [dbo].[PRODUCTOS] (cod_producto, descripcion, precio) VALUES ( @cod_producto, @descripcion, @precio)";

           
           SqlCommand cmd = new SqlCommand(sintaxis,conexion);
           cmd.CommandType = System.Data.CommandType.Text;
     
           cmd.Parameters.Add(new SqlParameter("@cod_producto", SqlDbType.VarChar));
           cmd.Parameters["@cod_producto"].Value = cod;

           
           cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
           cmd.Parameters["@descripcion"].Value = des;
       
           
           cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Int));
           cmd.Parameters["@precio"].Value = precio;




           try
           {

               conexion.Open();
               cmd.ExecuteNonQuery();
               return true;

           }
           catch (Exception ex)
           {
               return false;
               throw new Exception(ex.Message);
           }
           finally { conexion.Close(); }





       }
       #endregion Insertar


        #region Eliminar

       public bool DA_EliminarProducto(string cod) {

           SqlConnection conexion = CadenaConexion();

           string sintaxis = "DELETE FROM PRODUCTOS WHERE cod_producto = @cod_producto";

           SqlCommand cmd = new SqlCommand(sintaxis, conexion);
           cmd.CommandType = CommandType.Text;


           cmd.Parameters.Add(new SqlParameter("@cod_producto",SqlDbType.VarChar));
           cmd.Parameters["@cod_producto"].Value = cod;

           try
           {

               conexion.Open();
               cmd.ExecuteNonQuery();
               return true;


           }
           catch (Exception ex)
           {
               return false;
               throw new Exception(ex.Message);
           }
           finally { conexion.Close(); }

       
       }


        #endregion Eliminar

       
       #region Modificar

       public bool DA_ModificarProducto(string cod, string des, string pre) {

            precio = Convert.ToInt32(pre);
               

           SqlConnection conexion = CadenaConexion();

           string sintaxis = "UPDATE [dbo].[PRODUCTOS] SET cod_producto = @cod_producto ,descripcion = @descripcion, precio = @precio"+
                             " WHERE cod_producto = @cod_producto" ;

           SqlCommand cmd = new SqlCommand(sintaxis, conexion);
           cmd.CommandType = CommandType.Text;

           cmd.Parameters.Add(new SqlParameter("@cod_producto", SqlDbType.VarChar));
           cmd.Parameters["@cod_producto"].Value = cod;


           cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
           cmd.Parameters["@descripcion"].Value = des;


           cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Int));
           cmd.Parameters["@precio"].Value = precio;


           try
           {

               conexion.Open();
               cmd.ExecuteNonQuery();
               return true;



           }
           catch (Exception ex)
           {
               return false;
               throw new Exception(ex.Message);
           }
           finally { conexion.Close(); }

       }

        #endregion Modificar


        #region Buscar

       public  string[] DA_BuscarProducto(string cod) {

            string[] Producto = new string[3] ;

           SqlConnection conexion = CadenaConexion();

           string sintaxis = "SELECT * FROM PRODUCTOS WHERE cod_producto = @cod_producto";
           
           SqlCommand cmd = new SqlCommand(sintaxis, conexion);
           cmd.CommandType = CommandType.Text;


           cmd.Parameters.Add(new SqlParameter("@cod_producto", SqlDbType.VarChar));
           cmd.Parameters["@cod_producto"].Value = cod;


           try
           {

               conexion.Open();
               SqlDataReader sdr = cmd.ExecuteReader();

                     while (sdr.Read()) {

                   Producto[0] = sdr.GetString(0);
                   Producto[1] = sdr.GetString(1);
                   Producto[2] = sdr.GetValue(2).ToString();
               
                     }
               
              


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message);
           }
           finally { conexion.Close(); }

           return Producto;
       }


        #endregion Buscar




        #region CadenaConexion

       public SqlConnection CadenaConexion() {


           SqlConnection conexion = new SqlConnection("Data Source=ALVARO-ROBERTH\\SQLEXPRESS;Initial Catalog=PRUEB_PULPERIA;Integrated Security=True");


           return conexion;

       }
        
        #endregion

    }
}
