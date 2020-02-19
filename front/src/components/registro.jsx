import React from 'react';

function Registro() {

    return <div className="content">
        <div className="container">
            <div className="register">
                <form>
                    <div className="register-top-grid">
                        <h3 className="info">INFORMAÇÃO ESTABELECIMENTO</h3>
                    </div>
                    <div className="register-format form-row">
                        <div className="form-group col-md-10">
                            <span>Nome do Estabelecimento<label>*</label></span>
                            <input type="text" className="form-control" id="estabelecimento" aria-describedby="estabelecimento" placeholder="Estabelecimento" />
                        </div>
                        <div className="form-group col-md-6">
                            <span>Endereço<label>*</label></span>
                            <input type="text" className="form-control" id="estabelecimentoEnd" aria-describedby="endereço" placeholder="endereço" />
                        </div>
                        <div className="form-group col-md-6">
                            <span>Email<label>*</label></span>
                            <input type="email" className="form-control" id="estabelecimentoEmail" aria-describedby="email" placeholder="Email" />
                        </div>
                        <div className="form-group col-md-4">
                            <span>Capacidade<label>*</label></span>
                            <input type="text" className="form-control" id="estabelecimentoCap" aria-describedby="capacidade" placeholder="capacidade" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>;
}

export default Registro;