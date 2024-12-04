﻿using JwtRoleAuthentication.Data;
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

    //[HttpPut("{id}")]
    //public async Task<IActionResult> PutBarang(int id, Barang brg)
    //{
    //    if (id != brg.BarangId)
    //    {
    //        return BadRequest();
    //    }

    //    _dbContext.Entry(brg).State = EntityState.Modified;

    //    try
    //    {
    //        await _dbContext.SaveChangesAsync();
    //    }
    //    catch (DbUpdateConcurrencyException)
    //    {
    //        if (!BarangExists(id))
    //        {
    //            return NotFound();
    //        }
    //        else
    //        {
    //            throw;
    //        }
    //    }

    //    return NoContent();
    //}

    //private bool BarangExists(int id)
    //{
    //    return _dbContext.Barangs.Any(e => e.BarangId == id);
    //}

    [HttpPut]
    public async Task<IActionResult> Put(Barang productData)
    {
        if (productData == null || productData.BarangId == 0)
            return BadRequest();

        var product = await _dbContext.Barangs.FindAsync(productData.BarangId);
        if (product == null)
            return NotFound();
        product.NamaBarang = productData.NamaBarang;
        product.Harga = productData.Harga;
        product.StokAwal = productData.StokAwal;
        product.Kategori = productData.Kategori;
        product.GambarBarang = productData.GambarBarang;
        await _dbContext.SaveChangesAsync();
        return Ok();
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