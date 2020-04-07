import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloLinea } from '../../../models/articulo-linea';
import { ArticuloLineaService } from '../../../services/articulo-linea.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-linea-list',
  templateUrl: './articulo-linea-list.component.html',
  styleUrls: ['./articulo-linea-list.component.scss']
})

export class ArticuloLineaListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloLinea[];

  constructor(private router: Router,
    private articuloLineaService: ArticuloLineaService,
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
    this.articuloLineaService.getAll()
      .subscribe((data: ArticuloLinea[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulolineas/form/']);    
  }

  public update(row: ArticuloLinea): void {
    this.router.navigate(['articulolineas/form/', row.id]);
  }

  public updateStatus(row: ArticuloLinea): void {
    (row.activo) 
      ? this.articuloLineaService.disable(row.id) 
      : this.articuloLineaService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloLinea): void {
    this.commonDialog.confirmationDialog('Eliminar línea', '¿Desea eliminar la línea ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloLineaService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
