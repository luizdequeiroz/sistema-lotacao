import React, { useState } from 'react';
import { useForm } from 'react-hook-form';

function Registro() {
    let confirmPasswordRef;
    const { register, errors, handleSubmit } = useForm({ mode: 'onChange' });
    const [confirmValid, setConfirmValid] = useState(true);

    function enviarForm(values) {

        if (values.password !== confirmPasswordRef.value) {
            setConfirmValid(false);
            return;
        }

        alert('Envio em execução!');
    }

    return <div className="content">
        <div className="container">
            <div className="register">
                <form onSubmit={handleSubmit(enviarForm)}>
                    <div className="register-top-grid">
                        <h3 className="info">INFORMAÇÃO ESTABELECIMENTO</h3>
                    </div>
                    <div className="register-format form-row">
                        <div className="form-group col-md-10">
                            <span>Nome do Estabelecimento<label>*</label></span>
                            <input ref={register({ required: true })} type="text" className="form-control" name="estabelecimento" aria-describedby="estabelecimento" placeholder="Estabelecimento" />
                            {errors && errors['estabelecimento'] && <span className="text-warning">Nome do estabelecimento obrigatório!</span>}
                        </div>
                        <div className="form-group col-md-6">
                            <span>Endereço<label>*</label></span>
                            <input ref={register} type="text" className="form-control" name="estabelecimentoEnd" aria-describedby="endereço" placeholder="endereço" />
                        </div>
                        <div className="form-group col-md-6">
                            <span>Email<label>*</label></span>
                            <input ref={register} type="email" className="form-control" name="estabelecimentoEmail" aria-describedby="email" placeholder="Email" />
                        </div>
                        <div className="form-group col-md-4">
                            <span>Capacidade<label>*</label></span>
                            <input ref={register} type="number" className="form-control" name="estabelecimentoCap" aria-describedby="capacidade" placeholder="capacidade" />
                        </div>
                        <div className="form-group col-md-2">
                            <span>Senha<label>*</label></span>
                            <input ref={register({ required: true })} type="password" className="form-control" name="password" aria-describebdy="senha" />
                            {errors && errors['password'] && <span className="text-warning">Senha obrigatória!</span>}
                        </div>
                        <div className="form-group col-md-3">
                            <span>Confirmação da Senha<label>*</label></span>
                            <input ref={input => confirmPasswordRef = input} type="password" className="form-control" name="confirmPass" aria-describebdy="senha" />
                            {confirmValid || <span className="text-warning">Confirmação de senha difere da senha informada!</span>}
                        </div>
                    </div>
                    <div className="form-group">
                        <input type="submit" className="buttonValidation" id="button" />
                    </div>
                </form>
            </div>
        </div>
    </div>;
}

export default Registro;