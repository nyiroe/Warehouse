export const AppConstants = {
  // apiBaseHost is only used in dev mode
  API_BASE_HOST: "",
  API_BASE_URI: "/api/v1/"
};

export const ServerValidations = {
  STOCK_ITEM_ID_MAXLENGTH: 50,
  STOCK_ITEM_NAME_MAXLENGTH: 50,
  STOCK_ITEM_DESCRIPTION_MAXLENGTH: 250,
  STOCK_ITEM_PRICE_MAX: 1000000,
  STOCK_ITEM_MASS_MAX: 1000,
  STOCK_MOVEMENT_QUANTITY_MAX: 1000000
};

export const StockListActions = {
  NEW: 'new',
  EDIT: 'edit',
  DELETE: 'delete',
  ADD: 'add',
  REMOVE: 'remove'
};
