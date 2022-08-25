import React, { useState, useContext } from "react";
import Movie from "./Movie";
import { MovieContext } from "./MovieContext";

const MovieList = () => {
    
const [movies, setMovies] = useContext(MovieContext);

    //Array of Objects
    // const [movies, setMovies] = useState ([
    //     {
    //         name: 'Harry Potter',
    //         price: '$10',
    //         id: 23124
    //     },
    //     {
    //         name: 'Game of Thrones',
    //         price: '$10',
    //         id: 2566124
    //     },
    //     {
    //         name: 'Inception',
    //         price: '$10',
    //         id: 23524
    //     }
    // ]);

    return (
        <div>
            {movies.map(movie => (
                // <li>{movie.name}</li>
                <Movie name = {movie.name} price = {movie.price} key = {movie.id}/>
            ))}
        </div>
    );
}

export default MovieList;