import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { MedicorumAPIService } from '../../services/medicorum-api.service'
import { ActivatedRoute, Router } from '@angular/router';
import { PatientModel, Patient } from 'src/app/models/patient.model';
@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.scss']
})
export class PatientListComponent implements OnInit {
  @Output() canSearch: EventEmitter<boolean> = new EventEmitter();
  patientModel: PatientModel;
  patient: Patient;
  constructor(public rest: MedicorumAPIService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.getPatients();
    this.canSearch.emit(true);
  }
  getPatients() {
    
    this.rest.getPatients().subscribe((data: {}) => {
      this.patientModel = new PatientModel(data);
    });
  }
  goToPatient(id: any) {
    
    this.router.navigateByUrl('/patient/' + id);
    console.log(id);
  }
}
