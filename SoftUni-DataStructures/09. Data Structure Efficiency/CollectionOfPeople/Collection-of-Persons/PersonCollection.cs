using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    private Dictionary<string, Person> peopleByEmail;
    private Dictionary<string, SortedSet<Person>> peopleByEmailDomain;
    private Dictionary<string, SortedSet<Person>> peopleByNameAndTown;
    private OrderedDictionary<int, SortedSet<Person>> peopleByAge;
    private Dictionary<string, OrderedDictionary<int, SortedSet<Person>>> peopleByTownAndAge;

    public PersonCollection()
    {
        peopleByEmail = new Dictionary<string, Person>();
        peopleByEmailDomain = new Dictionary<string, SortedSet<Person>>();
        peopleByNameAndTown = new Dictionary<string, SortedSet<Person>>();
        peopleByAge = new OrderedDictionary<int, SortedSet<Person>>();
        peopleByTownAndAge = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();
    }

    public bool AddPerson(string email, string name, int age, string town)
    {
        if(peopleByEmail.ContainsKey(email))
        {
            return false;
        }

        var person = new Person(email, name, age, town);

        //add by email
        peopleByEmail.Add(email, person);

        //add by email domain
        string emailDomain = this.ExtractEmailDomain(email);
        peopleByEmailDomain.AppendValueToKey(emailDomain, person);

        //add by name and town
        var nameAndTown = this.CombineNameAndTown(name, town);
        peopleByNameAndTown.AppendValueToKey(nameAndTown, person);

        //add by age
        this.peopleByAge.AppendValueToKey(age, person);

        //add by town and age
        this.peopleByTownAndAge.EnsureKeyExists(town);
        this.peopleByTownAndAge[town].AppendValueToKey(age, person);

        return true;
    }

    private string ExtractEmailDomain(string email)
    {
        var domain = email.Split('@')[1];
        return domain;
    }

    public int Count
    {
        get
        {
            return this.peopleByEmail.Count;
        }
    }

    public Person FindPerson(string email)
    {
        if(peopleByEmail.ContainsKey(email))
        {
            return peopleByEmail[email];
        }

        return null;
    }

    public bool DeletePerson(string email)
    {
        var person = this.FindPerson(email);
        if(person == null)
        {
            return false;
        }



        //remove by email
        var personDeleted = this.peopleByEmail.Remove(email);

        //remove by email domain
        string emailDomain = this.ExtractEmailDomain(email);
        this.peopleByEmailDomain[emailDomain].Remove(person);

        //remove by name and town
        var nameAndTown = this.CombineNameAndTown(person.Name, person.Town);
        this.peopleByNameAndTown[nameAndTown].Remove(person);

        //remove by age
        this.peopleByAge[person.Age].Remove(person);

        //remove by town and age
        peopleByTownAndAge[person.Town][person.Age].Remove(person);

        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        return this.peopleByEmailDomain.GetValuesForKey(emailDomain);
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        string nameAndTown = this.CombineNameAndTown(name, town);
        return this.peopleByNameAndTown.GetValuesForKey(nameAndTown);
    }

    private string CombineNameAndTown(string name, string town)
    {
        const string separator = "|!|";
        return name + separator + town;
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var peopleInRange = this.peopleByAge.Range(startAge, true, endAge, true);
        foreach (var personByAge in peopleInRange)
        {
            foreach (var person in personByAge.Value)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if(!this.peopleByTownAndAge.ContainsKey(town))
        {
            yield break;
        }

        var peopleInRange = this.peopleByTownAndAge[town].Range(startAge, true, endAge, true);
        foreach (var personByAge in peopleInRange)
        {
            foreach (var person in personByAge.Value)
            {
                yield return person;
            }
        }
    }
}
