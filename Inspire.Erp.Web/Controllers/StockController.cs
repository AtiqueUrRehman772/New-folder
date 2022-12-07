using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;
using ItemMasterViewModel = Inspire.Erp.Domain.Entities.StoreWareHouse.ItemMasterViewModel;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStoreWareHouse _sw;

        public StockController(IStoreWareHouse sw)
        {
            _sw = sw;
        }
        [HttpPost("getStockLedgerReport")]
        public async Task<dynamic> getStockLedgerReport()
        {
            try
            {
                var response=await _sw.getStockLedgerReport();
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        //[HttpPost("getFilteredStockLedgerRpt")]
        //public async Task<string> getFilteredStockLedgerRpt([FromBody] StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        string response = await _sw.getFilteredStockLedgerRpt(obj);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpGet("getStockMovementRpt")]
        //public async Task<string> getStockMovementRpt()
        //{
        //    try
        //    {
        //        string response = await _sw.getStockMovementRpt();
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpPost("getStockMovementDetailsRpt")]
        //public async Task<string> getStockMovementDetailsRpt([FromBody] ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        string response = await _sw.getStockMovementDetailsRpt(id);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpPost("getItemDetailsById")]
        //public async Task<string> getItemDetailsById([FromBody] ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        string response = await _sw.getItemDetailsById(id);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpPost("getDetailsByItem")]
        //public async Task<string> getDetailsByItem([FromBody] StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        string response = await _sw.getDetailsByItem(obj);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpPost("getStockVchDetails")]
        //public async Task<string> getStockVchDetails([FromBody] StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        string response = await _sw.getStockVchDetails(obj);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpGet("getAllItems")]
        //public async Task<string> getAllItems()
        //{
        //    try
        //    {
        //        string response = await _sw.getAllItems();
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return ex.Message.ToString();
        //        throw;
        //    }
        //}
        //[HttpGet("getAllBrands")]
        //public async Task<string> getAllBrands()
        //{
        //    try
        //    {
        //        string response = await _sw.getAllBrands();
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return ex.Message.ToString();
        //        throw;
        //    }
        //}
        //[HttpGet("getAllDepartments")]
        //public async Task<string> getAllDepartments()
        //{
        //    try
        //    {
        //        string response = await _sw.getAllDepartments();
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return ex.Message.ToString();
        //        throw;
        //    }
        //}
        //[HttpGet("getVoucherNumber")]
        //public async Task<string> getVoucherNumber()
        //{
        //    try
        //    {
        //        string response = await _sw.getVoucherNumber();
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return ex.Message.ToString();
        //        throw;
        //    }
        //}
        //[HttpPost("submitTransferReport")]
        //public async Task<string> submitTransferReport(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        _sw.submitTransferReport(obj);
        //        return "success 200 Ok";
        //    }
        //    catch (Exception)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}
        //[HttpPost("submitDamageEntry")]
        //public async Task<string> submitDamageEntry(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        _sw.submitDamageEntry(obj);
        //        return "success 200 Ok";
        //    }
        //    catch (Exception)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}

    }
}
