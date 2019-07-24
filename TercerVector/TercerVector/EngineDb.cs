using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerVector
{
   public class EngineDb
    {
        //private readonly string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\TercerVector.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1234";
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["TercerVector.Properties.Settings.TercerVectorConnectionString"].ToString();

        public int InsertarRuta(Ruta m)
        {
            int resultado = new int();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                OleDbCommand command = new OleDbCommand(EngineData.SQLRuta, Conexion);
                command.CommandType = CommandType.Text;
                Conexion.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Campo1", m.Campo1);
                command.Parameters.AddWithValue("@Campo2", m.Campo2);
                command.Parameters.AddWithValue("@Campo3", m.Campo3);
                command.Parameters.AddWithValue("@Campo4", m.Campo4);
                command.Parameters.AddWithValue("@Campo5", m.Campo5);
                command.Parameters.AddWithValue("@Campo6", m.Campo6);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }
            return resultado;
        }

        public int InsertarMapa(Mapa m)
        {
            int resultado = new int();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                OleDbCommand command = new OleDbCommand(EngineData.SQLMapa, Conexion);
                command.CommandType = CommandType.Text;
                Conexion.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Uno", m.Uno);
                command.Parameters.AddWithValue("@Dos", m.Dos);
                command.Parameters.AddWithValue("@Tres", m.Tres);
                command.Parameters.AddWithValue("@Cuatro",m.Cuatro);
                command.Parameters.AddWithValue("@Cinco", m.Cinco);
                command.Parameters.AddWithValue("@Seis", m.Seis);
                command.Parameters.AddWithValue("@Siete", m.Siete);
                command.Parameters.AddWithValue("@Ocho", m.Ocho);
                command.Parameters.AddWithValue("@Nueve", m.Nueve);
                command.Parameters.AddWithValue("@Diez", m.Diez);
                command.Parameters.AddWithValue("@Once", m.Once);
                command.Parameters.AddWithValue("@Doce", m.Doce);
                command.Parameters.AddWithValue("@Trece", m.Trece);
                command.Parameters.AddWithValue("@Catorce", m.Catorce);
                command.Parameters.AddWithValue("@Quince", m.Quince);
                command.Parameters.AddWithValue("@Diesiseis", m.Diesiseis);
                command.Parameters.AddWithValue("@Diecisiete", m.Diesisiete);
                command.Parameters.AddWithValue("@Diesiocho", m.Diesiocho);
                command.Parameters.AddWithValue("@Diesinueve", m.Diesinueve);
                command.Parameters.AddWithValue("@Veinte", m.Veinte);
                command.Parameters.AddWithValue("@Veintiuno", m.Veintiuno);
                command.Parameters.AddWithValue("@Veintidos", m.Veintidos);
                command.Parameters.AddWithValue("@Veintitres", m.Veintitres);
                command.Parameters.AddWithValue("@Veinticuatro", m.Veinticuatro);
                command.Parameters.AddWithValue("@Veinticinco", m.Veinticinco);
                command.Parameters.AddWithValue("@Veintiseis", m.Veintiseis);
                command.Parameters.AddWithValue("@Veintisiete", m.Veintisiete);
                command.Parameters.AddWithValue("@Veintiocho", m.Veintiocho);
                command.Parameters.AddWithValue("@Veintinueve", m.Veintinueve);
                command.Parameters.AddWithValue("@Treinta", m.Treinta);
                command.Parameters.AddWithValue("@Treintayuno", m.Treintayuno);
                command.Parameters.AddWithValue("@Treintaydos", m.Treintaydos);
                command.Parameters.AddWithValue("@Treintaytres", m.Treintaytres);
                command.Parameters.AddWithValue("@Treintaycuatro", m.Treintaycuatro);
                command.Parameters.AddWithValue("@Treintaycinco", m.Treintaycinco);
                command.Parameters.AddWithValue("@Treintayseis", m.Treintayseis);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }
            return resultado;
        }

        public DataTable SeleccionarClienteExpirado(string SQL, DateTime FechaExpiracion)
        {
            DataTable dataTabla = new DataTable();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@FechaExpiracion", FechaExpiracion);
                OleDbDataAdapter dataAdaptador = new OleDbDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }
    }
}
