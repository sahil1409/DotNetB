import counterReducer from "./counter";
import loggedReducer from "./isLogged";
import { combineReducers } from 'redux';

const allReducers = combineReducers({
    counter : counterReducer, //Can also just define as -> counterReducer (This basically means counterReducer : counterReducer)
    isLogged : loggedReducer 
});

export default allReducers;
