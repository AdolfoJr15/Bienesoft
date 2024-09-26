import TitleH1 from "../../components/utilities/titles/TitleH1";

function ResetPassword() {
    return (
        <main>
            <form className="reset-password-form shadow-lg">
                <div className="mb-3">
                    <TitleH1 title="Restablecer Contraseña" styles="reset-title" />
                    <input
                        type="email"
                        className="form-email"
                        placeholder="Correo electrónico"
                        id="resetInputEmail"
                        aria-describedby="emailHelp"
                        required
                    />
                </div>
                <button type="submit" className="btn btn-primary">Enviar enlace de restablecimiento</button>
                <div className="links-container">
                    <a className="link" href="app">Volver al inicio de sesión</a>
                </div>
            </form>
        </main>
    );
}

export default ResetPassword;
