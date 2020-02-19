import React, { useState } from 'react';
import ReactDOM from 'react-dom';

const api = "https://localhost:44327/api";

function App() {
    const [usuarios, setUsuarios] = useState([]);

    function getUsers() {

        fetch(`${api}/Usuario`,
        {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                if (response.ok) {
                    return response.json();
                }
            })
            .then(json => {
                setUsuarios(json);
            });
    }

    return <>
        <button onClick={getUsers}>CADASTRO ESTABELECIMENTO</button>
        <h3>CADASTRO ESTABELECIMENTO</h3>
        <ul>
            {usuarios.map(usuario => <li>{usuario.nome} - {usuario.email}</li>)}
        </ul>
    </>;
}

ReactDOM.render(<App />, document.getElementById('app'));