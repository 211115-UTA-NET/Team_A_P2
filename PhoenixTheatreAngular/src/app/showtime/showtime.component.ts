import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Showtime } from '../mytypes';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-showtime',
  templateUrl: './showtime.component.html',
  styleUrls: ['./showtime.component.css']
})
export class ShowtimeComponent implements OnInit {
  showTime: Showtime | undefined;

  constructor(private route: ActivatedRoute, private location: Location, private movieService: MovieService) { }

  ngOnInit(): void {
    // this.getMovie();
    this.getShowTime();
  }

  // getMovie(): void {
  //   const id = String(this.route.snapshot.paramMap.get('id'));
  //   this.movieService.getMovie(id).subscribe(movie => this.movie= movie);
  // }

  getShowTime(): void {
    const id = String(this.route.snapshot.paramMap.get('id'));
    this.movieService.getShowTime(id).subscribe(showTime => this.showTime = showTime);
  }

}
