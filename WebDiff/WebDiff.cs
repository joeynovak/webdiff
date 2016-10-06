using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImageMagick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Selenium;
using WebDiff.Data;

namespace WebDiff
{
    class WebDiff
    {
        private IWebDriver _webDriver = null;
        public List<String> DomainUrls { get; set; } = new List<String>();
        public List<Url> DomainUrlsAsUrlObjects { get; set; } = new List<Url>();
        public List<String> ExternalUrls { get; set; } = new List<string>();
        private List<String> AllowedDomains { get; set; } = new List<string>();
        public String savePicturesToPath = "";
        public IWebDriver WebDriver
        {
            get
            {
                if (_webDriver == null)
                    _webDriver = getDriver();
                return _webDriver;
            }
            set { _webDriver = value; }
        }



        public WebDiff(params string[] allowedDomains)
        {
            AllowedDomains.AddRange(allowedDomains);
        }
        

        public void crawlUrl(string urlToCrawl, List<string> parentWillCrawl = null)
        {
            
            Url aUrl = new Url() { Uri = urlToCrawl };
            DomainUrlsAsUrlObjects.Add(aUrl);
            DomainUrls.Add(urlToCrawl);
            //Load Page And Capture Time To Load
            DateTime preLoad = DateTime.Now;            
            WebDriver.Navigate().GoToUrl(urlToCrawl);
            aUrl.MsToLoad = (DateTime.Now - preLoad).Milliseconds;            

            //Take Screenshot of Page
            
            String basePath = savePicturesToPath + aUrl.FileNameBase;
            int height = WebDriver.FindElement(By.TagName("body")).Size.Height;
            WebDriver.Manage().Window.Size = new Size(WebDriver.Manage().Window.Size.Width, height + 100);
            ((ITakesScreenshot) WebDriver).GetScreenshot().SaveAsFile(basePath + ".png", ImageFormat.Png);            
            aUrl.PicturePath = basePath + ".png";
            aUrl.HtmlSourcePath = basePath + ".html";            
            File.WriteAllText(aUrl.HtmlSourcePath, WebDriver.PageSource);


            //Save Source Code of Page
            ReadOnlyCollection<IWebElement> links = WebDriver.FindElements(By.TagName("a"));
            List<String> urlsToOnPage = new List<string>();
            foreach (var link in links)
            {
                if (link.GetAttribute("href") != null)
                {
                    urlsToOnPage.Add(link.GetAttribute("href"));
                }                
            }

            List<String> parentsWillCrawl = new List<string>();
            if(parentWillCrawl != null)
                parentsWillCrawl.AddRange(parentWillCrawl);

            parentsWillCrawl.AddRange(urlsToOnPage);

            foreach (var url in urlsToOnPage)
            {                
                if (InAllowedDomain(url) && !DomainUrls.Contains(url) && (parentWillCrawl == null || !parentWillCrawl.Contains(url)))
                {
                    crawlUrl(url, parentWillCrawl);
                }
                else
                {
                    ExternalUrls.Add(url);
                }
            }
        }                                                    

        private bool InAllowedDomain(string url)
        {
            return AllowedDomains.Contains(UrlCleaner.UrlCleaner.GetUri(url).Host);            
        }

        public IWebDriver getDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            
            DesiredCapabilities caps = new DesiredCapabilities();        
            ChromeDriver driver = new ChromeDriver(chromeOptions);
            
            return driver;
        }

        public void Close()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }

        public static CompareResults CompareSessions(Session originalSession, Session newSession)
        {
            String outputPath = Properties.Settings.Default.DefaultPicturePath + "\\" + originalSession.Time.ToFileTimeUtc() + "_" + newSession.Time.ToFileTimeUtc();
            Directory.CreateDirectory(outputPath);
            CompareResults results = new CompareResults(originalSession, newSession);
            List<UrlResults> ListOfUrlResults = new List<UrlResults>();
            foreach (var url in originalSession.Urls)
            {
                UrlResults urlResults = new UrlResults();
                urlResults.OriginalUrl = url;
                MagickImage image = new MagickImage(url.PicturePath);                

                Url url2 = null;
                foreach (Url urla in newSession.Urls)
                {
                    if (urla.Uri == url.Uri)
                    {
                        url2 = urla;
                    }
                }

                if (url2 != null && url2.PicturePath != "")
                {
                    urlResults.NewUrl = url2;
                    MagickImage compareImage = new MagickImage();
                    MagickImage anotherImage = new MagickImage(url2.PicturePath);
                    image.Compare(anotherImage, ErrorMetric.Absolute, compareImage);
                    String compareImagePath = outputPath + "\\" + new FileInfo(url.PicturePath).Name;
                    compareImage.Write(compareImagePath);
                    urlResults.ResultPicturePath = compareImagePath;
                    image.Dispose();
                    anotherImage.Dispose();
                    compareImage.Dispose();
                }
                else
                {
                    urlResults.Result = "No Matching Url In New Session Found";
                }

                ListOfUrlResults.Add(urlResults);
                
            }

            results.UrlResults = ListOfUrlResults.ToArray();

//            foreach (var url in newSession.Urls)
//            {
//                
//            }

            //Foreach url in the original session, compare source and images...
            
            return results;
        }
        
    }


}
