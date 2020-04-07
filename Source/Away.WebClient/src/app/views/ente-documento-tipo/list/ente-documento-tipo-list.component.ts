import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { EnteDocumentoTipo } from '../../../models/ente-documento-tipo';
import { EnteDocumentoTipoService } from '../../../services/ente-documento-tipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-ente-documento-tipo-list',
  templateUrl: './ente-documento-tipo-list.component.html',
  styleUrls: ['./ente-documento-tipo-list.component.scss']
})

export class EnteDocumentoTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: EnteDocumentoTipo[];

  constructor(private router: Router,
    private enteDocumentoTipoService: EnteDocumentoTipoService,
    private commonDialog: CommonDialog) { }

  ngOnInit() {
    this.intiliazeConfiguration();
    this.reloadData();
  }

  ngOnDestroy(): void {
    this.tableTrigger.unsubscribe();
  }

  private intiliazeConfiguration(): void {
    this.tableOptions = {
      pagingType: 'full_numbers'
    };
  }

  private reloadData(): void {
    this.enteDocumentoTipoService.getAll()
      .subscribe((data: EnteDocumentoTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['entedocumentotipos/form/']);    
  }

  public update(row: EnteDocumentoTipo): void {
    this.router.navigate(['entedocumentotipos/form/', row.id]);
  }

  public updateStatus(row: EnteDocumentoTipo): void {
    (row.activo) 
      ? this.enteDocumentoTipoService.disable(row.id) 
      : this.enteDocumentoTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: EnteDocumentoTipo): void {
    this.commonDialog.confirmationDialog('Eliminar tipo de documento', '¿Desea eliminar el tipo de documento ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.enteDocumentoTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
