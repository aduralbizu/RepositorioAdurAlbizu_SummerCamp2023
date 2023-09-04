import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IMoneda } from './moneda';
import { MonedaService } from './monedas.service';

@Component({
  selector: 'pm-monedas',
  templateUrl: './moneda-list.component.html'
})
export class MonedaListComponent implements OnInit, OnDestroy{
  pageTitle: string = 'Lista de Monedas';
  showImage: boolean = false;
  listFilter: string = "";
  errorMessage: string = '';
  sub!: Subscription;

  toggleImage(): void {
    this.showImage = !this.showImage;
  }

  filter() {
    let filterBy = this.listFilter.toLocaleLowerCase();
    this.monedasFiltered = this.monedas.filter((moneda: any) => moneda.nombre.toLocaleLowerCase().includes(filterBy));
  }
    
  monedasFiltered: IMoneda[] = [];
  monedas: IMoneda[] = [];

  constructor(private monedaService: MonedaService) { }

  ngOnInit(): void { //Ngonit => . It's called when a component is created and is the recommended place to perform tasks that need to be done before the component's view is displayed and when you want to set up initial data or configurations.
    this.sub = this.monedaService.getProducts().subscribe({
      next: monedasobtenida => {
        this.monedas = monedasobtenida;
        this.monedasFiltered = this.monedas;
      },
      error: err => this.errorMessage = err
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

}
