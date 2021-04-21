using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Clases
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string delegacion { get; set; }
        public string departamento { get; set; }
        public string idioma { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string movil { get; set; }
        public string ip { get; set; }
        public string progControlRemoto { get; set; }
        public string pswControlRemoto { get; set; }
        public int? incidencias { get; set; }
        public int? manager { get; set; }
        public int? alta { get; set; }
        public int? baja { get; set; }
        public int? modificado { get; set; }
        public string userAccount { get; set; }
        public int? extension { get; set; }
        public string perfil { get; set; }
        public string delegacionAX { get; set; }
        public string usuarioRegFacturas { get; set; }
        public string emailUsuarioRegistro { get; set; }
        public int? idfact { get; set; }
        public string clavePick { get; set; }
        public string numeroPick { get; set; }
        public string usuarioBFirst { get; set; }

        public  RRHH rrhh { get; set; }

        public object[] getAsParams()
        {
            object[] nuevo = { id , nombre, delegacion, departamento, idioma, email, telefono, movil, ip, progControlRemoto, pswControlRemoto, incidencias, manager, alta, baja, modificado, userAccount, extension, perfil, delegacionAX, usuarioRegFacturas, emailUsuarioRegistro, idfact, clavePick, numeroPick, usuarioBFirst, rrhh.noVisible, rrhh.fechaAlta, rrhh.fechaBaja, rrhh.nombre, rrhh.direccion, rrhh.cp, rrhh.poblacion, rrhh.pais, rrhh.fechaNacimiento, rrhh.estadoCivil, rrhh.dni, rrhh.numSegSocial, rrhh.riesgosLaborales, rrhh.telefono, rrhh.movil, rrhh.email, rrhh.observaciones, rrhh.tipoEmpleado};

            return nuevo;
        }
    }
}
