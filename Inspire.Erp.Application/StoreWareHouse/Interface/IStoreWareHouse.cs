using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.StoreWareHouse.Interfaces
{
    public interface IStoreWareHouse
    {
        public Task<dynamic> getStockLedgerReport();
        //public Task<string> getStockMovementRpt();
        //public Task<string> getAllItems();
        //public Task<string> getAllBrands();
        //public Task<string> getFilteredStockLedgerRpt(StockLedgerReportModel obj);
        //public Task<string> getStockMovementDetailsRpt(ItemMasterViewModel id);
        //public Task<string> getItemDetailsById(ItemMasterViewModel id);
        //public Task<string> getDetailsByItem(StockLedgerReportModel obj);
        //public Task<string> getStockVchDetails(StockLedgerReportModel obj);
        //public Task<string> getAllDepartments();
        //public Task<string> getVoucherNumber();
        //public Task<string> submitTransferReport(StockTransferRequestModel obj);
        //public Task<string> submitDamageEntry(StockTransferRequestModel obj);
    }
}
