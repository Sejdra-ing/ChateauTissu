using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChateauTissu.Models
{
    [DataContract]
    public class ProductModel
    {
        string _name, _id, _colors, _category;

        [DataMember(Name="name")]
        public string Name { get => _name; set { _name = value; } }

        [DataMember(Name = "id")]
        public string Id { get => _id; set { _id = value; }}

        [DataMember(Name = "colors")]
        public string Colors { get => _colors; set { _colors = value; } }

        [DataMember(Name = "category")]
        public string Category { get => _category; set { _category = value; } }

        public ProductModel(string name, string id, string colors, string category)
        {
            _name = name;
            _id = id;
            _colors = colors;
            _category = category;
        }
    }
}