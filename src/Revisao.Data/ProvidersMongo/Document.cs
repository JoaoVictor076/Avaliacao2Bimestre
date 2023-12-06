using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Revisao.Data.ProvidersMongo.MongoDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.ProvidersMongo
{
    public abstract class Document : IDocument
    {

        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
