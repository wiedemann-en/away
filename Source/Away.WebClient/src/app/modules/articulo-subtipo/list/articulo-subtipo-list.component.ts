import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloSubTipo } from '../../../models/articulo-subtipo';
import { ArticuloSubTipoService } from '../../../services/articulo-subtipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-subtipo-list',
  templateUrl: './articulo-subtipo-list.component.html',
  styleUrls: ['./articulo-subtipo-list.component.scss']
})

export class ArticuloSubTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloSubTipo[];

  constructor(private router: Router,
    private articuloSubTipoService: ArticuloSubTipoService,
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
    this.articuloSubTipoService.getAll()
      .subscribe((data: ArticuloSubTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulosubtipos/form/']);    
  }

  public update(row: ArticuloSubTipo): void {
    this.router.navigate(['articulosubtipos/form/', row.id]);
  }

  public updateStatus(row: ArticuloSubTipo): void {
    (row.activo) 
      ? this.articuloSubTipoService.disable(row.id) 
      : this.articuloSubTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloSubTipo): void {
    this.commonDialog.confirmationDialog('Eliminar subtipo', '¿Desea eliminar el subtipo ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloSubTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
