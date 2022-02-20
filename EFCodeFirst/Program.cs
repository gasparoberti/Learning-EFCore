using EFCodeFirst.Context;
using EFCodeFirst.Models;

using (var ctx = new SchoolContext())
{
    var stud = new Student() 
    {
        StudentName = "Bill"
    };

    ctx.Students.Add(stud); //agrega un estudiante al contexto
    ctx.SaveChanges();      //lo guarda en la bd
}