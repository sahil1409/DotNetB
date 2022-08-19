import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Hello World! My name is Sahil.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
        <p><AppChild name="Sahil Shaikh" /></p>
      </header>
    </div>
  );
}

function AppChild(props){
  return <span>
      Owner: {props.name}
    </span>
}
// ReactDOM.render(<App />, document.getElementById('app'));

export default App;
