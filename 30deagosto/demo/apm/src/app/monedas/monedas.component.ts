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
          "imageURL": "https://upload.wikimedia.org/wikipedia/commons/5/56/Reverso_1_euro.jpg"
        
        },
        {
          "nombre": "dolar",
          "test": "USD",
          "imageURL": "https://www.usmint.gov/wordpress/wp-content/uploads/2021/03/2021-american-innovation-one-dollar-coin-uncirculated-obverse-768x768.jpg"
        }

    ]
  
    showImage = false;

    toggleImage(): void {
      this.showImage = !this.showImage;
    }
}