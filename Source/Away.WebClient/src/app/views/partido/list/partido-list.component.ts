import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Partido } from '../../../models/partido';
import { PartidoService } from '../../../services/partido.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-partido-list',
  templateUrl: './partido-list.component.html',
  styleUrls: ['./partido-list.component.scss']
})

export class PartidoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Partido[];

  constructor(private router: Router,
    private partidoService: PartidoService,
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
    this.partidoService.getAll()
      .subscribe((data: Partido[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['partidos/form/']);    
  }

  public update(row: Partido): void {
    this.router.navigate(['partidos/form/', row.id]);
  }

  public updateStatus(row: Partido): void {
    (row.activo) 
      ? this.partidoService.disable(row.id) 
      : this.partidoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Partido): void {
    this.commonDialog.confirmationDialog('Eliminar partido', '¿Desea eliminar el partido ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.partidoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
