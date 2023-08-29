import { Component } from "@angular/core";

@Component({
    selector: 'pm-monedas',
    templateUrl: './monedas-list.component.html'
})

export class MonedasComponent {
    pageTitle: string = "Monedas"
    monedas: any[] = [
        {
          "nombre": "euro",
          "test": "EUR",
        
        },
        {
          "nombre": "dolar",
          "test": "USD",
        }

    ]
}