using System;
using HappyDevops.AutofacAndAspnetCore3.Dependences;
using Microsoft.AspNetCore.Mvc;

namespace HappyDevops.AutofacAndAspnetCore3.Controllers
{
    [Route("api/sample/")]
    public class SampleGenericInterfaceController : Controller
    {
        private readonly IGenericInterface _component;

        public SampleGenericInterfaceController(IGenericInterface component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        [HttpGet]
        [Route("genericSample")]
        public IActionResult Execute()
        {
            return new ObjectResult(_component.WriteText());
        }
    }
}