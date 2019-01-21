/**
* MedicorumAPI Service connects to the Medicorum API
* 
*/
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse} from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';
import { PatientModel } from "../models/patient.model"
export const MEDICORUM_API_URL = "https://localhost:44367/api/";
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};
@Injectable({
  providedIn: 'root'
})
export class MedicorumAPIService {

  constructor(private http: HttpClient, @Inject(MEDICORUM_API_URL) private apiUrl: string) { }
  private extractData(res: Response) {
    let body = res;
    return body || {};
  }
  getCinicalHistory(): Observable<any> {
    const queryUrl = `${this.apiUrl} + 'clinicalhistory'`;

    return this.http.get(queryUrl).pipe(map(this.extractData));
  }

  getPatients(): Observable<any> {
    const queryUrl = `${this.apiUrl}patients`;
    
    return this.http.get( queryUrl ).pipe( map(this.extractData) );
  }
  getPatient(id: number): Observable<any> {

    const queryUrl = `${this.apiUrl}patients/${id}`;
    return this.http.get(queryUrl).pipe(map(this.extractData));
  }
  addPatient(patient: PatientModel) {
    const queryUrl = `${this.apiUrl}patients`;
    console.log(patient);
    return this.http.post<any>(queryUrl, JSON.stringify(patient), httpOptions).pipe(
      tap((patient) => console.log(`added product w/ id=${patient.id}`)),
      catchError(this.handleError<any>('addPatient'))
    );

  }
  updatePatient(patient: PatientModel) {

    const queryUrl = `${this.apiUrl}patients`;
    return this.http.post<any>(queryUrl , JSON.stringify(patient), httpOptions).pipe(
      tap((patient) => console.log(`updated product w/ id=${patient.id}`)),
      catchError(this.handleError<any>('updatePatient'))
    );
  }
  deletePatient(id: number) {
    const queryUrl = `${this.apiUrl}'patients/'${id}`;
    return this.http.delete<any>(queryUrl + id, httpOptions).pipe(
      tap(_ => console.log(`deleted product id=${id}`)),
      catchError(this.handleError<any>('deletePatient'))
    );
  }
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  
}
