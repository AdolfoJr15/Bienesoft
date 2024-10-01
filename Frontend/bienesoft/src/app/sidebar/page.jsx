"use client";
import React, { useState } from 'react';

export default function sidebar() {
    const [isOpen, setIsOpen] = useState(false);

    const toggleSidebar = () => {
      setIsOpen(!isOpen);
    };
  return (
    <>
    <nav className="navbar bg-nav-public shadow-sm">
    <div className="container-fluid">
    <a className="navbar-brand" href="">
    <img id="img" src="./assets/img/logo.png" alt="Logo" width="140" height="40" className="d-inline-block align-text-top"/>
    </a>
        <div className="nav-links">
            <a href="#">Inicio</a>
            <a href="#">Perfil</a>
            <a href="#">Configuración</a>
            <a href="#">Ayuda</a>
        </div>
    </div>
    </nav>
    <div className="container">
        <button className="toggle-button" onClick={toggleSidebar}>☰</button>
        <aside className={`sidebar ${isOpen ? 'open' : ''}`}>
            <a href="">Aprendiz</a>
            <a href="">Area</a>
            <a href="">Programa</a>
            <a href="">Ficha</a>
            <a href="">Acudientes</a>
            <a href="">Responsables</a>
            <a href="">Permisos</a>
        </aside>
    </div>

    </>
  );

  
  
}