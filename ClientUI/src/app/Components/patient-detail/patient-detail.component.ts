import { Component, OnInit } from '@angular/core';
import { Patient } from 'src/app/models/patient.model';
import { MedicorumAPIService } from 'src/app/services/medicorum-api.service';
import { ActivatedRoute, Router } from '@angular/router';
import { switchMap } from 'rxjs/operators';

import { CheckboxModule, WavesModule, ButtonsModule, InputsModule, IconsModule } from 'angular-bootstrap-md'
@Component({
  selector: 'app-patient-detail',
  templateUrl: './patient-detail.component.html',
  styleUrls: ['./patient-detail.component.scss']
})
export class PatientDetailComponent implements OnInit {
  patient: Patient;
  id: number;
  constructor(public rest: MedicorumAPIService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get("id");

      this.getPatient(this.id);
    }
      
  
  getPatient(id: number) {
    this.rest.getPatient(id).subscribe((data: {}) => {
      this.patient = new Patient(data);
      console.log(this.patient);
    });
  }
}
