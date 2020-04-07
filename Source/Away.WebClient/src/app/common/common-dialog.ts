import { Injectable } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { ConfirmationDialogComponent } from '../shared/confirmation-dialog/confirmation-dialog.component';

@Injectable()
export class CommonDialog {

  constructor(private modalService: NgbModal) { }

  public confirmationDialog(title: string,
    message: string, 
    btnAcceptText: string = 'ACEPTAR', 
    btnCancelText: string = 'CANCELAR',
    dialogSize: 'sm'|'lg' = 'sm'): Promise<boolean> {
        const modalRef = this.modalService.open(ConfirmationDialogComponent, { size: dialogSize, backdrop: 'static', keyboard: false });
        modalRef.componentInstance.title = title;
        modalRef.componentInstance.message = message;
        modalRef.componentInstance.btnAcceptText = btnAcceptText;
        modalRef.componentInstance.btnCancelText = btnCancelText;
        return modalRef.result;
  }
}
