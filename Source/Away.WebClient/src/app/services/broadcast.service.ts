import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable()
export class BroadcastService {

  constructor(private toastr: ToastrService) {
  }

  public showSuccess(msgSuccess: string, msgTitle?: string) {
    this.toastr.success(msgSuccess, msgTitle, { timeOut: 2000 });
  }

  public showInfo(msgInfo: string, msgTitle?: string) {
    this.toastr.info(msgInfo, msgTitle, { timeOut: 2000 });
  }

  public showWarning(msgWarning: string, msgTitle?: string) {
    this.toastr.warning(msgWarning, msgTitle, { timeOut: 2000 });
  }

  public showError(msgError: string, msgTitle?: string) {
    this.toastr.error(msgError, msgTitle, { timeOut: 2000 });
  }

  public showErrors(msgErrors: string[], msgTitle?: string) {
    let msgError = '';
    for (let iPos = 0; iPos < msgErrors.length; iPos++) {
        if (iPos > 0) {
            msgError = msgError + ' | ';
        }
        msgError = msgError + msgErrors[iPos];
    }
    this.toastr.error(msgError, msgTitle, { timeOut: 2000 });
  }
}