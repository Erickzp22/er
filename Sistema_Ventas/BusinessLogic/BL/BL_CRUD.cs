using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.BL
{
   public class BL_CRUD
    {


        #region Insertar

        public bool BL_InsertarProducto(string cod, string des, string pre)
        {

            return new Data_Access.DA.DA_CRUD().DA_InsertarProducto(cod, des, pre);
                

        }
        #endregion Insertar


        #region Eliminar

        public bool BL_EliminarProducto(string cod)
        {

            return new Data_Access.DA.DA_CRUD().DA_EliminarProducto(cod);

        }


        #endregion Eliminar


        #region Modificar

        public bool BL_ModificarProducto(string cod, string des, string pre)
        {

            return new Data_Access.DA.DA_CRUD().DA_ModificarProducto(cod, des, pre);

        }

        #endregion Modificar


        #region Buscar

        public string[] BL_BuscarProducto(string cod)
        {

            return new Data_Access.DA.DA_CRUD().DA_BuscarProducto(cod);
        }


        #endregion Buscar



    }
}
