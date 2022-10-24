using Inspire.Erp.Infrastructure.Database;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly InspireErpDBContext context;
        private readonly IConfiguration configuration;
        private static string conn;
        public StockController(InspireErpDBContext context, IConfiguration _configuration)
        {
            configuration = _configuration;
            conn = configuration.GetConnectionString("db_con");
            this.context = context;
        }
        [HttpPost("getStockLedgerReport")]
        public async Task<string> getStockLedgerReport()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "getStockLedgerRpt";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Stock_Register");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        [HttpPost("getFilteredStockLedgerRpt")]
        public async Task<string> getFilteredStockLedgerRpt(StockLedgerReportModel obj)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "getFilteredStockLedgerRpt";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("dateFrom", obj.dateFrom);
                        com.Parameters.AddWithValue("dateTo", obj.dateTo);
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Stock_Register");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet("getStockMovementRpt")]
        public async Task<string> getStockMovementRpt()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "getStockMovementRpt";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "ItemDetails");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpPost("getStockMovementDetailsRpt")]
        public async Task<string> getStockMovementDetailsRpt([FromBody] ItemMasterViewModel id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = @"getStockMovementDetailsRpt";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("ItemMasterItemId", id.ItemMasterItemId);
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "ItemDetails");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpPost("getDetailsByItem")]
        public async Task<string> getDetailsByItem([FromBody] StockLedgerReportModel obj)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "select isnull(Item_Master_Item_Id,0) as Item_Id,Stock_Register_Unit_ID,OpenQty=Sum(Stock_Register_SIN-Stock_Register_Sout), " +
                                   "OpenQtyAmount = Sum((Stock_Register_SIN - Stock_Register_Sout) * Stock_Register_Rate), " +
                                   "StockIn = Sum(Stock_Register_SIN), " +
                                   "StockInAmount = Sum(Stock_Register_SIN * Stock_Register_Rate), " +
                                   "StockOut = Sum(Stock_Register_Sout)," +
                                   "StockOutAmount = Sum(Stock_Register_Sout * Stock_Register_Rate), " +
                                   "TotalBal = Sum(Stock_Register_SIN - Stock_Register_Sout), " +
                                   "TotalBalAmount = Sum((Stock_Register_SIN - Stock_Register_Sout) * Stock_Register_Rate), " +
                                   "isnull(Item_Master.Item_Master_Item_Name,'(No Name)') as Item_Name from Stock_Register " +
                                   "Left outer join Item_Master  on Stock_Register.Stock_Register_Material_ID = Item_Master.Item_Master_Item_ID where " +
                                   "Item_Master_Item_Id = " + obj.itemGroup + " group by Item_Master_Item_Name,Item_Master_Item_Id,Stock_Register_Unit_ID having " + "SUM(Stock_Register.Stock_Register_SIN) >= SUM(Stock_Register.Stock_Register_Sout) ";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Stock_Register");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpPost("getStockVchDetails")]
        public async Task<string> getStockVchDetails([FromBody] StockLedgerReportModel obj)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "getStockVchDetails";
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("itemGroup", obj.itemGroup);
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Stock_Register");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet("getAllItems")]
        public async Task<string> getAllItems()
        {
            try
            {
                string query = "getAllItems";
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Item_Master");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }
        [HttpGet("getAllBrands")]
        public async Task<string> getAllBrands()
        {
            try
            {
                string query = "";
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter customerDA = new SqlDataAdapter())
                        {
                            customerDA.SelectCommand = com;
                            using (DataSet customerDS = new DataSet())
                            {
                                customerDA.Fill(customerDS, "Brand_Master");
                                con.Close();
                                return JsonConvert.SerializeObject(customerDS);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }
    }
}
