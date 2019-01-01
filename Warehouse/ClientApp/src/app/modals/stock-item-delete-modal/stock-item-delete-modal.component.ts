import { Component } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { SimpleModalComponent } from 'ngx-simple-modal';
import { StockService } from 'src/app/services/stock.service';
import { IStockItemDeleteModal } from 'src/app/models/stock-item-delete-modal.model';
import { IStockItemView } from 'src/app/models/stock-item-view.model';

@Component({
  selector: 'app-stock-item-delete-modal',
  templateUrl: './stock-item-delete-modal.component.html',
  styleUrls: ['./stock-item-delete-modal.component.css']
})
export class StockItemDeleteModalComponent extends SimpleModalComponent<IStockItemDeleteModal, boolean> implements IStockItemDeleteModal {
  stockItem: IStockItemView;
  loading: boolean;

  constructor(private stockService: StockService) {
    super();
  }

  confirm() {
    this.loading = true;
    this.stockService.deleteItem(this.stockItem).pipe(finalize(() => this.loading = false)).subscribe(() => {
      this.result = true;
      this.close();
    });
  }
}
