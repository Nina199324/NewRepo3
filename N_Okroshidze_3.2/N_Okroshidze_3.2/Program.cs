using System.Collections;

Queue myQueue = new Queue();
myQueue.Enqueue(100);
myQueue.Enqueue(null);
myQueue.Enqueue(24);
myQueue.Enqueue(11);
myQueue.Enqueue(1993);
myQueue.Enqueue(29);
myQueue.Enqueue(0);
myQueue.Enqueue(2023); 
myQueue.Enqueue(null);
Console.WriteLine("Number of elements in Queue is:");
Console.WriteLine(myQueue.Count);
Console.WriteLine("Removing the 1st element from Queue, its a = " + myQueue.Dequeue());
Console.WriteLine("Left elements in myQueue");
Console.WriteLine(myQueue.Count); 
foreach (var element in myQueue)
    Console.WriteLine(element);
Console.WriteLine(myQueue.GetType());
if (myQueue.Any()) ;