import { Component, OnDestroy, OnInit } from "@angular/core";
import { UsuarioService } from "./usuarios.service";
import { IUsuario } from "./usuario";
import { Subscription } from 'rxjs';
@Component({
    selector: 'pm-usuario',
    templateUrl: './usuario.component.html',
    styleUrls: ['./usuario.css']
  })
  export class UsuarioComponent implements OnInit, OnDestroy {
    usuarios: IUsuario[] = [];
    sub!: Subscription;

    constructor(private usuarioService: UsuarioService) { }
 ngOnInit() {
    
    this.usuarioService.getMonedas().subscribe(data => {
        this.usuarios = data; // Cargar la lista de usuarios cuando se inicie el componente
      });
    }

    ngOnDestroy(): void {
        if (this.sub) {
          this.sub.unsubscribe();
        }
      }
  }







  