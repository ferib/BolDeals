using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Deserializers;
using Newtonsoft.Json;

namespace BolDeals
{
    class BolDotCom
    {
        private RestClient HttpClient { get; set; }

        public BolDotCom(RestClient httpClient)
        {
            this.HttpClient = httpClient; //BaseURL: https://www.bol.com/ 
        }

        public BolDotCom()
        {
            this.HttpClient = new RestClient("https://www.bol.com/"); //BaseURL: https://www.bol.com/ 
        }

        public List<BolClasses.Offer> FindOtherSellers(long ProductID)
        {
            //GET https://www.bol.com/nl/p/dagelijkse-kost/9200000059013779/prijsoverzicht/?filter=2ndhand&sortOrder=asc&sort=price HTTP/1.1
            var request = new RestRequest($"nl/p/sorry-not-sorry/{ProductID}/prijsoverzicht/?filter=2ndhand&sortOrder=asc&sort=price", Method.GET);
            //ConfigHeader(ref request);
            IRestResponse response = HttpClient.Execute(request);
            var PageInfo = JsonConvert.DeserializeObject<BolClasses.RootObject>(response.Content);
            int OffersCount = PageInfo.content.offers.offers.Count;

            if(OffersCount > 0)
                Console.WriteLine("---------------------------------------------------");

            List<BolClasses.Offer> OfferList = new List<BolClasses.Offer>();

            for(int i = 0; i < OffersCount; i++)
            {
                var CurrentOffer =  PageInfo.content.offers.offers[i];
                if (CurrentOffer.aboutOffer.sellerIsBol || CurrentOffer.aboutOffer.newOr2ndHandHeader != "Tweedehands")
                    continue;
                OfferList.Add(CurrentOffer);
            }

            return OfferList;
        }

        public void GetProductImage(long ProductID)
        {
            //GET https://s.s-bol.com/imgbase0/imagebase3/thumb/FC/9/7/7/3/9200000059013779.jpg HTTP/1.1
        }

        private void ConfigHeader(ref RestRequest request)
        {
            request.AddHeader("Host:","www.bol.com");
            request.AddHeader("Connection:","keep-alive");
            request.AddHeader("Cache-Control:","max-age=0");
            request.AddHeader("Upgrade-Insecure-Requests:","1");
            request.AddHeader("User-Agent:","Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36");
            request.AddHeader("Sec-Fetch-Mode:","navigate");
            request.AddHeader("Sec-Fetch-User:","?1");
            request.AddHeader("Accept:","text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
            request.AddHeader("Sec-Fetch-Site:","none");
            request.AddHeader("Referer:","https://www.bol.com/nl/p/FuckThisURL/9200000059013779/prijsoverzicht/");
            request.AddHeader("Accept-Encoding:","gzip, deflate, br");
            request.AddHeader("Accept-Language:","nl-NL,nl;q=0.9,en-US;q=0.8,en;q=0.7,de;q=0.6,fr;q=0.5");
/*
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36");
            request.AddHeader("Accept", "*
            /*");
            request.AddHeader("Host", "www.bol.com");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Sec-Fetch-Mode", "navigate");
            request.AddHeader("Sec-Fetch-User", "?1");
            request.AddHeader("Accept-Language", "nl-NL,nl;q=0.9,en-US;q=0.8,en;q=0.7,de;q=0.6,fr;q=0.5");
*/            
        }
    }
    public class BolModules
    {
        public class ContentPage
        {
            //all string since we do not need these
            public string head;
            public string country;
            public string footer;
            public bool isBelgium;
            public string[] footComponents;
            public string header;
            public bool isMobile;
            public Content content;
            public string variantName;
            public string m2;
            public string templateKey;
            //
        }

        public class Content
        {
            public Offers[] offers;
        }

        public class Offers
        {
            public Offer aboutOffer;
            public Rating sellerRating;
            public Price aboutPrice;
            public Seller aboutSeller;

        }
        public class Offer
        {
            public bool shouldShowMore;
            public bool isNewProduct;
            public string condition;
            public string newOr2ndHandHeader;
            public string fullComment;
            public bool sellerIsBol;
            public string shortComment;
            public string productQuestionUrl;
            public string variantName;
            public string templateKey;
        }
    
        public class Rating
        {
            public decimal sellerRating;
            public string sellerRatingClass;
            public string variantName;
            public string templateKey;
        }

        public class Price
        {
            public string deliveryTooltipText;
            public bool showDeliveryPopup;
            public string addToBasketUrl;
            public string deliveryText;
            public long productId;
            public decimal price;
            public string additionalFeeText;
            public bool hasAdditionals;
            public long offerId;
            public string variantName;
            public string templateKey;

        }

        public class Seller
        {
            public string sellerDisplayName;
            public string retourMessage;
            public string sellerUrl;
            public bool sellerIsBol;
            public string variantName;
            public string templateKey;
        }
    }
}
