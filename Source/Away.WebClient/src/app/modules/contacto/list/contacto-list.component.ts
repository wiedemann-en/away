import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

import { Contacto } from '../../../models/contacto';
import { ContactoService } from '../../../services/contacto.service';
import { CommonDialog } from '../../../common/common-dialog';

@Component({
  selector: 'app-contacto-list',
  templateUrl: './contacto-list.component.html',
  styleUrls: ['./contacto-list.component.scss']
})

export class ContactoListComponent implements OnInit, OnDestroy {
  public tableOptions: DataTables.Settings = {};
  public tableTrigger: Subject<any> = new Subject();
  public tableData: Contacto[];

  constructor(private router: Router,
    private contactoService: ContactoService,
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
    this.contactoService.getAll()
      .subscribe((data: Contacto[]) => { 
        this.tableData = data;
        this.tableTrigger.next();
      });
  }  

  public create(): void {
    this.router.navigate(['contactos/form/']);    
  }

  public update(row: Contacto): void {
    this.router.navigate(['contactos/form/', row.id]);
  }

  public updateStatus(row: Contacto): void {
    (row.activo) 
      ? this.contactoService.disable(row.id) 
      : this.contactoService.enable(row.id);
    this.reloadData();
  }

  public delete(row: Contacto): void {
    this.commonDialog.confirmationDialog('Eliminar contacto', '¿Desea eliminar el contacto ´' + row.ente.nombre + '´?')
      .then((confirmed) => {
        if (confirmed) {
          this.contactoService.delete(row.id);
          this.reloadData();
        }
    });
  }
}
