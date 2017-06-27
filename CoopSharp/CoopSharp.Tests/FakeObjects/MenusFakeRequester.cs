using System.Collections.Generic;
using System.Threading.Tasks;
using CoopSharp;

namespace CoopSharp.Tests.FakeObjects
{
  public class MenusFakeRequester : IRequester
  {
    public async Task<string> Get(string resource, IDictionary<string, string> queryParameters = null)
    {
      return RESULT;
    }

    private const string RESULT = @"{
  ""results"": [
    {
      ""menu"": [
        ""Kalbsbratwurst"", 
        ""Zwiebelsauce"", 
        ""R\u00f6sti"", 
        ""Saisonsalat""
      ], 
      ""price"": 13.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Wochenmen\u00fc""
    }, 
    {
      ""menu"": [
        ""Fish and Chips"", 
        ""Tartarsauce"", 
        ""Pommes frites""
      ], 
      ""price"": 9.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Special""
    }, 
    {
      ""menu"": [
        ""Tofu-Piccata"", 
        ""Spaghetti"", 
        ""Tomatensauce"", 
        ""Saisonsalat"", 
        ""(Vegetarisch)""
      ], 
      ""price"": 11.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Vegi-Men\u00fc""
    }, 
    {
      ""menu"": [
        ""Hackbraten"", 
        ""Pfeffersauce"", 
        ""Kartoffelgratin"", 
        ""Saisonsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Men\u00fc Tradition""
    }, 
    {
      ""menu"": [
        ""Rinds-Hohr\u00fcckensteak"", 
        ""Knoblauchbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 17.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Schweins-"", 
        ""Stotzenschnitzel"", 
        ""Kr\u00e4uterbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 14.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Penne"", 
        ""Tagessauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 10.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Lasagne Verdura"", 
        ""mit Gem\u00fcse"", 
        ""Tomatensauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498521600.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Kalbsbratwurst"", 
        ""Zwiebelsauce"", 
        ""R\u00f6sti"", 
        ""Saisonsalat""
      ], 
      ""price"": 13.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Wochenmen\u00fc""
    }, 
    {
      ""menu"": [
        ""Fish and Chips"", 
        ""Tartarsauce"", 
        ""Pommes frites""
      ], 
      ""price"": 9.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Special""
    }, 
    {
      ""menu"": [
        ""Fr\u00fchlingsrollen"", 
        ""Sweet Chili Sauce"", 
        ""garniert"", 
        ""Saisonsalat"", 
        ""Glasnudelsalat"", 
        ""(Vegan)""
      ], 
      ""price"": 11.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Vegi-Men\u00fc""
    }, 
    {
      ""menu"": [
        ""Holzf\u00e4llersteak"", 
        ""Madagaskarsauce"", 
        ""Butterr\u00f6sti"", 
        ""Erbsen""
      ], 
      ""price"": 14.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Men\u00fc Tradition""
    }, 
    {
      ""menu"": [
        ""Kalbsschnitzel"", 
        ""paniert"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 18.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Schweins-"", 
        ""Stotzenschnitzel"", 
        ""Kr\u00e4uterbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 14.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Penne"", 
        ""Tagessauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 10.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Lasagne Verdura"", 
        ""mit Gem\u00fcse"", 
        ""Tomatensauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498608000.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Kalbsbratwurst"", 
        ""Zwiebelsauce"", 
        ""R\u00f6sti"", 
        ""Saisonsalat""
      ], 
      ""price"": 13.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Wochenmen\u00fc""
    }, 
    {
      ""menu"": [
        ""Fish and Chips"", 
        ""Tartarsauce"", 
        ""Pommes frites""
      ], 
      ""price"": 9.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Special""
    }, 
    {
      ""menu"": [
        ""Gyozas"", 
        ""Fried rice"", 
        ""Saisonsalat"", 
        ""(Vegetarisch)""
      ], 
      ""price"": 11.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Vegi-Men\u00fc""
    }, 
    {
      ""menu"": [
        ""Rahmschnitzel"", 
        ""Aargauer Art"", 
        ""Schupfnudeln"", 
        ""Saisonsalat""
      ], 
      ""price"": 14.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Men\u00fc Tradition""
    }, 
    {
      ""menu"": [
        ""Rinds-Hohr\u00fcckensteak"", 
        ""Knoblauchbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 17.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Lammspiess"", 
        ""Rosmarinjus"", 
        ""Beilagen nach Wahl""
      ], 
      ""price"": 19.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Penne"", 
        ""Tagessauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 10.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Lasagne Verdura"", 
        ""mit Gem\u00fcse"", 
        ""Tomatensauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498694400.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Kalbsbratwurst"", 
        ""Zwiebelsauce"", 
        ""R\u00f6sti"", 
        ""Saisonsalat""
      ], 
      ""price"": 13.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Wochenmen\u00fc""
    }, 
    {
      ""menu"": [
        ""Fish and Chips"", 
        ""Tartarsauce"", 
        ""Pommes frites""
      ], 
      ""price"": 9.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Special""
    }, 
    {
      ""menu"": [
        ""Halloumi mit Quinoa"", 
        ""Ratatouille"", 
        ""Saisonsalat"", 
        ""(Vegetarisch)""
      ], 
      ""price"": 11.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Vegi-Men\u00fc""
    }, 
    {
      ""menu"": [
        ""Calamares im Bierteig"", 
        ""Tartarsauce"", 
        ""Pommes frites"", 
        ""Saisonsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Men\u00fc Tradition""
    }, 
    {
      ""menu"": [
        ""Lachssteak"", 
        ""Knoblauchbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 14.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Lammspiess"", 
        ""Rosmarinjus"", 
        ""Beilagen nach Wahl""
      ], 
      ""price"": 19.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Penne"", 
        ""Tagessauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 10.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Lasagne Verdura"", 
        ""mit Gem\u00fcse"", 
        ""Tomatensauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498780800.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Kalbsbratwurst"", 
        ""Zwiebelsauce"", 
        ""R\u00f6sti"", 
        ""Saisonsalat""
      ], 
      ""price"": 13.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""Wochenmen\u00fc""
    }, 
    {
      ""menu"": [
        ""Fish and Chips"", 
        ""Tartarsauce"", 
        ""Pommes frites""
      ], 
      ""price"": 9.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""Special""
    }, 
    {
      ""menu"": [
        ""Vegi-Men\u00fc Surprise""
      ], 
      ""price"": 11.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""Vegi-Men\u00fc""
    }, 
    {
      ""menu"": [
        ""Rinds-Hohr\u00fcckensteak"", 
        ""Knoblauchbutter"", 
        ""\""Fitnessteller\""""
      ], 
      ""price"": 17.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Lammspiess"", 
        ""Rosmarinjus"", 
        ""Beilagen nach Wahl""
      ], 
      ""price"": 19.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""vom Grill""
    }, 
    {
      ""menu"": [
        ""Penne"", 
        ""Tagessauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 10.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""Pasta""
    }, 
    {
      ""menu"": [
        ""Lasagne Verdura"", 
        ""mit Gem\u00fcse"", 
        ""Tomatensauce"", 
        ""Men\u00fcsalat""
      ], 
      ""price"": 12.95, 
      ""timestamp"": 1498867200.0, 
      ""title"": ""Pasta""
    }
  ]
}
";
  }
}
