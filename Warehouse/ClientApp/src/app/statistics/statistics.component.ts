import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { IStatisticsResult } from '../models/statistics-result.model';
import { StockService } from '../services/stock.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {
  statisticsResult$: Observable<IStatisticsResult>;

  constructor(private stockService: StockService) {
  }

  ngOnInit() {
    this.refresh();
  }

  private refresh(): void {
    this.statisticsResult$ = this.stockService.getStatistics();
  }
}
