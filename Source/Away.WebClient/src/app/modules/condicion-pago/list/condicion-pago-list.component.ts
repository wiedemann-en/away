import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { CondicionPago } from '../../../models/condicion-pago';
import { CondicionPagoService } from '../../../services/condicion-pago.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-condicion-pago-list',
  templateUrl: './condicion-pago-list.component.html',
  styleUrls: ['./condicion-pago-list.component.scss']
})

export class CondicionPagoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: CondicionPago[];

  constructor(private router: Router,
    private condicionPagoService: CondicionPagoService,
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
    this.condicionPagoService.getAll()
      .subscribe((data: CondicionPago[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['condicionespago/form/']);    
  }

  public update(row: CondicionPago): void {
    this.router.navigate(['condicionespago/form/', row.id]);
  }

  public updateStatus(row: CondicionPago): void {
    (row.activo) 
      ? this.condicionPagoService.disable(row.id) 
      : this.condicionPagoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: CondicionPago): void {
    this.commonDialog.confirmationDialog('Eliminar condición pago', '¿Desea eliminar la condición de pago ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.condicionPagoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
