import { IStockItemView } from "./stock-item-view.model";

export interface IStatisticsResult {
  globalMass?: number
  globalPrice?: number
  topQuantityItem: IStockItemView
  topMassItem: IStockItemView
}
