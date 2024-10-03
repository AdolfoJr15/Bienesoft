function Labeltext({ placeholder, label, type, id, onChange, }) {
    return (
      <div>
        <label htmlFor={id}>{label}</label>
        <input
          className="bg-body col-form-label border-primary rounded-2 p-2  "
          type={type}
          id={id}
          onChange={onChange}
          placeholder={placeholder}
        />
      </div>
    );
  }
  
  export default Labeltext;