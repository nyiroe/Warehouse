import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { finalize } from 'rxjs/operators';
import { SimpleModalComponent } from 'ngx-simple-modal';
import { CommonService } from 'src/app/services/common.service';
import { StockService } from 'src/app/services/stock.service';
import { IStockItemMoveModal } from 'src/app/models/stock-item-move-modal.model';
import { IStockItemView } from 'src/app/models/stock-item-view.model';
import { ServerValidations } from 'src/app/constants/app.constants';

@Component({
  selector: 'app-stock-item-move-modal',
  templateUrl: './stock-item-move-modal.component.html',
  styleUrls: ['./stock-item-move-modal.component.css']
})
export class StockItemMoveModalComponent extends SimpleModalComponent<IStockItemMoveModal, boolean> implements OnInit, IStockItemMoveModal {
  @ViewChild("quantity", { static: true }) quantityField: ElementRef;
  stockItem: IStockItemView;
  isAdd: boolean;

  formGroup: FormGroup;
  loading: boolean;

  colorStyle: string;
  modalTitle: string;
  okButtonText: string;

  readonly min: number = 1;
  max: number;

  constructor(
    private commonService: CommonService,
    private stockService: StockService) {
    super();
  }

  ngOnInit() {
    this.colorStyle = this.isAdd ? 'success' : 'info';
    this.modalTitle = this.isAdd ? 'Adding to stock' : 'Removing from stock';
    this.okButtonText = this.isAdd ? 'Add' : 'Remove';

    this.max = this.isAdd ? ServerValidations.STOCK_MOVEMENT_QUANTITY_MAX : this.stockItem.quantity;

    this.formGroup = new FormGroup({
      quantity: new FormControl(this.min, [
        Validators.required,
        Validators.min(this.min),
        Validators.max(this.max)
      ])
    });

    this.formGroup.controls.quantity.markAsTouched();

    // stripping decimals
    this.formGroup.controls.quantity.valueChanges.subscribe(
      (value: number) => {
        if (this.commonService.getDecimalCount(value) > 0) {
          this.formGroup.controls.quantity.setValue(Math.floor(value));
        }
      });

    this.quantityField.nativeElement.focus();
  }

  onSubmit() {
    if (this.formGroup.valid) {
      let quantity = this.formGroup.value.quantity;
      if (!this.isAdd) {
        quantity *= -1;
      }

      this.loading = true;
      this.stockService.moveItem(this.stockItem, quantity).pipe(finalize(() => this.loading = false)).subscribe(() => {
        this.result = true;
        this.close();
      });
    }
  }
}
