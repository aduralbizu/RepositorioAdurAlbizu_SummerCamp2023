import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { registerLocaleData } from '@angular/common';
import localeEs from '@angular/common/locales/es';
registerLocaleData(localeEs);

import { AppComponent } from './app.component';
import { ConversorComponent } from './conversor/conversor.component';
import { WelcomeComponent } from './home/welcome.component';
import { MonedaListComponent } from './monedas/moneda-list.component';
import { ProductListComponent } from './products/product-list.component';
import { PaginaPrincipalComponent } from './paginaPrincipal/paginaPrincipal.component';
import { HttpClientModule, HttpHeaders } from '@angular/common/http';
import { HistorialListComponent } from './historial/historial-list.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,  // Inyeccion de Dependencias del Program.cs
    ProductListComponent,
    MonedaListComponent,
    ConversorComponent,
    HistorialListComponent,
    HomeComponent, 
    PaginaPrincipalComponent
  ],
  imports: [
    BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot([
      { path: 'home', component: HomeComponent },
      { path: 'monedas', component: MonedaListComponent },
      { path: 'conversor', component: PaginaPrincipalComponent },
      {
        path: ''
        , redirectTo: 'conversor', pathMatch: 'full'
      },
      {
        path: '**'
        , redirectTo: 'conversor', pathMatch: 'full'
      }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent], // Changed [AppComponent]
})
export class AppModule { }
