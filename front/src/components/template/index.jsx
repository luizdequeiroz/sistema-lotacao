import React from 'react';
import Menu from './menu';
import { Switch, Route } from 'react-router-dom';

//const fastFoodImg = require('../../assets/images/FastFood.jpg');
const caseiraImg = require('../../assets/images/caseira.jpg');

function Header() {

    return <>
        <div className="carousel slide carousel-fade" data-ride="carousel">
            <div className="carousel-inner">
                <div className="carousel-item active">
                    <Switch>
                        <Route path="/" component={() => <img className="d-block w-100" src={caseiraImg} />} />
                    </Switch>                    
                </div>
            </div>
        </div>
        <Menu />
    </>;
}

export default Header;