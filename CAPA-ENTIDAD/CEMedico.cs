﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CEMedico
    {
        private string Id_medico;
        private string nom_medico;
        private string especialidad;
        private string tel_medico;
        private byte activo;

        public string Id_medico1 { get => Id_medico; set => Id_medico = value; }
        public string Nom_medico { get => nom_medico; set => nom_medico = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Tel_medico { get => tel_medico; set => tel_medico = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
