using Elections;
var election2023 = new Election();
PrintMenu();
var option = Console.ReadLine();

while (option.ToLower() != "x")
{
    switch (option.ToLower())
    {
        case "a":
            var candidate = InputCandidate();
            election2023.ElectionCandidates.Add(candidate);
            Console.Clear();
            break;
        case "b":
            var party = InputParty();
            election2023.ElectionParties.Add(party);
            Console.Clear();
            break;
        case "c":
            AssignCandidateToParty();
            Console.Clear();
            break;
        case "d":
            VoteCandidate();
            Console.Clear();
            break;
        case "e":
            VoteParty();
            Console.Clear();
            break;
        case "pc":
            PrintCandidate();
            break;
        case "p":
            election2023.PrintResultParties();
            break;
        default:
            Console.WriteLine("Invalid option");
        break;
    }
    PrintMenu();
    option = Console.ReadLine();
}

void PrintMenu()
{
    Console.WriteLine("Input \"A\" to enter a candidate");
    Console.WriteLine("Input \"B\" to enter a party");
    Console.WriteLine("Input \"C\" to assign a candidate to a party"); 
    Console.WriteLine("Input \"D\" to vote for a candidate");
    Console.WriteLine("Input \"E\" to vote for a party");
    Console.WriteLine("Input \"PC\" to print candidate results");
    Console.WriteLine("Input \"P\" to print results");
    Console.WriteLine("Input \"X\" to exit");
}
Candidate InputCandidate(){
    Console.WriteLine("Enter id");
    var id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter full name");
    var fullname = Console.ReadLine();

    var candidate = new Candidate
    {
        Id = id,
        Fullname = fullname
    };
    return candidate;
}
PoliticalParty InputParty()
{
    Console.WriteLine("Enter id");
    var id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter name");
    var name = Console.ReadLine();

    var party = new PoliticalParty
    {
        Id = id,
        Name = name
    };
    return party;
}
void AssignCandidateToParty()
{
    Console.WriteLine("Enter candidate id");
    var candidateId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter party id");
    var partyId = Convert.ToInt32(Console.ReadLine());

    var candiate = new Candidate();
    foreach(var c in election2023.ElectionCandidates)
    {
        if(c.Id == candidateId)
        {
            candiate = c;
            break;
        }
    }
    var party = new PoliticalParty();
    foreach (var p in election2023.ElectionParties)
    {
        if (p.Id == partyId)
        {
            party = p;
            break;
        }
    }

    party.Candidates.Add(candiate);
}
void VoteCandidate()
{
    Console.WriteLine("Enter candidate id");
    var candidateId = Convert.ToInt32(Console.ReadLine());
    election2023.VoteCanditate(candidateId);
}
void VoteParty()
{
    Console.WriteLine("Enter party id");
    var partyId = Convert.ToInt32(Console.ReadLine());
    election2023.VoteParty(partyId);
}

void PrintCandidate()
{
    Console.WriteLine("Enter candidate id");
    var candidateId = Convert.ToInt32(Console.ReadLine());
    election2023.PrintResultCandidate(candidateId);
}