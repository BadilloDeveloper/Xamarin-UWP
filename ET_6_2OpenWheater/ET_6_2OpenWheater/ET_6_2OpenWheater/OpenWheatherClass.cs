﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ET_6_2OpenWheater
{

        public partial class OpenWheatherClass
        {
            [JsonProperty("coord")]
            public Coord Coord { get; set; }

            [JsonProperty("weather")]
            public Weather[] Weather { get; set; }

            [JsonProperty("base")]
            public string Base { get; set; }

            [JsonProperty("main")]
            public Main Main { get; set; }

            [JsonProperty("visibility")]
            public long Visibility { get; set; }

            [JsonProperty("wind")]
            public Wind Wind { get; set; }

            [JsonProperty("clouds")]
            public Clouds Clouds { get; set; }

            [JsonProperty("dt")]
            public long Dt { get; set; }

            [JsonProperty("sys")]
            public Sys Sys { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("cod")]
            public long Cod { get; set; }
        }

        public partial class Clouds
        {
            [JsonProperty("all")]
            public long All { get; set; }
        }

        public partial class Coord
        {
            [JsonProperty("lon")]
            public double Lon { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }
        }

        public partial class Main
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("pressure")]
            public long Pressure { get; set; }

            [JsonProperty("humidity")]
            public long Humidity { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }
        }

        public partial class Sys
        {
            [JsonProperty("type")]
            public long Type { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("message")]
            public double Message { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("sunrise")]
            public long Sunrise { get; set; }

            [JsonProperty("sunset")]
            public long Sunset { get; set; }
        }

        public partial class Weather
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public partial class Wind
        {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public long Deg { get; set; }
        }

    public partial class OpenWheatherClass
    {
        public static OpenWheatherClass FromJson(string json) => JsonConvert.DeserializeObject<OpenWheatherClass>(json, ET_6_2OpenWheater.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OpenWheatherClass self) => JsonConvert.SerializeObject(self, ET_6_2OpenWheater.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
        };
    }





}
