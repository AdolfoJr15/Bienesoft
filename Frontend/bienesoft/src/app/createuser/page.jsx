import TitleH1 from "../../components/utilities/titles/TitleH1";

function CreateUser() {
    return (
        <main>
            <form className="create-user-form shadow-lg">
                <div className="mb-3">
                    <TitleH1 title="Crear Cuenta" styles="create-title" />
                    <p>Es rápido y fácil.</p>
                    <input
                        type="text"
                        className="form-input"
                        placeholder="Nombre"
                        id="inputName"
                        required
                    />
                </div>
                <div className="mb-3">
                    <input 
                        type="text"
                        className="form-input"
                        placeholder="Apellido"
                        id="inputSurname"
                        required
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="fecha">Fecha de Nacimiento</label>
                    <input 
                        type="date"
                        className="form-date"
                        id="inputDate"
                        required 
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="sexo">Sexo</label>
                    <select name="sexo" id="sexo" onChange="handleSelectChange" required>
                        <option value="">Seleccione una Opción</option>
                        <option value="hombre">Hombre</option>
                        <option value="mujer">Mujer</option>
                        <option value="otro">Otro</option>
                        <input 
                        type="text" 
                        placeholder="¿Cual?"/>
                    </select>
                </div>
                <div className="mb-3">
                    <input 
                        type="number"
                        className="form-phone"
                        placeholder="Número de Celular"
                        id="inputPhone"
                        required 
                    />
                </div>
                <div className="mb-3">
                    <input
                        type="email"
                        className="form-email"
                        placeholder="Correo electrónico"
                        id="inputEmail"
                        required
                    />
                </div>
                <div className="mb-3">
                    <input
                        type="password"
                        className="form-password"
                        placeholder="Contraseña"
                        id="inputPassword"
                        required
                    />
                </div>
                <button type="submit" className="btn btn-primary">Registrarse</button>
                <div className="links-container">
                    <a className="link" href="login">Ya tengo una cuenta</a>
                </div>
            </form>
        </main>
    );
}

export default CreateUser;
