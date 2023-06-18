using System.ComponentModel.Design;

namespace Task_2;

public class Person
{
    private string? _name;
    private string? _surname;
    private int _age;

    public string? Name
    {
        get => _name;
        set => _name = value;
    }

    public string? Surname
    {
        get => _surname;
        set => _surname = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }


}

public class CustomList
{
    public int _count
    { get { return _persons.Count(person=> person != null); } }

    public Person[] _persons = new Person[10];

    public Person this[int index]
    {
        get { return _persons[index]; }
        set { _persons[index] = value; }
    }


    public void AddElement(Person person)
    {
        int index = Array.IndexOf(_persons, null);
        if (index >= 0)
            _persons[index] = person;
        else
        {
            Array.Resize(ref _persons, _persons.Length + 1);
            _persons[_persons.Length] = person;
        }
    }

    public void AddList(Person[] persons)
    {
        int index = Array.IndexOf(_persons, null);
        if (index >= 0 && index + persons.Length <= _persons.Length)
            Array.Copy(persons, 0, _persons, index, persons.Length);
        else
        {
            Array.Resize(ref _persons, _persons.Length + persons.Length);
            Array.Copy(persons, 0, _persons, _persons.Length-1, persons.Length);
        }
    }

    public bool InsertElement(Person person, int index)
    {
        if (index <= _persons.Length - 1)
        {
            _persons[index] = person;
            return true;
        }
        else return false;
    }

    public bool InsertList(Person[] persons, int index)
    {
        if (index + persons.Length <= _persons.Length)
        {
            Array.Copy(persons, 0, _persons, index, persons.Length);
            return true;
        }
        else return false;
    }
    public bool GetElement(int index, out Person person)
    {
        if (index >= _persons.Length)
        {
            person = new Person();
            return false;
        }
        else
        {
            person = _persons[index];
            return true;
        }
    }

    public bool GetList(int index, int len, out Person[] persons)
    {
        persons = new Person[len];
        if (index + len >= _persons.Length)
        {
            persons = new Person[0];
            return false;
        }
        else
        {
            Array.Copy(_persons, index, persons, 0, len);
            return true;
        }
    }

    public void RemoveElement(Person person)
    {
        int index = Array.IndexOf(_persons, person);
        if (index >=0)
            _persons[index] = new Person();
    }

    public void Removelist(Person[] persons)
    {
        foreach (Person person in persons)
        {
            int index = Array.IndexOf(_persons, person);
            _persons[index] = new Person();
        }
    }

    public void Clear()
    {
        _persons = new Person[0]; 
    }
    public Person Find(String name)
    {
        foreach(Person person in _persons)
        {
            if (person != null)
                if (person.Name == name) return person;
        }
        return new Person();
    }
}