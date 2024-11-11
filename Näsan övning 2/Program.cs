bool inloggad = false;
bool steg2 = false;

int försökA = 3;
int försökB = 3;


Console.WriteLine("Användarnamn:");


while(inloggad == false)
{
string användarnamn = Console.ReadLine();
if(användarnamn == "kalleanka"){
steg2 = true;
inloggad = true;
}
else if(försökA > 0 || string.IsNullOrWhiteSpace(användarnamn))
{
    Console.WriteLine($"Fel! Du har {försökA} försök kvar");
    försökA -= 1;
    continue;
}
else if(försökA == 0 || string.IsNullOrWhiteSpace(användarnamn))
{
    Console.WriteLine("Fel! Vänligen vänta 5 minuter innan du kan försöka igen.");
    Thread.Sleep(60000);
    Console.WriteLine("Du har 4 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 3 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 2 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 1 minut kvar.");
        Thread.Sleep(60000);
        continue;
    försökA += 3;
    }
}

Console.WriteLine("Lösenord:");

while(inloggad == true)
{
    string lösenord = Console.ReadLine();
    if(lösenord == "12345"){
        inloggad = true;
        Console.WriteLine("Välkommen in");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
else if(försökB > 0 || string.IsNullOrWhiteSpace(lösenord))
{
    Console.WriteLine($"Fel! Du har {försökA} försök kvar");
    försökB -= 1;
    continue;
}
else if(försökB == 0 || string.IsNullOrWhiteSpace(lösenord))
{
    Console.WriteLine("Fel! Vänligen vänta 5 minuter innan du kan försöka igen.");
    Thread.Sleep(60000);
    Console.WriteLine("Du har 4 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 3 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 2 minuter kvar.");
        Thread.Sleep(60000);
    Console.WriteLine("Du har 1 minut kvar.");
        Thread.Sleep(60000);
        continue;
    försökB += 3;
    }
}