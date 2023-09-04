import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ConversorComponent } from './conversor/conversor.component';
import { WelcomeComponent } from './home/welcome.component';
import { MonedaListComponent } from './monedas/moneda-list.component';
import { ProductListComponent } from './products/product-list.component';


@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,  // Inyeccion de Dependencias del Program.cs
    ProductListComponent,
    MonedaListComponent,
    ConversorComponent 
  ],
  imports: [
    BrowserModule, 
    FormsModule, 
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
