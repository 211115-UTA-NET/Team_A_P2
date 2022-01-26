import { Component, OnInit } from '@angular/core';
import { Movie, Showtime } from '../mytypes';
import { fakeMovie, fakeShowtime } from '../melindas-fake-data';
@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  movies: Movie[] = [];
  showtimes: Showtime[] = [];

  monthToday: Date = new Date();
  yearToday: Date = new Date();

  date: Date = new Date();
  weekdays: Array<number> =
  [
    this.date.getDate(),
    this.date.getDate()+1,
    this.date.getDate()+2,
    this.date.getDate()+3,
    this.date.getDate()+4
  ];

  month: string = (this.monthToday.getMonth()+1).toString();
  year: string = this.yearToday.getFullYear().toString();

  constructor() { }

  ngOnInit(): void {
    this.movies = fakeMovie;
    this.showtimes = fakeShowtime;
    this.weekdays = this.weekdays;
    this.month = this.month;
    this.year = this.year;
  }
}
