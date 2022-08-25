import './App.css';
import Region from './Region';
import { Welcome1 } from './Data';
import { Welcome2 } from './Data';
import Data from './Data';
import { Welcome4 } from './Data';

import {School1} from './School'; 
import {School2} from './School'; 

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <p>
          My name is <span><AppChild name="Sahil Shaikh" /></span><br></br><br></br>
          <Welcome1 name = {"Sahil"} />
          <Welcome2 name = {"Harsh"}/>
          <Data name1 = {"Meet"} />
          <Welcome4 name2={"Shubham"} />
        </p>
        <Region />
        ================================
        <School1 />
        <School2 std = {"10-C"} />
      </header>
    </div>
  );
}

function AppChild(props){
  return <span>
      {props.name}
    </span>
}

export default App;
