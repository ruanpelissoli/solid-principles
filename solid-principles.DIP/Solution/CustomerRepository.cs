using System.Data;
using System.Data.SqlClient;
using solid_principles.DIP.Solution.Interfaces;

namespace solid_principles.DIP.Solution
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, CREATEDATE) VALUES (@name, @email, @cpf, @createDate))";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("cpf", customer.Cpf);
                cmd.Parameters.AddWithValue("createDate", customer.CreateDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}