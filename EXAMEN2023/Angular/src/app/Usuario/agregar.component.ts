import { Component,OnInit } from '@angular/core';
import { UsuarioService } from './usuarios.service';
import { FormBuilder, FormGroup, Validators, FormControl, AbstractControl, ValidatorFn } from '@angular/forms';
import { IUsuario } from './usuario'; // Asegúrate de que la ruta sea la correcta
import { Subscription } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';
import { IRegistro } from './registro';

@Component({
  selector: 'app-agregar',
  templateUrl: './usuario.agregar.html',
  styleUrls: ['./agregar.usuario.css']
})
export class AgregarComponent  {
    formulario: FormGroup;
    sub!: Subscription;
    Nombre : string = "";
    edad: string ="";
    telefono : string = "";



    constructor( private usuarioService: UsuarioService, public fb: FormBuilder, public router: Router){
        this.formulario = this.fb.group({
          Nombre: ['', [Validators.required]],
          telefono: ['', [Validators.required]],
          fechaNacimiento: ['', [Validators.required]],
        });
      }

      hacerRegistro(registroDTO: IRegistro): void {
        this.usuarioService.postRegistro(registroDTO).subscribe(
            (respuesta) => {
              // Manejar la respuesta exitosa aquí
              console.log('Registro exitoso', respuesta);
              // Puedes realizar acciones adicionales si es necesario
            },
            (error) => {
              // Manejar errores aquí
              console.error('Error al registrar usuario', error);
              // Puedes mostrar un mensaje de error al usuario o realizar acciones adicionales
            }
          );
      } 
      
      rellenarRegistro(formulario : FormGroup): void {
        const registroDTO: IRegistro = {
          nombre: formulario.value.Nombre,
          fechaNacimiento: formulario.value.fechaNacimiento,
          telefono: formulario.value.telefono,

        };
        console.log("estoy pidiendo el registro");
        this.hacerRegistro(registroDTO);
      }
 
}