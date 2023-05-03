using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("My wishes......");

// List<string> wishes = GetWish();

List<string> wish = new List<string>
    {
    "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
    "The ability to think of interesting wishes on short notice",
    "A washtub of Skittles",
    "World peace, but not the kind of world peace where all the humans are removed from existence",
    "A TV that is NOT internet-capable",
    "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
    };

foreach (string w in wish)
{
    Console.WriteLine(w);
}

//A function to make and return a list of wishes
// List<string> GetWish()
// {
// List<string> wish = new List<string>
//     {
//     "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
//     "The ability to think of interesting wishes on short notice",
//     "A washtub of Skittles",
//     "World peace, but not the kind of world peace where all the humans are removed from existence",
//     "A TV that is NOT internet-capable",
//     "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
//     };
//     return wish;
// }