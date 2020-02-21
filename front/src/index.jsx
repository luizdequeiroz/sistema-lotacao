import React, { useState } from 'react';
import ReactDOM from 'react-dom';
import Header from './components/template';
import { HashRouter as Routers, Switch, Route } from 'react-router-dom';
import Registro from './components/registro';
import Rodape from './components/template/rodape';
import Login from './components/template/login';

import 'bootstrap/dist/css/bootstrap.min.css';
import './assets/style.css';
import './assets/register.css';
import './assets/login.css';

const api = "https://localhost:3000/api";

function App() {
    const [sessao, setSessao] = useState(false);

    return (
        <Routers>
            {sessao ?
                <>
                    <Header />
                    <Switch>
                        <Route exact path="/" component={() => <h1>Inicio</h1>} />
                        <Route path="/registro" component={Registro} />
                        <Route path="/rodape" component={Rodape} />
                    </Switch>
                </>
                :
                <Login open={setSessao} />}
        </Routers>
    );
}

ReactDOM.render(<App />, document.getElementById('app'));