using AutosColombia.Src.Dtos;
using AutosColombia.Src.Models;
using AutosColombia.Src.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutosColombia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly IAutoRepository _autoRepository;
        private readonly int ejemplo;

        public AutoController(IAutoRepository autoRepository)
        {
            //dependency injection
            _autoRepository = autoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Auto>>> GetAutos()
        {
            var autos = await _autoRepository.GetAll();
            return Ok(autos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Auto>> GetAuto(int id)
        {
            var auto = await _autoRepository.Get(id);
            if (auto == null)
                return NotFound();

            return Ok(auto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAuto(AutoDto createAutoDto)
        {
            Auto auto= new()
            {
                CarBrand = createAutoDto.CarBrand,
                Color = createAutoDto.Color,
                FabricationDate = createAutoDto.FabricationDate,
                Model = createAutoDto.Model,
                Seating = createAutoDto.Seating
            };

            await _autoRepository.Add(auto);
            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAuto(int id, AutoDto updateProductDto)
        {
            Auto auto = new()
            {
                Id = id,
                CarBrand = updateProductDto.CarBrand,
                Color = updateProductDto.Color,
                FabricationDate = updateProductDto.FabricationDate,
                Model = updateProductDto.Model,
                Seating = updateProductDto.Seating
            };

            await _autoRepository.Update(auto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAuto(int id)
        {
            await _autoRepository.Delete(id);
            return Ok();
        }
    }
}
