import { Base } from './base/base';
import { EnteDomicilioTipo } from './ente-domicilio-tipo';
import { Localidad } from './localidad';

export class EnteDomicilio extends Base {
    tipo: EnteDomicilioTipo;
    localidad: Localidad;
    codigoPostal: string;
    calle: string;
    numero: string;
    cuerpo: string;
    piso: string;
    departamento: string;
} 