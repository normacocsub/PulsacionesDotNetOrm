using Entity;

public class PersonaInputModel : Persona​
{

}

public class PersonaViewModel : PersonaInputModel​
{
        public PersonaViewModel()
        {
        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Edad = persona.Edad;
            Sexo = persona.Sexo;
            Pulsacion = persona.Pulsacion;
        }

    }