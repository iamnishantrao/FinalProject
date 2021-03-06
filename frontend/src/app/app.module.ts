import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ProfileService } from './services/profile.service'
import { IssuesService } from './services/issues.service'

import { JwtModule } from '@auth0/angular-jwt';

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
import { PullComponent } from './components/pull/pull.component';
import { PulllistComponent } from './components/pulllist/pulllist.component';
import { PullrepolistComponent } from './components/pullrepolist/pullrepolist.component';
import { SignupComponent } from './components/signup/signup.component';
import { IssuelistComponent } from './components/issuelist/issuelist.component';
import { IssueComponent } from './components/issue/issue.component';
import { ProjectlistComponent } from './components/projectlist/projectlist.component'

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http';
import { SearchComponent } from './components/search/search.component';

import { NgxPaginationModule } from 'ngx-pagination';
import { StarredreposComponent } from './components/starredrepos/starredrepos.component';

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
  },
  {
    path: 'pullrepolist', component: PullrepolistComponent
  },
  {
    path: 'pulllist/:name', component: PulllistComponent
  },
  {
    path: 'pull/:id/:number/:title/:user_login/:state/:assigne/:created_at/:cloased_at/:body', component: PullComponent
  },
  {
    path: 'issuelist/:name', component: IssuelistComponent
  },
  {
    path: 'issue/:id/:number/:title/:user_login/:state/:assigne/:created_at/:cloased_at/:body', component: IssueComponent
  },
  {
    path: 'projectlist', component: ProjectlistComponent
  },
  {
    path: 'search/:keyword/:flag', component: SearchComponent
  },
  {
    path: 'stars', component: StarredreposComponent
  },
  {
    path: 'contactus', component: ContactusComponent
  }
];

export function tokenGetter() {
  return localStorage.getItem('access_token');
}
@NgModule({
  declarations: [
    PullrepolistComponent,
    PulllistComponent,
    PullComponent,
    AppComponent,
    DashboardComponent,
    MyrepositoriesComponent,
    ProfilepageComponent,
    TrialComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    ContactusComponent,
    SignupComponent,
    IssuelistComponent,
    IssueComponent,
    ProjectlistComponent,
    SearchComponent,
    StarredreposComponent
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
    RouterModule.forRoot(routes),
    HttpClientModule,
    ReactiveFormsModule,
    NgxPaginationModule
  ],
  exports: [
    RouterModule
  ],
  providers: [
    ProfileService,
    IssuesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
