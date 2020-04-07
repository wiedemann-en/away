import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloUnidadMedida } from '../../../models/articulo-unidad-medida';
import { ArticuloUnidadMedidaService } from '../../../services/articulo-unidad-medida.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-unidad-medida-list',
  templateUrl: './articulo-unidad-medida-list.component.html',
  styleUrls: ['./articulo-unidad-medida-list.component.scss']
})

export class ArticuloUnidadMedidaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloUnidadMedida[];

  constructor(private router: Router,
    private articuloUnidadMedidaService: ArticuloUnidadMedidaService,
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
    this.articuloUnidadMedidaService.getAll()
      .subscribe((data: ArticuloUnidadMedida[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulounidadesmedida/form/']);    
  }

  public update(row: ArticuloUnidadMedida): void {
    this.router.navigate(['articulounidadesmedida/form/', row.id]);
  }

  public updateStatus(row: ArticuloUnidadMedida): void {
    (row.activo) 
      ? this.articuloUnidadMedidaService.disable(row.id) 
      : this.articuloUnidadMedidaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloUnidadMedida): void {
    this.commonDialog.confirmationDialog('Eliminar unidad de medida', '¿Desea eliminar la unidad de medida ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloUnidadMedidaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
