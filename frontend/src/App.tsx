import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import BowlerList from './bowlers/BowlerList';
import Heading from './Heading';

function App() {
  return (
    <>
      <Heading />
      <BowlerList />
    </>
  );
}

export default App;
