import { Component, OnInit } from '@angular/core';
import { StreamingService } from '../_services/streaming.service';
import { Streaming } from '../_models/Streaming';

@Component({
  selector: 'app-dashboardStreaming',
  templateUrl: './dashboardStreaming.component.html',
  styleUrls: ['./dashboardStreaming.component.css']
})
export class DashboardStreamingComponent implements OnInit {

  Streamings: Streaming[];

  constructor(
    private streamingService: StreamingService
  ) { }

  ngOnInit() {
    this.getStreamings();
  }

  getStreamings()
  {
    this.streamingService.getAllStreaming().subscribe(
      (responseStreaming: Streaming[]) =>
      {
        this.Streamings = responseStreaming;
        // this.eventosFiltrados = this.Eventos;
        console.log(responseStreaming);
      },
      error =>
      {
        console.log(error);
      }
    );
  }

}
