using AutoMapper;
using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Modals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.StoreWareHouse.Implementations
{
    public class StoreWareHouses : IStoreWareHouse
    {
        private readonly InspireErpDBContext _sr;
        public IMapper _im;
        public StoreWareHouses(InspireErpDBContext sr)
        {
            _sr = sr;
        }
        public async Task<dynamic> getStockLedgerReport() {
            try
            {
                //var response = _sr.StockRegister.FirstOrDefault(); ;
                var response = await _sr.Set<StockRegisterResponse>().FromSqlInterpolated($"EXEC getStockLedgerRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public async Task<string> getStockLedgerReport()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "getStockLedgerRpt";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                com.CommandType = CommandType.StoredProcedure;
        //                con.Open();
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Stock_Register");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getStockMovementRpt()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "getStockMovementRpt";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "ItemDetails");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getAllBrands()
        //{
        //    try
        //    {
        //        string query = "select * from ";
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Brand_Master");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getAllDepartments()
        //{
        //    try
        //    {
        //        string query = "getAllDepartments";
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Department_Master");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getAllItems()
        //{
        //    try
        //    {
        //        string query = "getAllItems";
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Item_Master");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getFilteredStockLedgerRpt(StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "getFilteredStockLedgerRpt";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("itemGroup", obj.itemGroup);
        //                com.Parameters.AddWithValue("itemName", obj.itemName);
        //                com.Parameters.AddWithValue("job", obj.job);
        //                com.Parameters.AddWithValue("location", obj.location);
        //                com.Parameters.AddWithValue("dateFrom", obj.dateFrom);
        //                com.Parameters.AddWithValue("dateTo", obj.dateTo);
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Stock_Register");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //            //string query = "getFilteredStockLedgerRpt";
        //            //using (SqlCommand com = new SqlCommand(query, con))
        //            //{
        //            //    con.Open();
        //            //    com.CommandType = CommandType.StoredProcedure;
        //            //    com.Parameters.AddWithValue("dateFrom", obj.dateFrom);
        //            //    com.Parameters.AddWithValue("dateTo", obj.dateTo);
        //            //    using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //            //    {
        //            //        customerDA.SelectCommand = com;
        //            //        using (DataSet customerDS = new DataSet())
        //            //        {
        //            //            customerDA.Fill(customerDS, "Stock_Register");
        //            //            con.Close();
        //            //            return JsonConvert.SerializeObject(customerDS);
        //            //        }
        //            //    }
        //            //}
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getStockMovementDetailsRpt(ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = @"getStockMovementDetailsRpt";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("ItemMasterItemId", id.ItemMasterItemId);
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "ItemDetails");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getItemDetailsById(ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = @"getItemDetailsById";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("ItemMasterItemId", id.ItemMasterItemId);
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "ItemDetails");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getDetailsByItem(StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "select isnull(Item_Master_Item_Id,0) as Item_Id,Stock_Register_Unit_ID,OpenQty=Sum(Stock_Register_SIN-Stock_Register_Sout), " +
        //                           "OpenQtyAmount = Sum((Stock_Register_SIN - Stock_Register_Sout) * Stock_Register_Rate), " +
        //                           "StockIn = Sum(Stock_Register_SIN), " +
        //                           "StockInAmount = Sum(Stock_Register_SIN * Stock_Register_Rate), " +
        //                           "StockOut = Sum(Stock_Register_Sout)," +
        //                           "StockOutAmount = Sum(Stock_Register_Sout * Stock_Register_Rate), " +
        //                           "TotalBal = Sum(Stock_Register_SIN - Stock_Register_Sout), " +
        //                           "TotalBalAmount = Sum((Stock_Register_SIN - Stock_Register_Sout) * Stock_Register_Rate), " +
        //                           "isnull(Item_Master.Item_Master_Item_Name,'(No Name)') as Item_Name from Stock_Register " +
        //                           "Left outer join Item_Master  on Stock_Register.Stock_Register_Material_ID = Item_Master.Item_Master_Item_ID where " +
        //                           "Item_Master_Item_Id = " + obj.itemGroup + " group by Item_Master_Item_Name,Item_Master_Item_Id,Stock_Register_Unit_ID having " + "SUM(Stock_Register.Stock_Register_SIN) >= SUM(Stock_Register.Stock_Register_Sout) ";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Stock_Register");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getStockVchDetails(StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "getStockVchDetails";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("itemGroup", obj.itemGroup);
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Stock_Register");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> getVoucherNumber()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "GetVoucherNumber";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter customerDA = new SqlDataAdapter())
        //                {
        //                    customerDA.SelectCommand = com;
        //                    using (DataSet customerDS = new DataSet())
        //                    {
        //                        customerDA.Fill(customerDS, "Stock_Register");
        //                        con.Close();
        //                        return JsonConvert.SerializeObject(customerDS);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public async Task<string> submitTransferReport(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            if (obj.stockRate == null)
        //                obj.stockRate = "0";
        //            if (obj.unitId == null)
        //                obj.unitId = "0";
        //            string query = "submitTransferReport";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("ItemId", obj.stockItemId);
        //                com.Parameters.AddWithValue("voucherNo", obj.voucherNo);
        //                com.Parameters.AddWithValue("voucherDate", obj.voucherDate);
        //                com.Parameters.AddWithValue("selectedJob", obj.selectedJob);
        //                com.Parameters.AddWithValue("locationFrom", obj.locationFrom);
        //                com.Parameters.AddWithValue("locationTo", obj.locationTo);
        //                com.Parameters.AddWithValue("narration", obj.narration);
        //                com.Parameters.AddWithValue("department", obj.department);
        //                com.Parameters.AddWithValue("stockQuantity", obj.stockQuantity);
        //                com.Parameters.AddWithValue("stockItemName", obj.stockItemName);
        //                com.Parameters.AddWithValue("stockItemType", obj.stockItemType);
        //                com.Parameters.AddWithValue("stockRate", obj.stockRate);
        //                com.ExecuteNonQuery();
        //                con.Close();
        //            }
        //            query = "submitTransferReportDetails";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("ItemId", obj.stockItemId);
        //                com.Parameters.AddWithValue("narration", obj.narration);
        //                com.Parameters.AddWithValue("stockQuantity", obj.stockQuantity);
        //                com.Parameters.AddWithValue("stockRate", obj.stockRate);
        //                com.Parameters.AddWithValue("unitId", obj.unitId);
        //                com.ExecuteNonQuery();
        //                con.Close();
        //                return "Success";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}
        //public async Task<string> submitDamageEntry(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            string query = "submitDamageEntry";
        //            using (SqlCommand com = new SqlCommand(query, con))
        //            {
        //                con.Open();
        //                com.CommandType = CommandType.StoredProcedure;
        //                //com.Parameters.AddWithValue("stockItemId", obj.stockItemId);
        //                com.Parameters.AddWithValue("unitId", obj.unitId);
        //                com.Parameters.AddWithValue("VDate", obj.voucherDate);
        //                com.Parameters.AddWithValue("voucherNo", obj.voucherNo);
        //                com.Parameters.AddWithValue("narration", obj.narration);
        //                com.Parameters.AddWithValue("locationId", obj.locationFrom);
        //                com.Parameters.AddWithValue("qty", obj.stockQuantity);
        //                com.Parameters.AddWithValue("materialId", obj.materialId);
        //                com.Parameters.AddWithValue("jobId", "");
        //                com.Parameters.AddWithValue("price", obj.stockRate);
        //                com.Parameters.AddWithValue("amount", float.Parse(obj.stockRate) * float.Parse(obj.stockQuantity));
        //                com.Parameters.AddWithValue("voucherType", "DAMAGE ENTRY");
        //                com.ExecuteNonQuery();
        //                con.Close();
        //                return JsonConvert.SerializeObject("Success 200 Ok");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}
    }
}
