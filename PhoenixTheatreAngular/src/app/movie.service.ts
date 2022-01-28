import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Movie } from './mytypes';
import { Showtime } from './mytypes';
import { Tickets } from './mytypes';
import { SelectionAmounts } from './mytypes';

import { fakeMovie } from './melindas-fake-data';
import { fakeShowtime } from './melindas-fake-data';
import { fakeTickets } from './melindas-fake-data';
import { fakeTicketSelectionAmounts } from './melindas-fake-data';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': 'https://phoenixtheatre.azurewebsites.net'
    })
  };

  getTicketSelectionAmounts(): Observable<SelectionAmounts[]> {
    const amounts = of(fakeTicketSelectionAmounts);
    return amounts;
  }

   private url = "https://localhost:7291/PhoenixTheatre/movies";
   private urlTickets ="https://localhost:7291/PhoenixTheatre/ticket";
  // private urlShowings = "https://localhost:7291/PhoenixTheatre/filmShowings";
  
//  private url = "https://phoenixtheatreapi20220128091526.azurewebsites.net/PhoenixTheatre/movies";
//  private urlTickets ="https://phoenixtheatreapi20220128091526.azurewebsites.net/PhoenixTheatre/ticket";

  getMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(this.url, this.httpOptions);
  }

  getMovie(id: string): Observable<Movie> {
    const movie = fakeMovie.find(m => m.filmName === id)!;
    return of(movie);
  }

  getShowTimes(): Observable<Showtime[]> {
    const showTimes = of(fakeShowtime);
    return showTimes;
  }

  getShowTime(id: number): Observable<Showtime> {
    const showtime = fakeShowtime.find(s => s.filmShowingsId === id)!;
    return of(showtime);
  }

  getTickets(): Observable<Tickets[]> {
    return this.http.get<Tickets[]>(this.urlTickets, this.httpOptions);
  }

  constructor(private http: HttpClient) { }
}
