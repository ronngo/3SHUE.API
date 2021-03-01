using _3SHUE.BAL.Interface.InCompany;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _3SHUE.API.Controllers
{
    [ApiController]
    public class IntroduceCompanyController : ControllerBase
    {

        private readonly IIntroduceCompanyService introduceCompany;

        public IntroduceCompanyController(IIntroduceCompanyService introduceCompany)
        {
            this.introduceCompany = introduceCompany;
        }



        [HttpGet]
        [Route("/api/introduce/Create")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await introduceCompany.Get());
        }
    }

}
