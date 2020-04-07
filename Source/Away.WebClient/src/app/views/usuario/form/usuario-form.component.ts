import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { Action } from '../../../models/enums/enum-action';
import { Rol } from '../../../models/rol';
import { Usuario } from '../../../models/usuario';
import { RolService } from '../../../services/rol.service';
import { UsuarioService } from '../../../services/usuario.service';
import { CommonHelpers } from '../../../common/common-helpers';

@Component({
  selector: 'app-usuario-form',
  templateUrl: './usuario-form.component.html',
  styleUrls: ['./usuario-form.component.scss']
})

export class UsuarioFormComponent implements OnInit {
  private usuarioId: number;
  public usuarioModel: Usuario;
  public roles: Rol[];
  public formGroup: FormGroup;
  public submitted: boolean = false;

  constructor(private router: Router,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder,
    private rolService: RolService,
    private usuarioService: UsuarioService,
    private commonHelpers: CommonHelpers) { 
  }

  ngOnInit() {
    this.initializeParams();
    this.initializeForm();
    this.initializeData();
  }

  private initializeParams() {
    this.usuarioId = this.commonHelpers.toNumber(this.route.snapshot.params.id);
  }

  private initializeForm() {
    this.formGroup = this.formBuilder.group({
      nombre: ['', Validators.required],
      apellido: ['', Validators.required],
      email: ['', [
        Validators.required,
        Validators.pattern('/^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$/')]],
      usuario: ['', [
        Validators.required, 
        Validators.minLength(6), 
        Validators.pattern('^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$')]],
      password: ['', [
        Validators.required, 
        Validators.minLength(6)]],
      rol: this.formBuilder.group({
        id: ['', Validators.required]
      })
    });
  }

  private initializeData() {
    if (this.usuarioId > 0) {
      this.usuarioService.getById(this.usuarioId).subscribe((data: Usuario) => { 
        this.usuarioModel = data; 
        this.formGroup.patchValue(data);
      });
    }
    else {
      this.usuarioModel = new Usuario(); 
    }
    this.rolService.getActives().subscribe((data: Rol[]) => this.roles = data);
  }

  get action(): Action { 
    return (this.usuarioId > 0) ? Action.Update : Action.Create;
  }

  get title(): string { 
    return (this.usuarioId > 0) ? 'Editar Usuario' : 'Nuevo Usuario';
  }

  get formData() { 
    return this.formGroup.controls; 
  }

  reset(): void {
    this.formGroup.reset();    
  }

  cancel(): void {
    this.router.navigate(['usuarios']);   
  }

  onSubmit(): void {
    this.submitted = true;
    if (this.formGroup.invalid) {
        return;
    }
    let usuario: Usuario = this.formGroup.value;
    if (this.action === Action.Create) {
      this.usuarioService.create(usuario).subscribe(response => {
        this.router.navigate(['usuarios']);
      });
    }
    else if (this.action === Action.Update) {
      this.usuarioService.update(usuario).subscribe(response => {
        this.router.navigate(['usuarios']);
      });
    }
  }  
}
