import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, tap, throwError } from "rxjs";

import { IHistorial } from "./historial";

@Injectable({
  providedIn: 'root'
})

export class HistorialService {
  private idUsuario = "259289c4-6ea8-408f-b4d2-e22776ddcc58";
  private historialUrl = 'https://3enrayacodecurrencyconverter.azurewebsites.net/api/Usuarios/' + this.idUsuario + '/Historial';
  private token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibW9jaCIsImp0aSI6IjhiMTVkODlhLWU1YjUtNDM4Yi1iMTNhLWEzODU5NmNhYWZlOCIsImV4cCI6MTY5NTg5MjQ5MiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MDAwIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.xHkxQ1cqrOW8iK156IJSKRTuTQBs-vGbJYzoeAIxDyI"

  constructor(private http: HttpClient) { }

  getHistorial(): Observable<IHistorial[]> {
    let headers = new HttpHeaders().set('Authorization', `Bearer ${this.token}`);
    return this.http.get<IHistorial[]>(this.historialUrl, { headers }).pipe(
      tap(data => console.log('All', JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  deleteHistorial(): Observable<void> {
    let headers = new HttpHeaders().set('Authorization', `Bearer ${this.token}`);
    return this.http.delete<void>(this.historialUrl, { headers }).pipe(
      catchError(this.handleError)
    );
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