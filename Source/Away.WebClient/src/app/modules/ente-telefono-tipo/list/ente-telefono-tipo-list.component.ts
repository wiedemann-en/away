import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { EnteTelefonoTipo } from '../../../models/ente-telefono-tipo';
import { EnteTelefonoTipoService } from '../../../services/ente-telefono-tipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-ente-telefono-tipo-list',
  templateUrl: './ente-telefono-tipo-list.component.html',
  styleUrls: ['./ente-telefono-tipo-list.component.scss']
})

export class EnteTelefonoTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: EnteTelefonoTipo[];

  constructor(private router: Router,
    private enteTelefonoTipoService: EnteTelefonoTipoService,
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
    this.enteTelefonoTipoService.getAll()
      .subscribe((data: EnteTelefonoTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['entetelefonotipos/form/']);    
  }

  public update(row: EnteTelefonoTipo): void {
    this.router.navigate(['entetelefonotipos/form/', row.id]);
  }

  public updateStatus(row: EnteTelefonoTipo): void {
    (row.activo) 
      ? this.enteTelefonoTipoService.disable(row.id) 
      : this.enteTelefonoTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: EnteTelefonoTipo): void {
    this.commonDialog.confirmationDialog('Eliminar tipo de teléfono', '¿Desea eliminar el tipo de teléfono ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.enteTelefonoTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
