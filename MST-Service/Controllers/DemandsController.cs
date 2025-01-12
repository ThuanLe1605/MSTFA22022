﻿using Microsoft.AspNetCore.Mvc;
using MST_Service.RequestModels.Create;
using MST_Service.RequestModels.Update;
using MST_Service.Servvices.Implementations;
using MST_Service.Servvices.Interfaces;
using MST_Service.ViewModels;

namespace MST_Service.Controllers
{
    [Route("api/demands")]
    [ApiController]
    public class DemandsController : ControllerBase
    {
        private readonly IDemandService _demandService;

        public DemandsController(IDemandService demandService)
        {
            _demandService = demandService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DemandViewModel>>> GetDemands([FromQuery] string? search, Guid? genderId, Guid? subjectId, Guid? gradeId, Guid? syllabusId)
        {
            try
            {
                var result = await _demandService.GetDemands(search, genderId, subjectId, gradeId, syllabusId);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DemandViewModel>> GetDemand([FromRoute] Guid id)
        {
            try
            {
                var result = await _demandService.GetDemand(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet]
        [Route("lectures/{id}")]
        public async Task<ActionResult<DemandViewModel>> GetReommendLecture([FromRoute] Guid id)
        {
            try
            {
                var result = await _demandService.GetRecommendLecture(id);
                if (result != null && result.Count() > 0)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<DemandViewModel>> CreateDemand([FromBody] DemandCreateModel demand)
        {                        
            try
            {
                var result = await _demandService.CreateDemand(demand);
                if (result is not null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<DemandViewModel>> UpdateDemand([FromRoute] Guid id, [FromBody] DemandUpdateModel demand)
        {
            try
            {
                var result = await _demandService.UpdateDemand(id, demand);
                if (result is not null)
                {
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveDemand([FromRoute] Guid id)
        {
            try
            {
                var result = await _demandService.RemoveDemand(id);
                if (result)
                {
                    return NoContent();
                }
                return BadRequest();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
