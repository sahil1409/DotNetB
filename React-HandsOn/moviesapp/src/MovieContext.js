import React, {useState, createContext} from "react";

export const MovieContext = createContext();

export const MovieProvider = props => {
    
    const [movies, setMovies] = useState ([
        {
            name: 'Harry Potter',
            price: '$10',
            id: 23124
        },
        {
            name: 'Game of Thrones',
            price: '$10',
            id: 2566124
        },
        {
            name: 'Inception',
            price: '$10',
            id: 23524
        }
    ]);

    return (
        <MovieContext.Provider value = {[movies, setMovies]}>
            {/* MovieProvider's job is to hold some info and then pass it down to all the differen components we want to. */}
            {props.children}
        </MovieContext.Provider>
    );
}