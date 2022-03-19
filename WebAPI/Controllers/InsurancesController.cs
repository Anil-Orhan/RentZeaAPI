using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancesController : ControllerBase
    {
        private IInsuranceManager _insuranceManager;

        public InsurancesController(IInsuranceManager insuranceManager)
        {
            _insuranceManager = insuranceManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _insuranceManager.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _insuranceManager.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Insurance insurance)
        {
            var result = _insuranceManager.Add(insurance);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Insurance insurance)
        {
            var result = _insuranceManager.Update(insurance);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Insurance insurance)
        {
            var result = _insuranceManager.Delete(insurance);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
