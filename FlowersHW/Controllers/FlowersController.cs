using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersHW.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class FlowersController:ControllerBase
    {

        public string Rose()
        {
            return JsonSerializer.Serialize(new { name = "Rose" });
        }
        public string Sunflower()
        {
            return JsonSerializer.Serialize(new { name = "SunFlower" });
        }
        public string Hyacinth()
        {
            return JsonSerializer.Serialize(new { name = "hyacinth" });
        }
        public string Narcissus()
        {
            return JsonSerializer.Serialize(new { name = "narcissus" });
        }
    }
}
