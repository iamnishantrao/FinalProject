import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: [
    './navbar.component.css',
'../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
  ]
})
export class NavbarComponent implements OnInit {
  @Input() flagLogin: boolean;
  @Output() flagValueChanged = new EventEmitter<boolean>();
  searchFlag: boolean;
  keyword: string;

  constructor() { }

  ngOnInit() {
  }

  logmeout()
  {
    this.flagLogin = !this.flagLogin;
    this.flagValueChanged.emit(this.flagLogin);
  }
}
