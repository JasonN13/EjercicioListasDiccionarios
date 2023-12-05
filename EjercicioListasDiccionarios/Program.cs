

List<string> Productos=new List<string>();
Productos.Add("camisa");
Productos.Add("pantalon");
Productos.Add("calcetinez");
Productos.Add("sueters");
Productos.Add("chaquetas");
Productos.Add("zapatos");
Productos.Add("corbatas");
Productos.Add("relojes");
Productos.Add("puceras");
Productos.Add("cadenas");
Productos.Add("bufandas");

Productos.Insert(3, "Calcetas");
Productos.Remove(Productos[11]);
// Mostrar el Listado en la consola usando foreach
foreach (var PRODUCTO in Productos)
{
    Console.WriteLine(PRODUCTO);
}

Dictionary<string, string> Departamento = new Dictionary<string, string>()
     {
                    {"Nombre", "Francisco Morazan"},
                    {"Cabecera", "Distrito Central"},
                    {"Superficie", "8,580km^2"},
                    {"Poblacion", "10 millones de hondureños"}
    
};

Departamento.Add("Nombre1", "Atlantida");
Departamento.Add("Cabecera1", "La Ceiba");
Departamento.Add("Superficie1", "4,227km^2");
Departamento.Add("Poblacion1", "50 mil hondureños");

// Mostrar el Diccionario en la consola usando foreach
Console.WriteLine("\nDiccionario de departamentos:");
foreach (var DEPA in Departamento)
{
    Console.WriteLine("");
    Console.WriteLine("key : "+DEPA.Key + " ---- Value : "+DEPA.Value);
}