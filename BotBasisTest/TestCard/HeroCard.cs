using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotBasisTest.TestCard
{
    public static class HeroCard {
      public static List<HeroCard> createTestdata() {



            // Test der Karte
            List<string> urlList = new List<string>();
        urlList.Add("http://www.duophon.com/designs/de/standard/images/footer/Phone_256.png");
                List<CardAction> cardButtons = new List<CardAction>();
        CardAction plButton = new CardAction()
        {
            Value = "https://en.wikipedia.org/wiki/Pig_Latin",
            Type = "openUrl",
            Title = "Ja"
        };
        cardButtons.Add(plButton);
                CardAction plButton2 = new CardAction()
                {
                    Value = "https://en.wikipedia.org/wiki/Pig_Latin",
                    Type = "openUrl",
                    Title = "Nein"
                };
        cardButtons.Add(plButton2);


                //_______




                Activity reply = FrameworkCards.createHeroCard(activity, "Reply", "HeroCard", "Subtitle", "Text der Herocardd", FrameworkCards.createCardImage(urlList), cardButtons);



    }



}
}
