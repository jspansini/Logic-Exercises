using ExercicioReflection;
using System.Reflection;

//crie um método chamado DisplayPublicProperties Exibindo as classes públicas
//GetType faz esse trabalho naturalmente exibindo as classes publicas, adicionei uma prop id private pra testar!
void DisplayPublicProperties(object classe)
{
    Type type = classe.GetType();
    Console.WriteLine($"Imprimindo as informações da classe {classe}");
    foreach (PropertyInfo prop in type.GetProperties())
    {
        Console.WriteLine(prop.Name);
    }
}

Console.WriteLine();

//instanciando um student
Student student = new Student();
Console.WriteLine("Propriedades públicas da classe:");
DisplayPublicProperties(student);

Console.WriteLine();


//Use Reflection para preencher as propriedades públicas do objeto.

Type type = student.GetType();

object PropManual = Activator.CreateInstance(type);

PropertyInfo propNome = type.GetProperty("Name");
propNome.SetValue(PropManual, "Jess Pansini");

PropertyInfo propUniversidade = type.GetProperty("University");
propUniversidade.SetValue(PropManual, "42 Rio");

PropertyInfo propRollNumber = type.GetProperty("RollNumber");
propRollNumber.SetValue(PropManual, 132313);

PropertyInfo propIdStudent = type.GetProperty("IdStudent");
propRollNumber.SetValue(PropManual, 13);


//Use Reflection para chamar o método DisplayInfo do objeto criado

Console.WriteLine("****************************");
MethodInfo mostrarMetodo = type.GetMethod("DisplayInfo");
object result = mostrarMetodo.Invoke(PropManual, null);