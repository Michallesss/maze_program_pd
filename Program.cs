using labirynt;

// Opcje uzytkownika
List<Board> boards= new List<Board>();

//Board map = new Board();
int selectBoard(string title)
{
    Console.WriteLine("-------"+title+"------");
    int i = 0;
    foreach (Board b in boards)
    {
        Console.WriteLine(i + ". " + b.Name);
        i++;
    }

    int x;
    for (; ; )
    {
        Console.Write("Podaj mape:");
        try { x = Convert.ToInt32(Console.ReadLine()); }
        catch
        {
            Console.WriteLine("Podano nieprawidłową wartość...");
            continue;
        }
        if (x < 0 || x > boards.Count - 1)
        {
            Console.WriteLine("Podano nieprawidłową wartość...");
            continue;
        }
        break;
    }

    return x;
}

for (; ; )
{
    Console.Clear();
    Console.WriteLine("------Menu------");
    Console.WriteLine("1. Utwórz nową");
    Console.WriteLine("2. Usuń istniejącą");
    Console.WriteLine("3. Wyświetl");
    Console.WriteLine("4. Edytuj");
    Console.WriteLine("5. Wyjdź");
    Console.WriteLine("----------------");
    Console.Write("Opcja menu:");

    switch(Console.ReadLine())
    {
        case "1":
            boards.Add(new Board());
            break;

        case "2":
            boards.RemoveAt(selectBoard("Usuwanie"));
            break;

        case "3":
            boards[selectBoard("Wyświetlenie")].Display();
            Console.Write("Kliknij enter aby wrócić do menu...");
            Console.ReadLine();
            break;

        case "4":
            Board edit = boards[selectBoard("Edytowanie")];
            edit.Display();
            edit.Change();
            Console.Write("Kliknij enter aby wrócić do menu...");
            Console.ReadLine();
            break;

        case "5":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Podano nieprawidłowy index menu...");
            Console.ReadLine();
            Console.Clear();
            break;
    }
}