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
        public static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=aspnet;Integrated Security=True;";
        public SqlConnection SqlConnection = new SqlConnection(connectionString);               //Integrated Security=True
        public SqlCommand SqlCommand = new SqlCommand();  
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }



        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            GridView1.DataBind();
            GridView1.SelectedIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();  // otwieramy połączenie
                string p1 = TextBox1.Text;
                string p2 = TextBox2.Text;
                p1.Trim();
                p2.Trim();
                string insertQuery = "INSERT into aspnet(p1,p2) values(" + p1 + "," + p2 + ")";
                SqlCommand.CommandText = insertQuery;
                SqlCommand.Connection = SqlConnection;
                SqlCommand.ExecuteNonQuery();
                  
                SqlConnection.Close();
                GridView1.DataBind();
                GridView1.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
              
            } 



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataReader read;

            try
            {
                SqlConnection.Open();  // otwieramy połączenie
                SqlCommand.CommandText = "select * from aspnet";
                SqlCommand.CommandType = CommandType.Text;
                SqlCommand.Connection = SqlConnection;
                SqlDataAdapter da = new SqlDataAdapter(SqlCommand);
                DataSet ds = new DataSet();
                read = SqlCommand.ExecuteReader();
                while (read.Read())
                {
                    ListBox1.Items.Add(read[1].ToString());
                }
                }
            catch (Exception ex)
            {

            }
        }

        protected void SqlDataSource2_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

       
    }
}
