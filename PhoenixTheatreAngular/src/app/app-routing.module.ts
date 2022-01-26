import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieDescriptionComponent } from './movie-description/movie-description.component';
import { MoviesComponent } from './movies/movies.component';
import { ShoppingcartComponent } from './shoppingcart/shoppingcart.component';
import { MyOrderHistoryComponent } from './my-order-history/my-order-history.component';

const routes: Routes = [
  { path: '', redirectTo: '/movies', pathMatch: 'full' },
  { path: 'movies', component: MoviesComponent, pathMatch: 'full' },
  { path: 'movies/:id', component: MovieDescriptionComponent },
  { path: 'shoppingcart', component: ShoppingcartComponent },
  { path: 'my-order-history', component: MyOrderHistoryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
