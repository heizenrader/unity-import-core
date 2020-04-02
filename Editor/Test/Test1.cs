using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestPackage
{
    namespace test1
    {
        public class Test1
        {
            public string Value1 { get; set; } = "value1";

            public string GetJson()
            {
                string result = Newtonsoft.Json.JsonConvert.SerializeObject(this);
                return result;
            }
        }
    }
}
