namespace ConsoleApp2
{
    class Profile
    {   
        public string Name { get; set; }
        public int Height { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfiles =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="홍길동", Height=176},
                new Profile(){Name="고현정", Height=169},
                new Profile(){Name="이문세", Height=182},
                new Profile(){Name="하하", Height=169}
            };

            var profiles = from profile in arrProfiles
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
                Debug.WriteLine("{0}:{1}", profile.Name, profile.InchHeight);

        }
    }
}