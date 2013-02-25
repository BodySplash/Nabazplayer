using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace Nabazplayer.Core
{
    public class VioletApiResponse
    {
        public string Message
        {
            get { return message; }
        }

        public string Comment
        {
            get { return comment; }
        }

        public IDictionary<string, object> OtherAttributes
        {
            get { return otherAttributes; }
        }


        public VioletApiResponse(Stream content)
        {
            otherAttributes = new Dictionary<string, object>();
            XmlTextReader reader = new XmlTextReader(content);

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "message":
                            reader.Read();
                            message = reader.Value;
                            break;
                        case "comment":
                            reader.Read();
                            comment = reader.Value;
                            break;
                        case "rsp":
                            break;
                        default:
                            string key = reader.Name;
                            reader.Read();
                            otherAttributes.Add(key, reader.Value);
                            break;
                    }
                }


            }

            content.Close();
            reader.Close();
    
        }



        private string message;
        private string comment;
        private IDictionary<string, object> otherAttributes;
    }
}
