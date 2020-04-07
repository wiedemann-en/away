import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ClienteCategoria } from '../../../models/cliente-categoria';
import { ClienteCategoriaService } from '../../../services/cliente-categoria.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-cliente-categoria-list',
  templateUrl: './cliente-categoria-list.component.html',
  styleUrls: ['./cliente-categoria-list.component.scss']
})

export class ClienteCategoriaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ClienteCategoria[];

  constructor(private router: Router,
    private clienteCategoriaService: ClienteCategoriaService,
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
    this.clienteCategoriaService.getAll()
      .subscribe((data: ClienteCategoria[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['clientecategorias/form/']);    
  }

  public update(row: ClienteCategoria): void {
    this.router.navigate(['clienteCategoriaService/form/', row.id]);
  }

  public updateStatus(row: ClienteCategoria): void {
    (row.activo) 
      ? this.clienteCategoriaService.disable(row.id) 
      : this.clienteCategoriaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ClienteCategoria): void {
    this.commonDialog.confirmationDialog('Eliminar categoría', '¿Desea eliminar la categoría ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.clienteCategoriaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
