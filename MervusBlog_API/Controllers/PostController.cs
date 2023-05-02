using System;
using System.Net;
using AutoMapper;
using MervusBlog_API.Models;
using MervusBlog_API.Models.Dto;
using MervusBlog_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MervusBlog_API.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
	{
		private readonly IPostRepository _dbPost;
		private readonly IMapper _mapper;
        protected APIResponse _response;

		public PostController(IPostRepository postRepository, IMapper mapper)
		{
			_dbPost = postRepository;
			_mapper = mapper;
			this._response = new();
		}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetPosts()
        {
            try
            {
                IEnumerable<Post> postList = await _dbPost.GetAllAsync();
                _response.Result = _mapper.Map<List<PostDTO>>(postList);
                _response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return Ok(_response);
        }

        [HttpGet("{id:int}", Name = "GetPost")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetPost(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var post = await _dbPost.GetAsync(u => u.Id == id);
                if (post == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<PostDTO>(post);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}

