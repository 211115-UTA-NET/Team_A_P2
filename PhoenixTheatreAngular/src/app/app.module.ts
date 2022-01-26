import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopBarComponent } from './top-bar/top-bar.component';
import { LoginScreenComponent } from './login-screen/login-screen.component';
import { MoviesComponent } from './movies/movies.component';

import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MovieDescriptionComponent } from './movie-description/movie-description.component';
import { ShoppingcartComponent } from './shoppingcart/shoppingcart.component';
import { MyOrderHistoryComponent } from './my-order-history/my-order-history.component';

@NgModule({
  declarations: [
    AppComponent,
    TopBarComponent,
    LoginScreenComponent,
    MoviesComponent,
    MovieDescriptionComponent,
    ShoppingcartComponent,
    MyOrderHistoryComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    MatDatepickerModule,
    MatInputModule,
    MatNativeDateModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
