

LinkedNode<string> startNode = new LinkedNode<string>();
LinkedNode<string> currentNode = startNode;

for (var i = 0; i < 1000000; i++)
{
  LinkedNode<string> node = new();
  currentNode.next = node;
  currentNode = node;
}






Console.ReadLine();








// Dictionary<string, string> ordbok = new();

// ordbok.Add("Skola", "Rolig plats fylld av gläde och ljus");
// ordbok.Add("Micke", "Jättebra lärare");
// ordbok.Add("Martin", "Nästan lika bra lärare");

// string ord = Console.ReadLine();

// if (ordbok.ContainsKey(ord))
// {
//   Console.WriteLine(ordbok[ord]);
// }
// else
// {
//   Console.WriteLine("What?");
// }


// Queue<int> numbers = new();

// Random generator = new();

// for (int i = 0; i < 10; i++)
// {
//   numbers.Enqueue(generator.Next(100));
// }

// while (numbers.Count > 0)
// {
//   int n = numbers.Dequeue();
//   Console.WriteLine(n);
// }

