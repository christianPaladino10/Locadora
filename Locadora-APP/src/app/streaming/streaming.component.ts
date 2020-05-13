import { Component, OnInit, Input } from '@angular/core';
import { StreamingService } from '../_services/streaming.service';
import { Streaming } from '../_models/Streaming';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { ConteudoModalComponent } from '../conteudoModal/conteudoModal.component';
import { ClienteComponent } from '../cliente/cliente.component';
import { Cliente } from '../_models/Cliente';
import { ClienteService } from '../_services/cliente.service';

@Component({
  selector: 'app-streaming',
  templateUrl: './streaming.component.html',
  styleUrls: ['./streaming.component.css']
})
export class StreamingComponent implements OnInit {

  Streamings: Streaming[];
  Streaming: Streaming;

  Cliente: Cliente;
  modalRef: BsModalRef;
  idCliente = 1;

  @Input() qtdParaAlugar: number;

  constructor(
      private streamingService: StreamingService
    , private modalService: BsModalService
    , private clienteService: ClienteService
  ) { }

  ngOnInit()
  {
    this.getStreamings();
    this.getClienteById();
  }

  getClienteById()
  {
    this.clienteService.getClienteById(this.idCliente).subscribe(
      (responseCliente: Cliente) =>
      {
        this.Cliente = responseCliente;
        console.log(responseCliente);
      },
      error =>
      {
        console.log(error);
      }
    );
  }

  getStreamings()
  {
    this.streamingService.getAllStreaming().subscribe(
      (responseStreaming: Streaming[]) =>
      {
        this.Streamings = responseStreaming;
        console.log(responseStreaming);
      },
      error =>
      {
        console.log(error);
      }
    );
  }

  detalheStreaming(streamingClicada: Streaming, cliente: Cliente)
  {
    const initialState = {
      objStreaming: streamingClicada,
      objCliente: cliente
    };
    this.modalService.show(ConteudoModalComponent, { initialState, class: 'modal-lg' });
  }

}
