using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCs
{
    class DemoCs
    {
        [Serializable]
        public class InformationBucket
        {
            public int Value;
            public string Message;
        }
        public class DemoClas:MarshalByRefObject
        {
            private int Value =0;
            private string Message="";

            public void SetValue(int InputValue)
            {
                Value = InputValue;
                Console.WriteLine("Demo Class : setting Value to {0}", InputValue);
            }
            
            public void SetMessage(string InputMessage)
            {
                Message = InputMessage;
                Console.WriteLine("Demo Class : Setting Message to {0}", InputMessage);
            }

            public InformationBucket GetCurrentInformation()
            {
                InformationBucket Bucket = new InformationBucket();
                Bucket.Message = Message;
                Bucket.Value = Value;
                return Bucket;
            }

        }


    }
}
