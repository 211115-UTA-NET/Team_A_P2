import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Movie, Showtime, Tickets } from '../mytypes';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-showtime',
  templateUrl: './showtime.component.html',
  styleUrls: ['./showtime.component.css']
})
export class ShowtimeComponent implements OnInit {
  showTime: Showtime | undefined;
  amountSelected: number = 0;

  amountChanged (event: any) {
    this.amountSelected = event.target.value;
  }

  getTickets(): void {
    this.movieService.getTickets().subscribe(tickets => this.tickets = tickets);
  }

  getMovies(): void {
    this.movieService.getMovies().subscribe(movies => this.movies = movies);
  }
  
  movies: Movie[] = [];
  tickets: Tickets[] =[];

  constructor(private route: ActivatedRoute, private location: Location, private movieService: MovieService) { }

  ngOnInit(): void {
    console.log(this.amountSelected);
    this.getShowTime();
    this.getTickets();
    this.getMovies();
  }

  getMovie(): void {
    
  }

  getShowTime(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getShowTime(id).subscribe(showTime => this.showTime = showTime);
  }

}
