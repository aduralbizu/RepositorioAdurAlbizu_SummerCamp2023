import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  // templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

  template:`
   <!--  <h1>{{saludoHijo}}</h1>
    <pm-welcome [mensaje] = 'saludo' (saludar)='onSaludar($event)'></pm-welcome>-->
    <pm-paginaprincipal></pm-paginaprincipal>
    <!-- <pm-monedas></pm-monedas> -->
  `
})
export class AppComponent {
  pageTitle = '3enRayaCurrencyConverter';
  codigoMoneda = "EUR";
  saludo = "hola mundo";
  saludoHijo="No hay saludo";

  onSaludar(saludoDesdeHijo:string){
    this.saludoHijo = saludoDesdeHijo;
  }
}
