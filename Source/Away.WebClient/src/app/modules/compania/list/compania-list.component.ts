import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Compania } from '../../../models/compania';
import { CompaniaService } from '../../../services/compania.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-compania-list',
  templateUrl: './compania-list.component.html',
  styleUrls: ['./compania-list.component.scss']
})

export class CompaniaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Compania[];

  constructor(private router: Router,
    private companiaService: CompaniaService,
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
    this.companiaService.getAll()
      .subscribe((data: Compania[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['companias/form/']);    
  }

  public update(row: Compania): void {
    this.router.navigate(['companias/form/', row.id]);
  }

  public updateStatus(row: Compania): void {
    (row.activo) 
      ? this.companiaService.disable(row.id) 
      : this.companiaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Compania): void {
    this.commonDialog.confirmationDialog('Eliminar compañía', '¿Desea eliminar la compañía ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.companiaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
