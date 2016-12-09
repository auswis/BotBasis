using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BotBasis.Controllers.Cards.TestCard
{
    public class TestFrameworkCards
    {

        public static Activity createHeroExample( Activity activity)
        {
            List<CardImage> cardImages = new List<CardImage>();
            cardImages.Add(new CardImage(url: "http://image.flaticon.com/teams/new/137-vectors-market.jpg"));

            List<CardAction> cardButtons = new List<CardAction>();

            CardAction plButton = new CardAction()
            {
                Value = "Ja",
                Type = "imBack",
                Title = "Ja"
            };
            cardButtons.Add(plButton);

            CardAction plButton2 = new CardAction()
            {
                Value = "Nein",
                Type = "imBack",
                Title = "Nein"
            };
            cardButtons.Add(plButton2);


            Activity reply = FrameworkCards.createHeroCard(activity, "Reply Message", "HeroCard", "Subtitle","Text der HeroCard", cardImages,cardButtons);

            return reply;
        }

        public static Activity createThumbnailExample(Activity activity)
        {
            List<CardImage> cardImages = new List<CardImage>();
            cardImages.Add(new CardImage(url: "http://image.flaticon.com/teams/new/1-freepik.jpg"));

            List<CardAction> cardButtons = new List<CardAction>();

            CardAction plButton = new CardAction()
            {
                Value = "Ja",
                Type = "imBack",
                Title = "Ja"
            };
            cardButtons.Add(plButton);

            CardAction plButton2 = new CardAction()
            {
                Value = "Nein",
                Type = "imBack",
                Title = "Nein"
            };
            cardButtons.Add(plButton2);


            Activity reply = FrameworkCards.createThumbnailCard(activity, "Reply Message", "Thumbnail", "Subtitle", "Text der ThumbnailCard", cardImages, cardButtons);

            return reply;
        }

       

    }
}