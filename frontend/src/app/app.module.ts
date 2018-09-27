import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule, MatCardModule, MatDialogModule, MatInputModule, MatTableModule,
  MatToolbarModule, MatMenuModule,MatIconModule, MatProgressSpinnerModule} from '@angular/material';

import { NgModule } from '@angular/core';

import { FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { RouterModule,Routes } from '@angular/router';
import { ContactusComponent } from './components/contactus/contactus.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ContactusComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule,    
    BrowserAnimationsModule,
    MatButtonModule, 
    MatCheckboxModule,
    MatButtonModule, 
    MatCardModule, 
    MatDialogModule,
    MatInputModule, 
    MatTableModule,
    MatToolbarModule, 
    MatMenuModule,
    MatIconModule,
    MatProgressSpinnerModule
  ],
  exports:[MatButtonModule, MatCardModule, MatDialogModule, MatInputModule, MatTableModule,
    MatToolbarModule, MatMenuModule,MatIconModule, MatProgressSpinnerModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
