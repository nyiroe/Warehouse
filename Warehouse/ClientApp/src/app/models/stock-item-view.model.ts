import { IPriceView } from "./price-view.model";

export interface IStockItemView {
  stockItemId?: number
  id: string
  name: string
  description: string
  price: number
  foreignPrice?: IPriceView
  mass: number
  quantity?: number
}
