import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Cliente } from '../../../models/cliente';
import { ClienteService } from '../../../services/cliente.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './cliente-list.component.html',
  styleUrls: ['./cliente-list.component.scss']
})

export class ClienteListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Cliente[];

  constructor(private router: Router,
    private clienteService: ClienteService,
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
    this.clienteService.getAll()
      .subscribe((data: Cliente[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['clientes/form/']);    
  }

  public update(row: Cliente): void {
    this.router.navigate(['clientes/form/', row.id]);
  }

  public updateStatus(row: Cliente): void {
    (row.activo) 
      ? this.clienteService.disable(row.id) 
      : this.clienteService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Cliente): void {
    this.commonDialog.confirmationDialog('Eliminar cliente', '¿Desea eliminar el cliente ´' + row.nombreFantasia + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.clienteService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
