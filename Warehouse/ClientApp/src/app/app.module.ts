import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SimpleModalModule } from 'ngx-simple-modal';
import { NgxLoadingModule } from 'ngx-loading';
import { NgBootstrapFormValidationModule } from 'ng-bootstrap-form-validation';

import { StockService } from './services/stock.service';
import { ToastrService } from './services/toastr.service';
import { ErrorHandlerService } from './services/error-handler.service';
import { CommonService } from './services/common.service';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { LoadingComponent } from './common/loading/loading.component';
import { StockListComponent } from './stock-list/stock-list.component';
import { StatisticsComponent } from './statistics/statistics.component';
import { CurrencyHeaderComponent } from './stock-list/currency-header/currency-header.component';
import { StockTableComponent } from './stock-list/stock-table/stock-table.component';
import { StockTableRowComponent } from './stock-list/stock-table/stock-table-row/stock-table-row.component';
import { StockTableRowButtonComponent } from './stock-list/stock-table/stock-table-row/stock-table-row-button/stock-table-row-button.component';
import { StockItemEditModalComponent } from './modals/stock-item-edit-modal/stock-item-edit-modal.component';
import { StockItemMoveModalComponent } from './modals/stock-item-move-modal/stock-item-move-modal.component';
import { StockItemDeleteModalComponent } from './modals/stock-item-delete-modal/stock-item-delete-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    LoadingComponent,
    StockListComponent,
    StatisticsComponent,
    CurrencyHeaderComponent,
    StockTableComponent,
    StockTableRowComponent,
    StockTableRowButtonComponent,
    StockItemEditModalComponent,
    StockItemMoveModalComponent,
    StockItemDeleteModalComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    FontAwesomeModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    SimpleModalModule,
    NgxLoadingModule.forRoot({}),
    NgBootstrapFormValidationModule.forRoot(),
    NgBootstrapFormValidationModule,
    RouterModule.forRoot([
      { path: '', component: StockListComponent, pathMatch: 'full' },
      { path: 'statistics', component: StatisticsComponent }
    ])
  ],
  providers: [
    CommonService,
    StockService,
    ToastrService,
    ErrorHandlerService
  ],
  entryComponents: [
    StockItemEditModalComponent,
    StockItemMoveModalComponent,
    StockItemDeleteModalComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
