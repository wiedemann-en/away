import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ClienteTipo } from '../../../models/cliente-tipo';
import { ClienteTipoService } from '../../../services/cliente-tipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-cliente-tipo-list',
  templateUrl: './cliente-tipo-list.component.html',
  styleUrls: ['./cliente-tipo-list.component.scss']
})

export class ClienteTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ClienteTipo[];

  constructor(private router: Router,
    private clienteTipoService: ClienteTipoService,
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
    this.clienteTipoService.getAll()
      .subscribe((data: ClienteTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['clientetipos/form/']);    
  }

  public update(row: ClienteTipo): void {
    this.router.navigate(['clientetipos/form/', row.id]);
  }

  public updateStatus(row: ClienteTipo): void {
    (row.activo) 
      ? this.clienteTipoService.disable(row.id) 
      : this.clienteTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ClienteTipo): void {
    this.commonDialog.confirmationDialog('Eliminar tipo', '¿Desea eliminar el tipo ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.clienteTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
