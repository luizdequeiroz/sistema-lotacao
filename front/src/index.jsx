import React from 'react';
import ReactDOM from 'react-dom';
import Header from './components/template';
import { HashRouter as Routers, Switch, Route } from 'react-router-dom';
import Registro from './components/registro';

import 'bootstrap/dist/css/bootstrap.min.css';
import './assets/style.css';

const api = "https://localhost:44327/api";

function App() {

    return (
        <Routers>
            <Header />
            <Switch>
                <Route exact path="/" component={() => <h1>Inicio</h1>} />
                <Route path="/registro" component={Registro} />
            </Switch>
        </Routers>
    );
}

ReactDOM.render(<App />, document.getElementById('app'));