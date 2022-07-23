import React from 'react';
import './estilo.css'
import '../../assets/styles.css'
import '../../assets/global.css'
import logoImg from '../../assets/logo.svg'
import cadeadoImg from '../../assets/padlock.png'


export default function Login() {
  return (

    <div className="login-container">

      <section className="form">
        <img src={logoImg} alt="System Logo" />
        <form action="">

          <h1>Entre com as credencias:</h1>
          <input type="text" placeholder="username"></input>
          <input type="password" placeholder="password"></input> 
          <button className='button' type='submit'>Login</button>
        </form>

      </section>
      <img src={cadeadoImg} alt="Login" />
    </div>
  );
}