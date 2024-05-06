using PLista;

internal class Program
{
    private static void Main(string[] args)
    {
        ContactList lista = new ContactList();

        Contact contact1 = new("Bernardo", "123");
        Contact contact2 = new("Ana", "321");
        Contact contact3 = new("Caue", "456");
        Contact contact4 = new("Bruna", "321");
        lista.Add(contact1);
        lista.Add(contact2);
        lista.Add(contact3);
        lista.Add(contact4);
        lista.RemoveByName("Caue");
        Console.WriteLine("fim");
    }
}