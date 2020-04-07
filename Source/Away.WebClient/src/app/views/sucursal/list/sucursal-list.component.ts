import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Sucursal } from '../../../models/sucursal';
import { SucursalService } from '../../../services/sucursal.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-sucursal-list',
  templateUrl: './sucursal-list.component.html',
  styleUrls: ['./sucursal-list.component.scss']
})

export class SucursalListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Sucursal[];

  constructor(private router: Router,
    private sucursalService: SucursalService,
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
    this.sucursalService.getAll()
      .subscribe((data: Sucursal[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['sucursales/form/']);    
  }

  public update(row: Sucursal): void {
    this.router.navigate(['sucursales/form/', row.id]);
  }

  public updateStatus(row: Sucursal): void {
    (row.activo) 
      ? this.sucursalService.disable(row.id) 
      : this.sucursalService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Sucursal): void {
    this.commonDialog.confirmationDialog('Eliminar sucursal', '¿Desea eliminar la sucursal ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.sucursalService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
