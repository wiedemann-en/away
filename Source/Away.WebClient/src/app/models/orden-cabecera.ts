import { Base } from './base/base';
import { Cliente } from './cliente';
import { Contacto } from './contacto';
import { SegmentacioNegocio } from './segmentacion-negocio';
import { OrdenDetalle } from './orden-detalle';

export class OrdenCabecera extends Base {
    codTipoOrden: string;
    codEstado: string;
    cliente: Cliente;
    contacto: Contacto;
    nroOC: string;
    nroComprobante: string;
    ubicacion: string;
    observaciones: string;
    esUrgente: boolean;
    fechaIngreso: Date;
    fechaFinaliacion: Date;
    fechaProcesamiento: Date;
    fechaVencimiento: Date;
    negocio: SegmentacioNegocio;
    detalles: OrdenDetalle[];
} 