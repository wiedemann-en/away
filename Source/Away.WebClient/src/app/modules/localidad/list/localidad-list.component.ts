import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Localidad } from '../../../models/localidad';
import { LocalidadService } from '../../../services/localidad.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-localidad-list',
  templateUrl: './localidad-list.component.html',
  styleUrls: ['./localidad-list.component.scss']
})

export class LocalidadListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Localidad[];

  constructor(private router: Router,
    private localidadService: LocalidadService,
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
    this.localidadService.getAll()
      .subscribe((data: Localidad[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['localidades/form/']);    
  }

  public update(row: Localidad): void {
    this.router.navigate(['localidades/form/', row.id]);
  }

  public updateStatus(row: Localidad): void {
    (row.activo) 
      ? this.localidadService.disable(row.id) 
      : this.localidadService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Localidad): void {
    this.commonDialog.confirmationDialog('Eliminar localidad', '¿Desea eliminar la localidad ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.localidadService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
