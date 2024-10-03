import TitleH1 from "@/components/utilities/titles/TitleH1";
import Btn from "@/components/utilities/buttons/Btn";
import Labeltext from "@/components/utilities/labels/Labeltext";
function LoginUser({}) {
  return (
    <>
      <div className="border col-4 flex-column align-items-center d-flex m-auto shadow-lg rounded-3 py-4 ">
        <div className="mt-3">
          <TitleH1 title="Inicio de Sesion" style=""></TitleH1>
        </div>
        <div className="mt-4 pb-3 ">
          <Labeltext placeholder="Correo" />
        </div>
        <div className="pb-3 ">
          <Labeltext placeholder="Contraseña" />
        </div>
        <div  className="link px-lg-5 " >
          <Btn texto="Iniciar Sesion" onClick="" />
        </div>
        <div className="my-4">
          <a className="link" href="/resetpassword">
            ¿Has olvidado tu contraseña?
          </a>
          <a className="link ms-5" href="/createuser">
            Crear cuenta
          </a>
        </div>
      </div>
    </>
  );
}

export default LoginUser;
