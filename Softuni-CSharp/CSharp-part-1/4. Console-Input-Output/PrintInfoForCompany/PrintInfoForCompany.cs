using System;

class PrintInfoForCompany
{
    static void Main()
    {
        Console.Write("Comapny name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Company fax: ");
        string companyFax = Console.ReadLine();

        Console.Write("Company website: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager's phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0} is located at {1}. You can contact them via Phone: {2}, Fax: {3}, or their WebSite: {4}. Company manager is {5} {6}. He is {7} years old and his phone number is {8}",companyName, companyAddress,companyPhone, companyFax, companyWebSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

