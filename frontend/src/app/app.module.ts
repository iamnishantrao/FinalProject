import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule,MatListModule,MatGridListModule,MatDividerModule, MatToolbarModule, MatInputModule, MatFormFieldModule,} from '@angular/material';

//Imports for Material
import {MatCardModule,MatExpansionModule} from '@angular/material';

import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { MyrepositoriesComponent } from './components/myrepositories/myrepositories.component';
import { ProfilepageComponent } from './components/profilepage/profilepage.component';
import { TrialComponent } from './components/trial/trial.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes=[
  {
    path: '', component: DashboardComponent
  },
  {
    path: 'dashboard',component: DashboardComponent
  },
  {
    path: 'profile',component: ProfilepageComponent
  },
  {
    path: 'projects',component: MyrepositoriesComponent
  }];
@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    MyrepositoriesComponent,
    ProfilepageComponent,
    TrialComponent,
    NavbarComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    MatButtonModule, 
    MatCheckboxModule,
    MatCardModule,
    MatListModule,
    MatExpansionModule,
    MatGridListModule,
    MatDividerModule,
    MatToolbarModule,
    MatInputModule,
    MatFormFieldModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
