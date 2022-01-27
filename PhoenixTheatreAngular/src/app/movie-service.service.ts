import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Movie, Showtime } from './mytypes';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieServiceService {
  private moviesUrl = environment.serverUrl;

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json'})
  };

  constructor(private http: HttpClient) { }

  // GET movie showtimes
  getShowtimes(movie: Movie): Observable<Showtime[]> {
    return this.http.get<Showtime[]>(this.moviesUrl)
  }

  // This is going to be a proof of concept just to make sure we
  // we can get communication going between the DB and here
  // can get rid of it or change it to fit our needs if it does work
}
