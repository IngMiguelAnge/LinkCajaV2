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
        public async Task<List<ListUserModel>> GetUsers(UserModel user)
        {
            List<ListUserModel> list = new List<ListUserModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUsers", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@User", user.User));
                        cmd.Parameters.Add(new SqlParameter("@Name", user.Name));
                        cmd.Parameters.Add(new SqlParameter("@Id_TypeUser", user.Id_TypeUser));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListUser(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }

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
                Name = (string)reader["Name"],
                Address = (string)reader["Address"],
            };
        }
        private ListUserModel MapToListUser(SqlDataReader reader)
        {
            return new ListUserModel()
            {
                Id = (int)reader["Id"],
                User = (string)reader["User"],
                Name = (string)reader["Name"],
                TypeUser = (string)reader["TypeUser"],
            };
        }
        #endregion
        #region ActionsEmpresa
        public async Task<bool> SaveCompany(CompanyModel obj)
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
        #region Suppliers
        public async Task<List<ListSuppliersModel>> GetSuppliers(string Nombre)
        {
            List<ListSuppliersModel> list = new List<ListSuppliersModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSuppliers", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListSuppliers(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
             
            }
            return list;
        }
        public async Task<SuppliersModel> GetSuppliersbyId(int Id)
        {
            SuppliersModel response = new SuppliersModel();
            List<SuppliersModel> list = new List<SuppliersModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSuppliersbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToSuppliers(reader));
                            }
                            response = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return response;
        }
        private SuppliersModel MapToSuppliers(SqlDataReader reader)
        {
            return new SuppliersModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Address = (string)reader["Address"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
                Email = (string)reader["Email"],
            };
        }
        private ListSuppliersModel MapToListSuppliers(SqlDataReader reader)
        {
            return new ListSuppliersModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Email = (string)reader["Email"],
            };
        }
        public async Task<bool> SaveSupplier(SuppliersModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveSupplier", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Address", obj.Address));
                        cmd.Parameters.Add(new SqlParameter("@Phone1", obj.Phone1));
                        cmd.Parameters.Add(new SqlParameter("@Phone2", obj.Phone2));
                        cmd.Parameters.Add(new SqlParameter("@Email", obj.Email));
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
        #endregion
        #region Clients
        public async Task<List<ClientsModel>> GetClients(string Nombre)
        {
            List<ClientsModel> list = new List<ClientsModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetClients", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToClients(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }
        public async Task<ClientsModel> GetClientsbyId(int Id)
        {
            ClientsModel response = new ClientsModel();
            List<ClientsModel> list = new List<ClientsModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetClientsbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToClients(reader));
                            }
                            response = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return response;
        }
        private ClientsModel MapToClients(SqlDataReader reader)
        {
            return new ClientsModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Address = (string)reader["Address"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
                Email = (string)reader["Email"],
            };
        }
        public async Task<bool> SaveClient(ClientsModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveClient", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Address", obj.Address));
                        cmd.Parameters.Add(new SqlParameter("@Phone1", obj.Phone1));
                        cmd.Parameters.Add(new SqlParameter("@Phone2", obj.Phone2));
                        cmd.Parameters.Add(new SqlParameter("@Email", obj.Email));
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
        #endregion
        #region TypesUsers
        public async Task<List<TypesUsersModel>> GetTypesUsers()
        {
            List<TypesUsersModel> list = new List<TypesUsersModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetTypesUsers", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToTypesUsers(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }
        private TypesUsersModel MapToTypesUsers(SqlDataReader reader)
        {
            return new TypesUsersModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
            };
        }

        #endregion
    }
}