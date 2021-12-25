using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public static class Constants
    {
        public static class JwtConfigKeys
        {
            public const string Token = "Token";
            public const string Bearer = "bearer";
            public const string Authorization = "Authorization";
            public const string JwtSecret = "JwtConfig:Secret";
            public const string JwtIssuer = "JwtConfig:Issuer";
            public const string JwtAudience = "JwtConfig:Audience";
        }
        public static class Messages
        {
            public const string Record = "record(s)";
            public const string Success = "Success";
            public const string Successfully = "successfully";
            public const string Created = "created";
            public const string Saved = "saved";
            public const string Updated = "updated";
            public const string Deleted = "deleted";
            public const string Retrieved = "retrieved";

            public const string Process = "process";
            public const string Completed = "completed";
            public const string Found = "found";
            public const string Not = "not";

            public const string CreatedSuccessfully = Created + " " + Successfully;
            public const string NotCreated = Not + " " + Created;
            public const string EntityCreatedSuccessfully = "{0} " + Created + " " + Successfully;
            public const string SavedSuccessfully = Saved + " " + Successfully;
            public const string NotSaved = Not + " " + Saved;
            public const string EntitySuccessfully = "{0} " + Saved + " " + Successfully;
            public const string UpdatedSuccessfully = Updated + " " + Successfully;
            public const string NotUpdated = Not + " " + Updated;
            public const string EntityUpdatedSuccessfully = "{0} " + Updated + " " + Successfully;
            public const string DeletedSuccessfully = Deleted + " " + Successfully;
            public const string NotDeleted = Not + " " + Deleted;
            public const string EntityDeletedSuccessfully = "{0} " + Deleted + " " + Successfully;
            public const string RetrievedSuccessfully = Retrieved + " " + Successfully;
            public const string NotRetrieved = Not + " " + Retrieved;
            public const string EntityRetrievedSuccessfully = "{0} " + Retrieved + " " + Successfully;

            public const string RecordNotFound = Record + " " + Not + " " + Found;
            public const string EntityRecordNotFound = "{0} " + Record + " " + Not + " " + Found;

            public const string ProcessCompleted = Process + " " + Completed;
            public const string ProcessNotCompleted = Process + " " + Not + " " + Completed;
        }

        public static class Procs
        {
            public const string SP_Pages_GetByUser = "SP_Pages_GetByUser";
        }
    }
}
