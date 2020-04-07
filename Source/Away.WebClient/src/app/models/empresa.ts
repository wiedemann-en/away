import { Base } from './base/base';
import { Compania } from './compania';

export class Empresa extends Base {
    razonSocial: string;
    cuit: string;
    compania: Compania;
}
