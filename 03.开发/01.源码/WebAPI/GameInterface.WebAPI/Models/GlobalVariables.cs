using GameInterface.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameInterface.WebAPI.Models
{
    public class GlobalVariables
    {
        public static JsonUser CurrentUser { get; set; }
    }
}