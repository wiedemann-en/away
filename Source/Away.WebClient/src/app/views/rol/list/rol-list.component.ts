import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Rol } from '../../../models/rol';
import { RolService } from '../../../services/rol.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-rol-list',
  templateUrl: './rol-list.component.html',
  styleUrls: ['./rol-list.component.scss']
})

export class RolListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Rol[];

  constructor(private router: Router,
    private rolService: RolService,
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
    this.rolService.getAll()
      .subscribe((data: Rol[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['roles/form/']);    
  }

  public update(row: Rol): void {
    this.router.navigate(['roles/form/', row.id]);
  }

  public updateStatus(row: Rol): void {
    (row.activo) 
      ? this.rolService.disable(row.id) 
      : this.rolService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Rol): void {
    this.commonDialog.confirmationDialog('Eliminar rol', '¿Desea eliminar el rol ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.rolService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
