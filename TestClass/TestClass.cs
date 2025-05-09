using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports;
using HolyQuran.Pages;
using NunitAppiumProj.Core;
using NunitAppiumProj.Pages;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.TestClass
{
    [TestFixture]
    public class TestClass : Base
    {

        [Test, Order(1)]
        public void ALQuranStartup()
        {
            test = Extent.CreateTest("Quran Majeed Fist Session Report");
            var Firstsession = new FirstSession(driver!, test);
            Firstsession.QuranFirstSessionFlow();

        }
        [Test, Order(11)]
        public void ALQuran_1()
        {
            test = Extent.CreateTest("Quran Majeed Module Report");
           var ALQuran = new ALQuran(driver!, test);
            ALQuran.QuranMajeedModule();

        }
        [Test, Order(2)]
        public void QiblaFinder_2()
        {
            test = Extent.CreateTest("QiblaFinder Test Case");
            var QF = new QiblaFinder(driver!, test);
            QF.QiblaFinderT();
        }

       

          [Test, Order(3)]
        public void DigitalTasbeeh_3()
        {
            test = Extent.CreateTest("DigitalTasbeeh  Report");
               var DT = new DigitalTasbeeh(driver!, test);
                DT.DigitalTasbeehT();
        }

        [Test, Order(4)]
        public void Azkar_4()
        {
            test = Extent.CreateTest("DigitalTasbeeh  Report");

              var  Azkar = new Azkar(driver!, test);
                Azkar.AzkarTest();
        }

            [Test, Order(5)]
            public void PrayerTimesM()
        {
            test = Extent.CreateTest("Prayer Times test");
                         var  PrayerTimes = new PrayerTimes(driver, test);
                PrayerTimes.PrayerTimesTest();
           

        }

        [Test, Order(6)]
        public void HijriCalender()
        {
            test = Extent.CreateTest("Prayer Times test");
        
                var Hijrical = new HijriCalender(driver, test);
                Hijrical.CalenderTest();
           

        }

        [Test, Order(7)]
        public void HajjAndUmrahTest()
        {
            test = Extent.CreateTest("Hajj and Umrah Test");
                var hajjUmrah = new HajjandUmrahSection(driver, test);

                test.Log(Status.Info, "Executing Hajj Section Test");
                hajjUmrah.HajjSectionTest();
                test.Log(Status.Pass, "Hajj Section Test completed");

                test.Log(Status.Info, "Executing Umrah Section Test");
                hajjUmrah.UmrahSectionTest();
                test.Log(Status.Pass, "Umrah Section Test completed");

                test.Log(Status.Info, "Famous places of Makkah Test");
                hajjUmrah.FamousPlacesofMakkahTest();

                test.Log(Status.Info, "Famous places of Madina Test");
                hajjUmrah.FamousPlacesofMedinahTest();

                test.Log(Status.Info, "Executing Qibla Test");
                hajjUmrah.QiblaDirectionTest();
          
        }

        [Test, Order(8)]
        public void MasjidFinder()
        {
            test = Extent.CreateTest("Prayer Times test");   
                test.Log(Status.Info, "Starting Masjid Finder");
                var MasjidF = new Masjid(driver, test);
                MasjidF.MasjidTest();
        }

        [Test, Order(9)] 
        public void NamesSectionTestCase()
        {
            test = Extent.CreateTest("Names of Allah and Prophet Test");
         
                test.Log(Status.Info, "Starting Names Section Test");
               var  namesSection = new Names99((AndroidDriver)driver!, test);
                namesSection.NamesSectionTest();           
        }

        [Test, Order(10)] 
        public void MenuandPremium()
        {
            test = Extent.CreateTest("MenuandPremium");

            test.Log(Status.Info, "Starting Names Section Test");
            var settings = new Settings((AndroidDriver)driver!, test);
            settings.PremiumandMenuMethod();
        }

    }
    }