using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace CAPA_DATOS
{
    public class CDCita
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_cita(CECita ocitas)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "insertar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@Id_paciente", ocitas.Id_paciente1);
                ocmd.Parameters.Add("@Id_medico", ocitas.Id_medico1);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompanante", ocitas.Nom_acompañante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }



            
        }
    }
}
