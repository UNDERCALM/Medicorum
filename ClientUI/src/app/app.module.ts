import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http';
import { MedicorumConstants } from "./services/medicorum-constants.service";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PatientListComponent } from './Components/patient-list/patient-list.component';
import { ClinicalHistoryComponent } from './Components/clinical-history/clinical-history.component';
import { PatientDetailComponent } from './Components/patient-detail/patient-detail.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap/modal';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { HomeComponent } from './Components/home/home.component';


const appRoutes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
    data: { title: 'Patient List' }
  },
  {
    path: 'patients',
    component: PatientListComponent,
    data: { title: 'Patient List' }
  },
  {
    path: 'patient/:id',
    component: PatientDetailComponent,
    data: { title: 'Patient List' }
  },
  {
    path: 'patient-add',
    component: PatientDetailComponent,
    data: { title: 'Patient Add' }
  },
  {
    path: 'patient-edit/:id',
    component: PatientDetailComponent,
    data: { title: 'Patient Edit' }
  },
  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  }
];
@NgModule({

  declarations: [
    AppComponent,

    PatientListComponent,
    PatientDetailComponent,
    ClinicalHistoryComponent,
    NavBarComponent,
    HomeComponent
  ],
  imports: [
    RouterModule.forRoot(appRoutes),
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot()
  ],
  providers: [MedicorumConstants],
  bootstrap: [AppComponent]
})
export class AppModule { }
