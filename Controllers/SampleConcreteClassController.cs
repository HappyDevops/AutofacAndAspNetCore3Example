using System;
using HappyDevops.AutofacAndAspnetCore3.Dependences;
using Microsoft.AspNetCore.Mvc;

namespace HappyDevops.AutofacAndAspnetCore3.Controllers
{
    [Route("api/sample/")]
    public class SampleConcreteClassController : Controller
    {
        private readonly GenericComponent _component;

        public SampleConcreteClassController(GenericComponent component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        [HttpGet]
        [Route("concreteSample")]
        public IActionResult Execute()
        {
            return new ObjectResult(_component.WriteCustomText());
        }
    }
}
