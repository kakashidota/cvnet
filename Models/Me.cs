using CVNET.Data;

namespace CVNET.Models
{
    public class Me
    {

        public int Id { get; set; }

        public string Name { get; set; } = "Robin kamooo";
        public string Title { get; set; } = "Cloud Developer";
        public string Email { get; set; } = "Robin.kamo@iths.se";
        public string Phone { get; set; } = "031-3301088";
        public string Location { get; set; } = "Gotham, Sweden";
        public string Description { get; set; } = "Father, nerd, ninja & Jedi";
        public List<Education> Education { get; set; } = new List<Education>
        {
            new Education
            {
                Degree="App developer IOS and Android",
                Institution="It-Högskolan",
                GraduationYear="2018"
            },
            new Education
            {
                Degree="It-projectmanager",
                Institution="It-Högskolan",
                GraduationYear="2020"
            }
        };
        public List<Skills> Skills { get; set; } = new List<Skills>
        {
            new Skills
            {
                SkillName="Python",
                Level=5
            },
            new Skills
            {
                SkillName="Azure",
                Level=5
            }
        };
        public List<WorkExperience> WorkExperience { get; set; } = new List<WorkExperience>
        {
        new WorkExperience
        {
            Company = "HazelTime AB",
            Role = ".NET developer",
            Duration = "2018-2019",
            Responsibilities = "Developed the frontend. Gave the complete project e refurbish"
            
        },
        new WorkExperience
        {
            Company = "Singu AB",
            Role = "App developer",
            Duration = "2019-2020",
            Responsibilities = "Designed shit"
        }
        };

    }
}
