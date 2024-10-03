import TitleH1 from "@/components/utilities/titles/TitleH1"; 
import Btn from "@/components/utilities/buttons/Btn";
import Labeltext from "@/components/utilities/labels/Labeltext";
function CreateUser({}) {
  return (
    <>
     <div className="border col-4 flex-column align-items-center d-flex m-auto shadow-lg rounded-3 py-4" > 
      <div className="mt-3">
          <TitleH1  title="Restablecer Contraseña" style=""></TitleH1>
       </div>
       <div className="mt-4 pb-3 ">
          <Labeltext placeholder="Correo Electronico"/>
       </div>
       <div className="">
          <Btn  texto="Enviar Correo" onClick=""  />
       </div>
       <div >
          <a className="link " href="/login">Volver a Inicio </a>
       </div>
     </div>
    </>
  );
}

export default CreateUser;
