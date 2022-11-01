using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.Account.Interfaces
{
    public interface IStoreWareHouse
    {
        public Task<string> getStockLedgerReport();
        public Task<string> getStockMovementRpt();
        public Task<string> getAllItems();
        public Task<string> getAllBrands();
        public Task<string> getFilteredStockLedgerRpt(StockLedgerReportModel obj);
        public Task<string> getStockMovementDetailsRpt(ItemMasterViewModel id);
        public Task<string> getDetailsByItem(StockLedgerReportModel obj);
        public Task<string> getStockVchDetails(StockLedgerReportModel obj);
        public Task<string> getAllDepartments();
    }
}
