import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Proveedor } from '../../../models/proveedor';
import { ProveedorService } from '../../../services/proveedor.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-proveedor-list',
  templateUrl: './proveedor-list.component.html',
  styleUrls: ['./proveedor-list.component.scss']
})

export class ProveedorListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Proveedor[];

  constructor(private router: Router,
    private proveedorService: ProveedorService,
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
    this.proveedorService.getAll()
      .subscribe((data: Proveedor[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['proveedores/form/']);    
  }

  public update(row: Proveedor): void {
    this.router.navigate(['proveedores/form/', row.id]);
  }

  public updateStatus(row: Proveedor): void {
    (row.activo) 
      ? this.proveedorService.disable(row.id) 
      : this.proveedorService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Proveedor): void {
    this.commonDialog.confirmationDialog('Eliminar proveedor', '¿Desea eliminar el proveedor ´' + row.ente.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.proveedorService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
