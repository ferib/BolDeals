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
            request.AddHeader("Cookie", "locale=nl_BE; DYN_USER_ID=20011932588; DYN_USER_CONFIRM=1369350bd835f36c4feada8b990266fa; JSESSIONID=zh9S0g0EQeNxpF6fQQA8NQ**.ps41; shopping_session_id=92cf55f3fa57980deeaa6ca7c47d1508361ea84ad1b4332bfb72c93c4c145223; BUI=b96bqtemdurje2juzgmyypdovkqlzbdp; s_fid=6A0E97A742E07469-0DBC458729696157; _ga=GA1.2.1662260377.1521909782; s_vi=[CS]v1|2D5B400B85311826-60000102A000072A[CE]; hiddenCMV=9; __gads=ID=0acc2c64c839b5b7:T=1521909788:S=ALNI_MaIu2frhPocDinSzlyIMbIdEHMRpg; _gcl_au=1.1.740919869.1552923512; _gcl_aw=GCL.1562781036.CjwKCAjwmZbpBRAGEiwADrmVXkRM6J7WARQJ3ZMh5dFYFYJg2_kytPckt8-1kZ2dBYnW52htM6h8ihoCXoQQAvD_BwE; _gac_UA-89331604-12=1.1562781036.CjwKCAjwmZbpBRAGEiwADrmVXkRM6J7WARQJ3ZMh5dFYFYJg2_kytPckt8-1kZ2dBYnW52htM6h8ihoCXoQQAvD_BwE; bolConsentVersion=3; bolConsentBarShown=0; bolConsentChoices=third-party-cookies#true; bolApplicationSessionId=8e6bc317-a1f8-4d45-b4e4-e6cd22efd4e7; bltgSessionId=d31e4867-5cd6-477b-86b4-4e7b9fe29bd4; P=ps41; abt_aid=2050#2151#2401#2803#2764#1998#2791#2790#2613#2786#1457#1740#2779#1980#2775#1989#2154#2556#2816#2552#2634#2716#2809#2710#2002#2167#2080#2800#2084#1845#2421#2834#2831#1291#2480#2733#2022#2319#2729#2827#2650#2267#2769#2445#2599#2357#2434#2504#1319#2256#2253#2249#1055#2247#2751#2128#2748#2134#2216#2044#2666#2508#2602#2707#2205; abt_aid_session=true; px_page=no%20cms%20page; px_visit=1; px_prop36=xlarge; s_cc=true; cachedAssets=46b7; _gid=GA1.2.210225064.1570473585; px_prop34=price%20overview; px_pp=productOffers; px_nr=1570473775476-Repeat; px_eVar80=%7B%22journey%22%3A2%2C%22page%22%3A13%7D; _gat_gtag_UA_89331604_12=1; bff=1570473792; RT=\"dm=bol.com&si=b3dfff6e-88e1-49d3-a9b7-6c9388e33e9a&ss=1570473580783&sl=15&tt=41921&obo=0&sh=1570473775593%3D15%3A0%3A41921%2C1570473765727%3D14%3A0%3A38003%2C1570473761648%3D13%3A0%3A37334%2C1570473753625%3D12%3A0%3A36773%2C1570473748291%3D11%3A0%3A35939&bcn=%2F%2F684dd308.akstat.io%2F&ld=1570473775593&r=https%3A%2F%2Fwww.bol.com%2Fnl%2Fp%2FFuckThisURL%2F9200000059013779%2Fprijsoverzicht%2F%3F85d1fa0f1967772fc337cfa7aa82b62d&ul=1570473821529\"\n1");

            //request.AddHeader("xxxxxxxxxxxx", "xxxxxxxxxxxxxxxx");
            
            //request.AddHeader("Cookie", "__cfduid=da91b94b8a90114ed900dca70641db7371568723421"); //Dont use cookies since legal shiet wont use it anyways?
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
