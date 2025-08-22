using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDK.Interfaces;
using WebApi.DTOs;

namespace WebApi.Controllers
{
    [Route("api/documents")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDocumentsSdkRepository _documentsSdkRepository;

        public DocumentsController(IMapper mapper, IDocumentsSdkRepository documentsSdkRepository)
        {
            _mapper = mapper;
            _documentsSdkRepository = documentsSdkRepository;
        }

        // GET api/documents/{id}
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var documentSdk = _documentsSdkRepository.GetDocumentById(id);
                var documentDto = _mapper.Map<DocumentDto>(documentSdk);

                if (documentDto != null)
                {
                    return Ok(documentDto);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //GET api/documents?user=ivanov
        [HttpGet]
        public IActionResult Get([FromQuery] string user)
        {
            try
            {
                var documentsSdk = _documentsSdkRepository.GetDocumentsByUser(user);
                var documentsDto = _mapper.Map<IEnumerable<DocumentDto>>(documentsSdk);

                if (documentsDto.Count() != 0)
                {
                    return Ok(documentsDto);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
