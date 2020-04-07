import { BaseCode } from './base/base-code';
import { ArticuloStock } from './articulo-stock';
import { ArticuloFacturacion } from './articulo-facturacion';
import { ArticuloSegmentacion } from './articulo-segmentacion';
import { SegmentacioNegocio } from './segmentacion-negocio';

export class Articulo extends BaseCode {
    descripcion: string;
    descripcionCorta: string;
    presentacion: string;
    color: string;
    codigoEANBulto: string;
    codigoEANUnidad: string;
    codigoEANFraccion: string;
    stock: ArticuloStock;
    facturacion: ArticuloFacturacion;
    segmentacion: ArticuloSegmentacion;
    negocio: SegmentacioNegocio;
    esCompuesto: boolean;
    esLibreDescripcion: boolean;
    esDeOferta: boolean;
}
