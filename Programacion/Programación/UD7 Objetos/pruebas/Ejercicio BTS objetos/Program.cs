using Pruebas;

public class Program
{
    public static void Main()
    {
        Band bts = new Band();
        bts.Producer = "Productor de bts";

        bts.Members = new List<Member>();

        Member jimin = new Member();
        jimin.Name = "Park Jimin";
        jimin.Age = 25;
        jimin.VoiceType = "melódica";
        bts.Members.Add(jimin);

        Member jungkook = new Member();
        jungkook.Name = "Jeon Jungkook";
        jungkook.Age = 23;
        jungkook.VoiceType = "melódica";
        bts.Members.Add(jungkook);

        Member v = new Member();
        v.Name = "Kim Taehyung";
        v.Age = 25;
        v.VoiceType = "melódica";
        bts.Members.Add(v);

        Member rm = new Member();
        rm.Name = "Kim Namjoom";
        rm.Age = 28;
        rm.VoiceType = "rapero";
        bts.Members.Add(rm);

        Member jhope = new Member();
        jhope.Name = "Jung Hoseok";
        jhope.Age = 27;
        jhope.VoiceType = "rapero";
        bts.Members.Add(jhope);

        Member suga = new Member();
        suga.Name = "Jung Hoseok";
        suga.Age = 28;
        suga.VoiceType = "rapero";
        bts.Members.Add(suga);

        Member jin = new Member();
        jin.Name = "Seok Jin";
        jin.Age = 31;
        jin.VoiceType = "melódico";
        bts.Members.Add(jin);

        //CREAR Y AÑADIR DATOS DE ALBUMES DE BTS
        bts.Albums = new List<Album>();

        Album wings = new Album();
        wings.Name = "Wings";
        wings.Year = 2008;

        Song fly = new Song();
        fly.Name = "Fly";
        fly.Minutes = 3;
        fly.Seconds = 45;

        wings.Songs = new List<Song>();
        wings.Songs.Add(fly);

        bts.Albums.Add(wings);

        for (int i = 0; i < bts.Members.Count; i++)
        {
            Console.WriteLine(bts.Members[i].Name + ": " + bts.Members[i].Age);
        }

        for (int i = 0; i < bts.Albums.Count; i++)
        {
            Console.WriteLine(bts.Albums[i].Name);
        }
        Console.ReadLine();
    }
}