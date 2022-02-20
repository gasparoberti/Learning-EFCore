using EFDatabaseFirst.Models;



Console.WriteLine($"Listado de Personas");
getPersonas();

//para agregar un elemento a la tabla lo agrego primero al dbset del contexto y despues guardo los cambios.
//Persona nuevaPersona = new Persona();
//nuevaPersona.Nombre = "Jose";
//nuevaPersona.Apellido = "Perez";
//nuevaPersona.Dni = 20554696;

//Console.WriteLine($"Insertando Persona...");
//postPersona(nuevaPersona);

//Console.WriteLine($"Nuevo Listado de Personas");
//getPersonas();




//-------functions--------

bool postPersona(Persona persona)
{
    using (var results = new bd_pruebaContext())
    {
        results.Persona.Add(persona);
        results.SaveChanges();
    }

    return true;
}

void getPersonas()
{
    using (var results = new bd_pruebaContext())    //contextos con todas las tablas
    {
        List<Persona> personas = results.Persona.ToList();  //Persona es un dbset
        foreach (var item in personas)
        {
            Console.WriteLine($"{item.Nombre} {item.Apellido}");
        }
    }
}





