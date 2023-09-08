import { EventEmitter, Input, Output, SimpleChanges, OnChanges  } from "@angular/core";
import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { IHistorial } from "./historial";
import { HistorialService } from "./historial.service";

@Component({
  selector: 'pm-historial',
  templateUrl: './historial-list.component.html'
})
export class HistorialListComponent {
  pageTitle: string = 'Historial';
  errorMessage: string = 'Error al leer el historial';
  sub!: Subscription;
  historiales: IHistorial[] = [];

  constructor(private historialService: HistorialService) { }

  ngOnInit(): void {
    this.updateHistorial();
  }

  updateHistorial():void{
    this.sub = this.historialService.getHistorial().subscribe({
      next: historiales => {
        this.historiales = historiales;
      },
      error: err => this.errorMessage = err
    });
    
  }

  borrarHistorial(): void {
    this.historiales = [];
    this.historialService.deleteHistorial().subscribe({
      next: () => {
        console.log('Historial deleted successfully.');
      },
      error: (err) => {
        console.error('Error deleting historial:', err);
      },
    });
    
  }

  
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}
