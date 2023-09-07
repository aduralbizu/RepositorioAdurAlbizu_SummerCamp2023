import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ConversorComponent } from './conversor/conversor.component';
import { WelcomeComponent } from './home/welcome.component';
import { MonedaListComponent } from './monedas/moneda-list.component';
import { ProductListComponent } from './products/product-list.component';
import { PaginaPrincipalComponent } from './paginaPrincipal/paginaPrincipal.component';
import { HttpClientModule, HttpHeaders } from '@angular/common/http';
import { HistorialListComponent } from './historial/historial-list.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,  // Inyeccion de Dependencias del Program.cs
    ProductListComponent,
    MonedaListComponent,
    ConversorComponent,
    HistorialListComponent,
    PaginaPrincipalComponent
  ],
  imports: [
    BrowserModule, FormsModule, HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
