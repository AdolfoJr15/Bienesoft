function Btn ({ texto, onClick,href}) 
    {
        return <button  className="button " onClick={onClick}>{texto}{href}</button>;
    }
  export default Btn;