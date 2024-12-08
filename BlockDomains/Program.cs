// See https://aka.ms/new-console-template for more information

using BlockDomains;

var a = new[]
{
    "unlock.microvirus.md",
    "visitwar.com",
    "visitwar.de",
    "fruonline.co.uk",
    "australia.open.com",
    "credit.card.us",
};

var b = new[]
{
    "microvirus.md",
    "visitwar.de",
    "piratebay.co.uk",
    "list.stolen.credit.card.us",
};
var result = Solution.Check(a, b);

Console.WriteLine(string.Join(',', result));