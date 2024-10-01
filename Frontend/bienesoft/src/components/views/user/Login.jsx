<<<<<<< HEAD
import Btn from "@/components/utilities/buttons/btn";
import TitleH1 from "@/components/utilities/titles/TitleH1";

function LoginForm () {
    return (
        <>
        <main>
            <form className="login-form shadow-lg" action="sidebar">
                <div className="mb-3">
                    <TitleH1 title="Iniciar Sesion" styles="login-title " />
                    <input type="email" className="form-email" placeholder="Correo electrónico" id="exampleInputEmail" aria-describedby="emailHelp" required/>
                </div>
                <div className="mb-3">       
                    <input type="password" className="form-password" placeholder="Contraseña" id="exampleInputPassword" required/>
                </div>
                    <Btn type={"submit"} style={global} nameBtn={"Ingresar"}/>
                    <div className="links-container">
                        <a className="link" href="/resetpassword">Olvidé mi contraseña</a>
                        <a className="link" href="createuser">Crear cuenta</a>
                    </div>

                </form>
        </main>
        </>
    )
}

export default LoginForm;
=======
import TitleH1 from "@/components/utilities/titles/TitleH1";

function Login () {
    return ( 
        <TitleH1 title="Inicio Sesion" styles=""/>
     );
}

export default Login ;
>>>>>>> 11db6f84dfa10aeedef9a063d05a13c653362a53
