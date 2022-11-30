import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MasterApiService } from 'src/app/routes/service/master.api.services';
import { MenuItem } from 'primeng/api/menuitem';
import Handsontable from 'handsontable';
import { defaults } from 'src/app/shared/service/settings';
import { TranslateService } from '@ngx-translate/core';
import { AccountApiService } from 'src/app/routes/service/account.api.service';
import { SelectItem, MessageService, ConfirmationService } from 'primeng/api';
import { ChartofAccounts, ReceiptVoucher, ReceiptVoucherDetails } from 'src/app/routes/domain';
import { JobMaster } from 'src/app/routes/domain/JobMaster';
import { CostCenterMaster } from 'src/app/routes/domain/CostCenterMaster';
import { AccountsTransactions } from 'src/app/routes/domain/AccountsTransactions';
import { HotTableRegisterer } from '@handsontable/angular';
import { summaryFileName } from '@angular/compiler/src/aot/util';
import { DropDownValidator } from 'src/app/shared/validator/customvalidtor';
import { StockApiService } from 'src/app/routes/service/stock-api/stock-api.service';

@Component({
  selector: 'app-damage-entry',
  templateUrl: './damage-entry.component.html',
  styleUrls: ['./damage-entry.component.scss']
})
export class DamageEntryComponent implements OnInit {

  dataset: any;
  list: any;
  confirmDropDatabaseDialogVisible = false;
  title: string;
  search: string;
  index: number = 0;
  displayMaximizable: boolean;
  breadcumbmodel: MenuItem[];
  licensekey: string;
  locationList: Array<any>;
  btnFlag: ButtonFlag;
  currencyList: SelectItem[];
  currArry: string[] = [];
  voucherDate: any;
  checkNull: boolean = true;

  accountArray: ChartofAccounts[] = [];
  acctArry: string[] = [];
  accountList: SelectItem[];

  jobArray: JobMaster[] = [];
  jobList: SelectItem[] = [];
  jobArry: string[] = [];

  costcenterArray: CostCenterMaster[] = [];
  costcenterList: SelectItem[] = [];
  costcenterArry: string[] = [];

  accountTransactionList: AccountsTransactions[] = [];
  receiptVoucherarry: ReceiptVoucher[] = [];
  savedReceiptVoucher: ReceiptVoucher;
  private hotRegisterer = new HotTableRegisterer();
  hotid = 'receiptVouchrEntry';
  constructor(private activatedroute: ActivatedRoute,
    private service: StockApiService,
    private messageService: MessageService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService,
    private translate: TranslateService,
    private router: Router,
    private masterapi: MasterApiService,
    private accountapi: AccountApiService) {
    this.licensekey = defaults.hotlicensekey;
  }

  stockmovementrpt: Handsontable.GridSettings;
  stockMovementRptFormGroup: FormGroup;

  cols: any;
  ngOnInit(): void {
    this.voucherDate = new Date();
    this.voucherDate = this.voucherDate.getUTCFullYear() + '-' +
      ('00' + (this.voucherDate.getUTCMonth() + 1)).slice(-2) + '-' +
      ('00' + this.voucherDate.getUTCDate()).slice(-2) + ' ' +
      ('00' + this.voucherDate.getUTCHours()).slice(-2) + ':' +
      ('00' + this.voucherDate.getUTCMinutes()).slice(-2) + ':' +
      ('00' + this.voucherDate.getUTCSeconds()).slice(-2);
    this.cols = [
      { field: 'Item_Master_Item_ID', header: 'Item Id' },
      { field: 'Item_Master_Item_Name', header: 'Item Name' },
      { field: 'Item_Master_Part_No', header: 'Item Part No' },
      { field: 'Item_Master_Barcode', header: 'Item Barcode' }
    ];
    this.btnFlag = { edit: false, cancel: false, save: true, update: false, delete: false };
    this.initializeControls();
    this.getAllLocations();
    this.getVoucherNumber();
    this.stockMovementRptFormGroup = this.fb.group({
      DamageEntryVoucherNo: [{ value: null, disabled: true }],
      DamageEntryVoucherDate: [null, [Validators.required]],
      DamageEntryLocation: ['', [Validators.required]],
      DamageEntryDesc: [0, [Validators.required]]
    });
    this.breadcumbmodel = this.router.url.slice(1).split('/').map((k) => ({ label: k }));
    this.activatedroute.data.subscribe(data => {
      this.title = data.title;
    });
  }
  VoucherNumber: any;
  getVoucherNumber() {
    this.service.getVoucherNumber().subscribe(response => {
      this.VoucherNumber = response;
      this.VoucherNumber = parseInt(this.VoucherNumber.Stock_Register[0].Vouchers_Numbers_V_NO_NU) + 1;
    });
  }
  GetItemList() {
    this.service.getAllItemsList().subscribe(respose => {
      this.list = respose;
      console.log(this.list);
      this.dataset = this.list.Item_Master;
      this.displayMaximizable = true;
    },
      error => {
        console.error("Data Not found...!");
      });
  }
  GetItemDetails(id) {
    this.displayMaximizable = false;
    this.service.getItemDetailsById({ ItemMasterItemId: id }).subscribe(respose => {
      this.list = respose;
      this.dataset = this.list.ItemDetails;
      this.checkNull = false;
    },
      error => {
        console.error("Data Not found...!");
      });
  }
  handleChange(e) {
    this.index = e.index;
  }
  get f() {
    return this.stockMovementRptFormGroup.controls;
  }
  getAllLocations() {
    this.masterapi.GetAllLocation().subscribe(
      data => {
        this.locationList = data;
        console.log(this.locationList);
      }
    );
  }
  initializeControls() {
    this.stockmovementrpt = {
      rowHeaders: true,
      viewportColumnRenderingOffset: 27,
      viewportRowRenderingOffset: 'auto',
      colWidths: 150,
      minRows: 3,
      width: '100%',
      height: 300,
      rowHeights: 23,
      fillHandle: {
        direction: 'vertical',
        autoInsertRow: true
      },
      afterOnCellMouseDown: (event, coords, TD) => {
        if (coords.col === 0)
          this.GetItemList();
      },
      data: [],
      minSpareRows: 1,
      // allowInsertColumn: false,
      allowInsertRow: true,
      // allowRemoveColumn: false,
      // allowRemoveRow: false,
      // autoWrapRow: false,
      // autoWrapCol: false,
      stretchH: "all",
      //  autoWrapRow: true,
      // height: 487,
      // maxRows: 22,
      manualRowResize: true,
      manualColumnResize: true,
      hiddenColumns: {
        columns: [8],
        indicators: false
      },
      // rowHeaders: true,
      columns: [
        {
          data: 'account',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.acctArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'credit',
          type: 'numeric'
        },
        {
          data: 'jobname',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.jobArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'costcenter',
          type: 'dropdown',
          source: (query, callback) => {
            callback(this.costcenterArry);
          },
        },
        {
          data: 'narration',
          type: 'text',
        },
        {
          data: 'id',
          type: 'numeric'
        },
        {
          data: 'Temp',
          type: 'numeric'
        },
        {
          data: 'Temp',
          type: 'numeric'
        }
      ],
      colHeaders: [
        this.translate.instant('A'),
        this.translate.instant('B'),
        this.translate.instant('C'),
        this.translate.instant('D'),
        this.translate.instant('E'),
        this.translate.instant('F'),
        this.translate.instant('G'),
        this.translate.instant('H')
      ],
      manualRowMove: true,
      manualColumnMove: true,
      contextMenu: true,
      filters: true,
      dropdownMenu: true,
    };

    this.stockmovementrpt.beforeChangeRender = (change, source) => {
      this.ColumnSum();

    };
    this.stockmovementrpt.afterRemoveRow = (index: number, amount: number) => {
      // console.log('beforeRemove: index: %d, amount: %d', index, amount);
      // console.log(this.hotRegisterer.getInstance(this.hotid).getDataAtRow(index));
      this.ColumnSum();

    };


    this.stockmovementrpt.afterValidate = (isValid, value, row, prop) => {
      if (!isValid) {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Invalid entry' });
      }

    };



  }
  ColumnSum() {
    if (this.stockmovementrpt.data.length > 0) {
      const sum1 = this.stockmovementrpt.data.filter(item => item.hasOwnProperty('credit'))
        .reduce((sum, current) => sum + current.credit, 0);
    }
  }
  submitDamageEntry() {
    if (this.checkNull) {
      this.messageService.add({
        severity: 'error',
        detail: 'Please enter all required details',
        closable: true
      });
    }
    else {
      this.voucherDate = new Date();
      this.voucherDate = this.voucherDate.getUTCFullYear() + '-' +
        ('00' + (this.voucherDate.getUTCMonth() + 1)).slice(-2) + '-' +
        ('00' + this.voucherDate.getUTCDate()).slice(-2) + ' ' +
        ('00' + this.voucherDate.getUTCHours()).slice(-2) + ':' +
        ('00' + this.voucherDate.getUTCMinutes()).slice(-2) + ':' +
        ('00' + this.voucherDate.getUTCSeconds()).slice(-2);
      let payload = {
        materialId: String(this.dataset[0].Item_Master_Item_ID),
        stockItemName: String(this.dataset[0].Item_Master_Item_Name),
        stockItemType: String(this.dataset[0].Item_Master_Item_Type),
        locationFrom: String(this.dataset[0].Item_Master_Location_ID),
        partNo: String(this.dataset[0].Item_Master_Part_No),
        unitId: String(this.dataset[0].Item_Master_Unit_ID),
        stockRate: String(this.dataset[0].Item_Master_Unit_Price),
        stockQuantity: String(this.dataset[0].Quantity),
        voucherDate: String(this.voucherDate),
        voucherNo: String(this.VoucherNumber),
        narration: String(this.stockMovementRptFormGroup.value.DamageEntryDesc)
      }
      this.service.submitDamageEntry(payload).subscribe((data) => {
        console.log(data);
      });
      this.messageService.add({
        severity: 'success',
        detail: 'Data saved successfully !',
        closable: true
      });
    }
  }
}
interface ButtonFlag {
  edit?: boolean; cancel?: boolean; update?: boolean;
  save?: boolean; delete?: boolean;
}
