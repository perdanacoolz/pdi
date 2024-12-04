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
public class KategoriController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public KategoriController(ILogger<KategoriController> logger, ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("new")]
    public async Task<ActionResult<Kategori>> CreatePage(KategoriDto pageDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var page = new Kategori
        {
            KategoriID = pageDto.KategoriID,
            NamaKategori = pageDto.NamaKategori
            
        };

        _dbContext.kategoris.Add(page);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPage), new { id = page.KategoriID }, page);
    }

    [HttpPut]
    public async Task<IActionResult> EditPage(Kategori productData)
    {
        if (productData == null || productData.KategoriID == 0)
            return BadRequest();

        var product = await _dbContext.kategoris.FindAsync(productData.KategoriID);
        if (product == null)
            return NotFound();
        product.NamaKategori = productData.NamaKategori;
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpGet("{id:int}")]
    public async Task<ActionResult<KategoriDto>> GetPage(int id)
    {
        var page = await _dbContext.kategoris.FindAsync(id);

        if (page is null)
        {
            return NotFound();
        }

        var pageDto = new KategoriDto
        {
            KategoriID = page.KategoriID,
            NamaKategori = page.NamaKategori,
           
        };

        return pageDto;
    }


    [HttpGet]
    public async Task<KategorisDto> ListPages()
    {
        var pagesFromDb = await _dbContext.kategoris.ToListAsync();

        var pagesDto = new KategorisDto();

        foreach (var page in pagesFromDb)
        {
            var pageDto = new KategoriDto
            {
                KategoriID = page.KategoriID,
                NamaKategori = page.NamaKategori,
               
            };

            pagesDto.Kategoris.Add(pageDto);
        }

        return pagesDto;
    }
}