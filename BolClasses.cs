using System;
using System.Collections.Generic;
using System.Text;

namespace BolDeals
{
    public class BolClasses
    {
            
        public class JsBlock
        {
            public bool canary { get; set; }
            public bool inlinePromise { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class AppMetaData
        {
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class PageTitle
        {
            public string title { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Meta
        {
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class ShopReviewMeta
        {
            public string bestRating { get; set; }
            public string reviewCount { get; set; }
            public string ratingValue { get; set; }
            public string name { get; set; }
            public List<string> alternateUrls { get; set; }
            public string url { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class CriticalCssInline
        {
            public string cacheKey { get; set; }
            public bool fullCssLoaded { get; set; }
            public string criticalCssPath { get; set; }
            public string fullCssPath { get; set; }
        }

        public class CssBlock
        {
            public CriticalCssInline criticalCssInline { get; set; }
            public List<string> overrideCss { get; set; }
            public List<string> customCSS { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SeoBlock
        {
            public string canonicalUrl { get; set; }
            public string robots { get; set; }
            public string metaDescription { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class DnsPrefetch
        {
            public List<string> preconnectDomains { get; set; }
            public string cssAssetHost { get; set; }
            public string mediaAssetHost { get; set; }
            public string jsAssetHost { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Head
        {
            public JsBlock jsBlock { get; set; }
            public AppMetaData appMetaData { get; set; }
            public PageTitle pageTitle { get; set; }
            public Meta meta { get; set; }
            public ShopReviewMeta shopReviewMeta { get; set; }
            public CssBlock cssBlock { get; set; }
            public SeoBlock seoBlock { get; set; }
            public DnsPrefetch dnsPrefetch { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class CuiConfig
        {
            public string deviceType { get; set; }
            public string recaptchaSiteKey { get; set; }
            public string authState { get; set; }
            public List<object> abTests { get; set; }
            public bool attachmentsEnabled { get; set; }
            public string pageName { get; set; }
            public string chatrUrl { get; set; }
            public List<object> labels { get; set; }
            public string countryCode { get; set; }
            public bool onLoginPage { get; set; }
            public string csHomeUrl { get; set; }
            public string chatrImageUploadUrl { get; set; }
            public string initializeConversationType { get; set; }
            public bool isFullScreen { get; set; }
        }

        public class ConversationalUi
        {
            public CuiConfig cuiConfig { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class ShopReview
        {
            public string bestRating { get; set; }
            public string reviewCount { get; set; }
            public string ratingValue { get; set; }
        }

        public class Footer
        {
            public bool showFooterLinks { get; set; }
            public ConversationalUi conversationalUi { get; set; }
            public bool showTermsAndConditions { get; set; }
            public ShopReview shopReview { get; set; }
            public bool isBelgianContext { get; set; }
            public bool serviceBarTransparent { get; set; }
            public int currentYear { get; set; }
            public bool showServiceBar { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class MeasurmentProperties
        {
            public int timeInViewMs { get; set; }
            public int percentageItemInView { get; set; }
            public int endpointTimeout { get; set; }
            public string urlBltgEndPoint { get; set; }
            public int workerTimerMs { get; set; }
        }

        public class Config
        {
            public string apiUrl { get; set; }
            public string apiKey { get; set; }
            public List<string> blackList { get; set; }
            public List<string> whiteList { get; set; }
            public string softwareVersion { get; set; }
        }

        public class FootComponent
        {
            public bool partnerSitebarEnabled { get; set; }
            public bool enableGoogleAnalytics { get; set; }
            public bool scrollToTopEnabled { get; set; }
            public string partnerSitebarResourceUrl { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
            public bool? isProduction { get; set; }
            public bool? isHiddenCMVCookieSet { get; set; }
            public MeasurmentProperties measurmentProperties { get; set; }
            public bool? feMeasuringOn { get; set; }
            public string json { get; set; }
            public string apiJsUrl { get; set; }
            public Config config { get; set; }
        }

        public class SelectLogo
        {
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SelectStatus
        {
            public string label { get; set; }
            public SelectLogo selectLogo { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class HeaderBanner
        {
            public List<string> uspItems { get; set; }
            public SelectStatus selectStatus { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SubNavigation2
        {
            public List<object> columns { get; set; }
        }

        public class SubNavigation
        {
            public int amountColumns { get; set; }
            public bool showAsterisk { get; set; }
            public SubNavigation2 subNavigation { get; set; }
            public List<object> backLinks { get; set; }
            public string menuName { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Icon
        {
            public string className { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Category
        {
            public SubNavigation subNavigation { get; set; }
            public string asyncUrl { get; set; }
            public string name { get; set; }
            public Icon icon { get; set; }
            public string href { get; set; }
            public string omnitureDataValue { get; set; }
            public string asyncUrlSmall { get; set; }
        }

        public class Item
        {
            public bool highlight { get; set; }
            public bool openBlank { get; set; }
            public string name { get; set; }
            public bool collapseAfterElement { get; set; }
            public string omnitureDataValue { get; set; }
            public string url { get; set; }
        }

        public class Group
        {
            public string name { get; set; }
            public List<Item> items { get; set; }
        }

        public class Column
        {
            public List<Group> groups { get; set; }
        }

        public class SubNavigation3
        {
            public List<Column> columns { get; set; }
        }

        public class BackLink
        {
            public bool highlight { get; set; }
            public bool openBlank { get; set; }
            public string name { get; set; }
            public bool collapseAfterElement { get; set; }
            public string omnitureDataValue { get; set; }
        }

        public class SubContent
        {
            public bool abTestNoIcons { get; set; }
            public List<Category> categories { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
            public int? amountColumns { get; set; }
            public bool? showAsterisk { get; set; }
            public SubNavigation3 subNavigation { get; set; }
            public List<BackLink> backLinks { get; set; }
            public string menuName { get; set; }
        }

        public class Icon2
        {
            public string className { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class RootItem
        {
            public bool abTestNoIcons { get; set; }
            public List<object> ghostItems { get; set; }
            public bool isMain { get; set; }
            public string name { get; set; }
            public string title { get; set; }
            public SubContent subContent { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
            public Icon2 icon { get; set; }
            public string omnitureDataValue { get; set; }
        }

        public class Link
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class MarketingItem
        {
            public Link link { get; set; }
        }

        public class FlagshipLink
        {
            public string color { get; set; }
            public string subTitle { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class MarketingItems
        {
            public List<MarketingItem> marketingItems { get; set; }
            public FlagshipLink flagshipLink { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SelectLogo2
        {
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SelectStatus2
        {
            public string label { get; set; }
            public SelectLogo2 selectLogo { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class TopNavLink
        {
            public string href { get; set; }
            public string label { get; set; }
            public bool onlyDesktop { get; set; }
        }

        public class TranslateLink
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class AvailableCountry
        {
            public string isoCode { get; set; }
            public string isoCodeLowerCase { get; set; }
            public string label { get; set; }
        }

        public class FooterLinks
        {
            public List<TranslateLink> translateLinks { get; set; }
            public string countryCode { get; set; }
            public string userDisplayName { get; set; }
            public List<AvailableCountry> availableCountries { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class TranslateLink2
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class CountrySelector
        {
            public string countryIsoCode { get; set; }
            public TranslateLink2 translateLink { get; set; }
            public bool showChangePopup { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class NavigationLayout
        {
            public List<RootItem> rootItems { get; set; }
            public MarketingItems marketingItems { get; set; }
            public SelectStatus2 selectStatus { get; set; }
            public bool searchInOffcanvasAbtest { get; set; }
            public List<TopNavLink> topNavLinks { get; set; }
            public FooterLinks footerLinks { get; set; }
            public string userDisplayName { get; set; }
            public string selectUrl { get; set; }
            public CountrySelector countrySelector { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Content
        {
            public List<string> messages { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class NotificationModalLayout
        {
            public bool padded { get; set; }
            public bool narrow { get; set; }
            public Content content { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class DeviceProfile
        {
            public string deviceType { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Link2
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class MarketingItem2
        {
            public Link2 link { get; set; }
        }

        public class FlagshipLink2
        {
            public string color { get; set; }
            public string subTitle { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class MarketingItems2
        {
            public List<MarketingItem2> marketingItems { get; set; }
            public FlagshipLink2 flagshipLink { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class CookieBar
        {
            public bool showConsentBar { get; set; }
            public string consentBarText { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Link3
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class AccountMenu
        {
            public List<Link3> links { get; set; }
            public string label { get; set; }
            public string accountLoginUrl { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Link4
        {
            public string href { get; set; }
            public string label { get; set; }
        }

        public class BasketButton
        {
            public int quantity { get; set; }
            public Link4 link { get; set; }
            public bool showQuantity { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Brand
        {
            public string home { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Option
        {
            public string name { get; set; }
            public string value { get; set; }
            public bool separator { get; set; }
            public bool selected { get; set; }
        }

        public class FormInputValues
        {
            public string defaultSearchContext { get; set; }
            public string suggestFragment { get; set; }
            public string originalSearchContext { get; set; }
            public int searchTermMaxLength { get; set; }
            public List<Option> options { get; set; }
            public string nIds { get; set; }
            public string section { get; set; }
            public string originalSection { get; set; }
            public string appliedSearchContextId { get; set; }
            public string adjustedSection { get; set; }
        }

        public class ScriptValues
        {
            public string searchSuggestionsDomain { get; set; }
            public string searchSuggestionsExperiments { get; set; }
            public string searchSuggestionsSection { get; set; }
            public bool enableVoiceSearch { get; set; }
            public bool enableBrandSuggestions { get; set; }
            public bool showPromotions { get; set; }
        }

        public class DisplayNameMapping
        {
            public string displayName { get; set; }
            public string searchContext { get; set; }
        }

        public class Labels
        {
            public string searchTermPlaceholder { get; set; }
        }

        public class SearchBox
        {
            public bool featuredProductsEnabled { get; set; }
            public bool alwaysShowSearchTermInResults { get; set; }
            public FormInputValues formInputValues { get; set; }
            public ScriptValues scriptValues { get; set; }
            public List<DisplayNameMapping> displayNameMapping { get; set; }
            public bool showSearchContextSelect { get; set; }
            public string variantName { get; set; }
            public Labels labels { get; set; }
            public string templateKey { get; set; }
        }

        public class SearchBar
        {
            public AccountMenu accountMenu { get; set; }
            public BasketButton basketButton { get; set; }
            public Brand brand { get; set; }
            public SearchBox searchBox { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Svgs
        {
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class M2
        {
            public string bltggdefaulttemplate0 { get; set; }
        }

        public class Header
        {
            public HeaderBanner headerBanner { get; set; }
            public NavigationLayout navigationLayout { get; set; }
            public NotificationModalLayout notificationModalLayout { get; set; }
            public DeviceProfile deviceProfile { get; set; }
            public MarketingItems2 marketingItems { get; set; }
            public CookieBar cookieBar { get; set; }
            public SearchBar searchBar { get; set; }
            public bool categoryTreeMenu { get; set; }
            public Svgs svgs { get; set; }
            public string variantName { get; set; }
            public M2 m2 { get; set; }
            public string templateKey { get; set; }
        }

        public class AboutOffer
        {
            public bool shouldShowMore { get; set; }
            public bool isNewProduct { get; set; }
            public string condition { get; set; }
            public string newOr2ndHandHeader { get; set; }
            public string fullComment { get; set; }
            public bool sellerIsBol { get; set; }
            public string shortComment { get; set; }
            public string productQuestionUrl { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SellerRating
        {
            public string sellerRating { get; set; }
            public string sellerRatingClass { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class AboutPrice
        {
            public string deliveryTooltipText { get; set; }
            public bool showDeliveryPopup { get; set; }
            public string addToBasketUrl { get; set; }
            public string deliveryText { get; set; }
            public string productId { get; set; }
            public string price { get; set; }
            public string additionalFeeText { get; set; }
            public bool hasAdditionals { get; set; }
            public string offerId { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class AboutSeller
        {
            public string sellerDisplayName { get; set; }
            public string retourMessage { get; set; }
            public string sellerUrl { get; set; }
            public bool sellerIsBol { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Offer
        {
            public AboutOffer aboutOffer { get; set; }
            public SellerRating sellerRating { get; set; }
            public AboutPrice aboutPrice { get; set; }
            public AboutSeller aboutSeller { get; set; }
        }

        public class Pagination
        {
            public List<object> pagination { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class SortingOption
        {
            public string sortOrder { get; set; }
            public string label { get; set; }
            public string value { get; set; }
            public bool selected { get; set; }
        }

        public class TabsAndSort
        {
            public int newCount { get; set; }
            public bool allActive { get; set; }
            public List<SortingOption> sortingOptions { get; set; }
            public bool secondHandActive { get; set; }
            public int totalCount { get; set; }
            public int secondHandCount { get; set; }
            public bool newActive { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Offers
        {
            public List<Offer> offers { get; set; }
            public bool noPagination { get; set; }
            public Pagination pagination { get; set; }
            public TabsAndSort tabsAndSort { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Rating
        {
            public string score { get; set; }
            public string reviewsText { get; set; }
            public int reviewCount { get; set; }
            public int percentage { get; set; }
        }

        public class Product
        {
            public string seoUrl { get; set; }
            public string imageUrl { get; set; }
            public Rating rating { get; set; }
            public string title { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class BreadcrumbItem
        {
            public string name { get; set; }
            public string href { get; set; }
            public string breadcrumbItemType { get; set; }
            public bool selected { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Breadcrumb
        {
            public string homeUrl { get; set; }
            public string showBroadeningLinkSmall { get; set; }
            public bool showBackButtonItem { get; set; }
            public string homeButtonMeasurementTag { get; set; }
            public List<BreadcrumbItem> breadcrumbItems { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class BrowseHistory
        {
            public string identifier { get; set; }
            public string asyncUrl { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class Content2
        {
            public Offers offers { get; set; }
            public Product product { get; set; }
            public Breadcrumb breadcrumb { get; set; }
            public BrowseHistory browseHistory { get; set; }
            public string bannerHtml { get; set; }
            public string variantName { get; set; }
            public string templateKey { get; set; }
        }

        public class M22
        {
            public string bltgcconstraintemplate0 { get; set; }
        }

        public class RootObject
        {
            public Head head { get; set; }
            public string country { get; set; }
            public Footer footer { get; set; }
            public bool isBelgium { get; set; }
            public List<FootComponent> footComponents { get; set; }
            public Header header { get; set; }
            public bool isMobile { get; set; }
            public Content2 content { get; set; }
            public string variantName { get; set; }
            public M22 m2 { get; set; }
            public string templateKey { get; set; }
        }
    }
}