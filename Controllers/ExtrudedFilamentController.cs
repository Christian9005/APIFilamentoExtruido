using APIFilamentoExtruido.Context;
using APIFilamentoExtruido.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace APIFilamentoExtruido.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExtrudedFilamentController : ControllerBase
{
    private readonly FDbContext fDbContext;

    public ExtrudedFilamentController(FDbContext fDbContext)
    {
        this.fDbContext = fDbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ExtrudedFilament>>> GetExtrudedFilaments()
    {
        var extrudedFilaments = await fDbContext.ExtrudedFilaments.ToListAsync();
        return Ok(extrudedFilaments);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ExtrudedFilament>> GetExtrudedFilament(int id)
    {
        var extrudedFilament = await fDbContext.ExtrudedFilaments.FindAsync(id);

        if (extrudedFilament == null) 
        {
            return NotFound();
        }

        return Ok(extrudedFilament);
    }

    [HttpPost]
    public async Task<ActionResult<ExtrudedFilament>> CreateExtrudeFilament(ExtrudedFilamentDto extrudedFilamentDto)
    {
        var extrudedFilament = new ExtrudedFilament
        {
            Name = extrudedFilamentDto.Name,
            SpeedMotor = extrudedFilamentDto.SpeedMotor,
            CollectMeters = extrudedFilamentDto.CollectMeters,
            StateMaterial = extrudedFilamentDto.StateMaterial,
            EnableMotor = extrudedFilamentDto.EnableMotor,
            ExtruderTemperature = extrudedFilamentDto.ExtruderTemperature,
            SetPointTemperature = extrudedFilamentDto.SetPointTemperature
        };

        fDbContext.ExtrudedFilaments.Add(extrudedFilament);
        await fDbContext.SaveChangesAsync();

        return CreatedAtAction("GetExtrudedFilament", new { id = extrudedFilament.Id}, extrudedFilament);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExtrudedFilament(int id, ExtrudedFilamentDtoUpdate extrudedFilamentDtoUpdate)
    {
        var extrudedFilament = await fDbContext.ExtrudedFilaments.FindAsync(id);
        if (extrudedFilament == null)
        {
            return NotFound();
        }

        if (extrudedFilamentDtoUpdate.SpeedMotor.HasValue)
        {
            extrudedFilament.SpeedMotor = extrudedFilamentDtoUpdate.SpeedMotor.Value;
        }

        if (extrudedFilamentDtoUpdate.CollectMeters.HasValue)
        {
            extrudedFilament.CollectMeters = extrudedFilamentDtoUpdate.CollectMeters.Value;
        }

        if (extrudedFilamentDtoUpdate.StateMaterial.HasValue)
        {
            extrudedFilament.StateMaterial = extrudedFilamentDtoUpdate.StateMaterial.Value;
        }

        if (extrudedFilamentDtoUpdate.EnableMotor.HasValue)
        {
            extrudedFilament.EnableMotor = extrudedFilamentDtoUpdate.EnableMotor.Value;
        }

        if (extrudedFilamentDtoUpdate.ExtruderTemperature.HasValue)
        {
            extrudedFilament.ExtruderTemperature = extrudedFilamentDtoUpdate.ExtruderTemperature.Value;
        }

        if (extrudedFilamentDtoUpdate.SetPointTemperature.HasValue)
        {
            extrudedFilament.SetPointTemperature = extrudedFilamentDtoUpdate.SetPointTemperature.Value;
        }

        fDbContext.Entry(extrudedFilament).State = EntityState.Modified;

        try
        {
            await fDbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ExtrudedFilamentExist(id))
            {
                return NotFound();
            }
            else 
            {
                throw;
            }
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExtrudedFilament(int id)
    {
        var extrudedFilament = await fDbContext.ExtrudedFilaments.FindAsync(id);
        if (extrudedFilament == null)
        {
            return NotFound();
        } 

        fDbContext.Remove(extrudedFilament);
        await fDbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool ExtrudedFilamentExist(int id)
    {
        return fDbContext.ExtrudedFilaments.Any(f => f.Id == id);
    }
}
