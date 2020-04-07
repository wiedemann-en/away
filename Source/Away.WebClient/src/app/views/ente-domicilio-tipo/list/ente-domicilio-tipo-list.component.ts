import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { EnteDomicilioTipo } from '../../../models/ente-domicilio-tipo';
import { EnteDomicilioTipoService } from '../../../services/ente-domicilio-tipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-ente-domicilio-tipo-list',
  templateUrl: './ente-domicilio-tipo-list.component.html',
  styleUrls: ['./ente-domicilio-tipo-list.component.scss']
})

export class EnteDomicilioTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: EnteDomicilioTipo[];

  constructor(private router: Router,
    private enteDomicilioTipoService: EnteDomicilioTipoService,
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
    this.enteDomicilioTipoService.getAll()
      .subscribe((data: EnteDomicilioTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['entedomiciliotipos/form/']);    
  }

  public update(row: EnteDomicilioTipo): void {
    this.router.navigate(['entedomiciliotipos/form/', row.id]);
  }

  public updateStatus(row: EnteDomicilioTipo): void {
    (row.activo) 
      ? this.enteDomicilioTipoService.disable(row.id) 
      : this.enteDomicilioTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: EnteDomicilioTipo): void {
    this.commonDialog.confirmationDialog('Eliminar tipo de domicilio', '¿Desea eliminar el tipo de domicilio ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.enteDomicilioTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
