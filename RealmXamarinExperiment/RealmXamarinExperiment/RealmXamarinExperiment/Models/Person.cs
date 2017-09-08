using Realms;

namespace RealmXamarinExperiment.Models
{
    public class Person : RealmObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}