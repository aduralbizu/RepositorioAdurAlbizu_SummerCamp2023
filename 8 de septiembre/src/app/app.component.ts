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
    
    <nav class="navbar navbar-expand navbar-light bg-light">
      <img class="ms-2" src="../assets/TresEnRayaCode-small.jpg" alt="TresEnRayaCode">
      <a class="navbar-brand ms-2">3enRayaCode</a>
      <ul class="nav nav-pills">
        <li><a routerLink="/home" class="nav-link" ng-reflect-router-link="/home" href="/home">Home</a></li>
        <li><a routerlink="/conversor" class="nav-link" ng-reflect-router-link="/conversor" href="/conversor">Conversor</a></li>
        <li><a routerlink="/monedas" class="nav-link" ng-reflect-router-link="/monedas" href="/monedas">Lista Monedas</a></li>
      </ul>
    </nav>
    <router-outlet></router-outlet>
    <!-- <pm-conversor></pm-conversor> -->
    <!-- <pm-historial></pm-historial> -->
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
