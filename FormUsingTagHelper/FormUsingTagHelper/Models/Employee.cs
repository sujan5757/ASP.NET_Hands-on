namespace FormUsingTagHelper.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int age { get; set; }

        public string designation { get; set; }
        public int salary { get; set; }
        public string married { get; set; }
        public string description { get; set; }
    }
    public enum Gender
    {
        MALE,FEMALE
    }
}
