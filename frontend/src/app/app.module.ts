import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatButtonModule, MatCheckboxModule, MatCardModule, MatDialogModule, MatInputModule, MatTableModule,
  MatToolbarModule, MatExpansionModule,
  MatGridListModule,
  MatDividerModule, MatFormFieldModule, MatMenuModule, MatIconModule, MatProgressSpinnerModule, MatListModule
} from '@angular/material';

import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { MyrepositoriesComponent } from './components/myrepositories/myrepositories.component';
import { ProfilepageComponent } from './components/profilepage/profilepage.component';
import { TrialComponent } from './components/trial/trial.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RouterModule, Routes } from '@angular/router';
import { FooterComponent } from './components/footer/footer.component';
import { LoginComponent } from './components/login/login.component';
import { ContactusComponent } from './components/contactus/contactus.component';
import { FormsModule } from '../../node_modules/@angular/forms';

const routes: Routes = [
  {
    path: '', component: DashboardComponent
  },
  {
    path: 'dashboard', component: DashboardComponent
  },
  {
    path: 'profile', component: ProfilepageComponent
  },
  {
    path: 'projects', component: MyrepositoriesComponent
  }];
@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    MyrepositoriesComponent,
    ProfilepageComponent,
    TrialComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    ContactusComponent
  ],
  imports: [
    FormsModule,
    BrowserAnimationsModule,
    BrowserModule,
    MatButtonModule,
    MatCheckboxModule,
    MatCardModule,
    MatDialogModule,
    MatInputModule,
    MatTableModule,
    MatToolbarModule,
    MatExpansionModule,
    MatGridListModule,
    MatDividerModule,
    MatFormFieldModule,
    MatMenuModule,
    MatIconModule,
    MatProgressSpinnerModule,
    MatListModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
