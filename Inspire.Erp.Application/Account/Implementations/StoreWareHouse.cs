using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.Account.Implementations
{
    public class StoreWareHouse: IStoreWareHouse
    {
        private static string conn;
        private readonly InspireErpDBContext context;
        private readonly IConfiguration configuration;
        public StoreWareHouse(InspireErpDBContext context, IConfiguration _configuration)
        {
            configuration = _configuration;
            conn = configuration.GetConnectionString("db_con");
            this.context = context;
        }
        public async Task<string> getStockLedgerReport() {
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
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> getStockMovementRpt() {
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
            catch (Exception)
            {
                throw;
            }
        }
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
            catch (Exception)
            {
                throw;
            }
        }
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
            catch (Exception)
            {
                throw;
            }
        }
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
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> getStockMovementDetailsRpt(ItemMasterViewModel id)
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
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> getDetailsByItem(StockLedgerReportModel obj)
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
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> getStockVchDetails(StockLedgerReportModel obj)
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
