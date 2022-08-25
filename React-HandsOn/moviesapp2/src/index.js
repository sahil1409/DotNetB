import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

import {createStore} from 'redux';
import allReducer from './reducers'; //We dont have to add './reducers/index.js' because the wepack is automatically gonna look at the index.js
import { Provider } from 'react-redux';

const myStore = createStore(allReducer, window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());

//==========================================
// import {createStore} from 'redux';

// //STORE -> GLOBALIZED STATE (The store basically holds all the data or state for the application. It is baiscally a one big state, that we can access anywhere in all our components.)

// //ACION INCREMENT (It describes what you wanna do. So you can imagine in this one, we are going to create a super simple state called counter and it is going to be set to zero and whenever we add maybe we hit the button plus, its gonna increment by one. So an action can be called Increment, which is just a name.)
// //How does an action look? All an action is just a function that returns an object.
// const increment = () => {
//   return {
//     type: 'INCREMENT' //Basically name of acton
//   }
// }

// const decrement = () => {
//   return {
//     type: 'DECREMENT' //Basically name of acton
//   }
// }

// //REDUCER (It basically describes how your actions transform the state into the next state. So when the action is called, the reducer will check which action you did and based on the action it is gonna modify the store.)
// const counter = (state = 0, action) => {
//   switch (action.type) {
//     case 'INCREMENT':
//       return state + 1;
//     case 'DECREMENT':
//       return state - 1;
//   }
// };

// let store = createStore(counter);

// //Display it in the console
// store.subscribe(() => console.log(store.getState()));

// //DISPATCH (This is the way where we can actually execute that action. We can say dispatch this action to the reducer, so we can send that action to the reducer and the reducer is gonna check what to do and the store gets updated.)
// store.dispatch(increment());
// store.dispatch(decrement());
// store.dispatch(decrement());
//==========================================

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Provider store = {myStore}>
      <App /> {/*With the help of Provider, the whole App will have access to the store */}
    </Provider>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
