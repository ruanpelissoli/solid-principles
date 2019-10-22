using System.Data;
using System.Data.SqlClient;

namespace solid_principles.DIP.Violation
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, CREATEDAT) VALUES (@name, @email, @cpf, @createdAt))";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("cpf", customer.Cpf);
                cmd.Parameters.AddWithValue("createdAt", customer.CreatedAt);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
