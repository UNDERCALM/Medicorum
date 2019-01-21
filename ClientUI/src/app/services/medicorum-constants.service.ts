import { Injectable } from '@angular/core';
import { MedicorumAPIService, MEDICORUM_API_URL } from '../services/medicorum-api.service'

export const MedicorumConstants: Array<any> = [
  { provide: MedicorumAPIService, useClass: MedicorumAPIService },
  { provide: MEDICORUM_API_URL, useValue: MEDICORUM_API_URL }
];
