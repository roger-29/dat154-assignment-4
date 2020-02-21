import React from 'react';
import { Route, Switch, Redirect } from 'react-router';
import Login from './Login';
import Navbar from './Navbar';
import Footer from './Footer';
import Home from './Home';

const App = () => {
  return (
    <div className='App Site'>
      <Navbar />
      <div className='Site-content'>
        <div className='main'>
          <Switch>
            <Route exact path='/' component={Login} />
            <Route exact path='/home' component={Home} />
            <Redirect to='/' />
          </Switch>
        </div>
      </div>
      <Footer />
    </div>
  );
};

export default App;
