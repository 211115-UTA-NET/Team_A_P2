import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Customer } from './mytypes';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private customerUrl = 'localhost:4200/PhoenixTheatre/customer';
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'text/plain',
      'Access-Control-Allow-Origin': 'https://phoenixtheatre.azurewebsites.net'
    })
  };
  constructor(private http: HttpClient) { }

  getCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>(this.customerUrl, this.httpOptions)
  };

  getCustomerByName(firstName: string, lastName: string):
   Observable<Customer> {
    return this.http.get<Customer>(this.customerUrl)
  };

  // guess this is the proof of concept but still
}
