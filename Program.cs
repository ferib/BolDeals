using System;
using System.Threading;

namespace BolDeals
{

        class Program
        {
            static void Main(string[] args)
            {
                DiscordWebhookHandler discordWebhookHandler = new DiscordWebhookHandler("https://discordapp.com/api/webhooks/633400880842014765/xdF35WlBb21G-fNraDQ-4uGn5wxmHsUCDE4o7DNcyPTtanNV4XNIZxzov5KHXYOZpoj-");
                var bol = new BolDotCom();
                long[] ItemWatchlist = {
                                    9200000120047459, //Apple Watch Series5 Roze 44mm
                                    9200000120047461, //Apple Watch Series5 Roze 40mm
                                    9200000120046723, //Apple Watch Series5 Spacegrey 44mm
                                    9200000120046721, //Apple Watch Series5 Spacegrey 40mm
                                    9200000120049483, //Apple Watch Series5 wit 44mm
                                    9200000120049485, //Apple Watch Series5 wit 40mm
                                    9200000059013779  //Kook boek, jeroen meeus
                                    };
                string[] ItemNameList = {
                                    "Apple Watch Series 5 Roze 44m",
                                    "Apple Watch Series 5 Roze 40m",
                                    "Apple Watch Series 5 Spacegrey 44m",
                                    "Apple Watch Series 5 Spacegrey 40m",
                                    "Apple Watch Series 5 wit 44m",
                                    "Apple Watch Series 5 wit 40m",
                                    "Kook boek, jeroen meus"
                                    };

                while (true)
                {
                    Console.WriteLine("Scanning All...");
                    for (int i = 0; i < ItemWatchlist.Length; i++)
                    {
                        Console.WriteLine("Scanning: " + ItemNameList[i]);
                        var OfferList = bol.FindOtherSellers(ItemWatchlist[i]);
                        if (OfferList.Count > 0)
                        {
                            for (int j = 0; j < OfferList.Count; j++)
                            {
                                string NotifyMsg =
                                "Seller: " + OfferList[j].aboutSeller.sellerDisplayName + "\n" +
                                "Condition: " + OfferList[j].aboutOffer.condition + "\n" +
                                "Price: " + OfferList[j].aboutPrice.price + " - " + OfferList[j].aboutPrice.additionalFeeText + "\n" +
                                "Comment: " + OfferList[j].aboutOffer.fullComment + "\n" + "---------------------------------------------------";
                                Console.WriteLine(NotifyMsg);
                                discordWebhookHandler.SendMessage(NotifyMsg);
                                Thread.Sleep(1000);
                            }

                        }
                        Thread.Sleep(500);
                    }
                    Console.WriteLine("Sleeping for 5 minutes..");
                    Thread.Sleep(5 * 60 * 1000);
                }

        }
    }
}
