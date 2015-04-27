using System;

/*  A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

_Example input:_

|       program       |            user            |
|---------------------|----------------------------|
| Company name:       | Telerik Academy            |
| Company address:    | 31 Al. Malinov, Sofia      |
| Phone number:       | +359 888 55 55 555         |
| Fax number:         | 2                          |
| Web site:           | http://telerikacademy.com/ |
| Manager first name: | Nikolay                    |
| Manager last name:  | Kostov                     |
| Manager age:        | 25                         |
| Manager phone:      | +359 2 981 981             |

_Example output:_

	Telerik Academy
	Address: 231 Al. Malinov, Sofia
	Tel. +359 888 55 55 555
	Fax: (no fax)
	Web site: http://telerikacademy.com/
	Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)*/

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Input company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Input company name: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Input company's phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Input company's fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Input company's web site: ");
        string companyWeb = Console.ReadLine();
        Console.Write("Input manager's first name: ");
        string managerName = Console.ReadLine();
        Console.Write("Input manager's surname: ");
        string managerSur = Console.ReadLine();
        Console.Write("Input manager's age: ");
        Byte age = Byte.Parse(Console.ReadLine());
        Console.Write("Input company's phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\r\nAddress: {1}\r\nTel.{2}\r\nFax. {3}\r\nWeb site: {4}\r\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhone, companyFax, companyWeb, managerName, managerSur, age, managerPhone);
    }
}
