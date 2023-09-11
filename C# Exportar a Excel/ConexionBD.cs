using System.Data.SqlClient;

namespace C__Exportar_a_Excel
{
    public class ConexionBD
    {
        public SqlConnection conectar = new SqlConnection("server=ASREN-PC\\SQLSERVER ; database = FormatoExcel ; INTEGRATED SECURITY = true");
    }
}
