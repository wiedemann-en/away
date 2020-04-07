import { AlicuotaIva } from './alicuota-iva';

export class ArticuloFacturacion {
    alicuotaIva: AlicuotaIva;
    alicuotaIvaDiferencial: AlicuotaIva;
    impuestosInternosPorc: number;
    impuestosInternosFijos: number;
    percepcionIIBB: number;
}