import { HttpClient, HttpErrorResponse } from '@angular/common/http'; 
import { Observable, catchError, tap, throwError } from 'rxjs';
import { Injectable } from '@angular/core';

import { IMoneda } from './moneda';

@Injectable({ 
    providedIn: 'root'
})

export class MonedaService {
    private monedaUrl = 'https://localhost:7055/api/Monedas'; //Temporal

    constructor(private http: HttpClient) { } 

    getProducts(): Observable<IMoneda[]> {
     return this.http.get<IMoneda[]>(this.monedaUrl).pipe(
        tap(data=>console.log('All', JSON.stringify(data))),
        catchError(this.handleError)
     )
    }

    private handleError(err: HttpErrorResponse) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
          // A client-side or network error occurred. Handle it accordingly.
          errorMessage = `An error occurred: ${err.error.message}`;
        } else {
          // The backend returned an unsuccessful response code.
          // The response body may contain clues as to what went wrong,
          errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return throwError(() => errorMessage);
      }
}
