﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;



namespace CAPA_DATOS
{
    public class Conexión
    {
        public SqlConnection conectar (string cnx)
        {
            try
            { 
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oconectar.Open ();
                return oconectar;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
