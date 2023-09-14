import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { IUsuario } from "./usuario";
import { BehaviorSubject,Observable } from "rxjs";
import { IRegistro } from "./registro";
@Injectable({
    providedIn: 'root'
  })
  export class UsuarioService{
    private url = "https://localhost:7200/api/persona/GetPersonasPorOrden";
    private url2 = "https://localhost:7200/api/persona";
    constructor(private http:HttpClient){}

 getMonedas(): Observable<IUsuario[]> {
    console.log('Making API call...');
    return this.http.get<IUsuario[]>(this.url);
  }

  postRegistro(registroDTO: IRegistro): Observable<null> {
    const requestData = {
      nombre: registroDTO.nombre,
      telefono: registroDTO.telefono,
      fechaNacimiento: registroDTO.fechaNacimiento,
    };
    console.log(requestData);
    return this.http.post<null>(this.url2, requestData);
  }

}
