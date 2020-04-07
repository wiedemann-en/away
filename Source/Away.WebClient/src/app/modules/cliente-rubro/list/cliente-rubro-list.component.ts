import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ClienteRubro } from '../../../models/cliente-rubro';
import { ClienteRubroService } from '../../../services/cliente-rubro.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-cliente-rubro-list',
  templateUrl: './cliente-rubro-list.component.html',
  styleUrls: ['./cliente-rubro-list.component.scss']
})

export class ClienteRubroListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ClienteRubro[];

  constructor(private router: Router,
    private clienteRubroService: ClienteRubroService,
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
    this.clienteRubroService.getAll()
      .subscribe((data: ClienteRubro[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['clienterubros/form/']);    
  }

  public update(row: ClienteRubro): void {
    this.router.navigate(['clienterubros/form/', row.id]);
  }

  public updateStatus(row: ClienteRubro): void {
    (row.activo) 
      ? this.clienteRubroService.disable(row.id) 
      : this.clienteRubroService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ClienteRubro): void {
    this.commonDialog.confirmationDialog('Eliminar rubro', '¿Desea eliminar el rubro ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.clienteRubroService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
