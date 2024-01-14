import './App.scss';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Routes, Route } from 'react-router-dom'
import Layout from './components/Layout';

function App() {

  return (
      <>
          <Routes>
              <Route path="/" element={<Layout />} />
          </Routes>  
      </>
  )
}

export default App
