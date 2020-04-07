import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { AlicuotaIva } from '../../../models/alicuota-iva';
import { AlicuotaIvaService } from '../../../services/alicuota-iva.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-alicuota-iva-list',
  templateUrl: './alicuota-iva-list.component.html',
  styleUrls: ['./alicuota-iva-list.component.scss']
})

export class AlicuotaIvaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: AlicuotaIva[];

  constructor(private router: Router,
    private alicuotaIvaService: AlicuotaIvaService,
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
    this.alicuotaIvaService.getAll()
      .subscribe((data: AlicuotaIva[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['alicuotasiva/form/']);    
  }

  public update(row: AlicuotaIva): void {
    this.router.navigate(['alicuotasiva/form/', row.id]);
  }

  public updateStatus(row: AlicuotaIva): void {
    (row.activo) 
      ? this.alicuotaIvaService.disable(row.id) 
      : this.alicuotaIvaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: AlicuotaIva): void {
    this.commonDialog.confirmationDialog('Eliminar alicuota de iva', '¿Desea eliminar la alicuota de iva ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.alicuotaIvaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
