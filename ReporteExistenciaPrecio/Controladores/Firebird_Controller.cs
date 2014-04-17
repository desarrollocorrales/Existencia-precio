﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ReporteExistenciaPrecio.Modelos;
using System.IO;

namespace ReporteExistenciaPrecio.Controladores
{
    public class Firebird_Controller
    {
        private FbConnection FbConn;
        private FbCommand FbComm;
        private FbDataAdapter FbAdapter;

        public Firebird_Controller()
        {
            FbConn = new FbConnection();
            FbConn.ConnectionString = getConnectionString();
            FbComm = new FbCommand();

            FbAdapter = new FbDataAdapter();
        }

        private string getConnectionString()
        {
            StringBuilder sbStringConn = new StringBuilder();
            sbStringConn.Append(string.Format("User={0};", Microsip.Usuario));
            sbStringConn.Append(string.Format("Password={0};", Microsip.Contraseña));
            sbStringConn.Append(string.Format("Database={0};", Microsip.Servidor));
            //sbStringConn.Append(string.Format("DataSource={0};", Microsip.Host));
            sbStringConn.Append(string.Format("Port={0};", Microsip.Puerto));

            return (sbStringConn.ToString());
        }

        public List<Almacen> getAlmacenes()
        {
            List<Almacen> lstAlmacenes = new List<Almacen>();         
            FbConn.Open();
            FbComm.Connection = FbConn;
            
            FbComm.CommandText = "SELECT ALMACEN_ID, NOMBRE FROM ALMACENES";
            FbAdapter.SelectCommand = FbComm;

            System.Data.DataTable dtConsulta = new System.Data.DataTable();
            FbAdapter.Fill(dtConsulta);

            foreach (System.Data.DataRow fila in dtConsulta.Rows)
            {
                Almacen almacen = new Almacen();
                almacen.IdAlmacen = Convert.ToInt32(fila["ALMACEN_ID"]);
                almacen.NombreAlmacen = Convert.ToString(fila["NOMBRE"]);
                lstAlmacenes.Add(almacen);
            }

            FbConn.Close();
            return lstAlmacenes;
        }

        public List<FiltroGrupos> getGrupos()
        {
            List<FiltroGrupos> lstGrupos = new List<FiltroGrupos>();
            FbConn.Open();
            FbComm.Connection = FbConn;

            FbComm.CommandText = "SELECT GRUPO_LINEA_ID, NOMBRE FROM GRUPOS_LINEAS";
            FbAdapter.SelectCommand = FbComm;

            System.Data.DataTable dtConsulta = new System.Data.DataTable();
            FbAdapter.Fill(dtConsulta);

            foreach (System.Data.DataRow fila in dtConsulta.Rows)
            {
                FiltroGrupos Grupo = new FiltroGrupos();
                Grupo.IdGrupo = Convert.ToInt32(fila["GRUPO_LINEA_ID"]);
                Grupo.Grupo = Convert.ToString(fila["NOMBRE"]);
                lstGrupos.Add(Grupo);
            }

            FbConn.Close();
            return lstGrupos;
        }

        public List<Reporte> getPreciosExistencias(string AlmacenID, string GruposIDs)
        {
            List<Reporte> dsReporte = new List<Reporte>();

            FbConn.Open();
            FbComm.Connection = FbConn;

            StreamReader sr = new StreamReader(".\\conf\\Consulta.sql");
            FbComm.CommandText = sr.ReadToEnd();
            sr.Close();
            FbComm.CommandText = FbComm.CommandText.Replace("|ALMACEN_ID|", AlmacenID);
            FbComm.CommandText = FbComm.CommandText.Replace("|GRUPOS|", GruposIDs);
            FbAdapter.SelectCommand = FbComm;

            System.Data.DataTable dtConsulta = new System.Data.DataTable();
            FbAdapter.Fill(dtConsulta);

            foreach (System.Data.DataRow fila in dtConsulta.Rows)
            {
                Reporte Report = new Reporte();
                Report.Articulo = Convert.ToString(fila["ARTICULO"]);
                Report.Existencia = fila["EXISTENCIA"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["EXISTENCIA"]);
                Report.PrecioFilial = fila["FILIAL"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["FILIAL"]);
                Report.PrecioMayoreo = fila["MAYOREO"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["MAYOREO"]);
                Report.PrecioLista = fila["LISTA"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["LISTA"]);
                dsReporte.Add(Report);
            }

            FbConn.Close();

            return dsReporte;
        }
    }
}
