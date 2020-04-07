import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloCategoria } from '../../../models/articulo-categoria';
import { ArticuloCategoriaService } from '../../../services/articulo-categoria.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-categoria-list',
  templateUrl: './articulo-categoria-list.component.html',
  styleUrls: ['./articulo-categoria-list.component.scss']
})

export class ArticuloCategoriaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloCategoria[];

  constructor(private router: Router,
    private articuloCategoriaService: ArticuloCategoriaService,
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
    this.articuloCategoriaService.getAll()
      .subscribe((data: ArticuloCategoria[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulocategorias/form/']);    
  }

  public update(row: ArticuloCategoria): void {
    this.router.navigate(['articulocategorias/form/', row.id]);
  }

  public updateStatus(row: ArticuloCategoria): void {
    (row.activo) 
      ? this.articuloCategoriaService.disable(row.id) 
      : this.articuloCategoriaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloCategoria): void {
    this.commonDialog.confirmationDialog('Eliminar categoria', '¿Desea eliminar la categoria ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloCategoriaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
