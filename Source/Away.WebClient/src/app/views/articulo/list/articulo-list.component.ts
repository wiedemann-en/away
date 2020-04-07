import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Articulo } from '../../../models/articulo';
import { ArticuloService } from '../../../services/articulo.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-list',
  templateUrl: './articulo-list.component.html',
  styleUrls: ['./articulo-list.component.scss']
})

export class ArticuloListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Articulo[];

  constructor(private router: Router,
    private articuloService: ArticuloService,
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
    this.articuloService.getAll()
      .subscribe((data: Articulo[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    
    this.router.navigate([this.router.url + '/form/']);    
  }

  public update(row: Articulo): void {
    this.router.navigate(['articulos/form/', row.id]);
  }

  public updateStatus(row: Articulo): void {
    (row.activo) 
      ? this.articuloService.disable(row.id) 
      : this.articuloService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Articulo): void {
    this.commonDialog.confirmationDialog('Eliminar artículo', '¿Desea eliminar el artículo ´' + row.descripcionCorta + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
