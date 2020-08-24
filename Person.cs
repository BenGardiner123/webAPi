using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;


namespace webApi
{
    public class Person
    {
        [JsonPropertyName("Name")]
        public string Name{get; set;}

        [JsonPropertyName("ID")]
        public string ID {get; set;}

        [JsonPropertyName("Weight")]
        public int Wieght {get; set;}

        public Person()
        {
            
        }

        public Person(string name, string iD, int wieght)
        {
            this.Name = name;
            this.ID = iD;
            this.Wieght = wieght;
        }
        


    }


    


}