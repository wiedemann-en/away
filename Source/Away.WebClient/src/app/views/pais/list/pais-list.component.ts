import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Pais } from '../../../models/pais';
import { PaisService } from '../../../services/pais.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-pais-list',
  templateUrl: './pais-list.component.html',
  styleUrls: ['./pais-list.component.scss']
})

export class PaisListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Pais[];

  constructor(private router: Router,
    private paisService: PaisService,
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
    this.paisService.getAll()
      .subscribe((data: Pais[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['paises/form/']);    
  }

  public update(row: Pais): void {
    this.router.navigate(['paises/form/', row.id]);
  }

  public updateStatus(row: Pais): void {
    (row.activo) 
      ? this.paisService.disable(row.id) 
      : this.paisService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Pais): void {
    this.commonDialog.confirmationDialog('Eliminar país', '¿Desea eliminar el país ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.paisService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
