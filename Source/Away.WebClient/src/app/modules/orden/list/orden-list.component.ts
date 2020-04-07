import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { OrdenCabecera } from '../../../models/orden-cabecera';
import { OrdenService } from '../../../services/orden.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-orden-list',
  templateUrl: './orden-list.component.html',
  styleUrls: ['./orden-list.component.scss']
})

export class OrdenListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: OrdenCabecera[];

  constructor(private router: Router,
    private ordenService: OrdenService,
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
    this.ordenService.getAll()
      .subscribe((data: OrdenCabecera[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['ordenes/form/']);    
  }

  public update(row: OrdenCabecera): void {
    this.router.navigate(['ordenes/form/', row.id]);
  }

  public updateStatus(row: OrdenCabecera): void {
    (row.activo) 
      ? this.ordenService.disable(row.id) 
      : this.ordenService.enable(row.id);
    this.reloadData();
  }

  public delete(row: OrdenCabecera): void {
    this.commonDialog.confirmationDialog('Eliminar orden de pedido', '¿Desea eliminar la orden de pedido ´' + row.id + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.ordenService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
