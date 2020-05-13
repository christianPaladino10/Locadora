import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StreamingComponent } from './streaming/streaming.component';
import { ClienteComponent } from './cliente/cliente.component';
import { DashboardStreamingComponent } from './dashboardStreaming/dashboardStreaming.component';


const routes: Routes = [
  { path: 'streaming', component: StreamingComponent},
  { path: 'cliente', component: ClienteComponent},
  { path: 'dashboardStreaming', component: DashboardStreamingComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
