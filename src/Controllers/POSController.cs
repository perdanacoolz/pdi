using JwtRoleAuthentication.Dto;
using JwtRoleAuthentication.Data;
using JwtRoleAuthentication.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace JwtRoleAuthentication.Controllers;

[ApiVersion(1.0)]
[ApiController]
[Route("api/[controller]")]
public class PosController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public PosController(ILogger<PosController> logger, ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("new")]
    public async Task<ActionResult<Transaksi>> CreatePage(TransaksiDto pageDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var page = new Transaksi
        {
            transactionId = pageDto.transactionId,
            JmlItem = pageDto.Jmlitem,
            Hargaitem = pageDto.Hargaitem,
            Totalharga = pageDto.Totalharga,
            transactionDate = pageDto.transactionDate
         
        };

        _dbContext.transaksis.Add(page);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPage), new { id = page.transactionId }, page);
    }


    [HttpGet("{id:int}")]
    public async Task<ActionResult<TransaksiDto>> GetPage(int id)
    {
        var page = await _dbContext.transaksis.FindAsync(id);

        if (page is null)
        {
            return NotFound();
        }

        var pageDto = new TransaksiDto
        {
            transactionId = page.transactionId,
            Jmlitem = page.JmlItem,
            Hargaitem = page.Hargaitem,
            Totalharga = page.Totalharga,
            transactionDate = page.transactionDate
        };

        return pageDto;
    }

     
}