using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LinkCajaV2.Data
{
    public class AppRepository
    {
        public string Connection { get; set; }
        public AppRepository(bool isUnitOfWork = false)
        {
            Connection = "Data Source=.;Initial Catalog=LinkCaja;User ID=sa;Password=admin123;";
        }
        public void Dispose()
        {
            GC.Collect();
        }
        #region ActionsUsers
        public async Task<UserModel> GetUserbyNameAndPassword(string User, string Password)
        {
            UserModel response = new UserModel();
            List<UserModel> list = new List<UserModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserbyNameAndPassword", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@User", User));
                        cmd.Parameters.Add(new SqlParameter("@Password", Password));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToUser(reader));
                            }
                            response = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = null;
            }
            return response;
        }
        private UserModel MapToUser(SqlDataReader reader)
        {
            return new UserModel()
            {
                Id = (int)reader["Id"],
                User = (string)reader["User"],
                Password = (string)reader["Password"],
                Status = (bool)reader["Status"],
                Id_TypeUser = Convert.IsDBNull(reader["Id_TypeUser"]) ? 0 : (int)reader["Id_TypeUser"],
            };
        }
        #endregion
        #region ActionsEmpresa
        public async Task<bool> SaveEmpresa(CompanyModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveCompany", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Address", obj.Address));
                        cmd.Parameters.Add(new SqlParameter("@Manager", obj.Manager));
                        cmd.Parameters.Add(new SqlParameter("@Phone1", obj.Phone1));
                        cmd.Parameters.Add(new SqlParameter("@Phone2", obj.Phone2));
                        cmd.Parameters.Add(new SqlParameter("@Email", obj.Email));
                        cmd.Parameters.Add(new SqlParameter("@Logo", obj.Logo));
                        await sql.OpenAsync().ConfigureAwait(false);
                        await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<CompanyModel> GetCompany()
        {
            CompanyModel response = new CompanyModel();
            List<CompanyModel> list = new List<CompanyModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCompany", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToEmpresa(reader));
                            }
                            response = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = null;
            }
            return response;
        }
        private CompanyModel MapToEmpresa(SqlDataReader reader)
        {
            return new CompanyModel()
            {
                Name = (string)reader["Name"],
                Address = (string)reader["Address"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
                Email = (string)reader["Email"],
                Manager = (string)reader["Manager"],
                Logo = Convert.IsDBNull(reader["Logo"]) ? null : (byte[])reader["Logo"],
            };
        }

        #endregion
    }
}