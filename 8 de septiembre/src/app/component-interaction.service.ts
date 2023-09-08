import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { IHistorial } from './historial/historial';

@Injectable()
export class ComponentInteractionService {

    // Observable string sources
    private historialUpdatedSource = new Subject<IHistorial[]>();

    // Observable string streams
    historialUpdated$ = this.historialUpdatedSource.asObservable();

    // Service message commands
    updateHistorial(historiales: IHistorial[]) {
        this.historialUpdatedSource.next(historiales);
    }
}