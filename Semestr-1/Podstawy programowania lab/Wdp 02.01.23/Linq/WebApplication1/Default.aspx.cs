using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public DataTable GetDataTable()
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader read;
            // polaczenie lokalne
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=aspnet;Integrated Security=True;");
            // polaczenie zdalne
            //conn = new SqlConnection("Data Source=192.168.0.114\\SQL;Initial Catalog=aspnet;Integrated Security=False;user=pass;password=pass-1234");
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select p1,p2,i1 from aspnet";
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table= new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataTable tabela = GetDataTable();
            var query =
                from wiersz in tabela.AsEnumerable()
                select wiersz;
            foreach (DataRow p in query)
            {
                ListBox1.Items.Add(
                    p.Field<string>("p1") == null ? "" : p.Field<string>("p1") 
                    + " : "
                    + p.Field<int?>("i1").ToString()
                );
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataTable tabela = GetDataTable();
            var query =
                from wiersz in tabela.AsEnumerable()
                where wiersz.Field<Int32?>("i1") == 10
                where wiersz.Field<string>("p1").Trim() == "aaa"
                where (string)wiersz["p2"].ToString().Trim() == "aaa"
                orderby wiersz["i1"] descending
                select wiersz;
            foreach (DataRow p in query)
            {
                ListBox1.Items.Add(p.Field<string>("p1") + " : " + p.Field<int>("i1").ToString());
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataTable tabela = GetDataTable();
            var query = tabela.AsEnumerable().
                Select(wiersz => new
                {
                    PierwszePole = wiersz.Field<string>("p1"),
                    DrugiePole = wiersz.Field<Int32?>("i1")
                });
            foreach (var wiersz in query)
            {
                ListBox1.Items.Add(wiersz.PierwszePole + " : " + wiersz.DrugiePole.ToString());
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataTable tabela = GetDataTable();
            var query =
                from wiersz in tabela.AsEnumerable()
                where wiersz.Field<int?>("i1") < 150
                select wiersz;
            var query2 =
                query.Where(wiersz => wiersz.Field<int?>("i1") < 100);

            foreach (DataRow p in query2)
            {
                ListBox1.Items.Add(p.Field<string>("p1") + " : " + p.Field<int?>("i1").ToString());
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataTable tabela = GetDataTable();
            var query =
                from wiersz in tabela.AsEnumerable()
                join wiersz2 in tabela.AsEnumerable()
                on wiersz.Field<int?>("i1") equals wiersz2.Field<int?>("i1")
                select new
                {
                    PierwszePole = wiersz.Field<string>("p1"),
                    DrugiePole = wiersz2.Field<string>("p1"),
                    TrzeciePole = wiersz2.Field<int?>("i1"),

                };
            foreach (var wiersz in query)
            {
                ListBox1.Items.Add(wiersz.PierwszePole + " : " + wiersz.DrugiePole + " = " + wiersz.TrzeciePole);
            }
        }
       
    }
}
