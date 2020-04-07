import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Empresa } from '../../../models/empresa';
import { EmpresaService } from '../../../services/empresa.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-empresa-list',
  templateUrl: './empresa-list.component.html',
  styleUrls: ['./empresa-list.component.scss']
})

export class EmpresaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Empresa[];

  constructor(private router: Router,
    private empresaService: EmpresaService,
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
    this.empresaService.getAll()
      .subscribe((data: Empresa[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['empresas/form/']);    
  }

  public update(row: Empresa): void {
    this.router.navigate(['empresas/form/', row.id]);
  }

  public updateStatus(row: Empresa): void {
    (row.activo) 
      ? this.empresaService.disable(row.id) 
      : this.empresaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Empresa): void {
    this.commonDialog.confirmationDialog('Eliminar empresa', '¿Desea eliminar la empresa ´' + row.razonSocial + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.empresaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
