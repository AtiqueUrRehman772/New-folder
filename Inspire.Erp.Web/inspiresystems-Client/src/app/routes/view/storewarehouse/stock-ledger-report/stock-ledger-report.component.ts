import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MenuItem } from 'primeng/api/menuitem';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { HotTableRegisterer } from '@handsontable/angular';
import { defaults } from 'src/app/shared/service/settings';
import Handsontable from 'handsontable';
import * as XLSX from 'xlsx';
import { TranslateService } from '@ngx-translate/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { AccountApiService } from 'src/app/routes/service/account.api.service';
import { StockApiService } from 'src/app/routes/service/stock-api/stock-api.service';
import { interval } from 'rxjs';
import * as $ from 'jquery';
type SheetData = any[][];

@Component({
  selector: 'app-stock-ledger-report',
  templateUrl: './stock-ledger-report.component.html',
  styleUrls: ['./stock-ledger-report.component.scss']
})
export class StockLedgerReportComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private activatedroute: ActivatedRoute,
    private translate: TranslateService,
    private messageService: MessageService,
    private confirmation: ConfirmationService,
    private stockApi: StockApiService,
    private accountapi: AccountApiService) {
    this.licensekey = defaults.hotlicensekey;
    this.gridHeader = "No Data";
    this.btnFlag = { edit: true, cancel: true, save: true, new: true, delete: true, list: false };
  }
  response: any;
  btnFlag: {
    edit: boolean,
    cancel: boolean,
    save: boolean,
    new: boolean,
    delete: boolean,
    list: boolean
  };
  itemIds = [];
  itemNames = [];
  units = [];
  openQty = [];
  openAmount = [];
  SinQty = [];
  SinAmount = [];
  SoutQty = [];
  SoutAmount = [];
  BalQty = [];
  BalAmount = [];
  title: string;
  dataset: any;
  payload: any;
  subtitle: string;
  gridHeader:string;
  displayMaximizable: boolean;
  showItempGroupList:boolean;
  itemGroupList:Array<item>;
  selectedItem:item;
  breadcumbmodel: MenuItem[];
  btnlabel: string = 'Submit';
  cols: any;
  dataJson: string;
  data: SheetData;
  wopts: XLSX.WritingOptions = { bookType: 'xlsx', type: 'array' };
  fileName: string = '';
  ItemFormGroup: FormGroup;
  licensekey: string;


  ngOnInit(): void {
    this.breadcumbmodel = this.router.url.slice(1).split('/').map((k) => ({ label: k }));
    this.activatedroute.data.subscribe(data => {
      this.title = data.title;
      this.subtitle = data.title;
    });
    this.cols = [];
    this.initializeControls();
    this.ItemFormGroup = new FormGroup({
      ItemGroup: new FormControl('', Validators.required),
      ItemName: new FormControl('', Validators.required),
      DateFrom: new FormControl('', Validators.required),
      DateTo: new FormControl('', Validators.required),
      DateFormat: new FormControl('', Validators.required),
      Brand: new FormControl('', Validators.required),
      Location: new FormControl('', Validators.required),
      Job: new FormControl('', Validators.required),
      DetailsType: new FormControl('Details', Validators.required),
      DateType: new FormControl('Monthly', Validators.required)
    })
  }
  showItemGroups(){
    this.showItempGroupList = true;
    this.itemGroupList = [
      {itemId:'851',itemName:'Diesel'},
      {itemId:'311',itemName:'Garnet'},
      {itemId:'127',itemName:'General'},
      {itemId:'472',itemName:'Paints'}
    ];
  }
  toggleActive(itemId){
    console.log('Item Id is : ');
    console.log(itemId);
    this.itemGroupList.forEach(element => {
      $("#"+element.itemId).removeClass('selected');
    });
    $("#"+itemId).addClass('selected');
  }
  clearForm() {
    this.ItemFormGroup.controls['ItemGroup'].setValue('');
    this.ItemFormGroup.controls['ItemName'].setValue('');
    this.ItemFormGroup.controls['DateFrom'].setValue('');
    this.ItemFormGroup.controls['DateTo'].setValue('');
    this.ItemFormGroup.controls['DateFormat'].setValue('');
    this.ItemFormGroup.controls['Brand'].setValue('');
    this.ItemFormGroup.controls['Location'].setValue('');
    this.ItemFormGroup.controls['Job'].setValue('');
    this.ItemFormGroup.controls['DetailsType'].setValue('');
    this.ItemFormGroup.controls['DateType'].setValue('');
  }
  getStockLedgerRpt() {
    this.btnFlag = { edit: false, cancel: false, save: false, new: false, delete: false, list: false };
    this.stockApi.getStockLedgerReport().subscribe(
      data => {
        this.response = data;
        this.dataset = this.response.Stock_Register;
        this.getAllItemId(this.response.Stock_Register);
        this.gridHeader = "Showing All Data";
      }, (error) => {
        console.log(error);
      });
  }
  getFilteredStockLedgerRpt() {
    this.btnFlag = { edit: false, cancel: false, save: false, new: false, delete: false, list: false };
    this.payload = {
      itemGroup: this.ItemFormGroup.value.ItemGroup,
      itemName: this.ItemFormGroup.value.ItemName,
      dateFrom: this.ItemFormGroup.value.DateFrom,
      dateTo: this.ItemFormGroup.value.DateTo,
      brand: this.ItemFormGroup.value.Brand,
      location: this.ItemFormGroup.value.Location,
      job: this.ItemFormGroup.value.Job,
      detailsType: this.ItemFormGroup.value.DetailsType,
      dateType: this.ItemFormGroup.value.DateType,
    };
    console.log('Payload : ');
    console.log(this.payload);
    this.stockApi.getFilteredStockLedgerRpt(this.payload).subscribe(
      data => {
        this.response = data;
        this.dataset = this.response.Stock_Register;
        console.log(this.response);
        this.getAllItemId(this.response.Stock_Register);
        this.gridHeader = "Showing Filtered Data";
      }, (error) => {
        console.log(error);
      });
  }
  onCancel() {
    this.dataset = [];
    this.btnFlag = { edit: true, cancel: true, save: true, new: true, delete: true, list: false };
  }
  saveStockLedgerReport() {
    this.displayMaximizable = true;
    this.confirmation.confirm({
      key: 'confirm-key',
      message: 'Do you want to save Receipt?',
      accept: () => {
        this.messageService.add({ severity: 'success', summary: 'Alert', detail: 'Stock Ledger Report Saved Succesfully' });
      },
      reject: () => {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Stock Ledger Report Save Cancelled' });
      }
    });
  }
  getAllItemId(data: any) {
    this.itemIds = [];
    for (let i = 0; i < data.length; i++) {
      this.itemIds.push(data[i].Item_Id);
    }
  }
  getAllItemNames(data: any) {
    this.itemNames = [];
    for (let i = 0; i < data.length; i++) {
      this.itemNames.push(data[i].Item_Id);
    }
  }
  getAllUnits(data: any) {
    this.units = [];
    for (let i = 0; i < data.length; i++) {
      this.units.push(data[i].Item_Id);
    }
  }
  getOpenQty(data: any) {
    this.openQty = [];
    for (let i = 0; i < data.length; i++) {
      this.openQty.push(data[i].Item_Id);
    }
  }

  onFileChange(evt: any) {
    this.exceltoJsonConverter(evt);
    // /* wire up file reader */
    // const target: DataTransfer = <DataTransfer>(evt.target);
    // if (target.files.length !== 1) throw new Error('Cannot use multiple files');
    // const reader: FileReader = new FileReader();
    // reader.onload = (e: any) => {
    //   /* read workbook */
    //   const bstr: string = e.target.result;
    //   const wb: XLSX.WorkBook = XLSX.read(bstr, { type: 'binary' });

    //   /* grab first sheet */
    //   const wsname: string = wb.SheetNames[0];
    //   const ws: XLSX.WorkSheet = wb.Sheets[wsname];

    //   /* save data */
    //   this.data = <SheetData>(XLSX.utils.sheet_to_json(ws, { header: 1 }));
    //   console.log(this.data);
    //   //this.dataJson = JSON.stringify(this.data);
    //   //console.log(this.dataJson);
    // };
    // reader.readAsBinaryString(target.files[0]);
  }


  hotid = 'stockLedgerReport';
  private hotRegisterer = new HotTableRegisterer();
  stockLedgerReport: Handsontable.GridSettings;
  stockLedgerFormGroup: FormGroup;

  initializeControls() {
    this.stockLedgerReport = {
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
          data: 'itemId',
          type: 'numeric'
        },
        {
          data: 'itemName',
          type: 'text'
        },
        {
          data: 'unit',
          type: 'text'
        },
        {
          data: 'SinOpenQty',
          type: 'numeric'
        },
        {
          data: 'SinOpenAmount',
          type: 'text',
        },
        {
          data: 'SoutOpenQty',
          type: 'numeric'
        },
        {
          data: 'SoutOpenAmount',
          type: 'numeric'
        },
        {
          data: 'BalQty',
          type: 'numeric'
        },
        {
          data: 'BalAmount',
          type: 'numeric'
        }
      ],
      colHeaders: [
        this.translate.instant('Item Id'),
        this.translate.instant('Item Name'),
        this.translate.instant('Unit'),
        this.translate.instant('Open Qty'),
        this.translate.instant('Open Amount'),
        this.translate.instant('Stock In Qty'),
        this.translate.instant('Stock In Amount'),
        this.translate.instant('Stock Out Qty'),
        this.translate.instant('Stock Out Amount'),
        this.translate.instant('Balance Qty'),
        this.translate.instant('Balance Amount'),
      ],
      manualRowMove: true,
      manualColumnMove: true,
      contextMenu: true,
      filters: true,
      dropdownMenu: true,
    };

    this.stockLedgerReport.beforeChangeRender = (change, source) => {
      this.ColumnSum();

    };
    this.stockLedgerReport.afterRemoveRow = (index: number, amount: number) => {
      // console.log('beforeRemove: index: %d, amount: %d', index, amount);
      // console.log(this.hotRegisterer.getInstance(this.hotid).getDataAtRow(index));
      this.ColumnSum();

    };


    this.stockLedgerReport.afterValidate = (isValid, value, row, prop) => {
      if (!isValid) {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Invalid entry' });
      }

    };



  }
  ColumnSum() {
    if (this.stockLedgerReport.data.length > 0) {
      const sum1 = this.stockLedgerReport.data.filter(item => item.hasOwnProperty('credit'))
        .reduce((sum, current) => sum + current.credit, 0);
      this.stockLedgerFormGroup.controls.ReceiptVoucherMasterDrAmount.setValue(sum1);
    }
  }

  export(): void {
    var i = 0, result = [];

    while (i < Object.keys(this.exceltoJson.sheet1).length) {
      result.push([])
      for (var key in this.exceltoJson.sheet1[i].fields) {
        result[result.length - 1].push(this.exceltoJson.sheet1[i].fields[key])
      }
      i++
    }
    this.data = result;
    /* generate worksheet */
    const ws: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(this.data);

    /* generate workbook and add the worksheet */
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

    /* save to file */
    XLSX.writeFile(wb, this.fileName);
  }

  exceltoJson = { sheet1: {} };
  exceltoarray: Array<string> = [];

  exceltoJsonConverter(event: any) {
    this.exceltoJson = { sheet1: {} };
    let headerJson = {};
    /* wire up file reader */
    const target: DataTransfer = <DataTransfer>(event.target);
    // if (target.files.length !== 1) {
    //   throw new Error('Cannot use multiple files');
    // }
    const reader: FileReader = new FileReader();
    reader.readAsBinaryString(target.files[0]);
    console.log("filename", target.files[0].name);
    this.exceltoJson['filename'] = target.files[0].name;
    reader.onload = (e: any) => {
      /* create workbook */
      const binarystr: string = e.target.result;
      const wb: XLSX.WorkBook = XLSX.read(binarystr, { type: 'binary' });
      for (var i = 0; i < wb.SheetNames.length; ++i) {
        const wsname: string = wb.SheetNames[i];
        const ws: XLSX.WorkSheet = wb.Sheets[wsname];
        const data = XLSX.utils.sheet_to_json(ws); // to get 2d array pass 2nd parameter as object {header: 1}
        this.exceltoJson[`sheet${i + 1}`] = data;
        this.exceltoarray.push[`sheet${i + 1}`] = data.toString();
        const headers = this.get_header_row(ws);
        headerJson[`header${i + 1}`] = headers;
        this.cols.push(headers);
        //  console.log("json",headers);
      }
      this.exceltoJson['headers'] = headerJson;
      console.log(this.cols);
    };
  }

  get_header_row(sheet) {
    var headers = [];
    var range = XLSX.utils.decode_range(sheet['!ref']);
    var C, R = range.s.r; /* start in the first row */
    /* walk every column in the range */
    for (C = range.s.c; C <= range.e.c; ++C) {
      var cell = sheet[XLSX.utils.encode_cell({ c: C, r: R })] /* find the cell in the first row */
      // console.log("cell",cell)
      var hdr = "UNKNOWN " + C; // <-- replace with your desired default 
      if (cell && cell.t) {
        hdr = XLSX.utils.format_cell(cell);
        headers.push(hdr);
      }
    }
    return headers;
  }
  // new() {
  //   this.stockLedgerFormGroup.reset();
  //   this.stockLedgerReport.data = [];
  //   this.stockLedgerReport.readOnly = false;
  //   this.hotRegisterer.getInstance(this.hotid).updateSettings(this.stockLedgerReport);
  // }
  get f() {
    return this.ItemFormGroup.controls;
  }
}
interface item {
  itemId: string,
  itemName: string
}