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
            cardImages.Add(new CardImage(url: "http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons-256/ultra-glossy-silver-buttons-icons-symbols-shapes/021300-ultra-glossy-silver-button-icon-symbols-shapes-power-button.png"));

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
            cardImages.Add(new CardImage(url: "http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons-256/ultra-glossy-silver-buttons-icons-symbols-shapes/021300-ultra-glossy-silver-button-icon-symbols-shapes-power-button.png"));
            cardImages.Add(new CardImage(url: "http://icons.veryicon.com/ico/System/iOS7%20Minimal/Shopping%20Card%20in%20use.ico"));

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