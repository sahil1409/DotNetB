import React, { useContext } from "react";
import './Nav.css';
import { MovieContext } from "./MovieContext";

const Nav = () => {

    const [movies, setMovies] = useContext(MovieContext);

    return (
        
            <ul>
                <li class = "col"><b><a href="#name">Sahil Shaikh</a></b></li>
                <li class = "col"><a href="#list">List of Movies: {movies.length}</a></li>
            </ul>
        
    );
}

export default Nav;