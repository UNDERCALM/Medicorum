export class Patient {
  id: number;
  firstName: string;
  lastName: string;
  gender: string;
  driverLicenceNumber: string;
  socialSecurityNumber: string;
  birthDate: Date;

  constructor(obj?: any) {
    this.id = obj && obj.id || null;
    this.firstName = obj && obj.firstName || null;
    this.lastName = obj && obj.lastName || null;
    this.gender = obj && obj.gender || null;
    this.driverLicenceNumber = obj && obj.driverLicenceNumber || null;
    this.socialSecurityNumber = obj && obj.socialSecurityNumber || null;
    this.birthDate = obj && obj.birthDate || null;
  }
}
export class PatientModel {
  createEnabled: boolean;

  patients: Patient[];
  constructor(obj?: any) {
    this.createEnabled = obj && obj.createEnabled || null;
    this.patients = obj && obj.patients as Patient[] || null;
  }
}
