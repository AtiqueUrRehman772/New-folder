import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StockApiService {

  constructor(private http:HttpClient) { }

  getStockLedgerReport(){
    return this.http.post('http://localhost:53447/api/Stock/getStockLedgerReport','');
  }
  getFilteredStockLedgerRpt(payload:any){
    return this.http.post('http://localhost:53447/api/Stock/getFilteredStockLedgerRpt',payload);
  }
  getStockMovementRpt(){
    return this.http.get('http://localhost:53447/api/Stock/getStockMovementRpt');
  }
}
