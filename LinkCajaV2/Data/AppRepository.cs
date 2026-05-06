using LinkCajaV2.Catalogs;
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
        #region PricesSuppliers
        public async Task<bool> UpdateAllStatusPrices(int IdArticle)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateAllStatusPrices", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", IdArticle));
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
        public async Task<bool> SavePricesSuppliers(PricesSuppliersModel item)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SavePricesSuppliers", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", item.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdSupplier", item.IdSupplier));
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", item.IdArticle));
                        cmd.Parameters.Add(new SqlParameter("@PriceUnit", item.PriceUnit));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", item.IdPresentation));
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
        public async Task<HighPriceModel> GetHighPrice(int IdArticle)
        {
            HighPriceModel Result = new HighPriceModel();
            List<HighPriceModel> list = new List<HighPriceModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetHighPrice", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", IdArticle));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToHighPrice(reader));
                            }
                            Result = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Result= null;
            }
            return Result;
        }
        private HighPriceModel MapToHighPrice(SqlDataReader reader)
        {
            return new HighPriceModel()
            {
                Price = (decimal)reader["Price"],
                IdPresentation = (int)reader["IdPresentation"],
                Presentation = (string)reader["Presentation"],
            };
        }
        public async Task<List<ListPricesSuppliersModel>> GetPricesSuppliersActives(int IdArticle)
        {
            List<ListPricesSuppliersModel> list = new List<ListPricesSuppliersModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPricesSuppliersActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", IdArticle));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListPricesSuppliers(reader));
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
        private ListPricesSuppliersModel MapToListPricesSuppliers(SqlDataReader reader)
        {
            return new ListPricesSuppliersModel()
            {
                Id = (int)reader["Id"],
                IdSupplier = (int)reader["IdSupplier"],
                Name = (string)reader["Name"],
                PriceUnit = (decimal)reader["PriceUnit"],
                IdPresentation = (int)reader["IdPresentation"]
            };
        }
        #endregion
        #region Items
        public async Task<bool> UpdateAllStatusItems(int IdRecipe)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateAllStatusItems", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdRecipe", IdRecipe));
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
        public async Task<bool> SaveItem(ItemModel item)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveItem", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdRecipe", item.IdRecipe));
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", item.IdArticle));
                        cmd.Parameters.Add(new SqlParameter("@Use_Stock", item.Use_Stock));
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
        public async Task<List<ItemsRecipeModel>> GetItemsRecipe(int IdRecipe)
        {
            List<ItemsRecipeModel> list = new List<ItemsRecipeModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetItemsRecipe", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdRecipe", IdRecipe));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToItemsRecipe(reader));
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
        private ItemsRecipeModel MapToItemsRecipe(SqlDataReader reader)
        {
            return new ItemsRecipeModel()
            {
                IdArticle = (int)reader["IdArticle"],
                Code = (string)reader["Code"],
                Name = (string)reader["Name"],
                Stock = (decimal)reader["Stock"],
                Presentation = (string)reader["Presentation"],
                Price = (decimal)reader["Price"],
                Total = (decimal)reader["Total"],
                Decimals = (int)reader["Decimals"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
            };
        }
        #endregion
        #region ActionsRecipes
        public async Task<RecipeModel> GetRecipeByIdorCode(int Id, string Code)
        {
            RecipeModel response = new RecipeModel();
            List<RecipeModel> list = new List<RecipeModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetRecipeByIdorCode", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToRecipe(reader));
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
        private RecipeModel MapToRecipe(SqlDataReader reader)
        {
            return new RecipeModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
                Code = (string)reader["Code"],
                Stock = Convert.IsDBNull(reader["Stock"]) ? 0 : (decimal)reader["Stock"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
                Status = (bool)reader["Status"],
            };
        }
        public async Task<int> SaveRecipe(RecipeModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveRecipe", sql))
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
                        SqlParameter outputParam = new SqlParameter("@VResp", System.Data.SqlDbType.Int)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);
                        await sql.OpenAsync().ConfigureAwait(false);
                        await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                        int idGenerado = (outputParam.Value != DBNull.Value) ? Convert.ToInt32(outputParam.Value) : 0;

                        return idGenerado;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
         #endregion
        #region ActionsBox
        public async Task<List<ListBoxModel>> GetBoxsActives()
        {
            List<ListBoxModel> list = new List<ListBoxModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetBoxsActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListBox(reader));
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
        public async Task<List<ListBoxModel>> GetBoxs(string Name)
        {
            List<ListBoxModel> list = new List<ListBoxModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetBoxs", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", Name));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListBox(reader));
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
        public async Task<BoxModel> GetBoxsbyHardwareID(string HardwareID)
        {
            BoxModel response = new BoxModel();
            List<BoxModel> list = new List<BoxModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetBoxsbyHardwareID", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@HardwareID", HardwareID));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToBox(reader));
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
        public async Task<BoxModel> GetBoxsbyId(int Id)
        {
            BoxModel response = new BoxModel();
            List<BoxModel> list = new List<BoxModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetBoxsbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToBox(reader));
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
        private BoxModel MapToBox(SqlDataReader reader)
        {
            return new BoxModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                HardwareID = (string)reader["HardwareID"],
                Estatus = (string)reader["Estatus"],
            };
        }
        private ListBoxModel MapToListBox(SqlDataReader reader)
        {
            return new ListBoxModel()
            {
                Id = (int)reader["Id"],
                Nombre = (string)reader["Name"],
                Estatus = (string)reader["Estatus"],
            };
        }
        public async Task<bool> SaveBox(BoxModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveBox", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@HardwareID", obj.HardwareID));
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
        public async Task<bool> UpdateStatusBox(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusBox", sql))
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
        #endregion
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
        public async Task<bool> UpdateStatusUser(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusUser", sql))
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
        public async Task<UserModel> GetUserbyUser(string User)
        {
            UserModel response = new UserModel();
            List<UserModel> list = new List<UserModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserbyUser", sql))
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
                        cmd.Parameters.Add(new SqlParameter("@CP", obj.CP));
                        cmd.Parameters.Add(new SqlParameter("@RFC", obj.RFC));
                        cmd.Parameters.Add(new SqlParameter("@Regimen", obj.Regimen));
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
                CP = Convert.IsDBNull(reader["CP"]) ? 0 : (int)reader["CP"],
                RFC = (string)reader["RFC"],
                Regimen = (string)reader["Regimen"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
                Email = (string)reader["Email"],
                Manager = (string)reader["Manager"],
                Logo = Convert.IsDBNull(reader["Logo"]) ? null : (byte[])reader["Logo"],
            };
        }

        #endregion
        #region Suppliers
        public async Task<bool> UpdateStatusSupplier(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusSupplier", sql))
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
        public async Task<List<ListSuppliersActivesModel>> GetSuppliersActives()
        {
            List<ListSuppliersActivesModel> list = new List<ListSuppliersActivesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSuppliersActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListSuppliersActives(reader));
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
                Estatus = (string)reader["Status"],
            };
        }
        private ListSuppliersActivesModel MapToListSuppliersActives(SqlDataReader reader)
        {
            return new ListSuppliersActivesModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
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
        public async Task<bool> UpdateStatusClient(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusClient", sql))
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
                Estatus = (string)reader["Status"],
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
        #region Keys
        public async Task<bool> SaveKey(KeysModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveKeys", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Key", obj.Key));
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
        public async Task<List<KeysModel>> GetKeys()
        {
            List<KeysModel> list = new List<KeysModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetKeys", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToKeys(reader));
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
        public async Task<KeysModel> GetKeysActive()
        {
            KeysModel obj = new KeysModel();
            List<KeysModel> list = new List<KeysModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetKeys", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToKeys(reader));
                            }
                            obj = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return obj;
        }
        private KeysModel MapToKeys(SqlDataReader reader)
        {
            return new KeysModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Key = (string)reader["Key"],
            };
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
        #region Stock
        public async Task<bool> SaveStock(StockModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveStock", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@Stock", obj.Stock));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", obj.IdPresentation));
                        cmd.Parameters.Add(new SqlParameter("@Price", obj.Price));
                        cmd.Parameters.Add(new SqlParameter("@SuggestedStock", obj.SuggestedStock));

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
        public async Task<StockModel> GetStock(int Id)
        {
            StockModel response = new StockModel();
            List<StockModel> list = new List<StockModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetStock", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToStock(reader));
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
        private StockModel MapToStock(SqlDataReader reader)
        {
            return new StockModel()
            {
                Id = (int)reader["Id"],
                Stock = Convert.IsDBNull(reader["Stock"]) ? 0 : (decimal)reader["Stock"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Presentation = Convert.IsDBNull(reader["Image"]) ? string.Empty : (string)reader["Presentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
                Margen = Convert.IsDBNull(reader["Margen"]) ? 0 : (decimal)reader["Margen"],
            };
        }
        #endregion
        #region Articles
        public async Task<bool> UpdateStatusArticle(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusArticle", sql))
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
        public async Task<ArticleModel> GetArticle(int Id, string Code)
        {
            ArticleModel response = new ArticleModel();
            List<ArticleModel> list = new List<ArticleModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticle", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
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
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
                Code = (string)reader["Code"],
                Status = (bool)reader["Status"],
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
        public async Task<List<ListArticlesModel>> GetArticles(string Code, string Nombre, bool IsReceta)
        {
            List<ListArticlesModel> list = new List<ListArticlesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticles", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        cmd.Parameters.Add(new SqlParameter("@IsReceta", IsReceta));
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
        public async Task<List<ListArticlesModel>> GetArticlesActives(string Code, string Nombre)
        {
            List<ListArticlesModel> list = new List<ListArticlesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticlesActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
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
        public async Task<AllArticleModel> GetArticleActive(int Id, string Code)
        {
            AllArticleModel response = new AllArticleModel();
            List<AllArticleModel> list = new List<AllArticleModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticleActive", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToAllArticle(reader));
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
        private AllArticleModel MapToAllArticle(SqlDataReader reader)
        {
            return new AllArticleModel()
            {
                Id = (int)reader["Id"],
                Code = (string)reader["Code"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
                Status = (bool)reader["Status"],
                Stock = Convert.IsDBNull(reader["Stock"]) ? 0 : (decimal)reader["Stock"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Presentation = Convert.IsDBNull(reader["Presentation"]) ? string.Empty : (string)reader["Presentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
            };
        }
        private ListArticlesModel MapToListArticles(SqlDataReader reader)
        {
            return new ListArticlesModel()
            {
                Id = (int)reader["Id"],
                Codigo = (string)reader["Code"],
                Articulo = (string)reader["Name"],
                Existencias = (string)reader["Stock"],
                Precio = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                PorCada = (string)reader["PorCada"],
                Estatus = (string)reader["Status"],
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
                Presentation = Convert.IsDBNull(reader["Presentation"]) ? string.Empty : (string)reader["Presentation"],
                Decimals = (int)reader["Decimals"],
            };
        }
        public async Task<PresentationModel> GetPresentationbyId(int id)
        {
            List<PresentationModel> list = new List<PresentationModel>();
            PresentationModel response = new PresentationModel();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPresentationbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToPresentations(reader));
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
        private PresentationModel MapToPresentations(SqlDataReader reader)
        {
            return new PresentationModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Decimals = (int)reader["Decimals"]
            };
        }
        #endregion
    }
}