import { ArticuloUnidadMedida } from './articulo-unidad-medida';

export class ArticuloStock {
    gestionaStock: boolean;
    unidadesXBulto: number;
    bultosXPallet: number;
    unidadMedida: ArticuloUnidadMedida;
}