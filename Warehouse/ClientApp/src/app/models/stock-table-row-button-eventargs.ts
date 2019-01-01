import { IStockItemView } from "./stock-item-view.model";

export interface IStockTableRowButtonEventArgs {
  action: string
  stockItem: IStockItemView
}
