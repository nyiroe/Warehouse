import { Injectable, isDevMode } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ErrorHandlerService } from './error-handler.service';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AppConstants } from '../constants/app.constants';
import { IStockListResult } from '../models/stock-list-result.model';
import { IStockItemView } from '../models/stock-item-view.model';
import { IStockMovementView } from '../models/stock-movement-view.model';
import { IStatisticsResult } from '../models/statistics-result.model';

@Injectable()
export class StockService {
  readonly stockApiUrl: string;
  readonly statisticsApiUrl: string;

  constructor(private http: HttpClient, private errorHandler: ErrorHandlerService) {
    const apiBaseHost = isDevMode() ? AppConstants.API_BASE_HOST : '';
    this.stockApiUrl = apiBaseHost + AppConstants.API_BASE_URI + 'Stock';
    this.statisticsApiUrl = apiBaseHost + AppConstants.API_BASE_URI + 'Statistics';
  }

  getList(foreignCurrency?: string): Observable<IStockListResult> {
    let url = `${this.stockApiUrl}/List`;

    if (foreignCurrency) {
      url += '/' + foreignCurrency;
    }

    return <Observable<IStockListResult>>this.http.get<IStockListResult>(url).pipe(catchError(error => this.errorHandler.handleError(error)));
  }

  createItem(stockItem: IStockItemView): Observable<IStockItemView> {
    const url = `${this.stockApiUrl}/Item`;

    return this.http.post<IStockMovementView>(url, stockItem).pipe(catchError(error => this.errorHandler.handleError(error)));
  }

  updateItem(stockItem: IStockItemView): Observable<IStockItemView> {
    const url = `${this.stockApiUrl}/Item`;

    return this.http.put<IStockMovementView>(url, stockItem).pipe(catchError(error => this.errorHandler.handleError(error)));
  }

  deleteItem(stockItem: IStockItemView): Observable<{}> {
    const url = `${this.stockApiUrl}/Item/${stockItem.stockItemId}`;

    return this.http.delete(url).pipe(catchError(error => this.errorHandler.handleError(error)));
  }

  moveItem(stockItem: IStockItemView, quantity: number): Observable<{}> {
    const url = `${this.stockApiUrl}/MoveItem`;
    const stockMovementView: IStockMovementView = {
      stockItemId: stockItem.stockItemId,
      quantity
    };

    return this.http.post<IStockMovementView>(url, stockMovementView).pipe(catchError(error => this.errorHandler.handleError(error)));
  }

  getStatistics(): Observable<IStatisticsResult> {
    const url = `${this.statisticsApiUrl}/List`;

    return <Observable<IStatisticsResult>>this.http.get<IStatisticsResult>(url).pipe(catchError(error => this.errorHandler.handleError(error)));
  }
}
