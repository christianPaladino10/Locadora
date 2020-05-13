import { TipoStreaming } from './TipoStreaming';
import { Ator } from './Ator';
import { Genero } from './Genero';

export interface Streaming {
    id: number;
    sinopse: string;
    titulo: string;
    classificacaoIndicativa: number;
    imagemURL: string;
    dataLancamento: Date;
    dataCadastro: Date;
    dataModificado: Date;
    tipoStreaming: TipoStreaming;
    genero: Genero[];
    ator: Ator[];
}
