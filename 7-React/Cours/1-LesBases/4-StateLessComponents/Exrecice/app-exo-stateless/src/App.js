import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import HeaderComponent from './components/HeaderComponent/HeaderComponent';
import NavBarComponent from './components/NavBarComponent/NavBarComponent';


function App() {
  return (
    <div className="App">
          <HeaderComponent />
          <NavBarComponent  />
    </div>
  );
}

export default App;
