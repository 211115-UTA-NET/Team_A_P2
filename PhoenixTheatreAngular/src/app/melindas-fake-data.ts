import { Movie } from './mytypes';

export const fakeMovie: Movie[] = [{
    filmId: 1,
    filmName: 'Faking It',
    filmRating: 'PG-13',
    genre: 'Fantasy',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
    filmDuration: 101,
    image: 'https://images.unsplash.com/photo-1534447677768-be436bb09401?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8ZmFudGFzeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60',
    showtimes: ['12:30p', '1:00p', '5:30p']
},
{
    filmId: 1,
    filmName: 'Assassin With Wings',
    filmRating: 'R',
    genre: 'Adventure',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
    filmDuration: 101,
    image: 'https://images.unsplash.com/photo-1643123237307-fbbc66a1a37d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=928&q=80',
    showtimes: ['2:30p', '3:00p', '7:30p']
},
{
    filmId: 3,
    filmName: 'Castle Without Hope',
    filmRating: 'PG-13',
    genre: 'Drama',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
    filmDuration: 120,
    image: 'https://images.unsplash.com/photo-1639485420052-dc3dfe222959?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8Y2FzbHRlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60',
    showtimes: ['3:00p', '7:30p']
}];