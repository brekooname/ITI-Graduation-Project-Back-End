﻿using Final.Project.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Final.Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly IWishListManager _wishListManager;

        public WishListController(IWishListManager wishListManager)
        {
            _wishListManager = wishListManager;
        }

        [HttpGet]
        [Route("Add/{productId}")]
        public ActionResult AddToWishList(int productId)
        {
            var userIdFromToken = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdFromToken is null)
            {
                return BadRequest("not logged in");

            }
            var wishList = _wishListManager.AddtoWishList(userIdFromToken, productId);
            return Ok();
        }

        [HttpGet]
        [Route("Count")]
        public ActionResult GetWishListCount()
        {
            var userIdFromToken = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdFromToken is null)
            {
                return BadRequest("not logged in");

            }
            var wishListCounter = _wishListManager.GetWishListCount(userIdFromToken);
            return Ok(wishListCounter);
        }


    }
}