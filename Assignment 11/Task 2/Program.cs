﻿using Task_2;

Storage<int> intStorage = new Storage<int>();
intStorage.Add(10);
intStorage.Add(20);
intStorage.Print();
intStorage.Add(30);
intStorage.Remove(20);
intStorage.Print();
intStorage.Update(30, 40);
intStorage.Print();
Storage<string> stringStorage = new Storage<string>();
stringStorage.Add("Hello ");
stringStorage.Add("World!");
stringStorage.Print();
stringStorage.Add("!");
stringStorage.Remove("World!");
stringStorage.Print();
stringStorage.Update("!", "World!");
stringStorage.Print();
