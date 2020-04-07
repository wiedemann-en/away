import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ClienteSubTipo } from '../../../models/cliente-subtipo';
import { ClienteSubTipoService } from '../../../services/cliente-subtipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-cliente-subtipo-list',
  templateUrl: './cliente-subtipo-list.component.html',
  styleUrls: ['./cliente-subtipo-list.component.scss']
})

export class ClienteSubTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ClienteSubTipo[];

  constructor(private router: Router,
    private clienteSubTipoService: ClienteSubTipoService,
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
    this.clienteSubTipoService.getAll()
      .subscribe((data: ClienteSubTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['clientesubtipos/form/']);    
  }

  public update(row: ClienteSubTipo): void {
    this.router.navigate(['clientesubtipos/form/', row.id]);
  }

  public updateStatus(row: ClienteSubTipo): void {
    (row.activo) 
      ? this.clienteSubTipoService.disable(row.id) 
      : this.clienteSubTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ClienteSubTipo): void {
    this.commonDialog.confirmationDialog('Eliminar subtipo', '¿Desea eliminar el subtipo ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.clienteSubTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
