import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { MovimientoCaja } from '../../../models/movimiento-caja';
import { MovimientoCajaService } from '../../../services/movimiento-caja.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-movimiento-caja-list',
  templateUrl: './movimiento-caja-list.component.html',
  styleUrls: ['./movimiento-caja-list.component.scss']
})

export class MovimientoCajaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: MovimientoCaja[];

  constructor(private router: Router,
    private movimientoCajaService: MovimientoCajaService,
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
    this.movimientoCajaService.getAll()
      .subscribe((data: MovimientoCaja[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['movimientoscaja/form/']);    
  }

  public update(row: MovimientoCaja): void {
    this.router.navigate(['movimientoscaja/form/', row.id]);
  }

  public updateStatus(row: MovimientoCaja): void {
    (row.activo) 
      ? this.movimientoCajaService.disable(row.id) 
      : this.movimientoCajaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: MovimientoCaja): void {
    this.commonDialog.confirmationDialog('Eliminar movimiento de caja', '¿Desea eliminar el movimiento de caja ´' + row.id + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.movimientoCajaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
