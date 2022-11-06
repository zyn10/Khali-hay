#lists practice in csharp

List Class

List class represents the list of objects which can be accessed by
index.

It comes under the System.Collection.Generic namespace.

List class can be used to create a collection of different types like
integers, strings etc.

List class also provides the methods to search, sort, and manipulate
lists.

Creating a List of integers

List<int> numberlist = new List<int>();

numberlist.Add(1);

numberlist.Add(2);

numberlist.Add(3);

Accessing Items from the List

We can access items using foreach.

foreach (var number in numberlist)

{

Console.WriteLine(number);

}

We can also use “Count” to find the number if items in the list.

Console.WriteLine(numberlist.Count);

List can be cleared using “Clear”.

numberlist.Clear();

Example

List<string> nameslist = new List<string>();

nameslist.Add("Awais");

nameslist.Add("ALi");

nameslist.Add("Ahmad");

“Sort” will be used to sort the array.

nameslist.Sort();
