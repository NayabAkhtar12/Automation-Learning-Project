using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using NunitAppiumProj.Pages;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.TestClass
{
    /* Oops: pillars 
     * Abstraction   : AppiumDriver Interface, 
     * Inheritance   : from Base class getting the driver instance
     * Encpsulation  : Making the members private/ Protected 
     * Polymorphism  : Implicit wait, time in minutes, seconds, Hours, action class, assert class
     *
      */
    [TestFixture]
    public class TestClass : Base
    {
        private ALQuran? ALQuran;
        private QiblaFinder? QF;
        private DigitalTasbeeh? DT;
        private Azkar Azkar;
        private PrayerTimes? PrayerTimes;
        private HijriCalender Hijrical;
        private Masjid MasjidF;


        [Test, Order(1)]
        public void ALQuran_1()
        {
            test = Extent.CreateTest("Quran Majeed Module Report");
                test.Log(Status.Info, "Starting Quran Majeed Test Case");
                ALQuran = new ALQuran(driver!, test);
                ALQuran.QuranMajeedModule();
          
        }
        [Test, Order(2)]
        public void QiblaFinder_2()
        {
            test = Extent.CreateTest("QiblaFinder  Report");

            try
            {
                test.Log(Status.Info, "Starting QiblaFinder Test Case");

                QF = new QiblaFinder(driver!, test);
                QF.QiblaFinderT();
                test.Log(Status.Info, "Completed QiblaFinder Test Case");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured in Test case 2{e}");
                test.Log(Status.Fail, $"Failed :  Exception: {e.Message}");

                throw;
            }
        }

        [Test, Order(3)]
        public void DigitalTasbeeh_3()
        {
            test = Extent.CreateTest("DigitalTasbeeh  Report");

            try
            {
                test.Log(Status.Info, "Starting DigitalTasbeeh Test Case");
                if (driver == null)
                {
                    throw new InvalidOperationException("Driver is not initialized.");
                }
                DT = new DigitalTasbeeh(driver!, test);
                DT.DigitalTasbeehT();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured in Test case 3{e}");
                throw;
            }
        }

        [Test, Order(4)]
        public void Azkar_4()
        {
            test = Extent.CreateTest("DigitalTasbeeh  Report");

            try
            {
                test.Log(Status.Info, "Starting DigitalTasbeeh Test Case");

                Azkar = new Azkar(driver!, test);
                Azkar.AzkarTest();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured in Test case 3{e}");
                throw;
            }
        }

            [Test, Order(5)]
            public void PrayerTimesM()
        {
            test = Extent.CreateTest("Prayer Times test");
            try
            {
                test.Log(Status.Info, "Starting Prayer Times");
                PrayerTimes = new PrayerTimes(driver, test);
                PrayerTimes.PrayerTimesTest();
                test.Log(Status.Info, "Completed Prayer Times");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured {e}");
                throw;
            }

        }

        [Test, Order(6)]
        public void HijriCalender()
        {
            test = Extent.CreateTest("Prayer Times test");
            try
            {
                test.Log(Status.Info, "Starting Hijri Calender");
                Hijrical = new HijriCalender(driver, test);
                Hijrical.CalenderTest();
                test.Log(Status.Info, "Completed Hijri calender");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured {e}");
                throw;
            }

        }

        [Test, Order(7)]
        public void HajjAndUmrahTest()
        {
            test = Extent.CreateTest("Hajj and Umrah Test");
            try
            {
                test.Log(Status.Info, "Starting Hajj and Umrah Section Test");

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
                test.Log(Status.Pass, "Qibla Test completed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, $"Test failed with exception: {e.Message}");
                Console.WriteLine($"Exception occurred: {e}");
                throw;
            }
        }

        [Test, Order(8)]
        public void MasjidFinder()
        {
            test = Extent.CreateTest("Prayer Times test");
            try
            {
                test.Log(Status.Info, "Starting Masjid Finder");
                MasjidF = new Masjid(driver, test);
                MasjidF.MasjidTest();
                test.Log(Status.Info, "Completed Masjid Finder");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured {e}");
                throw;
            }

        }

        [Test, Order(9)] // Change the order number as needed
        public void NamesSectionTestCase()
        {
            test = Extent.CreateTest("Names of Allah and Prophet Test");
            try
            {
                test.Log(Status.Info, "Starting Names Section Test");
               var  namesSection = new Names99((AndroidDriver)driver!, test);
                namesSection.NamesSectionTest();
                test.Log(Status.Pass, "Completed Names Section Test Successfully");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, $"Test Failed with Exception: {e}");
                Console.WriteLine($"Exception occurred: {e}");
                throw;
            }
        }
    }
    }