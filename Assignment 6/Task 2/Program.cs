using Task_2;
CustomList customList = new CustomList();
Person person1 = new Person { Name = "John", Surname = "Doe", Age = 30 };
customList.AddElement(person1);
Person person2 = new Person { Name = "Jane", Surname = "Smith", Age = 25 };
customList.AddElement(person2);
Person person3 = new Person { Name = "Bob", Surname = "Johnson", Age = 40 };
customList.InsertElement(person3, 1);
Person[] personsToAdd = new Person[]
{
    new Person { Name = "Alice", Surname = "Anderson", Age = 35 },
    new Person { Name = "Michael", Surname = "Williams", Age = 45 }
};
customList.AddList(personsToAdd);
Person retrievedPerson;
customList.GetElement(2, out retrievedPerson);
Console.WriteLine("Person at index 2: {0} {1}", retrievedPerson.Name, retrievedPerson.Surname);
Person[] retrievedPersons;
customList.GetList(1, 3, out retrievedPersons);
Console.WriteLine("Retrieved persons:");
foreach (Person person in retrievedPersons)
{
    Console.WriteLine("{0} {1}", person.Name, person.Surname);
}
customList.RemoveElement(person2);
Person[] personsToRemove = new Person[]
{
    person1,
    person3
};
customList.Removelist(personsToRemove);
Person foundPerson = customList.Find("Alice");
Console.WriteLine("Found person: {0} {1}", foundPerson.Name, foundPerson.Surname);
customList.Clear();