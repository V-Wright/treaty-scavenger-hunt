// See https://aka.ms/new-console-template for more information

int i = 0;
int f = 0;
string input = "";
string userAnswer = "";
string[] questions = { "Through Our Story and What We Do, what do we believe can be done through increased understanding and dialogue?", "Let’s Talk about The Crown, what treaty was created in 1817?", "Let’s Talk about Numbered Treaties, how many adhesions are there?", "Now that you know Our Story and Our Logo, what do the prayers seek that the eagle messenger carries?", "Let’s Talk about Benefits, what did First Nation Elders see Treaties as?", "You know Our Story and Who We Are, but what are we all?", "Let’s Start a Discussion about our Relationships, what art gallery is a current/past partner on our list?", "Let’s Talk about What a Treaty is, what do Elders say that Treaties were?" };
string[] answers = { "change", "peguis-selkirk", "2", "peace harmony and understanding", "a bridge to the future and a way to provide for succeeding generations", "treaty people", "winnipeg art gallery", "an agreement to share the land" };
string[] answersVar = {"facilitate change", "peguis selkirk", "two", "peace, harmony, and understanding", "a way to provide for succeeding generations", "treaty people", "the winnipeg art gallery", "agreement to share the land"};
string[,] hint = { { "Go to the What We Do page under the Our Story menu", "Look under the Treaty Relations of Manitoba header", "Look at the first paragraph", "Read this sentence: We believe that through increased understanding and dialogue, we can facilitate change", "The answer is: change" },
                   { "Go to the Treaties with the Crown page under the Let's Talk Treaties menu", "The titles of the treaties have their date beside them, take a look!", "Fill in the blank: The ______-_______ Treaty", "It's the last treaty on the page", "The answer is: Peguis-Selkirk"},
                   { "Go to the Numbered Treaties page under the Let's Talk Treaties menu", "There are many treaties listed here, we are looking for the adhesions", "Treaty 5 is one of the treaties with an adhesion", "Treaty 6 is one of the treaties with an adhesion", "The answer is: 2" },
                   { "Go to the Our Logo page under the Our Story menu", "Look in the second paragraph", "The answer is in the second sentence of that paragraph", "The eagle messenger carries the prayers that seek to bring the parties together in:", "The answer is: peace, harmony, and understanding" },
                   { "Go to the Who Benefits from Treaties page under the Let's Talk Treaties menu", "Read to the end of the page, this is a long answer", "It is not in the blue quote", "It is in the last sentence of the last paragraph", "The answer is: a bridge to the future and a way to provide for succeeding generations" },
                   { "Go to the Who We Are page under the Our Story menu", "The idea that you are this may be new to you", "This is repeated three times in the first paragraph", "Finish this first sentence: We are all _____ ______", "The answer is: Treaty People" },
                   { "Go to the Relationships tab under the Start a Discusssion menu", "There is a bullet point list of partners, what art gallery is on there?", "If you live in Winnipeg, you may have gone there before", "The list is in alphabetical order (A-Z)", "The answer is: Winnipeg Art Gallery" },
                   { "Go to the What is a Treaty? page under the Let's Talk Treaties menu", "This answer is more hidden, read through the second paragraph again", "The answer is contained in the last sentence", "Look right after the words 'in fact'", "The answer is: An agreement to share the land" }};

Console.WriteLine("Go to trcm.ca to start this scavenger hunt!");

do
  {
    Console.WriteLine(questions[i]);
    input = Console.ReadLine();
    userAnswer = input.ToLower();

    if (userAnswer == answers[i] || userAnswer == answersVar[i])
    {
       i++;
       f = 0;
    }
    else if (f == 4)
    {
        Console.WriteLine("Here's a hint - " + hint[i, f]);
    }
    else
    {
        Console.WriteLine("Here's a hint - " + hint[i, f]);
        f++;
    }
}
while (input != answers[7]);

Console.WriteLine("Congradulations");