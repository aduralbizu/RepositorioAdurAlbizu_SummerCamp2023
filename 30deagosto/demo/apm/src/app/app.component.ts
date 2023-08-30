import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  template: `
  <div><h1>{{pageTitle}}</h1>
      <pm-welcome></pm-welcome>
      <pm-products></pm-products>
      <pm-monedas></pm-monedas>
  </div>
  `
})
export class AppComponent {
  pageTitle: string = 'Acme Product Management';
}
