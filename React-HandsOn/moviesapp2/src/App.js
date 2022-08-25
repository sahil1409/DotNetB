import React from "react";
import {useSelector, useDispatch} from 'react-redux'; //useSelector to access the counter
import {increment, decrement} from './actions'


function App() {
  const counter = useSelector(state => state.counter);
  const isLogged = useSelector(state => state.isLogged);
  const dispatch = useDispatch();
  
  return (
    <div className="App">
      <h1>Counter: {counter}</h1>
      <button onClick={() => dispatch(increment())}>+</button> {/*Create an action, and when we click it will dispatch */}
      <button onClick={() => dispatch(decrement())}>-</button>
      {isLogged ? <h3>Show only is Logged-in</h3> : ""} 
    </div>
  );
}

export default App;
