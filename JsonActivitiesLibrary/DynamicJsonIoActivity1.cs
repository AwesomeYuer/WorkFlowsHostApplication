using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Newtonsoft.Json.Linq;
using Microshaoft;

namespace JsonActivitiesLibrary
{

    public sealed class DynamicJsonIoActivity1 : AbstractDynamicJsonIoActivity
    {
        public override DynamicJson ExecuteProcess(NativeActivityContext context)
        {
            DynamicJson parameter = Inputs.Get(context);

            if (parameter.IsDefined("Steps"))
            {
                parameter["Steps"]
            }
            else
            {

            }


            //JArray steps = null; 
            //if (parameter["Steps"] == null)
            //{
            //    steps = new JArray();
            //    parameter["Steps"] = steps;
            //}
            //else
            //{
            //    steps = (JArray)parameter["Steps"];
            //}
            //steps
            //    .Add
            //        (
            //            $"Execute:{this.GetType().Name}@{DateTime.Now}"
            //        );
            return parameter;
        }

        public override DynamicJson OnResumeBookmarkProcess(NativeActivityContext context, Bookmark bookmark)
        {
            DynamicJson parameter = Inputs.Get(context);
            //JArray steps = null;
            //if (parameter["Steps"] == null)
            //{
            //    steps = new JArray();
            //    parameter["Steps"] = steps;
            //}
            //else
            //{
            //    steps = (JArray)parameter["Steps"];
            //}
            //steps
            //    .Add
            //        (
            //            $"Resume:{this.GetType().Name}@{DateTime.Now}"
            //        );
            return parameter;
        }
    }
}
