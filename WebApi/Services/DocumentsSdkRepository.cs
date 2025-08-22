using SDK.Data;
using SDK.Interfaces;
using SDK.Models;

namespace WebApi.Services
{
    public class DocumentsSdkRepository : IDocumentsSdkRepository
    {
        private readonly IEnumerable<DocumentSdk> _db;

        public DocumentsSdkRepository()
        {
            try
            {
                _db = DocumentsDatabase.DocumentsSdk;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<DocumentSdk> GetDocumentsByUser(string userName)
        {
            try
            {
                return _db.Where(d => d.UserName.ToLower() == userName.ToLower()).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DocumentSdk? GetDocumentById(Guid id)
        {
            try
            {
                return _db.Where(d => d.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
