using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nabazplayer.Core;
using Nabazplayer.Core.Events;
using Nabazplayer.Logging;
using System.Drawing;
using System.Configuration;


namespace Nabazplayer.Test
{
    [TestFixture()]
    public class EventsTest
    {

        [Test()]
        public void CanUseMultipleEvents()
        {
            
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);


            NabaztagEventColllection events = new NabaztagEventColllection();
            events.AddEvent(new Core.Events.LeftEarPositionEvent(0));
            events.AddEvent(new Core.Events.RightEarPositionEvent(0));
            events.AddEvent(new TextEvent("allez Julie!!! On se réveille un peu. Et oui je te parle depuis mon pc.", TextEvent.VoiceType.bruno22k));


            myNabaz.SendEvent(events);


        }

        [Test()]
        [ExpectedException()]
        public void CantPassWrongPositionToLeftEar()
        {
            Core.Events.LeftEarPositionEvent test = new Nabazplayer.Core.Events.LeftEarPositionEvent(20);
        }

        [Test()]
        [ExpectedException()]
        public void CantPassWrongPositionToRightEar()
        {
            Core.Events.RightEarPositionEvent test = new Nabazplayer.Core.Events.RightEarPositionEvent(20);
        }

        [Test()]
        public void CanSendMessage()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            VioletApiResponse respone =  myNabaz.SendEvent(new Core.Events.SendMessageEvent(1));
            Assert.AreNotEqual(respone.Message, "MESSAGENOTSEND");

        }

        [Test()]
        public void CanSendTts()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            Core.Events.TextEvent textEvent = new Nabazplayer.Core.Events.TextEvent("ceci est un test");
            textEvent.Voice = Nabazplayer.Core.Events.TextEvent.VoiceType.bruno22k;
            textEvent.Speed = 200;


            VioletApiResponse response =  myNabaz.SendEvent(textEvent);

            Assert.AreEqual(response.Message, "TTSSEND");
            
        }

        [Test()]
        public void CanSendEarChoregraphy()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            ChoregraphyEvent chorEvent = new ChoregraphyEvent("BodySplash chor", 10);

            chorEvent.AddCommand(new ChoregraphyEarCommand(myNabaz.LeftEar.WithAngleAndDirection(60, NabaztagEar.Direction.CouterClockwise), 10));
            chorEvent.AddCommand(new ChoregraphyEarCommand(myNabaz.RightEar.WithAngleAndDirection(60, NabaztagEar.Direction.Clockwise), 10));
            myNabaz.SendEvent(chorEvent);
        }

        [Test()]
        public void CanSendLedChoregraphy()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            ChoregraphyEvent chorEvent = new ChoregraphyEvent("BodySplash chor", 10);

            ChoregraphyLedCommand firstCommand = new ChoregraphyLedCommand(myNabaz.MiddleLed.WithColor(Color.Green), 10);
            firstCommand.Time = 1;

            ChoregraphyLedCommand secondCommand = new ChoregraphyLedCommand(myNabaz.LeftLed.WithColor(Color.Red), 10);
            secondCommand.Time = 2;




            chorEvent.AddCommand(firstCommand);
            chorEvent.AddCommand(secondCommand);

            myNabaz.SendEvent(chorEvent);
        }

        [Test()]
        public void CanSendEarAndLedChor()
        {
            Nabaztag myNabaz = new Nabaztag(ConfigurationManager.AppSettings["SerialNumber"], ConfigurationManager.AppSettings["Token"]);
            ChoregraphyEvent chorEvent = new ChoregraphyEvent("complex chor", 10);
            chorEvent.AddCommand(new ChoregraphyEarCommand(myNabaz.LeftEar.WithAngleAndDirection(80, NabaztagEar.Direction.Clockwise), 10));
            chorEvent.AddCommand(new ChoregraphyEarCommand(myNabaz.RightEar.WithAngleAndDirection(80, NabaztagEar.Direction.CouterClockwise), 20));

            chorEvent.AddCommand(new ChoregraphyLedCommand(myNabaz.HighLed.WithColor(Color.Red), 25));
            chorEvent.AddCommand(new ChoregraphyLedCommand(myNabaz.MiddleLed.WithColor(Color.Blue), 25));
            chorEvent.AddCommand(new ChoregraphyLedCommand(myNabaz.BottomLed.WithColor(Color.DarkBlue), 30));

            chorEvent.AddCommand(new ChoregraphyEarCommand(myNabaz.LeftEar.WithAngleAndDirection(80, NabaztagEar.Direction.CouterClockwise), 40));

            myNabaz.SendEvent(chorEvent);
            
            
        }

    
    }
}
