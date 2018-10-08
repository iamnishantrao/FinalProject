import { Component } from '@angular/core';
import '../../node_modules/bootstrap/dist/css/bootstrap.min.css'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: [
    './app.component.css',
    '../../node_modules/bootstrap/dist/css/bootstrap.min.css'
  ]
})
export class AppComponent {
  flagLogin = true;
  flagValueChanged(e)
  {
    this.flagLogin = e;
  }
}
