﻿using System;
using Inspire.Erp.Domain.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inspire.Erp.Domain.Entities
{
    public partial class InspireErpDBContext : DbContext
    {
        public InspireErpDBContext()
        {
        }

        public InspireErpDBContext(DbContextOptions<InspireErpDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountSettings> AccountSettings { get; set; }
        public virtual DbSet<AccountsTransactions> AccountsTransactions { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<AgeingTable> AgeingTable { get; set; }
        public virtual DbSet<AllocationType> AllocationType { get; set; }
        public virtual DbSet<AllocationVoucher> AllocationVoucher { get; set; }
        public virtual DbSet<AllocationVoucherDetails> AllocationVoucherDetails { get; set; }
        public virtual DbSet<AssetDepDetails> AssetDepDetails { get; set; }
        public virtual DbSet<AssetMaster> AssetMaster { get; set; }
        public virtual DbSet<AutoCodes> AutoCodes { get; set; }
        public virtual DbSet<AvCreditNote> AvCreditNote { get; set; }
        public virtual DbSet<AvCreditNoteDetails> AvCreditNoteDetails { get; set; }
        public virtual DbSet<AvDebitNote> AvDebitNote { get; set; }
        public virtual DbSet<AvDebitNoteDetails> AvDebitNoteDetails { get; set; }
        public virtual DbSet<AvIssueVoucher> AvIssueVoucher { get; set; }
        public virtual DbSet<AvIssueVoucherDetails> AvIssueVoucherDetails { get; set; }
        public virtual DbSet<AvIssueVoucherDetailsReturn> AvIssueVoucherDetailsReturn { get; set; }
        public virtual DbSet<AvIssueVoucherReturn> AvIssueVoucherReturn { get; set; }
        public virtual DbSet<BankMaster> BankMaster { get; set; }
        public virtual DbSet<BankPaymentVoucher> BankPaymentVoucher { get; set; }
        public virtual DbSet<BankPaymentVoucherDetails> BankPaymentVoucherDetails { get; set; }
        public virtual DbSet<BankReceiptVoucher> BankReceiptVoucher { get; set; }
        public virtual DbSet<BankReceiptVoucherDetails> BankReceiptVoucherDetails { get; set; }
        public virtual DbSet<BatchBarCodes> BatchBarCodes { get; set; }
        public virtual DbSet<BatchMaster> BatchMaster { get; set; }
        public virtual DbSet<BudgetMaster> BudgetMaster { get; set; }
        public virtual DbSet<BusinessTypeMaster> BusinessTypeMaster { get; set; }
        public virtual DbSet<CardDetails> CardDetails { get; set; }
        public virtual DbSet<CityMaster> CityMaster { get; set; }
        public virtual DbSet<CodeMaster> CodeMaster { get; set; }
        public virtual DbSet<CommonDocuments> CommonDocuments { get; set; }
        public virtual DbSet<ContraVoucher> ContraVoucher { get; set; }
        public virtual DbSet<ContraVoucherDetails> ContraVoucherDetails { get; set; }
        public virtual DbSet<CostCenterMaster> CostCenterMaster { get; set; }
        public virtual DbSet<CountryMaster> CountryMaster { get; set; }
        public virtual DbSet<CurrencyMaster> CurrencyMaster { get; set; }
        public virtual DbSet<CustomerContacts> CustomerContacts { get; set; }
        public virtual DbSet<CustomerDeliveryNote> CustomerDeliveryNote { get; set; }
        public virtual DbSet<CustomerDeliveryNoteDetails> CustomerDeliveryNoteDetails { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrder { get; set; }
        public virtual DbSet<CustomerOrderDetails> CustomerOrderDetails { get; set; }
        public virtual DbSet<CustomerOrderRegister> CustomerOrderRegister { get; set; }
        public virtual DbSet<CustomerPurchaseOrder> CustomerPurchaseOrder { get; set; }
        public virtual DbSet<CustomerPurchaseOrderDetails> CustomerPurchaseOrderDetails { get; set; }
        public virtual DbSet<CustomerQuotation> CustomerQuotation { get; set; }
        public virtual DbSet<CustomerQuotationDetails> CustomerQuotationDetails { get; set; }
        public virtual DbSet<CutomerType> CutomerType { get; set; }
        public virtual DbSet<DamageDetails> DamageDetails { get; set; }
        public virtual DbSet<DamageMaster> DamageMaster { get; set; }
        public virtual DbSet<DeliveryOrderVoucherBatchDetails> DeliveryOrderVoucherBatchDetails { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMaster { get; set; }
        public virtual DbSet<DocumentImages> DocumentImages { get; set; }
        public virtual DbSet<DriverMaster> DriverMaster { get; set; }
        public virtual DbSet<EnquiryDetails> EnquiryDetails { get; set; }
        public virtual DbSet<EnquiryMaster> EnquiryMaster { get; set; }
        public virtual DbSet<EnquiryStatus> EnquiryStatus { get; set; }
        public virtual DbSet<EqnuiryAbout> EqnuiryAbout { get; set; }
        public virtual DbSet<EquipmentTools> EquipmentTools { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<FinalStock> FinalStock { get; set; }
        public virtual DbSet<FinancialPeriods> FinancialPeriods { get; set; }
        public virtual DbSet<FormCategory> FormCategory { get; set; }
        public virtual DbSet<FormNames> FormNames { get; set; }
        public virtual DbSet<GeneralPurchaseOrder> GeneralPurchaseOrder { get; set; }
        public virtual DbSet<GeneralPurchaseOrderDetails> GeneralPurchaseOrderDetails { get; set; }
        public virtual DbSet<GeneralSettings> GeneralSettings { get; set; }
        public virtual DbSet<GeneralSettings1> GeneralSettings1 { get; set; }
        public virtual DbSet<GenericMaster> GenericMaster { get; set; }
        public virtual DbSet<GlobalAccountsTable> GlobalAccountsTable { get; set; }
        public virtual DbSet<GoodsDelivery> GoodsDelivery { get; set; }
        public virtual DbSet<GoodsDeliveryDetails> GoodsDeliveryDetails { get; set; }
        public virtual DbSet<GrnPoDetails> GrnPoDetails { get; set; }
        public virtual DbSet<HappyHour> HappyHour { get; set; }
        public virtual DbSet<HappyHourDeatils> HappyHourDeatils { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceAirDetails> InvoiceAirDetails { get; set; }
        public virtual DbSet<InvoiceAirMaster> InvoiceAirMaster { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceDetailsWestern> InvoiceDetailsWestern { get; set; }
        public virtual DbSet<InvoiceSeaDetails> InvoiceSeaDetails { get; set; }
        public virtual DbSet<InvoiceSeaMaster> InvoiceSeaMaster { get; set; }
        public virtual DbSet<InvoiceWestern> InvoiceWestern { get; set; }
        public virtual DbSet<ItemImages> ItemImages { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }
        public virtual DbSet<ItemPriceLevelDetails> ItemPriceLevelDetails { get; set; }
        public virtual DbSet<ItemStockType> ItemStockType { get; set; }
        public virtual DbSet<ItemSupplierDetails> ItemSupplierDetails { get; set; }
        public virtual DbSet<JobBudgetDetails> JobBudgetDetails { get; set; }
        public virtual DbSet<JobCordinator> JobCordinator { get; set; }
        public virtual DbSet<JobCostEntry> JobCostEntry { get; set; }
        public virtual DbSet<JobDetails> JobDetails { get; set; }
        public virtual DbSet<JobInvoice> JobInvoice { get; set; }
        public virtual DbSet<JobInvoiceDetails> JobInvoiceDetails { get; set; }
        public virtual DbSet<JobMaster> JobMaster { get; set; }
        public virtual DbSet<JobMaster1> JobMaster1 { get; set; }
        public virtual DbSet<JobOrder> JobOrder { get; set; }
        public virtual DbSet<JobOrderDetails> JobOrderDetails { get; set; }
        public virtual DbSet<JournalInvoiceDetails> JournalInvoiceDetails { get; set; }
        public virtual DbSet<JournalInvoiceMaster> JournalInvoiceMaster { get; set; }
        public virtual DbSet<JournalSalesVoucher> JournalSalesVoucher { get; set; }
        public virtual DbSet<JournalSalesVoucherDetails> JournalSalesVoucherDetails { get; set; }
        public virtual DbSet<JournalVoucher> JournalVoucher { get; set; }
        public virtual DbSet<JournalVoucherDetails> JournalVoucherDetails { get; set; }
        public virtual DbSet<LanguageMaster> LanguageMaster { get; set; }
        public virtual DbSet<LinkAccount> LinkAccount { get; set; }
        public virtual DbSet<LocationMaster> LocationMaster { get; set; }
        public virtual DbSet<ManufactureGoodEntryDetails> ManufactureGoodEntryDetails { get; set; }
        public virtual DbSet<ManufactureGoodsEntryMaster> ManufactureGoodsEntryMaster { get; set; }
        public virtual DbSet<ManufactureMaster> ManufactureMaster { get; set; }
        public virtual DbSet<MasterAccountsTable> MasterAccountsTable { get; set; }
        public virtual DbSet<MasterAccountsTableDelete> MasterAccountsTableDelete { get; set; }
        public virtual DbSet<MaterialsMaster> MaterialsMaster { get; set; }
        public virtual DbSet<MenuMaster> MenuMaster { get; set; }
        public virtual DbSet<ModelMaster> ModelMaster { get; set; }
        public virtual DbSet<NatureOfBusiness> NatureOfBusiness { get; set; }
        public virtual DbSet<OldBsMaster> OldBsMaster { get; set; }
        public virtual DbSet<OldBsMasterDetails> OldBsMasterDetails { get; set; }
        public virtual DbSet<OpStock> OpStock { get; set; }
        public virtual DbSet<OpeningStock> OpeningStock { get; set; }
        public virtual DbSet<OpeningVoucherDetails> OpeningVoucherDetails { get; set; }
        public virtual DbSet<OpeningVoucherMaster> OpeningVoucherMaster { get; set; }
        public virtual DbSet<OptionsMaster> OptionsMaster { get; set; }
        public virtual DbSet<OrderTracking> OrderTracking { get; set; }
        public virtual DbSet<PackageMaster> PackageMaster { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<PaymentVoucher> PaymentVoucher { get; set; }
        public virtual DbSet<PaymentVoucherDetails> PaymentVoucherDetails { get; set; }
        public virtual DbSet<PdcDetails> PdcDetails { get; set; }
        public virtual DbSet<PdcVoucher> PdcVoucher { get; set; }
        public virtual DbSet<PdcVoucherDetails> PdcVoucherDetails { get; set; }
        public virtual DbSet<PosStationSettings> PosStationSettings { get; set; }
        public virtual DbSet<PrApprovalDetails> PrApprovalDetails { get; set; }
        public virtual DbSet<PrUser> PrUser { get; set; }
        public virtual DbSet<PriceLevelMaster> PriceLevelMaster { get; set; }
        public virtual DbSet<ProductList> ProductList { get; set; }
        public virtual DbSet<ProformaInvoice> ProformaInvoice { get; set; }
        public virtual DbSet<ProformaInvoiceDetails> ProformaInvoiceDetails { get; set; }
        public virtual DbSet<ProgramSettings> ProgramSettings { get; set; }
        public virtual DbSet<ProgressiveInvoice> ProgressiveInvoice { get; set; }
        public virtual DbSet<ProgressiveInvoiceDetails> ProgressiveInvoiceDetails { get; set; }
        public virtual DbSet<ProjectDescriptionMaster> ProjectDescriptionMaster { get; set; }
        public virtual DbSet<PurOrderRegister> PurOrderRegister { get; set; }
        public virtual DbSet<PurchaseExpense> PurchaseExpense { get; set; }
        public virtual DbSet<PurchaseJournalVoucher> PurchaseJournalVoucher { get; set; }
        public virtual DbSet<PurchaseJournalVoucherDetails> PurchaseJournalVoucherDetails { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseRequisition> PurchaseRequisition { get; set; }
        public virtual DbSet<PurchaseRequisitionDetails> PurchaseRequisitionDetails { get; set; }
        public virtual DbSet<PurchaseReturnVoucher> PurchaseReturnVoucher { get; set; }
        public virtual DbSet<PurchaseReturnVoucherDetails> PurchaseReturnVoucherDetails { get; set; }
        public virtual DbSet<PurchaseVoucher> PurchaseVoucher { get; set; }
        public virtual DbSet<PurchaseVoucherDetails> PurchaseVoucherDetails { get; set; }
        public virtual DbSet<Qtemplates> Qtemplates { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }
        public virtual DbSet<QuotationDetails> QuotationDetails { get; set; }
        public virtual DbSet<RackMaster> RackMaster { get; set; }
        public virtual DbSet<ReceiptVoucherDetails> ReceiptVoucherDetails { get; set; }
        public virtual DbSet<ReceiptVoucherMaster> ReceiptVoucherMaster { get; set; }
        public virtual DbSet<ReconciliationVoucher> ReconciliationVoucher { get; set; }
        public virtual DbSet<ReconciliationVoucherDetails> ReconciliationVoucherDetails { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<RfqEntry> RfqEntry { get; set; }
        public virtual DbSet<RfqEntryDetails> RfqEntryDetails { get; set; }
        public virtual DbSet<SalesJournal> SalesJournal { get; set; }
        public virtual DbSet<SalesJournalDetails> SalesJournalDetails { get; set; }
        public virtual DbSet<SalesJournalVoucher> SalesJournalVoucher { get; set; }
        public virtual DbSet<SalesJournalVoucherDetails> SalesJournalVoucherDetails { get; set; }
        public virtual DbSet<SalesManMaster> SalesManMaster { get; set; }
        public virtual DbSet<SalesReturnDetails> SalesReturnDetails { get; set; }
        public virtual DbSet<SalesReturnMaster> SalesReturnMaster { get; set; }
        public virtual DbSet<SalesVoucher> SalesVoucher { get; set; }
        public virtual DbSet<SalesVoucherBatchDetials> SalesVoucherBatchDetials { get; set; }
        public virtual DbSet<SalesVoucherDetails> SalesVoucherDetails { get; set; }
        public virtual DbSet<ServiceMaster> ServiceMaster { get; set; }
        public virtual DbSet<SiteMaster> SiteMaster { get; set; }
        public virtual DbSet<SplitPaymentDetails> SplitPaymentDetails { get; set; }
        public virtual DbSet<StaffMaster> StaffMaster { get; set; }
        public virtual DbSet<StationMaster> StationMaster { get; set; }
        public virtual DbSet<StockAdjustment> StockAdjustment { get; set; }
        public virtual DbSet<StockAdjustmentVoucher> StockAdjustmentVoucher { get; set; }
        public virtual DbSet<StockAdjustmentVoucherDetails> StockAdjustmentVoucherDetails { get; set; }
        public virtual DbSet<StockEditPriceUpdate> StockEditPriceUpdate { get; set; }
        public virtual DbSet<StockExchangeDetails> StockExchangeDetails { get; set; }
        public virtual DbSet<StockExchangeMaster> StockExchangeMaster { get; set; }
        public virtual DbSet<StockInwardDetails> StockInwardDetails { get; set; }
        public virtual DbSet<StockInwardMaster> StockInwardMaster { get; set; }
        public virtual DbSet<StockRegister> StockRegister { get; set; }
        public virtual DbSet<StockReport> StockReport { get; set; }
        public virtual DbSet<StockReqDetails> StockReqDetails { get; set; }
        public virtual DbSet<StockReservation> StockReservation { get; set; }
        public virtual DbSet<StockReservationDetails> StockReservationDetails { get; set; }
        public virtual DbSet<StockStatement> StockStatement { get; set; }
        public virtual DbSet<StockTransfer> StockTransfer { get; set; }
        public virtual DbSet<StockTransferDetails> StockTransferDetails { get; set; }
        public virtual DbSet<StockTransferDetailsJobWise> StockTransferDetailsJobWise { get; set; }
        public virtual DbSet<StockTransferJobWise> StockTransferJobWise { get; set; }
        public virtual DbSet<StoreReqMaster> StoreReqMaster { get; set; }
        public virtual DbSet<SuppQuotationExpenseDetails> SuppQuotationExpenseDetails { get; set; }
        public virtual DbSet<SupplierContacts> SupplierContacts { get; set; }
        public virtual DbSet<SupplierDetails> SupplierDetails { get; set; }
        public virtual DbSet<SupplierPurchaseOrder> SupplierPurchaseOrder { get; set; }
        public virtual DbSet<SupplierPurchaseOrderDetails> SupplierPurchaseOrderDetails { get; set; }
        public virtual DbSet<SupplierQuotation> SupplierQuotation { get; set; }
        public virtual DbSet<SupplierQuotationDetails> SupplierQuotationDetails { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SuppliersMaster> SuppliersMaster { get; set; }
        public virtual DbSet<TempAgeingRpt> TempAgeingRpt { get; set; }
        public virtual DbSet<TempAssetDepCalc> TempAssetDepCalc { get; set; }
        public virtual DbSet<TempBalanceSheet> TempBalanceSheet { get; set; }
        public virtual DbSet<TempCashBook> TempCashBook { get; set; }
        public virtual DbSet<TempCashFlow> TempCashFlow { get; set; }
        public virtual DbSet<TempDayBook> TempDayBook { get; set; }
        public virtual DbSet<TempJobCostSummary> TempJobCostSummary { get; set; }
        public virtual DbSet<TempMisStatement> TempMisStatement { get; set; }
        public virtual DbSet<TempPlforecast> TempPlforecast { get; set; }
        public virtual DbSet<TempPlwithDate> TempPlwithDate { get; set; }
        public virtual DbSet<TempProfitLoss> TempProfitLoss { get; set; }
        public virtual DbSet<TempSalesJournalDetails> TempSalesJournalDetails { get; set; }
        public virtual DbSet<TempStatement> TempStatement { get; set; }
        public virtual DbSet<TempStatementVat> TempStatementVat { get; set; }
        public virtual DbSet<TempStkMovement> TempStkMovement { get; set; }
        public virtual DbSet<TempStockBaseUnit> TempStockBaseUnit { get; set; }
        public virtual DbSet<TempStockLedger> TempStockLedger { get; set; }
        public virtual DbSet<TempStockLedger1> TempStockLedger1 { get; set; }
        public virtual DbSet<TempStockLedgerBatch> TempStockLedgerBatch { get; set; }
        public virtual DbSet<TempStockPostail> TempStockPostail { get; set; }
        public virtual DbSet<TempStockpos> TempStockpos { get; set; }
        public virtual DbSet<TermsAndCondition> TermsAndCondition { get; set; }
        public virtual DbSet<TrackingRegister> TrackingRegister { get; set; }
        public virtual DbSet<TrialBalance> TrialBalance { get; set; }
        public virtual DbSet<TypeMaster> TypeMaster { get; set; }
        public virtual DbSet<UnitDetails> UnitDetails { get; set; }
        public virtual DbSet<UnitMaster> UnitMaster { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<UserTracking> UserTracking { get; set; }
        public virtual DbSet<UserWebAccSettings> UserWebAccSettings { get; set; }
        public virtual DbSet<VendorMaster> VendorMaster { get; set; }
        public virtual DbSet<VouchersNumbers> VouchersNumbers { get; set; }
        public virtual DbSet<WorkGroupMaster> WorkGroupMaster { get; set; }
        public virtual DbSet<WorkGroupPermissions> WorkGroupPermissions { get; set; }
        public virtual DbSet<WorkPeriods> WorkPeriods { get; set; }
        public virtual DbSet<StockRegisterResponse> StockRegisterResponse { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-H04AS89;Database=InspireErpDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region If the db table and entity has same name
            modelBuilder.Entity<StockRegisterResponse>().HasNoKey();
            #endregion

            #region If the db table and entity has different name
            modelBuilder.Entity<StockRegisterResponse>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.StockRegisterAmount).HasColumnName("Stock_Register_Amount");

                entity.Property(e => e.StockRegisterAmountTmp).HasColumnName("Stock_Register_AmountTmp");

                entity.Property(e => e.StockRegisterAssignedDate)
                    .HasColumnName("Stock_Register_Assigned_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterBatchCode)
                    .HasColumnName("Stock_Register_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterCalcDone).HasColumnName("Stock_Register_CalcDone");

                entity.Property(e => e.StockRegisterDelStatus).HasColumnName("Stock_Register_DelStatus");

                entity.Property(e => e.StockRegisterDepCode)
                    .HasColumnName("Stock_Register_Dep_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterExpDate)
                    .HasColumnName("Stock_Register_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterFcAmount).HasColumnName("Stock_Register_FC_Amount");

                entity.Property(e => e.StockRegisterFoc)
                    .HasColumnName("Stock_Register_FOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterFsno).HasColumnName("Stock_Register_FSNO");

                entity.Property(e => e.StockRegisterJobId).HasColumnName("Stock_Register_Job_ID");

                entity.Property(e => e.StockRegisterLocationId).HasColumnName("Stock_Register_Location_ID");

                entity.Property(e => e.StockRegisterMaterialId).HasColumnName("Stock_Register_Material_ID");

                entity.Property(e => e.StockRegisterNetStkBal).HasColumnName("Stock_Register_NetStkBal");

                entity.Property(e => e.StockRegisterPurchaseId)
                    .HasColumnName("Stock_Register_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterQuantity).HasColumnName("Stock_Register_Quantity");

                entity.Property(e => e.StockRegisterQueryRun).HasColumnName("Stock_Register_QueryRun");

                entity.Property(e => e.StockRegisterRate).HasColumnName("Stock_Register_Rate");

                entity.Property(e => e.StockRegisterRateTmp).HasColumnName("Stock_Register_RateTmp");

                entity.Property(e => e.StockRegisterRefVoucherNo)
                    .HasColumnName("Stock_Register_Ref_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterRemarks)
                    .HasColumnName("Stock_Register_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterSin).HasColumnName("Stock_Register_SIN");

                entity.Property(e => e.StockRegisterSno).HasColumnName("Stock_Register_Sno");

                entity.Property(e => e.StockRegisterSout).HasColumnName("Stock_Register_Sout");

                entity.Property(e => e.StockRegisterStatus)
                    .HasColumnName("Stock_Register_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterStoreId)
                    .HasColumnName("Stock_Register_Store_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockRegisterTransType)
                    .HasColumnName("Stock_Register_Trans_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterUnit).HasColumnName("Stock_Register_Unit_ID");

                entity.Property(e => e.StockRegisterUsedQty).HasColumnName("Stock_Register_Used_QTY");
            });
            #endregion


            modelBuilder.Entity<AccountSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account_Settings");

                entity.Property(e => e.AccountSettingsAccountCategory)
                    .HasColumnName("Account_Settings_Account_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSettingsAccountDelStatus).HasColumnName("Account_Settings_Account_DelStatus");

                entity.Property(e => e.AccountSettingsAccountDescription)
                    .HasColumnName("Account_Settings_Account_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSettingsAccountFormId).HasColumnName("Account_Settings_Account_Form_ID");

                entity.Property(e => e.AccountSettingsAccountId).HasColumnName("Account_Settings_Account_ID");

                entity.Property(e => e.AccountSettingsAccountKeyValue)
                    .HasColumnName("Account_Settings_Account_Key_Value")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.AccountSettingsAccountNumberValue).HasColumnName("Account_Settings_Account_Number_Value");

                entity.Property(e => e.AccountSettingsAccountTableName)
                    .HasColumnName("Account_Settings_Account_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSettingsAccountTextValue)
                    .HasColumnName("Account_Settings_Account_Text_Value")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSettingsAccountType)
                    .HasColumnName("Account_Settings_Account_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSettingsAccountValueType)
                    .HasColumnName("Account_Settings_Account_Value_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountsTransactions>(entity =>
            {
                entity.HasKey(e => e.AccountsTransactionsTransSno);

                entity.Property(e => e.AccountsTransactionsTransSno).HasColumnName("AccountsTransactions_TransSno");

                entity.Property(e => e.AccountsTransactionsAccNo)
                    .IsRequired()
                    .HasColumnName("AccountsTransactions_AccNo")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountsTransactionsAllocBalance)
                    .HasColumnName("AccountsTransactions_Alloc_Balance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsAllocCredit)
                    .HasColumnName("AccountsTransactions_Alloc_Credit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsAllocDebit)
                    .HasColumnName("AccountsTransactions_Alloc_Debit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsAllocUpdateBal).HasColumnName("AccountsTransactions_AllocUpdateBal");

                entity.Property(e => e.AccountsTransactionsApprovalDt)
                    .HasColumnName("AccountsTransactions_ApprovalDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountsTransactionsCheqDate)
                    .HasColumnName("AccountsTransactions_CheqDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountsTransactionsCheqNo)
                    .HasColumnName("AccountsTransactions_CheqNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsCompanyId).HasColumnName("AccountsTransactions_CompanyId");

                entity.Property(e => e.AccountsTransactionsCostCenterId).HasColumnName("AccountsTransactions_CostCenter_Id");

                entity.Property(e => e.AccountsTransactionsCrGram).HasColumnName("AccountsTransactions_CrGram");

                entity.Property(e => e.AccountsTransactionsCredit)
                    .HasColumnName("AccountsTransactions_Credit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsCurrencyId).HasColumnName("AccountsTransactions_CurrencyId");

                entity.Property(e => e.AccountsTransactionsDebit)
                    .HasColumnName("AccountsTransactions_Debit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsDepartment).HasColumnName("AccountsTransactions_Department");

                entity.Property(e => e.AccountsTransactionsDeptId).HasColumnName("AccountsTransactions_DeptID");

                entity.Property(e => e.AccountsTransactionsDescription)
                    .HasColumnName("AccountsTransactions_Description")
                    .HasMaxLength(200);

                entity.Property(e => e.AccountsTransactionsDrGram).HasColumnName("AccountsTransactions_DrGram");

                entity.Property(e => e.AccountsTransactionsFcAllocBalance)
                    .HasColumnName("AccountsTransactions_Fc_Alloc_Balance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFcAllocCredit)
                    .HasColumnName("AccountsTransactions_Fc_Alloc_Credit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFcAllocDebit)
                    .HasColumnName("AccountsTransactions_Fc_Alloc_Debit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFcCredit)
                    .HasColumnName("AccountsTransactions_Fc_Credit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFcDebit)
                    .HasColumnName("AccountsTransactions_Fc_Debit")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFcRate)
                    .HasColumnName("AccountsTransactions_Fc_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsFsno)
                    .HasColumnName("AccountsTransactions_FSNO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountsTransactionsJobNo).HasColumnName("AccountsTransactions_JobNo");

                entity.Property(e => e.AccountsTransactionsLocation).HasColumnName("AccountsTransactions_Location");

                entity.Property(e => e.AccountsTransactionsLpoNo)
                    .HasColumnName("AccountsTransactions_LpoNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsOpposEntryDesc)
                    .HasColumnName("AccountsTransactions_OpposEntryDesc")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsParticulars)
                    .HasColumnName("AccountsTransactions_Particulars")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountsTransactionsStatus)
                    .IsRequired()
                    .HasColumnName("AccountsTransactions_Status")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsTransDate)
                    .HasColumnName("AccountsTransactions_TransDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountsTransactionsTstamp)
                    .HasColumnName("AccountsTransactions_TStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountsTransactionsUserId).HasColumnName("AccountsTransactions_User_ID");

                entity.Property(e => e.AccountsTransactionsVatableAmount)
                    .HasColumnName("AccountsTransactions_VatableAmount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AccountsTransactionsVatno)
                    .HasColumnName("AccountsTransactions_VATNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsVoucherNo)
                    .IsRequired()
                    .HasColumnName("AccountsTransactions_VoucherNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsTransactionsVoucherType)
                    .IsRequired()
                    .HasColumnName("AccountsTransactions_VoucherType")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AccountstransactionsDelStatus).HasColumnName("Accountstransactions_DelStatus");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.AccountsTransactionsVoucherNoNavigation)
                    .WithMany(p => p.AccountsTransactions)
                    .HasPrincipalKey(p => p.VouchersNumbersVNo)
                    .HasForeignKey(d => d.AccountsTransactionsVoucherNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsTransactions_Voucher_numbers");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Activity_Log");

                entity.Property(e => e.ActivityLogBrowserInfo)
                    .HasColumnName("Activity_Log_Browser_Info")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLogColumnName)
                    .HasColumnName("Activity_Log_Column_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLogDelStatus).HasColumnName("Activity_Log_DelStatus");

                entity.Property(e => e.ActivityLogId)
                    .HasColumnName("Activity_Log_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityLogModifiedDate)
                    .HasColumnName("Activity_Log_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActivityLogModifiedUserId).HasColumnName("Activity_Log_Modified_User_ID");

                entity.Property(e => e.ActivityLogNewValue)
                    .HasColumnName("Activity_Log_New_Value")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLogOldValue)
                    .HasColumnName("Activity_Log_Old_Value")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLogPageId).HasColumnName("Activity_Log_Page_ID");

                entity.Property(e => e.ActivityLogStatus).HasColumnName("Activity_Log_Status");

                entity.Property(e => e.ActivityLogTableName)
                    .HasColumnName("Activity_Log_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLogTrackingId).HasColumnName("Activity_Log_Tracking_ID");

                entity.Property(e => e.ActivityLogUserIp)
                    .HasColumnName("Activity_Log_User_IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgeingTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ageing_Table");

                entity.Property(e => e.Ageing030).HasColumnName("Ageing_0_30");

                entity.Property(e => e.Ageing181270).HasColumnName("Ageing_181_270");

                entity.Property(e => e.Ageing271360).HasColumnName("Ageing_271_360");

                entity.Property(e => e.Ageing3160).HasColumnName("Ageing_31_60");

                entity.Property(e => e.Ageing6190).HasColumnName("Ageing_61_90");

                entity.Property(e => e.Ageing91180).HasColumnName("Ageing_91_180");

                entity.Property(e => e.AgeingAccNo)
                    .HasColumnName("Ageing_AccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgeingAllBalance).HasColumnName("Ageing_All_Balance");

                entity.Property(e => e.AgeingCreditBalance).HasColumnName("Ageing_Credit_Balance");

                entity.Property(e => e.AgeingCreditDays).HasColumnName("Ageing_Credit_Days");

                entity.Property(e => e.AgeingCreditLimit).HasColumnName("Ageing_Credit_Limit");

                entity.Property(e => e.AgeingCsname)
                    .HasColumnName("Ageing_CSName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AgeingDelStatus).HasColumnName("Ageing_DelStatus");

                entity.Property(e => e.AgeingOutstandingBal).HasColumnName("Ageing_Outstanding_Bal");

                entity.Property(e => e.AgeingOver360).HasColumnName("Ageing_Over_360");

                entity.Property(e => e.AgeingSalesMan).HasColumnName("Ageing_Sales_Man");

                entity.Property(e => e.AgeingSalesManName)
                    .HasColumnName("Ageing_Sales_Man_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllocationType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Allocation_Type");

                entity.Property(e => e.AllocationTypeDelStatus).HasColumnName("Allocation_Type_DelStatus");

                entity.Property(e => e.AllocationTypeId)
                    .HasColumnName("Allocation_Type_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllocationTypeName)
                    .HasColumnName("Allocation_Type_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationTypeStatus).HasColumnName("Allocation_Type_Status");
            });

            modelBuilder.Entity<AllocationVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Allocation_Voucher");

                entity.Property(e => e.AllocationVoucherAvStatus)
                    .HasColumnName("Allocation_Voucher_AV_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AllocationVoucherDelStatus).HasColumnName("Allocation_Voucher_DelStatus");

                entity.Property(e => e.AllocationVoucherDescription)
                    .HasColumnName("Allocation_Voucher_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherId).HasColumnName("Allocation_Voucher_ID");

                entity.Property(e => e.AllocationVoucherLocationId).HasColumnName("Allocation_Voucher_Location_ID");

                entity.Property(e => e.AllocationVoucherRefVno)
                    .HasColumnName("Allocation_Voucher_RefVNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherRefVtype).HasColumnName("Allocation_Voucher_REfVType");

                entity.Property(e => e.AllocationVoucherStatus)
                    .HasColumnName("Allocation_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AllocationVoucherType).HasColumnName("Allocation_Voucher_Type");

                entity.Property(e => e.AllocationVoucherUserId).HasColumnName("Allocation_Voucher_User_ID");

                entity.Property(e => e.AllocationVoucherVcreation)
                    .HasColumnName("Allocation_Voucher_Vcreation")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherVoucherAccNo)
                    .HasColumnName("Allocation_Voucher_Voucher_Acc_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherVoucherAccType)
                    .HasColumnName("Allocation_Voucher_Voucher_Acc_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherVoucherDate)
                    .HasColumnName("Allocation_Voucher_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AllocationVoucherVoucherFsno).HasColumnName("Allocation_Voucher_Voucher_FSNO");

                entity.Property(e => e.AllocationVoucherVoucherNo)
                    .HasColumnName("Allocation_Voucher_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllocationVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Allocation_Voucher_Details");

                entity.Property(e => e.AllocationVoucherDetailsAccNo)
                    .HasColumnName("Allocation_Voucher_Details_ACC_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherDetailsAllocCredit).HasColumnName("Allocation_Voucher_Details_Alloc_Credit");

                entity.Property(e => e.AllocationVoucherDetailsAllocDebit).HasColumnName("Allocation_Voucher_Details_Alloc_Debit");

                entity.Property(e => e.AllocationVoucherDetailsDelStatus).HasColumnName("Allocation_Voucher_Details_DelStatus");

                entity.Property(e => e.AllocationVoucherDetailsFcAllocCredit).HasColumnName("Allocation_Voucher_Details_FC_Alloc_Credit");

                entity.Property(e => e.AllocationVoucherDetailsFcAllocDebit).HasColumnName("Allocation_Voucher_Details_FC_Alloc_Debit");

                entity.Property(e => e.AllocationVoucherDetailsId).HasColumnName("Allocation_Voucher_Details_ID");

                entity.Property(e => e.AllocationVoucherDetailsRefFsno).HasColumnName("Allocation_Voucher_Details_Ref_FSNO");

                entity.Property(e => e.AllocationVoucherDetailsRefLocationId).HasColumnName("Allocation_Voucher_Details_Ref_Location_ID");

                entity.Property(e => e.AllocationVoucherDetailsRefVno)
                    .HasColumnName("Allocation_Voucher_Details_RefVNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherDetailsRefVtype)
                    .HasColumnName("Allocation_Voucher_Details_RefVType")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherDetailsSno)
                    .HasColumnName("Allocation_Voucher_Details_SNO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllocationVoucherDetailsTransSno).HasColumnName("Allocation_Voucher_Details_TransSno");

                entity.Property(e => e.AllocationVoucherDetailsVFsno).HasColumnName("Allocation_Voucher_Details_V_FSNO");

                entity.Property(e => e.AllocationVoucherDetailsVLocationId).HasColumnName("Allocation_Voucher_Details_V_Location_ID");

                entity.Property(e => e.AllocationVoucherDetailsVno)
                    .HasColumnName("Allocation_Voucher_Details_VNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationVoucherDetailsVtype).HasColumnName("Allocation_Voucher_Details_Vtype");
            });

            modelBuilder.Entity<AssetDepDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Dep_Details");

                entity.Property(e => e.AssetDepDetailsAccDepAmount).HasColumnName("Asset_Dep_Details_Acc_Dep_Amount");

                entity.Property(e => e.AssetDepDetailsAmount).HasColumnName("Asset_Dep_Details_Amount");

                entity.Property(e => e.AssetDepDetailsDelStatus).HasColumnName("Asset_Dep_Details_DelStatus");

                entity.Property(e => e.AssetDepDetailsDepAmount).HasColumnName("Asset_Dep_Details_Dep_Amount");

                entity.Property(e => e.AssetDepDetailsDepFrom)
                    .HasColumnName("Asset_Dep_Details_Dep_From")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetDepDetailsDepPercentage).HasColumnName("Asset_Dep_Details_Dep_Percentage");

                entity.Property(e => e.AssetDepDetailsDepTo)
                    .HasColumnName("Asset_Dep_Details_Dep_To")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetDepDetailsDjvno)
                    .HasColumnName("Asset_Dep_Details_DJVno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetDepDetailsId).HasColumnName("Asset_Dep_Details_ID");

                entity.Property(e => e.AssetDepDetailsNetBookValue).HasColumnName("Asset_Dep_Details_NetBookValue");

                entity.Property(e => e.AssetDepDetailsPurchaseDate)
                    .HasColumnName("Asset_Dep_Details_Purchase_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetDepDetailsPurchaseId)
                    .HasColumnName("Asset_Dep_Details_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Master");

                entity.Property(e => e.AssetMasterAssetAccountNo)
                    .HasColumnName("Asset_Master_Asset_Account_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMasterAssetCode)
                    .HasColumnName("Asset_Master_Asset_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMasterAssetCreatedDate)
                    .HasColumnName("Asset_Master_Asset_Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetMasterAssetDelStatus).HasColumnName("Asset_Master_Asset_DelStatus");

                entity.Property(e => e.AssetMasterAssetDepExpAccount)
                    .HasColumnName("Asset_Master_Asset_DepExp_Account")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMasterAssetDepLibAccount)
                    .HasColumnName("Asset_Master_Asset_DepLib_Account")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMasterAssetId).HasColumnName("Asset_Master_Asset_ID");

                entity.Property(e => e.AssetMasterAssetName)
                    .HasColumnName("Asset_Master_Asset_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMasterAssetRelativeNo).HasColumnName("Asset_Master_Asset_RelativeNo");

                entity.Property(e => e.AssetMasterAssetType)
                    .HasColumnName("Asset_Master_Asset_Type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AutoCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Auto_Codes");

                entity.Property(e => e.AutoCodeColDescription)
                    .HasColumnName("Auto_Code_ColDescription")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AutoCodeColValue).HasColumnName("Auto_Code_ColValue");

                entity.Property(e => e.AutoCodeColValueV)
                    .HasColumnName("Auto_Code_ColValue_V")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AutoCodeDelStatus).HasColumnName("Auto_Code_DelStatus");

                entity.Property(e => e.AutoCodeId).HasColumnName("Auto_Code_ID");
            });

            modelBuilder.Entity<AvCreditNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Credit_Note");

                entity.Property(e => e.AvCreditNoteAllocId).HasColumnName("AV_Credit_Note_Alloc_ID");

                entity.Property(e => e.AvCreditNoteCrAcNo)
                    .HasColumnName("AV_Credit_Note_Cr_Ac_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvCreditNoteCrAmount).HasColumnName("AV_Credit_Note_Cr_Amount");

                entity.Property(e => e.AvCreditNoteDate)
                    .HasColumnName("AV_Credit_Note_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvCreditNoteDelStatus).HasColumnName("AV_Credit_Note_DelStatus");

                entity.Property(e => e.AvCreditNoteFcCrAmount).HasColumnName("AV_Credit_Note_FC_Cr_Amount");

                entity.Property(e => e.AvCreditNoteFcRate).HasColumnName("AV_Credit_Note_FC_Rate");

                entity.Property(e => e.AvCreditNoteFsno).HasColumnName("AV_Credit_Note_FSNO");

                entity.Property(e => e.AvCreditNoteId).HasColumnName("AV_Credit_Note_ID");

                entity.Property(e => e.AvCreditNoteNarration)
                    .HasColumnName("AV_Credit_Note_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AvCreditNoteRefNo)
                    .HasColumnName("AV_Credit_Note_Ref_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvCreditNoteSno).HasColumnName("AV_Credit_Note_SNO");

                entity.Property(e => e.AvCreditNoteStatus)
                    .HasColumnName("AV_Credit_Note_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvCreditNoteUserId).HasColumnName("AV_Credit_Note_User_ID");
            });

            modelBuilder.Entity<AvCreditNoteDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Credit_Note_Details");

                entity.Property(e => e.AvCreditNoteDetailsAccNo)
                    .HasColumnName("AV_Credit_Note_Details_AccNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvCreditNoteDetailsAccSno).HasColumnName("AV_Credit_Note_Details_AccSNo");

                entity.Property(e => e.AvCreditNoteDetailsCostCenterId).HasColumnName("AV_Credit_Note_Details_Cost_Center_ID");

                entity.Property(e => e.AvCreditNoteDetailsDelStatus).HasColumnName("AV_Credit_Note_Details_DelStatus");

                entity.Property(e => e.AvCreditNoteDetailsFcAmount).HasColumnName("AV_Credit_Note_Details_FC_Amount");

                entity.Property(e => e.AvCreditNoteDetailsId).HasColumnName("AV_Credit_Note_Details_ID");

                entity.Property(e => e.AvCreditNoteDetailsJobNo).HasColumnName("AV_Credit_Note_Details_JobNo");

                entity.Property(e => e.AvCreditNoteDetailsNarration)
                    .HasColumnName("AV_Credit_Note_Details_Narration")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AvDebitNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Debit_Note");

                entity.Property(e => e.AvDebitNoteAllocId).HasColumnName("AV_Debit_Note_Alloc_ID");

                entity.Property(e => e.AvDebitNoteDate)
                    .HasColumnName("AV_Debit_Note_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvDebitNoteDelStatus).HasColumnName("AV_Debit_Note_DelStatus");

                entity.Property(e => e.AvDebitNoteDrAcNo)
                    .HasColumnName("AV_Debit_Note_Dr_Ac_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvDebitNoteDrAmount).HasColumnName("AV_Debit_Note_DR_Amount");

                entity.Property(e => e.AvDebitNoteFcDrAmount).HasColumnName("AV_Debit_Note_FC_DR_Amount");

                entity.Property(e => e.AvDebitNoteFcRate).HasColumnName("AV_Debit_Note_FC_Rate");

                entity.Property(e => e.AvDebitNoteFsno).HasColumnName("AV_Debit_Note_FSNO");

                entity.Property(e => e.AvDebitNoteId).HasColumnName("AV_Debit_Note_ID");

                entity.Property(e => e.AvDebitNoteNarration)
                    .HasColumnName("AV_Debit_Note_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AvDebitNoteRefNo)
                    .HasColumnName("AV_Debit_Note_RefNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvDebitNoteSno).HasColumnName("AV_Debit_Note_SNO");

                entity.Property(e => e.AvDebitNoteStatus)
                    .HasColumnName("AV_Debit_Note_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvDebitNoteUserId).HasColumnName("AV_Debit_Note_User_ID");
            });

            modelBuilder.Entity<AvDebitNoteDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Debit_Note_Details");

                entity.Property(e => e.AvDebitNoteDelStatus).HasColumnName("AV_Debit_Note_DelStatus");

                entity.Property(e => e.AvDebitNoteDetailsAccNo)
                    .HasColumnName("AV_Debit_Note_Details_Acc_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvDebitNoteDetailsAccSno).HasColumnName("AV_Debit_Note_Details_AccSNO");

                entity.Property(e => e.AvDebitNoteDetailsAmount).HasColumnName("AV_Debit_Note_Details_Amount");

                entity.Property(e => e.AvDebitNoteDetailsCostCenterId).HasColumnName("AV_Debit_Note_Details_Cost_Center_ID");

                entity.Property(e => e.AvDebitNoteDetailsFcAmount).HasColumnName("AV_Debit_Note_Details_FC_Amount");

                entity.Property(e => e.AvDebitNoteDetailsId).HasColumnName("AV_Debit_Note_Details_ID");

                entity.Property(e => e.AvDebitNoteDetailsJobNo).HasColumnName("AV_Debit_Note_Details_Job_No");

                entity.Property(e => e.AvDebitNoteDetailsNarration)
                    .HasColumnName("AV_Debit_Note_Details_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AvIssueVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Issue_Voucher");

                entity.Property(e => e.AvIssueVoucherAccNo)
                    .HasColumnName("AV_Issue_Voucher_Acc_NO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherAvSalesAcNo)
                    .HasColumnName("AV_Issue_Voucher_AV_Sales_AC_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherAvsvDate)
                    .HasColumnName("AV_Issue_Voucher_AVSV_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvIssueVoucherAvsvId)
                    .HasColumnName("AV_Issue_Voucher_AVSV_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AvIssueVoucherAvsvNo)
                    .HasColumnName("AV_Issue_Voucher_AVSV_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.AvIssueVoucherCostCenter).HasColumnName("AV_Issue_Voucher_Cost_Center");

                entity.Property(e => e.AvIssueVoucherCurrencyId).HasColumnName("AV_Issue_Voucher_Currency_ID");

                entity.Property(e => e.AvIssueVoucherDayBookNo)
                    .HasColumnName("AV_Issue_Voucher_DayBook_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDelStatus).HasColumnName("AV_Issue_Voucher_DelStatus");

                entity.Property(e => e.AvIssueVoucherDepartmentId).HasColumnName("AV_Issue_Voucher_Department_ID");

                entity.Property(e => e.AvIssueVoucherDiscountAmount).HasColumnName("AV_Issue_Voucher_Discount_Amount");

                entity.Property(e => e.AvIssueVoucherDiscountPercentage).HasColumnName("AV_Issue_Voucher_Discount_Percentage");

                entity.Property(e => e.AvIssueVoucherExpenseAccount)
                    .HasColumnName("AV_Issue_Voucher_Expense_Account")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherFcRate).HasColumnName("AV_Issue_Voucher_FC_Rate");

                entity.Property(e => e.AvIssueVoucherFcTotalAmount).HasColumnName("AV_Issue_Voucher_FC_Total_Amount");

                entity.Property(e => e.AvIssueVoucherFsno).HasColumnName("AV_Issue_Voucher_FSNO");

                entity.Property(e => e.AvIssueVoucherIssueEqpmentIdN).HasColumnName("AV_Issue_Voucher_Issue_Eqpment_ID_N");

                entity.Property(e => e.AvIssueVoucherJobId).HasColumnName("AV_Issue_Voucher_Job_ID");

                entity.Property(e => e.AvIssueVoucherLocationId).HasColumnName("AV_Issue_Voucher_Location_ID");

                entity.Property(e => e.AvIssueVoucherNarration)
                    .HasColumnName("AV_Issue_Voucher_Narration")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherNetAmount).HasColumnName("AV_Issue_Voucher_Net_Amount");

                entity.Property(e => e.AvIssueVoucherPoNo)
                    .HasColumnName("AV_Issue_Voucher_PO_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherPurchaseId)
                    .HasColumnName("AV_Issue_Voucher_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherReqNo)
                    .HasColumnName("AV_Issue_Voucher_Req_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherStatus)
                    .HasColumnName("AV_Issue_Voucher_Status")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AvIssueVoucherStockAccount)
                    .HasColumnName("AV_Issue_Voucher_Stock_Account")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherTotalAmount).HasColumnName("AV_Issue_Voucher_Total_Amount");

                entity.Property(e => e.AvIssueVoucherUserId).HasColumnName("AV_Issue_Voucher_User_ID");
            });

            modelBuilder.Entity<AvIssueVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Issue_Voucher_Details");

                entity.Property(e => e.AvIssueVoucherDetailsAvSvNo)
                    .HasColumnName("AV_Issue_Voucher_Details_AV_SV_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDetailsAvSvSno)
                    .HasColumnName("AV_Issue_Voucher_Details_AV_SV_Sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AvIssueVoucherDetailsDelStatus).HasColumnName("AV_Issue_Voucher_Details_DelStatus");

                entity.Property(e => e.AvIssueVoucherDetailsExpenseAccount)
                    .HasColumnName("AV_Issue_Voucher_Details_Expense_Account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDetailsFsno).HasColumnName("AV_Issue_Voucher_Details_FSNO");

                entity.Property(e => e.AvIssueVoucherDetailsMaterialId).HasColumnName("AV_Issue_Voucher_Details_Material_ID");

                entity.Property(e => e.AvIssueVoucherDetailsQuantity).HasColumnName("AV_Issue_Voucher_Details_Quantity");

                entity.Property(e => e.AvIssueVoucherDetailsRate).HasColumnName("AV_Issue_Voucher_Details_Rate");

                entity.Property(e => e.AvIssueVoucherDetailsRemakrs)
                    .HasColumnName("AV_Issue_Voucher_Details_Remakrs")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDetailsSno).HasColumnName("AV_Issue_Voucher_Details_SNO");

                entity.Property(e => e.AvIssueVoucherDetailsSoldAmount).HasColumnName("AV_Issue_Voucher_Details_Sold_Amount");

                entity.Property(e => e.AvIssueVoucherDetailsSoldQuantity).HasColumnName("AV_Issue_Voucher_Details_Sold_Quantity");

                entity.Property(e => e.AvIssueVoucherDetailsSrdId).HasColumnName("AV_Issue_Voucher_Details_SRD_ID");

                entity.Property(e => e.AvIssueVoucherDetailsStock).HasColumnName("AV_Issue_Voucher_Details_Stock");

                entity.Property(e => e.AvIssueVoucherDetailsUId).HasColumnName("AV_Issue_Voucher_Details_U_ID");
            });

            modelBuilder.Entity<AvIssueVoucherDetailsReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Issue_Voucher_Details_Return");

                entity.Property(e => e.AvIssueVoucherDetailsReturnDelStatus).HasColumnName("AV_Issue_Voucher_Details_Return_DelStatus");

                entity.Property(e => e.AvIssueVoucherDetailsReturnExpenseAccount)
                    .HasColumnName("AV_Issue_Voucher_Details_Return_Expense_Account")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDetailsReturnFcAmount).HasColumnName("AV_Issue_Voucher_Details_Return_FC_Amount");

                entity.Property(e => e.AvIssueVoucherDetailsReturnFsno).HasColumnName("AV_Issue_Voucher_Details_Return_FSNO");

                entity.Property(e => e.AvIssueVoucherDetailsReturnIssueVoucherNo)
                    .HasColumnName("AV_Issue_Voucher_Details_Return_Issue_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherDetailsReturnIssueVoucherReturnNo).HasColumnName("AV_Issue_Voucher_Details_Return_Issue_Voucher_Return_No");

                entity.Property(e => e.AvIssueVoucherDetailsReturnMaterialId).HasColumnName("AV_Issue_Voucher_Details_Return_Material_ID");

                entity.Property(e => e.AvIssueVoucherDetailsReturnQuantity).HasColumnName("AV_Issue_Voucher_Details_Return_Quantity");

                entity.Property(e => e.AvIssueVoucherDetailsReturnRate).HasColumnName("AV_Issue_Voucher_Details_Return_Rate");

                entity.Property(e => e.AvIssueVoucherDetailsReturnReturnedAmount).HasColumnName("AV_Issue_Voucher_Details_Return_Returned_Amount");

                entity.Property(e => e.AvIssueVoucherDetailsReturnReturnedQuantity).HasColumnName("AV_Issue_Voucher_Details_Return_Returned_Quantity");

                entity.Property(e => e.AvIssueVoucherDetailsReturnSno).HasColumnName("AV_Issue_Voucher_Details_Return_SNO");

                entity.Property(e => e.AvIssueVoucherDetailsReturnUId).HasColumnName("AV_Issue_Voucher_Details_Return_U_ID");
            });

            modelBuilder.Entity<AvIssueVoucherReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AV_Issue_Voucher_Return");

                entity.Property(e => e.AvIssueVoucherReturnDelStatus).HasColumnName("AV_Issue_Voucher_Return_DelStatus");

                entity.Property(e => e.AvIssueVoucherReturnFcRate).HasColumnName("AV_Issue_Voucher_Return_FC_Rate");

                entity.Property(e => e.AvIssueVoucherReturnFcTotalAmount).HasColumnName("AV_Issue_Voucher_Return_FC_Total_Amount");

                entity.Property(e => e.AvIssueVoucherReturnFsno).HasColumnName("AV_Issue_Voucher_Return_FSNO");

                entity.Property(e => e.AvIssueVoucherReturnIssueVoucherDate)
                    .HasColumnName("AV_Issue_Voucher_Return_Issue_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvIssueVoucherReturnIssueVoucherId)
                    .HasColumnName("AV_Issue_Voucher_Return_Issue_Voucher_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AvIssueVoucherReturnIssueVoucherNo)
                    .HasColumnName("AV_Issue_Voucher_Return_Issue_Voucher_No")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AvIssueVoucherReturnIssueVoucherReturnDate)
                    .HasColumnName("AV_Issue_Voucher_Return_Issue_Voucher_Return_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvIssueVoucherReturnIssueVoucherReturnNo)
                    .HasColumnName("AV_Issue_Voucher_Return_Issue_Voucher_Return_No")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AvIssueVoucherReturnJobId).HasColumnName("AV_Issue_Voucher_Return_Job_ID");

                entity.Property(e => e.AvIssueVoucherReturnLoactionId).HasColumnName("AV_Issue_Voucher_Return_Loaction_ID");

                entity.Property(e => e.AvIssueVoucherReturnNarration)
                    .HasColumnName("AV_Issue_Voucher_Return_Narration")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherReturnPoNo)
                    .HasColumnName("AV_Issue_Voucher_Return_PO_NO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherReturnSalesAcNo)
                    .HasColumnName("AV_Issue_Voucher_Return_Sales_AC_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AvIssueVoucherReturnStatus)
                    .HasColumnName("AV_Issue_Voucher_Return_Status")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AvIssueVoucherReturnTotalAmount).HasColumnName("AV_Issue_Voucher_Return_Total_Amount");

                entity.Property(e => e.AvIssueVoucherReturnUserId).HasColumnName("AV_Issue_Voucher_Return_User_ID");
            });

            modelBuilder.Entity<BankMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Master");

                entity.Property(e => e.BankMasterDelStatus).HasColumnName("Bank_Master_DelStatus");

                entity.Property(e => e.BankMasterDi).HasColumnName("Bank_Master_DI");

                entity.Property(e => e.BankMasterName)
                    .HasColumnName("Bank_Master_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankMasterStatus).HasColumnName("Bank_Master_Status");
            });

            modelBuilder.Entity<BankPaymentVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Payment_Voucher");

                entity.Property(e => e.BankPaymentVoucherAllocId).HasColumnName("Bank_Payment_Voucher_Alloc_ID");

                entity.Property(e => e.BankPaymentVoucherCrAcNo)
                    .HasColumnName("Bank_Payment_Voucher_CR_AC_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankPaymentVoucherCrAmount).HasColumnName("Bank_Payment_Voucher_CR_Amount");

                entity.Property(e => e.BankPaymentVoucherCurrencyId).HasColumnName("Bank_Payment_Voucher_Currency_ID");

                entity.Property(e => e.BankPaymentVoucherDelStatus).HasColumnName("Bank_Payment_Voucher_DelStatus");

                entity.Property(e => e.BankPaymentVoucherDrAmount).HasColumnName("Bank_Payment_Voucher_DR_Amount");

                entity.Property(e => e.BankPaymentVoucherFcRate).HasColumnName("Bank_Payment_Voucher_FC_Rate");

                entity.Property(e => e.BankPaymentVoucherFrCrAmount).HasColumnName("Bank_Payment_Voucher_FR_CR_Amount");

                entity.Property(e => e.BankPaymentVoucherFrDrAmount).HasColumnName("Bank_Payment_Voucher_FR_DR_Amount");

                entity.Property(e => e.BankPaymentVoucherFsno).HasColumnName("Bank_Payment_Voucher_FSNO");

                entity.Property(e => e.BankPaymentVoucherLocationId).HasColumnName("Bank_Payment_Voucher_Location_ID");

                entity.Property(e => e.BankPaymentVoucherNarration)
                    .HasColumnName("Bank_Payment_Voucher_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankPaymentVoucherOptType)
                    .HasColumnName("Bank_Payment_Voucher_Opt_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankPaymentVoucherRefNo).HasColumnName("Bank_Payment_Voucher_RefNO");

                entity.Property(e => e.BankPaymentVoucherStatus)
                    .HasColumnName("Bank_Payment_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankPaymentVoucherUserId).HasColumnName("Bank_Payment_Voucher_User_ID");

                entity.Property(e => e.BankPaymentVoucherVDt)
                    .HasColumnName("Bank_Payment_Voucher_V_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankPaymentVoucherVNo).HasColumnName("Bank_Payment_Voucher_V_NO");
            });

            modelBuilder.Entity<BankPaymentVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Payment_Voucher_Details");

                entity.Property(e => e.BankPaymentVoucherDetailsAcNo)
                    .HasColumnName("Bank_Payment_Voucher_Details_AC_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankPaymentVoucherDetailsChequeDate)
                    .HasColumnName("Bank_Payment_Voucher_Details_Cheque_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankPaymentVoucherDetailsChequeNo).HasColumnName("Bank_Payment_Voucher_Details_Cheque_No");

                entity.Property(e => e.BankPaymentVoucherDetailsCostCenterId).HasColumnName("Bank_Payment_Voucher_Details_Cost_Center_ID");

                entity.Property(e => e.BankPaymentVoucherDetailsCrAmount).HasColumnName("Bank_Payment_Voucher_Details_CR_Amount");

                entity.Property(e => e.BankPaymentVoucherDetailsCrFcAmount).HasColumnName("Bank_Payment_Voucher_Details_CR_FC_Amount");

                entity.Property(e => e.BankPaymentVoucherDetailsDelStatus).HasColumnName("Bank_Payment_Voucher_Details_DelStatus");

                entity.Property(e => e.BankPaymentVoucherDetailsDrAmount).HasColumnName("Bank_Payment_Voucher_Details_DR_Amount");

                entity.Property(e => e.BankPaymentVoucherDetailsDrFcAmount).HasColumnName("Bank_Payment_Voucher_Details_DR_FC_Amount");

                entity.Property(e => e.BankPaymentVoucherDetailsFsno).HasColumnName("Bank_Payment_Voucher_Details_FSNO");

                entity.Property(e => e.BankPaymentVoucherDetailsId).HasColumnName("Bank_Payment_Voucher_Details_ID");

                entity.Property(e => e.BankPaymentVoucherDetailsInvDate)
                    .HasColumnName("Bank_Payment_Voucher_Details_Inv_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankPaymentVoucherDetailsInvNo)
                    .HasColumnName("Bank_Payment_Voucher_Details_Inv_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankPaymentVoucherDetailsJobNo).HasColumnName("Bank_Payment_Voucher_Details_Job_No");

                entity.Property(e => e.BankPaymentVoucherDetailsNarration)
                    .HasColumnName("Bank_Payment_Voucher_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankPaymentVoucherDetailsPdc).HasColumnName("Bank_Payment_Voucher_Details_PDC");

                entity.Property(e => e.BankPaymentVoucherDetailsPdcId).HasColumnName("Bank_Payment_Voucher_Details_PDC_ID");

                entity.Property(e => e.BankPaymentVoucherDetailsSno).HasColumnName("Bank_Payment_Voucher_Details_SNO");
            });

            modelBuilder.Entity<BankReceiptVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Receipt_Voucher");

                entity.Property(e => e.BankReceiptVoucherAllocId).HasColumnName("Bank_Receipt_Voucher_Alloc_ID");

                entity.Property(e => e.BankReceiptVoucherCrAmount).HasColumnName("Bank_Receipt_Voucher_CR_Amount");

                entity.Property(e => e.BankReceiptVoucherCurrencyId).HasColumnName("Bank_Receipt_Voucher_Currency_ID");

                entity.Property(e => e.BankReceiptVoucherDelStatus).HasColumnName("Bank_Receipt_Voucher_DelStatus");

                entity.Property(e => e.BankReceiptVoucherDrAcNo)
                    .HasColumnName("Bank_Receipt_Voucher_DR_AC_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankReceiptVoucherDrAmount).HasColumnName("Bank_Receipt_Voucher_DR_Amount");

                entity.Property(e => e.BankReceiptVoucherFcRate).HasColumnName("Bank_Receipt_Voucher_FC_Rate");

                entity.Property(e => e.BankReceiptVoucherFrCrAmount).HasColumnName("Bank_Receipt_Voucher_FR_CR_Amount");

                entity.Property(e => e.BankReceiptVoucherFrDrAmount).HasColumnName("Bank_Receipt_Voucher_FR_DR_Amount");

                entity.Property(e => e.BankReceiptVoucherFsno).HasColumnName("Bank_Receipt_Voucher_FSNO");

                entity.Property(e => e.BankReceiptVoucherId).HasColumnName("Bank_Receipt_Voucher_ID");

                entity.Property(e => e.BankReceiptVoucherLocationId).HasColumnName("Bank_Receipt_Voucher_Location_ID");

                entity.Property(e => e.BankReceiptVoucherNarration)
                    .HasColumnName("Bank_Receipt_Voucher_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BankReceiptVoucherRefNo)
                    .HasColumnName("Bank_Receipt_Voucher_RefNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankReceiptVoucherStatus)
                    .HasColumnName("Bank_Receipt_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankReceiptVoucherUserId).HasColumnName("Bank_Receipt_Voucher_User_ID");

                entity.Property(e => e.BankReceiptVoucherVDate)
                    .HasColumnName("Bank_Receipt_Voucher_V_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankReceiptVoucherVNo).HasColumnName("Bank_Receipt_Voucher_V_NO");
            });

            modelBuilder.Entity<BankReceiptVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Receipt_Voucher_Details");

                entity.Property(e => e.BankReceiptVoucherDetailsAcNo)
                    .HasColumnName("Bank_Receipt_Voucher_Details_AC_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankReceiptVoucherDetailsChequeDate)
                    .HasColumnName("Bank_Receipt_Voucher_Details_Cheque_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankReceiptVoucherDetailsChequeNo).HasColumnName("Bank_Receipt_Voucher_Details_Cheque_No");

                entity.Property(e => e.BankReceiptVoucherDetailsCostCenterId).HasColumnName("Bank_Receipt_Voucher_Details_Cost_Center_ID");

                entity.Property(e => e.BankReceiptVoucherDetailsCrAmount).HasColumnName("Bank_Receipt_Voucher_Details_CR_Amount");

                entity.Property(e => e.BankReceiptVoucherDetailsCrFcAmount).HasColumnName("Bank_Receipt_Voucher_Details_CR_FC_Amount");

                entity.Property(e => e.BankReceiptVoucherDetailsDelStatus).HasColumnName("Bank_Receipt_Voucher_Details_DelStatus");

                entity.Property(e => e.BankReceiptVoucherDetailsDrAmount).HasColumnName("Bank_Receipt_Voucher_Details_DR_Amount");

                entity.Property(e => e.BankReceiptVoucherDetailsDrFcAmount).HasColumnName("Bank_Receipt_Voucher_Details_DR_FC_Amount");

                entity.Property(e => e.BankReceiptVoucherDetailsFsno).HasColumnName("Bank_Receipt_Voucher_Details_FSNO");

                entity.Property(e => e.BankReceiptVoucherDetailsId).HasColumnName("Bank_Receipt_Voucher_Details_ID");

                entity.Property(e => e.BankReceiptVoucherDetailsJ0bNo).HasColumnName("Bank_Receipt_Voucher_Details__J0b_NO");

                entity.Property(e => e.BankReceiptVoucherDetailsNarration)
                    .HasColumnName("Bank_Receipt_Voucher_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankReceiptVoucherDetailsPdc).HasColumnName("Bank_Receipt_Voucher_Details_PDC");

                entity.Property(e => e.BankReceiptVoucherDetailsPdcId).HasColumnName("Bank_Receipt_Voucher_Details_PDC_ID");

                entity.Property(e => e.BankReceiptVoucherDetailsSno).HasColumnName("Bank_Receipt_Voucher_Details_SNO");

                entity.Property(e => e.BankReceiptVoucherDetailsVNo).HasColumnName("Bank_Receipt_Voucher_Details_V_NO");
            });

            modelBuilder.Entity<BatchBarCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Batch_BarCodes");

                entity.Property(e => e.BatchBarCodesBatchCode)
                    .HasColumnName("Batch_BarCodes_Batch_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.BatchBarCodesDelStatus).HasColumnName("Batch_BarCodes_DelStatus");

                entity.Property(e => e.BatchBarCodesExpDate)
                    .HasColumnName("Batch_BarCodes_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BatchBarCodesGenBatchBarcode)
                    .HasColumnName("Batch_BarCodes_GenBatch_Barcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchBarCodesId)
                    .HasColumnName("Batch_BarCodes_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BatchBarCodesItemId).HasColumnName("Batch_BarCodes_Item_ID");

                entity.Property(e => e.BatchBarCodesUnivBarcode)
                    .HasColumnName("Batch_BarCodes_Univ_Barcode")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BatchMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Batch_Master");

                entity.Property(e => e.BatchMasterBatchCode)
                    .HasColumnName("Batch_Master_Batch_Code")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchMasterDelStatus).HasColumnName("Batch_Master_DelStatus");

                entity.Property(e => e.BatchMasterExpiryDate)
                    .HasColumnName("Batch_Master_Expiry_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BatchMasterId)
                    .HasColumnName("Batch_Master_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BatchMasterItemId).HasColumnName("Batch_Master_Item_ID");
            });

            modelBuilder.Entity<BudgetMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Budget_Master");

                entity.Property(e => e.BudgetMasterBudgetDelStatus).HasColumnName("Budget_Master_Budget_DelStatus");

                entity.Property(e => e.BudgetMasterBudgetId).HasColumnName("Budget_Master_Budget_ID");

                entity.Property(e => e.BudgetMasterBudgetName)
                    .HasColumnName("Budget_Master_Budget_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessTypeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Business_Type_Master");

                entity.Property(e => e.BusinessTypeMasterBusinessTypeDelStatus).HasColumnName("Business_Type_Master_Business_Type_DelStatus");

                entity.Property(e => e.BusinessTypeMasterBusinessTypeId).HasColumnName("Business_Type_Master_Business_Type_ID");

                entity.Property(e => e.BusinessTypeMasterBusinessTypeName)
                    .HasColumnName("Business_Type_Master_Business_Type_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTypeMasterBusinessTypeStatus).HasColumnName("Business_Type_Master_Business_Type_Status");
            });

            modelBuilder.Entity<CardDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_Details");

                entity.Property(e => e.CardDetailsBillNo)
                    .HasColumnName("Card_Details_Bill_No")
                    .HasMaxLength(50);

                entity.Property(e => e.CardDetailsCardNo)
                    .HasColumnName("Card_Details_Card_No")
                    .HasMaxLength(50);

                entity.Property(e => e.CardDetailsCardType)
                    .HasColumnName("Card_Details_Card_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardDetailsDelStatus).HasColumnName("Card_Details_DelStatus");

                entity.Property(e => e.CardDetailsId).HasColumnName("Card_Details_ID");
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("City_Master");

                entity.Property(e => e.CityMasterCityCountryId).HasColumnName("City_Master_City_Country_ID");

                entity.Property(e => e.CityMasterCityDelStatus).HasColumnName("City_Master_City_DelStatus");

                entity.Property(e => e.CityMasterCityDeleted).HasColumnName("City_Master_City_Deleted");

                entity.Property(e => e.CityMasterCityId).HasColumnName("City_Master_City_ID");

                entity.Property(e => e.CityMasterCityName)
                    .HasColumnName("City_Master_City_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityMasterCityStatus).HasColumnName("City_Master_City_Status");
            });

            modelBuilder.Entity<CodeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Code_Master");

                entity.Property(e => e.CodeMasterCode).HasColumnName("Code_Master_Code");

                entity.Property(e => e.CodeMasterDelStatus).HasColumnName("Code_Master_DelStatus");

                entity.Property(e => e.CodeMasterDescription)
                    .HasColumnName("Code_Master_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMasterType)
                    .HasColumnName("Code_Master_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMasterTypeDescription)
                    .HasColumnName("Code_Master_Type_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Common_Documents");

                entity.Property(e => e.CommonDocumentsDelStatus).HasColumnName("Common_Documents_DelStatus");

                entity.Property(e => e.CommonDocumentsDocDelStatusB).HasColumnName("Common_Documents_Doc_DelStatus_B");

                entity.Property(e => e.CommonDocumentsDocId).HasColumnName("Common_Documents_Doc_ID");

                entity.Property(e => e.CommonDocumentsDocImage)
                    .HasColumnName("Common_Documents_Doc_Image")
                    .HasColumnType("image");

                entity.Property(e => e.CommonDocumentsDocN).HasColumnName("Common_Documents_Doc_N");

                entity.Property(e => e.CommonDocumentsDocPathV)
                    .HasColumnName("Common_Documents_Doc_Path_V")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommonDocumentsDocRemarksV)
                    .HasColumnName("Common_Documents_Doc_Remarks_V")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CommonDocumentsVouchIdN).HasColumnName("Common_Documents_VouchID_N");

                entity.Property(e => e.CommonDocumentsVoucherTypeV)
                    .HasColumnName("Common_Documents_VoucherType_V")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContraVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contra_Voucher");

                entity.Property(e => e.ContraVoucherAmount).HasColumnName("Contra_Voucher_Amount");

                entity.Property(e => e.ContraVoucherCurrencyId).HasColumnName("Contra_Voucher_Currency_ID");

                entity.Property(e => e.ContraVoucherDate)
                    .HasColumnName("Contra_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContraVoucherDelStatus).HasColumnName("Contra_Voucher_DelStatus");

                entity.Property(e => e.ContraVoucherFsno).HasColumnName("Contra_Voucher_FSNO");

                entity.Property(e => e.ContraVoucherId).HasColumnName("Contra_Voucher_ID");

                entity.Property(e => e.ContraVoucherLocationId).HasColumnName("Contra_Voucher_Location_ID");

                entity.Property(e => e.ContraVoucherNarration)
                    .HasColumnName("Contra_Voucher_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherRefNo)
                    .HasColumnName("Contra_Voucher_RefNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherReference)
                    .HasColumnName("Contra_Voucher_Reference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherSno).HasColumnName("Contra_Voucher_SNO");

                entity.Property(e => e.ContraVoucherStatus)
                    .HasColumnName("Contra_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContraVoucherType)
                    .HasColumnName("Contra_Voucher_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContraVoucherUserId).HasColumnName("Contra_Voucher_User_ID");
            });

            modelBuilder.Entity<ContraVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contra_Voucher_Details");

                entity.Property(e => e.ContraVoucherDetailsAccSno).HasColumnName("Contra_Voucher_Details_AccSNO");

                entity.Property(e => e.ContraVoucherDetailsAccno)
                    .HasColumnName("Contra_Voucher_Details_ACCNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherDetailsAmount).HasColumnName("Contra_Voucher_Details_Amount");

                entity.Property(e => e.ContraVoucherDetailsCostCenterId).HasColumnName("Contra_Voucher_Details_CostCenter_ID");

                entity.Property(e => e.ContraVoucherDetailsDelStatus).HasColumnName("Contra_Voucher_Details_DelStatus");

                entity.Property(e => e.ContraVoucherDetailsDrCr)
                    .HasColumnName("Contra_Voucher_Details_Dr_Cr")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContraVoucherDetailsFcRate).HasColumnName("Contra_Voucher_Details_FC_Rate");

                entity.Property(e => e.ContraVoucherDetailsFsno).HasColumnName("Contra_Voucher_Details_FSNO");

                entity.Property(e => e.ContraVoucherDetailsId).HasColumnName("Contra_Voucher_Details_ID");

                entity.Property(e => e.ContraVoucherDetailsJobId).HasColumnName("Contra_Voucher_Details_Job_ID");

                entity.Property(e => e.ContraVoucherDetailsLocationId).HasColumnName("Contra_Voucher_Details_Location_ID");

                entity.Property(e => e.ContraVoucherDetailsNarration)
                    .HasColumnName("Contra_Voucher_Details_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherDetailsReference)
                    .HasColumnName("Contra_Voucher_Details_Reference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContraVoucherDetailsSno).HasColumnName("Contra_Voucher_Details_SNO");
            });

            modelBuilder.Entity<CostCenterMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cost_Center_Master");

                entity.Property(e => e.CostCenterMasterCostCenterDelStatus).HasColumnName("Cost_Center_Master_Cost_Center_DelStatus");

                entity.Property(e => e.CostCenterMasterCostCenterId).HasColumnName("Cost_Center_Master_Cost_Center_ID");

                entity.Property(e => e.CostCenterMasterCostCenterIsSystem).HasColumnName("Cost_Center_Master_Cost_Center_IsSystem");

                entity.Property(e => e.CostCenterMasterCostCenterName)
                    .HasColumnName("Cost_Center_Master_Cost_Center_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterMasterCostCenterSortOrder).HasColumnName("Cost_Center_Master_Cost_Center_Sort_Order");

                entity.Property(e => e.CostCenterMasterCostCenterStatus).HasColumnName("Cost_Center_Master_Cost_Center_Status");
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Country_Master");

                entity.Property(e => e.CountryMasterCountryAmount).HasColumnName("Country_Master_Country_Amount");

                entity.Property(e => e.CountryMasterCountryDelStatus).HasColumnName("Country_Master_Country_DelStatus");

                entity.Property(e => e.CountryMasterCountryId)
                    .HasColumnName("Country_Master_Country_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryMasterCountryIsdCode)
                    .HasColumnName("Country_Master_Country_ISD_Code")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CountryMasterCountryName)
                    .HasColumnName("Country_Master_Country_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryMasterCountryStatus).HasColumnName("Country_Master_Country_Status");

                entity.Property(e => e.CountryMasterCountryUserId).HasColumnName("Country_Master_Country_User_ID");
            });

            modelBuilder.Entity<CurrencyMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Currency_Master");

                entity.Property(e => e.CurrencyMasterCurrencyDelStatus).HasColumnName("Currency_Master_Currency_DelStatus");

                entity.Property(e => e.CurrencyMasterCurrencyDenomination)
                    .HasColumnName("Currency_Master_Currency_Denomination")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyMasterCurrencyId)
                    .HasColumnName("Currency_Master_Currency_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CurrencyMasterCurrencyName)
                    .HasColumnName("Currency_Master_Currency_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyMasterCurrencyRate).HasColumnName("Currency_Master_Currency_Rate");

                entity.Property(e => e.CurrencyMasterCurrencyRemarks)
                    .HasColumnName("Currency_Master_Currency_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyMasterCurrencyShortName)
                    .HasColumnName("Currency_Master_Currency_Short_Name")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyMasterCurrencyStatus).HasColumnName("Currency_Master_Currency_Status");

                entity.Property(e => e.CurrencyMasterCurrencySymbol)
                    .HasColumnName("Currency_Master_Currency_Symbol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyMasterCurrencyType)
                    .HasColumnName("Currency_Master_Currency_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurrencyMasterCurrencyUserId).HasColumnName("Currency_Master_Currency_User_ID");
            });

            modelBuilder.Entity<CustomerContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Contacts");

                entity.Property(e => e.CustomerContactsActive).HasColumnName("Customer_Contacts_Active");

                entity.Property(e => e.CustomerContactsCustomerId).HasColumnName("Customer_Contacts_Customer_ID");

                entity.Property(e => e.CustomerContactsDelStatus).HasColumnName("Customer_Contacts_DelStatus");

                entity.Property(e => e.CustomerContactsDepartmentId).HasColumnName("Customer_Contacts_Department_ID");

                entity.Property(e => e.CustomerContactsEmail)
                    .HasColumnName("Customer_Contacts_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerContactsId)
                    .HasColumnName("Customer_Contacts_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerContactsMobile)
                    .HasColumnName("Customer_Contacts_Mobile")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerContactsName)
                    .HasColumnName("Customer_Contacts_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerContactsOffice)
                    .HasColumnName("Customer_Contacts_Office")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDeliveryNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Delivery_Note");

                entity.Property(e => e.CustomerDeliveryNoteAttention)
                    .HasColumnName("Customer_Delivery_Note_Attention")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteCpoDate)
                    .HasColumnName("Customer_Delivery_Note_CPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerDeliveryNoteCpoId).HasColumnName("Customer_Delivery_Note_CPO_ID");

                entity.Property(e => e.CustomerDeliveryNoteCurrencyId).HasColumnName("Customer_Delivery_Note_Currency_ID");

                entity.Property(e => e.CustomerDeliveryNoteCustomerCode).HasColumnName("Customer_Delivery_Note_Customer_Code");

                entity.Property(e => e.CustomerDeliveryNoteCustomerName)
                    .HasColumnName("Customer_Delivery_Note_Customer_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteDelDetId).HasColumnName("Customer_Delivery_Note_Del_Det_ID");

                entity.Property(e => e.CustomerDeliveryNoteDelStatus).HasColumnName("Customer_Delivery_Note_DelStatus");

                entity.Property(e => e.CustomerDeliveryNoteDeliveryAddress)
                    .HasColumnName("Customer_Delivery_Note_Delivery_Address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteDeliveryDate)
                    .HasColumnName("Customer_Delivery_Note_Delivery_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerDeliveryNoteDeliveryId).HasColumnName("Customer_Delivery_Note_Delivery_ID");

                entity.Property(e => e.CustomerDeliveryNoteDeliveryStatus)
                    .HasColumnName("Customer_Delivery_Note_Delivery_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteFsno).HasColumnName("Customer_Delivery_Note_FSNO");

                entity.Property(e => e.CustomerDeliveryNoteIssuedStatus).HasColumnName("Customer_Delivery_Note_Issued_Status");

                entity.Property(e => e.CustomerDeliveryNoteLocationId).HasColumnName("Customer_Delivery_Note_Location_ID");

                entity.Property(e => e.CustomerDeliveryNoteManuelPo).HasColumnName("Customer_Delivery_Note_Manuel_PO");

                entity.Property(e => e.CustomerDeliveryNoteNote)
                    .HasColumnName("Customer_Delivery_Note_Note")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNotePacking)
                    .HasColumnName("Customer_Delivery_Note_Packing")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNotePodId).HasColumnName("Customer_Delivery_Note_POD_ID");

                entity.Property(e => e.CustomerDeliveryNoteQuality)
                    .HasColumnName("Customer_Delivery_Note_Quality")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteRemarks)
                    .HasColumnName("Customer_Delivery_Note_Remarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteSalesManId).HasColumnName("Customer_Delivery_Note_Sales_Man_ID");

                entity.Property(e => e.CustomerDeliveryNoteTechnicalDetails)
                    .HasColumnName("Customer_Delivery_Note_Technical_Details")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteTerms)
                    .HasColumnName("Customer_Delivery_Note_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteTraining)
                    .HasColumnName("Customer_Delivery_Note_Training")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteUserId).HasColumnName("Customer_Delivery_Note_User_ID");

                entity.Property(e => e.CustomerDeliveryNoteWarranty)
                    .HasColumnName("Customer_Delivery_Note_Warranty")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDeliveryNoteDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Delivery_Note_Details");

                entity.Property(e => e.CustomerDeliveryNoteDetailsBaseValue).HasColumnName("Customer_Delivery_Note_Details_Base_Value");

                entity.Property(e => e.CustomerDeliveryNoteDetailsCpoSlno).HasColumnName("Customer_Delivery_Note_Details_CPO_Slno");

                entity.Property(e => e.CustomerDeliveryNoteDetailsCustomerPoNo).HasColumnName("Customer_Delivery_Note_Details_Customer_PO_NO");

                entity.Property(e => e.CustomerDeliveryNoteDetailsDelStatus).HasColumnName("Customer_Delivery_Note_Details_DelStatus");

                entity.Property(e => e.CustomerDeliveryNoteDetailsDeliveryDetailId)
                    .HasColumnName("Customer_Delivery_Note_Details_Delivery_Detail_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerDeliveryNoteDetailsDeliveryNo).HasColumnName("Customer_Delivery_Note_Details_Delivery_NO");

                entity.Property(e => e.CustomerDeliveryNoteDetailsDescription)
                    .HasColumnName("Customer_Delivery_Note_Details_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDeliveryNoteDetailsFoc).HasColumnName("Customer_Delivery_Note_Details_FOC");

                entity.Property(e => e.CustomerDeliveryNoteDetailsFsno).HasColumnName("Customer_Delivery_Note_Details_FSNO");

                entity.Property(e => e.CustomerDeliveryNoteDetailsIsEdited).HasColumnName("Customer_Delivery_Note_Details_IsEdited");

                entity.Property(e => e.CustomerDeliveryNoteDetailsItemId).HasColumnName("Customer_Delivery_Note_Details_Item_ID");

                entity.Property(e => e.CustomerDeliveryNoteDetailsMatId2).HasColumnName("Customer_Delivery_Note_Details_Mat_ID2");

                entity.Property(e => e.CustomerDeliveryNoteDetailsPodId).HasColumnName("Customer_Delivery_Note_Details_POD_ID");

                entity.Property(e => e.CustomerDeliveryNoteDetailsQty)
                    .HasColumnName("Customer_Delivery_Note_Details_QTY")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerDeliveryNoteDetailsSlno).HasColumnName("Customer_Delivery_Note_Details_Slno");

                entity.Property(e => e.CustomerDeliveryNoteDetailsUnitId).HasColumnName("Customer_Delivery_Note_Details_Unit_ID");

                entity.Property(e => e.CustomerDeliveryNoteDetailsUnitId2).HasColumnName("Customer_Delivery_Note_Details_Unit_ID2");
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Master");

                entity.Property(e => e.CustomerMasterCustomerArabicName)
                    .HasColumnName("Customer_Master_Customer_Arabic_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerMasterCustomerBlackList).HasColumnName("Customer_Master_Customer_Black_List");

                entity.Property(e => e.CustomerMasterCustomerCityId).HasColumnName("Customer_Master_Customer_City_ID");

                entity.Property(e => e.CustomerMasterCustomerContactPerson)
                    .HasColumnName("Customer_Master_Customer_Contact_Person")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerContactPerson2)
                    .HasColumnName("Customer_Master_Customer_Contact_Person2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerContactPerson3)
                    .HasColumnName("Customer_Master_Customer_Contact_Person3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerCountryId).HasColumnName("Customer_Master_Customer_Country_ID");

                entity.Property(e => e.CustomerMasterCustomerCreateAccount).HasColumnName("Customer_Master_Customer_Create_Account");

                entity.Property(e => e.CustomerMasterCustomerCreditDays).HasColumnName("Customer_Master_Customer_Credit_Days");

                entity.Property(e => e.CustomerMasterCustomerCreditLimit).HasColumnName("Customer_Master_Customer_Credit_Limit");

                entity.Property(e => e.CustomerMasterCustomerCtTypeId).HasColumnName("Customer_Master_Customer_CT_Type_ID");

                entity.Property(e => e.CustomerMasterCustomerCurrencyId).HasColumnName("Customer_Master_Customer_Currency_ID");

                entity.Property(e => e.CustomerMasterCustomerCustType)
                    .HasColumnName("Customer_Master_Customer_Cust_Type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerDelStatus).HasColumnName("Customer_Master_Customer_DelStatus");

                entity.Property(e => e.CustomerMasterCustomerDeleteStatus).HasColumnName("Customer_Master_Customer_Delete_Status");

                entity.Property(e => e.CustomerMasterCustomerEarnPoints).HasColumnName("Customer_Master_Customer_Earn_Points");

                entity.Property(e => e.CustomerMasterCustomerEmail)
                    .HasColumnName("Customer_Master_Customer_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerFax)
                    .HasColumnName("Customer_Master_Customer_Fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerGroupAccNo)
                    .HasColumnName("Customer_Master_Customer_Group_ACC_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerJoinDate)
                    .HasColumnName("Customer_Master_Customer_Join_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerMasterCustomerLocation)
                    .HasColumnName("Customer_Master_Customer_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerLoyaltyId).HasColumnName("Customer_Master_Customer_Loyalty_ID");

                entity.Property(e => e.CustomerMasterCustomerMobile)
                    .HasColumnName("Customer_Master_Customer_Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerName)
                    .HasColumnName("Customer_Master_Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerNo)
                    .HasColumnName("Customer_Master_Customer_No")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerMasterCustomerPoBox)
                    .HasColumnName("Customer_Master_Customer_PO_BOX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerPriceLevel)
                    .HasColumnName("Customer_Master_Customer_Price_Level")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerPriceLevelId).HasColumnName("Customer_Master_Customer_Price_Level_ID");

                entity.Property(e => e.CustomerMasterCustomerRedeemEarnPoints).HasColumnName("Customer_Master_Customer_Redeem_Earn_Points");

                entity.Property(e => e.CustomerMasterCustomerReffAcNo)
                    .HasColumnName("Customer_Master_Customer_Reff_AC_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerRemarks)
                    .HasColumnName("Customer_Master_Customer_Remarks")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerStatus).HasColumnName("Customer_Master_Customer_Status");

                entity.Property(e => e.CustomerMasterCustomerStatusValue).HasColumnName("Customer_Master_Customer_Status_Value");

                entity.Property(e => e.CustomerMasterCustomerTel1)
                    .HasColumnName("Customer_Master_Customer_Tel1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerTel2)
                    .HasColumnName("Customer_Master_Customer_Tel2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerTitle)
                    .HasColumnName("Customer_Master_Customer_Title")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CustomerMasterCustomerTotalPoints).HasColumnName("Customer_Master_Customer_Total_Points");

                entity.Property(e => e.CustomerMasterCustomerTotalValue).HasColumnName("Customer_Master_Customer_Total_Value");

                entity.Property(e => e.CustomerMasterCustomerType)
                    .HasColumnName("Customer_Master_Customer_Type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerMasterCustomerUserId).HasColumnName("Customer_Master_Customer_User_ID");

                entity.Property(e => e.CustomerMasterCustomerVatNo)
                    .HasColumnName("Customer_Master_Customer_VAT_No")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterCustomerWebSite)
                    .HasColumnName("Customer_Master_Customer_Web_Site")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Order");

                entity.Property(e => e.CustomerOrderCurrencyId).HasColumnName("Customer_Order_Currency_ID");

                entity.Property(e => e.CustomerOrderCustomerId).HasColumnName("Customer_Order_Customer_ID");

                entity.Property(e => e.CustomerOrderDate)
                    .HasColumnName("Customer_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerOrderDelStatus).HasColumnName("Customer_Order_DelStatus");

                entity.Property(e => e.CustomerOrderDescription)
                    .HasColumnName("Customer_Order_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderDiscount).HasColumnName("Customer_Order_Discount");

                entity.Property(e => e.CustomerOrderDiscountPercentage).HasColumnName("Customer_Order_Discount_Percentage");

                entity.Property(e => e.CustomerOrderFsno).HasColumnName("Customer_Order_FSNO");

                entity.Property(e => e.CustomerOrderId).HasColumnName("Customer_Order_ID");

                entity.Property(e => e.CustomerOrderLocationId).HasColumnName("Customer_Order_Location_ID");

                entity.Property(e => e.CustomerOrderLpoDate)
                    .HasColumnName("Customer_Order_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerOrderLpoNo)
                    .HasColumnName("Customer_Order_LPO_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNetAmount).HasColumnName("Customer_Order_NetAmount");

                entity.Property(e => e.CustomerOrderNo)
                    .HasColumnName("Customer_Order_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderStatus)
                    .HasColumnName("Customer_Order_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderTermsAndConditions)
                    .HasColumnName("Customer_Order_TermsAndConditions")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderTotalAmount).HasColumnName("Customer_Order_Total_Amount");

                entity.Property(e => e.CustomerOrderUserId).HasColumnName("Customer_Order_User_ID");
            });

            modelBuilder.Entity<CustomerOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Order_Details");

                entity.Property(e => e.CustomerOrderDetailsAmount).HasColumnName("Customer_Order_Details_Amount");

                entity.Property(e => e.CustomerOrderDetailsDelStatus).HasColumnName("Customer_Order_Details_DelStatus");

                entity.Property(e => e.CustomerOrderDetailsDescription)
                    .HasColumnName("Customer_Order_Details_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderDetailsFcAmount).HasColumnName("Customer_Order_Details_FC_Amount");

                entity.Property(e => e.CustomerOrderDetailsId).HasColumnName("Customer_Order_Details_ID");

                entity.Property(e => e.CustomerOrderDetailsMaterialDescription)
                    .HasColumnName("Customer_Order_Details_Material_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderDetailsMaterialId).HasColumnName("Customer_Order_Details_Material_ID");

                entity.Property(e => e.CustomerOrderDetailsQuantity).HasColumnName("Customer_Order_Details_Quantity");

                entity.Property(e => e.CustomerOrderDetailsRate).HasColumnName("Customer_Order_Details_Rate");

                entity.Property(e => e.CustomerOrderDetailsSno).HasColumnName("Customer_Order_Details_SNO");

                entity.Property(e => e.CustomerOrderDetailsUnitId).HasColumnName("Customer_Order_Details_Unit_ID");
            });

            modelBuilder.Entity<CustomerOrderRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Order_Register");

                entity.Property(e => e.CustomerOrderRegisterAmount).HasColumnName("Customer_Order_Register_Amount");

                entity.Property(e => e.CustomerOrderRegisterAssignedDate).HasColumnName("Customer_Order_Register_Assigned_Date");

                entity.Property(e => e.CustomerOrderRegisterCustomerId).HasColumnName("Customer_Order_Register_Customer_ID");

                entity.Property(e => e.CustomerOrderRegisterDelStatus).HasColumnName("Customer_Order_Register_DelStatus");

                entity.Property(e => e.CustomerOrderRegisterFcAmount).HasColumnName("Customer_Order_Register_FC_Amount");

                entity.Property(e => e.CustomerOrderRegisterFsno).HasColumnName("Customer_Order_Register_FSNO");

                entity.Property(e => e.CustomerOrderRegisterId).HasColumnName("Customer_Order_Register_ID");

                entity.Property(e => e.CustomerOrderRegisterLocationId).HasColumnName("Customer_Order_Register_Location_ID");

                entity.Property(e => e.CustomerOrderRegisterMaterialId).HasColumnName("Customer_Order_Register_Material_ID");

                entity.Property(e => e.CustomerOrderRegisterOrderNo).HasColumnName("Customer_Order_Register_Order_No");

                entity.Property(e => e.CustomerOrderRegisterQtyIssued).HasColumnName("Customer_Order_Register_QTY_Issued");

                entity.Property(e => e.CustomerOrderRegisterQtyOrder).HasColumnName("Customer_Order_Register_QTY_Order");

                entity.Property(e => e.CustomerOrderRegisterRate).HasColumnName("Customer_Order_Register_Rate");

                entity.Property(e => e.CustomerOrderRegisterRefVoucherNo).HasColumnName("Customer_Order_Register_Ref_Voucher_No");

                entity.Property(e => e.CustomerOrderRegisterStatus)
                    .HasColumnName("Customer_Order_Register_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderRegisterTransType).HasColumnName("Customer_Order_Register_Trans_Type");

                entity.Property(e => e.CustomerOrderRegisterUnitId).HasColumnName("Customer_Order_Register_Unit_ID");
            });

            modelBuilder.Entity<CustomerPurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Purchase_Order");

                entity.Property(e => e.CustomerPurchaseOrderCpoAboutId).HasColumnName("Customer_Purchase_Order_CPO_About_ID");

                entity.Property(e => e.CustomerPurchaseOrderCpoDate)
                    .HasColumnName("Customer_Purchase_Order_CPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerPurchaseOrderCpoDeliveryTimeDate)
                    .HasColumnName("Customer_Purchase_Order_CPO_DeliveryTime_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerPurchaseOrderCpoId).HasColumnName("Customer_Purchase_Order_CPO_ID");

                entity.Property(e => e.CustomerPurchaseOrderCpoTermsV)
                    .HasColumnName("Customer_Purchase_Order_CPO_Terms_V")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderCurrencyId).HasColumnName("Customer_Purchase_Order_Currency_ID");

                entity.Property(e => e.CustomerPurchaseOrderCustomerCode)
                    .HasColumnName("Customer_Purchase_Order_Customer_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderCustomerName)
                    .HasColumnName("Customer_Purchase_Order_Customer_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderDelStatus).HasColumnName("Customer_Purchase_Order_DelStatus");

                entity.Property(e => e.CustomerPurchaseOrderDiscountAmount).HasColumnName("Customer_Purchase_Order_Discount_Amount");

                entity.Property(e => e.CustomerPurchaseOrderDiscountPercentage).HasColumnName("Customer_Purchase_Order_Discount_Percentage");

                entity.Property(e => e.CustomerPurchaseOrderFsno).HasColumnName("Customer_Purchase_Order_FSNO");

                entity.Property(e => e.CustomerPurchaseOrderGrandTotal).HasColumnName("Customer_Purchase_Order_Grand_Total");

                entity.Property(e => e.CustomerPurchaseOrderIslocalPurchase).HasColumnName("Customer_Purchase_Order_ISLocal_Purchase");

                entity.Property(e => e.CustomerPurchaseOrderJobId).HasColumnName("Customer_Purchase_Order_Job_ID");

                entity.Property(e => e.CustomerPurchaseOrderLocationId).HasColumnName("Customer_Purchase_Order_Location_ID");

                entity.Property(e => e.CustomerPurchaseOrderLpoDate)
                    .HasColumnName("Customer_Purchase_Order_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerPurchaseOrderLpoNo)
                    .HasColumnName("Customer_Purchase_Order_LPO_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderNote)
                    .HasColumnName("Customer_Purchase_Order_Note")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderPacking)
                    .HasColumnName("Customer_Purchase_Order_Packing")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderPoEnquiryIdN).HasColumnName("Customer_Purchase_Order_PO_Enquiry_ID_N");

                entity.Property(e => e.CustomerPurchaseOrderPoQuotationIdN).HasColumnName("Customer_Purchase_Order_PO_Quotation_ID_N");

                entity.Property(e => e.CustomerPurchaseOrderQuantity)
                    .HasColumnName("Customer_Purchase_Order_Quantity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderQuotationId)
                    .HasColumnName("Customer_Purchase_Order_Quotation_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderRemarks)
                    .HasColumnName("Customer_Purchase_Order_Remarks")
                    .HasColumnType("text");

                entity.Property(e => e.CustomerPurchaseOrderSalesManId).HasColumnName("Customer_Purchase_Order_Sales_Man_ID");

                entity.Property(e => e.CustomerPurchaseOrderSubject)
                    .HasColumnName("Customer_Purchase_Order_Subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderTechnicalDetails)
                    .HasColumnName("Customer_Purchase_Order_Technical_Details")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderTerms)
                    .HasColumnName("Customer_Purchase_Order_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderTotal).HasColumnName("Customer_Purchase_Order_Total");

                entity.Property(e => e.CustomerPurchaseOrderTraining)
                    .HasColumnName("Customer_Purchase_Order_Training")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderUserId).HasColumnName("Customer_Purchase_Order_User_ID");

                entity.Property(e => e.CustomerPurchaseOrderWarranty)
                    .HasColumnName("Customer_Purchase_Order_Warranty")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerPurchaseOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Purchase_Order_Details");

                entity.Property(e => e.CustomerPurchaseOrderDetailsAmount)
                    .HasColumnName("Customer_Purchase_Order_Details_Amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPurchaseOrderDetailsCpoId).HasColumnName("Customer_Purchase_Order_Details_CPO_ID");

                entity.Property(e => e.CustomerPurchaseOrderDetailsDelStatus).HasColumnName("Customer_Purchase_Order_Details_DelStatus");

                entity.Property(e => e.CustomerPurchaseOrderDetailsDeliverdQty)
                    .HasColumnName("Customer_Purchase_Order_Details_Deliverd_Qty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPurchaseOrderDetailsDescription)
                    .HasColumnName("Customer_Purchase_Order_Details_Description")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderDetailsFcAmount)
                    .HasColumnName("Customer_Purchase_Order_Details_FC_Amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPurchaseOrderDetailsFocQty)
                    .HasColumnName("Customer_Purchase_Order_Details_FOC_Qty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPurchaseOrderDetailsFsno).HasColumnName("Customer_Purchase_Order_Details_FSNO");

                entity.Property(e => e.CustomerPurchaseOrderDetailsIsEdited).HasColumnName("Customer_Purchase_Order_Details_IsEdited");

                entity.Property(e => e.CustomerPurchaseOrderDetailsItemId).HasColumnName("Customer_Purchase_Order_Details_Item_ID");

                entity.Property(e => e.CustomerPurchaseOrderDetailsPodId).HasColumnName("Customer_Purchase_Order_Details_POD_ID");

                entity.Property(e => e.CustomerPurchaseOrderDetailsPodId2).HasColumnName("Customer_Purchase_Order_Details_POD_ID2");

                entity.Property(e => e.CustomerPurchaseOrderDetailsQty)
                    .HasColumnName("Customer_Purchase_Order_Details_Qty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPurchaseOrderDetailsQuotationDetailsId).HasColumnName("Customer_Purchase_Order_Details_Quotation_Details_ID");

                entity.Property(e => e.CustomerPurchaseOrderDetailsRemarks)
                    .HasColumnName("Customer_Purchase_Order_Details_Remarks")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderDetailsSlno).HasColumnName("Customer_Purchase_Order_Details_SLNo");

                entity.Property(e => e.CustomerPurchaseOrderDetailsUnitId).HasColumnName("Customer_Purchase_Order_Details_Unit_ID");

                entity.Property(e => e.CustomerPurchaseOrderDetailsUnitPrice)
                    .HasColumnName("Customer_Purchase_Order_Details_Unit_Price")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CustomerQuotation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Quotation");

                entity.Property(e => e.CustomerQuotationCashCustomerName)
                    .HasColumnName("Customer_Quotation_Cash_Customer_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationContactPersonV)
                    .HasColumnName("Customer_Quotation_Contact_Person_V")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerQuotationCurrencyId).HasColumnName("Customer_Quotation_Currency_ID");

                entity.Property(e => e.CustomerQuotationCustomerId).HasColumnName("Customer_Quotation_Customer_ID");

                entity.Property(e => e.CustomerQuotationDelStatus).HasColumnName("Customer_Quotation_DelStatus");

                entity.Property(e => e.CustomerQuotationDeliveryTimeDate)
                    .HasColumnName("Customer_Quotation_Delivery_Time_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerQuotationDiscountAmount)
                    .HasColumnName("Customer_Quotation_Discount_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CustomerQuotationDiscountAmountTotal)
                    .HasColumnName("Customer_Quotation_Discount_Amount_Total")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CustomerQuotationDiscountPercentage)
                    .HasColumnName("Customer_Quotation_Discount_Percentage")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CustomerQuotationEnquiryId).HasColumnName("Customer_Quotation_Enquiry_ID");

                entity.Property(e => e.CustomerQuotationEnquiryNo)
                    .HasColumnName("Customer_Quotation_Enquiry_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationFooter)
                    .HasColumnName("Customer_Quotation_Footer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationFsno).HasColumnName("Customer_Quotation_FSNO");

                entity.Property(e => e.CustomerQuotationGrossTotal)
                    .HasColumnName("Customer_Quotation_Gross_Total")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CustomerQuotationHeader)
                    .HasColumnName("Customer_Quotation_Header")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationIsClose).HasColumnName("Customer_Quotation_IsClose");

                entity.Property(e => e.CustomerQuotationLocationId).HasColumnName("Customer_Quotation_Location_ID");

                entity.Property(e => e.CustomerQuotationModelId).HasColumnName("Customer_Quotation_Model_ID");

                entity.Property(e => e.CustomerQuotationNetTotal)
                    .HasColumnName("Customer_Quotation_Net_Total")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CustomerQuotationNote)
                    .HasColumnName("Customer_Quotation_Note")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationPacking)
                    .HasColumnName("Customer_Quotation_Packing")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationQid).HasColumnName("Customer_Quotation_QID");

                entity.Property(e => e.CustomerQuotationQuality)
                    .HasColumnName("Customer_Quotation_Quality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationQuotationAddition).HasColumnName("Customer_Quotation_Quotation_Addition");

                entity.Property(e => e.CustomerQuotationQuotationDate)
                    .HasColumnName("Customer_Quotation_Quotation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerQuotationQuotationEnquiryN).HasColumnName("Customer_Quotation_Quotation_Enquiry_N");

                entity.Property(e => e.CustomerQuotationQuotationId)
                    .HasColumnName("Customer_Quotation_Quotation_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationQuotationRoot).HasColumnName("Customer_Quotation_Quotation_Root");

                entity.Property(e => e.CustomerQuotationQuotationStatusId).HasColumnName("Customer_Quotation_Quotation_Status_ID");

                entity.Property(e => e.CustomerQuotationRemarks)
                    .HasColumnName("Customer_Quotation_Remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationSalesManId).HasColumnName("Customer_Quotation_Sales_Man_ID");

                entity.Property(e => e.CustomerQuotationSubject)
                    .HasColumnName("Customer_Quotation_Subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationTechnicalDetails)
                    .HasColumnName("Customer_Quotation_Technical_Details")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationTerms)
                    .HasColumnName("Customer_Quotation_Terms")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationTraining)
                    .HasColumnName("Customer_Quotation_Training")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationTypeId).HasColumnName("Customer_Quotation_Type_ID");

                entity.Property(e => e.CustomerQuotationVatAmount)
                    .HasColumnName("Customer_Quotation_VAT_Amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationVatPercentage)
                    .HasColumnName("Customer_Quotation_VAT_Percentage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationVendorId).HasColumnName("Customer_Quotation_Vendor_ID");

                entity.Property(e => e.CustomerQuotationVoucherType)
                    .HasColumnName("Customer_Quotation_Voucher_Type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationWarranty)
                    .HasColumnName("Customer_Quotation_Warranty")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerQuotationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Quotation_Details");

                entity.Property(e => e.CustomerQuotationDetailsCashCustomerName)
                    .HasColumnName("Customer_Quotation_Details_Cash_Customer_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationDetailsDelStatus).HasColumnName("Customer_Quotation_Details_DelStatus");

                entity.Property(e => e.CustomerQuotationDetailsDescription)
                    .HasColumnName("Customer_Quotation_Details_Description")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationDetailsDiscount)
                    .HasColumnName("Customer_Quotation_Details_Discount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationDetailsEnquiryDetailsId).HasColumnName("Customer_Quotation_Details_Enquiry_Details_ID");

                entity.Property(e => e.CustomerQuotationDetailsFsno).HasColumnName("Customer_Quotation_Details_FSNO");

                entity.Property(e => e.CustomerQuotationDetailsGrossAmount)
                    .HasColumnName("Customer_Quotation_Details_Gross_Amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationDetailsId).HasColumnName("Customer_Quotation_Details_ID");

                entity.Property(e => e.CustomerQuotationDetailsIsEdited).HasColumnName("Customer_Quotation_Details_IsEdited");

                entity.Property(e => e.CustomerQuotationDetailsItemId).HasColumnName("Customer_Quotation_Details_Item_ID");

                entity.Property(e => e.CustomerQuotationDetailsNetAmount)
                    .HasColumnName("Customer_Quotation_Details_Net_Amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationDetailsPriceType)
                    .HasColumnName("Customer_Quotation_Details_Price_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationDetailsPurchasePrice).HasColumnName("Customer_Quotation_Details_Purchase_Price");

                entity.Property(e => e.CustomerQuotationDetailsQty)
                    .HasColumnName("Customer_Quotation_Details_Qty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationDetailsQuotationDetailsId).HasColumnName("Customer_Quotation_Details_Quotation_Details_ID");

                entity.Property(e => e.CustomerQuotationDetailsQuotationId)
                    .HasColumnName("Customer_Quotation_Details_Quotation_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuotationDetailsSlno).HasColumnName("Customer_Quotation_Details_Slno");

                entity.Property(e => e.CustomerQuotationDetailsUnitId).HasColumnName("Customer_Quotation_Details_Unit_ID");

                entity.Property(e => e.CustomerQuotationDetailsUnitPrice)
                    .HasColumnName("Customer_Quotation_Details_Unit_Price")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerQuotationDetailsVoucherType)
                    .HasColumnName("Customer_Quotation_Details_Voucher_Type")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CutomerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cutomer_Type");

                entity.Property(e => e.CustomerTypeDelStatus).HasColumnName("Customer_Type_DelStatus");

                entity.Property(e => e.CustomerTypeDeleted).HasColumnName("Customer_Type_Deleted");

                entity.Property(e => e.CustomerTypeId).HasColumnName("Customer_type_ID");

                entity.Property(e => e.CustomerTypeName)
                    .HasColumnName("Customer_Type_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeStatus).HasColumnName("Customer_Type_Status");

                entity.Property(e => e.CustomerTypeUserId).HasColumnName("Customer_Type_User_ID");
            });

            modelBuilder.Entity<DamageDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Damage_Details");

                entity.Property(e => e.DamageDetailsAmount).HasColumnName("Damage_Details_Amount");

                entity.Property(e => e.DamageDetailsDelStatus).HasColumnName("Damage_Details_DelStatus");

                entity.Property(e => e.DamageDetailsId).HasColumnName("Damage_Details_ID");

                entity.Property(e => e.DamageDetailsMaterialId).HasColumnName("Damage_Details_Material_ID");

                entity.Property(e => e.DamageDetailsPrice).HasColumnName("Damage_Details_Price");

                entity.Property(e => e.DamageDetailsQty).HasColumnName("Damage_Details_QTY");

                entity.Property(e => e.DamageDetailsRemarks)
                    .HasColumnName("Damage_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DamageDetailsSno).HasColumnName("Damage_Details_SNO");

                entity.Property(e => e.DamageDetailsUnitId).HasColumnName("Damage_Details_Unit_ID");
            });

            modelBuilder.Entity<DamageMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Damage_Master");

                entity.Property(e => e.DamageMasterDelStatus).HasColumnName("Damage_Master_DelStatus");

                entity.Property(e => e.DamageMasterId).HasColumnName("Damage_Master_ID");

                entity.Property(e => e.DamageMasterLocationId).HasColumnName("Damage_Master_Location_ID");

                entity.Property(e => e.DamageMasterNarration)
                    .HasColumnName("Damage_Master_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DamageMasterVdate)
                    .HasColumnName("Damage_Master_Vdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DeliveryOrderVoucherBatchDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Delivery_Order_Voucher_Batch_Details");

                entity.Property(e => e.DovBatchCode)
                    .HasColumnName("DOV_Batch_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DovCompanyId).HasColumnName("DOV_Company_ID");

                entity.Property(e => e.DovCostPrice).HasColumnName("DOV_Cost_Price");

                entity.Property(e => e.DovDelStatus).HasColumnName("DOV_DelStatus");

                entity.Property(e => e.DovDeliveryDetialsId).HasColumnName("DOV_Delivery_Detials_ID");

                entity.Property(e => e.DovDeliveryId).HasColumnName("DOV_Delivery_ID");

                entity.Property(e => e.DovDeliveryNoteId).HasColumnName("DOV_Delivery_Note_ID");

                entity.Property(e => e.DovDescription)
                    .HasColumnName("DOV_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DovDiscount).HasColumnName("DOV_Discount");

                entity.Property(e => e.DovExpDate)
                    .HasColumnName("DOV_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DovFocqty).HasColumnName("DOV_FOCQty");

                entity.Property(e => e.DovFsno).HasColumnName("DOV_FSNO");

                entity.Property(e => e.DovGrossAmount).HasColumnName("DOV_Gross_Amount");

                entity.Property(e => e.DovItemId).HasColumnName("DOV_Item_ID");

                entity.Property(e => e.DovLocationId).HasColumnName("DOV_Location_ID");

                entity.Property(e => e.DovNetAmount).HasColumnName("DOV_Net_Amount");

                entity.Property(e => e.DovPodId).HasColumnName("DOV_POD_ID");

                entity.Property(e => e.DovSno).HasColumnName("DOV_SNO");

                entity.Property(e => e.DovSoldQty).HasColumnName("DOV_Sold_QTY");

                entity.Property(e => e.DovUnitId).HasColumnName("DOV_Unit_ID");

                entity.Property(e => e.DovUnitPrice).HasColumnName("DOV_Unit_Price");

                entity.Property(e => e.DovVat).HasColumnName("DOV_VAT");

                entity.Property(e => e.DovVoucherNo)
                    .HasColumnName("DOV_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department_Master");

                entity.Property(e => e.DepartmentMasterDepartmentDelStatus).HasColumnName("Department_Master_Department_DelStatus");

                entity.Property(e => e.DepartmentMasterDepartmentDeleted).HasColumnName("Department_Master_Department_Deleted");

                entity.Property(e => e.DepartmentMasterDepartmentId).HasColumnName("Department_Master_Department_ID");

                entity.Property(e => e.DepartmentMasterDepartmentName)
                    .HasColumnName("Department_Master_Department_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentMasterDepartmentStatus).HasColumnName("Department_Master_Department_Status");
            });

            modelBuilder.Entity<DocumentImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Document_Images");

                entity.Property(e => e.DocumentImageDelStatus).HasColumnName("Document_Image_DelStatus");

                entity.Property(e => e.DocumentImageDocumentId).HasColumnName("Document_Image_Document_ID");

                entity.Property(e => e.DocumentImageExtension)
                    .HasColumnName("Document_Image_Extension")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentImageId).HasColumnName("Document_Image_ID");

                entity.Property(e => e.DocumentImageImage)
                    .HasColumnName("Document_Image_Image")
                    .HasColumnType("image");

                entity.Property(e => e.DocumentImageName)
                    .HasColumnName("Document_Image_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentImageVoucherType)
                    .HasColumnName("Document_Image_Voucher_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DriverMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Master");

                entity.Property(e => e.DriverMasterCode)
                    .HasColumnName("Driver_Master_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterDelStatus).HasColumnName("Driver_Master_DelStatus");

                entity.Property(e => e.DriverMasterId).HasColumnName("Driver_Master_ID");

                entity.Property(e => e.DriverMasterMobile1)
                    .HasColumnName("Driver_Master_Mobile1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterMobile2)
                    .HasColumnName("Driver_Master_Mobile2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterMobile3)
                    .HasColumnName("Driver_Master_Mobile3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterMobile4)
                    .HasColumnName("Driver_Master_Mobile4")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterMobile5)
                    .HasColumnName("Driver_Master_Mobile5")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterMobile6)
                    .HasColumnName("Driver_Master_Mobile6")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMasterName)
                    .HasColumnName("Driver_Master_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnquiryDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Enquiry_Details");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsDelStatus).HasColumnName("Enquiry_Details_Enquiry_Details_DelStatus");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsDescription)
                    .HasColumnName("Enquiry_Details_Enquiry_Details_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsEquiryId).HasColumnName("Enquiry_Details_Enquiry_Details_Equiry_ID");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsId).HasColumnName("Enquiry_Details_Enquiry_Details_ID");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsIsEdited).HasColumnName("Enquiry_Details_Enquiry_Details_IsEdited");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsItemId).HasColumnName("Enquiry_Details_Enquiry_Details_Item_ID");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsMaterialDescription)
                    .HasColumnName("Enquiry_Details_Enquiry_Details_Material_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsQty).HasColumnName("Enquiry_Details_Enquiry_Details_QTY");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsSlno).HasColumnName("Enquiry_Details_Enquiry_Details_SLNO");

                entity.Property(e => e.EnquiryDetailsEnquiryDetailsUnitId).HasColumnName("Enquiry_Details_Enquiry_Details_Unit_ID");
            });

            modelBuilder.Entity<EnquiryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Enquiry_Master");

                entity.Property(e => e.EnquiryMasterBuilder)
                    .HasColumnName("Enquiry_Master_Builder")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterBusineeTypeId).HasColumnName("Enquiry_Master_Businee_Type_ID");

                entity.Property(e => e.EnquiryMasterConsultingEngineer)
                    .HasColumnName("Enquiry_Master_Consulting_Engineer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterContactEmail)
                    .HasColumnName("Enquiry_Master_Contact_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterContactId).HasColumnName("Enquiry_Master_Contact_ID");

                entity.Property(e => e.EnquiryMasterContactName)
                    .HasColumnName("Enquiry_Master_Contact_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterCurrencyId).HasColumnName("Enquiry_Master_Currency_ID");

                entity.Property(e => e.EnquiryMasterCustomerReference)
                    .HasColumnName("Enquiry_Master_Customer_Reference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterDelStatus).HasColumnName("Enquiry_Master_DelStatus");

                entity.Property(e => e.EnquiryMasterEnquiryAboutId).HasColumnName("Enquiry_Master_Enquiry_About_ID");

                entity.Property(e => e.EnquiryMasterEnquiryDate)
                    .HasColumnName("Enquiry_Master_Enquiry_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnquiryMasterEnquiryId).HasColumnName("Enquiry_Master_Enquiry_ID");

                entity.Property(e => e.EnquiryMasterEnquiryStatusId).HasColumnName("Enquiry_Master_Enquiry_Status_ID");

                entity.Property(e => e.EnquiryMasterEnquiryVoucherNo).HasColumnName("Enquiry_Master_Enquiry_Voucher_No");

                entity.Property(e => e.EnquiryMasterJobNo).HasColumnName("Enquiry_Master_Job_No");

                entity.Property(e => e.EnquiryMasterLocationId).HasColumnName("Enquiry_Master_Location_ID");

                entity.Property(e => e.EnquiryMasterModelId).HasColumnName("Enquiry_Master_Model_ID");

                entity.Property(e => e.EnquiryMasterRemarks)
                    .HasColumnName("Enquiry_Master_Remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterSalesManId).HasColumnName("Enquiry_Master_Sales_Man_ID");

                entity.Property(e => e.EnquiryMasterSerialNo)
                    .HasColumnName("Enquiry_Master_Serial_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryMasterTypeId).HasColumnName("Enquiry_Master_Type_ID");

                entity.Property(e => e.EnquiryMasterVendorId).HasColumnName("Enquiry_Master_Vendor_ID");

                entity.Property(e => e.EnquiryMasterVesselId).HasColumnName("Enquiry_Master_Vessel_ID");
            });

            modelBuilder.Entity<EnquiryStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Enquiry_Status");

                entity.Property(e => e.EnquiryStatusEnquiryStatus)
                    .HasColumnName("Enquiry_Status_Enquiry_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryStatusEnquiryStatusDelStatus).HasColumnName("Enquiry_Status_Enquiry_Status_DelStatus");

                entity.Property(e => e.EnquiryStatusEnquiryStatusId).HasColumnName("Enquiry_Status_Enquiry_Status_ID");
            });

            modelBuilder.Entity<EqnuiryAbout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Eqnuiry_About");

                entity.Property(e => e.EqnuiryAboutEnquiryAbountDelStatus).HasColumnName("Eqnuiry_About_Enquiry_Abount_DelStatus");

                entity.Property(e => e.EqnuiryAboutEnquiryAbout)
                    .HasColumnName("Eqnuiry_About_Enquiry_About")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EqnuiryAboutEnquiryAboutId).HasColumnName("Eqnuiry_About_Enquiry_About_ID");

                entity.Property(e => e.EqnuiryAboutEnquiryAboutStatus).HasColumnName("Eqnuiry_About_Enquiry_About_Status");
            });

            modelBuilder.Entity<EquipmentTools>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Equipment_Tools");

                entity.Property(e => e.EquipmentToolsCode)
                    .HasColumnName("Equipment_Tools_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentToolsDelStatus).HasColumnName("Equipment_Tools_DelStatus");

                entity.Property(e => e.EquipmentToolsDescription)
                    .HasColumnName("Equipment_Tools_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentToolsId).HasColumnName("Equipment_Tools_ID");

                entity.Property(e => e.EquipmentToolsName)
                    .HasColumnName("Equipment_Tools_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentToolsValue).HasColumnName("Equipment_Tools_Value");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Error_log");

                entity.Property(e => e.ErrorLogDate)
                    .HasColumnName("Error_Log_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorLogDelStatus).HasColumnName("Error_Log_DelStatus");

                entity.Property(e => e.ErrorLogDetails)
                    .HasColumnName("Error_Log_Details")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorLogFormName)
                    .HasColumnName("Error_Log_FormName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorLogFuntionName)
                    .HasColumnName("Error_Log_FuntionName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("Error_Log_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ErrorLogLineNo).HasColumnName("Error_Log_LineNo");

                entity.Property(e => e.ErrorLogTime)
                    .HasColumnName("Error_Log_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorLogTraceDetails)
                    .HasColumnName("Error_Log_TraceDetails")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinalStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Final_Stock");

                entity.Property(e => e.FinalStockDelStatus).HasColumnName("Final_Stock_DelStatus");

                entity.Property(e => e.FinalStockId).HasColumnName("Final_Stock_ID");

                entity.Property(e => e.FinalStockItemId).HasColumnName("Final_Stock_Item_ID");

                entity.Property(e => e.FinalStockLocationId).HasColumnName("Final_Stock_Location_ID");

                entity.Property(e => e.FinalStockQty).HasColumnName("Final_Stock_QTY");
            });

            modelBuilder.Entity<FinancialPeriods>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Financial_Periods");

                entity.Property(e => e.FinancialPeriodsDelStatus).HasColumnName("Financial_Periods_DelStatus");

                entity.Property(e => e.FinancialPeriodsEndDate)
                    .HasColumnName("Financial_Periods_End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinancialPeriodsFsno).HasColumnName("Financial_Periods_FSNO");

                entity.Property(e => e.FinancialPeriodsStartDate)
                    .HasColumnName("Financial_Periods_Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinancialPeriodsStatus)
                    .HasColumnName("Financial_Periods_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FinancialPeriodsYearEndFile)
                    .HasColumnName("Financial_periods_Year_EndFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodsYearEndJv)
                    .HasColumnName("Financial_Periods_Year_EndJV")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Form_Category");

                entity.Property(e => e.FormCategoryCategory)
                    .HasColumnName("Form_Category_Category")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormCategoryDelStatus).HasColumnName("Form_Category_DelStatus");

                entity.Property(e => e.FormCategoryId).HasColumnName("Form_Category_ID");
            });

            modelBuilder.Entity<FormNames>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Form_Names");

                entity.Property(e => e.FormNamesAliasName)
                    .HasColumnName("Form_Names_Alias_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormNamesCategoryId).HasColumnName("Form_Names_Category_ID");

                entity.Property(e => e.FormNamesDelStatus).HasColumnName("Form_Names_DelStatus");

                entity.Property(e => e.FormNamesId).HasColumnName("Form_Names_ID");

                entity.Property(e => e.FormNamesIsMenuVisible).HasColumnName("Form_Names_IsMenuVisible");

                entity.Property(e => e.FormNamesIsVisible).HasColumnName("Form_Names_IsVisible");

                entity.Property(e => e.FormNamesMenuName)
                    .HasColumnName("Form_Names_Menu_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormNamesName)
                    .HasColumnName("Form_Names_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralPurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("General_Purchase_Order");

                entity.Property(e => e.GeneralPurchaseOrderApproveDate)
                    .HasColumnName("General_Purchase_Order_Approve_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneralPurchaseOrderApproveStatus)
                    .HasColumnName("General_Purchase_Order_Approve_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderApprovedBy).HasColumnName("General_Purchase_Order_Approved_By");

                entity.Property(e => e.GeneralPurchaseOrderCurrencyId).HasColumnName("General_Purchase_Order_Currency_ID");

                entity.Property(e => e.GeneralPurchaseOrderDelStatus).HasColumnName("General_Purchase_Order_DelStatus");

                entity.Property(e => e.GeneralPurchaseOrderDelivery)
                    .HasColumnName("General_Purchase_Order_Delivery")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderDescription)
                    .HasColumnName("General_Purchase_Order_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderDiscount).HasColumnName("General_Purchase_Order_Discount");

                entity.Property(e => e.GeneralPurchaseOrderDiscountPercentage).HasColumnName("General_Purchase_Order_Discount_Percentage");

                entity.Property(e => e.GeneralPurchaseOrderFooter)
                    .HasColumnName("General_Purchase_Order_Footer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderFsno).HasColumnName("General_Purchase_Order_FSNO");

                entity.Property(e => e.GeneralPurchaseOrderHeader)
                    .HasColumnName("General_Purchase_Order_Header")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderId).HasColumnName("General_Purchase_Order_ID");

                entity.Property(e => e.GeneralPurchaseOrderIndentNo)
                    .HasColumnName("General_Purchase_Order_Indent_No")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderJobId).HasColumnName("General_Purchase_Order_Job_ID");

                entity.Property(e => e.GeneralPurchaseOrderLocationId).HasColumnName("General_Purchase_Order_Location_ID");

                entity.Property(e => e.GeneralPurchaseOrderLpoDate)
                    .HasColumnName("General_Purchase_Order_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneralPurchaseOrderLpoNo)
                    .HasColumnName("General_Purchase_Order_LPO_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderNetAmount).HasColumnName("General_Purchase_Order_Net_Amount");

                entity.Property(e => e.GeneralPurchaseOrderPaymentTerms)
                    .HasColumnName("General_Purchase_Order_Payment_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderPoDate)
                    .HasColumnName("General_Purchase_Order_PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneralPurchaseOrderPono)
                    .HasColumnName("General_Purchase_Order_PONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderStatus)
                    .HasColumnName("General_Purchase_Order_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderSupplierId).HasColumnName("General_Purchase_Order_Supplier_ID");

                entity.Property(e => e.GeneralPurchaseOrderTermAndCondition)
                    .HasColumnName("General_Purchase_Order_TermAndCondition")
                    .HasMaxLength(500);

                entity.Property(e => e.GeneralPurchaseOrderTerms)
                    .HasColumnName("General_Purchase_Order_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderTotalAmount).HasColumnName("General_Purchase_Order_Total_Amount");

                entity.Property(e => e.GeneralPurchaseOrderUserId).HasColumnName("General_Purchase_Order_User_ID");
            });

            modelBuilder.Entity<GeneralPurchaseOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("General_Purchase_Order_Details");

                entity.Property(e => e.GeneralPurchaseOrderDetailsAmount).HasColumnName("General_Purchase_Order_Details_Amount");

                entity.Property(e => e.GeneralPurchaseOrderDetailsDelStatus).HasColumnName("General_Purchase_Order_Details_DelStatus");

                entity.Property(e => e.GeneralPurchaseOrderDetailsDescription)
                    .HasColumnName("General_Purchase_Order_Details_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderDetailsFcAmount).HasColumnName("General_Purchase_Order_Details_FC_Amount");

                entity.Property(e => e.GeneralPurchaseOrderDetailsIsEdit).HasColumnName("General_Purchase_Order_Details_IsEdit");

                entity.Property(e => e.GeneralPurchaseOrderDetailsMaterialDescription)
                    .HasColumnName("General_Purchase_Order_Details_Material_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderDetailsMaterialId).HasColumnName("General_Purchase_Order_Details_Material_ID");

                entity.Property(e => e.GeneralPurchaseOrderDetailsPoStatus)
                    .HasColumnName("General_Purchase_Order_Details_PO_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralPurchaseOrderDetailsPodId).HasColumnName("General_Purchase_Order_Details_POD_ID");

                entity.Property(e => e.GeneralPurchaseOrderDetailsPoid).HasColumnName("General_Purchase_Order_Details_POID");

                entity.Property(e => e.GeneralPurchaseOrderDetailsPreqId).HasColumnName("General_Purchase_Order_Details_PReq_ID");

                entity.Property(e => e.GeneralPurchaseOrderDetailsQuantity).HasColumnName("General_Purchase_Order_Details_Quantity");

                entity.Property(e => e.GeneralPurchaseOrderDetailsRate).HasColumnName("General_Purchase_Order_Details_Rate");

                entity.Property(e => e.GeneralPurchaseOrderDetailsSno).HasColumnName("General_Purchase_Order_Details_SNO");

                entity.Property(e => e.GeneralPurchaseOrderDetailsSrdId).HasColumnName("General_Purchase_Order_Details_SRD_ID");

                entity.Property(e => e.GeneralPurchaseOrderDetailsUnitId).HasColumnName("General_Purchase_Order_Details_Unit_ID");
            });

            modelBuilder.Entity<GeneralSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("General_Settings");

                entity.Property(e => e.GeneralSettingsBoolValue).HasColumnName("General_Settings_Bool_Value");

                entity.Property(e => e.GeneralSettingsCategory)
                    .HasColumnName("General_Settings_Category")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsDelStatus).HasColumnName("General_Settings_DelStatus");

                entity.Property(e => e.GeneralSettingsDescription)
                    .HasColumnName("General_Settings_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsId).HasColumnName("General_Settings_ID");

                entity.Property(e => e.GeneralSettingsKeyValue)
                    .HasColumnName("General_Settings_Key_Value")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.GeneralSettingsNumValue).HasColumnName("General_Settings_Num_Value");

                entity.Property(e => e.GeneralSettingsTableName)
                    .HasColumnName("General_Settings_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsTextValue)
                    .HasColumnName("General_Settings_Text_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsValueType)
                    .HasColumnName("General_Settings_Value_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralSettings1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GeneralSettings");

                entity.Property(e => e.GeneralSettingsAppName)
                    .HasColumnName("GeneralSettings_App_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsDelStatus).HasColumnName("GeneralSettings_DelStatus");

                entity.Property(e => e.GeneralSettingsKeyName)
                    .HasColumnName("GeneralSettings_Key_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsSettingName)
                    .HasColumnName("GeneralSettings_Setting_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSettingsSettingValue)
                    .HasColumnName("GeneralSettings_Setting_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenericMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Generic_Master");

                entity.Property(e => e.GenericMasterDelStatus).HasColumnName("Generic_Master_DelStatus");

                entity.Property(e => e.GenericMasterDeleted).HasColumnName("Generic_Master_Deleted");

                entity.Property(e => e.GenericMasterId).HasColumnName("Generic_Master_ID");

                entity.Property(e => e.GenericMasterName)
                    .HasColumnName("Generic_Master_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenericMasterStatus).HasColumnName("Generic_Master_Status");

                entity.Property(e => e.GenericMasterUserId).HasColumnName("Generic_Master_User_ID");
            });

            modelBuilder.Entity<GlobalAccountsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Global_Accounts_Table");

                entity.Property(e => e.GlobalAccountsTableAcAcc)
                    .HasColumnName("Global_Accounts_Table_AC_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableAccName)
                    .HasColumnName("Global_Accounts_Table_AccName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableAccNo)
                    .HasColumnName("Global_Accounts_Table_AccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableAccType)
                    .HasColumnName("Global_Accounts_Table_AccType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableCurrencyId).HasColumnName("Global_Accounts_Table_Currency_ID");

                entity.Property(e => e.GlobalAccountsTableDelStatus).HasColumnName("Global_Accounts_Table_DelStatus");

                entity.Property(e => e.GlobalAccountsTableDtCreate)
                    .HasColumnName("Global_Accounts_Table_Dt_Create")
                    .HasColumnType("datetime");

                entity.Property(e => e.GlobalAccountsTableEdAcc)
                    .HasColumnName("Global_Accounts_Table_ED_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableFsno).HasColumnName("Global_Accounts_Table_FSNO");

                entity.Property(e => e.GlobalAccountsTableGpAcc)
                    .HasColumnName("Global_Accounts_Table_GP_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableImageKey)
                    .HasColumnName("Global_Accounts_Table_ImageKey")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableMainHead)
                    .HasColumnName("Global_Accounts_Table_MainHead")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableOpbal).HasColumnName("Global_Accounts_Table_Opbal");

                entity.Property(e => e.GlobalAccountsTableRelativeNo)
                    .HasColumnName("Global_Accounts_Table_RelativeNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableSno).HasColumnName("Global_Accounts_Table_Sno");

                entity.Property(e => e.GlobalAccountsTableStatus)
                    .HasColumnName("Global_Accounts_Table_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableSubHead)
                    .HasColumnName("Global_Accounts_Table_SubHead")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalAccountsTableSystemAcc)
                    .HasColumnName("Global_Accounts_Table_SystemAcc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalAccountsTableTotalCredit).HasColumnName("Global_Accounts_Table_Total_Credit");

                entity.Property(e => e.GlobalAccountsTableTotalDebit).HasColumnName("Global_Accounts_Table_Total_Debit");

                entity.Property(e => e.GlobalAccountsTableUserId).HasColumnName("Global_Accounts_Table_User_ID");
            });

            modelBuilder.Entity<GoodsDelivery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_Delivery");

                entity.Property(e => e.GoodsDeliveryCpoId).HasColumnName("Goods_Delivery_CPO_ID");

                entity.Property(e => e.GoodsDeliveryDateTime)
                    .HasColumnName("Goods_Delivery_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoodsDeliveryDelStatus).HasColumnName("Goods_Delivery_DelStatus");

                entity.Property(e => e.GoodsDeliveryFsno).HasColumnName("Goods_Delivery_FSNO");

                entity.Property(e => e.GoodsDeliveryId).HasColumnName("Goods_Delivery_ID");

                entity.Property(e => e.GoodsDeliveryReceivedBy)
                    .HasColumnName("Goods_Delivery_Received_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsDeliveryRemarks)
                    .HasColumnName("Goods_Delivery_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsDeliveryDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_Delivery_Details");

                entity.Property(e => e.GoodsDeliveryDetailsDelStatus).HasColumnName("Goods_Delivery_Details_DelStatus");

                entity.Property(e => e.GoodsDeliveryDetailsDeliveryId).HasColumnName("Goods_Delivery_Details_Delivery_ID");

                entity.Property(e => e.GoodsDeliveryDetailsDetailsId).HasColumnName("Goods_Delivery_Details_Details_ID");

                entity.Property(e => e.GoodsDeliveryDetailsFsno).HasColumnName("Goods_Delivery_Details_FSNO");

                entity.Property(e => e.GoodsDeliveryDetailsItemId).HasColumnName("Goods_Delivery_Details_Item_ID");

                entity.Property(e => e.GoodsDeliveryDetailsNarration)
                    .HasColumnName("Goods_Delivery_Details_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsDeliveryDetailsQty).HasColumnName("Goods_Delivery_Details_QTY");

                entity.Property(e => e.GoodsDeliveryDetailsSlno).HasColumnName("Goods_Delivery_Details_SLNO");

                entity.Property(e => e.GoodsDeliveryDetailsUnitId).HasColumnName("Goods_Delivery_Details_Unit_ID");
            });

            modelBuilder.Entity<GrnPoDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRN_PO_Details");

                entity.Property(e => e.GrnPoDetailsDelStatus).HasColumnName("GRN_PO_Details_DelStatus");

                entity.Property(e => e.GrnPoDetailsGrnNo)
                    .HasColumnName("GRN_PO_Details_GRN_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrnPoDetailsPoDate)
                    .HasColumnName("GRN_PO_Details_PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrnPoDetailsPoId).HasColumnName("GRN_PO_Details_PO_ID");

                entity.Property(e => e.GrnPoDetailsSno).HasColumnName("GRN_PO_Details_Sno");
            });

            modelBuilder.Entity<HappyHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Happy_Hour");

                entity.Property(e => e.HappyHourCreatdBy)
                    .HasColumnName("Happy_Hour_Creatd_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourDays).HasColumnName("Happy_Hour_Days");

                entity.Property(e => e.HappyHourDelStatus).HasColumnName("Happy_Hour_DelStatus");

                entity.Property(e => e.HappyHourEditedBy)
                    .HasColumnName("Happy_Hour_Edited_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourExp1)
                    .HasColumnName("Happy_Hour_Exp1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourExp2)
                    .HasColumnName("Happy_Hour_Exp2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourExp3)
                    .HasColumnName("Happy_Hour_Exp3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourExp4)
                    .HasColumnName("Happy_Hour_Exp4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourFromDate)
                    .HasColumnName("Happy_Hour_From_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HappyHourHappyHour)
                    .HasColumnName("Happy_Hour_Happy_Hour")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourId).HasColumnName("Happy_Hour_ID");

                entity.Property(e => e.HappyHourRemarks)
                    .HasColumnName("Happy_Hour_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HappyHourToDate)
                    .HasColumnName("Happy_Hour_To_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HappyHourDeatils>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Happy_Hour_Deatils");

                entity.Property(e => e.HappyHourDeatilsEndDate)
                    .HasColumnName("Happy_Hour_Deatils_End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HappyHourDeatilsHappyHourId).HasColumnName("Happy_Hour_Deatils_Happy_Hour_ID");

                entity.Property(e => e.HappyHourDeatilsId)
                    .HasColumnName("Happy_Hour_Deatils_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HappyHourDeatilsItemId).HasColumnName("Happy_Hour_Deatils_Item_ID");

                entity.Property(e => e.HappyHourDeatilsStartDate)
                    .HasColumnName("Happy_Hour_Deatils_Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HappyHourDetailsDelStatus).HasColumnName("Happy_Hour_Details_DelStatus");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InvoiceBankId).HasColumnName("Invoice_Bank_ID");

                entity.Property(e => e.InvoiceCpoId).HasColumnName("Invoice_CPO_ID");

                entity.Property(e => e.InvoiceCustCode)
                    .HasColumnName("Invoice_Cust_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceDelStatus).HasColumnName("Invoice_DelStatus");

                entity.Property(e => e.InvoiceDiscountAmount).HasColumnName("Invoice_Discount_Amount");

                entity.Property(e => e.InvoiceDiscountPercentage).HasColumnName("Invoice_Discount_Percentage");

                entity.Property(e => e.InvoiceNo).HasColumnName("Invoice_No");

                entity.Property(e => e.InvoicePaymentTerms)
                    .HasColumnName("Invoice_Payment_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRemarks)
                    .HasColumnName("Invoice_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceAirDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Air_Details");

                entity.Property(e => e.InvoiceAirDetailsAccNo)
                    .HasColumnName("Invoice_Air_Details_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAirDetailsAmount).HasColumnName("Invoice_Air_Details_Amount");

                entity.Property(e => e.InvoiceAirDetailsDelStatus).HasColumnName("Invoice_Air_Details_DelStatus");

                entity.Property(e => e.InvoiceAirDetailsInvoiceNo)
                    .HasColumnName("Invoice_Air_Details_Invoice_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAirDetailsRemarks)
                    .HasColumnName("Invoice_Air_Details_Remarks")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAirDetailsSno).HasColumnName("Invoice_Air_Details_SNO");
            });

            modelBuilder.Entity<InvoiceAirMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Air_Master");

                entity.Property(e => e.InvoiceAirMasterCustomerId).HasColumnName("Invoice_Air_Master_Customer_ID");

                entity.Property(e => e.InvoiceAirMasterDebitId).HasColumnName("Invoice_Air_Master_Debit_ID");

                entity.Property(e => e.InvoiceAirMasterDelStatus).HasColumnName("Invoice_Air_Master_DelStatus");

                entity.Property(e => e.InvoiceAirMasterInvoiceDate)
                    .HasColumnName("Invoice_Air_Master_Invoice_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceAirMasterInvoiceNo).HasColumnName("Invoice_Air_Master_Invoice_No");

                entity.Property(e => e.InvoiceAirMasterJobId).HasColumnName("Invoice_Air_Master_Job_ID");

                entity.Property(e => e.InvoiceAirMasterRemarks)
                    .HasColumnName("Invoice_Air_Master_Remarks")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Details");

                entity.Property(e => e.InvoiceDetailsAmount).HasColumnName("Invoice_Details_Amount");

                entity.Property(e => e.InvoiceDetailsDelStatus).HasColumnName("Invoice_Details_DelStatus");

                entity.Property(e => e.InvoiceDetailsDescription)
                    .HasColumnName("Invoice_Details_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsDetailsId).HasColumnName("Invoice_Details_Details_ID");

                entity.Property(e => e.InvoiceDetailsGddetailsId).HasColumnName("Invoice_Details_GDDetails_ID");

                entity.Property(e => e.InvoiceDetailsInvoiceNo)
                    .HasColumnName("Invoice_Details_Invoice_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsIsEdited).HasColumnName("Invoice_Details_IsEdited");

                entity.Property(e => e.InvoiceDetailsItemId).HasColumnName("Invoice_Details_Item_ID");

                entity.Property(e => e.InvoiceDetailsQty).HasColumnName("Invoice_Details_QTY");

                entity.Property(e => e.InvoiceDetailsSlno).HasColumnName("Invoice_Details_Slno");

                entity.Property(e => e.InvoiceDetailsUnitId).HasColumnName("Invoice_Details_Unit_ID");

                entity.Property(e => e.InvoiceDetailsUnitPrice).HasColumnName("Invoice_Details_UnitPrice");
            });

            modelBuilder.Entity<InvoiceDetailsWestern>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Details_Western");

                entity.Property(e => e.InvoiceDetailsWesternAccNo)
                    .HasColumnName("Invoice_Details_Western_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsWesternAmount).HasColumnName("Invoice_Details_Western_Amount");

                entity.Property(e => e.InvoiceDetailsWesternDelStatus).HasColumnName("Invoice_Details_Western_DelStatus");

                entity.Property(e => e.InvoiceDetailsWesternDescription)
                    .HasColumnName("Invoice_Details_Western_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsWesternDetailsId)
                    .HasColumnName("Invoice_Details_Western_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceDetailsWesternFsno).HasColumnName("Invoice_Details_Western_FSNO");

                entity.Property(e => e.InvoiceDetailsWesternInvNo)
                    .HasColumnName("Invoice_Details_Western_InvNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsWesternIsEdit).HasColumnName("Invoice_Details_Western_IsEdit");

                entity.Property(e => e.InvoiceDetailsWesternJobId).HasColumnName("Invoice_Details_Western_Job_ID");

                entity.Property(e => e.InvoiceDetailsWesternJsize)
                    .HasColumnName("Invoice_Details_Western_Jsize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailsWesternMatId).HasColumnName("Invoice_Details_Western_Mat_ID");

                entity.Property(e => e.InvoiceDetailsWesternQty).HasColumnName("Invoice_Details_Western_Qty");

                entity.Property(e => e.InvoiceDetailsWesternSno).HasColumnName("Invoice_Details_Western_Sno");

                entity.Property(e => e.InvoiceDetailsWesternSupId).HasColumnName("Invoice_Details_Western_Sup_ID");

                entity.Property(e => e.InvoiceDetailsWesternUnitId).HasColumnName("Invoice_Details_Western_Unit_ID");

                entity.Property(e => e.InvoiceDetailsWesternUnitPrice).HasColumnName("Invoice_Details_Western_UnitPrice");
            });

            modelBuilder.Entity<InvoiceSeaDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Sea_Details");

                entity.Property(e => e.InvoiceSeaDetailsAccNo)
                    .HasColumnName("Invoice_Sea_Details_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSeaDetailsAmount).HasColumnName("Invoice_Sea_Details_Amount");

                entity.Property(e => e.InvoiceSeaDetailsDelStatus).HasColumnName("Invoice_Sea_Details_DelStatus");

                entity.Property(e => e.InvoiceSeaDetailsInvoiceNo)
                    .HasColumnName("Invoice_Sea_Details_Invoice_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSeaDetailsRemarks)
                    .HasColumnName("Invoice_Sea_Details_Remarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSeaDetailsSno).HasColumnName("Invoice_Sea_Details_SNO");
            });

            modelBuilder.Entity<InvoiceSeaMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Sea_Master");

                entity.Property(e => e.InvoiceSeaMasterCustomerId).HasColumnName("Invoice_Sea_Master_Customer_ID");

                entity.Property(e => e.InvoiceSeaMasterDebitId).HasColumnName("Invoice_Sea_Master_Debit_ID");

                entity.Property(e => e.InvoiceSeaMasterDelStatus).HasColumnName("Invoice_Sea_Master_DelStatus");

                entity.Property(e => e.InvoiceSeaMasterInvoiceDate)
                    .HasColumnName("Invoice_Sea_Master_Invoice_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceSeaMasterInvoiceNo).HasColumnName("Invoice_Sea_Master_Invoice_No");

                entity.Property(e => e.InvoiceSeaMasterJobId).HasColumnName("Invoice_Sea_Master_Job_ID");

                entity.Property(e => e.InvoiceSeaMasterRemarks)
                    .HasColumnName("Invoice_Sea_Master_Remarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceWestern>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Western");

                entity.Property(e => e.InvoiceWesternBank)
                    .HasColumnName("Invoice_Western_Bank")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternChasis)
                    .HasColumnName("Invoice_Western_Chasis")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternCsId).HasColumnName("Invoice_Western_CS_ID");

                entity.Property(e => e.InvoiceWesternCurrencyId).HasColumnName("Invoice_Western_Currency_ID");

                entity.Property(e => e.InvoiceWesternCurrencyRate).HasColumnName("Invoice_Western_Currency_Rate");

                entity.Property(e => e.InvoiceWesternDelStatus).HasColumnName("Invoice_Western_DelStatus");

                entity.Property(e => e.InvoiceWesternDiscount).HasColumnName("Invoice_Western_Discount");

                entity.Property(e => e.InvoiceWesternDiscountPercentage).HasColumnName("Invoice_Western_Discount_Percentage");

                entity.Property(e => e.InvoiceWesternFsno).HasColumnName("Invoice_Western_FSNO");

                entity.Property(e => e.InvoiceWesternId).HasColumnName("Invoice_Western_ID");

                entity.Property(e => e.InvoiceWesternInvDate)
                    .HasColumnName("Invoice_Western_InvDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceWesternInvNo)
                    .HasColumnName("Invoice_Western_InvNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternJobId).HasColumnName("Invoice_Western_Job_ID");

                entity.Property(e => e.InvoiceWesternLocationId).HasColumnName("Invoice_Western_Location_ID");

                entity.Property(e => e.InvoiceWesternLpoRefNo)
                    .HasColumnName("Invoice_Western_LPO_RefNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternMake)
                    .HasColumnName("Invoice_Western_Make")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternPrintInv)
                    .HasColumnName("Invoice_Western_PrintInv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternQtnNo)
                    .HasColumnName("Invoice_Western_QtnNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternRemarks)
                    .HasColumnName("Invoice_Western_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternStatus)
                    .HasColumnName("Invoice_Western_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternTotalAmount).HasColumnName("Invoice_Western_Total_Amount");

                entity.Property(e => e.InvoiceWesternType)
                    .HasColumnName("Invoice_Western_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWesternUnitId).HasColumnName("Invoice_Western_Unit_ID");

                entity.Property(e => e.InvoiceWesternVehNo)
                    .HasColumnName("Invoice_Western_VehNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Item_Images");

                entity.Property(e => e.ItemImagesItemCatelogImage)
                    .HasColumnName("Item_Images_Item_Catelog_Image")
                    .HasColumnType("image");

                entity.Property(e => e.ItemImagesItemId).HasColumnName("Item_Images_Item_ID");

                entity.Property(e => e.ItemImagesItemImage)
                    .HasColumnName("Item_Images_Item_Image")
                    .HasColumnType("image");

                entity.Property(e => e.ItemImagesItemImage1)
                    .HasColumnName("Item_Images_Item_Image1")
                    .HasColumnType("image");

                entity.Property(e => e.ItemImagesItemImageDelStatus).HasColumnName("Item_Images_Item_Image_DelStatus");

                entity.Property(e => e.ItemImagesItemImageId).HasColumnName("Item_Images_Item_Image_ID");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.HasKey(e => e.ItemMasterItemId);

                entity.ToTable("Item_Master");

                entity.Property(e => e.ItemMasterItemId)
                    .HasColumnName("Item_Master_Item_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemMasterAccountNo).HasColumnName("Item_Master_Account_No");

                entity.Property(e => e.ItemMasterActive).HasColumnName("Item_Master_Active");

                entity.Property(e => e.ItemMasterAliasName)
                    .HasColumnName("Item_Master_Alias_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterAssetAcc)
                    .HasColumnName("Item_Master_Asset_ACC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterAvgCostYel)
                    .HasColumnName("Item_Master_Avg_Cost_Yel")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemMasterBarcode)
                    .HasColumnName("Item_Master_Barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterBaseValue).HasColumnName("Item_Master_Base_Value");

                entity.Property(e => e.ItemMasterBatchCode)
                    .HasColumnName("Item_Master_Batch_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterColor)
                    .HasColumnName("Item_Master_Color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterCountryId).HasColumnName("Item_Master_Country_ID");

                entity.Property(e => e.ItemMasterCurrentStock).HasColumnName("Item_Master_Current_Stock");

                entity.Property(e => e.ItemMasterDefaultLocation).HasColumnName("Item_Master_Default_Location");

                entity.Property(e => e.ItemMasterDefaultLocationName)
                    .HasColumnName("Item_Master_Default_Location_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterDelStatus).HasColumnName("Item_Master_DelStatus");

                entity.Property(e => e.ItemMasterExpenseAcc)
                    .HasColumnName("Item_Master_Expense_ACC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterGenericName)
                    .HasColumnName("Item_Master_Generic_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterGroupCreditAcc)
                    .HasColumnName("Item_Master_Group_Credit_ACC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterGroupDebitAcc)
                    .HasColumnName("Item_Master_Group_Debit_ACC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterHeightN).HasColumnName("Item_Master_Height_N");

                entity.Property(e => e.ItemMasterImage)
                    .HasColumnName("Item_Master_Image")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ItemMasterItemName)
                    .HasColumnName("Item_Master_Item_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterItemSize)
                    .HasColumnName("Item_Master_Item_Size")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterItemType)
                    .HasColumnName("Item_Master_Item_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemMasterLandingCost).HasColumnName("Item_Master_Landing_Cost");

                entity.Property(e => e.ItemMasterLastPurchasePrice)
                    .HasColumnName("Item_Master_Last_Purchase_Price")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterLocationId).HasColumnName("Item_Master_Location_ID");

                entity.Property(e => e.ItemMasterManufactureName)
                    .HasColumnName("Item_Master_Manufacture_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterMaterialCode)
                    .HasColumnName("Item_Master_Material_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterModelId).HasColumnName("Item_Master_Model_ID");

                entity.Property(e => e.ItemMasterPackageId)
                    .HasColumnName("Item_Master_Package_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterPacking)
                    .HasColumnName("Item_Master_Packing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterPartNo)
                    .HasColumnName("Item_Master_Part_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterProMrp)
                    .HasColumnName("Item_Master_PRO_MRP")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterProPurchaseRate)
                    .HasColumnName("Item_Master_PRO_Purchase_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterProSaleRate)
                    .HasColumnName("Item_Master_PRO_Sale_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterRackId).HasColumnName("Item_Master_Rack_ID");

                entity.Property(e => e.ItemMasterReOrderLevel).HasColumnName("Item_Master_ReOrder_Level");

                entity.Property(e => e.ItemMasterRedeemRewardPoint)
                    .HasColumnName("Item_Master_Redeem_Reward_Point")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ItemMasterRef1)
                    .HasColumnName("Item_Master_Ref1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterRef2)
                    .HasColumnName("Item_Master_Ref2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterReorderCheck).HasColumnName("Item_Master_Reorder_Check");

                entity.Property(e => e.ItemMasterServices).HasColumnName("Item_Master_Services");

                entity.Property(e => e.ItemMasterShape)
                    .HasColumnName("Item_Master_Shape")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterStatus).HasColumnName("Item_Master_Status");

                entity.Property(e => e.ItemMasterStockType).HasColumnName("Item_Master_Stock_Type");

                entity.Property(e => e.ItemMasterSuplierCode)
                    .HasColumnName("Item_Master_Suplier_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterSupplierName)
                    .HasColumnName("Item_Master_Supplier_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterTypeId)
                    .HasColumnName("Item_Master_Type_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterUnitId).HasColumnName("Item_Master_Unit_ID");

                entity.Property(e => e.ItemMasterUnitPrice)
                    .HasColumnName("Item_Master_Unit_Price")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterUnitPrice1)
                    .HasColumnName("Item_Master_Unit_Price1")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterUnitPrice2)
                    .HasColumnName("Item_Master_Unit_Price2")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemMasterUserId).HasColumnName("Item_Master_User_ID");

                entity.Property(e => e.ItemMasterVat).HasColumnName("Item_Master_VAT");

                entity.Property(e => e.ItemMasterVatInclues).HasColumnName("Item_Master_Vat_Inclues");

                entity.Property(e => e.ItemMasterVatPercentage)
                    .HasColumnName("Item_Master_Vat_Percentage")
                    .HasColumnType("numeric(4, 4)");

                entity.Property(e => e.ItemMasterVenderId).HasColumnName("Item_Master_Vender_ID");

                entity.Property(e => e.ItemMasterWeight)
                    .HasColumnName("Item_Master_Weight")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMasterWeightN).HasColumnName("Item_Master_Weight_N");
            });

            modelBuilder.Entity<ItemPriceLevelDetails>(entity =>
            {
                entity.HasKey(e => e.ItemPriceLevelId);

                entity.ToTable("Item_PriceLevel_Details");

                entity.Property(e => e.ItemPriceLevelId).HasColumnName("ItemPriceLevelID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPriceLevelDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_PriceLevel_Details_Item_Master");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.ItemPriceLevelDetails)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_PriceLevel_Details_PriceLevelMaster");
            });

            modelBuilder.Entity<ItemStockType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Item_Stock_Type");

                entity.Property(e => e.ItemStockTypeDelStatus).HasColumnName("Item_Stock_Type_DelStatus");

                entity.Property(e => e.ItemStockTypeDescription)
                    .HasColumnName("Item_Stock_Type_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemStockTypeId).HasColumnName("Item_Stock_Type_ID");
            });

            modelBuilder.Entity<ItemSupplierDetails>(entity =>
            {
                entity.HasKey(e => e.ItemSupplierDetailsItemSupplierDetailsId);

                entity.ToTable("Item_Supplier_Details");

                entity.Property(e => e.ItemSupplierDetailsItemSupplierDetailsId)
                    .HasColumnName("Item_Supplier_Details_ItemSupplierDetails_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemSupplierDetailsBatchId).HasColumnName("Item_Supplier_Details_Batch_ID");

                entity.Property(e => e.ItemSupplierDetailsDelStatus).HasColumnName("Item_Supplier_Details_DelStatus");

                entity.Property(e => e.ItemSupplierDetailsItemId).HasColumnName("Item_Supplier_Details_Item_ID");

                entity.Property(e => e.ItemSupplierDetailsRate)
                    .HasColumnName("Item_Supplier_Details_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemSupplierDetailsSupplierId).HasColumnName("Item_Supplier_Details_Supplier_ID");

                entity.HasOne(d => d.ItemSupplierDetailsItem)
                    .WithMany(p => p.ItemSupplierDetails)
                    .HasForeignKey(d => d.ItemSupplierDetailsItemId)
                    .HasConstraintName("FK_Item_Supplier_Details_Item_Master");
            });

            modelBuilder.Entity<JobBudgetDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Budget_Details");

                entity.Property(e => e.JobBudgetDetailsBudgetAmount).HasColumnName("Job_Budget_Details_Budget_Amount");

                entity.Property(e => e.JobBudgetDetailsBudgetId).HasColumnName("Job_Budget_Details_Budget_ID");

                entity.Property(e => e.JobBudgetDetailsDelStatus).HasColumnName("Job_Budget_Details_DelStatus");

                entity.Property(e => e.JobBudgetDetailsId).HasColumnName("Job_Budget_Details_ID");

                entity.Property(e => e.JobBudgetDetailsSno).HasColumnName("Job_Budget_Details_Sno");
            });

            modelBuilder.Entity<JobCordinator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Cordinator");

                entity.Property(e => e.JobCordinatorActive).HasColumnName("Job_Cordinator_Active");

                entity.Property(e => e.JobCordinatorCode).HasColumnName("Job_Cordinator_Code");

                entity.Property(e => e.JobCordinatorDelStatus).HasColumnName("Job_Cordinator_DelStatus");

                entity.Property(e => e.JobCordinatorDescription)
                    .HasColumnName("Job_Cordinator_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobCostEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Cost_Entry");

                entity.Property(e => e.JobCostEntryAccNo)
                    .HasColumnName("Job_Cost_Entry_ACC_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobCostEntryCompanyId).HasColumnName("Job_Cost_Entry_Company_ID");

                entity.Property(e => e.JobCostEntryCostCenterId).HasColumnName("Job_Cost_Entry_CostCenter_ID");

                entity.Property(e => e.JobCostEntryCrAmount).HasColumnName("Job_Cost_Entry_Cr_Amount");

                entity.Property(e => e.JobCostEntryCurrencyId).HasColumnName("Job_Cost_Entry_Currency_ID");

                entity.Property(e => e.JobCostEntryDelStatus).HasColumnName("Job_Cost_Entry_DelStatus");

                entity.Property(e => e.JobCostEntryDepartmentId).HasColumnName("Job_Cost_Entry_Department_ID");

                entity.Property(e => e.JobCostEntryDescription)
                    .HasColumnName("Job_Cost_Entry_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobCostEntryDrAmount).HasColumnName("Job_Cost_Entry_Dr_Amount");

                entity.Property(e => e.JobCostEntryFsno).HasColumnName("Job_Cost_Entry_FSNO");

                entity.Property(e => e.JobCostEntryJcId).HasColumnName("Job_Cost_Entry_JC_ID");

                entity.Property(e => e.JobCostEntryJobId).HasColumnName("Job_Cost_Entry_Job_ID");

                entity.Property(e => e.JobCostEntryLocationId).HasColumnName("Job_Cost_Entry_Location_ID");

                entity.Property(e => e.JobCostEntryTransDate)
                    .HasColumnName("Job_Cost_Entry_Trans_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobCostEntryUserId).HasColumnName("Job_Cost_Entry_User_ID");

                entity.Property(e => e.JobCostEntryVoucherNo)
                    .HasColumnName("Job_Cost_Entry_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCostEntryVoucherType)
                    .HasColumnName("Job_Cost_Entry_Voucher_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Details");

                entity.Property(e => e.JobDetailsAmount).HasColumnName("Job_Details_Amount");

                entity.Property(e => e.JobDetailsDelStatus).HasColumnName("Job_Details_DelStatus");

                entity.Property(e => e.JobDetailsDescription)
                    .HasColumnName("Job_Details_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobDetailsDescriptionId).HasColumnName("Job_Details_Description_ID");

                entity.Property(e => e.JobDetailsDetailsId)
                    .HasColumnName("Job_Details_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JobDetailsIsEdit).HasColumnName("Job_Details_IsEdit");

                entity.Property(e => e.JobDetailsJobId).HasColumnName("Job_Details_Job_ID");

                entity.Property(e => e.JobDetailsQtyN).HasColumnName("Job_Details_Qty_N");

                entity.Property(e => e.JobDetailsRefNo)
                    .HasColumnName("Job_Details_RefNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobDetailsStatus).HasColumnName("Job_Details_Status");

                entity.Property(e => e.JobDetailsStatusDate)
                    .HasColumnName("Job_Details_Status_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobDetailsUnitId).HasColumnName("Job_Details_Unit_ID");
            });

            modelBuilder.Entity<JobInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Invoice");

                entity.Property(e => e.JobInvoiceCurrencyId).HasColumnName("Job_Invoice_Currency_ID");

                entity.Property(e => e.JobInvoiceCustomerId).HasColumnName("Job_Invoice_Customer_ID");

                entity.Property(e => e.JobInvoiceCustomerName)
                    .HasColumnName("Job_Invoice_Customer_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceDelStatus).HasColumnName("Job_Invoice_DelStatus");

                entity.Property(e => e.JobInvoiceDiscount).HasColumnName("Job_Invoice_Discount");

                entity.Property(e => e.JobInvoiceFcRate).HasColumnName("Job_Invoice_FC_Rate");

                entity.Property(e => e.JobInvoiceFsno).HasColumnName("Job_Invoice_FSNO");

                entity.Property(e => e.JobInvoiceGrossAmount).HasColumnName("Job_Invoice_Gross_Amount");

                entity.Property(e => e.JobInvoiceId).HasColumnName("Job_Invoice_ID");

                entity.Property(e => e.JobInvoiceJobId).HasColumnName("Job_Invoice_Job_ID");

                entity.Property(e => e.JobInvoiceLocationId).HasColumnName("Job_Invoice_Location_ID");

                entity.Property(e => e.JobInvoiceLpoDate)
                    .HasColumnName("Job_Invoice_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobInvoiceLpoNo)
                    .HasColumnName("Job_Invoice_LPO_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceNetAmount).HasColumnName("Job_Invoice_Net_Amount");

                entity.Property(e => e.JobInvoiceRemarks)
                    .HasColumnName("Job_Invoice_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceSalesAccount)
                    .HasColumnName("Job_Invoice_Sales_Account")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceSalesManId).HasColumnName("Job_Invoice_Sales_Man_ID");

                entity.Property(e => e.JobInvoiceUserId).HasColumnName("Job_Invoice_User_ID");

                entity.Property(e => e.JobInvoiceVoucherDate)
                    .HasColumnName("Job_Invoice_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobInvoiceVoucherNo)
                    .HasColumnName("Job_Invoice_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobInvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Invoice_Details");

                entity.Property(e => e.JobInvoiceDetailsDelStatus).HasColumnName("Job_Invoice_Details_DelStatus");

                entity.Property(e => e.JobInvoiceDetailsDescription)
                    .HasColumnName("Job_Invoice_Details_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceDetailsDetailsId)
                    .HasColumnName("Job_Invoice_Details_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JobInvoiceDetailsDiscount).HasColumnName("Job_Invoice_Details_Discount");

                entity.Property(e => e.JobInvoiceDetailsFsno).HasColumnName("Job_Invoice_Details_FSNO");

                entity.Property(e => e.JobInvoiceDetailsGrossAmount).HasColumnName("Job_Invoice_Details_Gross_Amount");

                entity.Property(e => e.JobInvoiceDetailsItemId).HasColumnName("Job_Invoice_Details_Item_ID");

                entity.Property(e => e.JobInvoiceDetailsLocationId).HasColumnName("Job_Invoice_Details_Location_ID");

                entity.Property(e => e.JobInvoiceDetailsNetAmount).HasColumnName("Job_Invoice_Details_Net_Amount");

                entity.Property(e => e.JobInvoiceDetailsSno).HasColumnName("Job_Invoice_Details_Sno");

                entity.Property(e => e.JobInvoiceDetailsSoldQty).HasColumnName("Job_Invoice_Details_Sold_Qty");

                entity.Property(e => e.JobInvoiceDetailsUnit)
                    .HasColumnName("Job_Invoice_Details_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvoiceDetailsUnitId).HasColumnName("Job_Invoice_Details_Unit_ID");

                entity.Property(e => e.JobInvoiceDetailsUnitPrice).HasColumnName("Job_Invoice_Details_Unit_Price");

                entity.Property(e => e.JobInvoiceDetailsVoucherNo)
                    .HasColumnName("Job_Invoice_Details_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Master");

                entity.Property(e => e.JobMasterJobAdvanceAmount).HasColumnName("Job_Master_Job_Advance_Amount");

                entity.Property(e => e.JobMasterJobBalance).HasColumnName("Job_Master_Job_Balance");

                entity.Property(e => e.JobMasterJobBudgetMaterialCost).HasColumnName("Job_Master_Job_Budget_Material_Cost");

                entity.Property(e => e.JobMasterJobBudgetOverHeadCost).HasColumnName("Job_Master_Job_Budget_OverHead_Cost");

                entity.Property(e => e.JobMasterJobBugetLabourCost).HasColumnName("Job_Master_Job_Buget_Labour_Cost");

                entity.Property(e => e.JobMasterJobCode)
                    .HasColumnName("Job_Master_Job_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobCommenceDate)
                    .HasColumnName("Job_Master_Job_Commence_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobMasterJobConsultant)
                    .HasColumnName("Job_Master_Job_Consultant")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobConsultantReff)
                    .HasColumnName("Job_Master_Job_Consultant_Reff")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobContractType)
                    .HasColumnName("Job_Master_Job_Contract_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobContractorName)
                    .HasColumnName("Job_Master_Job_Contractor_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobCurVal).HasColumnName("Job_Master_Job_CurVal");

                entity.Property(e => e.JobMasterJobCurrencyId).HasColumnName("Job_Master_Job_Currency_ID");

                entity.Property(e => e.JobMasterJobCustomerId).HasColumnName("Job_Master_Job_Customer_ID");

                entity.Property(e => e.JobMasterJobDate)
                    .HasColumnName("Job_Master_Job_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobMasterJobDelStatus).HasColumnName("Job_Master_Job_DelStatus");

                entity.Property(e => e.JobMasterJobId).HasColumnName("Job_Master_Job_ID");

                entity.Property(e => e.JobMasterJobIsSubJob).HasColumnName("Job_Master_Job_IsSubJob");

                entity.Property(e => e.JobMasterJobLabourCost).HasColumnName("Job_Master_Job_Labour_Cost");

                entity.Property(e => e.JobMasterJobLabourCostVar).HasColumnName("Job_Master_Job_Labour_Cost_Var");

                entity.Property(e => e.JobMasterJobMaterialCost).HasColumnName("Job_Master_Job_Material_Cost");

                entity.Property(e => e.JobMasterJobMaterialCostVar).HasColumnName("Job_Master_Job_Material_Cost_Var");

                entity.Property(e => e.JobMasterJobMiscCost).HasColumnName("Job_Master_Job_Misc_Cost");

                entity.Property(e => e.JobMasterJobName)
                    .HasColumnName("Job_Master_Job_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobNumber)
                    .HasColumnName("Job_Master_Job_Number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobOpenInv).HasColumnName("Job_Master_Job_OpenInv");

                entity.Property(e => e.JobMasterJobOrgCompleteDate)
                    .HasColumnName("Job_Master_Job_OrgComplete_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobMasterJobOverHeadCost).HasColumnName("Job_Master_Job_OverHead_Cost");

                entity.Property(e => e.JobMasterJobOverHeadCostVar).HasColumnName("Job_Master_Job_OverHead_Cost_Var");

                entity.Property(e => e.JobMasterJobPayTermDays).HasColumnName("Job_Master_Job_PayTerm_Days");

                entity.Property(e => e.JobMasterJobPerInv).HasColumnName("Job_Master_Job_PerInv");

                entity.Property(e => e.JobMasterJobProfit).HasColumnName("Job_Master_Job_Profit");

                entity.Property(e => e.JobMasterJobRelativeNo).HasColumnName("Job_Master_Job_Relative_No");

                entity.Property(e => e.JobMasterJobRemarks)
                    .HasColumnName("Job_Master_Job_Remarks")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.JobMasterJobRetention).HasColumnName("Job_Master_Job_Retention");

                entity.Property(e => e.JobMasterJobRetentionPercentage).HasColumnName("Job_Master_Job_Retention_Percentage");

                entity.Property(e => e.JobMasterJobSalesMan).HasColumnName("Job_Master_Job_Sales_Man");

                entity.Property(e => e.JobMasterJobSalesManId).HasColumnName("Job_Master_Job_Sales_Man_ID");

                entity.Property(e => e.JobMasterJobStatus).HasColumnName("Job_Master_Job_Status");

                entity.Property(e => e.JobMasterJobStatusVal).HasColumnName("Job_Master_Job_StatusVal");

                entity.Property(e => e.JobMasterJobSupplierId).HasColumnName("Job_Master_Job_Supplier_ID");

                entity.Property(e => e.JobMasterJobTotalCost).HasColumnName("Job_Master_Job_Total_Cost");

                entity.Property(e => e.JobMasterJobTotalExpValue).HasColumnName("Job_Master_Job_TotalExp_Value");

                entity.Property(e => e.JobMasterJobTotalInvValue).HasColumnName("Job_Master_Job_TotalInv_Value");

                entity.Property(e => e.JobMasterJobTotalPayValue).HasColumnName("Job_Master_Job_TotalPay_Value");

                entity.Property(e => e.JobMasterJobTotalRecValue).HasColumnName("Job_Master_Job_TotalRec_Value");

                entity.Property(e => e.JobMasterJobType)
                    .HasColumnName("Job_Master_Job_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobMasterJobValue).HasColumnName("Job_Master_Job_Value");

                entity.Property(e => e.JobMasterJobWorkingDays).HasColumnName("Job_Master_Job_Working_Days");
            });

            modelBuilder.Entity<JobMaster1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Master1");

                entity.Property(e => e.JobMaster1ActualWeight).HasColumnName("Job_Master1_Actual_Weight");

                entity.Property(e => e.JobMaster1Awbno)
                    .HasColumnName("Job_Master1_AWBNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1CarrierId).HasColumnName("Job_Master1_Carrier_ID");

                entity.Property(e => e.JobMaster1ChargebleWeight).HasColumnName("Job_Master1_Chargeble_Weight");

                entity.Property(e => e.JobMaster1ConsigneeId).HasColumnName("Job_Master1_Consignee_ID");

                entity.Property(e => e.JobMaster1ContainerNo)
                    .HasColumnName("Job_Master1_Container_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1ContainerType)
                    .HasColumnName("Job_Master1_Container_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1Date)
                    .HasColumnName("Job_Master1_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobMaster1DelStatus).HasColumnName("Job_Master1_DelStatus");

                entity.Property(e => e.JobMaster1DesignationId).HasColumnName("Job_Master1_Designation_ID");

                entity.Property(e => e.JobMaster1FreightRate).HasColumnName("Job_Master1_Freight_Rate");

                entity.Property(e => e.JobMaster1JobCode).HasColumnName("Job_Master1_Job_Code");

                entity.Property(e => e.JobMaster1NoPackages).HasColumnName("Job_Master1_No_Packages");

                entity.Property(e => e.JobMaster1Remarks)
                    .HasColumnName("Job_Master1_Remarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1SealNo)
                    .HasColumnName("Job_Master1_Seal_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1Status).HasColumnName("Job_Master1_Status");

                entity.Property(e => e.JobMaster1Transit)
                    .HasColumnName("Job_Master1_Transit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMaster1Type)
                    .HasColumnName("Job_Master1_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Order");

                entity.Property(e => e.JobOrderCpoId).HasColumnName("Job_Order_CPO_ID");

                entity.Property(e => e.JobOrderDelStatus).HasColumnName("Job_Order_DelStatus");

                entity.Property(e => e.JobOrderExpectedEndDateTime)
                    .HasColumnName("Job_Order_Expected_EndDate_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobOrderId).HasColumnName("Job_Order_ID");

                entity.Property(e => e.JobOrderJobStartDateTime)
                    .HasColumnName("Job_Order_JobStartDate_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobOrderRemarks)
                    .HasColumnName("Job_Order_Remarks")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.JobOrderStaffCode).HasColumnName("Job_Order_StaffCode");
            });

            modelBuilder.Entity<JobOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Job_Order_Details");

                entity.Property(e => e.JobOrderDetailsDelStatus).HasColumnName("Job_Order_Details_DelStatus");

                entity.Property(e => e.JobOrderDetailsDetailsId).HasColumnName("Job_Order_Details_Details_ID");

                entity.Property(e => e.JobOrderDetailsIsEdited).HasColumnName("Job_Order_Details_IsEdited");

                entity.Property(e => e.JobOrderDetailsItemId).HasColumnName("Job_Order_Details_Item_ID");

                entity.Property(e => e.JobOrderDetailsOrderId).HasColumnName("Job_Order_Details_Order_ID");

                entity.Property(e => e.JobOrderDetailsQty).HasColumnName("Job_Order_Details_QTY");

                entity.Property(e => e.JobOrderDetailsRemarks)
                    .HasColumnName("Job_Order_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobOrderDetailsSlno).HasColumnName("Job_Order_Details_Slno");

                entity.Property(e => e.JobOrderDetailsUnitId).HasColumnName("Job_Order_Details_Unit_ID");
            });

            modelBuilder.Entity<JournalInvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Invoice_Details");

                entity.Property(e => e.JournalInvoiceDetailsAccNo)
                    .HasColumnName("Journal_Invoice_Details_AccNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceDetailsAmount).HasColumnName("Journal_Invoice_Details_Amount");

                entity.Property(e => e.JournalInvoiceDetailsDelStatus).HasColumnName("Journal_Invoice_Details_DelStatus");

                entity.Property(e => e.JournalInvoiceDetailsId)
                    .HasColumnName("Journal_Invoice_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalInvoiceDetailsIsEdit).HasColumnName("Journal_Invoice_Details_IsEdit");

                entity.Property(e => e.JournalInvoiceDetailsJobId).HasColumnName("Journal_Invoice_Details_Job_ID");

                entity.Property(e => e.JournalInvoiceDetailsNo)
                    .HasColumnName("Journal_Invoice_Details_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceDetailsRefNo)
                    .HasColumnName("Journal_Invoice_Details_RefNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceDetailsRemarks)
                    .HasColumnName("Journal_Invoice_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceDetailsSlNo).HasColumnName("Journal_Invoice_Details_SlNO");
            });

            modelBuilder.Entity<JournalInvoiceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Invoice_Master_");

                entity.Property(e => e.JournalInvoiceMasterCurrencyId).HasColumnName("Journal_Invoice_Master_Currency_ID");

                entity.Property(e => e.JournalInvoiceMasterDate)
                    .HasColumnName("Journal_Invoice_Master_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalInvoiceMasterDelStatus).HasColumnName("Journal_Invoice_Master_DelStatus");

                entity.Property(e => e.JournalInvoiceMasterId).HasColumnName("Journal_Invoice_Master_ID");

                entity.Property(e => e.JournalInvoiceMasterNarration)
                    .HasColumnName("Journal_Invoice_Master_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceMasterNo)
                    .HasColumnName("Journal_Invoice_Master_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceMasterRefNo)
                    .HasColumnName("Journal_Invoice_Master_RefNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceMasterSupplierId).HasColumnName("Journal_Invoice_Master_Supplier_ID");
            });

            modelBuilder.Entity<JournalSalesVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Sales_Voucher_");

                entity.Property(e => e.JournalSalesVoucherAmount).HasColumnName("Journal_Sales_Voucher_Amount");

                entity.Property(e => e.JournalSalesVoucherCurrencyValue).HasColumnName("Journal_Sales_Voucher_Currency_Value");

                entity.Property(e => e.JournalSalesVoucherDate)
                    .HasColumnName("Journal_Sales_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalSalesVoucherDelStatus).HasColumnName("Journal_Sales_Voucher_DelStatus");

                entity.Property(e => e.JournalSalesVoucherFsno).HasColumnName("Journal_Sales_Voucher_FSNO");

                entity.Property(e => e.JournalSalesVoucherMakingCharge).HasColumnName("Journal_Sales_Voucher_Making_Charge");

                entity.Property(e => e.JournalSalesVoucherMultiFactor).HasColumnName("Journal_Sales_Voucher_MultiFactor");

                entity.Property(e => e.JournalSalesVoucherNarration)
                    .HasColumnName("Journal_Sales_Voucher_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherNetWeight).HasColumnName("Journal_Sales_Voucher_Net_Weight");

                entity.Property(e => e.JournalSalesVoucherOunce).HasColumnName("Journal_Sales_Voucher_Ounce");

                entity.Property(e => e.JournalSalesVoucherRefNo)
                    .HasColumnName("Journal_Sales_Voucher_RefNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherSno)
                    .HasColumnName("Journal_Sales_Voucher_SNO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalSalesVoucherStatus)
                    .HasColumnName("Journal_Sales_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherSupplierId).HasColumnName("Journal_Sales_Voucher_Supplier_ID");

                entity.Property(e => e.JournalSalesVoucherType)
                    .HasColumnName("Journal_Sales_Voucher_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherUserId).HasColumnName("Journal_Sales_Voucher_User_ID");

                entity.Property(e => e.JournalSalesVoucherVid).HasColumnName("Journal_Sales_Voucher_VID");

                entity.Property(e => e.JournalSalesVoucherVreference)
                    .HasColumnName("Journal_Sales_Voucher_VReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JournalSalesVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Sales_Voucher_Details");

                entity.Property(e => e.JournalSalesVoucherDetailsAccNo)
                    .HasColumnName("Journal_Sales_Voucher_Details_AccNO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherDetailsAccSno).HasColumnName("Journal_Sales_Voucher_Details_AccSNO");

                entity.Property(e => e.JournalSalesVoucherDetailsAmount).HasColumnName("Journal_Sales_Voucher_Details_Amount");

                entity.Property(e => e.JournalSalesVoucherDetailsDelStatus).HasColumnName("Journal_Sales_Voucher_Details_DelStatus");

                entity.Property(e => e.JournalSalesVoucherDetailsDrCr)
                    .HasColumnName("Journal_Sales_Voucher_Details_DrCr")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherDetailsDrCrGram).HasColumnName("Journal_Sales_Voucher_Details_DrCrGram");

                entity.Property(e => e.JournalSalesVoucherDetailsFcAmount).HasColumnName("Journal_Sales_Voucher_Details_FC_Amount");

                entity.Property(e => e.JournalSalesVoucherDetailsFcRate).HasColumnName("Journal_Sales_Voucher_Details_FC_Rate");

                entity.Property(e => e.JournalSalesVoucherDetailsFsno).HasColumnName("Journal_Sales_Voucher_Details_FSNO");

                entity.Property(e => e.JournalSalesVoucherDetailsId).HasColumnName("Journal_Sales_Voucher_Details_ID");

                entity.Property(e => e.JournalSalesVoucherDetailsJobId).HasColumnName("Journal_Sales_Voucher_Details_Job_ID");

                entity.Property(e => e.JournalSalesVoucherDetailsLocationId).HasColumnName("Journal_Sales_Voucher_Details_Location_ID");

                entity.Property(e => e.JournalSalesVoucherDetailsNarration)
                    .HasColumnName("Journal_Sales_Voucher_Details_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherDetailsReference)
                    .HasColumnName("Journal_Sales_Voucher_Details_Reference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalSalesVoucherDetailsSno).HasColumnName("Journal_Sales_Voucher_Details_Sno");
            });

            modelBuilder.Entity<JournalVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Voucher");

                entity.Property(e => e.JournalVoucherAmount).HasColumnName("Journal_Voucher_Amount");

                entity.Property(e => e.JournalVoucherCostCenterId).HasColumnName("Journal_Voucher_CostCenter_ID");

                entity.Property(e => e.JournalVoucherCurrencyId).HasColumnName("Journal_Voucher_Currency_ID");

                entity.Property(e => e.JournalVoucherDate)
                    .HasColumnName("Journal_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalVoucherDelStatus).HasColumnName("Journal_Voucher_DelStatus");

                entity.Property(e => e.JournalVoucherDepreciationFrom)
                    .HasColumnName("Journal_Voucher_Depreciation_From")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalVoucherDepreciationTo)
                    .HasColumnName("Journal_Voucher_Depreciation_To")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalVoucherFsno).HasColumnName("Journal_Voucher_FSNO");

                entity.Property(e => e.JournalVoucherId).HasColumnName("Journal_Voucher_ID");

                entity.Property(e => e.JournalVoucherJobNo).HasColumnName("Journal_Voucher_Job_No");

                entity.Property(e => e.JournalVoucherLocationId).HasColumnName("Journal_Voucher_Location_ID");

                entity.Property(e => e.JournalVoucherNarration)
                    .HasColumnName("Journal_Voucher_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherRefNo)
                    .HasColumnName("Journal_Voucher_RefNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherSno)
                    .HasColumnName("Journal_Voucher_SNO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalVoucherStatus)
                    .HasColumnName("Journal_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherType)
                    .HasColumnName("Journal_Voucher_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherUserId).HasColumnName("Journal_Voucher_User_ID");

                entity.Property(e => e.JournalVoucherVrefNo)
                    .HasColumnName("Journal_Voucher_VRefNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JournalVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Journal_Voucher_Details");

                entity.Property(e => e.JournalVoucherDetailsAccNo)
                    .HasColumnName("Journal_Voucher_Details_AccNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherDetailsAccSno).HasColumnName("Journal_Voucher_Details_AccSNO");

                entity.Property(e => e.JournalVoucherDetailsAmount).HasColumnName("Journal_Voucher_Details_Amount");

                entity.Property(e => e.JournalVoucherDetailsCostCenterId).HasColumnName("Journal_Voucher_Details_CostCenter_ID");

                entity.Property(e => e.JournalVoucherDetailsDelStatus).HasColumnName("Journal_Voucher_Details_DelStatus");

                entity.Property(e => e.JournalVoucherDetailsDrCr)
                    .HasColumnName("Journal_Voucher_Details_DrCr")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherDetailsFcAmount).HasColumnName("Journal_Voucher_Details_FC_Amount");

                entity.Property(e => e.JournalVoucherDetailsFcRate).HasColumnName("Journal_Voucher_Details_FC_Rate");

                entity.Property(e => e.JournalVoucherDetailsFsno).HasColumnName("Journal_Voucher_Details_FSNO");

                entity.Property(e => e.JournalVoucherDetailsId).HasColumnName("Journal_Voucher_Details_ID");

                entity.Property(e => e.JournalVoucherDetailsJobId).HasColumnName("Journal_Voucher_Details_Job_ID");

                entity.Property(e => e.JournalVoucherDetailsLocationId).HasColumnName("Journal_Voucher_Details_Location_ID");

                entity.Property(e => e.JournalVoucherDetailsNarration)
                    .HasColumnName("Journal_Voucher_Details_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherDetailsReference)
                    .HasColumnName("Journal_Voucher_Details_Reference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JournalVoucherDetailsSno).HasColumnName("Journal_Voucher_Details_Sno");
            });

            modelBuilder.Entity<LanguageMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Language_Master");

                entity.Property(e => e.LanguageMasterDelStatus).HasColumnName("Language_Master_DelStatus");

                entity.Property(e => e.LanguageMasterDescription)
                    .HasColumnName("Language_Master_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageMasterId).HasColumnName("Language_Master_ID");
            });

            modelBuilder.Entity<LinkAccount>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LinkAccountAccDesc)
                    .HasColumnName("LinkAccount_ACC_DESc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LinkAccountAccKey)
                    .HasColumnName("LinkAccount_ACC_Key")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LinkAccountAccNo)
                    .HasColumnName("LinkAccount_ACC_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LinkAccountDelStatus).HasColumnName("LinkAccount_DelStatus");
            });

            modelBuilder.Entity<LocationMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Location_Master");

                entity.Property(e => e.LocationMasterLocationAddress)
                    .HasColumnName("Location_Master_Location_Address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationCashAccount)
                    .HasColumnName("Location_Master_Location_Cash_Account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationCostCenter)
                    .HasColumnName("Location_Master_Location_Cost_Center")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationDelStatus).HasColumnName("Location_Master_Location_DelStatus");

                entity.Property(e => e.LocationMasterLocationDeleted).HasColumnName("Location_Master_Location_Deleted");

                entity.Property(e => e.LocationMasterLocationEmail)
                    .HasColumnName("Location_Master_Location_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationFax)
                    .HasColumnName("Location_Master_Location_FAX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationId).HasColumnName("Location_Master_Location_ID");

                entity.Property(e => e.LocationMasterLocationName)
                    .HasColumnName("Location_Master_Location_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMasterLocationStatus).HasColumnName("Location_Master_Location_Status");

                entity.Property(e => e.LocationMasterLocationTelephone)
                    .HasColumnName("Location_Master_Location_Telephone")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufactureGoodEntryDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manufacture_GoodEntry_Details");

                entity.Property(e => e.ManufactureGoodEntryDetailsDelStatus).HasColumnName("Manufacture_GoodEntry_Details_DelStatus");

                entity.Property(e => e.ManufactureGoodEntryDetailsDetId).HasColumnName("Manufacture_GoodEntry_Details_DetID");

                entity.Property(e => e.ManufactureGoodEntryDetailsId).HasColumnName("Manufacture_GoodEntry_Details_ID");

                entity.Property(e => e.ManufactureGoodEntryDetailsKg).HasColumnName("Manufacture_GoodEntry_Details_KG");

                entity.Property(e => e.ManufactureGoodEntryDetailsMaterialId).HasColumnName("Manufacture_GoodEntry_Details_Material_ID");

                entity.Property(e => e.ManufactureGoodEntryDetailsMaterialId2).HasColumnName("Manufacture_GoodEntry_Details_Material_ID2");

                entity.Property(e => e.ManufactureGoodEntryDetailsQty).HasColumnName("Manufacture_GoodEntry_Details_QTY");

                entity.Property(e => e.ManufactureGoodEntryDetailsRemarks)
                    .HasColumnName("Manufacture_GoodEntry_Details_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureGoodEntryDetailsSno).HasColumnName("Manufacture_GoodEntry_Details_SNO");

                entity.Property(e => e.ManufactureGoodEntryDetailsUnitId).HasColumnName("Manufacture_GoodEntry_Details_Unit_ID");
            });

            modelBuilder.Entity<ManufactureGoodsEntryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manufacture_GoodsEntry_Master");

                entity.Property(e => e.ManufactureGoodsEntryMasterDelStatus).HasColumnName("Manufacture_GoodsEntry_Master_DelStatus");

                entity.Property(e => e.ManufactureGoodsEntryMasterEntryDate)
                    .HasColumnName("Manufacture_GoodsEntry_Master_EntryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManufactureGoodsEntryMasterId).HasColumnName("Manufacture_GoodsEntry_Master_ID");

                entity.Property(e => e.ManufactureGoodsEntryMasterLocationId).HasColumnName("Manufacture_GoodsEntry_Master_Location_ID");

                entity.Property(e => e.ManufactureGoodsEntryMasterRefNo)
                    .HasColumnName("Manufacture_GoodsEntry_Master_RefNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureGoodsEntryMasterRemarks)
                    .HasColumnName("Manufacture_GoodsEntry_Master_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufactureMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manufacture_Master");

                entity.Property(e => e.ManufactureMasterDelStatus).HasColumnName("Manufacture_Master_DelStatus");

                entity.Property(e => e.ManufactureMasterDeleted).HasColumnName("Manufacture_Master_Deleted");

                entity.Property(e => e.ManufactureMasterId).HasColumnName("Manufacture_Master_ID");

                entity.Property(e => e.ManufactureMasterName)
                    .HasColumnName("Manufacture_Master_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureMasterStatus).HasColumnName("Manufacture_Master_Status");

                entity.Property(e => e.ManufactureMasterUserId).HasColumnName("Manufacture_Master_User_ID");
            });

            modelBuilder.Entity<MasterAccountsTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MasterAccountsTableAcAcc)
                    .HasColumnName("MasterAccountsTable_AC_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableAccName)
                    .HasColumnName("MasterAccountsTable_AccName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableAccNo)
                    .HasColumnName("MasterAccountsTable_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableAccType)
                    .HasColumnName("MasterAccountsTable_AccType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableAssetDate)
                    .HasColumnName("MasterAccountsTable_Asset_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MasterAccountsTableAssetDepMode)
                    .HasColumnName("MasterAccountsTable_Asset_Dep_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableAssetDepValue).HasColumnName("MasterAccountsTable_Asset_Dep_Value");

                entity.Property(e => e.MasterAccountsTableAssetQty).HasColumnName("MasterAccountsTable_Asset_QTY");

                entity.Property(e => e.MasterAccountsTableAssetValue).HasColumnName("MasterAccountsTable_Asset_Value");

                entity.Property(e => e.MasterAccountsTableCostCenterId).HasColumnName("MasterAccountsTable_CostCenter_ID");

                entity.Property(e => e.MasterAccountsTableCostCenterSub).HasColumnName("MasterAccountsTable_CostCenterSub");

                entity.Property(e => e.MasterAccountsTableCurrencyId).HasColumnName("MasterAccountsTable_Currency_ID");

                entity.Property(e => e.MasterAccountsTableDateCreated)
                    .HasColumnName("MasterAccountsTable_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.MasterAccountsTableDelStatus).HasColumnName("MasterAccountsTable_DelStatus");

                entity.Property(e => e.MasterAccountsTableEdAcc)
                    .HasColumnName("MasterAccountsTable_ED_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableFsno).HasColumnName("MasterAccountsTable_FSNO");

                entity.Property(e => e.MasterAccountsTableGpAcc)
                    .HasColumnName("MasterAccountsTable_GP_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableImageKey)
                    .HasColumnName("MasterAccountsTable_ImageKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableIsAirAcc).HasColumnName("MasterAccountsTable_IsAirAcc");

                entity.Property(e => e.MasterAccountsTableIsAsset).HasColumnName("MasterAccountsTable_IsAsset");

                entity.Property(e => e.MasterAccountsTableIsSeaAcc).HasColumnName("MasterAccountsTable_IsSeaAcc");

                entity.Property(e => e.MasterAccountsTableLifeInYrs).HasColumnName("MasterAccountsTable_LifeInYrs");

                entity.Property(e => e.MasterAccountsTableMainHead)
                    .HasColumnName("MasterAccountsTable_MainHead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableManualCode)
                    .HasColumnName("MasterAccountsTable_Manual_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableOpenBalance).HasColumnName("MasterAccountsTable_OpenBalance");

                entity.Property(e => e.MasterAccountsTableRelativeNo)
                    .HasColumnName("MasterAccountsTable_RelativeNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableShowSuminTb).HasColumnName("MasterAccountsTable_ShowSuminTB");

                entity.Property(e => e.MasterAccountsTableSno)
                    .HasColumnName("MasterAccountsTable_Sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MasterAccountsTableSortNo).HasColumnName("MasterAccountsTable_SortNo");

                entity.Property(e => e.MasterAccountsTableStatus)
                    .HasColumnName("MasterAccountsTable_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableSubHead)
                    .HasColumnName("MasterAccountsTable_SubHead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableSystemAcc)
                    .HasColumnName("MasterAccountsTable_System_Acc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableTotalCredit).HasColumnName("MasterAccountsTable_Total_Credit");

                entity.Property(e => e.MasterAccountsTableTotalDebit).HasColumnName("MasterAccountsTable_Total_Debit");

                entity.Property(e => e.MasterAccountsTableUserId).HasColumnName("MasterAccountsTable_User_ID");
            });

            modelBuilder.Entity<MasterAccountsTableDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasterAccountsTable_Delete");

                entity.Property(e => e.MasterAccountsTableDeleteAcAcc)
                    .HasColumnName("MasterAccountsTable_Delete_AC_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteAccName)
                    .HasColumnName("MasterAccountsTable_Delete_AccName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteAccNo)
                    .HasColumnName("MasterAccountsTable_Delete_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteAccType)
                    .HasColumnName("MasterAccountsTable_Delete_AccType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteCurrencyId).HasColumnName("MasterAccountsTable_Delete_Currency_ID");

                entity.Property(e => e.MasterAccountsTableDeleteDateCreated)
                    .HasColumnName("MasterAccountsTable_Delete_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.MasterAccountsTableDeleteDelStatus).HasColumnName("MasterAccountsTable_Delete_DelStatus");

                entity.Property(e => e.MasterAccountsTableDeleteEdAcc)
                    .HasColumnName("MasterAccountsTable_Delete_ED_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteFsno).HasColumnName("MasterAccountsTable_Delete_FSNO");

                entity.Property(e => e.MasterAccountsTableDeleteGpAcc)
                    .HasColumnName("MasterAccountsTable_Delete_GP_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteImageKey)
                    .HasColumnName("MasterAccountsTable_Delete_ImageKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteIsAirAcc).HasColumnName("MasterAccountsTable_Delete_IsAirAcc");

                entity.Property(e => e.MasterAccountsTableDeleteIsSeaAcc).HasColumnName("MasterAccountsTable_Delete_IsSeaAcc");

                entity.Property(e => e.MasterAccountsTableDeleteMainHead)
                    .HasColumnName("MasterAccountsTable_Delete_MainHead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteManualCode)
                    .HasColumnName("MasterAccountsTable_Delete_Manual_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteOpenBalance).HasColumnName("MasterAccountsTable_Delete_OpenBalance");

                entity.Property(e => e.MasterAccountsTableDeleteRelativeNo)
                    .HasColumnName("MasterAccountsTable_Delete_Relative_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteSno).HasColumnName("MasterAccountsTable_Delete_Sno");

                entity.Property(e => e.MasterAccountsTableDeleteStatus)
                    .HasColumnName("MasterAccountsTable_Delete_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteSubHead)
                    .HasColumnName("MasterAccountsTable_Delete_SubHead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterAccountsTableDeleteSystemAcc)
                    .HasColumnName("MasterAccountsTable_Delete_SystemAcc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterAccountsTableDeleteTotalCredit).HasColumnName("MasterAccountsTable_Delete_Total_Credit");

                entity.Property(e => e.MasterAccountsTableDeleteTotalDebit).HasColumnName("MasterAccountsTable_Delete_Total_Debit");

                entity.Property(e => e.MasterAccountsTableDeleteUserId).HasColumnName("MasterAccountsTable_Delete_User_ID");
            });

            modelBuilder.Entity<MaterialsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Materials_Master");

                entity.Property(e => e.MaterialsMasterAcAcc)
                    .HasColumnName("Materials_Master_AC_Acc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterAccType)
                    .HasColumnName("Materials_Master_AccType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterAssetAcc)
                    .HasColumnName("Materials_Master_Asset_ACC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterCode)
                    .HasColumnName("Materials_Master_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterDateCreated)
                    .HasColumnName("Materials_Master_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaterialsMasterDelStatus).HasColumnName("Materials_Master_DelStatus");

                entity.Property(e => e.MaterialsMasterEdAcc)
                    .HasColumnName("Materials_Master_ED_Acc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterExpenseAcc)
                    .HasColumnName("Materials_Master_Expense_ACC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterFsno).HasColumnName("Materials_Master_FSNO");

                entity.Property(e => e.MaterialsMasterGpAcc)
                    .HasColumnName("Materials_Master_GP_ACC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterGroupAccNo)
                    .HasColumnName("Materials_Master_GroupAccNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterGroupPurchaseAcc)
                    .HasColumnName("Materials_Master_Group_Purchase_ACC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterId).HasColumnName("Materials_Master_ID");

                entity.Property(e => e.MaterialsMasterImageKey)
                    .HasColumnName("Materials_Master_ImageKey")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterLocationId).HasColumnName("Materials_Master_Location_ID");

                entity.Property(e => e.MaterialsMasterMainHead)
                    .HasColumnName("Materials_Master_MainHead")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterManualCode)
                    .HasColumnName("Materials_Master_Manual_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterManufactureCode)
                    .HasColumnName("Materials_Master_Manufacture_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterName)
                    .HasColumnName("Materials_Master_Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterOpeningStock).HasColumnName("Materials_Master_Opening_Stock");

                entity.Property(e => e.MaterialsMasterPack)
                    .HasColumnName("Materials_Master_Pack")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterPrice).HasColumnName("Materials_Master_Price");

                entity.Property(e => e.MaterialsMasterPriceDate)
                    .HasColumnName("Materials_Master_Price_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaterialsMasterRackId).HasColumnName("Materials_Master_Rack_ID");

                entity.Property(e => e.MaterialsMasterRelativeNo)
                    .HasColumnName("Materials_Master_RelativeNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterReorderLevel).HasColumnName("Materials_Master_Reorder_Level");

                entity.Property(e => e.MaterialsMasterStatus)
                    .HasColumnName("Materials_Master_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterSubHead)
                    .HasColumnName("Materials_Master_SubHead")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterSupplierCode)
                    .HasColumnName("Materials_Master_Supplier_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialsMasterSupplierId).HasColumnName("Materials_Master_Supplier_ID");

                entity.Property(e => e.MaterialsMasterSystemAcc)
                    .HasColumnName("Materials_Master_SystemAcc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialsMasterUserId).HasColumnName("Materials_Master_User_ID");
            });

            modelBuilder.Entity<MenuMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu_Master");

                entity.Property(e => e.MenuMasterArabic)
                    .HasColumnName("Menu_Master_Arabic")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuMasterDelStatus).HasColumnName("Menu_Master_DelStatus");

                entity.Property(e => e.MenuMasterHindi)
                    .HasColumnName("Menu_Master_Hindi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuMasterId).HasColumnName("Menu_Master_ID");

                entity.Property(e => e.MenuMasterLatin)
                    .HasColumnName("Menu_Master_Latin")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModelMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Model_Master");

                entity.Property(e => e.ModelMasterDelStatus).HasColumnName("Model_Master_DelStatus");

                entity.Property(e => e.ModelMasterDeleted).HasColumnName("Model_Master_Deleted");

                entity.Property(e => e.ModelMasterId).HasColumnName("Model_Master_ID");

                entity.Property(e => e.ModelMasterName)
                    .HasColumnName("Model_Master_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelMasterStatus).HasColumnName("Model_Master_Status");

                entity.Property(e => e.ModelMasterTypeId).HasColumnName("Model_Master_Type_ID");

                entity.Property(e => e.ModelMasterUserId).HasColumnName("Model_Master_User_ID");
            });

            modelBuilder.Entity<NatureOfBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NatureOfBusinessDelStatus).HasColumnName("NatureOfBusiness_DelStatus");

                entity.Property(e => e.NatureOfBusinessId).HasColumnName("NatureOfBusiness_ID");

                entity.Property(e => e.NatureOfBusinessNature)
                    .HasColumnName("NatureOfBusiness_Nature")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldBsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLD_BS_Master");

                entity.Property(e => e.OldBsMasterDelStatus).HasColumnName("OLD_BS_Master_DelStatus");

                entity.Property(e => e.OldBsMasterDescription)
                    .HasColumnName("OLD_BS_Master_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterFsno).HasColumnName("OLD_BS_Master_FSNO");

                entity.Property(e => e.OldBsMasterId).HasColumnName("OLD_BS_Master_ID");

                entity.Property(e => e.OldBsMasterPost)
                    .HasColumnName("OLD_BS_Master_Post")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterRefJv)
                    .HasColumnName("OLD_BS_Master_Ref_JV")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldBsMasterDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLD_BS_Master_Details");

                entity.Property(e => e.OldBsMasterDetailsAccNo)
                    .HasColumnName("OLD_BS_Master_Details_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterDetailsBcAmount).HasColumnName("OLD_BS_Master_Details_BC_Amount");

                entity.Property(e => e.OldBsMasterDetailsCrate).HasColumnName("OLD_BS_Master_Details_Crate");

                entity.Property(e => e.OldBsMasterDetailsDelStatus).HasColumnName("OLD_BS_Master_Details_DelStatus");

                entity.Property(e => e.OldBsMasterDetailsDrCrType)
                    .HasColumnName("OLD_BS_Master_Details_Dr_Cr_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterDetailsFcAmount).HasColumnName("OLD_BS_Master_Details_FC_Amount");

                entity.Property(e => e.OldBsMasterDetailsFsno).HasColumnName("OLD_BS_Master_Details_FSNO");

                entity.Property(e => e.OldBsMasterDetailsGroupName)
                    .HasColumnName("OLD_BS_Master_Details_Group_Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterDetailsId).HasColumnName("OLD_BS_Master_Details_ID");

                entity.Property(e => e.OldBsMasterDetailsNarration)
                    .HasColumnName("OLD_BS_Master_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldBsMasterDetailsSno).HasColumnName("OLD_BS_Master_Details_Sno");
            });

            modelBuilder.Entity<OpStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OP_Stock");

                entity.Property(e => e.OpStockBatch)
                    .HasColumnName("OP_Stock_Batch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpStockCost).HasColumnName("OP_Stock_Cost");

                entity.Property(e => e.OpStockDelStatus).HasColumnName("OP_Stock_DelStatus");

                entity.Property(e => e.OpStockExpDate)
                    .HasColumnName("OP_Stock_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpStockItemId).HasColumnName("OP_Stock_Item_ID");

                entity.Property(e => e.OpStockMaterialCode)
                    .HasColumnName("OP_Stock_Material_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpStockMaterialName)
                    .HasColumnName("OP_Stock_Material_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpStockPurchasePrice).HasColumnName("OP_Stock_Purchase_Price");

                entity.Property(e => e.OpStockRprice).HasColumnName("OP_Stock_Rprice");

                entity.Property(e => e.OpStockSlNo)
                    .HasColumnName("OP_Stock_SlNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpStockStock).HasColumnName("OP_Stock_Stock");

                entity.Property(e => e.OpStockUnitId).HasColumnName("OP_Stock_Unit_ID");

                entity.Property(e => e.OpStockWprice).HasColumnName("OP_Stock_Wprice");
            });

            modelBuilder.Entity<OpeningStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Opening_Stock");

                entity.Property(e => e.OpeningStockAmount).HasColumnName("Opening_Stock_Amount");

                entity.Property(e => e.OpeningStockBatchCode)
                    .HasColumnName("Opening_Stock_Batch_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningStockCRate).HasColumnName("Opening_Stock_C_Rate");

                entity.Property(e => e.OpeningStockCurrencyId).HasColumnName("Opening_Stock_Currency_ID");

                entity.Property(e => e.OpeningStockDelStatus).HasColumnName("Opening_Stock_DelStatus");

                entity.Property(e => e.OpeningStockExpDate)
                    .HasColumnName("Opening_Stock_ExpDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningStockFcAmount).HasColumnName("Opening_Stock_FC_Amount");

                entity.Property(e => e.OpeningStockFsno).HasColumnName("Opening_Stock_FSNO");

                entity.Property(e => e.OpeningStockIsEdit).HasColumnName("Opening_Stock_IsEdit");

                entity.Property(e => e.OpeningStockJobId).HasColumnName("Opening_Stock_Job_ID");

                entity.Property(e => e.OpeningStockLocationId).HasColumnName("Opening_Stock_Location_ID");

                entity.Property(e => e.OpeningStockMaterialId).HasColumnName("Opening_Stock_Material_ID");

                entity.Property(e => e.OpeningStockPosted)
                    .HasColumnName("Opening_Stock_Posted")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningStockPurchaseId)
                    .HasColumnName("Opening_Stock_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningStockQty).HasColumnName("Opening_Stock_QTY");

                entity.Property(e => e.OpeningStockRemakrs)
                    .HasColumnName("Opening_Stock_Remakrs")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningStockSno).HasColumnName("Opening_Stock_Sno");

                entity.Property(e => e.OpeningStockStockId).HasColumnName("Opening_Stock_Stock_ID");

                entity.Property(e => e.OpeningStockUnitId).HasColumnName("Opening_Stock_Unit_ID");

                entity.Property(e => e.OpeningStockUnitRate).HasColumnName("Opening_Stock_Unit_Rate");
            });

            modelBuilder.Entity<OpeningVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Opening_Voucher_Details");

                entity.Property(e => e.OpeningVoucherDetailsCredit).HasColumnName("Opening_Voucher_Details_Credit");

                entity.Property(e => e.OpeningVoucherDetailsDebit).HasColumnName("Opening_Voucher_Details_Debit");

                entity.Property(e => e.OpeningVoucherDetailsDelStatus).HasColumnName("Opening_Voucher_Details_DelStatus");

                entity.Property(e => e.OpeningVoucherDetailsDrCr)
                    .HasColumnName("Opening_Voucher_Details_DrCr")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningVoucherDetailsFsno).HasColumnName("Opening_Voucher_Details_FSNO");

                entity.Property(e => e.OpeningVoucherDetailsId).HasColumnName("Opening_Voucher_Details_ID");

                entity.Property(e => e.OpeningVoucherDetailsLastUpdateTime)
                    .HasColumnName("Opening_Voucher_Details_Last_UpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningVoucherDetailsOpId).HasColumnName("Opening_Voucher_Details_OP_ID");

                entity.Property(e => e.OpeningVoucherDetailsRefNo)
                    .HasColumnName("Opening_Voucher_Details_Ref_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningVoucherDetailsRemarks)
                    .HasColumnName("Opening_Voucher_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningVoucherDetailsUserId).HasColumnName("Opening_Voucher_Details_User_ID");

                entity.Property(e => e.OpeningVoucherDetailsVDate)
                    .HasColumnName("Opening_Voucher_Details_V_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningVoucherDetailsVoucherNo)
                    .HasColumnName("Opening_Voucher_Details_Voucher_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpeningVoucherMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Opening_Voucher_Master");

                entity.Property(e => e.OpeningVoucherMasterAccNo)
                    .HasColumnName("Opening_Voucher_Master_ACC_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningVoucherMasterCurrencyId).HasColumnName("Opening_Voucher_Master_Currency_ID");

                entity.Property(e => e.OpeningVoucherMasterDelStatus).HasColumnName("Opening_Voucher_Master_DelStatus");

                entity.Property(e => e.OpeningVoucherMasterFsno).HasColumnName("Opening_Voucher_Master_FSNO");

                entity.Property(e => e.OpeningVoucherMasterId).HasColumnName("Opening_Voucher_Master_ID");

                entity.Property(e => e.OpeningVoucherMasterLastUpdateTime)
                    .HasColumnName("Opening_Voucher_Master_Last_UpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningVoucherMasterOpBDate)
                    .HasColumnName("Opening_Voucher_Master_OpB_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningVoucherMasterRemarks)
                    .HasColumnName("Opening_Voucher_Master_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningVoucherMasterTotalCredit).HasColumnName("Opening_Voucher_Master_Total_Credit");

                entity.Property(e => e.OpeningVoucherMasterTotalDebit).HasColumnName("Opening_Voucher_Master_Total_Debit");

                entity.Property(e => e.OpeningVoucherMasterUserId).HasColumnName("Opening_Voucher_Master_User_ID");
            });

            modelBuilder.Entity<OptionsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Options_Master");

                entity.Property(e => e.OptionsMasterDelStatus).HasColumnName("Options_Master_DelStatus");

                entity.Property(e => e.OptionsMasterDescription)
                    .HasColumnName("Options_Master_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OptionsMasterFormName)
                    .HasColumnName("Options_Master_Form_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionsMasterFullDescription)
                    .HasColumnName("Options_Master_Full_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OptionsMasterId)
                    .HasColumnName("Options_Master_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OptionsMasterType)
                    .HasColumnName("Options_Master_Type")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Tracking");

                entity.Property(e => e.OrderTrackingDelStatus).HasColumnName("Order_Tracking_DelStatus");

                entity.Property(e => e.OrderTrackingFsno).HasColumnName("Order_Tracking_FSNO");

                entity.Property(e => e.OrderTrackingId)
                    .HasColumnName("Order_Tracking_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTrackingInQty).HasColumnName("Order_Tracking_IN_QTY");

                entity.Property(e => e.OrderTrackingJobId).HasColumnName("Order_Tracking_Job_ID");

                entity.Property(e => e.OrderTrackingLocationId).HasColumnName("Order_Tracking_Location_ID");

                entity.Property(e => e.OrderTrackingMaterialId).HasColumnName("Order_Tracking_Material_ID");

                entity.Property(e => e.OrderTrackingOutOty).HasColumnName("Order_Tracking_Out_OTY");

                entity.Property(e => e.OrderTrackingQty).HasColumnName("Order_Tracking_QTY");

                entity.Property(e => e.OrderTrackingUnit).HasColumnName("Order_Tracking_Unit");

                entity.Property(e => e.OrderTrackingVoucherDate)
                    .HasColumnName("Order_Tracking_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTrackingVoucherNo)
                    .HasColumnName("Order_Tracking_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTrackingVoucherType)
                    .HasColumnName("Order_Tracking_Voucher_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackageMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Package_Master_");

                entity.Property(e => e.PackageMasterDdcCode)
                    .HasColumnName("Package_Master_DDC_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PackageMasterDelStatus).HasColumnName("Package_Master_DelStatus");

                entity.Property(e => e.PackageMasterId)
                    .HasColumnName("Package_Master_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PackageMasterManufacturer)
                    .HasColumnName("Package_Master_Manufacturer")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PackageMasterPackageDetails)
                    .HasColumnName("Package_Master_PackageDetails")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PackageMasterPackageName)
                    .HasColumnName("Package_Master_PackageName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PackageMasterSupplierId).HasColumnName("Package_Master_Supplier_ID");
            });

            modelBuilder.Entity<Packages>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PackagesDelStatus).HasColumnName("Packages_DelStatus");

                entity.Property(e => e.PackagesDeleted).HasColumnName("Packages_Deleted");

                entity.Property(e => e.PackagesId).HasColumnName("Packages_ID");

                entity.Property(e => e.PackagesName)
                    .HasColumnName("Packages_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PackagesStatus).HasColumnName("Packages_Status");

                entity.Property(e => e.PackagesUserId).HasColumnName("Packages_User_ID");
            });

            modelBuilder.Entity<PaymentVoucher>(entity =>
            {
                entity.HasKey(e => e.PaymentVoucherSno);

                entity.ToTable("Payment_Voucher");

                entity.HasIndex(e => e.PaymentVoucherVoucherNo)
                    .HasName("UNIQUE_Payment_Voucher")
                    .IsUnique();

                entity.Property(e => e.PaymentVoucherSno).HasColumnName("Payment_Voucher_Sno");

                entity.Property(e => e.PaymentVoucherAllocationId).HasColumnName("Payment_Voucher_Allocation_ID");

                entity.Property(e => e.PaymentVoucherCrAcNo)
                    .HasColumnName("Payment_Voucher_CR_AC_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVoucherCrAmount).HasColumnName("Payment_Voucher_CR_Amount");

                entity.Property(e => e.PaymentVoucherCurrencyId).HasColumnName("Payment_Voucher_Currency_ID");

                entity.Property(e => e.PaymentVoucherDate)
                    .HasColumnName("Payment_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentVoucherDbAmount).HasColumnName("Payment_Voucher_DB_Amount");

                entity.Property(e => e.PaymentVoucherDelStatus).HasColumnName("Payment_Voucher_DelStatus");

                entity.Property(e => e.PaymentVoucherFcCrAmount).HasColumnName("Payment_Voucher_FC_CR_Amount");

                entity.Property(e => e.PaymentVoucherFcDbAmount).HasColumnName("Payment_Voucher_FC_DB_Amount");

                entity.Property(e => e.PaymentVoucherFsno).HasColumnName("Payment_Voucher_FSNO");

                entity.Property(e => e.PaymentVoucherLocationId).HasColumnName("Payment_Voucher_Location_ID");

                entity.Property(e => e.PaymentVoucherNarration)
                    .HasColumnName("Payment_Voucher_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVoucherUserId).HasColumnName("Payment_Voucher_User_ID");

                entity.Property(e => e.PaymentVoucherVoucherNo)
                    .IsRequired()
                    .HasColumnName("Payment_Voucher_Voucher_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVoucherVoucherRef)
                    .HasColumnName("Payment_Voucher_Voucher_Ref")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.PaymentVoucherVoucherNoNavigation)
                    .WithOne(p => p.PaymentVoucher)
                    .HasPrincipalKey<VouchersNumbers>(p => p.VouchersNumbersVNo)
                    .HasForeignKey<PaymentVoucher>(d => d.PaymentVoucherVoucherNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Voucher_Vouchers_Numbers");
            });

            modelBuilder.Entity<PaymentVoucherDetails>(entity =>
            {
                entity.ToTable("Payment_Voucher_Details");

                entity.Property(e => e.PaymentVoucherDetailsId).HasColumnName("Payment_Voucher_Details_ID");

                entity.Property(e => e.PaymentVocherDetailsDelStatus).HasColumnName("Payment_Vocher_Details_DelStatus");

                entity.Property(e => e.PaymentVoucherDetailsAcNo)
                    .HasColumnName("Payment_Voucher_Details_AC_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVoucherDetailsCrAmount).HasColumnName("Payment_Voucher_Details_CR_Amount");

                entity.Property(e => e.PaymentVoucherDetailsCrFcAmount).HasColumnName("Payment_Voucher_Details_CR_FC_Amount");

                entity.Property(e => e.PaymentVoucherDetailsDbAmount).HasColumnName("Payment_Voucher_Details_DB_Amount");

                entity.Property(e => e.PaymentVoucherDetailsDbFcAmount).HasColumnName("Payment_Voucher_Details_DB_FC_Amount");

                entity.Property(e => e.PaymentVoucherDetailsDepartmentId).HasColumnName("Payment_Voucher_Details_Department_ID");

                entity.Property(e => e.PaymentVoucherDetailsFsno).HasColumnName("Payment_Voucher_Details_FSNO");

                entity.Property(e => e.PaymentVoucherDetailsJobId).HasColumnName("Payment_Voucher_Details_Job_ID");

                entity.Property(e => e.PaymentVoucherDetailsLocationId).HasColumnName("Payment_Voucher_Details_Location_ID");

                entity.Property(e => e.PaymentVoucherDetailsNarration)
                    .HasColumnName("Payment_Voucher_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVoucherDetailsSno).HasColumnName("Payment_Voucher_Details_Sno");

                entity.Property(e => e.PaymentVoucherDetailsVoucherNo)
                    .IsRequired()
                    .HasColumnName("Payment_Voucher_Details_Voucher_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.PaymentVoucherDetailsVoucherNoNavigation)
                    .WithMany(p => p.PaymentVoucherDetails)
                    .HasPrincipalKey(p => p.VouchersNumbersVNo)
                    .HasForeignKey(d => d.PaymentVoucherDetailsVoucherNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Voucher_Details_Voucher_Number");
            });

            modelBuilder.Entity<PdcDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDC_Details");

                entity.Property(e => e.PdcDetailsBankAccountNo)
                    .HasColumnName("PDC_Details_Bank_Account_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsBuildingId).HasColumnName("PDC_Details_Building_ID");

                entity.Property(e => e.PdcDetailsChequeAmount).HasColumnName("PDC_Details_Cheque_Amount");

                entity.Property(e => e.PdcDetailsChequeBankName)
                    .HasColumnName("PDC_Details_Cheque_Bank_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsChequeNo)
                    .HasColumnName("PDC_Details_Cheque_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsChequeStatus)
                    .HasColumnName("PDC_Details_Cheque_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsContract)
                    .HasColumnName("PDC_Details_Contract")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsDelStatus).HasColumnName("PDC_Details_DelStatus");

                entity.Property(e => e.PdcDetailsFcChequeAmount).HasColumnName("PDC_Details_FC_Cheque_Amount");

                entity.Property(e => e.PdcDetailsFlatId).HasColumnName("PDC_Details_Flat_ID");

                entity.Property(e => e.PdcDetailsFsno).HasColumnName("PDC_Details_FSNO");

                entity.Property(e => e.PdcDetailsId).HasColumnName("PDC_Details_ID");

                entity.Property(e => e.PdcDetailsOldChequeStatus)
                    .HasColumnName("PDC_Details_Old_Cheque_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsPartyAccNo)
                    .HasColumnName("PDC_Details_PartyAccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsPdcVoucherDate)
                    .HasColumnName("PDC_Details_PDC_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PdcDetailsPdcVoucherId)
                    .HasColumnName("PDC_Details_PDC_Voucher_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsPdcVoucherNarration)
                    .HasColumnName("PDC_Details_PDC_Voucher_Narration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsTransDate)
                    .HasColumnName("PDC_Details_Trans_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PdcDetailsTransType)
                    .HasColumnName("PDC_Details_Trans_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsUserId).HasColumnName("PDC_Details_User_ID");

                entity.Property(e => e.PdcDetailsVNo)
                    .HasColumnName("PDC_Details_V_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcDetailsVType)
                    .HasColumnName("PDC_Details_V_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PdcVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDC_Voucher");

                entity.Property(e => e.PdcVoucherDelStatus).HasColumnName("PDC_Voucher_DelStatus");

                entity.Property(e => e.PdcVoucherFcPdcAmount).HasColumnName("PDC_Voucher_FC_PDC_Amount");

                entity.Property(e => e.PdcVoucherFsno).HasColumnName("PDC_Voucher_FSNO");

                entity.Property(e => e.PdcVoucherNarration)
                    .HasColumnName("PDC_Voucher_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PdcVoucherPdcAmount).HasColumnName("PDC_Voucher_PDC_Amount");

                entity.Property(e => e.PdcVoucherPdcDate)
                    .HasColumnName("PDC_Voucher_PDC_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PdcVoucherRef)
                    .HasColumnName("PDC_Voucher_Ref")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcVoucherSno).HasColumnName("PDC_Voucher_Sno");

                entity.Property(e => e.PdcVoucherUserId).HasColumnName("PDC_Voucher_User_ID");

                entity.Property(e => e.PdcVoucherVid)
                    .HasColumnName("PDC_Voucher_VID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PdcVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDC_Voucher_Details");

                entity.Property(e => e.PdcVoucherDetailsAccSno).HasColumnName("PDC_Voucher_Details_AccSNO");

                entity.Property(e => e.PdcVoucherDetailsAccno)
                    .HasColumnName("PDC_Voucher_Details_ACCNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcVoucherDetailsAmount).HasColumnName("PDC_Voucher_Details_Amount");

                entity.Property(e => e.PdcVoucherDetailsDelStatus).HasColumnName("PDC_Voucher_Details_DelStatus");

                entity.Property(e => e.PdcVoucherDetailsDetId)
                    .HasColumnName("PDC_Voucher_Details_Det_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PdcVoucherDetailsDrCr)
                    .HasColumnName("PDC_Voucher_Details_DrCr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PdcVoucherDetailsFcAmount).HasColumnName("PDC_Voucher_Details_FC_Amount");

                entity.Property(e => e.PdcVoucherDetailsNarration)
                    .HasColumnName("PDC_Voucher_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosStationSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POS_Station_Settings");

                entity.Property(e => e.PosStationSettingsBaudRate).HasColumnName("POS_Station_Settings_BaudRate");

                entity.Property(e => e.PosStationSettingsBillClosing)
                    .HasColumnName("POS_Station_Settings_BillClosing")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsClubGrid).HasColumnName("POS_Station_Settings_Club_Grid");

                entity.Property(e => e.PosStationSettingsCrBcopy).HasColumnName("POS_Station_Settings_CrBCopy");

                entity.Property(e => e.PosStationSettingsCsBcopy).HasColumnName("POS_Station_Settings_CsBCopy");

                entity.Property(e => e.PosStationSettingsDelStatus).HasColumnName("POS_Station_Settings_DelStatus");

                entity.Property(e => e.PosStationSettingsDisableVat).HasColumnName("POS_Station_Settings_DisableVAT");

                entity.Property(e => e.PosStationSettingsDisplayLines).HasColumnName("POS_Station_Settings_DisplayLines");

                entity.Property(e => e.PosStationSettingsEmulation)
                    .HasColumnName("POS_Station_Settings_Emulation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsEnablePrinter).HasColumnName("POS_Station_Settings_EnablePrinter");

                entity.Property(e => e.PosStationSettingsEnableVfd).HasColumnName("POS_Station_Settings_EnableVFD");

                entity.Property(e => e.PosStationSettingsFooter1)
                    .HasColumnName("POS_Station_Settings_Footer1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsFooter2)
                    .HasColumnName("POS_Station_Settings_Footer2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsFooter3)
                    .HasColumnName("POS_Station_Settings_Footer3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsFooter4)
                    .HasColumnName("POS_Station_Settings_Footer4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsHeader1)
                    .HasColumnName("POS_Station_Settings_Header1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsHeader2)
                    .HasColumnName("POS_Station_Settings_Header2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsHeader3)
                    .HasColumnName("POS_Station_Settings_Header3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsHeader4)
                    .HasColumnName("POS_Station_Settings_Header4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsId)
                    .HasColumnName("POS_Station_Settings_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PosStationSettingsParity)
                    .HasColumnName("POS_Station_Settings_Parity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsPrinterName)
                    .HasColumnName("POS_Station_Settings_PrinterName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsPrinterPort)
                    .HasColumnName("POS_Station_Settings_PrinterPort")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsPrinterType)
                    .HasColumnName("POS_Station_Settings_PrinterType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsReorderCheck).HasColumnName("POS_Station_Settings_Reorder_Check");

                entity.Property(e => e.PosStationSettingsReportCardSale).HasColumnName("POS_Station_Settings_ReportCardSale");

                entity.Property(e => e.PosStationSettingsReportCashSale).HasColumnName("POS_Station_Settings_ReportCashSale");

                entity.Property(e => e.PosStationSettingsReportCreditSales).HasColumnName("POS_Station_Settings_ReportCreditSales");

                entity.Property(e => e.PosStationSettingsReportGroupTotal).HasColumnName("POS_Station_Settings_ReportGroup_Total");

                entity.Property(e => e.PosStationSettingsReportItemTotal).HasColumnName("POS_Station_Settings_ReportItem_Total");

                entity.Property(e => e.PosStationSettingsScanner)
                    .HasColumnName("POS_Station_Settings_Scanner")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsShowBarCode).HasColumnName("POS_Station_Settings_ShowBarCode");

                entity.Property(e => e.PosStationSettingsShowDiscountColumn).HasColumnName("POS_Station_Settings_ShowDiscountColumn");

                entity.Property(e => e.PosStationSettingsShowUnit).HasColumnName("POS_Station_Settings_ShowUnit");

                entity.Property(e => e.PosStationSettingsShowVatcolumn).HasColumnName("POS_Station_Settings_ShowVATColumn");

                entity.Property(e => e.PosStationSettingsShowVattotal).HasColumnName("POS_Station_Settings_ShowVATTotal");

                entity.Property(e => e.PosStationSettingsStationName)
                    .HasColumnName("POS_Station_Settings_StationName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsVatInclusive).HasColumnName("POS_Station_Settings_VAT_Inclusive");

                entity.Property(e => e.PosStationSettingsVatPercentage).HasColumnName("POS_Station_Settings_VAT_Percentage");

                entity.Property(e => e.PosStationSettingsVfdDriver)
                    .HasColumnName("POS_Station_Settings_VFD_Driver")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosStationSettingsWelcomeMessage)
                    .HasColumnName("POS_Station_Settings_Welcome_Message")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrApprovalDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_Approval_Details");

                entity.Property(e => e.PrApprovalDetailsDelStatus).HasColumnName("PR_Approval_Details_DelStatus");

                entity.Property(e => e.PrApprovalDetailsId)
                    .HasColumnName("PR_Approval_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrApprovalDetailsReqId).HasColumnName("PR_Approval_Details_Req_ID");

                entity.Property(e => e.PrApprovalDetailsStatus)
                    .HasColumnName("PR_Approval_Details_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrApprovalDetailsUserId).HasColumnName("PR_Approval_Details_User_ID");
            });

            modelBuilder.Entity<PrUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_User");

                entity.Property(e => e.PrUserDelStatus).HasColumnName("PR_User_DelStatus");

                entity.Property(e => e.PrUserId)
                    .HasColumnName("PR_User_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrUserName)
                    .HasColumnName("PR_User_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrUserUallow).HasColumnName("PR_User_Uallow");

                entity.Property(e => e.PrUserUserId).HasColumnName("PR_User_User_ID");

                entity.Property(e => e.PrUserVoudType)
                    .HasColumnName("PR_User_VoudType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriceLevelMaster>(entity =>
            {
                entity.HasKey(e => e.PriceLevelMasterPriceLevelId);

                entity.ToTable("PriceLevel_Master");

                entity.Property(e => e.PriceLevelMasterPriceLevelId)
                    .HasColumnName("PriceLevel_Master_PriceLevel_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriceLevelMasterPriceLevelName)
                    .HasColumnName("PriceLevel_Master_PriceLevel_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriveLevelMasterPriceLevelDelStatus).HasColumnName("PriveLevel_Master_PriceLevel_DelStatus");
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product_List");

                entity.Property(e => e.ProductListBonus)
                    .HasColumnName("Product_List_Bonus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductListDelStatus).HasColumnName("Product_List_DelStatus");

                entity.Property(e => e.ProductListExpDate)
                    .HasColumnName("Product_List_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductListGroupHead)
                    .HasColumnName("Product_List_Group_Head")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductListId).HasColumnName("Product_List_ID");

                entity.Property(e => e.ProductListItemId).HasColumnName("Product_List_Item_ID");

                entity.Property(e => e.ProductListItemName)
                    .HasColumnName("Product_List_Item_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductListMoviCole)
                    .HasColumnName("Product_List_MoviCole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductListPackingSize)
                    .HasColumnName("Product_List_Packing_Size")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductListRPrice).HasColumnName("Product_List_R_Price");

                entity.Property(e => e.ProductListWPrice).HasColumnName("Product_List_W_Price");
            });

            modelBuilder.Entity<ProformaInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proforma_Invoice");

                entity.Property(e => e.ProformaInvoiceCpoAboutIt).HasColumnName("Proforma_Invoice_CPO_AboutIT");

                entity.Property(e => e.ProformaInvoiceCpoDeliveryTime)
                    .HasColumnName("Proforma_Invoice_CPO_DeliveryTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProformaInvoiceCurrencyId).HasColumnName("Proforma_Invoice_Currency_ID");

                entity.Property(e => e.ProformaInvoiceCustCode).HasColumnName("Proforma_Invoice_Cust_Code");

                entity.Property(e => e.ProformaInvoiceCustName)
                    .HasColumnName("Proforma_Invoice_Cust_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceDate)
                    .HasColumnName("Proforma_Invoice_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProformaInvoiceDelStatus).HasColumnName("Proforma_Invoice_DelStatus");

                entity.Property(e => e.ProformaInvoiceDiscountAmount).HasColumnName("Proforma_Invoice_Discount_Amount");

                entity.Property(e => e.ProformaInvoiceDiscountPercentage).HasColumnName("Proforma_Invoice_Discount_Percentage");

                entity.Property(e => e.ProformaInvoiceFsno).HasColumnName("Proforma_Invoice_FSNO");

                entity.Property(e => e.ProformaInvoiceGrandTotal).HasColumnName("Proforma_Invoice_Grand_Total");

                entity.Property(e => e.ProformaInvoiceId).HasColumnName("Proforma_Invoice_ID");

                entity.Property(e => e.ProformaInvoiceIsLocalPurchase).HasColumnName("Proforma_Invoice_IsLocalPurchase");

                entity.Property(e => e.ProformaInvoiceJobId).HasColumnName("Proforma_Invoice_Job_ID");

                entity.Property(e => e.ProformaInvoiceLocationId).HasColumnName("Proforma_Invoice_Location_ID");

                entity.Property(e => e.ProformaInvoiceLpoDate)
                    .HasColumnName("Proforma_Invoice_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProformaInvoiceLpoNo)
                    .HasColumnName("Proforma_Invoice_LPO_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNote)
                    .HasColumnName("Proforma_Invoice_Note")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoicePacking)
                    .HasColumnName("Proforma_Invoice_Packing")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceQuality)
                    .HasColumnName("Proforma_Invoice_Quality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceQuatationId)
                    .HasColumnName("Proforma_Invoice_Quatation_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceRemarks)
                    .HasColumnName("Proforma_Invoice_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceSalesManId).HasColumnName("Proforma_Invoice_Sales_Man_ID");

                entity.Property(e => e.ProformaInvoiceSubject)
                    .HasColumnName("Proforma_Invoice_Subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceTechnicalDetails)
                    .HasColumnName("Proforma_Invoice_Technical_Details")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceTerms)
                    .HasColumnName("Proforma_Invoice_Terms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceTotal).HasColumnName("Proforma_Invoice_Total");

                entity.Property(e => e.ProformaInvoiceTraining)
                    .HasColumnName("Proforma_Invoice_training")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceUserId).HasColumnName("Proforma_Invoice_User_ID");

                entity.Property(e => e.ProformaInvoiceWarranty)
                    .HasColumnName("Proforma_Invoice_Warranty")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProformaInvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proforma_Invoice_Details");

                entity.Property(e => e.ProformaInvoiceDetailsAmount).HasColumnName("Proforma_Invoice_Details_Amount");

                entity.Property(e => e.ProformaInvoiceDetailsDelStatus).HasColumnName("Proforma_Invoice_Details_DelStatus");

                entity.Property(e => e.ProformaInvoiceDetailsDeliveryQty).HasColumnName("Proforma_Invoice_Details_Delivery_QTY");

                entity.Property(e => e.ProformaInvoiceDetailsDescription)
                    .HasColumnName("Proforma_Invoice_Details_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceDetailsFcAmount).HasColumnName("Proforma_Invoice_Details_FC_Amount");

                entity.Property(e => e.ProformaInvoiceDetailsFsno).HasColumnName("Proforma_Invoice_Details_FSNO");

                entity.Property(e => e.ProformaInvoiceDetailsId).HasColumnName("Proforma_Invoice_Details_ID");

                entity.Property(e => e.ProformaInvoiceDetailsIsEdited).HasColumnName("Proforma_Invoice_Details_IsEdited");

                entity.Property(e => e.ProformaInvoiceDetailsItemId).HasColumnName("Proforma_Invoice_Details_Item_ID");

                entity.Property(e => e.ProformaInvoiceDetailsPodId).HasColumnName("Proforma_Invoice_Details_POD_ID");

                entity.Property(e => e.ProformaInvoiceDetailsQty).HasColumnName("Proforma_Invoice_Details_QTY");

                entity.Property(e => e.ProformaInvoiceDetailsQuotationDetId).HasColumnName("Proforma_Invoice_Details_Quotation_DetID");

                entity.Property(e => e.ProformaInvoiceDetailsRemarks)
                    .HasColumnName("Proforma_Invoice_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceDetailsSlNo).HasColumnName("Proforma_Invoice_Details_SlNo");

                entity.Property(e => e.ProformaInvoiceDetailsUnitId).HasColumnName("Proforma_Invoice_Details_Unit_ID");

                entity.Property(e => e.ProformaInvoiceDetailsUnitPrice).HasColumnName("Proforma_Invoice_Details_Unit_Price");
            });

            modelBuilder.Entity<ProgramSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Program_Settings");

                entity.Property(e => e.ProgramSettingsBoolValue).HasColumnName("Program_Settings_Bool_Value");

                entity.Property(e => e.ProgramSettingsCategory)
                    .HasColumnName("Program_Settings_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsDelStatus).HasColumnName("Program_Settings_DelStatus");

                entity.Property(e => e.ProgramSettingsDescription)
                    .HasColumnName("Program_Settings_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsFormId)
                    .HasColumnName("Program_Settings_FormID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsGenId).HasColumnName("Program_Settings_GenID");

                entity.Property(e => e.ProgramSettingsKeyValue)
                    .HasColumnName("Program_Settings_Key_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsNumValue).HasColumnName("Program_Settings_Num_Value");

                entity.Property(e => e.ProgramSettingsTableName)
                    .HasColumnName("Program_Settings_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsTextValue)
                    .HasColumnName("Program_Settings_Text_Value")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramSettingsValueType)
                    .HasColumnName("Program_Settings_Value_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgressiveInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Progressive_Invoice");

                entity.Property(e => e.ProgressiveInvoiceAmountDue).HasColumnName("Progressive_Invoice_AmountDue");

                entity.Property(e => e.ProgressiveInvoiceCumilativePer).HasColumnName("Progressive_Invoice_Cumilative_Per");

                entity.Property(e => e.ProgressiveInvoiceCumilativeVal).HasColumnName("Progressive_Invoice_Cumilative_Val");

                entity.Property(e => e.ProgressiveInvoiceCurComplPer).HasColumnName("Progressive_Invoice_Cur_Compl_Per");

                entity.Property(e => e.ProgressiveInvoiceCurComplVal).HasColumnName("Progressive_Invoice_Cur_Compl_Val");

                entity.Property(e => e.ProgressiveInvoiceCustId).HasColumnName("Progressive_Invoice_Cust_ID");

                entity.Property(e => e.ProgressiveInvoiceDelStatus).HasColumnName("Progressive_Invoice_DelStatus");

                entity.Property(e => e.ProgressiveInvoiceDescription)
                    .HasColumnName("Progressive_Invoice_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceDescriptionId).HasColumnName("Progressive_Invoice_Description_ID");

                entity.Property(e => e.ProgressiveInvoiceDiscPercentage).HasColumnName("Progressive_Invoice_Disc_Percentage");

                entity.Property(e => e.ProgressiveInvoiceDiscount).HasColumnName("Progressive_Invoice_Discount");

                entity.Property(e => e.ProgressiveInvoiceFsno).HasColumnName("Progressive_Invoice_FSNO");

                entity.Property(e => e.ProgressiveInvoiceId).HasColumnName("Progressive_Invoice_ID");

                entity.Property(e => e.ProgressiveInvoiceInvDate)
                    .HasColumnName("Progressive_Invoice_InvDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgressiveInvoiceInvNo)
                    .HasColumnName("Progressive_Invoice_InvNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceInvoiceType)
                    .HasColumnName("Progressive_Invoice_Invoice_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceIsVariation).HasColumnName("Progressive_Invoice_IsVariation");

                entity.Property(e => e.ProgressiveInvoiceJobId).HasColumnName("Progressive_Invoice_Job_ID");

                entity.Property(e => e.ProgressiveInvoiceLocationId).HasColumnName("Progressive_Invoice_Location_ID");

                entity.Property(e => e.ProgressiveInvoicePayAppNo)
                    .HasColumnName("Progressive_Invoice_PayAppNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoicePlRetention).HasColumnName("Progressive_Invoice_Pl_Retention");

                entity.Property(e => e.ProgressiveInvoicePlTotalAmount).HasColumnName("Progressive_Invoice_Pl_Total_Amount");

                entity.Property(e => e.ProgressiveInvoicePrevComplPer).HasColumnName("Progressive_Invoice_Prev_Compl_Per");

                entity.Property(e => e.ProgressiveInvoicePrevComplVal).HasColumnName("Progressive_Invoice_Prev_Compl_Val");

                entity.Property(e => e.ProgressiveInvoicePrintInv)
                    .HasColumnName("Progressive_Invoice_PrintInv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceProgress)
                    .HasColumnName("Progressive_Invoice_Progress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceReference)
                    .HasColumnName("Progressive_Invoice_Reference")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceStatus)
                    .HasColumnName("Progressive_Invoice_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveInvoiceTotAmount).HasColumnName("Progressive_Invoice_TotAmount");

                entity.Property(e => e.ProgressiveInvoiceTotal).HasColumnName("Progressive_Invoice_Total");

                entity.Property(e => e.ProgressiveInvoiceUserId).HasColumnName("Progressive_Invoice_User_ID");
            });

            modelBuilder.Entity<ProgressiveInvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Progressive_Invoice_Details");

                entity.Property(e => e.ProgressiveInvoiceDetailsAmount).HasColumnName("Progressive_Invoice_Details_Amount");

                entity.Property(e => e.ProgressiveInvoiceDetailsDelStatus).HasColumnName("Progressive_Invoice_Details_DelStatus");

                entity.Property(e => e.ProgressiveInvoiceDetailsDescrId).HasColumnName("Progressive_Invoice_Details_DescrID");

                entity.Property(e => e.ProgressiveInvoiceDetailsId).HasColumnName("Progressive_Invoice_Details_ID");

                entity.Property(e => e.ProgressiveInvoiceDetailsIsEdit).HasColumnName("Progressive_Invoice_Details_IsEdit");

                entity.Property(e => e.ProgressiveInvoiceDetailsJobDecId).HasColumnName("Progressive_Invoice_Details_JobDecID");

                entity.Property(e => e.ProgressiveInvoiceDetailsPerValue).HasColumnName("Progressive_Invoice_Details_PerValue");

                entity.Property(e => e.ProgressiveInvoiceDetailsPrDetId)
                    .HasColumnName("Progressive_Invoice_Details_PrDetID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProgressiveInvoiceDetailsRemarks)
                    .HasColumnName("Progressive_Invoice_Details_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectDescriptionMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Project_Description_Master");

                entity.Property(e => e.ProjectDescriptionMasterProjectDescriptionDelStatus).HasColumnName("Project_Description_Master_Project_Description_DelStatus");

                entity.Property(e => e.ProjectDescriptionMasterProjectDescriptionId).HasColumnName("Project_Description_Master_Project_Description_ID");

                entity.Property(e => e.ProjectDescriptionMasterProjectDescriptionName)
                    .HasColumnName("Project_Description_Master_Project_Description_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescriptionMasterProjectDescriptionSortOrder).HasColumnName("Project_Description_Master_Project_Description_SortOrder");

                entity.Property(e => e.ProjectDescriptionMasterProjectDescriptionStatus).HasColumnName("Project_Description_Master_Project_Description_Status");
            });

            modelBuilder.Entity<PurOrderRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PurOrder_Register");

                entity.Property(e => e.PurOrderRegisterAmount).HasColumnName("PurOrder_Register_Amount");

                entity.Property(e => e.PurOrderRegisterAssignedDate)
                    .HasColumnName("PurOrder_Register_Assigned_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurOrderRegisterDelStatus).HasColumnName("PurOrder_Register_DelStatus");

                entity.Property(e => e.PurOrderRegisterDetailId).HasColumnName("PurOrder_Register_Detail_ID");

                entity.Property(e => e.PurOrderRegisterFcAmount).HasColumnName("PurOrder_Register_FC_Amount");

                entity.Property(e => e.PurOrderRegisterFsno).HasColumnName("PurOrder_Register_FSNO");

                entity.Property(e => e.PurOrderRegisterId)
                    .HasColumnName("PurOrder_Register_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurOrderRegisterLocationId).HasColumnName("PurOrder_Register_Location_ID");

                entity.Property(e => e.PurOrderRegisterMaterialId).HasColumnName("PurOrder_Register_Material_ID");

                entity.Property(e => e.PurOrderRegisterOrderNo)
                    .HasColumnName("PurOrder_Register_OrderNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurOrderRegisterQtyIssued).HasColumnName("PurOrder_Register_QTY_Issued");

                entity.Property(e => e.PurOrderRegisterQtyOrder).HasColumnName("PurOrder_Register_QTY_Order");

                entity.Property(e => e.PurOrderRegisterRate).HasColumnName("PurOrder_Register_Rate");

                entity.Property(e => e.PurOrderRegisterRefVoucherNo)
                    .HasColumnName("PurOrder_Register_Ref_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurOrderRegisterStatus)
                    .HasColumnName("PurOrder_Register_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurOrderRegisterSupplierId).HasColumnName("PurOrder_Register_Supplier_ID");

                entity.Property(e => e.PurOrderRegisterTransType)
                    .HasColumnName("PurOrder_Register_Trans_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurOrderRegisterUnitId).HasColumnName("PurOrder_Register_Unit_ID");
            });

            modelBuilder.Entity<PurchaseExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Expense");

                entity.Property(e => e.PurchaseExpenseDelStatus).HasColumnName("Purchase_Expense_DelStatus");

                entity.Property(e => e.PurchaseExpenseDrCr)
                    .HasColumnName("Purchase_Expense_DrCr")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseExpenseFcTransAmount).HasColumnName("Purchase_Expense_FC_Trans_Amount");

                entity.Property(e => e.PurchaseExpenseIsEdit).HasColumnName("Purchase_Expense_IsEdit");

                entity.Property(e => e.PurchaseExpensePtcid).HasColumnName("Purchase_Expense_PTCID");

                entity.Property(e => e.PurchaseExpensePurId)
                    .HasColumnName("Purchase_Expense_Pur_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseExpenseSno).HasColumnName("Purchase_Expense_Sno");

                entity.Property(e => e.PurchaseExpenseTransAccNo)
                    .HasColumnName("Purchase_Expense_Trans_AccNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseExpenseTransAmount).HasColumnName("Purchase_Expense_Trans_Amount");

                entity.Property(e => e.PurchaseExpenseTransRemarks)
                    .HasColumnName("Purchase_Expense_Trans_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseJournalVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Journal_Voucher");

                entity.Property(e => e.PurchaseJournalVoucherCostCenterId).HasColumnName("Purchase_Journal_Voucher_CostCenter_ID");

                entity.Property(e => e.PurchaseJournalVoucherCurrencyId).HasColumnName("Purchase_Journal_Voucher_Currency_ID");

                entity.Property(e => e.PurchaseJournalVoucherDelStatus).HasColumnName("Purchase_Journal_Voucher_DelStatus");

                entity.Property(e => e.PurchaseJournalVoucherFsno).HasColumnName("Purchase_Journal_Voucher_FSNO");

                entity.Property(e => e.PurchaseJournalVoucherJobNo).HasColumnName("Purchase_Journal_Voucher_JobNo");

                entity.Property(e => e.PurchaseJournalVoucherJvAmount).HasColumnName("Purchase_Journal_Voucher_JV_Amount");

                entity.Property(e => e.PurchaseJournalVoucherJvDate)
                    .HasColumnName("Purchase_Journal_Voucher_JV_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseJournalVoucherJvid).HasColumnName("Purchase_Journal_Voucher_JVID");

                entity.Property(e => e.PurchaseJournalVoucherJvidRef)
                    .HasColumnName("Purchase_Journal_Voucher_JVID_Ref")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherJvsno)
                    .HasColumnName("Purchase_Journal_Voucher_JVSNO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaseJournalVoucherJvtype)
                    .HasColumnName("Purchase_Journal_Voucher_JVType")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherLocationId).HasColumnName("Purchase_Journal_Voucher_Location_ID");

                entity.Property(e => e.PurchaseJournalVoucherNarration)
                    .HasColumnName("Purchase_Journal_Voucher_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherRefNo)
                    .HasColumnName("Purchase_Journal_Voucher_RefNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherStatus)
                    .HasColumnName("Purchase_Journal_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherUserId).HasColumnName("Purchase_Journal_Voucher_User_ID");
            });

            modelBuilder.Entity<PurchaseJournalVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Journal_Voucher_Details");

                entity.Property(e => e.PurchaseJournalVoucherDetailsAccNo)
                    .HasColumnName("Purchase_Journal_Voucher_Details_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherDetailsAccSno).HasColumnName("Purchase_Journal_Voucher_Details_AccSNO");

                entity.Property(e => e.PurchaseJournalVoucherDetailsAmount).HasColumnName("Purchase_Journal_Voucher_Details_Amount");

                entity.Property(e => e.PurchaseJournalVoucherDetailsCostCenterId).HasColumnName("Purchase_Journal_Voucher_Details_CostCenter_ID");

                entity.Property(e => e.PurchaseJournalVoucherDetailsDelStatus).HasColumnName("Purchase_Journal_Voucher_Details_DelStatus");

                entity.Property(e => e.PurchaseJournalVoucherDetailsDrCr)
                    .HasColumnName("Purchase_Journal_Voucher_Details_DrCr")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherDetailsFcAmount).HasColumnName("Purchase_Journal_Voucher_Details_FC_Amount");

                entity.Property(e => e.PurchaseJournalVoucherDetailsFcRate).HasColumnName("Purchase_Journal_Voucher_Details_FC_Rate");

                entity.Property(e => e.PurchaseJournalVoucherDetailsFsno).HasColumnName("Purchase_Journal_Voucher_Details_FSNO");

                entity.Property(e => e.PurchaseJournalVoucherDetailsJobId).HasColumnName("Purchase_Journal_Voucher_Details_Job_ID");

                entity.Property(e => e.PurchaseJournalVoucherDetailsJvid).HasColumnName("Purchase_Journal_Voucher_Details_JVID");

                entity.Property(e => e.PurchaseJournalVoucherDetailsLocationId).HasColumnName("Purchase_Journal_Voucher_Details_Location_ID");

                entity.Property(e => e.PurchaseJournalVoucherDetailsNarration)
                    .HasColumnName("Purchase_Journal_Voucher_Details_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherDetailsReference)
                    .HasColumnName("Purchase_Journal_Voucher_Details_Reference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournalVoucherDetailsSno).HasColumnName("Purchase_Journal_Voucher_Details_SNO");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Order");

                entity.Property(e => e.PurchaseOrderApprovedBy).HasColumnName("Purchase_Order_Approved_By");

                entity.Property(e => e.PurchaseOrderApprovedDate)
                    .HasColumnName("Purchase_Order_Approved_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderApprovedStatus)
                    .HasColumnName("Purchase_Order_Approved_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderContactPersonV)
                    .HasColumnName("Purchase_Order_Contact_Person_V")
                    .HasMaxLength(100);

                entity.Property(e => e.PurchaseOrderCurrencyId).HasColumnName("Purchase_Order_Currency_ID");

                entity.Property(e => e.PurchaseOrderCustomerEnquiryIdN)
                    .HasColumnName("Purchase_Order_Customer_Enquiry_ID_N")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDelStatus).HasColumnName("Purchase_Order_DelStatus");

                entity.Property(e => e.PurchaseOrderDelivery)
                    .HasColumnName("Purchase_Order_Delivery")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDescription)
                    .HasColumnName("Purchase_Order_Description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDiscountPercentage).HasColumnName("Purchase_Order_Discount_Percentage");

                entity.Property(e => e.PurchaseOrderFooter)
                    .HasColumnName("Purchase_Order_Footer")
                    .HasMaxLength(200);

                entity.Property(e => e.PurchaseOrderFsno).HasColumnName("Purchase_Order_FSNO");

                entity.Property(e => e.PurchaseOrderHeader)
                    .HasColumnName("Purchase_Order_Header")
                    .HasMaxLength(200);

                entity.Property(e => e.PurchaseOrderIndentNo)
                    .HasColumnName("Purchase_Order_Indent_No")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderJobId).HasColumnName("Purchase_Order_Job_ID");

                entity.Property(e => e.PurchaseOrderLoacationId).HasColumnName("Purchase_Order_Loacation_ID");

                entity.Property(e => e.PurchaseOrderLpoDate)
                    .HasColumnName("Purchase_Order_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderLpoNo)
                    .HasColumnName("Purchase_Order_LPO_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNetAmount).HasColumnName("Purchase_Order_Net_Amount");

                entity.Property(e => e.PurchaseOrderPaymentTerms)
                    .HasColumnName("Purchase_Order_Payment_Terms")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderPoDate)
                    .HasColumnName("Purchase_Order_PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderPoId).HasColumnName("Purchase_Order_PO_ID");

                entity.Property(e => e.PurchaseOrderPoNo)
                    .HasColumnName("Purchase_Order_PO_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderPoStatus).HasColumnName("Purchase_Order_PO_Status");

                entity.Property(e => e.PurchaseOrderRfqIdN)
                    .HasColumnName("Purchase_Order_RFQ_ID_N")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderSupplierId).HasColumnName("Purchase_Order_Supplier_ID");

                entity.Property(e => e.PurchaseOrderSupplierQuatationIdN)
                    .HasColumnName("Purchase_Order_Supplier_Quatation_ID_N")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderTerms)
                    .HasColumnName("Purchase_Order_Terms")
                    .HasMaxLength(200);

                entity.Property(e => e.PurchaseOrderTermsAndCondition)
                    .HasColumnName("Purchase_Order_Terms_And_Condition")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderTotalAmount).HasColumnName("Purchase_Order_Total_Amount");

                entity.Property(e => e.PurchaseOrderUserId).HasColumnName("Purchase_Order_User_ID");
            });

            modelBuilder.Entity<PurchaseOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Order_Details");

                entity.Property(e => e.PurchaseOrderDetailsAmount).HasColumnName("Purchase_Order_Details_Amount");

                entity.Property(e => e.PurchaseOrderDetailsDelStatus).HasColumnName("Purchase_Order_Details_DelStatus");

                entity.Property(e => e.PurchaseOrderDetailsDescription)
                    .HasColumnName("Purchase_Order_Details_Description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDetailsFcAmount).HasColumnName("Purchase_Order_Details_FC_Amount");

                entity.Property(e => e.PurchaseOrderDetailsIsEdit).HasColumnName("Purchase_Order_Details_IsEdit");

                entity.Property(e => e.PurchaseOrderDetailsMaterialDescription)
                    .HasColumnName("Purchase_Order_Details_Material_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDetailsMaterialId).HasColumnName("Purchase_Order_Details_Material_ID");

                entity.Property(e => e.PurchaseOrderDetailsPoId).HasColumnName("Purchase_Order_Details_PO_ID");

                entity.Property(e => e.PurchaseOrderDetailsPoStatus)
                    .HasColumnName("Purchase_Order_Details_PO_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDetailsPodId).HasColumnName("Purchase_Order_Details_POD_ID");

                entity.Property(e => e.PurchaseOrderDetailsPreqId).HasColumnName("Purchase_Order_Details_Preq_ID");

                entity.Property(e => e.PurchaseOrderDetailsQuantity).HasColumnName("Purchase_Order_Details_Quantity");

                entity.Property(e => e.PurchaseOrderDetailsRate).HasColumnName("Purchase_Order_Details_Rate");

                entity.Property(e => e.PurchaseOrderDetailsSno).HasColumnName("Purchase_Order_Details_SNO");

                entity.Property(e => e.PurchaseOrderDetailsSrdId).HasColumnName("Purchase_Order_Details_SRD_ID");

                entity.Property(e => e.PurchaseOrderDetailsSupplierQatationDetailsId).HasColumnName("Purchase_Order_Details_Supplier_Qatation_Details_ID");

                entity.Property(e => e.PurchaseOrderDetailsUnitId).HasColumnName("Purchase_Order_Details_Unit_ID");
            });

            modelBuilder.Entity<PurchaseRequisition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Requisition");

                entity.Property(e => e.PurchaseRequisitionDelStatus).HasColumnName("Purchase_Requisition_DelStatus");

                entity.Property(e => e.PurchaseRequisitionJobId).HasColumnName("Purchase_Requisition_Job_ID");

                entity.Property(e => e.PurchaseRequisitionPurchaseRequesId).HasColumnName("Purchase_Requisition_Purchase_Reques_ID");

                entity.Property(e => e.PurchaseRequisitionRemarks)
                    .HasColumnName("Purchase_Requisition_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseRequisitionRequestedBy).HasColumnName("Purchase_Requisition_Requested_By");

                entity.Property(e => e.PurchaseRequisitionRequisitionDate)
                    .HasColumnName("Purchase_Requisition_Requisition_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseRequisitionStaffCode).HasColumnName("Purchase_Requisition_Staff_Code");

                entity.Property(e => e.PurchaseRequisitionSubJobId).HasColumnName("Purchase_Requisition_Sub_Job_ID");

                entity.Property(e => e.PurchaseRequisitionSupplierCode).HasColumnName("Purchase_Requisition_Supplier_Code");
            });

            modelBuilder.Entity<PurchaseRequisitionDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Requisition_Details");

                entity.Property(e => e.PurchaseRequisitionDetailsDelStatus).HasColumnName("Purchase_Requisition_Details_DelStatus");

                entity.Property(e => e.PurchaseRequisitionDetailsIsEdit).HasColumnName("Purchase_Requisition_Details_IsEdit");

                entity.Property(e => e.PurchaseRequisitionDetailsItemId).HasColumnName("Purchase_Requisition_Details_Item_ID");

                entity.Property(e => e.PurchaseRequisitionDetailsItemName)
                    .HasColumnName("Purchase_Requisition_Details_Item_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseRequisitionDetailsJobIdDetail).HasColumnName("Purchase_Requisition_Details_Job_ID_Detail");

                entity.Property(e => e.PurchaseRequisitionDetailsPurchaseRequesDetailId).HasColumnName("Purchase_Requisition_Details_Purchase_Reques_Detail_ID");

                entity.Property(e => e.PurchaseRequisitionDetailsPurchaseRequesId).HasColumnName("Purchase_Requisition_Details_Purchase_Reques_ID");

                entity.Property(e => e.PurchaseRequisitionDetailsQty)
                    .HasColumnName("Purchase_Requisition_Details_QTY")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PurchaseRequisitionDetailsRequiredDate)
                    .HasColumnName("Purchase_Requisition_Details_Required_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseRequisitionDetailsRequiredStatus)
                    .HasColumnName("Purchase_Requisition_Details_Required_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseRequisitionDetailsSlno).HasColumnName("Purchase_Requisition_Details_Slno");

                entity.Property(e => e.PurchaseRequisitionDetailsSrdId).HasColumnName("Purchase_Requisition_Details_SRD_ID");

                entity.Property(e => e.PurchaseRequisitionDetailsStock).HasColumnName("Purchase_Requisition_Details_Stock");

                entity.Property(e => e.PurchaseRequisitionDetailsUnitId).HasColumnName("Purchase_Requisition_Details_Unit_ID");
            });

            modelBuilder.Entity<PurchaseReturnVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Return_Voucher");

                entity.Property(e => e.PurchaseReturnVoucherDelStatus).HasColumnName("Purchase_Return_Voucher_DelStatus");

                entity.Property(e => e.PurchaseReturnVoucherDiscount).HasColumnName("Purchase_Return_Voucher_Discount");

                entity.Property(e => e.PurchaseReturnVoucherExcludeVat).HasColumnName("Purchase_Return_Voucher_ExcludeVAT");

                entity.Property(e => e.PurchaseReturnVoucherFcDiscAmount).HasColumnName("Purchase_Return_Voucher_FC_Disc_Amount");

                entity.Property(e => e.PurchaseReturnVoucherFcNetAmount).HasColumnName("Purchase_Return_Voucher_FC_NetAmount");

                entity.Property(e => e.PurchaseReturnVoucherFcRate).HasColumnName("Purchase_Return_Voucher_FC_Rate");

                entity.Property(e => e.PurchaseReturnVoucherFsno).HasColumnName("Purchase_Return_Voucher_FSNO");

                entity.Property(e => e.PurchaseReturnVoucherGrno)
                    .HasColumnName("Purchase_Return_Voucher_GRNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherGrossAmount).HasColumnName("Purchase_Return_Voucher_GrossAmount");

                entity.Property(e => e.PurchaseReturnVoucherHandlingCharges).HasColumnName("Purchase_Return_Voucher_HandlingCharges");

                entity.Property(e => e.PurchaseReturnVoucherId)
                    .HasColumnName("Purchase_Return_Voucher_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaseReturnVoucherLocationId).HasColumnName("Purchase_Return_Voucher_Location_ID");

                entity.Property(e => e.PurchaseReturnVoucherNarration)
                    .HasColumnName("Purchase_Return_Voucher_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherNetAmount).HasColumnName("Purchase_Return_Voucher_NetAmount");

                entity.Property(e => e.PurchaseReturnVoucherRetDate)
                    .HasColumnName("Purchase_Return_Voucher_Ret_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseReturnVoucherRetId)
                    .HasColumnName("Purchase_Return_Voucher_Ret_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherSpId).HasColumnName("Purchase_Return_Voucher_SP_ID");

                entity.Property(e => e.PurchaseReturnVoucherStatus)
                    .HasColumnName("Purchase_Return_Voucher_Status")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherSupInvNo)
                    .HasColumnName("Purchase_Return_Voucher_SupInvNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherTransportCost).HasColumnName("Purchase_Return_Voucher_TransportCost");

                entity.Property(e => e.PurchaseReturnVoucherUserId).HasColumnName("Purchase_Return_Voucher_User_ID");

                entity.Property(e => e.PurchaseReturnVoucherVatAmount).HasColumnName("Purchase_Return_Voucher_VAT_Amount");

                entity.Property(e => e.PurchaseReturnVoucherVatNo)
                    .HasColumnName("Purchase_Return_Voucher_VAT_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherVatPercentage).HasColumnName("Purchase_Return_Voucher_VAT_Percentage");

                entity.Property(e => e.PurchaseReturnVoucherVatRoundAmt).HasColumnName("Purchase_Return_Voucher_VAT_RoundAmt");

                entity.Property(e => e.PurchaseReturnVoucherVatRoundSign)
                    .HasColumnName("Purchase_Return_Voucher_VAT_RoundSign")
                    .HasMaxLength(1);

                entity.Property(e => e.PurchaseReturnVoucherVoucherDate)
                    .HasColumnName("Purchase_Return_Voucher_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseReturnVoucherVoucherId)
                    .HasColumnName("Purchase_Return_Voucher_Voucher_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherVoucherType)
                    .HasColumnName("Purchase_Return_Voucher_Voucher_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseReturnVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Return_Voucher_Details");

                entity.Property(e => e.PurchaseReturnVoucherDetailsAmount).HasColumnName("Purchase_Return_Voucher_Details_Amount");

                entity.Property(e => e.PurchaseReturnVoucherDetailsBatch)
                    .HasColumnName("Purchase_Return_Voucher_Details_Batch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherDetailsBatchCode)
                    .HasColumnName("Purchase_Return_Voucher_Details_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherDetailsDelStatus).HasColumnName("Purchase_Return_Voucher_Details_DelStatus");

                entity.Property(e => e.PurchaseReturnVoucherDetailsExpDate)
                    .HasColumnName("Purchase_Return_Voucher_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseReturnVoucherDetailsFcAmount).HasColumnName("Purchase_Return_Voucher_Details_FC_Amount");

                entity.Property(e => e.PurchaseReturnVoucherDetailsFocQty).HasColumnName("Purchase_Return_Voucher_Details_FOC_QTY");

                entity.Property(e => e.PurchaseReturnVoucherDetailsJobId).HasColumnName("Purchase_Return_Voucher_Details_Job_ID");

                entity.Property(e => e.PurchaseReturnVoucherDetailsMaterialId).HasColumnName("Purchase_Return_Voucher_Details_Material_ID");

                entity.Property(e => e.PurchaseReturnVoucherDetailsPurQty).HasColumnName("Purchase_Return_Voucher_Details_PUR_QTY");

                entity.Property(e => e.PurchaseReturnVoucherDetailsQty).HasColumnName("Purchase_Return_Voucher_Details_QTY");

                entity.Property(e => e.PurchaseReturnVoucherDetailsRate).HasColumnName("Purchase_Return_Voucher_Details_Rate");

                entity.Property(e => e.PurchaseReturnVoucherDetailsRemarks)
                    .HasColumnName("Purchase_Return_Voucher_Details_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherDetailsRetId)
                    .HasColumnName("Purchase_Return_Voucher_Details_Ret_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseReturnVoucherDetailsSno).HasColumnName("Purchase_Return_Voucher_Details_Sno");

                entity.Property(e => e.PurchaseReturnVoucherDetailsUnitId).HasColumnName("Purchase_Return_Voucher_Details_Unit_ID");

                entity.Property(e => e.PurchaseReturnVoucherDetailsVatAmount).HasColumnName("Purchase_Return_Voucher_Details_VAT_Amount");

                entity.Property(e => e.PurchaseReturnVoucherDetailsVatPercetage).HasColumnName("Purchase_Return_Voucher_Details_VAT_Percetage");

                entity.Property(e => e.PurchaseReturnVoucherDetailsVoucherNo)
                    .HasColumnName("Purchase_Return_Voucher_Details_VoucherNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseVoucher>(entity =>
            {
                entity.HasKey(e => e.PurchaseVoucherPurId);

                entity.ToTable("Purchase_Voucher");

                entity.HasIndex(e => e.PurchaseVoucherPurchaseId)
                    .HasName("UniquePaymenPurID")
                    .IsUnique();

                entity.Property(e => e.PurchaseVoucherPurId).HasColumnName("Purchase_Voucher_Pur_ID");

                entity.Property(e => e.PurchaseVoucherActualAmount).HasColumnName("Purchase_Voucher_Actual_Amount");

                entity.Property(e => e.PurchaseVoucherBatchCode)
                    .HasColumnName("Purchase_Voucher_Batch_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherCashSupplierName)
                    .HasColumnName("Purchase_Voucher_Cash_Supplier_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.PurchaseVoucherCompanyId).HasColumnName("Purchase_Voucher_Company_ID");

                entity.Property(e => e.PurchaseVoucherCurrencyId).HasColumnName("Purchase_Voucher_Currency_ID");

                entity.Property(e => e.PurchaseVoucherDayBookNo)
                    .HasColumnName("Purchase_Voucher_Day_Book_no")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDelStatus).HasColumnName("Purchase_Voucher_DelStatus");

                entity.Property(e => e.PurchaseVoucherDescription)
                    .HasColumnName("Purchase_Voucher_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDisAcNo)
                    .HasColumnName("Purchase_Voucher_Dis_AC_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDisAmount).HasColumnName("Purchase_Voucher_Dis_Amount");

                entity.Property(e => e.PurchaseVoucherDisYn)
                    .HasColumnName("Purchase_Voucher_Dis_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PurchaseVoucherDiscountPercentage)
                    .HasColumnName("Purchase_Voucher_Discount_Percentage")
                    .HasColumnType("numeric(4, 4)");

                entity.Property(e => e.PurchaseVoucherDrAccNo).HasColumnName("Purchase_Voucher_DR_ACC_NO");

                entity.Property(e => e.PurchaseVoucherDrAmount).HasColumnName("Purchase_Voucher_DR_Amount");

                entity.Property(e => e.PurchaseVoucherExcludeVat).HasColumnName("Purchase_Voucher_Exclude_VAT");

                entity.Property(e => e.PurchaseVoucherFcActualAmount).HasColumnName("Purchase_Voucher_FC_Actual_Amount");

                entity.Property(e => e.PurchaseVoucherFcDisAmount).HasColumnName("Purchase_Voucher_FC_Dis_Amount");

                entity.Property(e => e.PurchaseVoucherFcDrAmount).HasColumnName("Purchase_Voucher_FC_DR_Amount");

                entity.Property(e => e.PurchaseVoucherFcNetAmount).HasColumnName("Purchase_Voucher_FC_Net_Amount");

                entity.Property(e => e.PurchaseVoucherFcRate).HasColumnName("Purchase_Voucher_FC_Rate");

                entity.Property(e => e.PurchaseVoucherFcSpAmount).HasColumnName("Purchase_Voucher_FC_SP_Amount");

                entity.Property(e => e.PurchaseVoucherFsno).HasColumnName("Purchase_Voucher_FSNO");

                entity.Property(e => e.PurchaseVoucherGrDate)
                    .HasColumnName("Purchase_Voucher_GR_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherGrNo)
                    .HasColumnName("Purchase_Voucher_GR_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherGrnoTmp)
                    .HasColumnName("Purchase_Voucher_GRNO_TMP")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherHandlingCharges).HasColumnName("Purchase_Voucher_Handling_Charges");

                entity.Property(e => e.PurchaseVoucherIssedId).HasColumnName("Purchase_Voucher_Issed_ID");

                entity.Property(e => e.PurchaseVoucherJobDirectPurchase).HasColumnName("Purchase_Voucher_Job_Direct_Purchase");

                entity.Property(e => e.PurchaseVoucherJobId).HasColumnName("Purchase_Voucher_Job_ID");

                entity.Property(e => e.PurchaseVoucherLocationId).HasColumnName("Purchase_Voucher_Location_ID");

                entity.Property(e => e.PurchaseVoucherLpoDate)
                    .HasColumnName("Purchase_Voucher_LPO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherLpoNo)
                    .HasColumnName("Purchase_Voucher_LPO_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherNetAmount).HasColumnName("Purchase_Voucher_Net_Amount");

                entity.Property(e => e.PurchaseVoucherPoNo).HasColumnName("Purchase_Voucher_PO_No");

                entity.Property(e => e.PurchaseVoucherPurchaseDate)
                    .HasColumnName("Purchase_Voucher_Purchase_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherPurchaseId)
                    .IsRequired()
                    .HasColumnName("Purchase_Voucher_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherPurchaseIdNum).HasColumnName("Purchase_Voucher_Purchase_ID_Num");

                entity.Property(e => e.PurchaseVoucherPurchaseRef)
                    .HasColumnName("Purchase_Voucher_Purchase_Ref")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherPurchaseType)
                    .HasColumnName("Purchase_Voucher_Purchase_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherQuatationDate)
                    .HasColumnName("Purchase_Voucher_Quatation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherQuatationNo)
                    .HasColumnName("Purchase_Voucher_Quatation_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherSpAccNo)
                    .HasColumnName("Purchase_Voucher_SP_ACC_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherSpAmount).HasColumnName("Purchase_Voucher_SP_Amount");

                entity.Property(e => e.PurchaseVoucherSpId).HasColumnName("Purchase_Voucher_SP_ID");

                entity.Property(e => e.PurchaseVoucherStatus)
                    .HasColumnName("Purchase_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PurchaseVoucherSupplyInvoiceNo)
                    .HasColumnName("Purchase_Voucher_Supply_Invoice_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherTransportCost).HasColumnName("Purchase_Voucher_Transport_Cost");

                entity.Property(e => e.PurchaseVoucherUserId).HasColumnName("Purchase_Voucher_User_ID");

                entity.Property(e => e.PurchaseVoucherVatAmount).HasColumnName("Purchase_Voucher_VAT_Amount");

                entity.Property(e => e.PurchaseVoucherVatNo)
                    .HasColumnName("Purchase_Voucher_VAT_No")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherVatPercentage).HasColumnName("Purchase_Voucher_VAT_Percentage");

                entity.Property(e => e.PurchaseVoucherVatRoundAmount).HasColumnName("Purchase_Voucher_VAT_RoundAmount");

                entity.Property(e => e.PurchaseVoucherVatRoundSign)
                    .HasColumnName("Purchase_Voucher_VAT_RoundSign")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.PurchaseVoucherSp)
                    .WithMany(p => p.PurchaseVoucher)
                    .HasForeignKey(d => d.PurchaseVoucherSpId)
                    .HasConstraintName("FK_Purchase_Voucher_Supplier");
            });

            modelBuilder.Entity<PurchaseVoucherDetails>(entity =>
            {
                entity.HasKey(e => e.PurchaseVoucherDetailsPurcahseDetailsId);

                entity.ToTable("Purchase_Voucher_Details");

                entity.Property(e => e.PurchaseVoucherDetailsPurcahseDetailsId).HasColumnName("Purchase_Voucher_Details_Purcahse_Details_ID");

                entity.Property(e => e.PurchaseVoucherDetailsAmount).HasColumnName("Purchase_Voucher_Details_Amount");

                entity.Property(e => e.PurchaseVoucherDetailsAssetAcc)
                    .HasColumnName("Purchase_Voucher_Details_Asset_ACC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsBatchCode)
                    .HasColumnName("Purchase_Voucher_Details_Batch_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsCompanyId).HasColumnName("Purchase_Voucher_Details_Company_ID");

                entity.Property(e => e.PurchaseVoucherDetailsDelStatus).HasColumnName("Purchase_Voucher_Details_DelStatus");

                entity.Property(e => e.PurchaseVoucherDetailsDiscountAmoutPurchase).HasColumnName("Purchase_Voucher_Details_Discount_Amout_Purchase");

                entity.Property(e => e.PurchaseVoucherDetailsExpiryDate)
                    .HasColumnName("Purchase_Voucher_Details_Expiry_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherDetailsFcAmount).HasColumnName("Purchase_Voucher_Details_FC_Amount");

                entity.Property(e => e.PurchaseVoucherDetailsFcSmAmount).HasColumnName("Purchase_Voucher_Details_FC_SM_Amount");

                entity.Property(e => e.PurchaseVoucherDetailsFcSmRate).HasColumnName("Purchase_Voucher_Details_FC_SM_Rate");

                entity.Property(e => e.PurchaseVoucherDetailsFoc).HasColumnName("Purchase_Voucher_Details_FOC");

                entity.Property(e => e.PurchaseVoucherDetailsFsno).HasColumnName("Purchase_Voucher_Details_FSNO");

                entity.Property(e => e.PurchaseVoucherDetailsGrnNo)
                    .HasColumnName("Purchase_Voucher_Details_GRN_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsIsEdit).HasColumnName("Purchase_Voucher_Details_IsEdit");

                entity.Property(e => e.PurchaseVoucherDetailsLandingCost).HasColumnName("Purchase_Voucher_Details_Landing_Cost");

                entity.Property(e => e.PurchaseVoucherDetailsLandingCostLocalCurrency).HasColumnName("Purchase_Voucher_Details_Landing_Cost_Local_Currency");

                entity.Property(e => e.PurchaseVoucherDetailsLoacationId).HasColumnName("Purchase_Voucher_Details_Loacation_ID");

                entity.Property(e => e.PurchaseVoucherDetailsLpoId).HasColumnName("Purchase_Voucher_Details_LPO_ID");

                entity.Property(e => e.PurchaseVoucherDetailsManufactureDate)
                    .HasColumnName("Purchase_Voucher_Details_Manufacture_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseVoucherDetailsMaterialId).HasColumnName("Purchase_Voucher_Details_Material_ID");

                entity.Property(e => e.PurchaseVoucherDetailsPodId).HasColumnName("Purchase_Voucher_Details_POD_ID");

                entity.Property(e => e.PurchaseVoucherDetailsPurchaseId)
                    .HasColumnName("Purchase_Voucher_Details_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsQuantity)
                    .HasColumnName("Purchase_Voucher_Details_Quantity")
                    .HasColumnType("numeric(5, 4)");

                entity.Property(e => e.PurchaseVoucherDetailsRate).HasColumnName("Purchase_Voucher_Details_Rate");

                entity.Property(e => e.PurchaseVoucherDetailsRemarks)
                    .HasColumnName("Purchase_Voucher_Details_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsSalesPrice1).HasColumnName("Purchase_Voucher_Details_Sales_Price1");

                entity.Property(e => e.PurchaseVoucherDetailsSalesPrice2).HasColumnName("Purchase_Voucher_Details_Sales_Price2");

                entity.Property(e => e.PurchaseVoucherDetailsSalesPrice3).HasColumnName("Purchase_Voucher_Details_Sales_Price3");

                entity.Property(e => e.PurchaseVoucherDetailsSno).HasColumnName("Purchase_Voucher_Details_SNO");

                entity.Property(e => e.PurchaseVoucherDetailsUnit)
                    .HasColumnName("Purchase_Voucher_Details_Unit")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVoucherDetailsUnitId).HasColumnName("Purchase_Voucher_Details_Unit_ID");

                entity.Property(e => e.PurchaseVoucherDetailsVatAmount).HasColumnName("Purchase_Voucher_Details_VAT_Amount");

                entity.HasOne(d => d.PurchaseVoucherDetailsPurchase)
                    .WithMany(p => p.PurchaseVoucherDetails)
                    .HasPrincipalKey(p => p.PurchaseVoucherPurchaseId)
                    .HasForeignKey(d => d.PurchaseVoucherDetailsPurchaseId)
                    .HasConstraintName("FK_Purchase_Voucher_Details_Purchase_Voucher");
            });

            modelBuilder.Entity<Qtemplates>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.QtemplatesDelStatus).HasColumnName("Qtemplates_DelStatus");

                entity.Property(e => e.QtemplatesDescription)
                    .HasColumnName("Qtemplates_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QtemplatesId)
                    .HasColumnName("Qtemplates_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QtemplatesType)
                    .HasColumnName("Qtemplates_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.QuotationCurrencyId).HasColumnName("Quotation_Currency_ID");

                entity.Property(e => e.QuotationCustId).HasColumnName("Quotation_Cust_ID");

                entity.Property(e => e.QuotationCustName)
                    .HasColumnName("Quotation_Cust_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationDate)
                    .HasColumnName("Quotation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuotationDelStatus).HasColumnName("Quotation_DelStatus");

                entity.Property(e => e.QuotationDiscPercentage).HasColumnName("Quotation_Disc_Percentage");

                entity.Property(e => e.QuotationDiscount).HasColumnName("Quotation_Discount");

                entity.Property(e => e.QuotationFsno).HasColumnName("Quotation_FSNO");

                entity.Property(e => e.QuotationId)
                    .HasColumnName("Quotation_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuotationLocationId).HasColumnName("Quotation_Location_ID");

                entity.Property(e => e.QuotationNetAmount).HasColumnName("Quotation_Net_Amount");

                entity.Property(e => e.QuotationNo)
                    .HasColumnName("Quotation_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationRemarks)
                    .HasColumnName("Quotation_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationSalesManId).HasColumnName("Quotation_Sales_Man_ID");

                entity.Property(e => e.QuotationTermsCondition)
                    .HasColumnName("Quotation_Terms_Condition")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationTotalAmount).HasColumnName("Quotation_Total_Amount");

                entity.Property(e => e.QuotationUserId).HasColumnName("Quotation_User_ID");

                entity.Property(e => e.QuotationValidTill)
                    .HasColumnName("Quotation_Valid_Till")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quotation_Details");

                entity.Property(e => e.QuotationDetailsAmount).HasColumnName("Quotation_Details_Amount");

                entity.Property(e => e.QuotationDetailsDelStatus).HasColumnName("Quotation_Details_DelStatus");

                entity.Property(e => e.QuotationDetailsFcAmount).HasColumnName("Quotation_Details_FC_Amount");

                entity.Property(e => e.QuotationDetailsId).HasColumnName("Quotation_Details_ID");

                entity.Property(e => e.QuotationDetailsMaterialDesc)
                    .HasColumnName("Quotation_Details_Material_Desc")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationDetailsMaterialId).HasColumnName("Quotation_Details_Material_ID");

                entity.Property(e => e.QuotationDetailsQuantity).HasColumnName("Quotation_Details_Quantity");

                entity.Property(e => e.QuotationDetailsRate).HasColumnName("Quotation_Details_Rate");

                entity.Property(e => e.QuotationDetailsSno).HasColumnName("Quotation_Details_Sno");

                entity.Property(e => e.QuotationDetailsUnitId).HasColumnName("Quotation_Details_Unit_ID");
            });

            modelBuilder.Entity<RackMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rack_Master");

                entity.Property(e => e.RackMasterDelStatus).HasColumnName("Rack_Master_DelStatus");

                entity.Property(e => e.RackMasterId).HasColumnName("Rack_Master_ID");

                entity.Property(e => e.RackMasterName)
                    .HasColumnName("Rack_Master_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RackMasterStatus).HasColumnName("Rack_Master_Status");
            });

            modelBuilder.Entity<ReceiptVoucherDetails>(entity =>
            {
                entity.ToTable("Receipt_Voucher_Details");

                entity.Property(e => e.ReceiptVoucherDetailsId).HasColumnName("Receipt_Voucher_Details_ID");

                entity.Property(e => e.ReceiptVoucherDetailsCrAcNo)
                    .HasColumnName("Receipt_Voucher_Details_Cr_Ac_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherDetailsCrAmount).HasColumnName("Receipt_Voucher_Details_Cr_Amount");

                entity.Property(e => e.ReceiptVoucherDetailsDbAmount).HasColumnName("Receipt_Voucher_Details_Db_Amount");

                entity.Property(e => e.ReceiptVoucherDetailsDelStatus).HasColumnName("Receipt_Voucher_Details_DelStatus");

                entity.Property(e => e.ReceiptVoucherDetailsDepId).HasColumnName("Receipt_Voucher_Details_Dep_ID");

                entity.Property(e => e.ReceiptVoucherDetailsFcCrAmount).HasColumnName("Receipt_Voucher_Details_FC_Cr_Amount");

                entity.Property(e => e.ReceiptVoucherDetailsFsno).HasColumnName("Receipt_Voucher_Details_FSNO");

                entity.Property(e => e.ReceiptVoucherDetailsJobId).HasColumnName("Receipt_Voucher_Details_Job_ID");

                entity.Property(e => e.ReceiptVoucherDetailsNarration)
                    .HasColumnName("Receipt_Voucher_Details_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherDetailsSlNo).HasColumnName("Receipt_Voucher_Details_SlNo");

                entity.Property(e => e.ReceiptVoucherDetailsVoucherNo)
                    .HasColumnName("Receipt_Voucher_Details_Voucher_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReceiptVoucherDetailsVoucherNoNavigation)
                    .WithMany(p => p.ReceiptVoucherDetails)
                    .HasPrincipalKey(p => p.VouchersNumbersVNo)
                    .HasForeignKey(d => d.ReceiptVoucherDetailsVoucherNo)
                    .HasConstraintName("FK_Receipt_Voucher_Details_Vouchers_Numbers");
            });

            modelBuilder.Entity<ReceiptVoucherMaster>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptVoucherMasterSno, e.ReceiptVoucherMasterVoucherNo });

                entity.ToTable("Receipt_Voucher_Master");

                entity.Property(e => e.ReceiptVoucherMasterSno)
                    .HasColumnName("Receipt_Voucher_Master_SNO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReceiptVoucherMasterVoucherNo)
                    .HasColumnName("Receipt_Voucher_Master_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherMasterAllocId).HasColumnName("Receipt_Voucher_Master_Alloc_ID");

                entity.Property(e => e.ReceiptVoucherMasterCrAmount).HasColumnName("Receipt_Voucher_Master_Cr_Amount");

                entity.Property(e => e.ReceiptVoucherMasterCurrencyId).HasColumnName("Receipt_Voucher_Master_Currency_ID");

                entity.Property(e => e.ReceiptVoucherMasterDelStatus).HasColumnName("Receipt_Voucher_Master_DelStatus");

                entity.Property(e => e.ReceiptVoucherMasterDrAcNo)
                    .HasColumnName("Receipt_Voucher_Master_Dr_Ac_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherMasterDrAmount).HasColumnName("Receipt_Voucher_Master_Dr_Amount");

                entity.Property(e => e.ReceiptVoucherMasterFcCrAmount).HasColumnName("Receipt_Voucher_Master_FC_Cr_Amount");

                entity.Property(e => e.ReceiptVoucherMasterFcDrAmount).HasColumnName("Receipt_Voucher_Master_FC_Dr_Amount");

                entity.Property(e => e.ReceiptVoucherMasterFsno).HasColumnName("Receipt_Voucher_Master_FSNO");

                entity.Property(e => e.ReceiptVoucherMasterNarration)
                    .HasColumnName("Receipt_Voucher_Master_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherMasterRefNo)
                    .HasColumnName("Receipt_Voucher_Master_Ref_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptVoucherMasterUserId).HasColumnName("Receipt_Voucher_Master_User_ID");

                entity.Property(e => e.ReceiptVoucherMasterVoucherDate)
                    .HasColumnName("Receipt_Voucher_Master_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiptVoucherMasterVoucherType)
                    .HasColumnName("Receipt_Voucher_Master_Voucher_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReconciliationVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reconciliation_Voucher");

                entity.Property(e => e.ReconciliationVoucherBankAcNo)
                    .HasColumnName("Reconciliation_Voucher_Bank_Ac_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherBankBalance).HasColumnName("Reconciliation_Voucher_Bank_Balance");

                entity.Property(e => e.ReconciliationVoucherBankStDate)
                    .HasColumnName("Reconciliation_Voucher_Bank_St_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReconciliationVoucherClosingBalance).HasColumnName("Reconciliation_Voucher_Closing_Balance");

                entity.Property(e => e.ReconciliationVoucherComplete).HasColumnName("Reconciliation_Voucher_Complete");

                entity.Property(e => e.ReconciliationVoucherDelStatus).HasColumnName("Reconciliation_Voucher_DelStatus");

                entity.Property(e => e.ReconciliationVoucherFsno).HasColumnName("Reconciliation_Voucher_FSNO");

                entity.Property(e => e.ReconciliationVoucherId)
                    .HasColumnName("Reconciliation_Voucher_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherLocationId).HasColumnName("Reconciliation_Voucher_Location_ID");

                entity.Property(e => e.ReconciliationVoucherNarration)
                    .HasColumnName("Reconciliation_Voucher_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherSno).HasColumnName("Reconciliation_Voucher_Sno");

                entity.Property(e => e.ReconciliationVoucherUnClearedTotal).HasColumnName("Reconciliation_Voucher_UnClearedTotal");

                entity.Property(e => e.ReconciliationVoucherUserId).HasColumnName("Reconciliation_Voucher_User_ID");
            });

            modelBuilder.Entity<ReconciliationVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reconciliation_Voucher_Details");

                entity.Property(e => e.ReconciliationVoucherDetailsChequeNo)
                    .HasColumnName("Reconciliation_Voucher_Details_ChequeNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherDetailsCredit).HasColumnName("Reconciliation_Voucher_Details_Credit");

                entity.Property(e => e.ReconciliationVoucherDetailsDebit).HasColumnName("Reconciliation_Voucher_Details_Debit");

                entity.Property(e => e.ReconciliationVoucherDetailsDelStatus).HasColumnName("Reconciliation_Voucher_Details_DelStatus");

                entity.Property(e => e.ReconciliationVoucherDetailsDescription)
                    .HasColumnName("Reconciliation_Voucher_Details_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherDetailsId)
                    .HasColumnName("Reconciliation_Voucher_Details_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationVoucherDetailsLocationId).HasColumnName("Reconciliation_Voucher_Details_Location_ID");

                entity.Property(e => e.ReconciliationVoucherDetailsMatched)
                    .HasColumnName("Reconciliation_Voucher_Details_Matched")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReconciliationVoucherDetailsSno).HasColumnName("Reconciliation_Voucher_Details_SNO");

                entity.Property(e => e.ReconciliationVoucherDetailsTransDate)
                    .HasColumnName("Reconciliation_Voucher_Details_Trans_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReconciliationVoucherDetailsTransSno).HasColumnName("Reconciliation_Voucher_Details_Trans_Sno");

                entity.Property(e => e.ReconciliationVoucherDetailsVno)
                    .HasColumnName("Reconciliation_Voucher_Details_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_Type");

                entity.Property(e => e.ReportTypeDelStatus).HasColumnName("Report_Type_DelStatus");

                entity.Property(e => e.ReportTypeDescription)
                    .HasColumnName("Report_Type_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTypeFileName)
                    .HasColumnName("Report_Type_FileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTypeId)
                    .HasColumnName("Report_Type_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReportTypeIsDefault).HasColumnName("Report_Type_Is_Default");

                entity.Property(e => e.ReportTypeIsImage).HasColumnName("Report_Type_Is_Image");

                entity.Property(e => e.ReportTypeIsVisible).HasColumnName("Report_Type_IsVisible");

                entity.Property(e => e.ReportTypeVoucherName)
                    .HasColumnName("Report_Type_Voucher_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RfqEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RFQ_Entry");

                entity.Property(e => e.RfqEntryDelStatus).HasColumnName("RFQ_Entry_DelStatus");

                entity.Property(e => e.RfqEntryDeliveryStatus).HasColumnName("RFQ_Entry_Delivery_Status");

                entity.Property(e => e.RfqEntryId).HasColumnName("RFQ_Entry_ID");

                entity.Property(e => e.RfqEntryRfqDate)
                    .HasColumnName("RFQ_Entry_RFQ_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RfqEntryRfqEnqId).HasColumnName("RFQ_Entry_RFQ_Enq_ID");

                entity.Property(e => e.RfqEntryRfqId)
                    .HasColumnName("RFQ_Entry_RFQ_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RfqEntrySalesManId).HasColumnName("RFQ_Entry_Sales_Man_ID");

                entity.Property(e => e.RfqEntryStatus).HasColumnName("RFQ_Entry_Status");

                entity.Property(e => e.RfqEntrySupplierAddress)
                    .HasColumnName("RFQ_Entry_Supplier_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RfqEntrySupplierId).HasColumnName("RFQ_Entry_Supplier_ID");
            });

            modelBuilder.Entity<RfqEntryDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RFQ_Entry_Details");

                entity.Property(e => e.RfqEntryDetailsDelStatus).HasColumnName("RFQ_Entry_Details_DelStatus");

                entity.Property(e => e.RfqEntryDetailsDelqty).HasColumnName("RFQ_Entry_Details_Delqty");

                entity.Property(e => e.RfqEntryDetailsDescription)
                    .HasColumnName("RFQ_Entry_Details_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RfqEntryDetailsDetId).HasColumnName("RFQ_Entry_Details_Det_ID");

                entity.Property(e => e.RfqEntryDetailsItemId).HasColumnName("RFQ_Entry_Details_Item_ID");

                entity.Property(e => e.RfqEntryDetailsPrice).HasColumnName("RFQ_Entry_Details_Price");

                entity.Property(e => e.RfqEntryDetailsQuantity).HasColumnName("RFQ_Entry_Details_Quantity");

                entity.Property(e => e.RfqEntryDetailsRemarks)
                    .HasColumnName("RFQ_Entry_Details_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RfqEntryDetailsRfqamt).HasColumnName("RFQ_Entry_Details_RFQAmt");

                entity.Property(e => e.RfqEntryDetailsUnitId).HasColumnName("RFQ_Entry_Details_Unit_ID");
            });

            modelBuilder.Entity<SalesJournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Journal");

                entity.Property(e => e.SalesJournalCustId).HasColumnName("Sales_Journal_Cust_ID");

                entity.Property(e => e.SalesJournalDate)
                    .HasColumnName("Sales_Journal_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesJournalDelStatus).HasColumnName("Sales_Journal_DelStatus");

                entity.Property(e => e.SalesJournalFsno).HasColumnName("Sales_Journal_FSNO");

                entity.Property(e => e.SalesJournalId).HasColumnName("Sales_Journal_ID");

                entity.Property(e => e.SalesJournalReffNo)
                    .HasColumnName("Sales_Journal_ReffNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalRemarks)
                    .HasColumnName("Sales_Journal_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalUserId).HasColumnName("Sales_Journal_User_ID");
            });

            modelBuilder.Entity<SalesJournalDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Journal_Details");

                entity.Property(e => e.SalesJournalDetailsAmountDh).HasColumnName("Sales_Journal_Details_AmountDH");

                entity.Property(e => e.SalesJournalDetailsAmountDollar).HasColumnName("Sales_Journal_Details_Amount_Dollar");

                entity.Property(e => e.SalesJournalDetailsCargoRate).HasColumnName("Sales_Journal_Details_Cargo_Rate");

                entity.Property(e => e.SalesJournalDetailsCargoValue).HasColumnName("Sales_Journal_Details_Cargo_Value");

                entity.Property(e => e.SalesJournalDetailsDelStatus).HasColumnName("Sales_Journal_Details_DelStatus");

                entity.Property(e => e.SalesJournalDetailsGrossWt).HasColumnName("Sales_Journal_Details_GrossWt");

                entity.Property(e => e.SalesJournalDetailsId).HasColumnName("Sales_Journal_Details_ID");

                entity.Property(e => e.SalesJournalDetailsPack).HasColumnName("Sales_Journal_Details_Pack");

                entity.Property(e => e.SalesJournalDetailsSno).HasColumnName("Sales_Journal_Details_SNO");

                entity.Property(e => e.SalesJournalDetailsTotalAmountDh).HasColumnName("Sales_Journal_Details_Total_AmountDH");

                entity.Property(e => e.SalesJournalDetailsTotalAmountDollar).HasColumnName("Sales_Journal_Details_Total_AmountDollar");
            });

            modelBuilder.Entity<SalesJournalVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Journal_Voucher");

                entity.Property(e => e.SalesJournalVoucherAmount).HasColumnName("Sales_Journal_Voucher_Amount");

                entity.Property(e => e.SalesJournalVoucherCostCenterId).HasColumnName("Sales_Journal_Voucher_CostCenter_ID");

                entity.Property(e => e.SalesJournalVoucherCurrencyId).HasColumnName("Sales_Journal_Voucher_Currency_ID");

                entity.Property(e => e.SalesJournalVoucherDate)
                    .HasColumnName("Sales_Journal_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesJournalVoucherDelStatus).HasColumnName("Sales_Journal_Voucher_DelStatus");

                entity.Property(e => e.SalesJournalVoucherFsno).HasColumnName("Sales_Journal_Voucher_FSNO");

                entity.Property(e => e.SalesJournalVoucherId)
                    .HasColumnName("Sales_Journal_Voucher_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherIdRef)
                    .HasColumnName("Sales_Journal_Voucher_ID_Ref")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherJobNo).HasColumnName("Sales_Journal_Voucher_Job_No");

                entity.Property(e => e.SalesJournalVoucherJvtype)
                    .HasColumnName("Sales_Journal_Voucher_JVType")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherLocationId).HasColumnName("Sales_Journal_Voucher_Location_ID");

                entity.Property(e => e.SalesJournalVoucherNarration)
                    .HasColumnName("Sales_Journal_Voucher_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherRefNo)
                    .HasColumnName("Sales_Journal_Voucher_RefNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherSno).HasColumnName("Sales_Journal_Voucher_SNO");

                entity.Property(e => e.SalesJournalVoucherStatus)
                    .HasColumnName("Sales_Journal_Voucher_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherUserId).HasColumnName("Sales_Journal_Voucher_User_ID");
            });

            modelBuilder.Entity<SalesJournalVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Journal_Voucher_Details");

                entity.Property(e => e.SalesJournalVoucherDetailsAccNo)
                    .HasColumnName("Sales_Journal_Voucher_Details_AccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherDetailsAccSno).HasColumnName("Sales_Journal_Voucher_Details_AccSNO");

                entity.Property(e => e.SalesJournalVoucherDetailsAmount).HasColumnName("Sales_Journal_Voucher_Details_Amount");

                entity.Property(e => e.SalesJournalVoucherDetailsCostCenterId).HasColumnName("Sales_Journal_Voucher_Details_CostCenter_ID");

                entity.Property(e => e.SalesJournalVoucherDetailsDelStatus).HasColumnName("Sales_Journal_Voucher_Details_DelStatus");

                entity.Property(e => e.SalesJournalVoucherDetailsDrCr)
                    .HasColumnName("Sales_Journal_Voucher_Details_DrCr")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherDetailsFcAmount).HasColumnName("Sales_Journal_Voucher_Details_FC_Amount");

                entity.Property(e => e.SalesJournalVoucherDetailsFcRate).HasColumnName("Sales_Journal_Voucher_Details_FC_Rate");

                entity.Property(e => e.SalesJournalVoucherDetailsFsno).HasColumnName("Sales_Journal_Voucher_Details_FSNO");

                entity.Property(e => e.SalesJournalVoucherDetailsId).HasColumnName("Sales_Journal_Voucher_Details_ID");

                entity.Property(e => e.SalesJournalVoucherDetailsJobId).HasColumnName("Sales_Journal_Voucher_Details_Job_ID");

                entity.Property(e => e.SalesJournalVoucherDetailsLocationId).HasColumnName("Sales_Journal_Voucher_Details_Location_ID");

                entity.Property(e => e.SalesJournalVoucherDetailsNarration)
                    .HasColumnName("Sales_Journal_Voucher_Details_Narration")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherDetailsReference)
                    .HasColumnName("Sales_Journal_Voucher_Details_Reference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournalVoucherDetailsSno).HasColumnName("Sales_Journal_Voucher_Details_SNO");
            });

            modelBuilder.Entity<SalesManMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Man_Master");

                entity.Property(e => e.SalesManMasterSalesManContactNo)
                    .HasColumnName("Sales_Man_Master_Sales_Man_Contact_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManMasterSalesManDelStatus).HasColumnName("Sales_Man_Master_Sales_Man_DelStatus");

                entity.Property(e => e.SalesManMasterSalesManDeleted).HasColumnName("Sales_Man_Master_Sales_Man_Deleted");

                entity.Property(e => e.SalesManMasterSalesManId).HasColumnName("Sales_Man_Master_Sales_Man_ID");

                entity.Property(e => e.SalesManMasterSalesManLocationId).HasColumnName("Sales_Man_Master_Sales_Man_Location_ID");

                entity.Property(e => e.SalesManMasterSalesManName)
                    .HasColumnName("Sales_Man_Master_Sales_Man_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesReturnDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Return_Details");

                entity.Property(e => e.SalesReturnDetailsBatch)
                    .HasColumnName("Sales_Return_Details_Batch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnDetailsBatchCode)
                    .HasColumnName("Sales_Return_Details_BatchCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnDetailsCostPrice).HasColumnName("Sales_Return_Details_Cost_Price");

                entity.Property(e => e.SalesReturnDetailsDelStatus).HasColumnName("Sales_Return_Details_DelStatus");

                entity.Property(e => e.SalesReturnDetailsDiscount).HasColumnName("Sales_Return_Details_Discount");

                entity.Property(e => e.SalesReturnDetailsExpDate)
                    .HasColumnName("Sales_Return_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesReturnDetailsFcAmount).HasColumnName("Sales_Return_Details_FC_Amount");

                entity.Property(e => e.SalesReturnDetailsFocQty).HasColumnName("Sales_Return_Details_FOC_QTY");

                entity.Property(e => e.SalesReturnDetailsFsno).HasColumnName("Sales_Return_Details_FSNO");

                entity.Property(e => e.SalesReturnDetailsGrossAmt).HasColumnName("Sales_Return_Details_GrossAmt");

                entity.Property(e => e.SalesReturnDetailsMaterialId).HasColumnName("Sales_Return_Details_Material_ID");

                entity.Property(e => e.SalesReturnDetailsNetAmount).HasColumnName("Sales_Return_Details_NetAmount");

                entity.Property(e => e.SalesReturnDetailsQty).HasColumnName("Sales_Return_Details_QTY");

                entity.Property(e => e.SalesReturnDetailsRate).HasColumnName("Sales_Return_Details_Rate");

                entity.Property(e => e.SalesReturnDetailsRefSvno)
                    .HasColumnName("Sales_Return_Details_Ref_SVNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnDetailsSno).HasColumnName("Sales_Return_Details_SNO");

                entity.Property(e => e.SalesReturnDetailsSrNo)
                    .HasColumnName("Sales_Return_Details_SrNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnDetailsUnitId).HasColumnName("Sales_Return_Details_Unit_ID");

                entity.Property(e => e.SalesReturnDetailsVat).HasColumnName("Sales_Return_Details_VAT");
            });

            modelBuilder.Entity<SalesReturnMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Return_Master");

                entity.Property(e => e.SalesReturnMasterCurrencyId).HasColumnName("Sales_Return_Master_Currency_ID");

                entity.Property(e => e.SalesReturnMasterCustName)
                    .HasColumnName("Sales_Return_Master_Cust_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterCustNo).HasColumnName("Sales_Return_Master_Cust_No");

                entity.Property(e => e.SalesReturnMasterDate)
                    .HasColumnName("Sales_Return_Master_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesReturnMasterDelStatus).HasColumnName("Sales_Return_Master_DelStatus");

                entity.Property(e => e.SalesReturnMasterDiscount).HasColumnName("Sales_Return_Master_Discount");

                entity.Property(e => e.SalesReturnMasterFcNetAmount).HasColumnName("Sales_Return_Master_FC_NetAmount");

                entity.Property(e => e.SalesReturnMasterFcRate).HasColumnName("Sales_Return_Master_FC_Rate");

                entity.Property(e => e.SalesReturnMasterFsno).HasColumnName("Sales_Return_Master_FSNO");

                entity.Property(e => e.SalesReturnMasterGrossAmount).HasColumnName("Sales_Return_Master_Gross_Amount");

                entity.Property(e => e.SalesReturnMasterLocationId).HasColumnName("Sales_Return_Master_Location_ID");

                entity.Property(e => e.SalesReturnMasterNarration)
                    .HasColumnName("Sales_Return_Master_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterNetAmount).HasColumnName("Sales_Return_Master_NetAmount");

                entity.Property(e => e.SalesReturnMasterRefSvDate)
                    .HasColumnName("Sales_Return_Master_Ref_SV_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesReturnMasterRefSvNo)
                    .HasColumnName("Sales_Return_Master_Ref_SV_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterReturnType)
                    .HasColumnName("Sales_Return_Master_Return_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterSalesManId).HasColumnName("Sales_Return_Master_Sales_Man_ID");

                entity.Property(e => e.SalesReturnMasterSrNo)
                    .HasColumnName("Sales_Return_Master_SrNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterSrNoNum).HasColumnName("Sales_Return_Master_SrNO_NUM");

                entity.Property(e => e.SalesReturnMasterStatus)
                    .HasColumnName("Sales_Return_Master_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterSvVoucherType)
                    .HasColumnName("Sales_Return_Master_SV_Voucher_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterUserId).HasColumnName("Sales_Return_Master_User_ID");

                entity.Property(e => e.SalesReturnMasterVatAmt).HasColumnName("Sales_Return_Master_VAT_Amt");

                entity.Property(e => e.SalesReturnMasterVatPercentage).HasColumnName("Sales_Return_Master_VAT_Percentage");

                entity.Property(e => e.SalesReturnMasterVatRoundAmt).HasColumnName("Sales_Return_Master_VAT_RoundAmt");

                entity.Property(e => e.SalesReturnMasterVatRoungSign)
                    .HasColumnName("Sales_Return_Master_VAT_RoungSign")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReturnMasterWorkPeriodId).HasColumnName("Sales_Return_Master_WorkPeriodID");
            });

            modelBuilder.Entity<SalesVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Voucher");

                entity.Property(e => e.SalesVoucherCashCustomerName)
                    .HasColumnName("Sales_Voucher_Cash_Customer_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherCompanyId).HasColumnName("Sales_Voucher_Company_ID");

                entity.Property(e => e.SalesVoucherCono)
                    .HasColumnName("Sales_Voucher_CONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherContractId).HasColumnName("Sales_Voucher_Contract_ID");

                entity.Property(e => e.SalesVoucherCreditCustomerId).HasColumnName("Sales_Voucher_Credit_Customer_ID");

                entity.Property(e => e.SalesVoucherCurrencyId).HasColumnName("Sales_Voucher_Currency_ID");

                entity.Property(e => e.SalesVoucherCustomerId).HasColumnName("Sales_Voucher_Customer_ID");

                entity.Property(e => e.SalesVoucherCustomerName)
                    .HasColumnName("Sales_Voucher_Customer_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherCustomerPoDate)
                    .HasColumnName("Sales_Voucher_Customer_PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesVoucherCustomerPoNo)
                    .HasColumnName("Sales_Voucher_Customer_PO_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDelStatus).HasColumnName("Sales_Voucher_DelStatus");

                entity.Property(e => e.SalesVoucherDeliveryNote)
                    .HasColumnName("Sales_Voucher_Delivery_Note")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDescription)
                    .HasColumnName("Sales_Voucher_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDiscount)
                    .HasColumnName("Sales_Voucher_Discount")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.SalesVoucherDiscountPercentage)
                    .HasColumnName("Sales_Voucher_Discount_Percentage")
                    .HasColumnType("numeric(4, 4)");

                entity.Property(e => e.SalesVoucherFcRate)
                    .HasColumnName("Sales_Voucher_FC_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherFsno).HasColumnName("Sales_Voucher_FSNO");

                entity.Property(e => e.SalesVoucherGrossAmount)
                    .HasColumnName("Sales_Voucher_Gross_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherInvMode)
                    .HasColumnName("Sales_Voucher_Inv_Mode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherInvoiceStatus)
                    .HasColumnName("Sales_Voucher_Invoice_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherInvoiceType)
                    .HasColumnName("Sales_Voucher_Invoice_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherJobId).HasColumnName("Sales_Voucher_Job_ID");

                entity.Property(e => e.SalesVoucherLoacationId).HasColumnName("Sales_Voucher_Loacation_ID");

                entity.Property(e => e.SalesVoucherNetAmount)
                    .HasColumnName("Sales_Voucher_Net_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherNetDiscount)
                    .HasColumnName("Sales_Voucher_Net_Discount")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.SalesVoucherPaymentMode)
                    .HasColumnName("Sales_Voucher_Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherPaymentTermsV)
                    .HasColumnName("Sales_Voucher_Payment_Terms_V")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherPriceType)
                    .HasColumnName("Sales_Voucher_Price_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherReference)
                    .HasColumnName("Sales_Voucher_Reference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherRemarks)
                    .HasColumnName("Sales_Voucher_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherSalesManId).HasColumnName("Sales_Voucher_Sales_Man_ID");

                entity.Property(e => e.SalesVoucherShippingAddress)
                    .HasColumnName("Sales_Voucher_Shipping_Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherShortNo).HasColumnName("Sales_Voucher_Short_No");

                entity.Property(e => e.SalesVoucherStationId).HasColumnName("Sales_Voucher_Station_ID");

                entity.Property(e => e.SalesVoucherSvId)
                    .HasColumnName("Sales_Voucher_SV_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesVoucherSvQtnIdN).HasColumnName("Sales_Voucher_SV_QtnID_N");

                entity.Property(e => e.SalesVoucherTermsAndConditionsV)
                    .HasColumnName("Sales_Voucher_Terms_And_Conditions_V")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherUserId).HasColumnName("Sales_Voucher_User_ID");

                entity.Property(e => e.SalesVoucherVatAmount)
                    .HasColumnName("Sales_Voucher_VAT_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherVatNo)
                    .HasColumnName("Sales_Voucher_VAT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherVatPercentage)
                    .HasColumnName("Sales_Voucher_VAT_Percentage")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherVatRoundAmount)
                    .HasColumnName("Sales_Voucher_VAT_Round_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherVatRoundSign)
                    .HasColumnName("Sales_Voucher_VAT_Round_Sign")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherVoucherDate)
                    .HasColumnName("Sales_Voucher_Voucher_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesVoucherVoucherNo)
                    .HasColumnName("Sales_Voucher_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherVoucherType).HasColumnName("Sales_Voucher_Voucher_Type");

                entity.Property(e => e.SalesVoucherWorkPeriodId)
                    .HasColumnName("Sales_Voucher_Work_Period_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesVoucherBatchDetials>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Voucher_Batch_Detials");

                entity.Property(e => e.SalesVoucherBatchDetailsDelStatus).HasColumnName("Sales_Voucher_Batch_Details_DelStatus");

                entity.Property(e => e.SalesVoucherBatchDetialsBatchCode)
                    .HasColumnName("Sales_Voucher_Batch_Detials_BatchCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherBatchDetialsCompanyId).HasColumnName("Sales_Voucher_Batch_Detials_Company_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsCostPrice).HasColumnName("Sales_Voucher_Batch_Detials_Cost_Price");

                entity.Property(e => e.SalesVoucherBatchDetialsDelDetailsId).HasColumnName("Sales_Voucher_Batch_Detials_Del_Details_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsDeliveryId).HasColumnName("Sales_Voucher_Batch_Detials_Delivery_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsDeliveryNote).HasColumnName("Sales_Voucher_Batch_Detials_DeliveryNote");

                entity.Property(e => e.SalesVoucherBatchDetialsDescription)
                    .HasColumnName("Sales_Voucher_Batch_Detials_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherBatchDetialsDetId)
                    .HasColumnName("Sales_Voucher_Batch_Detials_Det_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesVoucherBatchDetialsDiscount).HasColumnName("Sales_Voucher_Batch_Detials_Discount");

                entity.Property(e => e.SalesVoucherBatchDetialsExpDate)
                    .HasColumnName("Sales_Voucher_Batch_Detials_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesVoucherBatchDetialsFocQty).HasColumnName("Sales_Voucher_Batch_Detials_FOC_QTY");

                entity.Property(e => e.SalesVoucherBatchDetialsFsno).HasColumnName("Sales_Voucher_Batch_Detials_FSNO");

                entity.Property(e => e.SalesVoucherBatchDetialsGrossAmt).HasColumnName("Sales_Voucher_Batch_Detials_Gross_Amt");

                entity.Property(e => e.SalesVoucherBatchDetialsItemId).HasColumnName("Sales_Voucher_Batch_Detials_Item_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsLocationId).HasColumnName("Sales_Voucher_Batch_Detials_Location_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsNetAmount).HasColumnName("Sales_Voucher_Batch_Detials_Net_Amount");

                entity.Property(e => e.SalesVoucherBatchDetialsPodId).HasColumnName("Sales_Voucher_Batch_Detials_POD_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsSno).HasColumnName("Sales_Voucher_Batch_Detials_SNO");

                entity.Property(e => e.SalesVoucherBatchDetialsSoldQty).HasColumnName("Sales_Voucher_Batch_Detials_Sold_QTY");

                entity.Property(e => e.SalesVoucherBatchDetialsUnitId).HasColumnName("Sales_Voucher_Batch_Detials_Unit_ID");

                entity.Property(e => e.SalesVoucherBatchDetialsUnitPrice).HasColumnName("Sales_Voucher_Batch_Detials_Unit_Price");

                entity.Property(e => e.SalesVoucherBatchDetialsVoucherNo)
                    .HasColumnName("Sales_Voucher_Batch_Detials_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_Voucher_Details");

                entity.Property(e => e.SalesVoucherDetailsBatchCode)
                    .HasColumnName("Sales_Voucher_Details_Batch_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDetailsCompanyId).HasColumnName("Sales_Voucher_Details_Company_ID");

                entity.Property(e => e.SalesVoucherDetailsCostPrice)
                    .HasColumnName("Sales_Voucher_Details_Cost_Price")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsCostPriceBk)
                    .HasColumnName("Sales_Voucher_Details_Cost_Price_BK")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsDelStatus).HasColumnName("Sales_Voucher_Details_DelStatus");

                entity.Property(e => e.SalesVoucherDetailsDeliveryId).HasColumnName("Sales_Voucher_Details_Delivery_ID");

                entity.Property(e => e.SalesVoucherDetailsDeliveryNote).HasColumnName("Sales_Voucher_Details_Delivery_Note");

                entity.Property(e => e.SalesVoucherDetailsDescription)
                    .HasColumnName("Sales_Voucher_Details_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDetailsDiscount)
                    .HasColumnName("Sales_Voucher_Details_Discount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsExpDate)
                    .HasColumnName("Sales_Voucher_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesVoucherDetailsFocqty)
                    .HasColumnName("Sales_Voucher_Details_FOCQty")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.SalesVoucherDetailsFsno).HasColumnName("Sales_Voucher_Details_FSNO");

                entity.Property(e => e.SalesVoucherDetailsGrossAmount)
                    .HasColumnName("Sales_Voucher_Details_Gross_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsItemId).HasColumnName("Sales_Voucher_Details_Item_ID");

                entity.Property(e => e.SalesVoucherDetailsLocationId).HasColumnName("Sales_Voucher_Details_Location_ID");

                entity.Property(e => e.SalesVoucherDetailsNetAmount)
                    .HasColumnName("Sales_Voucher_Details_Net_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsPaymentMode)
                    .HasColumnName("Sales_Voucher_Details_Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDetailsPodId).HasColumnName("Sales_Voucher_Details_POD_ID");

                entity.Property(e => e.SalesVoucherDetailsSalesDetailsId)
                    .HasColumnName("Sales_Voucher_Details_SalesDetails_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesVoucherDetailsSno).HasColumnName("Sales_Voucher_Details_SNO");

                entity.Property(e => e.SalesVoucherDetailsSoldQty)
                    .HasColumnName("Sales_Voucher_Details_Sold_Qty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalesVoucherDetailsStationId).HasColumnName("Sales_Voucher_Details_Station_ID");

                entity.Property(e => e.SalesVoucherDetailsUnitId).HasColumnName("Sales_Voucher_Details_Unit_ID");

                entity.Property(e => e.SalesVoucherDetailsUnitPrice)
                    .HasColumnName("Sales_Voucher_Details_Unit_Price")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsVatAmount)
                    .HasColumnName("Sales_Voucher_Details_VAT_Amount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SalesVoucherDetailsVatPercentage)
                    .HasColumnName("Sales_Voucher_Details_VAT_Percentage")
                    .HasColumnType("numeric(4, 4)");

                entity.Property(e => e.SalesVoucherDetailsVoucherNo)
                    .HasColumnName("Sales_Voucher_Details_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVoucherDetailsWorkPeriodId).HasColumnName("Sales_Voucher_Details_Work_Period_ID");
            });

            modelBuilder.Entity<ServiceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ServiceMasterCode)
                    .HasColumnName("ServiceMaster_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceMasterDelStatus).HasColumnName("ServiceMaster_DelStatus");

                entity.Property(e => e.ServiceMasterId).HasColumnName("ServiceMaster_ID");
            });

            modelBuilder.Entity<SiteMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Site_Master");

                entity.Property(e => e.SiteMasterDelStatus).HasColumnName("Site_Master_DelStatus");

                entity.Property(e => e.SiteMasterShortName)
                    .HasColumnName("Site_Master_Short_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMasterSiteId).HasColumnName("Site_Master_Site_ID");

                entity.Property(e => e.SiteMasterSiteName)
                    .HasColumnName("Site_Master_Site_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SplitPaymentDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Split_Payment_Details");

                entity.Property(e => e.SplitPaymentDetailsCardAmount).HasColumnName("Split_Payment_Details_Card_Amount");

                entity.Property(e => e.SplitPaymentDetailsCashAmount).HasColumnName("Split_Payment_Details_Cash_Amount");

                entity.Property(e => e.SplitPaymentDetailsDelStatus).HasColumnName("Split_Payment_Details_DelStatus");

                entity.Property(e => e.SplitPaymentDetailsId)
                    .HasColumnName("Split_Payment_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SplitPaymentDetailsInvoiceNo)
                    .HasColumnName("Split_Payment_Details_Invoice_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SplitPaymentDetailsWorkPeriodId).HasColumnName("Split_Payment_Details_WorkPeriod_ID");
            });

            modelBuilder.Entity<StaffMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staff_Master");

                entity.Property(e => e.StaffMasterStaffCode)
                    .HasColumnName("Staff_Master_Staff_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StaffMasterStaffDelStatus).HasColumnName("Staff_Master_Staff_DelStatus");

                entity.Property(e => e.StaffMasterStaffId)
                    .HasColumnName("Staff_Master_Staff_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StaffMasterStaffName)
                    .HasColumnName("Staff_Master_Staff_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StationMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Station_Master");

                entity.Property(e => e.StationMasterAddress)
                    .HasColumnName("Station_Master_Address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterCity)
                    .HasColumnName("Station_Master_City")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterCode).HasColumnName("Station_Master_Code");

                entity.Property(e => e.StationMasterCountry)
                    .HasColumnName("Station_Master_Country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterDelStatus).HasColumnName("Station_Master_DelStatus");

                entity.Property(e => e.StationMasterEmail)
                    .HasColumnName("Station_Master_Email")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterFax)
                    .HasColumnName("Station_Master_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterLogoImg)
                    .HasColumnName("Station_Master_Logo_Img")
                    .HasColumnType("image");

                entity.Property(e => e.StationMasterLogoPath)
                    .HasColumnName("Station_Master_Logo_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterPostOffice)
                    .HasColumnName("Station_Master_PostOffice")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterSealImg)
                    .HasColumnName("Station_Master_Seal_Img")
                    .HasColumnType("image");

                entity.Property(e => e.StationMasterSignImg)
                    .HasColumnName("Station_Master_Sign_Img")
                    .HasColumnType("image");

                entity.Property(e => e.StationMasterSignPath)
                    .HasColumnName("Station_Master_Sign_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterStationName)
                    .HasColumnName("Station_Master_Station_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterTele1)
                    .HasColumnName("Station_Master_Tele1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterTele2)
                    .HasColumnName("Station_Master_Tele2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterVatNo)
                    .HasColumnName("Station_Master_VAT_No")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StationMasterWebSite)
                    .HasColumnName("Station_Master_WebSite")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Adjustment");

                entity.Property(e => e.StockAdjustmentAdjDate)
                    .HasColumnName("Stock_Adjustment_Adj_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockAdjustmentAdjQty).HasColumnName("Stock_Adjustment_Adj_QTY");

                entity.Property(e => e.StockAdjustmentDelStatus).HasColumnName("Stock_Adjustment_DelStatus");

                entity.Property(e => e.StockAdjustmentFsno).HasColumnName("Stock_Adjustment_FSNO");

                entity.Property(e => e.StockAdjustmentLocationId).HasColumnName("Stock_Adjustment_Location_ID");

                entity.Property(e => e.StockAdjustmentManuelQty).HasColumnName("Stock_Adjustment_Manuel_QTY");

                entity.Property(e => e.StockAdjustmentMaterialId).HasColumnName("Stock_Adjustment_Material_ID");

                entity.Property(e => e.StockAdjustmentRemarks)
                    .HasColumnName("Stock_Adjustment_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockAdjustmentSano).HasColumnName("Stock_Adjustment_SANo");

                entity.Property(e => e.StockAdjustmentSdate)
                    .HasColumnName("Stock_Adjustment_Sdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockAdjustmentStatus)
                    .HasColumnName("Stock_Adjustment_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StockAdjustmentVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Adjustment_Voucher");

                entity.Property(e => e.StockAdjustmentVoucherDelStatus).HasColumnName("Stock_Adjustment_Voucher_DelStatus");

                entity.Property(e => e.StockAdjustmentVoucherFsno).HasColumnName("Stock_Adjustment_Voucher_FSNO");

                entity.Property(e => e.StockAdjustmentVoucherLocationId).HasColumnName("Stock_Adjustment_Voucher_Location_ID");

                entity.Property(e => e.StockAdjustmentVoucherSaDate)
                    .HasColumnName("Stock_Adjustment_Voucher_SA_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockAdjustmentVoucherSaId).HasColumnName("Stock_Adjustment_Voucher_SA_ID");

                entity.Property(e => e.StockAdjustmentVoucherSaNo)
                    .HasColumnName("Stock_Adjustment_Voucher_SA_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockAdjustmentVoucherSaRemarks)
                    .HasColumnName("Stock_Adjustment_Voucher_SA_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockAdjustmentVoucherStVno)
                    .HasColumnName("Stock_Adjustment_Voucher_ST_VNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockAdjustmentVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Adjustment_Voucher_Details");

                entity.Property(e => e.StockAdjustmentVoucherDetailsAdjQty).HasColumnName("Stock_Adjustment_Voucher_Details_Adj_Qty");

                entity.Property(e => e.StockAdjustmentVoucherDetailsBatchCode)
                    .HasColumnName("Stock_Adjustment_Voucher_Details_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StockAdjustmentVoucherDetailsCosePrice).HasColumnName("Stock_Adjustment_Voucher_Details_Cose_Price");

                entity.Property(e => e.StockAdjustmentVoucherDetailsDelStatus).HasColumnName("Stock_Adjustment_Voucher_Details_DelStatus");

                entity.Property(e => e.StockAdjustmentVoucherDetailsDetId).HasColumnName("Stock_Adjustment_Voucher_Details_DET_ID");

                entity.Property(e => e.StockAdjustmentVoucherDetailsExpDate)
                    .HasColumnName("Stock_Adjustment_Voucher_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockAdjustmentVoucherDetailsIsEdit).HasColumnName("Stock_Adjustment_Voucher_Details_IsEdit");

                entity.Property(e => e.StockAdjustmentVoucherDetailsJobId).HasColumnName("Stock_Adjustment_Voucher_Details_Job_ID");

                entity.Property(e => e.StockAdjustmentVoucherDetailsLocationId).HasColumnName("Stock_Adjustment_Voucher_Details_Location_ID");

                entity.Property(e => e.StockAdjustmentVoucherDetailsManualQty).HasColumnName("Stock_Adjustment_Voucher_Details_Manual_QTY");

                entity.Property(e => e.StockAdjustmentVoucherDetailsMaterialId).HasColumnName("Stock_Adjustment_Voucher_Details_Material_ID");

                entity.Property(e => e.StockAdjustmentVoucherDetailsSaId).HasColumnName("Stock_Adjustment_Voucher_Details_SA_ID");

                entity.Property(e => e.StockAdjustmentVoucherDetailsUnitId).HasColumnName("Stock_Adjustment_Voucher_Details_Unit_ID");
            });

            modelBuilder.Entity<StockEditPriceUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Edit_Price_Update");

                entity.Property(e => e.StockEditPriceUpdateDelStatus).HasColumnName("Stock_Edit_Price_Update_DelStatus");

                entity.Property(e => e.StockEditPriceUpdateId).HasColumnName("Stock_Edit_Price_Update_ID");

                entity.Property(e => e.StockEditPriceUpdateMaterialId).HasColumnName("Stock_Edit_Price_Update_Material_ID");

                entity.Property(e => e.StockEditPriceUpdateQty).HasColumnName("Stock_Edit_Price_Update_QTY");

                entity.Property(e => e.StockEditPriceUpdateRate).HasColumnName("Stock_Edit_Price_Update_Rate");

                entity.Property(e => e.StockEditPriceUpdateVno)
                    .HasColumnName("Stock_Edit_Price_Update_VNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockExchangeDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Exchange_Details");

                entity.Property(e => e.StockExchangeDetailsBatch)
                    .HasColumnName("Stock_Exchange_Details_Batch")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeDetailsDelStatus).HasColumnName("Stock_Exchange_Details_DelStatus");

                entity.Property(e => e.StockExchangeDetailsExpDate)
                    .HasColumnName("Stock_Exchange_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockExchangeDetailsFsno).HasColumnName("Stock_Exchange_Details_FSNO");

                entity.Property(e => e.StockExchangeDetailsMaterialId).HasColumnName("Stock_Exchange_Details_Material_ID");

                entity.Property(e => e.StockExchangeDetailsNetAmount).HasColumnName("Stock_Exchange_Details_NetAmount");

                entity.Property(e => e.StockExchangeDetailsQty).HasColumnName("Stock_Exchange_Details_Qty");

                entity.Property(e => e.StockExchangeDetailsRate).HasColumnName("Stock_Exchange_Details_Rate");

                entity.Property(e => e.StockExchangeDetailsSeNo)
                    .HasColumnName("Stock_Exchange_Details_SE_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeDetailsSno).HasColumnName("Stock_Exchange_Details_SNO");

                entity.Property(e => e.StockExchangeDetailsTransType)
                    .HasColumnName("Stock_Exchange_Details_TransType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeDetailsUnitId).HasColumnName("Stock_Exchange_Details_Unit_ID");
            });

            modelBuilder.Entity<StockExchangeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Exchange_Master");

                entity.Property(e => e.StockExchangeMasterAccNo)
                    .HasColumnName("Stock_Exchange_Master_AccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeMasterDate)
                    .HasColumnName("Stock_Exchange_Master_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockExchangeMasterDelStatus).HasColumnName("Stock_Exchange_Master_DelStatus");

                entity.Property(e => e.StockExchangeMasterDiffAccNo)
                    .HasColumnName("Stock_Exchange_Master_DiffAccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeMasterDiffAmt).HasColumnName("Stock_Exchange_Master_Diff_Amt");

                entity.Property(e => e.StockExchangeMasterFsno).HasColumnName("Stock_Exchange_Master_FSNO");

                entity.Property(e => e.StockExchangeMasterLocationId).HasColumnName("Stock_Exchange_Master_Location_ID");

                entity.Property(e => e.StockExchangeMasterNarration)
                    .HasColumnName("Stock_Exchange_Master_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeMasterPartyName)
                    .HasColumnName("Stock_Exchange_Master_PartyName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeMasterSeNo)
                    .HasColumnName("Stock_Exchange_Master_SE_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchangeMasterSeNoNum).HasColumnName("Stock_Exchange_Master_SE_NO_NUM");

                entity.Property(e => e.StockExchangeMasterStockOutAmt).HasColumnName("Stock_Exchange_Master_StockOut_Amt");

                entity.Property(e => e.StockExchangeMasterStockinAmt).HasColumnName("Stock_Exchange_Master_Stockin_Amt");

                entity.Property(e => e.StockExchangeMasterUnitId).HasColumnName("Stock_Exchange_Master_Unit_ID");
            });

            modelBuilder.Entity<StockInwardDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Inward_Details");

                entity.Property(e => e.StockInwardDetailsBatch)
                    .HasColumnName("Stock_Inward_Details_Batch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockInwardDetailsDelStatus).HasColumnName("Stock_Inward_Details_DelStatus");

                entity.Property(e => e.StockInwardDetailsExpDate)
                    .HasColumnName("Stock_Inward_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockInwardDetailsFcAmount).HasColumnName("Stock_Inward_Details_FC_Amount");

                entity.Property(e => e.StockInwardDetailsFsno).HasColumnName("Stock_Inward_Details_FSNO");

                entity.Property(e => e.StockInwardDetailsMaterialId).HasColumnName("Stock_Inward_Details_Material_ID");

                entity.Property(e => e.StockInwardDetailsNetAmount).HasColumnName("Stock_Inward_Details_NetAmount");

                entity.Property(e => e.StockInwardDetailsQty).HasColumnName("Stock_Inward_Details_QTY");

                entity.Property(e => e.StockInwardDetailsRate).HasColumnName("Stock_Inward_Details_Rate");

                entity.Property(e => e.StockInwardDetailsSiNo)
                    .HasColumnName("Stock_Inward_Details_SI_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockInwardDetailsSno).HasColumnName("Stock_Inward_Details_SNO");

                entity.Property(e => e.StockInwardDetailsUnitId).HasColumnName("Stock_Inward_Details_Unit_ID");
            });

            modelBuilder.Entity<StockInwardMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Inward_Master");

                entity.Property(e => e.StockInwardMasterCurrencyId).HasColumnName("Stock_Inward_Master_Currency_ID");

                entity.Property(e => e.StockInwardMasterCustName)
                    .HasColumnName("Stock_Inward_Master_Cust_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockInwardMasterCustNo).HasColumnName("Stock_Inward_Master_Cust_no");

                entity.Property(e => e.StockInwardMasterDelStatus).HasColumnName("Stock_Inward_Master_DelStatus");

                entity.Property(e => e.StockInwardMasterFcNetAmount).HasColumnName("Stock_Inward_Master_FC_NetAmount");

                entity.Property(e => e.StockInwardMasterFcRate).HasColumnName("Stock_Inward_Master_FC_Rate");

                entity.Property(e => e.StockInwardMasterFsno).HasColumnName("Stock_Inward_Master_FSNO");

                entity.Property(e => e.StockInwardMasterLocationId).HasColumnName("Stock_Inward_Master_Location_ID");

                entity.Property(e => e.StockInwardMasterNarration)
                    .HasColumnName("Stock_Inward_Master_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockInwardMasterNetAmount).HasColumnName("Stock_Inward_Master_NetAmount");

                entity.Property(e => e.StockInwardMasterSiDate)
                    .HasColumnName("Stock_Inward_Master_SI_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockInwardMasterSiNo)
                    .HasColumnName("Stock_Inward_Master_SI_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockInwardMasterSiNoNum).HasColumnName("Stock_Inward_Master_SI_NO_NUM");

                entity.Property(e => e.StockInwardMasterUserId).HasColumnName("Stock_Inward_Master_User_ID");

                entity.Property(e => e.StockInwardMasterVoucherType)
                    .HasColumnName("Stock_Inward_Master_VoucherType")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Register");

                entity.Property(e => e.StockRegisterAmount).HasColumnName("Stock_Register_Amount");

                entity.Property(e => e.StockRegisterAmountTmp).HasColumnName("Stock_Register_AmountTmp");

                entity.Property(e => e.StockRegisterAssignedDate)
                    .HasColumnName("Stock_Register_Assigned_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterBatchCode)
                    .HasColumnName("Stock_Register_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterCalcDone).HasColumnName("Stock_Register_CalcDone");

                entity.Property(e => e.StockRegisterDelStatus).HasColumnName("Stock_Register_DelStatus");

                entity.Property(e => e.StockRegisterDepCode)
                    .HasColumnName("Stock_Register_Dep_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterExpDate)
                    .HasColumnName("Stock_Register_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterFcAmount).HasColumnName("Stock_Register_FC_Amount");

                entity.Property(e => e.StockRegisterFoc)
                    .HasColumnName("Stock_Register_FOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterFsno).HasColumnName("Stock_Register_FSNO");

                entity.Property(e => e.StockRegisterJobId).HasColumnName("Stock_Register_Job_ID");

                entity.Property(e => e.StockRegisterLocationId).HasColumnName("Stock_Register_Location_ID");

                entity.Property(e => e.StockRegisterMaterialId).HasColumnName("Stock_Register_Material_ID");

                entity.Property(e => e.StockRegisterNetStkBal).HasColumnName("Stock_Register_NetStkBal");

                entity.Property(e => e.StockRegisterPurchaseId)
                    .HasColumnName("Stock_Register_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterQuantity).HasColumnName("Stock_Register_Quantity");

                entity.Property(e => e.StockRegisterQueryRun).HasColumnName("Stock_Register_QueryRun");

                entity.Property(e => e.StockRegisterRate).HasColumnName("Stock_Register_Rate");

                entity.Property(e => e.StockRegisterRateTmp).HasColumnName("Stock_Register_RateTmp");

                entity.Property(e => e.StockRegisterRefVoucherNo)
                    .HasColumnName("Stock_Register_Ref_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterRemarks)
                    .HasColumnName("Stock_Register_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterSin).HasColumnName("Stock_Register_SIN");

                entity.Property(e => e.StockRegisterSno).HasColumnName("Stock_Register_Sno");

                entity.Property(e => e.StockRegisterSout).HasColumnName("Stock_Register_Sout");

                entity.Property(e => e.StockRegisterStatus)
                    .HasColumnName("Stock_Register_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterStoreId)
                    .HasColumnName("Stock_Register_Store_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockRegisterTransType)
                    .HasColumnName("Stock_Register_Trans_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterUnit).HasColumnName("Stock_Register_Unit_ID");

                entity.Property(e => e.StockRegisterUsedQty).HasColumnName("Stock_Register_Used_QTY");
            });

            modelBuilder.Entity<StockRegisterResponse>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.StockRegisterAmount).HasColumnName("Stock_Register_Amount");

                entity.Property(e => e.StockRegisterAmountTmp).HasColumnName("Stock_Register_AmountTmp");

                entity.Property(e => e.StockRegisterAssignedDate)
                    .HasColumnName("Stock_Register_Assigned_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterBatchCode)
                    .HasColumnName("Stock_Register_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterCalcDone).HasColumnName("Stock_Register_CalcDone");

                entity.Property(e => e.StockRegisterDelStatus).HasColumnName("Stock_Register_DelStatus");

                entity.Property(e => e.StockRegisterDepCode)
                    .HasColumnName("Stock_Register_Dep_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterExpDate)
                    .HasColumnName("Stock_Register_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockRegisterFcAmount).HasColumnName("Stock_Register_FC_Amount");

                entity.Property(e => e.StockRegisterFoc)
                    .HasColumnName("Stock_Register_FOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterFsno).HasColumnName("Stock_Register_FSNO");

                entity.Property(e => e.StockRegisterJobId).HasColumnName("Stock_Register_Job_ID");

                entity.Property(e => e.StockRegisterLocationId).HasColumnName("Stock_Register_Location_ID");

                entity.Property(e => e.StockRegisterMaterialId).HasColumnName("Stock_Register_Material_ID");

                entity.Property(e => e.StockRegisterNetStkBal).HasColumnName("Stock_Register_NetStkBal");

                entity.Property(e => e.StockRegisterPurchaseId)
                    .HasColumnName("Stock_Register_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterQuantity).HasColumnName("Stock_Register_Quantity");

                entity.Property(e => e.StockRegisterQueryRun).HasColumnName("Stock_Register_QueryRun");

                entity.Property(e => e.StockRegisterRate).HasColumnName("Stock_Register_Rate");

                entity.Property(e => e.StockRegisterRateTmp).HasColumnName("Stock_Register_RateTmp");

                entity.Property(e => e.StockRegisterRefVoucherNo)
                    .HasColumnName("Stock_Register_Ref_Voucher_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterRemarks)
                    .HasColumnName("Stock_Register_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterSin).HasColumnName("Stock_Register_SIN");

                entity.Property(e => e.StockRegisterSno).HasColumnName("Stock_Register_Sno");

                entity.Property(e => e.StockRegisterSout).HasColumnName("Stock_Register_Sout");

                entity.Property(e => e.StockRegisterStatus)
                    .HasColumnName("Stock_Register_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterStoreId)
                    .HasColumnName("Stock_Register_Store_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockRegisterTransType)
                    .HasColumnName("Stock_Register_Trans_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockRegisterUnit).HasColumnName("Stock_Register_Unit_ID");

                entity.Property(e => e.StockRegisterUsedQty).HasColumnName("Stock_Register_Used_QTY");
            });

            modelBuilder.Entity<StockReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Report");

                entity.Property(e => e.StockReportAvgRate).HasColumnName("Stock_Report_Avg_Rate");

                entity.Property(e => e.StockReportBrand)
                    .HasColumnName("Stock_Report_Brand")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockReportDelStatus).HasColumnName("Stock_Report_DelStatus");

                entity.Property(e => e.StockReportItemId).HasColumnName("Stock_Report_Item_ID");

                entity.Property(e => e.StockReportItemName)
                    .HasColumnName("Stock_Report_Item_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockReportPartNo)
                    .HasColumnName("Stock_Report_Part_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockReportRelativeNo)
                    .HasColumnName("Stock_Report_Relative_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockReportStock).HasColumnName("Stock_Report_Stock");

                entity.Property(e => e.StockReportStockValue).HasColumnName("Stock_Report_Stock_Value");

                entity.Property(e => e.StockReportUnit)
                    .HasColumnName("Stock_Report_Unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockReqDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StockReq_Details");

                entity.Property(e => e.StockReqDetailsApprovedBy)
                    .HasColumnName("StockReq_Details_ApprovedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockReqDetailsDelStatus).HasColumnName("StockReq_Details_DelStatus");

                entity.Property(e => e.StockReqDetailsFsno).HasColumnName("StockReq_Details_FSNO");

                entity.Property(e => e.StockReqDetailsIsApproved).HasColumnName("StockReq_Details_IsApproved");

                entity.Property(e => e.StockReqDetailsIsEdit).HasColumnName("StockReq_Details_IsEdit");

                entity.Property(e => e.StockReqDetailsMaterialId).HasColumnName("StockReq_Details_Material_ID");

                entity.Property(e => e.StockReqDetailsRate).HasColumnName("StockReq_Details_Rate");

                entity.Property(e => e.StockReqDetailsRemarks)
                    .HasColumnName("StockReq_Details_Remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockReqDetailsReqAmount).HasColumnName("StockReq_Details_Req_Amount");

                entity.Property(e => e.StockReqDetailsReqQty).HasColumnName("StockReq_Details_Req_Qty");

                entity.Property(e => e.StockReqDetailsSno).HasColumnName("StockReq_Details_Sno");

                entity.Property(e => e.StockReqDetailsSrNo).HasColumnName("StockReq_Details_SR_NO");

                entity.Property(e => e.StockReqDetailsSrdId).HasColumnName("StockReq_Details_SRD_ID");

                entity.Property(e => e.StockReqDetailsStatus)
                    .HasColumnName("StockReq_Details_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockReqDetailsUnitId).HasColumnName("StockReq_Details_Unit_ID");
            });

            modelBuilder.Entity<StockReservation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Reservation");

                entity.Property(e => e.StockReservationDelStatus).HasColumnName("Stock_Reservation_DelStatus");

                entity.Property(e => e.StockReservationId).HasColumnName("Stock_Reservation_ID");

                entity.Property(e => e.StockReservationJobId).HasColumnName("Stock_Reservation_Job_ID");

                entity.Property(e => e.StockReservationRDate)
                    .HasColumnName("Stock_Reservation_R_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockReservationRelease).HasColumnName("Stock_Reservation_Release");

                entity.Property(e => e.StockReservationRemarks)
                    .HasColumnName("Stock_Reservation_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockReservationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Reservation_Details");

                entity.Property(e => e.StockReservationDetailsDelStatus).HasColumnName("Stock_Reservation_Details_DelStatus");

                entity.Property(e => e.StockReservationDetailsItemId).HasColumnName("Stock_Reservation_Details_Item_ID");

                entity.Property(e => e.StockReservationDetailsRId).HasColumnName("Stock_Reservation_Details_R_ID");

                entity.Property(e => e.StockReservationDetailsRdId).HasColumnName("Stock_Reservation_Details_RD_ID");

                entity.Property(e => e.StockReservationDetailsRelease).HasColumnName("Stock_Reservation_Details_Release");

                entity.Property(e => e.StockReservationDetailsRemarks)
                    .HasColumnName("Stock_Reservation_Details_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockReservationDetailsSQty).HasColumnName("Stock_Reservation_Details_S_QTY");

                entity.Property(e => e.StockReservationDetailsUnitId).HasColumnName("Stock_Reservation_Details_Unit_ID");
            });

            modelBuilder.Entity<StockStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Statement");

                entity.Property(e => e.StockStatementAvgPrice).HasColumnName("Stock_Statement_Avg_Price");

                entity.Property(e => e.StockStatementDateAdjust)
                    .HasColumnName("Stock_Statement_Date_Adjust")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockStatementDelStatus).HasColumnName("Stock_Statement_DelStatus");

                entity.Property(e => e.StockStatementDepCode)
                    .HasColumnName("Stock_Statement_Dep_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockStatementId).HasColumnName("Stock_Statement_ID");

                entity.Property(e => e.StockStatementMaterialId).HasColumnName("Stock_Statement_Material_ID");

                entity.Property(e => e.StockStatementMaterialName)
                    .HasColumnName("Stock_Statement_Material_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockStatementQuantity).HasColumnName("Stock_Statement_Quantity");

                entity.Property(e => e.StockStatementStockValue).HasColumnName("Stock_Statement_Stock_Value");
            });

            modelBuilder.Entity<StockTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Transfer");

                entity.Property(e => e.StockTransferApproved).HasColumnName("Stock_Transfer_Approved");

                entity.Property(e => e.StockTransferApprovedBy)
                    .HasColumnName("Stock_Transfer_ApprovedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferApprovedDate)
                    .HasColumnName("Stock_Transfer_Approved_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockTransferDelStatus).HasColumnName("Stock_Transfer_DelStatus");

                entity.Property(e => e.StockTransferFsno).HasColumnName("Stock_Transfer_FSNO");

                entity.Property(e => e.StockTransferJobId).HasColumnName("Stock_Transfer_Job_ID");

                entity.Property(e => e.StockTransferLocationIdFrom).HasColumnName("Stock_Transfer_Location_ID_From");

                entity.Property(e => e.StockTransferLocationIdTo).HasColumnName("Stock_Transfer_Location_ID_To");

                entity.Property(e => e.StockTransferNarration)
                    .HasColumnName("Stock_Transfer_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferStDate)
                    .HasColumnName("Stock_Transfer_ST_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockTransferStatus)
                    .HasColumnName("Stock_Transfer_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferStid).HasColumnName("Stock_Transfer_STID");

                entity.Property(e => e.StockTransferStvno)
                    .HasColumnName("Stock_Transfer_STVNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferUserId).HasColumnName("Stock_Transfer_User_ID");
            });

            modelBuilder.Entity<StockTransferDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Transfer_Details");

                entity.Property(e => e.StockTransferDetailsBatchCode)
                    .HasColumnName("Stock_Transfer_Details_BatchCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferDetailsDelStatus).HasColumnName("Stock_Transfer_Details_DelStatus");

                entity.Property(e => e.StockTransferDetailsExpDate)
                    .HasColumnName("Stock_Transfer_Details_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockTransferDetailsMaterialId).HasColumnName("Stock_Transfer_Details_Material_ID");

                entity.Property(e => e.StockTransferDetailsQty).HasColumnName("Stock_Transfer_Details_QTY");

                entity.Property(e => e.StockTransferDetailsRate).HasColumnName("Stock_Transfer_Details_Rate");

                entity.Property(e => e.StockTransferDetailsRemarks)
                    .HasColumnName("Stock_Transfer_Details_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferDetailsSno).HasColumnName("Stock_Transfer_Details_SNO");

                entity.Property(e => e.StockTransferDetailsStid).HasColumnName("Stock_Transfer_Details_STID");

                entity.Property(e => e.StockTransferDetailsUnitId).HasColumnName("Stock_Transfer_Details_Unit_ID");
            });

            modelBuilder.Entity<StockTransferDetailsJobWise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Transfer_Details_JobWise");

                entity.Property(e => e.StockTransferDetailsJobWiseDelStatus).HasColumnName("Stock_Transfer_Details_JobWise_DelStatus");

                entity.Property(e => e.StockTransferDetailsJobWiseId).HasColumnName("Stock_Transfer_Details_JobWise_ID");

                entity.Property(e => e.StockTransferDetailsJobWiseMaterialId).HasColumnName("Stock_Transfer_Details_JobWise_Material_ID");

                entity.Property(e => e.StockTransferDetailsJobWiseQty).HasColumnName("Stock_Transfer_Details_JobWise_QTY");

                entity.Property(e => e.StockTransferDetailsJobWiseRate).HasColumnName("Stock_Transfer_Details_JobWise_Rate");

                entity.Property(e => e.StockTransferDetailsJobWiseRemarks)
                    .HasColumnName("Stock_Transfer_Details_JobWise_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferDetailsJobWiseSno).HasColumnName("Stock_Transfer_Details_JobWise_SNO");

                entity.Property(e => e.StockTransferDetailsJobWiseUnitId).HasColumnName("Stock_Transfer_Details_JobWise_Unit_ID");
            });

            modelBuilder.Entity<StockTransferJobWise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stock_Transfer_JobWise");

                entity.Property(e => e.StockTransferJobWiseDate)
                    .HasColumnName("Stock_Transfer_JobWise_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockTransferJobWiseDelStatus).HasColumnName("Stock_Transfer_JobWise_DelStatus");

                entity.Property(e => e.StockTransferJobWiseFsno).HasColumnName("Stock_Transfer_JobWise_FSNO");

                entity.Property(e => e.StockTransferJobWiseJobIdFrom).HasColumnName("Stock_Transfer_JobWise_Job_ID_From");

                entity.Property(e => e.StockTransferJobWiseJobIdTo).HasColumnName("Stock_Transfer_JobWise_Job_ID_To");

                entity.Property(e => e.StockTransferJobWiseNarration)
                    .HasColumnName("Stock_Transfer_JobWise_Narration")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferJobWiseStatus)
                    .HasColumnName("Stock_Transfer_JobWise_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransferJobWiseStid).HasColumnName("Stock_Transfer_JobWise_STID");

                entity.Property(e => e.StockTransferJobWiseUserId).HasColumnName("Stock_Transfer_JobWise_User_ID");

                entity.Property(e => e.StockTransferJobWiseVno)
                    .HasColumnName("Stock_Transfer_JobWise_VNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreReqMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoreReq_Master");

                entity.Property(e => e.StoreReqMasterBillofQtyId).HasColumnName("StoreReq_Master_BillofQtyID");

                entity.Property(e => e.StoreReqMasterDelStatus).HasColumnName("StoreReq_Master_DelStatus");

                entity.Property(e => e.StoreReqMasterFsno).HasColumnName("StoreReq_Master_FSNO");

                entity.Property(e => e.StoreReqMasterJobId).HasColumnName("StoreReq_Master_Job_ID");

                entity.Property(e => e.StoreReqMasterLocationId).HasColumnName("StoreReq_Master_Location_ID");

                entity.Property(e => e.StoreReqMasterNarration)
                    .HasColumnName("StoreReq_Master_Narration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreReqMasterSrDate)
                    .HasColumnName("StoreReq_Master_SR_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StoreReqMasterSrno).HasColumnName("StoreReq_Master_SRNO");

                entity.Property(e => e.StoreReqMasterUserId).HasColumnName("StoreReq_Master_User_ID");
            });

            modelBuilder.Entity<SuppQuotationExpenseDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supp_Quotation_ExpenseDetails");

                entity.Property(e => e.SuppQuotationExpenseDetailsDelStatus).HasColumnName("Supp_Quotation_ExpenseDetails_DelStatus");

                entity.Property(e => e.SuppQuotationExpenseDetailsDetId).HasColumnName("Supp_Quotation_ExpenseDetails_Det_ID");

                entity.Property(e => e.SuppQuotationExpenseDetailsExpAmount).HasColumnName("Supp_Quotation_ExpenseDetails_EXP_Amount");

                entity.Property(e => e.SuppQuotationExpenseDetailsExpFcAmount).HasColumnName("Supp_Quotation_ExpenseDetails_Exp_FC_Amount");

                entity.Property(e => e.SuppQuotationExpenseDetailsExpId).HasColumnName("Supp_Quotation_ExpenseDetails_EXP_ID");

                entity.Property(e => e.SuppQuotationExpenseDetailsExpPercentage).HasColumnName("Supp_Quotation_ExpenseDetails_Exp_Percentage");

                entity.Property(e => e.SuppQuotationExpenseDetailsExpRemarks)
                    .HasColumnName("Supp_Quotation_ExpenseDetails_Exp_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SuppQuotationExpenseDetailsIsEdit).HasColumnName("Supp_Quotation_ExpenseDetails_IsEdit");

                entity.Property(e => e.SuppQuotationExpenseDetailsSno).HasColumnName("Supp_Quotation_ExpenseDetails_Sno");

                entity.Property(e => e.SuppQuotationExpenseDetailsSqtnid).HasColumnName("Supp_Quotation_ExpenseDetails_SQTNID");
            });

            modelBuilder.Entity<SupplierContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Contacts");

                entity.Property(e => e.SupplierContactsActive).HasColumnName("Supplier_Contacts_Active");

                entity.Property(e => e.SupplierContactsContactMobile)
                    .HasColumnName("Supplier_Contacts_Contact_Mobile")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierContactsContactName)
                    .HasColumnName("Supplier_Contacts_Contact_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SupplierContactsContactOffice)
                    .HasColumnName("Supplier_Contacts_Contact_Office")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierContactsDelStatus).HasColumnName("Supplier_Contacts_DelStatus");

                entity.Property(e => e.SupplierContactsDepartmentId).HasColumnName("Supplier_Contacts_Department_ID");

                entity.Property(e => e.SupplierContactsEmail)
                    .HasColumnName("Supplier_Contacts_Email")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierContactsId).HasColumnName("Supplier_Contacts_ID");

                entity.Property(e => e.SupplierContactsSupplierId).HasColumnName("Supplier_Contacts_Supplier_ID");
            });

            modelBuilder.Entity<SupplierDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Details");

                entity.Property(e => e.SupplierDetailsContract)
                    .HasColumnName("Supplier_Details_Contract")
                    .HasColumnType("image");

                entity.Property(e => e.SupplierDetailsContract1)
                    .HasColumnName("Supplier_Details_Contract1")
                    .HasColumnType("image");

                entity.Property(e => e.SupplierDetailsContract2)
                    .HasColumnName("Supplier_Details_Contract2")
                    .HasColumnType("image");

                entity.Property(e => e.SupplierDetailsDelStatus).HasColumnName("Supplier_Details_DelStatus");

                entity.Property(e => e.SupplierDetailsId)
                    .HasColumnName("Supplier_Details_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SupplierDetailsSupplierInsId).HasColumnName("Supplier_Details_Supplier_INS_ID");
            });

            modelBuilder.Entity<SupplierPurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Purchase_Order");

                entity.Property(e => e.SupplierPurchaseOrderCpoDeliveryTime)
                    .HasColumnName("Supplier_Purchase_Order_CPO_Delivery_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierPurchaseOrderCurrencyId).HasColumnName("Supplier_Purchase_Order_Currency_ID");

                entity.Property(e => e.SupplierPurchaseOrderDate)
                    .HasColumnName("Supplier_Purchase_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierPurchaseOrderDelStatus).HasColumnName("Supplier_Purchase_Order_DelStatus");

                entity.Property(e => e.SupplierPurchaseOrderDiscAmt).HasColumnName("Supplier_Purchase_Order_Disc_Amt");

                entity.Property(e => e.SupplierPurchaseOrderDiscPercentage).HasColumnName("Supplier_Purchase_Order_Disc_Percentage");

                entity.Property(e => e.SupplierPurchaseOrderGrandTotal).HasColumnName("Supplier_Purchase_Order_Grand_Total");

                entity.Property(e => e.SupplierPurchaseOrderId).HasColumnName("Supplier_Purchase_Order_ID");

                entity.Property(e => e.SupplierPurchaseOrderInsId).HasColumnName("Supplier_Purchase_Order_INS_ID");

                entity.Property(e => e.SupplierPurchaseOrderIsLocalPurchase).HasColumnName("Supplier_Purchase_Order_IsLocalPurchase");

                entity.Property(e => e.SupplierPurchaseOrderNote)
                    .HasColumnName("Supplier_Purchase_Order_Note")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderPacking)
                    .HasColumnName("Supplier_Purchase_Order_Packing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderQuality)
                    .HasColumnName("Supplier_Purchase_Order_Quality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderRemarks)
                    .HasColumnName("Supplier_Purchase_Order_Remarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderSpoAboutId).HasColumnName("Supplier_Purchase_Order_SpoAbout_ID");

                entity.Property(e => e.SupplierPurchaseOrderSubject)
                    .HasColumnName("Supplier_Purchase_Order_Subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderTechDetails)
                    .HasColumnName("Supplier_Purchase_Order_Tech_Details")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderTerms)
                    .HasColumnName("Supplier_Purchase_Order_Terms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderTotal).HasColumnName("Supplier_Purchase_Order_Total");

                entity.Property(e => e.SupplierPurchaseOrderTraining)
                    .HasColumnName("Supplier_Purchase_Order_Training")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderWarranty)
                    .HasColumnName("Supplier_Purchase_Order_Warranty")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplierPurchaseOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Purchase_Order_Details");

                entity.Property(e => e.SupplierPurchaseOrderDetailsAmount).HasColumnName("Supplier_Purchase_Order_Details_Amount");

                entity.Property(e => e.SupplierPurchaseOrderDetailsDelStatus).HasColumnName("Supplier_Purchase_Order_Details_DelStatus");

                entity.Property(e => e.SupplierPurchaseOrderDetailsDescription)
                    .HasColumnName("Supplier_Purchase_Order_Details_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderDetailsDetailsId).HasColumnName("Supplier_Purchase_Order_Details_Details_ID");

                entity.Property(e => e.SupplierPurchaseOrderDetailsIsEdited).HasColumnName("Supplier_Purchase_Order_Details_IsEdited");

                entity.Property(e => e.SupplierPurchaseOrderDetailsItemId).HasColumnName("Supplier_Purchase_Order_Details_Item_ID");

                entity.Property(e => e.SupplierPurchaseOrderDetailsQty).HasColumnName("Supplier_Purchase_Order_Details_QTY");

                entity.Property(e => e.SupplierPurchaseOrderDetailsSlno).HasColumnName("Supplier_Purchase_Order_Details_Slno");

                entity.Property(e => e.SupplierPurchaseOrderDetailsSpoId).HasColumnName("Supplier_Purchase_Order_Details_SPO_ID");

                entity.Property(e => e.SupplierPurchaseOrderDetailsUnitId).HasColumnName("Supplier_Purchase_Order_Details_Unit_ID");

                entity.Property(e => e.SupplierPurchaseOrderDetailsUnitPrice).HasColumnName("Supplier_Purchase_Order_Details_Unit_Price");
            });

            modelBuilder.Entity<SupplierQuotation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Quotation");

                entity.Property(e => e.SupplierQuotationCbm)
                    .HasColumnName("Supplier_Quotation_CBM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierQuotationCurrencyId).HasColumnName("Supplier_Quotation_Currency_ID");

                entity.Property(e => e.SupplierQuotationDate)
                    .HasColumnName("Supplier_Quotation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierQuotationDelStatus).HasColumnName("Supplier_Quotation_DelStatus");

                entity.Property(e => e.SupplierQuotationDiscAmt).HasColumnName("Supplier_Quotation_Disc_Amt");

                entity.Property(e => e.SupplierQuotationDiscPercentage).HasColumnName("Supplier_Quotation_Disc_percentage");

                entity.Property(e => e.SupplierQuotationEnqDetId).HasColumnName("Supplier_Quotation_Enq_Det_ID");

                entity.Property(e => e.SupplierQuotationEnqId).HasColumnName("Supplier_Quotation_Enq_ID");

                entity.Property(e => e.SupplierQuotationGtotal).HasColumnName("Supplier_Quotation_Gtotal");

                entity.Property(e => e.SupplierQuotationId).HasColumnName("Supplier_Quotation_ID");

                entity.Property(e => e.SupplierQuotationJobNo).HasColumnName("Supplier_Quotation_Job_No");

                entity.Property(e => e.SupplierQuotationRemarks)
                    .HasColumnName("Supplier_Quotation_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierQuotationStatus)
                    .HasColumnName("Supplier_Quotation_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierQuotationSupplierId).HasColumnName("Supplier_Quotation_Supplier_ID");

                entity.Property(e => e.SupplierQuotationWeight)
                    .HasColumnName("Supplier_Quotation_Weight")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplierQuotationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_Quotation_Details");

                entity.Property(e => e.SupplierQuotationDetailsAmount).HasColumnName("Supplier_Quotation_Details_Amount");

                entity.Property(e => e.SupplierQuotationDetailsDelStatus).HasColumnName("Supplier_Quotation_Details_DelStatus");

                entity.Property(e => e.SupplierQuotationDetailsDetId).HasColumnName("Supplier_Quotation_Details_Det_ID");

                entity.Property(e => e.SupplierQuotationDetailsDremarks)
                    .HasColumnName("Supplier_Quotation_Details_Dremarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierQuotationDetailsEnqDetId).HasColumnName("Supplier_Quotation_Details_Enq_Det_ID");

                entity.Property(e => e.SupplierQuotationDetailsFcAmount).HasColumnName("Supplier_Quotation_Details_FC_Amount");

                entity.Property(e => e.SupplierQuotationDetailsId).HasColumnName("Supplier_Quotation_Details_ID");

                entity.Property(e => e.SupplierQuotationDetailsIsEdiat).HasColumnName("Supplier_Quotation_Details_IsEdiat");

                entity.Property(e => e.SupplierQuotationDetailsMaterialId).HasColumnName("Supplier_Quotation_Details_Material_ID");

                entity.Property(e => e.SupplierQuotationDetailsQty).HasColumnName("Supplier_Quotation_Details_Qty");

                entity.Property(e => e.SupplierQuotationDetailsRate).HasColumnName("Supplier_Quotation_Details_Rate");

                entity.Property(e => e.SupplierQuotationDetailsSno).HasColumnName("Supplier_Quotation_Details_Sno");

                entity.Property(e => e.SupplierQuotationDetailsUnitId).HasColumnName("Supplier_Quotation_Details_Unit_ID");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SuppliersInsId);

                entity.Property(e => e.SuppliersInsId)
                    .HasColumnName("Suppliers_INS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuppliersCityId).HasColumnName("Suppliers_City_ID");

                entity.Property(e => e.SuppliersConsup).HasColumnName("Suppliers_Consup");

                entity.Property(e => e.SuppliersContactPerson)
                    .HasColumnName("Suppliers_Contact_Person")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersCreditDays).HasColumnName("Suppliers_Credit_Days");

                entity.Property(e => e.SuppliersCreditLimit).HasColumnName("Suppliers_Credit_Limit");

                entity.Property(e => e.SuppliersCrl).HasColumnName("Suppliers_Crl");

                entity.Property(e => e.SuppliersCrp).HasColumnName("Suppliers_Crp");

                entity.Property(e => e.SuppliersCtId).HasColumnName("Suppliers_CT_ID");

                entity.Property(e => e.SuppliersCurrencyId).HasColumnName("Suppliers_Currency_ID");

                entity.Property(e => e.SuppliersDelStatus).HasColumnName("Suppliers_DelStatus");

                entity.Property(e => e.SuppliersDeleteStatus).HasColumnName("Suppliers_DeleteStatus");

                entity.Property(e => e.SuppliersEmail)
                    .HasColumnName("Suppliers_Email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersFax)
                    .HasColumnName("Suppliers_Fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersGroupNo)
                    .HasColumnName("Suppliers_Group_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersInsName)
                    .HasColumnName("Suppliers_INS_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersInsReffAcNo)
                    .HasColumnName("Suppliers_INS_Reff_AC_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersLocationId).HasColumnName("Suppliers_Location_ID");

                entity.Property(e => e.SuppliersMobile)
                    .HasColumnName("Suppliers_Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersPaymentTerms)
                    .HasColumnName("Suppliers_Payment_Terms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersPoBox)
                    .HasColumnName("Suppliers_PO_Box")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersRemarks)
                    .HasColumnName("Suppliers_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersStatus).HasColumnName("Suppliers_Status");

                entity.Property(e => e.SuppliersStatusVal).HasColumnName("Suppliers_StatusVal");

                entity.Property(e => e.SuppliersSupplierType)
                    .HasColumnName("Suppliers_Supplier_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SuppliersTel1)
                    .HasColumnName("Suppliers_Tel1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersTel2)
                    .HasColumnName("Suppliers_Tel2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersTrno)
                    .HasColumnName("Suppliers_TRNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersUserId).HasColumnName("Suppliers_User_ID");

                entity.Property(e => e.SuppliersVatNo)
                    .HasColumnName("Suppliers_VAT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersWebSite)
                    .HasColumnName("Suppliers_WebSite")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuppliersMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Suppliers_Master");

                entity.Property(e => e.SuppliersMasterSupplierCityId).HasColumnName("Suppliers_Master_Supplier_City_ID");

                entity.Property(e => e.SuppliersMasterSupplierConsup).HasColumnName("Suppliers_Master_Supplier_Consup");

                entity.Property(e => e.SuppliersMasterSupplierContactPerson)
                    .HasColumnName("Suppliers_Master_Supplier_Contact_Person")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierCountryId).HasColumnName("Suppliers_Master_Supplier_Country_ID");

                entity.Property(e => e.SuppliersMasterSupplierCreditDays).HasColumnName("Suppliers_Master_Supplier_Credit_Days");

                entity.Property(e => e.SuppliersMasterSupplierCreditLimit).HasColumnName("Suppliers_Master_Supplier_Credit_Limit");

                entity.Property(e => e.SuppliersMasterSupplierCrl).HasColumnName("Suppliers_Master_Supplier_CRL");

                entity.Property(e => e.SuppliersMasterSupplierCurrencyId).HasColumnName("Suppliers_Master_Supplier_Currency_ID");

                entity.Property(e => e.SuppliersMasterSupplierDelStatus).HasColumnName("Suppliers_Master_Supplier_DelStatus");

                entity.Property(e => e.SuppliersMasterSupplierDeleteStatus).HasColumnName("Suppliers_Master_Supplier_Delete_Status");

                entity.Property(e => e.SuppliersMasterSupplierEmail)
                    .HasColumnName("Suppliers_Master_Supplier_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierFax)
                    .HasColumnName("Suppliers_Master_Supplier_FAX")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierId).HasColumnName("Suppliers_Master_Supplier_ID");

                entity.Property(e => e.SuppliersMasterSupplierLocation)
                    .HasColumnName("Suppliers_Master_Supplier_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierMobile)
                    .HasColumnName("Suppliers_Master_Supplier_Mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierName)
                    .HasColumnName("Suppliers_Master_Supplier_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierPaymentTerms)
                    .HasColumnName("Suppliers_Master_Supplier_Payment_Terms")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierPoBox)
                    .HasColumnName("Suppliers_Master_Supplier_PO_BOX")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierReffAcNo)
                    .HasColumnName("Suppliers_Master_Supplier_Reff_AC_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierRemarks)
                    .HasColumnName("Suppliers_Master_Supplier_Remarks")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierStatus).HasColumnName("Suppliers_Master_Supplier_Status");

                entity.Property(e => e.SuppliersMasterSupplierStatusValue).HasColumnName("Suppliers_Master_Supplier_Status_Value");

                entity.Property(e => e.SuppliersMasterSupplierTel1)
                    .HasColumnName("Suppliers_Master_Supplier_Tel1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierTel2)
                    .HasColumnName("Suppliers_Master_Supplier_Tel2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierType)
                    .HasColumnName("Suppliers_Master_Supplier_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SuppliersMasterSupplierUserId).HasColumnName("Suppliers_Master_Supplier_User_ID");

                entity.Property(e => e.SuppliersMasterSupplierVatNo)
                    .HasColumnName("Suppliers_Master_Supplier_VAT_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersMasterSupplierWebSite)
                    .HasColumnName("Suppliers_Master_Supplier_Web_Site")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempAgeingRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_AgeingRpt");

                entity.Property(e => e.TempAgeingRpt1).HasColumnName("Temp_AgeingRpt");

                entity.Property(e => e.TempAgeingRptA030days).HasColumnName("Temp_AgeingRpt_A0_30Days");

                entity.Property(e => e.TempAgeingRptA181270days).HasColumnName("Temp_AgeingRpt_A181_270Days");

                entity.Property(e => e.TempAgeingRptA271360days).HasColumnName("Temp_AgeingRpt_A271_360Days");

                entity.Property(e => e.TempAgeingRptA3160days).HasColumnName("Temp_AgeingRpt_A31_60Days");

                entity.Property(e => e.TempAgeingRptA6190days).HasColumnName("Temp_AgeingRpt_A61_90Days");

                entity.Property(e => e.TempAgeingRptA91180days).HasColumnName("Temp_AgeingRpt_A91_180Days");

                entity.Property(e => e.TempAgeingRptAccNo)
                    .HasColumnName("Temp_AgeingRpt_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempAgeingRptCreditLimit).HasColumnName("Temp_AgeingRpt_Credit_Limit");

                entity.Property(e => e.TempAgeingRptCurBalance).HasColumnName("Temp_AgeingRpt_CurBalance");

                entity.Property(e => e.TempAgeingRptName)
                    .HasColumnName("Temp_AgeingRpt_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempAgeingRptOutstandingBal).HasColumnName("Temp_AgeingRpt_OutstandingBal");

                entity.Property(e => e.TempAgeingRptOver360Days).HasColumnName("Temp_AgeingRpt_Over360Days");

                entity.Property(e => e.TempAgeingRptUnallocBal).HasColumnName("Temp_AgeingRpt_UnallocBal");
            });

            modelBuilder.Entity<TempAssetDepCalc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_AssetDepCalc");

                entity.Property(e => e.TempAssetDepCalcAccDepAmt).HasColumnName("Temp_AssetDepCalc_AccDepAmt");

                entity.Property(e => e.TempAssetDepCalcAmount).HasColumnName("Temp_AssetDepCalc_Amount");

                entity.Property(e => e.TempAssetDepCalcBookValue).HasColumnName("Temp_AssetDepCalc_BookValue");

                entity.Property(e => e.TempAssetDepCalcDelStatus).HasColumnName("Temp_AssetDepCalc_DelStatus");

                entity.Property(e => e.TempAssetDepCalcDepAmount).HasColumnName("Temp_AssetDepCalc_DepAmount");

                entity.Property(e => e.TempAssetDepCalcDepFrom)
                    .HasColumnName("Temp_AssetDepCalc_DepFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempAssetDepCalcDepPercentage).HasColumnName("Temp_AssetDepCalc_Dep_Percentage");

                entity.Property(e => e.TempAssetDepCalcDepTo)
                    .HasColumnName("Temp_AssetDepCalc_DepTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempAssetDepCalcId).HasColumnName("Temp_AssetDepCalc_ID");

                entity.Property(e => e.TempAssetDepCalcNetBookValue).HasColumnName("Temp_AssetDepCalc_NetBookValue");

                entity.Property(e => e.TempAssetDepCalcPurchaseDate)
                    .HasColumnName("Temp_AssetDepCalc_Purchase_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempAssetDepCalcPurchaseId)
                    .HasColumnName("Temp_AssetDepCalc_Purchase_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempBalanceSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Balance_Sheet");

                entity.Property(e => e.TempBalanceSheetAccName)
                    .HasColumnName("Temp_Balance_Sheet_AccName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetAccNo)
                    .HasColumnName("Temp_Balance_Sheet_AccNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetCreditBalance).HasColumnName("Temp_Balance_Sheet_CreditBalance");

                entity.Property(e => e.TempBalanceSheetDebitBalance).HasColumnName("Temp_Balance_Sheet_DebitBalance");

                entity.Property(e => e.TempBalanceSheetDelStatus).HasColumnName("Temp_Balance_Sheet_DelStatus");

                entity.Property(e => e.TempBalanceSheetMainHead)
                    .HasColumnName("Temp_Balance_Sheet_MainHead")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetRelativeName)
                    .HasColumnName("Temp_Balance_Sheet_RelativeName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetRelativeNo)
                    .HasColumnName("Temp_Balance_Sheet_RelativeNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetSubHead)
                    .HasColumnName("Temp_Balance_Sheet_SubHead")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempBalanceSheetTotalCredit).HasColumnName("Temp_Balance_Sheet_TotalCredit");

                entity.Property(e => e.TempBalanceSheetTotalDebit).HasColumnName("Temp_Balance_Sheet_TotalDebit");
            });

            modelBuilder.Entity<TempCashBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_CashBook");

                entity.Property(e => e.TempCashBookAccNo)
                    .HasColumnName("Temp_CashBook_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempCashBookCredit).HasColumnName("Temp_CashBook_Credit");

                entity.Property(e => e.TempCashBookDebit).HasColumnName("Temp_CashBook_Debit");

                entity.Property(e => e.TempCashBookDelStatus).HasColumnName("Temp_CashBook_DelStatus");

                entity.Property(e => e.TempCashBookDescription)
                    .HasColumnName("Temp_CashBook_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempCashBookInvType)
                    .HasColumnName("Temp_CashBook_Inv_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempCashBookSlNo).HasColumnName("Temp_CashBook_SlNo");

                entity.Property(e => e.TempCashBookVdate)
                    .HasColumnName("Temp_CashBook_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempCashBookVno)
                    .HasColumnName("Temp_CashBook_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCashFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_CashFlow");

                entity.Property(e => e.TempCashFlowAccName)
                    .HasColumnName("Temp_CashFlow_AccName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempCashFlowAccNo)
                    .HasColumnName("Temp_CashFlow_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempCashFlowBal).HasColumnName("Temp_CashFlow_Bal");

                entity.Property(e => e.TempCashFlowCashOutCredit).HasColumnName("Temp_CashFlow_CashOut_Credit");

                entity.Property(e => e.TempCashFlowCashinDebit).HasColumnName("Temp_CashFlow_Cashin_Debit");

                entity.Property(e => e.TempCashFlowDelStatus).HasColumnName("Temp_CashFlow_DelStatus");

                entity.Property(e => e.TempCashFlowId).HasColumnName("Temp_CashFlow_ID");

                entity.Property(e => e.TempCashFlowRunBal).HasColumnName("Temp_CashFlow_RunBal");

                entity.Property(e => e.TempCashFlowTransDate)
                    .HasColumnName("Temp_CashFlow_Trans_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TempDayBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_DayBook");

                entity.Property(e => e.TempDayBookCredit).HasColumnName("Temp_DayBook_Credit");

                entity.Property(e => e.TempDayBookDebit).HasColumnName("Temp_DayBook_Debit");

                entity.Property(e => e.TempDayBookDelStatus).HasColumnName("Temp_DayBook_DelStatus");

                entity.Property(e => e.TempDayBookDescription)
                    .HasColumnName("Temp_DayBook_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempDayBookParticulars)
                    .HasColumnName("Temp_DayBook_Particulars")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempDayBookRefNo)
                    .HasColumnName("Temp_DayBook_RefNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempDayBookSlNo).HasColumnName("Temp_DayBook_SlNo");

                entity.Property(e => e.TempDayBookVdate)
                    .HasColumnName("Temp_DayBook_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempDayBookVno)
                    .HasColumnName("Temp_DayBook_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempJobCostSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_JobCostSummary");

                entity.Property(e => e.TempJobCostSummaryDelStatus).HasColumnName("Temp_jobCostSummary_DelStatus");

                entity.Property(e => e.TempJobCostSummaryInvoiceTotal).HasColumnName("Temp_JobCostSummary_InvoiceTotal");

                entity.Property(e => e.TempJobCostSummaryJobNo)
                    .HasColumnName("Temp_JobCostSummary_JobNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempJobCostSummaryJobValue).HasColumnName("Temp_JobCostSummary_JobValue");

                entity.Property(e => e.TempJobCostSummaryLabourCost).HasColumnName("Temp_JobCostSummary_LabourCost");

                entity.Property(e => e.TempJobCostSummaryMatCost).HasColumnName("Temp_JobCostSummary_MatCost");

                entity.Property(e => e.TempJobCostSummaryOverHead).HasColumnName("Temp_JobCostSummary_OverHead");

                entity.Property(e => e.TempJobCostSummaryProfit).HasColumnName("Temp_JobCostSummary_Profit");

                entity.Property(e => e.TempJobCostSummaryTotCost).HasColumnName("Temp_JobCostSummary_TotCost");
            });

            modelBuilder.Entity<TempMisStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_MisStatement");

                entity.Property(e => e.TempMisStatementAmount).HasColumnName("Temp_MisStatement_Amount");

                entity.Property(e => e.TempMisStatementDelStatus).HasColumnName("Temp_MisStatement_DelStatus");

                entity.Property(e => e.TempMisStatementDesc)
                    .HasColumnName("Temp_MisStatement_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempMisStatementSlNo).HasColumnName("Temp_MisStatement_SlNo");

                entity.Property(e => e.TempMisStatementVdate)
                    .HasColumnName("Temp_MisStatement_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempMisStatementVno)
                    .HasColumnName("Temp_MisStatement_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempMisStatementVtype)
                    .HasColumnName("Temp_MisStatement_Vtype")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempPlforecast>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_PLForecast");

                entity.Property(e => e.TempPlforecastAccName)
                    .HasColumnName("Temp_PLForecast_AccName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlforecastAccNo)
                    .HasColumnName("Temp_PLForecast_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlforecastDelStatus).HasColumnName("Temp_PLForecast_DelStatus");

                entity.Property(e => e.TempPlforecastMainHead)
                    .HasColumnName("Temp_PLForecast_Main_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlforecastMonthToday).HasColumnName("Temp_PLForecast_MonthToday");

                entity.Property(e => e.TempPlforecastSubHead)
                    .HasColumnName("Temp_PLForecast_Sub_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlforecastYearToday).HasColumnName("Temp_PLForecast_YearToday");
            });

            modelBuilder.Entity<TempPlwithDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_PLWithDate");

                entity.Property(e => e.TempPlwithDateAccName)
                    .HasColumnName("Temp_PLWithDate_AccName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlwithDateAccNo)
                    .HasColumnName("Temp_PLWithDate_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlwithDateDelStatus).HasColumnName("Temp_PLWithDate_DelStatus");

                entity.Property(e => e.TempPlwithDateMainHead)
                    .HasColumnName("Temp_PLWithDate_Main_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlwithDateSubHead)
                    .HasColumnName("Temp_PLWithDate_Sub_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempPlwithDateTotCredit).HasColumnName("Temp_PLWithDate_TotCredit");

                entity.Property(e => e.TempPlwithDateTotDebit).HasColumnName("Temp_PLWithDate_TotDebit");

                entity.Property(e => e.TempPlwithDateTransDate)
                    .HasColumnName("Temp_PLWithDate_TransDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TempProfitLoss>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Profit_Loss");

                entity.Property(e => e.TempProfitLossAcName)
                    .HasColumnName("Temp_Profit_Loss_Ac_Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TempProfitLossAcNo)
                    .HasColumnName("Temp_Profit_Loss_Ac_No")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempProfitLossDelStatus).HasColumnName("Temp_Profit_Loss_DelStatus");

                entity.Property(e => e.TempProfitLossMainHead)
                    .HasColumnName("Temp_Profit_Loss_Main_Head")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempProfitLossSubHead)
                    .HasColumnName("Temp_Profit_Loss_Sub_Head")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempProfitLossTotalCredit).HasColumnName("Temp_Profit_Loss_Total_Credit");

                entity.Property(e => e.TempProfitLossTotalDebit).HasColumnName("Temp_Profit_Loss_Total_Debit");
            });

            modelBuilder.Entity<TempSalesJournalDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_SalesJournal_Details");

                entity.Property(e => e.TempSalesJournalDetailsAmtDh).HasColumnName("Temp_SalesJournal_Details_AmtDH");

                entity.Property(e => e.TempSalesJournalDetailsAmtDollar).HasColumnName("Temp_SalesJournal_Details_AmtDollar");

                entity.Property(e => e.TempSalesJournalDetailsCargoValue).HasColumnName("Temp_SalesJournal_Details_CargoValue");

                entity.Property(e => e.TempSalesJournalDetailsDelStatus).HasColumnName("Temp_SalesJournal_Details_DelStatus");

                entity.Property(e => e.TempSalesJournalDetailsGrossWt).HasColumnName("Temp_SalesJournal_Details_GrossWt");

                entity.Property(e => e.TempSalesJournalDetailsId).HasColumnName("Temp_SalesJournal_Details_ID");

                entity.Property(e => e.TempSalesJournalDetailsPack).HasColumnName("Temp_SalesJournal_Details_Pack");

                entity.Property(e => e.TempSalesJournalDetailsSno).HasColumnName("Temp_SalesJournal_Details_SNO");

                entity.Property(e => e.TempSalesJournalDetailsTotAmtDollar).HasColumnName("Temp_SalesJournal_Details_TotAmtDollar");

                entity.Property(e => e.TempSalesJournalDetailsTotalAmtDh).HasColumnName("Temp_SalesJournal_Details_TotalAmtDH");
            });

            modelBuilder.Entity<TempStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Statement_");

                entity.Property(e => e.TempStatementAccNo)
                    .HasColumnName("Temp_Statement_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementBalance).HasColumnName("Temp_Statement_Balance");

                entity.Property(e => e.TempStatementCostCenter)
                    .HasColumnName("Temp_Statement_CostCenter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementCredit).HasColumnName("Temp_Statement_Credit");

                entity.Property(e => e.TempStatementDebit).HasColumnName("Temp_Statement_Debit");

                entity.Property(e => e.TempStatementDelStatus).HasColumnName("Temp_Statement_DelStatus");

                entity.Property(e => e.TempStatementDesc)
                    .HasColumnName("Temp_Statement_Desc")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementRemarks)
                    .HasColumnName("Temp_Statement_Remarks")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementSno).HasColumnName("Temp_Statement_Sno");

                entity.Property(e => e.TempStatementVdate)
                    .HasColumnName("Temp_Statement_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempStatementVno)
                    .HasColumnName("Temp_Statement_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVtype)
                    .HasColumnName("Temp_Statement_Vtype")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStatementVat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Statement_VAT_");

                entity.Property(e => e.TempStatementVatAccNo)
                    .HasColumnName("Temp_Statement_VAT_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatBalance).HasColumnName("Temp_Statement_VAT_Balance");

                entity.Property(e => e.TempStatementVatCostCenter)
                    .HasColumnName("Temp_Statement_VAT_CostCenter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatCredit).HasColumnName("Temp_Statement_VAT_Credit");

                entity.Property(e => e.TempStatementVatDebit).HasColumnName("Temp_Statement_VAT_Debit");

                entity.Property(e => e.TempStatementVatDelStatus).HasColumnName("Temp_Statement_VAT_DelStatus");

                entity.Property(e => e.TempStatementVatDepartment)
                    .HasColumnName("Temp_Statement_VAT_Department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatDesc)
                    .HasColumnName("Temp_Statement_VAT_Desc")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatPartyName)
                    .HasColumnName("Temp_Statement_VAT_PartyName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatRemarks)
                    .HasColumnName("Temp_Statement_VAT_Remarks")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatSlno).HasColumnName("Temp_Statement_VAT_Slno");

                entity.Property(e => e.TempStatementVatVatableAmt).HasColumnName("Temp_Statement_VAT_VatableAmt");

                entity.Property(e => e.TempStatementVatVatno)
                    .HasColumnName("Temp_Statement_VAT_VATNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatVdate)
                    .HasColumnName("Temp_Statement_VAT_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempStatementVatVno)
                    .HasColumnName("Temp_Statement_VAT_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatementVatVtype)
                    .HasColumnName("Temp_Statement_VAT_Vtype")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStkMovement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_StkMovement");

                entity.Property(e => e.TempStkMovementAmount).HasColumnName("Temp_StkMovement_Amount");

                entity.Property(e => e.TempStkMovementDelStatus).HasColumnName("Temp_StkMovement_DelStatus");

                entity.Property(e => e.TempStkMovementQtyIn).HasColumnName("Temp_StkMovement_QtyIN");

                entity.Property(e => e.TempStkMovementQtyOut).HasColumnName("Temp_StkMovement_QtyOut");

                entity.Property(e => e.TempStkMovementTotAmt).HasColumnName("Temp_StkMovement_TotAmt");

                entity.Property(e => e.TempStkMovementVdate)
                    .HasColumnName("Temp_StkMovement_Vdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempStkMovementVno)
                    .HasColumnName("Temp_StkMovement_Vno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStkMovementVtype)
                    .HasColumnName("Temp_StkMovement_Vtype")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStockBaseUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Stock_BaseUnit");

                entity.Property(e => e.TempStockBaseUnitAmount).HasColumnName("Temp_Stock_BaseUnit_Amount");

                entity.Property(e => e.TempStockBaseUnitAvgRate).HasColumnName("Temp_Stock_BaseUnit_AvgRate");

                entity.Property(e => e.TempStockBaseUnitClosing).HasColumnName("Temp_Stock_BaseUnit_Closing");

                entity.Property(e => e.TempStockBaseUnitDelStatus).HasColumnName("Temp_Stock_BaseUnit_DelStatus");

                entity.Property(e => e.TempStockBaseUnitMaterialId).HasColumnName("Temp_Stock_BaseUnit_Material_ID");

                entity.Property(e => e.TempStockBaseUnitOpening).HasColumnName("Temp_Stock_BaseUnit_Opening");

                entity.Property(e => e.TempStockBaseUnitSno).HasColumnName("Temp_Stock_BaseUnit_Sno");

                entity.Property(e => e.TempStockBaseUnitStock).HasColumnName("Temp_Stock_BaseUnit_Stock");

                entity.Property(e => e.TempStockBaseUnitUnit)
                    .HasColumnName("Temp_Stock_BaseUnit_Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStockLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Stock_Ledger");

                entity.Property(e => e.TempStockLedgerClosingQty).HasColumnName("Temp_Stock_Ledger_ClosingQty");

                entity.Property(e => e.TempStockLedgerClosingValue).HasColumnName("Temp_Stock_Ledger_ClosingValue");

                entity.Property(e => e.TempStockLedgerDelStatus).HasColumnName("Temp_Stock_Ledger_DelStatus");

                entity.Property(e => e.TempStockLedgerIssuedQty).HasColumnName("Temp_Stock_Ledger_IssuedQty");

                entity.Property(e => e.TempStockLedgerIssuedValue).HasColumnName("Temp_Stock_Ledger_IssuedValue");

                entity.Property(e => e.TempStockLedgerItemId).HasColumnName("Temp_Stock_Ledger_Item_ID");

                entity.Property(e => e.TempStockLedgerItemName)
                    .HasColumnName("Temp_Stock_Ledger_Item_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerOpenQty).HasColumnName("Temp_Stock_Ledger_OpenQty");

                entity.Property(e => e.TempStockLedgerOpenValue).HasColumnName("Temp_Stock_Ledger_OpenValue");

                entity.Property(e => e.TempStockLedgerRecvdQty).HasColumnName("Temp_Stock_Ledger_RecvdQty");

                entity.Property(e => e.TempStockLedgerRecvdValue).HasColumnName("Temp_Stock_Ledger_RecvdValue");

                entity.Property(e => e.TempStockLedgerRelativeName)
                    .HasColumnName("Temp_Stock_Ledger_Relative_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStockLedger1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_StockLedger");

                entity.Property(e => e.TempStockLedgerColNo1).HasColumnName("Temp_StockLedger_ColNo1");

                entity.Property(e => e.TempStockLedgerColNo2).HasColumnName("Temp_StockLedger_ColNo2");

                entity.Property(e => e.TempStockLedgerColNo3).HasColumnName("Temp_StockLedger_ColNo3");

                entity.Property(e => e.TempStockLedgerColumn1)
                    .HasColumnName("Temp_StockLedger_Column1")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerColumn2)
                    .HasColumnName("Temp_StockLedger_Column2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerColumn3)
                    .HasColumnName("Temp_StockLedger_Column3")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerColumnValue).HasColumnName("Temp_StockLedger_ColumnValue");

                entity.Property(e => e.TempStockLedgerDelStatus).HasColumnName("Temp_StockLedger_DelStatus");

                entity.Property(e => e.TempStockLedgerGroupId).HasColumnName("Temp_StockLedger_Group_ID");

                entity.Property(e => e.TempStockLedgerGroupName)
                    .HasColumnName("Temp_StockLedger_Group_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerIdentitypKey)
                    .HasColumnName("Temp_StockLedger_Identityp_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TempStockLedgerItemId).HasColumnName("Temp_StockLedger_Item_ID");

                entity.Property(e => e.TempStockLedgerUnit).HasColumnName("Temp_StockLedger_Unit");
            });

            modelBuilder.Entity<TempStockLedgerBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Stock_Ledger_Batch");

                entity.Property(e => e.TempStockLedgerBatchClosingQty).HasColumnName("Temp_Stock_Ledger_Batch_ClosingQty");

                entity.Property(e => e.TempStockLedgerBatchClosingValue).HasColumnName("Temp_Stock_Ledger_Batch_ClosingValue");

                entity.Property(e => e.TempStockLedgerBatchDelStatus).HasColumnName("Temp_Stock_Ledger_Batch_DelStatus");

                entity.Property(e => e.TempStockLedgerBatchIssuedQty).HasColumnName("Temp_Stock_Ledger_Batch_IssuedQty");

                entity.Property(e => e.TempStockLedgerBatchIssuedValue).HasColumnName("Temp_Stock_Ledger_Batch_IssuedValue");

                entity.Property(e => e.TempStockLedgerBatchItemId).HasColumnName("Temp_Stock_Ledger_Batch_Item_ID");

                entity.Property(e => e.TempStockLedgerBatchItemName)
                    .HasColumnName("Temp_Stock_Ledger_Batch_Item_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockLedgerBatchOpenQty).HasColumnName("Temp_Stock_Ledger_Batch_OpenQty");

                entity.Property(e => e.TempStockLedgerBatchOpenValue).HasColumnName("Temp_Stock_Ledger_Batch_OpenValue");

                entity.Property(e => e.TempStockLedgerBatchRecvdQty).HasColumnName("Temp_Stock_Ledger_Batch_RecvdQty");

                entity.Property(e => e.TempStockLedgerBatchRecvdValue).HasColumnName("Temp_Stock_Ledger_Batch_RecvdValue");

                entity.Property(e => e.TempStockLedgerBatchRelativeName)
                    .HasColumnName("Temp_Stock_Ledger_Batch_Relative_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempStockPostail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_StockPostail");

                entity.Property(e => e.TempStockPostailBatchCode)
                    .HasColumnName("Temp_StockPostail_BatchCode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockPostailDelStatus).HasColumnName("Temp_StockPostail_DelStatus");

                entity.Property(e => e.TempStockPostailExpiryDate)
                    .HasColumnName("Temp_StockPostail_ExpiryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempStockPostailItemId).HasColumnName("Temp_StockPostail_Item_ID");

                entity.Property(e => e.TempStockPostailStock).HasColumnName("Temp_StockPostail_Stock");
            });

            modelBuilder.Entity<TempStockpos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Stockpos");

                entity.Property(e => e.TempStockposConversionType).HasColumnName("Temp_Stockpos_Conversion_Type");

                entity.Property(e => e.TempStockposDefaultUnit)
                    .HasColumnName("Temp_Stockpos_Default_Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockposDelStatus).HasColumnName("Temp_Stockpos_DelStatus");

                entity.Property(e => e.TempStockposItemId).HasColumnName("Temp_Stockpos_Item_ID");

                entity.Property(e => e.TempStockposItemName)
                    .HasColumnName("Temp_Stockpos_Item_Name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.TempStockposNegativeBatchCount).HasColumnName("Temp_Stockpos_NegativeBatchCount");

                entity.Property(e => e.TempStockposStockBatch).HasColumnName("Temp_Stockpos_Stock_Batch");

                entity.Property(e => e.TempStockposStockItemId).HasColumnName("Temp_Stockpos_Stock_Item_ID");

                entity.Property(e => e.TempStockposStockVariation).HasColumnName("Temp_Stockpos_Stock_Variation");

                entity.Property(e => e.TempStockposTotalBatchCount).HasColumnName("Temp_Stockpos_TotalBatchCount");
            });

            modelBuilder.Entity<TermsAndCondition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Terms_And_Condition");

                entity.Property(e => e.TermsAndConditionTermsConditions)
                    .HasColumnName("Terms_And_Condition_Terms_Conditions")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAndConditionTermsDeleted).HasColumnName("Terms_And_Condition_Terms_Deleted");

                entity.Property(e => e.TermsAndConditionTermsId).HasColumnName("Terms_And_Condition_Terms_ID");

                entity.Property(e => e.TermsAndConditionsTermsDelStatus).HasColumnName("Terms_And_Conditions_Terms_DelStatus");
            });

            modelBuilder.Entity<TrackingRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tracking_Register");

                entity.Property(e => e.TrackingRegisterDelStatus).HasColumnName("Tracking_Register_DelStatus");

                entity.Property(e => e.TrackingRegisterDetailsId).HasColumnName("Tracking_Register_Details_ID");

                entity.Property(e => e.TrackingRegisterFsno).HasColumnName("Tracking_Register_FSNO");

                entity.Property(e => e.TrackingRegisterMaterialId).HasColumnName("Tracking_Register_Material_ID");

                entity.Property(e => e.TrackingRegisterQty).HasColumnName("Tracking_Register_QTY");

                entity.Property(e => e.TrackingRegisterQtyin).HasColumnName("Tracking_Register_QTYIN");

                entity.Property(e => e.TrackingRegisterQtyout).HasColumnName("Tracking_Register_QTYOut");

                entity.Property(e => e.TrackingRegisterRate).HasColumnName("Tracking_Register_Rate");

                entity.Property(e => e.TrackingRegisterRefVno)
                    .HasColumnName("Tracking_Register_RefVNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingRegisterSno).HasColumnName("Tracking_Register_Sno");

                entity.Property(e => e.TrackingRegisterTrackDate)
                    .HasColumnName("Tracking_Register_Track_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrackingRegisterTrackId)
                    .HasColumnName("Tracking_Register_Track_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackingRegisterVoucherNo)
                    .HasColumnName("Tracking_Register_VoucherNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingRegisterVoucherType)
                    .HasColumnName("Tracking_Register_VoucherType")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Trial_Balance");

                entity.Property(e => e.TrialBalanceAccName)
                    .HasColumnName("Trial_Balance_AccName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceAccNo)
                    .HasColumnName("Trial_Balance_AccNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceCreditBalance).HasColumnName("Trial_Balance_Credit_Balance");

                entity.Property(e => e.TrialBalanceDebitBalance).HasColumnName("Trial_Balance_Debit_Balance");

                entity.Property(e => e.TrialBalanceDelStatus).HasColumnName("Trial_Balance_DelStatus");

                entity.Property(e => e.TrialBalanceMainHead)
                    .HasColumnName("Trial_Balance_Main_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceNumericAccNo).HasColumnName("Trial_Balance_NumericAccNo");

                entity.Property(e => e.TrialBalanceOpenBalance).HasColumnName("Trial_Balance_Open_Balance");

                entity.Property(e => e.TrialBalanceRelativeName)
                    .HasColumnName("Trial_Balance_Relative_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceRelativeNo)
                    .HasColumnName("Trial_Balance_Relative_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceSubHead)
                    .HasColumnName("Trial_Balance_Sub_Head")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrialBalanceTotalCredit).HasColumnName("Trial_Balance_Total_Credit");

                entity.Property(e => e.TrialBalanceTotalDebit).HasColumnName("Trial_Balance_Total_Debit");
            });

            modelBuilder.Entity<TypeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Type_Master");

                entity.Property(e => e.TypeMasterDelStatus).HasColumnName("Type_Master_DelStatus");

                entity.Property(e => e.TypeMasterDeleted).HasColumnName("Type_Master_Deleted");

                entity.Property(e => e.TypeMasterStatus).HasColumnName("Type_Master_Status");

                entity.Property(e => e.TypeMasterTypeId).HasColumnName("Type_Master_Type_ID");

                entity.Property(e => e.TypeMasterTypeName)
                    .HasColumnName("Type_Master_Type_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMasterUserId).HasColumnName("Type_Master_User_ID");

                entity.Property(e => e.TypeMasterVendorId).HasColumnName("Type_Master_Vendor_ID");
            });

            modelBuilder.Entity<UnitDetails>(entity =>
            {
                entity.ToTable("Unit_Details");

                entity.Property(e => e.UnitDetailsId).HasColumnName("Unit_Details_ID");

                entity.Property(e => e.UnitDetailsConversionType).HasColumnName("Unit_Details_ConversionType");

                entity.Property(e => e.UnitDetailsDefUnit).HasColumnName("Unit_Details_DefUnit");

                entity.Property(e => e.UnitDetailsDefWunit).HasColumnName("Unit_Details_DefWUnit");

                entity.Property(e => e.UnitDetailsDelStatus).HasColumnName("Unit_Details_DelStatus");

                entity.Property(e => e.UnitDetailsHeight)
                    .HasColumnName("Unit_Details_Height")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitDetailsItemId).HasColumnName("Unit_Details_Item_ID");

                entity.Property(e => e.UnitDetailsRate).HasColumnName("Unit_Details_Rate");

                entity.Property(e => e.UnitDetailsReorder)
                    .HasColumnName("Unit_Details_Reorder")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitDetailsUnitId).HasColumnName("Unit_Details_Unit_ID");

                entity.Property(e => e.UnitDetailsWidth)
                    .HasColumnName("Unit_Details_Width")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitDetailsWrate).HasColumnName("Unit_Details_Wrate");

                entity.HasOne(d => d.UnitDetailsItem)
                    .WithMany(p => p.UnitDetails)
                    .HasForeignKey(d => d.UnitDetailsItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Unit_Details_Unit_Details");

                entity.HasOne(d => d.UnitDetailsUnit)
                    .WithMany(p => p.UnitDetails)
                    .HasForeignKey(d => d.UnitDetailsUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Unit_Details_Unit_Master");
            });

            modelBuilder.Entity<UnitMaster>(entity =>
            {
                entity.HasKey(e => e.UnitMasterUnitId);

                entity.ToTable("Unit_Master");

                entity.Property(e => e.UnitMasterUnitId)
                    .HasColumnName("Unit_Master_Unit_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitMasterUnitDelStatus).HasColumnName("Unit_Master_Unit_DelStatus");

                entity.Property(e => e.UnitMasterUnitDescription)
                    .HasColumnName("Unit_Master_Unit_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitMasterUnitFullName)
                    .HasColumnName("Unit_Master_Unit_Full_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitMasterUnitShortName)
                    .HasColumnName("Unit_Master_Unit_Short_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitMasterUnitStatus).HasColumnName("Unit_Master_Unit_Status");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_Permission");

                entity.Property(e => e.UserPermissionDelStatus).HasColumnName("User_Permission_DelStatus");

                entity.Property(e => e.UserPermissionFormId).HasColumnName("User_Permission_Form_ID");

                entity.Property(e => e.UserPermissionSno)
                    .HasColumnName("User_Permission_Sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserPermissionUadd).HasColumnName("User_Permission_UAdd");

                entity.Property(e => e.UserPermissionUallow).HasColumnName("User_Permission_UAllow");

                entity.Property(e => e.UserPermissionUdelete).HasColumnName("User_Permission_UDelete");

                entity.Property(e => e.UserPermissionUedit).HasColumnName("User_Permission_UEdit");

                entity.Property(e => e.UserPermissionUprint).HasColumnName("User_Permission_UPrint");

                entity.Property(e => e.UserPermissionUview).HasColumnName("User_Permission_UView");

                entity.Property(e => e.UserPermissionWorkGroupId).HasColumnName("User_Permission_WorkGroup_ID");
            });

            modelBuilder.Entity<UserTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_Tracking");

                entity.Property(e => e.UserTrackingUserChangeDt)
                    .HasColumnName("User_Tracking_User_Change_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserTrackingUserChangeTime)
                    .HasColumnName("User_Tracking_User_Change_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserTrackingUserDelStatus).HasColumnName("User_Tracking_User_DelStatus");

                entity.Property(e => e.UserTrackingUserFsno).HasColumnName("User_Tracking_User_FSNO");

                entity.Property(e => e.UserTrackingUserNo)
                    .HasColumnName("User_Tracking_User_No")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserTrackingUserUserId).HasColumnName("User_Tracking_User_User_ID");

                entity.Property(e => e.UserTrackingUserVpAction)
                    .HasColumnName("User_Tracking_User_VP_Action")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserTrackingUserVpNo)
                    .HasColumnName("User_Tracking_User_VP_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTrackingUserVpType)
                    .HasColumnName("User_Tracking_User_VP_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserWebAccSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_WebAccSettings");

                entity.Property(e => e.UserWebAccSettingsCreateDateTime)
                    .HasColumnName("User_WebAccSettings_CreateDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserWebAccSettingsCreateUser).HasColumnName("User_WebAccSettings_CreateUser");

                entity.Property(e => e.UserWebAccSettingsDefaultMail).HasColumnName("User_WebAccSettings_Default_Mail");

                entity.Property(e => e.UserWebAccSettingsDelStatus).HasColumnName("User_WebAccSettings_DelStatus");

                entity.Property(e => e.UserWebAccSettingsEnableSsi).HasColumnName("User_WebAccSettings_EnableSSI");

                entity.Property(e => e.UserWebAccSettingsId).HasColumnName("User_WebAccSettings_ID");

                entity.Property(e => e.UserWebAccSettingsIsBodyHtml).HasColumnName("User_WebAccSettings_IsBodyHTML");

                entity.Property(e => e.UserWebAccSettingsLastUpdateDateTime)
                    .HasColumnName("User_WebAccSettings_LastUpdate_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserWebAccSettingsLastUpdateUser).HasColumnName("User_WebAccSettings_LastUpdate_User");

                entity.Property(e => e.UserWebAccSettingsPort).HasColumnName("User_WebAccSettings_Port");

                entity.Property(e => e.UserWebAccSettingsServerName)
                    .HasColumnName("User_WebAccSettings_ServerName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserWebAccSettingsSmtp)
                    .HasColumnName("User_WebAccSettings_SMTP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserWebAccSettingsUapwd)
                    .HasColumnName("User_WebAccSettings_UAPwd")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserWebAccSettingsUserAccount)
                    .HasColumnName("User_WebAccSettings_User_Account")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Vendor_Master");

                entity.Property(e => e.VendorMasterVendorAddress)
                    .HasColumnName("Vendor_Master_Vendor_Address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VendorMasterVendorDelStatus).HasColumnName("Vendor_Master_Vendor_DelStatus");

                entity.Property(e => e.VendorMasterVendorEmail)
                    .HasColumnName("Vendor_Master_Vendor_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorMasterVendorFax)
                    .HasColumnName("Vendor_Master_Vendor_Fax")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorMasterVendorId).HasColumnName("Vendor_Master_Vendor_ID");

                entity.Property(e => e.VendorMasterVendorName)
                    .HasColumnName("Vendor_Master_Vendor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorMasterVendorPhone)
                    .HasColumnName("Vendor_Master_Vendor_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorMasterVendorStatus).HasColumnName("Vendor_Master_Vendor_Status");
            });

            modelBuilder.Entity<VouchersNumbers>(entity =>
            {
                entity.HasKey(e => e.VouchersNumbersVsno)
                    .HasName("PrimaryKeyVOUCHERSno");

                entity.ToTable("Vouchers_Numbers");

                entity.HasIndex(e => e.VouchersNumbersVNo)
                    .HasName("UNIQUEVNumber")
                    .IsUnique();

                entity.Property(e => e.VouchersNumbersVsno)
                    .HasColumnName("Vouchers_Numbers_VSNO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VouchersNumbersFsno)
                    .HasColumnName("Vouchers_Numbers_FSNO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VouchersNumbersLocationId)
                    .HasColumnName("Vouchers_Numbers_LocationID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VouchersNumbersStatus)
                    .HasColumnName("Vouchers_Numbers_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VouchersNumbersVNo)
                    .IsRequired()
                    .HasColumnName("Vouchers_Numbers_V_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VouchersNumbersVNoNu)
                    .HasColumnName("Vouchers_Numbers_V_NO_NU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VouchersNumbersVType)
                    .HasColumnName("Vouchers_Numbers_V_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VouchersNumbersVoucherDate)
                    .HasColumnName("Vouchers_Numbers_VoucherDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VouhersNumbersDelStatus)
                    .HasColumnName("Vouhers_Numbers_DelStatus")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WorkGroupMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkGroup_Master");

                entity.Property(e => e.WorkGroupMasterWorkGroupDelStatus).HasColumnName("WorkGroup_Master_WorkGroup_DelStatus");

                entity.Property(e => e.WorkGroupMasterWorkGroupId).HasColumnName("WorkGroup_Master_WorkGroup_ID");

                entity.Property(e => e.WorkGroupMasterWorkGroupName)
                    .HasColumnName("WorkGroup_Master_WorkGroup_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkGroupPermissions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkGroup_Permissions");

                entity.Property(e => e.WorkGroupPermissionsDelStatus).HasColumnName("WorkGroup_Permissions_DelStatus");

                entity.Property(e => e.WorkGroupPermissionsFormId).HasColumnName("WorkGroup_Permissions_Form_ID");

                entity.Property(e => e.WorkGroupPermissionsSno)
                    .HasColumnName("WorkGroup_Permissions_Sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WorkGroupPermissionsUadd).HasColumnName("WorkGroup_Permissions_UAdd");

                entity.Property(e => e.WorkGroupPermissionsUallow).HasColumnName("WorkGroup_Permissions_UAllow");

                entity.Property(e => e.WorkGroupPermissionsUdelete).HasColumnName("WorkGroup_Permissions_UDelete");

                entity.Property(e => e.WorkGroupPermissionsUedit).HasColumnName("WorkGroup_Permissions_UEdit");

                entity.Property(e => e.WorkGroupPermissionsUprint).HasColumnName("WorkGroup_Permissions_UPrint");

                entity.Property(e => e.WorkGroupPermissionsUview).HasColumnName("WorkGroup_Permissions_UView");

                entity.Property(e => e.WorkGroupPermissionsWorkGroupId).HasColumnName("WorkGroup_Permissions_Work_Group_ID");
            });

            modelBuilder.Entity<WorkPeriods>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Work_Periods");

                entity.Property(e => e.WorkPeriodsDelStatus).HasColumnName("Work_periods_DelStatus");

                entity.Property(e => e.WorkPeriodsEndDate)
                    .HasColumnName("Work_Periods_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkPeriodsEndTime).HasColumnName("Work_Periods_End_Time");

                entity.Property(e => e.WorkPeriodsId)
                    .HasColumnName("Work_Periods_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WorkPeriodsStartDate)
                    .HasColumnName("Work_Periods_Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkPeriodsStartTime).HasColumnName("Work_Periods_Start_Time");

                entity.Property(e => e.WorkPeriodsStationId)
                    .HasColumnName("Work_Periods_Station_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPeriodsStationName)
                    .HasColumnName("Work_Periods_Station_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPeriodsStatus)
                    .HasColumnName("Work_Periods_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPeriodsUserEnd).HasColumnName("Work_Periods_User_End");

                entity.Property(e => e.WorkPeriodsUserId).HasColumnName("Work_Periods_User_ID");

                entity.Property(e => e.WorkPeriodsWorkPeriodName)
                    .HasColumnName("Work_Periods_Work_period_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
