using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public class PersistentModel
    {
        public string StoragePath { get; private set; }

        public List<Athlete> Athletes { get; private set; }
        public List<Organization> Organizations { get; private set; }

        public void Create(string path)
        {
            if (!Directory.Exists(path))
                throw new ArgumentException("Storage path is invalid.");

            StoragePath = path;

            LoadOrganizations();
            LoadAthletes();

        }

        private void LoadOrganizations()
        {
            string filePath = GetFileName("Organizations");

            Organizations = new List<Organization>();



            var fury = new Organization()
            {
                Id = Guid.NewGuid(),
                Name = "Fury",
                LongName = "Fury Volleyball Club",
                URL = "www.furyvolleyballclub.com"
            };

            var fury12Black = new TeamSquad()
            {
                Id = Guid.NewGuid(),
                Name = "Fury 12U Black",
                HeadCoach = "Rob Lisama",
                Since = new DateTime(2016, 12, 17),
                Season = "Winter 16/17",
                AgeBracket = "12U",
                Colors = "White/Black/Teal",
                Team = fury
            };
            var fury12Red = new TeamSquad()
            {
                Id = Guid.NewGuid(),
                Name = "Fury 12U Red",
                HeadCoach = "Rob Lisama",
                AssistantCoach = "Denver",
                Since = new DateTime(2016, 12, 17),
                Season = "Winter 16/17",
                AgeBracket = "12U",
                Colors = "White/Black/Teal",
                Team = fury
            };

            fury.Squads.Add(fury12Black);
            fury.Squads.Add(fury12Red);


            Organizations.Add(fury);
            
            string output = JsonConvert.SerializeObject(Organizations, Formatting.Indented,
                new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
            File.WriteAllText(filePath, output);








            if (!File.Exists(filePath)) return;

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                Organizations = JsonConvert.DeserializeObject<List<Organization>>(json);
            }
        }

        private void LoadAthletes()
        {
            string filePath = GetFileName("Athletes");

            Athletes = new List<Athlete>();

            if (!File.Exists(filePath)) return;

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                Athletes = JsonConvert.DeserializeObject<List<Athlete>>(json);
            }
        }

        private string GetFileName(string entityName)
        {
            return Path.Combine(StoragePath, entityName + ".json");
        }
    }
}
