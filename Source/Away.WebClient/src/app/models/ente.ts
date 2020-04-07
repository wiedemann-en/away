import { BaseCode } from './base/base-code';
import { EnteDocumentoTipo } from './ente-documento-tipo';
import { EnteDomicilio } from './ente-domicilio';
import { EnteTelefono } from './ente-telefono';
import { Contacto } from './contacto';

export class Ente extends BaseCode {
    apellidoRazonSocial: string;
    nombre: string;
    tipoDocumento: EnteDocumentoTipo;
    nroFiscal: string;
    esPersonaJuridica: boolean;
    tipoEnte: string;
    domicilios: EnteDomicilio[];
    telefonos: EnteTelefono[];
    contactos: Contacto[];
}