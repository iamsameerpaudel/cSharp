class Amplifier
{
    DvDPlayer dvd;
    Tuner tuner;
    CdPlayer cd;
    int volume;
    public void On()
    {
        System.Console.WriteLine("Amplifier turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("Amplifier turned off!");
    }
    public void SetCd(CdPlayer cd)
    {
        this.cd = cd;
        System.Console.WriteLine("Amplifier set to CD!");
    }
    public void SetStereoSound()
    {
        System.Console.WriteLine("Amplifier set to stereo sound!");
    }
    public void SetTuner(Tuner tuner)
    {
        this.tuner = tuner;
        System.Console.WriteLine("Amplifier tuner set!");
    }
    public void SetSurroundSound()
    {
        System.Console.WriteLine("Amplifier set to surround sound!");
    }
    public void SetDVD(DvDPlayer dvd)
    {
        this.dvd = dvd;
        System.Console.WriteLine("Amplifier set to DVD!");
    }
    public void SetVolume(int volume)
    {
        this.volume = volume;
        System.Console.WriteLine("Amplifier set to volume: " + volume);
    }
}
class Tuner
{

    int frequency;
    public void On()
    {
        System.Console.WriteLine("Tuner turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("Tuner turned off!");
    }
    public void SetAm()
    {
        System.Console.WriteLine("Tuner set to AM!");
    }
    public void SetFm()
    {
        System.Console.WriteLine("Tuner set to FM!");
    }
    public void SetFrequency(int frequency)
    {
        this.frequency = frequency;
        System.Console.WriteLine("Tuner set to frequency: " + frequency);
    }

}
class CdPlayer
{
    string MovieName;
    public void On()
    {
        System.Console.WriteLine("CdPlayer turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("CdPlayer turned off!");
    }
    public void Eject()
    {
        System.Console.WriteLine("CdPlayer ejected!");
    }
    public void Pause()
    {
        System.Console.WriteLine("CdPlayer paused!");
    }
    public void Play(string movieName)
    {
        this.MovieName = movieName;
        System.Console.WriteLine($"CdPlayer playing {this.MovieName}!");
    }
    public void Stop()
    {
        System.Console.WriteLine("CdPlayer stopped!");
    }
}
class Projector
{
    public void On()
    {
        System.Console.WriteLine("Projector turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("Projector turned off!");
    }
    public void TvMode()
    {
        System.Console.WriteLine("Projector set to TV mode!");
    }
    public void WideScreenMode()
    {
        System.Console.WriteLine("Projector set to wide screen mode!");
    }
}
class TheatreLights
{
    public void On()
    {
        System.Console.WriteLine("TheatreLights turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("TheatreLights turned off!");
    }
    public void Dim()
    {
        System.Console.WriteLine("TheatreLights dimmed!");
    }
}
class Screen
{
    public void Up()
    {
        System.Console.WriteLine();
    }
    public void Down()
    {
        System.Console.WriteLine("Screen down!");
    }
}
class PopcornPopper
{
    public void On()
    {
        System.Console.WriteLine("PopcornPopper turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("PopcornPopper turned off!");
    }
    public void Pop()
    {
        System.Console.WriteLine("PopcornPopper popping popcorn!");
    }
}
class DvDPlayer
{
    string MovieName;
    public void On()
    {
        System.Console.WriteLine("DvDPlayer turned on!");
    }
    public void Off()
    {
        System.Console.WriteLine("DvDPlayer turned off!");
    }
    public void Eject()
    {
        System.Console.WriteLine("DvDPlayer ejected!");
    }
    public void Pause()
    {
        System.Console.WriteLine("DvDPlayer paused!");
    }
    public void Play(string movie)
    {
        this.MovieName = movie;
        System.Console.WriteLine($"DvDPlayer playing {this.MovieName}!");
    }
    public void Stop()
    {
        System.Console.WriteLine("DvDPlayer stopped!");
    }
    public void setSurroundSound()
    {
        System.Console.WriteLine("DvDPlayer set to surround sound!");
    }
    public void SetTwoChannelAudio()
    {
        System.Console.WriteLine("DvDPlayer set to two channel audio!");
    }
}


public class HomeTheatreFacade
{
    Amplifier amp;
    Tuner tuner;
    DvDPlayer dvd;
    CdPlayer cd;
    Projector projector;
    TheatreLights lights;
    Screen screen;
    PopcornPopper popper;
    public HomeTheatreFacade()
    {
        amp = new Amplifier();
        tuner = new Tuner();
        dvd = new DvDPlayer();
        cd = new CdPlayer();
        projector = new Projector();
        lights = new TheatreLights();
        screen = new Screen();
        popper = new PopcornPopper();
    }
    public void WatchMovie(string movie)
    {
        System.Console.WriteLine("Get ready to watch a movie...");
        popper.On();
        lights.Dim();
        screen.Down();
        projector.On();
        projector.WideScreenMode();
        amp.On();
        amp.SetSurroundSound();
        amp.SetVolume(5);
        dvd.On();
        dvd.Play(movie);
    }
    public void EndMovie()
    {
        System.Console.WriteLine("Shutting movie theater down...");
        popper.Off();
        lights.On();
        screen.Up();
        projector.Off();
        amp.Off();
        dvd.Off();
    }
}



public class MyClass
{
    public static void Main(string[] args)
    {
        HomeTheatreFacade homeTheatre = new HomeTheatreFacade();
        homeTheatre.WatchMovie("Avengers: Doomsday");
        homeTheatre.EndMovie();
    }
}
