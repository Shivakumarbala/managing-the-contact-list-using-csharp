class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string firstName, string lastName, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}\nPhone: {PhoneNumber}\nEmail: {Email}";
    }
}

class ContactBook
{
    private List<Contact> contacts;

    public ContactBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully.");
    }

    public void DisplayContacts()
    {
        Console.WriteLine("\nContacts in the Contact Book:");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
            Console.WriteLine("------------");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactBook contactBook = new ContactBook();

        while (true)
        {
            Console.WriteLine("\nContact Book Menu:");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Display contacts");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    Contact newContact = new Contact(firstName, lastName, phoneNumber, email);
                    contactBook.AddContact(newContact);
                    break;

                case 2:
                    contactBook.DisplayContacts();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}