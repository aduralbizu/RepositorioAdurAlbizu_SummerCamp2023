import { Component,  AfterViewInit, ViewChild } from '@angular/core';
import { HistorialListComponent } from '../historial/historial-list.component';

@Component({
  selector: 'pm-paginaprincipal',
  // templateUrl: './app.component.html',
  styleUrls: [],

  templateUrl:'./paginaPrincipal.component.html'
})
export class PaginaPrincipalComponent {
  @ViewChild(HistorialListComponent)

  private historialComponent!: HistorialListComponent;
  
  gestionEventoConversion(){
    this.historialComponent.updateHistorial();
  }


}