using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.Account.Interfaces
{
    public interface IStoreWareHouse
    {
        Task<string> getStockLedgerReport();
        Task<string> getStockMovementRpt();
        Task<string> getAllItems();
        Task<string> getAllBrands();
        Task<string> getFilteredStockLedgerRpt(StockLedgerReportModel obj);
        Task<string> getStockMovementDetailsRpt(ItemMasterViewModel id);
        Task<string> getDetailsByItem(StockLedgerReportModel obj);
        Task<string> getStockVchDetails(StockLedgerReportModel obj);
    }
}
