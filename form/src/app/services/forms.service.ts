import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RegistrationForm } from '../models/registrationForm';
import { FormOption } from '../models/formOption';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root',
})
export class FormsService {
  private apiUrl = 'https://localhost:44356/api/Forms';

  constructor(private http: HttpClient) {}

  getForms(): Observable<RegistrationForm[]> {
    return this.http.get<RegistrationForm[]>(this.apiUrl);
  }

  getOptions(id: string): Observable<FormOption[]> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<FormOption[]>(url);
  }

  putOptions(updatedOption: FormOption): Observable<FormOption> {
    return this.http.put<FormOption>(this.apiUrl, updatedOption);
  }
}
