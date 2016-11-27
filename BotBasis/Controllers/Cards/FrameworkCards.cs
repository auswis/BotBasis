using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotBasis.Controllers.Cards
{
    //Hero Card	A card  A Card with one big image	Single or Carousel
    //Thumbnail Card	A card with a single small image	Single or Carousel
    //Receipt Card	    A card that lets the user deliver an invoice or receipt	Single
    //Sign-In Card	    A card that lets the bot initiate a sign-in procedure	Single

    // Alle Karten geben eine Activity zurück mit der einzelenen Karte als Attachment

    public static class FrameworkCards
    {


        //Property	Description
        //________________________
        //Title	    Title of card
        //Subtitle	Link for the title
        //Text	    Text of the card
        //Images[]	For a hero card, a single image is supported
        //Buttons[]	Hero cards support one or more buttons
        //Tap	    An action to take when tapping on the card

        public static Activity createHeroCard(Activity activity, string replyMessage, string title, string subtile, string text, List<CardImage>cardImage, List<CardAction>cardButton)
        {
            Activity replyToConversation = activity.CreateReply(replyMessage);
            replyToConversation.Recipient = activity.From;
            replyToConversation.Type = "message";
            replyToConversation.Attachments = new List<Attachment>();
           
            HeroCard plCard = new HeroCard()
            {
                Title = title,
                Subtitle = subtile,
                Images = cardImage,
                Buttons = cardButton,
                Text = text,
                Tap = null
                
            };
            Attachment plAttachment = plCard.ToAttachment();
            replyToConversation.Attachments.Add(plAttachment);
            
            return replyToConversation;
        }


        public static List<CardImage> createCardImage(List<string>Url)
        {
            List<CardImage> cardImages = new List<CardImage>();

            foreach(string element in Url)
            {
                cardImages.Add(new CardImage(url: element));
            }

            return cardImages;
        }

    }
}