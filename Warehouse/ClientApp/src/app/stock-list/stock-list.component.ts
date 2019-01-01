import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { SimpleModalService } from "ngx-simple-modal";
import { StockService } from '../services/stock.service';
import { ToastrService } from '../services/toastr.service';
import { IStockListResult } from '../models/stock-list-result.model';
import { IStockItemView } from '../models/stock-item-view.model';
import { IStockTableRowButtonEventArgs } from '../models/stock-table-row-button-eventargs';
import { StockItemEditModalComponent } from '../modals/stock-item-edit-modal/stock-item-edit-modal.component';
import { StockItemMoveModalComponent } from '../modals/stock-item-move-modal/stock-item-move-modal.component';
import { StockItemDeleteModalComponent } from '../modals/stock-item-delete-modal/stock-item-delete-modal.component';
import { StockListActions } from '../constants/app.constants';

@Component({
  selector: 'app-stock-list',
  templateUrl: './stock-list.component.html',
  styleUrls: ['./stock-list.component.css']
})
export class StockListComponent implements OnInit {
  readonly foreignCurrency: string = 'eur';
  stockListResult$: Observable<IStockListResult>;

  constructor(
    private stockService: StockService,
    private simpleModalService: SimpleModalService,
    private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.refresh();
  }

  handleClick(eventArgs: IStockTableRowButtonEventArgs) {
    switch (eventArgs.action) {
      case StockListActions.NEW:
        this.onEdit(eventArgs.stockItem, true);
        break;
      case StockListActions.EDIT:
        this.onEdit(eventArgs.stockItem, false);
        break;
      case StockListActions.DELETE:
        this.onDelete(eventArgs.stockItem);
        break;
      case StockListActions.ADD:
        this.onMove(eventArgs.stockItem, true);
        break;
      case StockListActions.REMOVE:
        this.onMove(eventArgs.stockItem, false);
        break;
      default:
        break;
    }
  }

  onEdit(stockItem: IStockItemView, isCreate: boolean): void {
    this.simpleModalService.addModal(StockItemEditModalComponent, {
      stockItem,
      isCreate
    }).subscribe(newStockItem => {
      if (newStockItem) {
        const message = isCreate ? `${newStockItem.name} has been created successfully.` : `${newStockItem.name} has been updated successfully.`;
        this.success(message);
      }
    });
  }

  onDelete(stockItem: IStockItemView): void {
    this.simpleModalService.addModal(StockItemDeleteModalComponent, {
      stockItem
    }).subscribe(isConfirmed => {
      if (isConfirmed) {
        const message = `${stockItem.name} has been removed successfully.`;
        this.success(message);
      }
    });
  }

  onMove(stockItem: IStockItemView, isAdd: boolean): void {
    this.simpleModalService.addModal(StockItemMoveModalComponent, {
      stockItem,
      isAdd
    }).subscribe(isConfirmed => {
      if (isConfirmed) {
        const message = `${stockItem.name} quantity has been modified successfully.`;
        this.success(message);
      }
    });
  }

  private refresh(): void {
    this.stockListResult$ = this.stockService.getList(this.foreignCurrency);
  }

  private success(message: string): void {
    this.toastrService.showSuccess(message, 'Success');
    this.stockListResult$ = null;
    this.refresh();
  }
}
