using EFDatabaseFirst.Models;

using (var results = new bd_pruebaContext())
{
    List<Persona> personas = results.Persona.ToList();

    foreach (var item in personas)
    {
        Console.WriteLine(item.Nombre);
    }
}
