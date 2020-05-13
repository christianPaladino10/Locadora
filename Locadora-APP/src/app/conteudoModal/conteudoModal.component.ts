import { Component, OnInit } from '@angular/core';
import { Streaming } from '../_models/Streaming';
import { BsModalRef } from 'ngx-bootstrap/modal/ngx-bootstrap-modal';
import { Cliente } from '../_models/Cliente';

@Component({
  selector: 'app-conteudoModal',
  templateUrl: './conteudoModal.component.html',
  styleUrls: ['./conteudoModal.component.css']
})
export class ConteudoModalComponent implements OnInit {

  objStreaming: Streaming;
  objCliente: Cliente;
  modalRef: BsModalRef;
  qtdAlugar: number;

  constructor() { }

  ngOnInit() {
  }

  AlugarStreaming(cliente: Cliente, streamingEscolhida: Streaming)
  {


  }

}
