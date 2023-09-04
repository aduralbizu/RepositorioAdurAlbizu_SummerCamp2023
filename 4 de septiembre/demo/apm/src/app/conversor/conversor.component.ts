import { Component } from "@angular/core";

@Component({
    selector: "pm-conversor",
    templateUrl: "./conversor.component.html"
})

export class ConversorComponent {
    pageTitle: string = 'Conversor de Monedas';
    monedaOrigenSelect: string = "";
    monedaDestinoSelect: string = "";
    importe: any;
    resultado: number = 1;
    conversionDone: boolean = false;
    monedas: any[] = [
        {
            "Id": 1,
            "Name": "Euro",
            "Code": "EUR",
            "Symbol": "€",
            "Descripcion": "EUR € - Euro",
            "FactorConversion": 1.09,
            "imageUrl": "http://s.exchangerate.net/small_flags/small_european_union_flag.gif"
        },
        {
            "Id": 2,
            "Name": "Dólar estadounidense",
            "Code": "USD",
            "Symbol": "$",
            "Descripcion": "USD $ - Dólar estadounidense",
            "FactorConversion": 1,
            "imageUrl": "http://s.exchangerate.net/small_flags/small_united_states_flag.gif"
        },
        {
            "Id": 3,
            "Name": "Libra esterlina",
            "Code": "GBP",
            "Symbol": "£",
            "Descripcion": "GBP £ - Libra esterlina",
            "FactorConversion": 1.27,
            "imageUrl": "http://s.exchangerate.net/small_flags/small_united_kingdom_flag.gif"
        }
    ];

    hacerConversion(): void {
        let regex = /^\d+(\.\d+)?$/;

        if (!regex.test(this.importe)) {
            alert("Introduce un valor valido p.ej: 32.56");
            return;
        }

        let monedaOrigen = this.monedas.find(m => m.Code === this.monedaOrigenSelect)
        let monedaDestino = this.monedas.find(m => m.Code === this.monedaDestinoSelect)
        let factor = monedaOrigen.FactorConversion / monedaDestino.FactorConversion
        this.resultado = Number((Math.round(this.importe * factor * 100) / 100).toFixed(2).toLocaleString());
        this.conversionDone = true
    }

    resetearConversion(): void {
        this.conversionDone = false
    }
}