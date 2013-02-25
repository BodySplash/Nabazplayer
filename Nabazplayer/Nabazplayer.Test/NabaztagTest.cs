using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nabazplayer.Core;
using Nabazplayer.Logging;
using System.Configuration;

namespace Nabazplayer.Test
{
    [TestFixture()]
    public class NabaztagTest
    {

        [Test()]
        public void CanCreateNabaztag()
        {

            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            Assert.IsNotNull(myNabaz);

            Assert.AreEqual(myNabaz.SerialNumber, "00904BBD9BD2");
            Assert.AreEqual(myNabaz.Token, "1168842105");
        }

        [Test()]
        public void CanSetProperties()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);

            myNabaz.Token = "testToken";
            Assert.AreEqual(myNabaz.Token, "testToken");

            myNabaz.SerialNumber = "testSerial";
            Assert.AreEqual(myNabaz.SerialNumber, "testSerial");
        }

        [Test()]
        public void CanSendEvent()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            VioletApiResponse response = myNabaz.SendEvent(new MockEvent());
        }

        [Test()]
        public void CanWakeUp()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            myNabaz.WakeUp();
        }

        [Test()]
        public void CanSendNabaztagToSleep()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            myNabaz.SendToSleep();
        }

        [Test()]
        public void CanGetStatus()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            myNabaz.SendToSleep();
            Assert.IsTrue(myNabaz.IsAsleep);
        }

        [Test()]
        public void CanGetVersion()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            Assert.AreEqual(myNabaz.Version, "V1");
        }

        [Test()]
        public void CanGetName()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            Assert.AreEqual(myNabaz.Name, "NabaSplash");
        }


    }
}
