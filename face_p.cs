using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using RethinkDb;
using RethinkDb.QueryTerm;
using RethinkDb.Configuration;

namespace Microsoft.Samples.Kinect.FaceBasics
{

    [DataContract]
    public class face_p
    {
        public static IDatabaseQuery Db = Query.Db("prueba");
        public static TableQuery<face_p> Table = Db.Table<face_p>("cara");

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id;

        [DataMember]
        public string caract;
    }
}
