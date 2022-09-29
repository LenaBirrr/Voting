Voting.Voting voting = new Voting.Voting();
string votersAddress = "test_address";
Voting.Voting.Choice votersChoice = Voting.Voting.Choice.CANDIDAD_1;
voting.ValidateVoter(votersAddress);
voting.ValidateChoice(ref votersChoice, false);
Console.WriteLine(voting.GetWinner().ToString());


