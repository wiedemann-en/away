import { Articulo } from './articulo';

export class OrdenDetalle {
    id: number;
    idOrdenCabecera: number;
    orden: number;
    articulo: Articulo;
    articuloCodigo: string;
    articuloDescripcion: string;
    articuloPrecio: number;
    cantidad: number;
    codEstado: string;
    observaciones: string;
} 