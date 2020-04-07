import { Base } from './base/base';
import { Ente } from './ente';
import { ClienteFacturacion } from './cliente-facturacion';
import { ClienteSegmentacion } from './cliente-segmentacion';
import { SegmentacioNegocio } from './segmentacion-negocio';

export class Cliente extends Base {
    email: string;
    nombreFantasia: string;
    rol: string;
    ente: Ente;
    facturacion: ClienteFacturacion;
    segmentacion: ClienteSegmentacion;
    negocio: SegmentacioNegocio;
}
