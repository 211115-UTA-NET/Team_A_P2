import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

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

  getMovies(): Observable<Movie[]> {
    const movies = of(fakeMovie);
    return movies;
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
    const tickets = of(fakeTickets);
    return tickets;
  }

  constructor() { }
}
