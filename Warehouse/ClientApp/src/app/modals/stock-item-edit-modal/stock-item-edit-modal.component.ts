import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormControl, Validators, AbstractControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';
import { SimpleModalComponent } from 'ngx-simple-modal';
import { ErrorMessage } from 'ng-bootstrap-form-validation';
import { CommonService } from 'src/app/services/common.service';
import { StockService } from 'src/app/services/stock.service';
import { IStockItemEditModal } from 'src/app/models/stock-item-edit-modal.model';
import { IStockItemView } from 'src/app/models/stock-item-view.model';
import { ServerValidations } from 'src/app/constants/app.constants';
import { GreaterThanZero } from 'src/app/validators/greaterThanZero.validator';

@Component({
  selector: 'app-stock-item-edit-modal',
  templateUrl: './stock-item-edit-modal.component.html',
  styleUrls: ['./stock-item-edit-modal.component.css']
})
export class StockItemEditModalComponent extends SimpleModalComponent<IStockItemEditModal, IStockItemView> implements OnInit, IStockItemEditModal {
  @ViewChild("stockname", { static: true }) nameField: ElementRef;
  stockItem: IStockItemView;
  isCreate: boolean;

  formGroup: FormGroup;
  loading: boolean;

  modalTitle: string;
  okButtonText: string;

  readonly min: number = 0;
  readonly maxPrice: number = ServerValidations.STOCK_ITEM_PRICE_MAX;
  readonly maxMass: number = ServerValidations.STOCK_ITEM_MASS_MAX;

  customErrorMessages: ErrorMessage[] = [
    {
      error: 'greaterThanZero',
      format: (label, error) => `${label} must be greater than 0`
    },
    {
      error: 'pattern',
      format: (label, error) => `Only latin letters, numbers, dash and space is allowed`
    }
  ];

  constructor(
    private commonService: CommonService,
    private stockService: StockService) {
    super();
  }

  ngOnInit() {
    this.modalTitle = this.isCreate ? 'Create new item' : 'Update item';
    this.okButtonText = this.isCreate ? 'Create' : 'Update';

    this.formGroup = new FormGroup({
      name: new FormControl(this.stockItem.name, [
        Validators.required,
        Validators.maxLength(ServerValidations.STOCK_ITEM_NAME_MAXLENGTH),
        Validators.pattern(ServerValidations.STOCK_ITEM_STRING_PATTERN)
      ]),
      id: new FormControl(this.stockItem.id, [
        Validators.maxLength(ServerValidations.STOCK_ITEM_ID_MAXLENGTH),
        Validators.pattern(ServerValidations.STOCK_ITEM_STRING_PATTERN)
      ]),
      description: new FormControl(this.stockItem.description, [
        Validators.maxLength(ServerValidations.STOCK_ITEM_DESCRIPTION_MAXLENGTH),
        Validators.pattern(ServerValidations.STOCK_ITEM_STRING_PATTERN)
      ]),
      price: new FormControl(this.stockItem.price, [
        Validators.required,
        GreaterThanZero,
        Validators.max(ServerValidations.STOCK_ITEM_PRICE_MAX)
      ]),
      mass: new FormControl(this.stockItem.mass, [
        Validators.required,
        GreaterThanZero,
        Validators.max(ServerValidations.STOCK_ITEM_MASS_MAX)
      ])
    });

    this.formGroup.controls.price.valueChanges.subscribe(
      (value: number) => this.formatDecimals(value, this.formGroup.controls.price, 2));

    this.formGroup.controls.mass.valueChanges.subscribe(
      (value: number) => this.formatDecimals(value, this.formGroup.controls.mass, 4));

    this.nameField.nativeElement.focus();
  }

  onSubmit() {
    if (this.formGroup.valid) {
      const newStockItem: IStockItemView = {
        stockItemId: this.isCreate ? null : this.stockItem.stockItemId,
        id: this.formGroup.value.id,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        price: this.formGroup.value.price,
        mass: this.formGroup.value.mass
      };

      this.loading = true;

      const result: Observable<IStockItemView> = this.isCreate ? this.stockService.createItem(newStockItem) : this.stockService.updateItem(newStockItem);

      result.pipe(finalize(() => this.loading = false)).subscribe(() => {
        this.result = newStockItem;
        this.close();
      });
    }
  }

  private formatDecimals(value: number, control: AbstractControl, decimals: number) {
    const decCount: number = this.commonService.getDecimalCount(value);
    if (decCount > decimals) {
      control.setValue(value.toFixed(decimals));
    }
  }
}
