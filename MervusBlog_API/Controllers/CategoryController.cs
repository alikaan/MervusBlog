using System.Net;
using AutoMapper;
using MervusBlog_API.Models;
using MervusBlog_API.Models.Dto;
using MervusBlog_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MervusBlog_API.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
	{
        private readonly ICategoryRepository _dbCategory;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public CategoryController(ICategoryRepository dbCategory, IMapper mapper)
		{
            _dbCategory = dbCategory;
            _mapper = mapper;
            this._response = new();
		}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetCategories()
        {
            try
            {
                IEnumerable<Category> categoryList = await _dbCategory.GetAllAsync();
                _response.Result = _mapper.Map<List<CategoryDTO>>(categoryList);
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

        [HttpGet("{id:int}", Name = "GetCategory")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetCategory(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var category = await _dbCategory.GetAsync(u => u.Id == id);
                if (category == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<CategoryDTO>(category);
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

