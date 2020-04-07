import { Base } from './base/base';
import { Ente } from './ente';
import { ProveedorFacturacion } from './proveedor-facturacion';
import { SegmentacioNegocio } from './segmentacion-negocio';

export class Proveedor extends Base {
    ente: Ente;
    facturacion: ProveedorFacturacion;
    negocio: SegmentacioNegocio;
} 