import { ArticuloTipo } from './articulo-tipo';
import { ArticuloSubTipo } from './articulo-subtipo';
import { ArticuloRubro } from './articulo-rubro';
import { ArticuloCategoria } from './articulo-categoria';
import { ArticuloLinea } from './articulo-linea';
import { ArticuloMarca } from './articulo-marca';

export class ArticuloSegmentacion {
    familia: string;
    grupo: string;
    tipo: ArticuloTipo;
    subTipo: ArticuloSubTipo;
    rubro: ArticuloRubro;
    categoria: ArticuloCategoria;
    linea: ArticuloLinea;
    marca: ArticuloMarca;
}