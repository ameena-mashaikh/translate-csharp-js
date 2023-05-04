using System;
using System.Collections.Generic;

List<string> insults = new List<string> {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
};

List<int> dispInsults = new List<int>
{

};

int randInsult()
{
    Random randIns = new Random();
    int randInsNum = randIns.Next(0, insults.Count);
    return randInsNum;
};

while (dispInsults.Count < 3)
{
    int num = randInsult();
    if (!dispInsults.Contains(num))
    {
        dispInsults.Add(num);
    }

}

foreach (int ins in dispInsults)
{
    Console.WriteLine(insults[ins]);
}
// foreach (string insult in insults)
// {
//     while (dispInsults.Count() <= 3)
//     {
//         if (!dispInsults.Contains(insult))
//         {
//             dispInsults.Add(insult);
//         }
//     }
// };
// foreach (string ins in dispInsults)
// {
//     Console.WriteLine(ins);

// };

