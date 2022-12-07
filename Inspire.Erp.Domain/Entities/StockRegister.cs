using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class StockRegister
    {
        public int StockRegisterStoreId { get; set; }
        public string StockRegisterPurchaseId { get; set; }
        public string StockRegisterRefVoucherNo { get; set; }
        public int? StockRegisterSno { get; set; }
        public string StockRegisterBatchCode { get; set; }
        public DateTime? StockRegisterExpDate { get; set; }
        public int? StockRegisterMaterialId { get; set; }
        public double? StockRegisterQuantity { get; set; }
        public double? StockRegisterSin { get; set; }
        public double? StockRegisterSout { get; set; }
        public double? StockRegisterRate { get; set; }
        public double? StockRegisterAmount { get; set; }
        public double? StockRegisterFcAmount { get; set; }
        public DateTime? StockRegisterAssignedDate { get; set; }
        public string StockRegisterDepCode { get; set; }
        public string StockRegisterStatus { get; set; }
        public string StockRegisterTransType { get; set; }
        public string StockRegisterRemarks { get; set; }
        public int StockRegisterUnit { get; set; }
        public int? StockRegisterLocationId { get; set; }
        public int? StockRegisterJobId { get; set; }
        public int? StockRegisterFsno { get; set; }
        public double? StockRegisterNetStkBal { get; set; }
        public string StockRegisterFoc { get; set; }
        public double? StockRegisterUsedQty { get; set; }
        public bool? StockRegisterQueryRun { get; set; }
        public bool? StockRegisterCalcDone { get; set; }
        public double? StockRegisterRateTmp { get; set; }
        public double? StockRegisterAmountTmp { get; set; }
        public bool? StockRegisterDelStatus { get; set; }
    }
}
