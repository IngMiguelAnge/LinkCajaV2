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
        public async Task<bool> SaveUser(UserModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveUser", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Address", obj.Address));
                        cmd.Parameters.Add(new SqlParameter("@User", obj.User));
                        cmd.Parameters.Add(new SqlParameter("@Password", obj.Password));
                        cmd.Parameters.Add(new SqlParameter("@IdTypeUser", obj.IdTypeUser));
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
        public async Task<bool> ChangeStatusUser(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("ChangeStatusUser", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
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
                        cmd.Parameters.Add(new SqlParameter("@IdTypeUser", user.IdTypeUser));
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
        public async Task<UserModel> GetUserSearchbyUser(string User)
        {
            UserModel response = new UserModel();
            List<UserModel> list = new List<UserModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserSearchbyUser", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@User", User));
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
                IdTypeUser = Convert.IsDBNull(reader["IdTypeUser"]) ? 0 : (int)reader["IdTypeUser"],
                Name = (string)reader["Name"],
                Address = (string)reader["Address"],
            };
        }
        private ListUserModel MapToListUser(SqlDataReader reader)
        {
            return new ListUserModel()
            {
                Id = (int)reader["Id"],
                Nombre = (string)reader["Name"],
                Usuario = (string)reader["User"],
                Tipo = (string)reader["TypeUser"],
                Estatus = (string)reader["Status"],
            };
        }
        public async Task<UserModel> GetUserbyId(int Id)
        {
            UserModel response = new UserModel();
            List<UserModel> list = new List<UserModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
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

            }
            return response;
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
                Nombre = (string)reader["Name"],
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
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
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
        public async Task<List<ListClientsModel>> GetClients(string Nombre)
        {
            List<ListClientsModel> list = new List<ListClientsModel>();
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
                                list.Add(MapToListClients(reader));
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
        private ListClientsModel MapToListClients(SqlDataReader reader)
        {
            return new ListClientsModel()
            {
                Id = (int)reader["Id"],
                Nombre = (string)reader["Name"],
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
        #region Articles
        public async Task<ArticleModel> GetArticlebyId(int Id)
        {
            ArticleModel response = new ArticleModel();
            List<ArticleModel> list = new List<ArticleModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticlebyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToArticle(reader));
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
        private ArticleModel MapToArticle(SqlDataReader reader)
        {
            return new ArticleModel()
            {
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
                Code = (string)reader["Code"],
                Stock = Convert.IsDBNull(reader["Stock"]) ? 0 : (decimal)reader["Stock"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
                SuggestedPresentation = Convert.IsDBNull(reader["SuggestedPresentation"]) ? 0 : (int)reader["SuggestedPresentation"],
            };
        }
        public async Task<bool> SaveArticle(ArticleModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveArticle", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Description", obj.Description));
                        cmd.Parameters.Add(new SqlParameter("@Image", obj.Image));
                        cmd.Parameters.Add(new SqlParameter("@Code", obj.Code));
                        cmd.Parameters.Add(new SqlParameter("@Stock", obj.Stock));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", obj.IdPresentation));
                        cmd.Parameters.Add(new SqlParameter("@Price", obj.Price));
                        cmd.Parameters.Add(new SqlParameter("@SuggestedStock", obj.SuggestedStock));
                        cmd.Parameters.Add(new SqlParameter("@SuggestedPresentation", obj.SuggestedPresentation));

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
        public async Task<List<ListArticlesModel>> GetArticles(string Nombre, string Descripcion)
        {
            List<ListArticlesModel> list = new List<ListArticlesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticles", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Description", Descripcion));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListArticles(reader));
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
        private ListArticlesModel MapToListArticles(SqlDataReader reader)
        {
            return new ListArticlesModel()
            {
                Id = (int)reader["Id"],
                Codigo = (string)reader["Code"],
                Articulo = (string)reader["Name"],
                Existencias = (string)reader["Stock"],
                Presentacion = (string)reader["Presentation"],
                Precio = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
            };
        }
        #endregion
        #region Presentation
        public async Task<List<ListPresentationsModel>> GetPresentations()
        {
            List<ListPresentationsModel> list = new List<ListPresentationsModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPresentations", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListPresentations(reader));
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
        private ListPresentationsModel MapToListPresentations(SqlDataReader reader)
        {
            return new ListPresentationsModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
            };
        }

        #endregion
    }
}