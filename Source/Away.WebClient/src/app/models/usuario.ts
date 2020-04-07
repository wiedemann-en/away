import { Base } from './base/base';
import { Rol } from './rol';
import { SegmentacioNegocio } from './segmentacion-negocio';

export class Usuario extends Base {
    nombre: string;
    apellido: string;
    email: string;
    usuario: string;
    password: string;
    rol: Rol;
    negocio: SegmentacioNegocio;
}
