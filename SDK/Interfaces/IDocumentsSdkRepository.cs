using SDK.Models;

namespace SDK.Interfaces
{
    public interface IDocumentsSdkRepository
    {
        IEnumerable<DocumentSdk> GetDocumentsByUser(string userName);
        DocumentSdk? GetDocumentById(Guid id);
    }
}
