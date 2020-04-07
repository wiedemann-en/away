import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Usuario } from '../../../models/usuario';
import { UsuarioService } from '../../../services/usuario.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-usuario-list',
  templateUrl: './usuario-list.component.html',
  styleUrls: ['./usuario-list.component.scss']
})

export class UsuarioListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Usuario[];

  constructor(private router: Router,
    private usuarioService: UsuarioService,
    private commonDialog: CommonDialog) { }

  ngOnInit() {
    this.intiliazeConfiguration();
    this.reloadData();
  }

  ngOnDestroy(): void {
    this.tableTrigger.unsubscribe();
  }

  private intiliazeConfiguration(): void {
    //TODO: DataTable Package Information:
    //https://l-lin.github.io/angular-datatables/#/getting-started
    this.tableOptions = {
      pagingType: 'full_numbers'
    };
  }

  private reloadData(): void {
    this.usuarioService.getAll()
      .subscribe((data: Usuario[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['usuarios/form/']);    
  }

  public update(row: Usuario): void {
    this.router.navigate(['usuarios/form/', row.id]);
  }

  public updateStatus(row: Usuario): void {
    (row.activo) 
      ? this.usuarioService.disable(row.id) 
      : this.usuarioService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Usuario): void {
    this.commonDialog.confirmationDialog('Eliminar usuario', '¿Desea eliminar el usuario ´' + row.email + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.usuarioService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
