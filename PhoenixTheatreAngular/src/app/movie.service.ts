import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

import { Movie } from './mytypes';
import { Showtime } from './mytypes';
import { fakeMovie } from './melindas-fake-data';
import { fakeShowtime } from './melindas-fake-data';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  getMovies(): Observable<Movie[]> {
    const movies = of(fakeMovie);
    return movies;
  }

  getShowTimes(): Observable<Showtime[]> {
    const showTimes = of(fakeShowtime);
    return showTimes;
  }

  constructor() { }
}
