import { ClienteTipo } from './cliente-tipo';
import { ClienteSubTipo } from './cliente-subtipo';
import { ClienteRubro } from './cliente-rubro';
import { ClienteCategoria } from './cliente-categoria';

export class ClienteSegmentacion {
    grupo: string;
    zona: string;
    tipo: ClienteTipo;
    subTipo: ClienteSubTipo;
    rubro: ClienteRubro;
    categoria: ClienteCategoria;
}
