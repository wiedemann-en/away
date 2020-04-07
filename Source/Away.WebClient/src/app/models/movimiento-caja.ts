import { Base } from './base/base';
import { Ente } from './ente';

export class MovimientoCaja extends Base {
    ente: Ente;
    tipoMovimiento: string;
    importe: number;
} 