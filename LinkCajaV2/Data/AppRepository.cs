using LinkCajaV2.Catalogs;
using LinkCajaV2.Configurations;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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
        #region Prize
        public async Task<List<PrizeModel>> GetPrizesValids()
        {
            List<PrizeModel> list = new List<PrizeModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPrizesValids", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToPrizeModel(reader));
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
        public async Task<List<ListPrizesModel>> GetPrizes(int Id, string Nombre)
        {
            List<ListPrizesModel> list = new List<ListPrizesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPrizes", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListPrizes(reader));
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
        private ListPrizesModel MapToListPrizes(SqlDataReader reader)
        {
            return new ListPrizesModel()
            {
                Id = (int)reader["Id"],
                IdArticle = (int)reader["IdArticle"],
                Nombre = (string)reader["Article"],
                Cantidad = (string)reader["Stock"],
                Estatus = (string)reader["Status"],
            };
        }
        private PrizeModel MapToPrizeModel(SqlDataReader reader)
        {
            return new PrizeModel()
            {
                Id = (int)reader["Id"],
                IdArticle = (int)reader["IdArticle"],
                Stock = (decimal)reader["Stock"],
                Status = (bool)reader["Status"],
            };
        }
        public async Task<bool> SavePrize(PrizeModel Prize)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SavePrize", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Prize.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", Prize.IdArticle));
                        cmd.Parameters.Add(new SqlParameter("@Stock", Prize.Stock));
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
        public async Task<bool> UpdateStatusPrize(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusPrize", sql))
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
        #region SearchSAT       
        private CodeSatModel MapToSAT(SqlDataReader reader)
        {
            return new CodeSatModel()
            {
                Id = (string)reader["id"],
                Descripcion = (string)reader["descripcion"],
                Similares = (string)reader["similares"],
            };
        }
        //Método auxiliar para extraer todo de SQL e indexarlo en Lucene(Solo se corre una vez)
        public async Task<List<CodeSatModel>> GetCodeSAT(string descripcion)
        {
            List<CodeSatModel> list = new List<CodeSatModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCodeSAT", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Description", descripcion));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToSAT(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tu manejo de errores
            }
            return list;
        }

        #endregion
        #region Grafics
        public async Task<List<GraphModel>> GetSolds(DateTime Desde, DateTime Hasta)
        {
            List<GraphModel> list = new List<GraphModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSolds", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@CheckIn", Desde));
                        cmd.Parameters.Add(new SqlParameter("@CheckOut", Hasta));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToArticlesSolds(reader));
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
        public async Task<List<GraphModel>> GetArticlesSolds(DateTime Desde, DateTime Hasta, int IdPresentation,int IdProveedor)
        {
            List<GraphModel> list = new List<GraphModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticlesSolds", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@CheckIn", Desde));
                        cmd.Parameters.Add(new SqlParameter("@CheckOut", Hasta));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", IdPresentation));
                        cmd.Parameters.Add(new SqlParameter("@IdProveedor", IdProveedor));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToArticlesSolds(reader));
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
        private GraphModel MapToArticlesSolds(SqlDataReader reader)
        {
            return new GraphModel()
            {
                CordY = (string)reader["Name"],
                CordX = (decimal)reader["Total"],
            };
        }
        #endregion
        #region Retirements
        public async Task<bool> SaveRetirement(RetirementModel retirement)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveRetirement", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", retirement.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdCashfund", retirement.IdCashfund));
                        cmd.Parameters.Add(new SqlParameter("@Concept", retirement.Concept));
                        cmd.Parameters.Add(new SqlParameter("@Amount", retirement.Amount));
                        cmd.Parameters.Add(new SqlParameter("@Created", retirement.Created));
                        cmd.Parameters.Add(new SqlParameter("@Retire", retirement.Retire));
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
        public async Task<bool> UpdateStatusRetirement(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusRetirement", sql))
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
        public async Task<List<ListRetirementsModel>> GetRetirementsByIdCashfund(int IdCashfund, bool Retire)
        {
            List<ListRetirementsModel> list = new List<ListRetirementsModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetRetirementsByIdCashfund", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdCashfund", IdCashfund));
                        cmd.Parameters.Add(new SqlParameter("@Retire", Retire));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToRetirements(reader));
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
        private ListRetirementsModel MapToRetirements(SqlDataReader reader)
        {
            return new ListRetirementsModel()
            {
                Id = (int)reader["Id"],
                Concept = (string)reader["Concept"],
                Amount = (decimal)reader["Amount"],
                Created = (DateTime)reader["Created"],
                Status = (string)reader["Status"],
            };
        }
        #endregion
        #region Categories
        public async Task<List<CategorieModel>> GetCategoriesActives()
        {
            List<CategorieModel> list = new List<CategorieModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCategoriesActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCategorie(reader));
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
        public async Task<CategorieModel> GetCategoriebyId(int Id)
        {
            CategorieModel obj = new CategorieModel();
            List<CategorieModel> list = new List<CategorieModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCategoriebyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCategorie(reader));
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
        private CategorieModel MapToCategorie(SqlDataReader reader)
        {
            return new CategorieModel()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Status = (bool)reader["Status"],
            };
        }
        public async Task<bool> SaveCategorie(int Id, string Name)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveCategorie", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@Name", Name));
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
        public async Task<bool> UpdateStatusCategorie(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusCategorie", sql))
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
        public async Task<List<ListCategoriesModel>> GetCategories(string Nombre)
        {
            List<ListCategoriesModel> list = new List<ListCategoriesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCategories", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListCategories(reader));
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
        private ListCategoriesModel MapToListCategories(SqlDataReader reader)
        {
            return new ListCategoriesModel()
            {
                Id = (int)reader["Id"],
                Nombre = (string)reader["Name"],
                Estatus = (string)reader["Status"],
            };
        }

        #endregion
        #region CashDrop
        public async Task<List<CashDropModel>> GetCashDropbyIdBox(int IdBox, DateTime Desde, DateTime Hasta, bool Entradas)
        {
            List<CashDropModel> list = new List<CashDropModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashDropbyIdBox", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdBox", IdBox));
                        cmd.Parameters.Add(new SqlParameter("@Desde", Desde));
                        cmd.Parameters.Add(new SqlParameter("@Hasta", Hasta));
                        cmd.Parameters.Add(new SqlParameter("@Entradas", Entradas));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCashDrop(reader));
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

        public async Task<List<CashDropModel>> GetCashDrop(DateTime Desde, DateTime Hasta, bool Entradas)
        {
            List<CashDropModel> list = new List<CashDropModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashDrop", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Desde", Desde));
                        cmd.Parameters.Add(new SqlParameter("@Hasta", Hasta));
                        cmd.Parameters.Add(new SqlParameter("@Entradas", Entradas));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCashDrop(reader));
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
        private CashDropModel MapToCashDrop(SqlDataReader reader)
        {
            return new CashDropModel()
            {
                Concepto = (string)reader["Concepto"],
                Monto = (decimal)reader["Monto"],
                Articulo = (string)reader["Articulo"],
                Fecha = (DateTime)reader["Fecha"],
                VerConcepto = (string)reader["VerConcepto"],
            };
        }
        #endregion
        #region CashFund
        public async Task<CashFundModel> GetCashfundbyHardwareID(string HardwareID)
        {
            CashFundModel response = new CashFundModel();
            List<CashFundModel> list = new List<CashFundModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashfundbyHardwareID", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@HardwareID", HardwareID));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCashFund(reader));
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
        public async Task<bool> UpdateStatusCashFund(int Id)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStatusCashFund", sql))
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
        public async Task<bool> SaveCashFund(CashFundModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveCashFund", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdBox", obj.IdBox));
                        cmd.Parameters.Add(new SqlParameter("@CheckIn", obj.CheckIn));
                        cmd.Parameters.Add(new SqlParameter("@CheckOut", obj.CheckOut));
                        cmd.Parameters.Add(new SqlParameter("@CashIn", obj.CashIn));
                        cmd.Parameters.Add(new SqlParameter("@CashOut", obj.CashOut));
                        cmd.Parameters.Add(new SqlParameter("@CashFinish", obj.CashFinish));
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
        public async Task<CashFundModel> GetCashFundbyIdBox(int IdBox)
        {
            CashFundModel obj = new CashFundModel();
            List<CashFundModel> list = new List<CashFundModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashFundbyIdBox", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdBox", IdBox));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCashFund(reader));
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
        public async Task<CashFundModel> GetCashFundbyId(int Id)
        {
            CashFundModel obj = new CashFundModel();
            List<CashFundModel> list = new List<CashFundModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashFundbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToCashFund(reader));
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
        private CashFundModel MapToCashFund(SqlDataReader reader)
        {
            return new CashFundModel()
            {
                Id = (int)reader["Id"],
                IdBox = (int)reader["IdBox"],
                CheckIn = (DateTime)reader["CheckIn"],
                CheckOut = (DateTime)reader["CheckOut"],
                CashIn = (decimal)reader["CashIn"],
                CashOut = (decimal)reader["CashOut"],
                CashFinish = (decimal)reader["CashFinish"],
                StatusOpen = (bool)reader["StatusOpen"]
            };
        }
        public async Task<List<ListCashFundModel>> GetCashFund(DateTime Desde,
           DateTime Hasta)
        {
            List<ListCashFundModel> list = new List<ListCashFundModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCashFund", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Desde", Desde));
                        cmd.Parameters.Add(new SqlParameter("@Hasta", Hasta));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListCashFund(reader));
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
        private ListCashFundModel MapToListCashFund(SqlDataReader reader)
        {
            return new ListCashFundModel()
            {
                Id = (int)reader["Id"],
                IdBox = (int)reader["IdBox"],
                Caja = (string)reader["Caja"],
                Apertura = (DateTime)reader["Apertura"],
                Cierre = (DateTime)reader["Cierre"],
                Estatus = (string)reader["Estatus"],
            };
        }
        #endregion
        #region Tickets
        public async Task<TicketModel> GetTicketsbyId(int Id)
        {
            TicketModel result = new TicketModel();
            List<TicketModel> list = new List<TicketModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetTicketsbyId", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToTicket(reader));
                            }
                            result = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        private TicketModel MapToTicket(SqlDataReader reader)
        {
            return new TicketModel()
            {
                Id = (int)reader["Id"],
                IdUser = (int)reader["IdUser"],
                IdClient = (int)reader["IdClient"],
                CreateDate = (DateTime)reader["CreateDate"],
                Lastmodification = (DateTime)reader["Lastmodification"],
                Status = (bool)reader["Status"],
                IdBox = (int)reader["IdBox"],
                Total = (decimal)reader["Total"],
                TotalReturn = (decimal)reader["TotalReturn"],
                Send = (bool)reader["Send"],
                TypePay = (string)reader["TypePay"],
                Folio = (string)reader["Folio"]
            };
        }
        public async Task<List<DetailsforFactureModel>> GetDetailsforFacture(int IdTicket)
        {
            List<DetailsforFactureModel> list = new List<DetailsforFactureModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetDetailsforFacture", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdTicket", IdTicket));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToDetailTicket(reader));
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
        private DetailsforFactureModel MapToDetailTicket(SqlDataReader reader)
        {
            return new DetailsforFactureModel()
            {
                CodeSAT = (string)reader["CodeSAT"],
                Code = (string)reader["Code"], //Ahora este guarda "Id"+ Idarticle
                Stock = (decimal)reader["StockSold"],
                UnitSAT = (string)reader["UnitSAT"],
                NamePresentation = (string)reader["NamePresentation"],
                Name = (string)reader["Name"],
                Price = (decimal)reader["PriceSold"],
                Total = (decimal)reader["TotalSold"],
                Rate = (string)reader["Rate"],
                Amount = (decimal)reader["Amount"],
            };
        }

        public async Task<List<ListDetailsTicketModel>> GetDetailsTicket(int IdTicket)
        {
            List<ListDetailsTicketModel> list = new List<ListDetailsTicketModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetDetailsTicket", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdTicket", IdTicket));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListDetailsTicket(reader));
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
        private ListDetailsTicketModel MapToListDetailsTicket(SqlDataReader reader)
        {
            return new ListDetailsTicketModel()
            {
                Id = (int)reader["Id"],
                IdArticle = (int)reader["IdArticle"],
                Code = (string)reader["Code"],
                Name = (string)reader["Name"],
                Stock = (string)reader["Stock"],
                PriceSold = (decimal)reader["PriceSold"],
                TotalSold = (decimal)reader["TotalSold"],
                CreateDate = (DateTime)reader["CreateDate"],
                Status = (string)reader["Status"],
                SendBack = (bool)reader["SendBack"],
                StockSold = (decimal)reader["StockSold"],
                Note = (string)reader["Note"],
            };
        }
        public async Task<List<ListTicketModel>> GetTickets(int IdTicket, DateTime Desde,
            DateTime Hasta, bool FechaCreacion)
        {
            List<ListTicketModel> list = new List<ListTicketModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetTickets", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdTicket", IdTicket));
                        cmd.Parameters.Add(new SqlParameter("@Desde", Desde));
                        cmd.Parameters.Add(new SqlParameter("@Hasta", Hasta));
                        cmd.Parameters.Add(new SqlParameter("@FechaCreacion", FechaCreacion));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListTickets(reader));
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
        private ListTicketModel MapToListTickets(SqlDataReader reader)
        {
            return new ListTicketModel()
            {
                Id = (int)reader["Id"],
                User = (string)reader["User"],
                Client = (string)reader["Client"],
                Total = (decimal)reader["Total"],
                TotalReturn = (decimal)reader["TotalReturn"],
                TotalEnd = (decimal)reader["TotalEnd"],
                Created = (DateTime)reader["CreateDate"],
                Modified = (DateTime)reader["Lastmodification"],
                Status = (string)reader["Status"],
                Send = (string)reader["Send"],
                TypePay = (string)reader["TypePay"],
            };
        }
        public async Task<bool> ReturnArticle(int Id, string NoteText)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("ReturnArticle", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // 1. Parámetro de entrada normal
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@NoteText", NoteText));
                        // 2. CONFIGURAR EL PARÁMETRO DE SALIDA
                        SqlParameter vRespParam = new SqlParameter("@VResp", System.Data.SqlDbType.Int)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(vRespParam);

                        await sql.OpenAsync().ConfigureAwait(false);
                        await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);

                        // 3. CAPTURAR Y EVALUAR EL RESULTADO
                        // Validamos que no sea DBNull y que el valor sea igual a 1
                        if (vRespParam.Value != DBNull.Value && (int)vRespParam.Value == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false; // El SP devolvió 0 (error interno, ya devuelto o ID no existe)
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> CancelTicket(int Id, string NoteText)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("CancelTicket", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@NoteText", NoteText));
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
        #region Venta
        public async Task<bool> ConfirmSend(int Id, RespuestaFactureModel Send)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("ConfirmSend", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", Id));
                        cmd.Parameters.Add(new SqlParameter("@Send", Send.Exito));
                        cmd.Parameters.Add(new SqlParameter("@Note", Send.Data.message));
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
        public async Task<int> SaveTicket(TicketModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveTicket", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdUser", obj.IdUser));
                        cmd.Parameters.Add(new SqlParameter("@IdClient", obj.IdClient));
                        cmd.Parameters.Add(new SqlParameter("@Total", obj.Total));
                        cmd.Parameters.Add(new SqlParameter("@IdBox", obj.IdBox));
                        cmd.Parameters.Add(new SqlParameter("@TypePay", obj.TypePay));
                        cmd.Parameters.Add(new SqlParameter("@Folio", obj.Folio));
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
        public async Task<bool> SaveDetailsTicket(DetailsTicketModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveDetailsTicket", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id", obj.Id));
                        cmd.Parameters.Add(new SqlParameter("@IdTicket", obj.IdTicket));
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", obj.IdArticle));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", obj.IdPresentation));
                        cmd.Parameters.Add(new SqlParameter("@StockSold", obj.StockSold));
                        cmd.Parameters.Add(new SqlParameter("@PriceSold", obj.PriceSold));
                        cmd.Parameters.Add(new SqlParameter("@TotalSold", obj.TotalSold));
                        cmd.Parameters.Add(new SqlParameter("@Rate", obj.Rate));
                        cmd.Parameters.Add(new SqlParameter("@Amount", obj.Amount));
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
        #region ConfigImpressions
        public async Task<bool> SaveConfigImpressions(ConfigImpressionsModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveConfigImpressions", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@FontSize", obj.FontSize));
                        cmd.Parameters.Add(new SqlParameter("@FontStyle", obj.FontStyle));
                        cmd.Parameters.Add(new SqlParameter("@FontColor", obj.FontColor));
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
        public async Task<bool> SaveConfigBox(ConfigBoxModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveConfigBox", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Spacing", obj.Spacing));
                        cmd.Parameters.Add(new SqlParameter("@Align", obj.Align));
                        cmd.Parameters.Add(new SqlParameter("@Width", obj.Width));
                        cmd.Parameters.Add(new SqlParameter("@HightLine", obj.HightLine));
                        cmd.Parameters.Add(new SqlParameter("@ColorLine", obj.ColorLine));
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
        public async Task<bool> SaveImpressions(ImpressionsModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveImpressions", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", obj.Name));
                        cmd.Parameters.Add(new SqlParameter("@Page", obj.Page));
                        cmd.Parameters.Add(new SqlParameter("@WidthPage", obj.WidthPage));
                        cmd.Parameters.Add(new SqlParameter("@HightPage", obj.HightPage));
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
        public async Task<List<ListConfigImpressionsModel>> GetConfigImpressions(string Tipo)
        {
            List<ListConfigImpressionsModel> list = new List<ListConfigImpressionsModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetConfigImpressions", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Tipo", Tipo));

                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToConfigImpressions(reader));
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
        private ListConfigImpressionsModel MapToConfigImpressions(SqlDataReader reader)
        {
            return new ListConfigImpressionsModel()
            {
                Name = (string)reader["Name"],
                FontSize = (int)reader["FontSize"],
                FontStyle = (string)reader["FontStyle"],
                FontColor = (string)reader["FontColor"],
            };
        }
        public async Task<ConfigPageModel> GetConfigBox()
        {
            ConfigPageModel Result = new ConfigPageModel();
            List<ConfigPageModel> list = new List<ConfigPageModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetConfigBox", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToConfigBox(reader));
                            }
                            Result = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Result = null;
            }
            return Result;
        }
        public async Task<ConfigPageModel> GetConfigPage()
        {
            ConfigPageModel Result = new ConfigPageModel();
            List<ConfigPageModel> list = new List<ConfigPageModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetConfigPage", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToConfigPage(reader));
                            }
                            Result = list.Count() > 0 ? list[0] : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Result = null;
            }
            return Result;
        }
        private ConfigPageModel MapToConfigBox(SqlDataReader reader)
        {
            return new ConfigPageModel()
            {
                Page = (string)reader["Page"],
                Spacing = (int)reader["Spacing"],
                Align = (string)reader["Align"],
                Width = (int)reader["Width"],
                HightLine = (decimal)reader["HightLine"],
                ColorLine = (string)reader["ColorLine"],
                WidthPage = (decimal)reader["WidthPage"],
                HightPage = (decimal)reader["HightPage"],
            };
        }
        private ConfigPageModel MapToConfigPage(SqlDataReader reader)
        {
            return new ConfigPageModel()
            {
                Page = (string)reader["Page"],
                Spacing = 0,
                Align = string.Empty,
                Width = 0,
                HightLine = 0,
                ColorLine = string.Empty,
                WidthPage = (decimal)reader["WidthPage"],
                HightPage = (decimal)reader["HightPage"],
            };
        }
        #endregion
        #region PricesSuppliers
        public async Task<bool> UpdateAllStatusPrices(int IdArticle, int IdPresentation)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateAllStatusPrices", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", IdArticle));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", IdPresentation));
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
                Result = null;
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
                        cmd.Parameters.Add(new SqlParameter("@BillingName", obj.BillingName));
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
                                list.Add(MapToCompany(reader));
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
        private CompanyModel MapToCompany(SqlDataReader reader)
        {
            return new CompanyModel()
            {
                Name = (string)reader["Name"],
                BillingName = (string)reader["BillingName"],
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
        public async Task<bool> SaveTransactionHistory(TransactionHistoryModel obj)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveTransactionHistory", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdArticle", obj.IdArticles));
                        cmd.Parameters.Add(new SqlParameter("@Stock", obj.Stock));
                        cmd.Parameters.Add(new SqlParameter("@Concept", obj.Concept));
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
                        cmd.Parameters.Add(new SqlParameter("@StockMin", obj.StockMin));
                        cmd.Parameters.Add(new SqlParameter("@IdPresentation", obj.IdPresentation));
                        cmd.Parameters.Add(new SqlParameter("@Price", obj.Price));
                        cmd.Parameters.Add(new SqlParameter("@SuggestedStock", obj.SuggestedStock));
                        cmd.Parameters.Add(new SqlParameter("@Margen", obj.Margen));
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
                StockMin = Convert.IsDBNull(reader["StockMin"]) ? 0 : (decimal)reader["StockMin"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Presentation = Convert.IsDBNull(reader["Presentation"]) ? string.Empty : (string)reader["Presentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
                Margen = Convert.IsDBNull(reader["Margen"]) ? 0 : (decimal)reader["Margen"],
            };
        }
        #endregion
        #region Articles
        public async Task<int> GetStockOut()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetStockOut", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter outputParam = new SqlParameter("@VResp", System.Data.SqlDbType.Int)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);
                        await sql.OpenAsync().ConfigureAwait(false);
                        await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                        int Agotados = (outputParam.Value != DBNull.Value) ? Convert.ToInt32(outputParam.Value) : 0;

                        return Agotados;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
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
        public async Task<bool> UpdateSAT(string CodeSAT, string Code, string Name, int IdCategory)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateSAT", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@CodeSAT", CodeSAT));
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        cmd.Parameters.Add(new SqlParameter("@Name", Name));
                        cmd.Parameters.Add(new SqlParameter("@IdCategory", IdCategory));
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
                CodeSAT = Convert.IsDBNull(reader["CodeSAT"]) ? string.Empty : (string)reader["CodeSAT"],
                SendBack = (bool)reader["SendBack"],
                Status = (bool)reader["Status"],
                Medicine = (bool)reader["Medicine"],
                IdCategory = Convert.IsDBNull(reader["IdCategory"]) ? 0 : (int)reader["IdCategory"],
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
                        cmd.Parameters.Add(new SqlParameter("@CodeSAT", obj.CodeSAT));
                        cmd.Parameters.Add(new SqlParameter("@Code", obj.Code));
                        cmd.Parameters.Add(new SqlParameter("@SendBack", obj.SendBack));
                        cmd.Parameters.Add(new SqlParameter("@Medicine", obj.Medicine));
                        cmd.Parameters.Add(new SqlParameter("@IdCategory", obj.IdCategory));
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
        public async Task<List<ListArticlesModel>> GetArticles(string Code, string Nombre, bool IsReceta, int IdCategory, bool Agotados, int IdProveedor)
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
                        cmd.Parameters.Add(new SqlParameter("@IdCategory", IdCategory));
                        cmd.Parameters.Add(new SqlParameter("@Outstock", Agotados));
                        cmd.Parameters.Add(new SqlParameter("@IdSupplier", IdProveedor));
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
        public async Task<List<ListArticlesActivesModel>> GetArticlesActives(string Code, string Nombre, int IdCategory, int IdProveedor)
        {
            List<ListArticlesActivesModel> list = new List<ListArticlesActivesModel>();
            try
            {
                using (SqlConnection sql = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("GetArticlesActives", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Code", Code));
                        cmd.Parameters.Add(new SqlParameter("@Name", Nombre));
                        cmd.Parameters.Add(new SqlParameter("@IdCategory", IdCategory));
                        cmd.Parameters.Add(new SqlParameter("@IdSupplier", IdProveedor));
                        await sql.OpenAsync().ConfigureAwait(false);
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(MapToListArticlesActives(reader));
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
                CodeSAT = Convert.IsDBNull(reader["CodeSAT"]) ? string.Empty : (string)reader["CodeSAT"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Image = Convert.IsDBNull(reader["Image"]) ? null : (byte[])reader["Image"],
                Status = (bool)reader["Status"],
                Stock = Convert.IsDBNull(reader["Stock"]) ? 0 : (decimal)reader["Stock"],
                IdPresentation = Convert.IsDBNull(reader["IdPresentation"]) ? 0 : (int)reader["IdPresentation"],
                Presentation = Convert.IsDBNull(reader["Presentation"]) ? string.Empty : (string)reader["Presentation"],
                Price = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                SuggestedStock = Convert.IsDBNull(reader["SuggestedStock"]) ? 0 : (decimal)reader["SuggestedStock"],
                Medicine = (bool)reader["Medicine"],
            };
        }
        private ListArticlesModel MapToListArticles(SqlDataReader reader)
        {
            return new ListArticlesModel()
            {
                Id = (int)reader["Id"],
                Codigo = (string)reader["Code"],
                ClaveSAT = Convert.IsDBNull(reader["CodeSAT"]) ? string.Empty : (string)reader["CodeSAT"],
                Articulo = (string)reader["Name"],
                Categoria = (string)reader["Category"],
                Existencias = (string)reader["Stock"],
                ExistenciasMinimas = (string)reader["StockMin"],
                Precio = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                PrecioProveedor = Convert.IsDBNull(reader["PriceSuppliers"]) ? 0 : (decimal)reader["PriceSuppliers"],
                PorCada = (string)reader["PorCada"],
                Medicamento = (string)reader["Medicine"],
                Estatus = (string)reader["Status"],
                Stock = Convert.IsDBNull(reader["Stocks"]) ? 0 : (decimal)reader["Stocks"],
            };
        }
        private ListArticlesActivesModel MapToListArticlesActives(SqlDataReader reader)
        {
            return new ListArticlesActivesModel()
            {
                Id = (int)reader["Id"],
                Codigo = (string)reader["Code"],
                Nombre = (string)reader["Name"],
                Stock = (string)reader["Stock"],
                Precio = Convert.IsDBNull(reader["Price"]) ? 0 : (decimal)reader["Price"],
                PorCada = (string)reader["PorCada"],
                EsMedicina = (string)reader["Medicine"],
                Categoria = (string)reader["Category"],
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
                Submeasurement = Convert.IsDBNull(reader["Submeasurement"]) ? string.Empty : (string)reader["Submeasurement"]
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
                Decimals = (int)reader["Decimals"],
                Presentation = (string)reader["Presentation"],
                UnitSAT = (string)reader["UnitSAT"],
            };
        }
        #endregion
    }
}