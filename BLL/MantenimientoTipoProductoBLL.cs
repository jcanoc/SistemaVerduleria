using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class MantenimientoTipoProductoBLL
    {
 
       
        private readonly MantenimientoTipoProductoDAL _tipoProductoDAL;


        public MantenimientoTipoProductoBLL()
        {
            _tipoProductoDAL = new MantenimientoTipoProductoDAL();
        }

       
        public void InsertaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            _tipoProductoDAL.InsertaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);
        }

        
        public void ActualizaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            _tipoProductoDAL.ActualizaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);
        }

        
        public bool ValidaExistenciaProducto(string nombre)
        {
            return _tipoProductoDAL.ValidaExistenciaProducto(nombre);
        }
    }
}