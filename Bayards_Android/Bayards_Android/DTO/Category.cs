using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace Bayards_Android.DTO
{
    class Category
    {
        [JsonProperty("id_s")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("risks")]
        public List<Risk> Risks { get; set; }
        
        [JsonProperty("subsections")]
        public List<Subcategory> Subcategories { get; set; }



    }
}