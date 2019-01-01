import { Component, Input, Output, EventEmitter } from '@angular/core';
import { IStockItemView } from 'src/app/models/stock-item-view.model';
import { IStockTableRowButtonEventArgs } from 'src/app/models/stock-table-row-button-eventargs';

@Component({
  selector: 'app-stock-table-row-button',
  templateUrl: './stock-table-row-button.component.html',
  styleUrls: ['./stock-table-row-button.component.css']
})
export class StockTableRowButtonComponent {
  @Input() action: string;
  @Input() stockItem: IStockItemView;
  @Input() icon: object;
  @Input() buttonClass: string;
  @Input() isDisabled: boolean;
  @Input() title: string;
  @Input() buttonText: string;
  @Output() eventClick = new EventEmitter();

  handleClick() {
    const eventArgs: IStockTableRowButtonEventArgs = {
      action: this.action,
      stockItem: this.stockItem
    };

    this.eventClick.emit(eventArgs);
  }
}
