using JwtRoleAuthentication.Data;
using JwtRoleAuthentication.Models;
using JwtRoleAuthentication.Dto;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using JwtRoleAuthentication.Dto;

namespace JwtRoleAuthentication.Controllers;

[ApiVersion(1.0)]
[ApiController]
[Route("api/[controller]")]
public class ItemController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public ItemController(ILogger<PagesController> logger, ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("new")]
    public async Task<ActionResult<Barang>> CreatePage(BarangDto pageDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var page = new Barang
        {
            BarangId = pageDto.BarangId,
            NamaBarang = pageDto.NamaBarang,
            Harga = pageDto.Harga,
            StokAwal = pageDto.StokAwal,
            Kategori = pageDto.Kategori,
            GambarBarang = pageDto.GambarBarang,
        };

        _dbContext.Barangs.Add(page);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPage), new { id = page.BarangId }, page);
    }


    [HttpGet("{id:int}")]
    public async Task<ActionResult<BarangDto>> GetPage(int id)
    {
        var page = await _dbContext.Barangs.FindAsync(id);

        if (page is null)
        {
            return NotFound();
        }

        var pageDto = new BarangDto
        {
            BarangId = page.BarangId,
            NamaBarang = page.NamaBarang,
            Harga = page.Harga,
            StokAwal = page.StokAwal,
            Kategori = page.Kategori,
            GambarBarang = page.GambarBarang,
        };

        return pageDto;
    }


    [HttpGet]
    public async Task<BarangsDto> ListPages()
    {
        var pagesFromDb = await _dbContext.Barangs.ToListAsync();

        var pagesDto = new BarangsDto();

        foreach (var page in pagesFromDb)
        {
            var pageDto = new BarangDto
            {
                BarangId = page.BarangId,
                NamaBarang = page.NamaBarang,
                Harga = page.Harga,
                StokAwal = page.StokAwal,
                Kategori = page.Kategori,
                GambarBarang = page.GambarBarang
            };

            pagesDto.Barangs.Add(pageDto);
        }

        return pagesDto;
    }
}