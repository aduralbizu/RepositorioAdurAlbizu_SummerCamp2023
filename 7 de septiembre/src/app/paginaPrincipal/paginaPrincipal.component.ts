import { Component } from '@angular/core';

@Component({
  selector: 'pm-paginaprincipal',
  // templateUrl: './app.component.html',
  styleUrls: [],

  templateUrl:'./paginaPrincipal.component.html'
})
export class PaginaPrincipalComponent {
  saludo = "hola mundo";
  saludoHijo="No se ha emitido el evento";
  shouldupdate = false;

  onAvisar(eventoConversion:string){
    this.saludoHijo = eventoConversion;
    this.shouldupdate = true;
  }

  
}