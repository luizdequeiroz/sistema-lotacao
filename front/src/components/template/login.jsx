import React from 'react';
import { useForm } from 'react-hook-form';


function Login({ open }) {

    let password;
    const {register, errors, handleSubmit} = useForm();

    return <>
      <div className="wrapper fadeInDown">
          <div id="formContent">
            <form >
                <div>
                    <input ref={register({ required: true })} type="text" className="fadeIn second" id="login" name="nome" placeholder="Nome do estabelecimento/Usuário" />
                    <input ref={register({ required: true })} type="password" className="fadeIn third" id="password" name="senha" placeholder="Senha"/>
                    <input type="submit" className="fadeIn fourth" name="login"/>
                </div>    
            </form>
            <div id="formFooter">
                <a class="underlineHover" href="#">Forgot Password?</a>
            </div>
          </div>
      </div>
    </>;
}

export default Login;

{/* <button onClick={() => open(true)}>Entrar</button> */}