import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { lastValueFrom } from 'rxjs';

import { TempNewCustomer } from './TempCustomer';

@Injectable({
  providedIn: 'root'
})
export class MyhttpService {
  defaultUrl = "https://phoenixtheatreapi.azurewebsites.net";
  getUser = this.defaultUrl + "/api/customer/username";

  constructor( private http: HttpClient) {}

  getUserInfo(username:string): Promise<TempNewCustomer[]>{
    const headers = new HttpHeaders()
      .set('content-type', 'text/plain')
      .set('Access-Control-Allow-Origin', 'http://localhost:4200/login')

    const params = new HttpParams()
      .set('username', username);
    return lastValueFrom(this.http.get<TempNewCustomer[]>(this.getUser, { headers, params }));

  }
}
