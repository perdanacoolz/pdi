using JwtRoleAuthentication.Data;
using JwtRoleAuthentication.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using JwtRoleAuthentication.Dto;

namespace JwtRoleAuthentication.Controllers;

[ApiVersion(1.0)]
[ApiController]
[Route("api/[controller]")]
public class POSController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public POSController(ILogger<POSController> logger, ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Transaksi>>> GetTransaksi()
    {
        return await _dbContext.transaksis.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Transaksi>> GetTransaksi(int id)
    {
        var customer = await _dbContext.transaksis.FindAsync(id);

        if (customer == null)
        {
            return NotFound();
        }

        return customer;
    }

    [HttpPost]
    public async Task<ActionResult<Transaksi>> PostTransaksi(Transaksi trans)
    {
        _dbContext.transaksis.Add(trans);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction("GetTransaksi", new { id = trans.transactionId }, trans);
    }

}