export interface Movie {
    filmId: number,
    filmName: string,
    filmRating: string,
    genre: string,
    filmDescription: string,
    filmDuration: number,
    image: string,
}

export interface Showtime {
    filmShowingsId: number,
    theatreId: number,
    filmId: number,
    showDate: Date,
    showTime: string,
    ticketsAvailable: number,
};