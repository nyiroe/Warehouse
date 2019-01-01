import { Component, Input, Output, EventEmitter } from '@angular/core';
import { IStockItemView } from 'src/app/models/stock-item-view.model';
import { IExchangeRate } from 'src/app/models/exchange-rate.model';
import { IStockTableRowButtonEventArgs } from 'src/app/models/stock-table-row-button-eventargs';

import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { faPlusCircle } from '@fortawesome/free-solid-svg-icons';
import { faMinusCircle } from '@fortawesome/free-solid-svg-icons';
import { StockListActions } from 'src/app/constants/app.constants';

@Component({
  selector: '[app-stock-table-row]',
  templateUrl: './stock-table-row.component.html',
  styleUrls: ['./stock-table-row.component.css']
})
export class StockTableRowComponent {
  @Input() stockItem: IStockItemView;
  @Input() exchangeRate: IExchangeRate;
  @Output() eventClick = new EventEmitter();

  faEdit = faEdit;
  faTrashAlt = faTrashAlt;
  faPlusCircle = faPlusCircle;
  faMinusCircle = faMinusCircle;

  editAction = StockListActions.EDIT;
  deleteAction = StockListActions.DELETE;
  addAction = StockListActions.ADD;
  removeAction = StockListActions.REMOVE;

  handleClick(eventArgs: IStockTableRowButtonEventArgs) {
    this.eventClick.emit(eventArgs);
  }
}
