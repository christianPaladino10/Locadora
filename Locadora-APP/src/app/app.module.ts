import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { StreamingComponent } from './streaming/streaming.component';
import { ConteudoModalComponent } from './conteudoModal/conteudoModal.component';
import { ClienteComponent } from './cliente/cliente.component';
import { DashboardStreamingComponent } from './dashboardStreaming/dashboardStreaming.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      StreamingComponent,
      ConteudoModalComponent,
      ClienteComponent,
      DashboardStreamingComponent
   ],
   imports: [
      BrowserModule,
      ModalModule.forRoot(),
      AppRoutingModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
