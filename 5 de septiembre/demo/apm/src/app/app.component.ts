import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  // templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

  template:`
    <!--
    <h1>{{saludoHijo}}</h1>
    <pm-welcome [mensaje] = 'saludo' (saludar)='onSaludar($event)'></pm-welcome>
    -->
    <pm-monedas></pm-monedas>
    <pm-conversor></pm-conversor>
  `
})
export class AppComponent {
  pageTitle = 'ProyectoAngular';
  codigoMoneda = "EUR";
  saludo = "hola mundo";
  saludoHijo="No hay saludo";

  onSaludar(saludoDesdeHijo:string){
    this.saludoHijo = saludoDesdeHijo;
  }
}
