import { Base } from './base/base';
import { Rol } from './rol';

export class UsuarioAutenticado extends Base {
    nombre: string;
    apellido: string;
    token: string;
    rol: Rol;
}
