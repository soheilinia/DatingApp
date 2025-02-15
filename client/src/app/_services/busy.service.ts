import { inject, Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  bussyRequestCount = 0;
  private spinnerService = inject(NgxSpinnerService);

  bussy() {
    this.bussyRequestCount++;
    this.spinnerService.show(undefined, {
      type: 'line-scale-party',
      bdColor: 'rgba(255, 255, 255, 0.6)',
      color: '#333333',
      fullScreen: true
    })
  }

  idle() {
    this.bussyRequestCount--;
    if (this.bussyRequestCount <= 0) {
      this.bussyRequestCount = 0;
      this.spinnerService.hide();
    }
  }
}
