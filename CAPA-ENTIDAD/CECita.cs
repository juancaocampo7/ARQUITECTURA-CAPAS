using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CECita
    {
        private string cod_cita;
        private DateTime fecha;
        private DateTime hora;
        private string Id_paciente;
        private string Id_medico;
        private int valor;
        private string diagnostico;
        private string nom_acompañante;
        private byte activo;

        public string Cod_cita { get => cod_cita; set => cod_cita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Id_paciente1 { get => Id_paciente; set => Id_paciente = value; }
        public string Id_medico1 { get => Id_medico; set => Id_medico = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nom_acompañante { get => nom_acompañante; set => nom_acompañante = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
