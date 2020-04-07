import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloTipo } from '../../../models/articulo-tipo';
import { ArticuloTipoService } from '../../../services/articulo-tipo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-tipo-list',
  templateUrl: './articulo-tipo-list.component.html',
  styleUrls: ['./articulo-tipo-list.component.scss']
})

export class ArticuloTipoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloTipo[];

  constructor(private router: Router,
    private articuloTipoService: ArticuloTipoService,
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
    this.articuloTipoService.getAll()
      .subscribe((data: ArticuloTipo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulotipos/form/']);    
  }

  public update(row: ArticuloTipo): void {
    this.router.navigate(['articulotipos/form/', row.id]);
  }

  public updateStatus(row: ArticuloTipo): void {
    (row.activo) 
      ? this.articuloTipoService.disable(row.id) 
      : this.articuloTipoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloTipo): void {
    this.commonDialog.confirmationDialog('Eliminar tipo', '¿Desea eliminar el tipo ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloTipoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
