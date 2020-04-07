import { Base } from './base/base';

export class RecursoSistema extends Base {
    appState: string;
    apiName: string;
    permiso: string;
    descripcion: string;
    appStatePadre: string;
    recursosDependientes: string;
}
