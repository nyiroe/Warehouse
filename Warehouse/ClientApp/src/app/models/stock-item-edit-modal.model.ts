import { IStockItemView } from "./stock-item-view.model";

export interface IStockItemEditModal {
  stockItem: IStockItemView
  isCreate: boolean
}
