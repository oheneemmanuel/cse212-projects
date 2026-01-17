using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // adding people with different priorities
        priorityQueue.Enqueue("Alice", 2);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Charlie", 3);
         //Verify Bob is first because 5 is the highest priority
        string firstOut = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", firstOut, "The first dequeued item should be Bob with the highest priority of 5.");
        // Verify Charlie is next because 3 is higher than 2
        string secondOut = priorityQueue.Dequeue();
        Assert.AreEqual("Charlie", secondOut, "The second dequeued item should be Charlie with the next highest priority of 3.");
        // Verify Alice is last
        string thirdOut = priorityQueue.Dequeue();
        Assert.AreEqual("Alice", thirdOut, "The third dequeued item should be Alice with the lowest priority of 2.");
       // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // adding items with same priorities
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 1); 
        priorityQueue.Enqueue("Task3", 1); 

        // Verify they come out in the order they were added
        string firstOut = priorityQueue.Dequeue();
        Assert.AreEqual("Task1", firstOut, "The first dequeued item should be Task1 as it was added first among equal priorities.");

        string secondOut = priorityQueue.Dequeue();
        Assert.AreEqual("Task2", secondOut, "The second dequeued item should be Task2 as it was added second among equal priorities.");

        string thirdOut = priorityQueue.Dequeue();
        Assert.AreEqual("Task3", thirdOut, "The third dequeued item should be   Task3 as it was added last among equal priorities.");
        //Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}