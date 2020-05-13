import { Plano } from './Plano';

export interface Cliente {
    id: number;
    nome: string;
    plano: Plano;
}
