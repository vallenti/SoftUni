using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web Site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        if (companyName == String.Empty)
            companyName = "(no comapny name)";
        if (companyAddress == String.Empty)
            companyAddress = "(no company adress)";
        if (phoneNumber == String.Empty)
            phoneNumber = "(no company phone)";
        if (faxNumber == String.Empty)
            faxNumber = "(no fax number)";
        if (webSite == String.Empty)
            webSite = "(no web site)";
        if (managerFirstName == String.Empty)
            managerFirstName = "(no first name)";
        if (managerLastName == String.Empty)
            managerLastName = "(no last name)";
        if (managerPhone == String.Empty)
            managerPhone = "(no phone)";

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: "+webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,managerLastName,managerAge,managerPhone);
    }
}

