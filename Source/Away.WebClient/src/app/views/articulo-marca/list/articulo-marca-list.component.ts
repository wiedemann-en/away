import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloMarca } from '../../../models/articulo-marca';
import { ArticuloMarcaService } from '../../../services/articulo-marca.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-marca-list',
  templateUrl: './articulo-marca-list.component.html',
  styleUrls: ['./articulo-marca-list.component.scss']
})

export class ArticuloMarcaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloMarca[];

  constructor(private router: Router,
    private articuloMarcaService: ArticuloMarcaService,
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
    this.articuloMarcaService.getAll()
      .subscribe((data: ArticuloMarca[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulomarcas/form/']);    
  }

  public update(row: ArticuloMarca): void {
    this.router.navigate(['articulomarcas/form/', row.id]);
  }

  public updateStatus(row: ArticuloMarca): void {
    (row.activo) 
      ? this.articuloMarcaService.disable(row.id) 
      : this.articuloMarcaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloMarca): void {
    this.commonDialog.confirmationDialog('Eliminar marca', '¿Desea eliminar la marca ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloMarcaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
