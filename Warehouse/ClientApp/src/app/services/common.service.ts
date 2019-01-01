import { Injectable } from '@angular/core';

@Injectable()
export class CommonService {
  getDecimalCount(value: number): number {
    if (!value || Math.floor(value) === value) return 0;
    return value.toString().split(".")[1].length || 0;
  }
}
