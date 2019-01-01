import { Component, Input, Output, EventEmitter } from '@angular/core';
import { IExchangeRate } from 'src/app/models/exchange-rate.model';
import { IStockItemView } from 'src/app/models/stock-item-view.model';
import { IStockTableRowButtonEventArgs } from 'src/app/models/stock-table-row-button-eventargs';

import { faFileAlt } from '@fortawesome/free-solid-svg-icons';
import { StockListActions } from 'src/app/constants/app.constants';

@Component({
  selector: 'app-stock-table',
  templateUrl: './stock-table.component.html',
  styleUrls: ['./stock-table.component.css']
})
export class StockTableComponent {
  @Input() exchangeRate: IExchangeRate;
  @Input() stockList: IStockItemView[];
  @Output() eventClick = new EventEmitter();

  faFileAlt = faFileAlt;

  newAction = StockListActions.NEW;

  handleCreateClick() {
    const eventArgs: IStockTableRowButtonEventArgs = {
      action: this.newAction,
      stockItem: {
        id: null,
        name: null,
        description: null,
        price: null,
        mass: null
      }
    };

    this.eventClick.emit(eventArgs);
  }

  handleClick(eventArgs: IStockTableRowButtonEventArgs) {
    this.eventClick.emit(eventArgs);
  }
}
