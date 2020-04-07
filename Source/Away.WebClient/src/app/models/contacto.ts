import { Base } from './base/base';
import { Ente } from './ente';

export class Contacto extends Base {
    empresa: string;
    puesto: string;
    esPrincipal: boolean;
    ente: Ente;
    enteRelacion: Ente;
} 