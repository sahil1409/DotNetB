import logo from './logo.svg';
import './App.css';
import Region from './Region';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          My name is <span><AppChild name="Sahil Shaikh" /></span>
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
