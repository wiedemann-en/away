import { Base } from './base/base';
import { EnteTelefonoTipo } from './ente-telefono-tipo';

export class EnteTelefono extends Base {
    tipo: EnteTelefonoTipo;
    codigoArea: string;
    numero: string;
} 