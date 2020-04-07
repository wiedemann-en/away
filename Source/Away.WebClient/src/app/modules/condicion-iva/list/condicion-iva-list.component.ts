import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { CondicionIva } from '../../../models/condicion-iva';
import { CondicionIvaService } from '../../../services/condicion-iva.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-condicion-iva-list',
  templateUrl: './condicion-iva-list.component.html',
  styleUrls: ['./condicion-iva-list.component.scss']
})

export class CondicionIvaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: CondicionIva[];

  constructor(private router: Router,
    private condicionIvaService: CondicionIvaService,
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
    this.condicionIvaService.getAll()
      .subscribe((data: CondicionIva[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['condicionesiva/form/']);    
  }

  public update(row: CondicionIva): void {
    this.router.navigate(['condicionesiva/form/', row.id]);
  }

  public updateStatus(row: CondicionIva): void {
    (row.activo) 
      ? this.condicionIvaService.disable(row.id) 
      : this.condicionIvaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: CondicionIva): void {
    this.commonDialog.confirmationDialog('Eliminar condición iva', '¿Desea eliminar la condición de iva ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.condicionIvaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
