import TitleH1 from "../../components/utilities/titles/TitleH1";
import Labeltext from "@/components/utilities/labels/Labeltext";
import Btn from "@/components/utilities/buttons/Btn";

function CreateUser() {
  return (
    <div className="border col-3   flex-column align-items-center d-flex m-auto shadow-lg  py-4 px-4">
      <form>
        <div className="">
          <TitleH1 title="Crear Cuenta" styles="" />
        </div>
        <div className=" ">
          <Labeltext placeholder="Nombre" />
        </div>
        <div className="mt-4  ">
          <Labeltext placeholder="Apellido" />
        </div>

        <div className="mb-3 mt-3">
          <label htmlFor="sexo">Sexo</label>
          <select name="sexo" id="sexo" onChange="handleSelectChange" required>
            <option value="">Seleccione una Opción</option>
            <option value="hombre">Hombre</option>
            <option value="mujer">Mujer</option>
            <option value="otro">Otro</option>
            <input type="text" placeholder="¿Cual?" />
          </select>
        </div>
        <div className="mt-3  ">
          <Labeltext placeholder="Telefono" />
        </div>
        <div className="mt-4  ">
          <Labeltext placeholder="Correo Electronico" />
        </div>
        <div className="mt-4 pb-3 ">
          <Labeltext placeholder="Contraseña" />
        </div>
        <div className="ms-5">
          <Btn texto="Enviar" onClick="" />
        </div>
      </form>
    </div>
  );
}

export default CreateUser;
