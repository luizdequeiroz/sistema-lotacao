import React from 'react';
import { Link } from 'react-router-dom';

function Menu() {

    return <>
        <ul className="mr-auto">
            <li><Link to="/">Inicio</Link></li>
            <li><a>Sobre</a></li>
            <li><a>Lugares</a></li>
            <li><Link to="/registro">Registro</Link></li>
            <nav className="navbar navbar-ligt bg-ligt" style={{ float: 'right' }}>
                <form className="form-inline">
                    <input className="form-control mr-sm-2" type="search" placeholder="Pesquisar" aria-label="Pesquisar" />
                    <button className="btn btn-outline-sucess my-2 my-sm-0" type="submit">search</button>
                </form>
            </nav>
        </ul>
    </>;
}

export default Menu;