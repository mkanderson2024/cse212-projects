using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adds three seperate items with differing priority levels to test if it brings back the highest priority.
    // Expected Result: Program should remove the item with the highest priority level first when the dequeue is called.
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("low", 2);
        priorityQueue.Enqueue("high", 10);
        priorityQueue.Enqueue("medium", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Addes three items, 2 with similar prioritiy levels to test if it brings back the 1st item with matching
    // priorities from the queue when the dequeue is called.
    // Expected Result: Program should remove "medium2" from the queue which will be entered first. Using medium2 for
    // variable name to ensure seeing the first item entered is item returned.
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("low", 2);
        priorityQueue.Enqueue("medium2", 5);
        priorityQueue.Enqueue("medium1", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("medium2", result);
    }

    [TestMethod]
    // Scenario: creates queue with no added items to verify empty queue handling is valild.
    // Expected Result: Program should return error "The queue is empty."
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var result = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });

        Assert.AreEqual("The queue is empty.", result.Message);
    }
}