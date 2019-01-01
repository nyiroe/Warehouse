import { Injectable } from '@angular/core';
import Toastr from 'toastr';

@Injectable()
export class ToastrService {
  showSuccess(message: string, title?: string) {
    this.setOptions(false, 5000, 1000);
    Toastr.success(message, title);
  }

  showWarning(message: string, title?: string) {
    this.setOptions(false, 5000, 1000);
    Toastr.warning(message, title);
  }

  showError(message: string, title?: string) {
    this.setOptions(true, 0, 0);
    Toastr.error(message, title);
  }

  setOptions(closeButton: boolean, timeOut: number, extendedTimeOut: number) {
    Toastr.options = {
      "closeButton": closeButton,
      "timeOut": timeOut,
      "extendedTimeOut": extendedTimeOut
    }
  }
}
