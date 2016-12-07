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


        //
        //Property	Description
        //________________________
        //Title	    Title of card
        //Subtitle	Link for the title
        //Text	    Text of the card
        //Images[]	For a hero card, a single image is supported
        //Buttons[]	Hero cards support one or more buttons
        //Tap	    An action to take when tapping on the card

        public static Activity createThumbnailCard(Activity activity, string replyMessage, string title, string subtile, string text, List<CardImage> cardImage, List<CardAction> cardButton)
        {
            Activity replyToConversation = activity.CreateReply(replyMessage);
            replyToConversation.Recipient = activity.From;
            replyToConversation.Type = "message";
            replyToConversation.Attachments = new List<Attachment>();

            ThumbnailCard plCard = new ThumbnailCard()
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

        //Property	Description
        //________________________
        //Title	    Title of card
        //Facts[]	Key Value pair list of information to display on the receipt
        //Items[]	The list of ReceiptItem objects on this receipt
        //Tap   	An action to take when tapping on the card
        //Tax	    Tax on this receipt
        //VAT	    Any additional VAT on this receipt
        //Total 	The Sum Total of the Receipt
        //Buttons[]	Hero cards support one or more buttons

        public static Activity createReceiptCard()
        {
            return null;
        }

        public static Activity createCarusel(Activity message)
        {

            Activity replyToConversation = message.CreateReply("Should go to conversation, with a carousel");
            replyToConversation.Recipient = message.From;
            replyToConversation.Type = "message";
            //replyToConversation.AttachmentLayout = "carousel";
            replyToConversation.Attachments = new List<Attachment>();
            Dictionary<string, string> cardContentList = new Dictionary<string, string>();
            cardContentList.Add("PigLatin", "http://icons.veryicon.com/ico/System/iOS7%20Minimal/Shopping%20Card%20in%20use.ico");
            cardContentList.Add("Pork Shoulder", "http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons-256/ultra-glossy-silver-buttons-icons-symbols-shapes/021300-ultra-glossy-silver-button-icon-symbols-shapes-power-button.png");
            foreach (KeyValuePair<string, string> cardContent in cardContentList)
            {
                List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: cardContent.Value));
                List<CardAction> cardButtons = new List<CardAction>();
                CardAction plButton = new CardAction()
                {
                    Value = $"https://en.wikipedia.org/wiki/{cardContent.Key}",
                    Type = "openUrl",
                    Title = "WikiPedia Page"
                };
                cardButtons.Add(plButton);
                HeroCard plCard = new HeroCard()
                {
                    Title = $"I'm a hero card about {cardContent.Key}",
                    Subtitle = $"{cardContent.Key} Wikipedia Page",
                    Images = cardImages,
                    Buttons = cardButtons
                };
                Attachment plAttachment = plCard.ToAttachment();
                replyToConversation.Attachments.Add(plAttachment);
            }
            replyToConversation.AttachmentLayout = AttachmentLayoutTypes.Carousel;
            
            return replyToConversation;
        }

    }
}