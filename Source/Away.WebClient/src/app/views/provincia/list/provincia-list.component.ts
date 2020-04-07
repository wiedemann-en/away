import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Provincia } from '../../../models/provincia';
import { ProvinciaService } from '../../../services/provincia.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-provincia-list',
  templateUrl: './provincia-list.component.html',
  styleUrls: ['./provincia-list.component.scss']
})

export class ProvinciaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Provincia[];

  constructor(private router: Router,
    private provinciaService: ProvinciaService,
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
    this.provinciaService.getAll()
      .subscribe((data: Provincia[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['provincias/form/']);    
  }

  public update(row: Provincia): void {
    this.router.navigate(['provincias/form/', row.id]);
  }

  public updateStatus(row: Provincia): void {
    (row.activo) 
      ? this.provinciaService.disable(row.id) 
      : this.provinciaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Provincia): void {
    this.commonDialog.confirmationDialog('Eliminar provincia', '¿Desea eliminar la provincia ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.provinciaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
