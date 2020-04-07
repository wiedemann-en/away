import { CondicionIva } from './condicion-iva';
import { CondicionPago } from './condicion-pago';

export class ClienteFacturacion {
    condicionIva: CondicionIva;
    condicionPago: CondicionPago;
    percibirIB: boolean;
    alicuotaIB: number;
    ivaDiferencial: boolean;
}
