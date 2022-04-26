using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CEPaciente
    {
        private string Id_paciente;
        private string Tipo_doc;
        private string nom_paciente;
        private string dir_paciente;
        private string tel_paciente;
        private string cel_paciente;
        private byte activo;

        public string Id_paciente1 { get => Id_paciente; set => Id_paciente = value; }
        public string Tipo_doc1 { get => Tipo_doc; set => Tipo_doc = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public string Dir_paciente { get => dir_paciente; set => dir_paciente = value; }
        public string Tel_paciente { get => tel_paciente; set => tel_paciente = value; }
        public string Cel_paciente { get => cel_paciente; set => cel_paciente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
