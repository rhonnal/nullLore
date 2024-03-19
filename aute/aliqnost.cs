public static void InsertAndRemove(Repository<TestClass> testObjects)
{
    // Option 1: Use a foreach loop to iterate over the test objects and insert them into the repository
    foreach (var testObject in testObjects.GetAll())
    {
        testObjects.Insert(testObject);
    }

    // Option 2: Use a LINQ query to filter the test objects by some condition and insert them into the repository
    var filteredTestObjects = testObjects.GetAll().Where(t => t.Name.StartsWith("A"));
    testObjects.InsertRange(filteredTestObjects);

    // Option 3: Use a for loop to insert a fixed number of test objects into the repository
    for (int i = 0; i < 10; i++)
    {
        var testObject = new TestClass { Id = i, Name = "Test" + i };
        testObjects.Insert(testObject);
    }

    // After inserting the test objects, you can remove them from the repository using one of the following methods:

    // Option 1: Use the Remove method to remove a single test object by its id
    testObjects.Remove(5);

    // Option 2: Use the RemoveRange method to remove a collection of test objects by their ids
    var idsToRemove = new List<int> { 1, 3, 7, 9 };
    testObjects.RemoveRange(idsToRemove);

    // Option 3: Use the Clear method to remove all the test objects from the repository
    testObjects.Clear();
}
