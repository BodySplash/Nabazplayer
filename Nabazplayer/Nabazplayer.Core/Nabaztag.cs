using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Configuration;
using Nabazplayer.Logging;
using System.IO;
using System.Xml;
using System.Drawing;
using Nabazplayer.Core.Events;

namespace Nabazplayer.Core
{
    /// <summary>
    /// Describe a nabaztag
    /// </summary>
    public class Nabaztag
    {
        #region *********************** Constructors ***********************


        public Nabaztag(string serialNumber, string token)
        {
            this.serialNumber = serialNumber;
            this.token = token;
        }

#endregion

        #region *********************** Properties ***********************

        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { serialNumber = value; }
        }

        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        public string Name
        {
            get
            {
                VioletApiResponse response = SendEvent(new Events.ActionEvent(ActionType.GetName));
                return response.OtherAttributes["rabbitName"].ToString();
            }
        }

        public Boolean IsAsleep
        {
            get
            {
                bool retour = true;
                VioletApiResponse response = SendEvent(new Events.ActionEvent(ActionType.GetStatus));
                retour = response.OtherAttributes["rabbitSleep"].ToString() == "YES";
                return retour;
            }
        }

        public string Version
        {
            get
            {
                VioletApiResponse response = SendEvent(new Events.ActionEvent(ActionType.GetVersion));
                return response.OtherAttributes["rabbitVersion"].ToString();
            }
        }

        public NabaztagLed BottomLed
        {
            get { return new NabaztagLed(NabaztagLed.Position.bottom, Color.Black); }
        }

        public NabaztagLed LeftLed
        {
            get { return new NabaztagLed(NabaztagLed.Position.left, Color.Black); }
        }

        public NabaztagLed MiddleLed
        {
            get { return new NabaztagLed(NabaztagLed.Position.middle, Color.Black); }
        }

        public NabaztagLed RightLed
        {
            get { return new NabaztagLed(NabaztagLed.Position.right, Color.Black); }
        }

        public NabaztagLed HighLed
        {
            get { return new NabaztagLed(NabaztagLed.Position.high, Color.Black); }
        }

        public NabaztagEar LeftEar
        {
            get { return new NabaztagEar(NabaztagEar.Position.left); }
        }

        public NabaztagEar RightEar
        {
            get { return new NabaztagEar(NabaztagEar.Position.right); }
        }

        #endregion

        #region *********************** Methods ***********************

        public VioletApiResponse SendEvent(NabaztagEvent nabazEvent)
        {
            NabazLogger.Instance.CurrentLogger.Debug("Building event string");
            return SendEventCore("&" + nabazEvent.GetEventString());    
        }

        public void SendToSleep()
        {
            SendEvent(new Events.ActionEvent(ActionType.FallAsleep));
        }

        public void WakeUp()
        {
            SendEvent(new Events.ActionEvent(ActionType.WakeUp));
        }

        private VioletApiResponse SendEventCore(string queryString)
        {
            Uri uriEvent = new Uri(ConfigurationManager.AppSettings["ApiUrl"] + "?sn=" + serialNumber + "&token=" + token + "&" + queryString);
            NabazLogger.Instance.CurrentLogger.Debug("Calling api: " + uriEvent.AbsoluteUri);

            WebRequest request = HttpWebRequest.Create(uriEvent);
            WebResponse response = request.GetResponse();

            VioletApiResponse retour = new VioletApiResponse(response.GetResponseStream());

            NabazLogger.Instance.CurrentLogger.Debug("Response message: " + retour.Message + " response comment : " + retour.Comment);
            foreach (KeyValuePair<string, object> element in retour.OtherAttributes)
            {
                NabazLogger.Instance.CurrentLogger.Debug("other attributes : " + element.Key + ": " + element.Value.ToString());
            }

            return retour;
        }


        #endregion

        #region *********************** Attributes ***********************

        private string serialNumber;
        private string token;

        #endregion
    }
}
