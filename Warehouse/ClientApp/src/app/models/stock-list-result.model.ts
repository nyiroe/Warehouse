import { IExchangeRate } from "./exchange-rate.model";
import { IStockItemView } from "./stock-item-view.model";

export interface IStockListResult {
  exchangeRate: IExchangeRate
  stockList: IStockItemView[]
}
