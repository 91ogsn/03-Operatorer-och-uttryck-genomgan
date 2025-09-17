//3. Skriv ett uttryck som beräknar arean av en rektangel 
//utifrån inmatade width och height
Console.Write("Ange rektangelns bredd: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Ange rektangelns höjd: ");
double height = double.Parse(Console.ReadLine());

//double area = width * height;
Console.WriteLine($"Rektangelns area: {width * height}");