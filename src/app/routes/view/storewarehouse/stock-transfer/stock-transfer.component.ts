import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { ConfirmationService, MenuItem, MessageService } from 'primeng';
import { MasterApiService } from 'src/app/routes/service/master.api.services';
import { StockApiService } from 'src/app/routes/service/stock-api/stock-api.service';
import { defaults } from 'src/app/shared/service/settings';
import Handsontable from 'handsontable';

@Component({
  selector: 'app-stock-transfer',
  templateUrl: './stock-transfer.component.html',
  styleUrls: ['./stock-transfer.component.scss']
})
export class StockTransferComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private activatedroute: ActivatedRoute,
    private translate: TranslateService,
    private messageService: MessageService,
    private confirmation: ConfirmationService,
    private masterApi: MasterApiService,
    private stockApi: StockApiService,) {
    this.licensekey = defaults.hotlicensekey;
    this.showCustomerList = false;
    this.btnFlag = { edit: true, cancel: true, save: true, new: false, delete: false, list: false, submit: false };
    this.jobList = [
      { name: 'Job 1' },
      { name: 'Job 2' },
      { name: 'Job 3' },
      { name: 'Job 4' },
      { name: 'Job 5' },
      { name: 'Job 6' }
    ];
  }

  btnFlag: {
    edit: boolean,
    cancel: boolean,
    save: boolean,
    new: boolean,
    delete: boolean,
    list: boolean,
    submit: boolean
  };
  breadcumbmodel: MenuItem[];
  jobList: Array<any>;
  locationList: Array<any>;
  itemList: any;
  departmentList: any;
  customerList: Array<any>;
  dataset: Array<any>;
  selectedJob: string;
  showCustomerList: boolean;
  showItemList: boolean;
  conditionCheck: boolean;
  cols: any;
  itemCols: any;
  licensekey: string;
  response: any;
  subtitle: string;
  StockTransferGroup: FormGroup;
  stockTransfer: Handsontable.GridSettings;
  title: string;
  voucherDate: any;
  selectedCustomer: string;
  customerDesc: boolean;

  ngOnInit(): void {
    this.voucherDate = new Date().toDateString();
    this.getVoucherNumber();
    this.breadcumbmodel = this.router.url.slice(1).split('/').map((k) => ({ label: k }));
    this.activatedroute.data.subscribe(data => {
      this.title = data.title;
      this.subtitle = data.title;
    });
    this.StockTransferGroup = new FormGroup({
      VoucherNo: new FormControl('', Validators.required),
      VoucherDate: new FormControl('', Validators.required),
      VoucherJob: new FormControl('', Validators.required),
      SelectedJob: new FormControl('', Validators.required),
      LocationFrom: new FormControl('', Validators.required),
      LocationTo: new FormControl('', Validators.required),
      CustomerName: new FormControl('', Validators.required),
      Department: new FormControl('', Validators.required),
      Narration: new FormControl('', Validators.required)
    });
    this.selectedCustomer = "";
    this.customerDesc = true;
    this.conditionCheck = false;
    this.cols = [
      { field: "customerTitle", header: "Title" },
      { field: "customerName", header: "Name" },
      { field: "customerEmail", header: "Email Address" },
      { field: "customerContact", header: "Contact No." }
    ];
    this.itemCols = [
      { field: "itemNo", header: "Item No." },
      { field: "itemName", header: "Item Name" },
    ];
    this.initializeControls();
  }
  selectCustomer(customerName) {
    this.selectedCustomer = customerName;
    this.showCustomerList = false;
    this.showItemList = false;
    this.customerDesc = false;
  }
  hotid = 'stockLedgerReport';
  initializeControls() {
    this.stockTransfer = {
      rowHeaders: true,
      viewportColumnRenderingOffset: 27,
      viewportRowRenderingOffset: 'auto',
      colWidths: undefined,
      minRows: 3,
      width: '100%',
      height: 150,
      rowHeights: 23,
      fillHandle: {
        direction: 'vertical',
        autoInsertRow: true
      },
      afterOnCellMouseDown: (event, coords, TD) => {
        if ((TD.innerText === null || isNaN(parseInt(TD.innerText))) && this.conditionCheck)
          return;
        this.getAllItems();
        this.conditionCheck = true;
      },
      afterChange: (changes) => {
        changes?.forEach(([row, prop, oldValue, newValue]) => {
          this.stockQuantity = newValue;
        });
      },
      data: [],
      minSpareRows: 1,
      allowInsertRow: true,
      // allowInsertColumn: false,
      // allowRemoveColumn: false,
      // allowRemoveRow: false,
      // autoWrapRow: false,
      // autoWrapCol: false,
      //  autoWrapRow: true,
      // height: 487,
      // maxRows: 22,
      stretchH: "all",
      manualRowResize: true,
      manualColumnResize: true,
      hiddenColumns: {
        columns: [5],
        indicators: false
      },
      columns: [
        {
          data: 'Item',
          type: 'numeric'
        },
        {
          data: 'itemName',
          type: 'text'
        },
        {
          data: 'itemType',
          type: 'text'
        },
        {
          data: 'quantity',
          type: 'text',
        }
      ],
      colHeaders: [
        this.translate.instant('Item'),
        this.translate.instant('Item Name'),
        this.translate.instant('Item Type'),
        this.translate.instant('Quantity')
      ],
      manualRowMove: true,
      manualColumnMove: true,
      contextMenu: true,
      filters: true,
      dropdownMenu: true,
    };

    // this.stockTransfer.beforeChangeRender = (change, source) => {
    //   this.ColumnSum();

    // };
    // this.stockTransfer.afterRemoveRow = (index: number, amount: number) => {
    //   // console.log('beforeRemove: index: %d, amount: %d', index, amount);
    //   // console.log(this.hotRegisterer.getInstance(this.hotid).getDataAtRow(index));
    //   this.ColumnSum();

    // };


    this.stockTransfer.afterValidate = (isValid, value, row, prop) => {
      if (!isValid) {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Invalid entry' });
      }

    };
  }
  createNew() {
    this.getAllJobs();
    this.getAllLocations();
    this.getAllDepartments();
    this.btnFlag.cancel = false;
    this.btnFlag.edit = false;
    this.btnFlag.save = false;
  }
  VoucherNumber: any;
  getVoucherNumber() {
    this.stockApi.getVoucherNumber().subscribe(response => {
      this.VoucherNumber = response;
      this.VoucherNumber = this.VoucherNumber.Stock_Register[0].Vouchers_Numbers_V_NO;
    });
  }
  GetItemDetails(id) {
    this.showItemList = false;
    this.stockApi.getItemDetailsById({ ItemMasterItemId: id }).subscribe(respose => {
      this.itemList = respose;
      this.dataset = this.itemList.ItemDetails;
      console.log(this.dataset);
    },
      error => {
        console.error("Data Not found...!");
      });
  }
  getAllJobs() {
    this.masterApi.GetAllJob().subscribe(
      data => {
        this.jobList = data;
      }
    )
  }
  getAllLocations() {
    this.masterApi.GetAllLocation().subscribe(
      data => {
        this.locationList = data;
      }
    );
  }
  getAllDepartments() {
    this.stockApi.getAllDepartments().subscribe(
      data => {
        this.response = data;
        this.departmentList = this.response.Department_Master;
      }
    );
  }
  showAllCustomers() {
    this.masterApi.GetAllCustomer().subscribe(
      data => {
        this.customerList = data;
      }
    );
    this.showCustomerList = true;
  }
  tmp: any;
  getAllItems() {
    this.stockApi.getAllItemsList().subscribe(
      data => {
        this.tmp = data;
        this.showItemList = true;
        this.itemList = this.tmp.Item_Master;
      }
    );
  }
  date: any;
  stockObj:any;
  stockQuantity:any;
  submitTransferReport() {
    this.date = new Date();
    this.date = this.date.getUTCFullYear() + '-' +
      ('00' + (this.date.getUTCMonth() + 1)).slice(-2) + '-' +
      ('00' + this.date.getUTCDate()).slice(-2) + ' ' +
      ('00' + this.date.getUTCHours()).slice(-2) + ':' +
      ('00' + this.date.getUTCMinutes()).slice(-2) + ':' +
      ('00' + this.date.getUTCSeconds()).slice(-2);
    var payload = {
      voucherNo: String(this.StockTransferGroup.value.VoucherNo),
      voucherDate: String(this.date),
      selectedJob: String(this.StockTransferGroup.value.SelectedJob.jobMasterJobId),
      locationFrom: String(this.StockTransferGroup.value.LocationFrom.locationMasterLocationId),
      locationTo: String(this.StockTransferGroup.value.LocationTo.locationMasterLocationId),
      narration: String(this.StockTransferGroup.value.Narration),
      department: String(this.StockTransferGroup.value.Department.Department_Master_Department_ID),
      stockQuantity:String(this.stockQuantity),
      unitId: String(this.dataset[0].Item_Master_Unit_Id),
      unitPrice: String(this.dataset[0].Item_Master_Unit_Price),
      stockItemId:String(this.dataset[0].Item_Master_Item_ID),
      stockItemName:String(this.dataset[0].Item_Master_Item_Name),
      stockItemType:String(this.dataset[0].Item_Master_Item_Type),
      stockRate:String(this.dataset[0].Item_Master_Unit_Price)
    }
    console.log(payload);
    this.stockApi.submitTransferReport(payload).subscribe(
      data => {
        console.log(data);
      }
    );
  }
  get f() {
    return this.StockTransferGroup.controls;
  }
}
