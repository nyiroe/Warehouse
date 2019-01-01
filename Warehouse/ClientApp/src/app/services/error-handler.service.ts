import { Injectable } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { ToastrService } from './toastr.service';
import { Observable } from 'rxjs';

@Injectable()
export class ErrorHandlerService {
  constructor(private toastrService: ToastrService) {
  }

  handleError(error: HttpErrorResponse): Observable<any> {
    if (error.status === 400) {
      this.toastrService.showWarning(null, error.error.error);
    }
    else {
      this.toastrService.showError("Please refresh the page to try again!", "An unexpected error has occured");
    }

    return throwError(error.message);
  }
}
