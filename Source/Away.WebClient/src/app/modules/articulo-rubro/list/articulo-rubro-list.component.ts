import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { ArticuloRubro } from '../../../models/articulo-rubro';
import { ArticuloRubroService } from '../../../services/articulo-rubro.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-articulo-rubro-list',
  templateUrl: './articulo-rubro-list.component.html',
  styleUrls: ['./articulo-rubro-list.component.scss']
})

export class ArticuloRubroListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: ArticuloRubro[];

  constructor(private router: Router,
    private articuloRubroService: ArticuloRubroService,
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
    this.articuloRubroService.getAll()
      .subscribe((data: ArticuloRubro[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['articulorubros/form/']);    
  }

  public update(row: ArticuloRubro): void {
    this.router.navigate(['articulorubros/form/', row.id]);
  }

  public updateStatus(row: ArticuloRubro): void {
    (row.activo) 
      ? this.articuloRubroService.disable(row.id) 
      : this.articuloRubroService.enable(row.id);
    this.reloadData();
  }

  public delete(row: ArticuloRubro): void {
    this.commonDialog.confirmationDialog('Eliminar rubro', '¿Desea eliminar el rubro ´' + row.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.articuloRubroService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
