using SDK.Models;

namespace SDK.Data
{
    public class DocumentsDatabase
    {
        public static IEnumerable<DocumentSdk> DocumentsSdk = new List<DocumentSdk>
        {
            new DocumentSdk{ Id = Guid.Parse("e1b46800-49a5-44ba-9401-7d963be8071c"), //Id = Guid.NewGuid(),
                             UserName = "Ivanov",
                             Caption = "Document 1",
                             Description = "Test document 1",
                             Text = "Test REST API 1",
                             CreatedDate = DateTime.Now },
            new DocumentSdk{ Id = Guid.Parse("959a597a-9d48-40eb-beae-170f33fa66df"), //Id = Guid.NewGuid(),
                             UserName = "Ivanov",
                             Caption = "Document 2",
                             Description = "Test document 2",
                             Text = "Test REST API 2",
                             CreatedDate = DateTime.Now },
            new DocumentSdk{ Id = Guid.Parse("fdb8f935-b6b8-4f52-a50b-70c3bc1a938b"), //Id = Guid.NewGuid(),
                             UserName = "Petrov",
                             Caption = "Document 3",
                             Description = "Test document 3",
                             Text = "Test REST API 3",
                             CreatedDate = DateTime.Now },
            new DocumentSdk{ Id = Guid.Parse("9bc5d53f-668f-4876-8b3b-1dc1ce3a3c11"), //Id = Guid.NewGuid(),
                             UserName = "Sidorov",
                             Caption = "Document 4",
                             Description = "Test document 4",
                             Text = "Test REST API 4",
                             CreatedDate = DateTime.Now },
            new DocumentSdk{ Id = Guid.Parse("8b14d9c6-9cae-4ff8-966b-2cdac7319806"), //Id = Guid.NewGuid(),
                             UserName = "Petrov",
                             Caption = "Document 5",
                             Description = "Test document 5",
                             Text = "Test REST API 5",
                             CreatedDate = DateTime.Now },
        };
    }
}
