import logo from './logo.svg';
import './App.css';
import Region from './Region';
import { Welcome1 } from './Data';
import { Welcome2 } from './Data';
import Data from './Data';
import { Welcome4 } from './Data';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          My name is <span><AppChild name="Sahil Shaikh" /></span>
          <Welcome1 name = {"Sahil"} />
          <Welcome2 name = {"Harsh"}/>
          <Data name1 = {"Meet"} />
          <Welcome4 name2={"Shubham"} />
        </p>
        <Region />
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
