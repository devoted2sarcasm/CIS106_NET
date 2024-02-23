using inheritance.services;

AutoPolicyInfoRetriever autoPolicyInfoRetriever = new AutoPolicyInfoRetriever();

Console.WriteLine(autoPolicyInfoRetriever.GetGeneralPolicyInfo("12345").PolicyNumber);