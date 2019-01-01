import { Component, Input } from '@angular/core';
import { IExchangeRate } from 'src/app/models/exchange-rate.model';

@Component({
  selector: 'app-currency-header',
  templateUrl: './currency-header.component.html',
  styleUrls: ['./currency-header.component.css']
})
export class CurrencyHeaderComponent {
  @Input() exchangeRate: IExchangeRate;
}
