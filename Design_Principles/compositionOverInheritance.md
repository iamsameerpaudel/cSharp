# Composition over inheritance

> This states that our moudles/classes should be defined not by 'is a' relationship but rather with 'has a' relationship.

> For eg: Iphone is an Apple device, Magic Mouse is an Apple device. But Iphone and Magic Mouse have completely different components. We could create an AppleDevices class and inherit from it for both Iphone and Magic Mouse but It's not a good idea.

```C#
class AppleDevices
{
    public string name { get; set; }
    public string CPU { get; set; }
    public int Memory { get; set; }
    public AppleDevices(string name, string CPU, int Memory)
    {
        this.name = name;
        this.CPU = CPU;
        this.Memory = Memory;
    }
    public void TakePhoto()
    {
        System.Console.WriteLine("Click!!!");
    }
    public void PlayGame()
    {
        System.Console.WriteLine("Playing Game!!!");
    }
    public void PlayMusic()
    {
        System.Console.WriteLine("Playing Music!!!");
    }

}


class IPhone : AppleDevices
{
public IPhone(string name, string cpu, int memory):base(name,cpu,memory){}
}

class MacBook : AppleDevices
{
public MacBook(string name, string cpu, int memory):base(name,cpu,memory){}

}

class MagicMouse : AppleDevices
{
public MagicMouse(string name, string cpu, int memory):base(name,cpu,memory){}

}


public class program
{
    public static void Main(string[] args)
    {
        AppleDevices iphone13 = new IPhone("Iphone 13", "A14", 128);
        iphone13.PlayMusic();

        AppleDevices magicMouse = new MagicMouse("Magic Mouse", "M1", 128);
        magicMouse.TakePhoto(); //This should not work, but it does. We can use composition over inheritance to avoid these type of errors
    }
}

```

> When we inherit from a base class we inherit everything it has whether we need it or not.

> We can break the base class down to multiple sub classes so that we compose only the things we need.

```C#

class AppleDevices
{
    private string _name;
    public AppleDevices(string name)
    {
        this._name = name;
    }
}

class Memory
{
    private int _memory;
    public Memory(int memory)
    {
        this._memory = memory;
    }
}

class CPU
{
    private string _cpu;
    public CPU(string name)
    {
        this._cpu = name;
    }

}

class Scroller
{
    public void ScrollUp()
    {
        System.Console.WriteLine("Scrolling up!!");
    }
    public void ScrollDown()
    {
        System.Console.WriteLine("Scrolling Down!!!");
    }
    public void ScrollSideways()
    {
        System.Console.WriteLine("Scrolling Sideways!!!");
    }
}

class Camera
{
    public void TakePicture()
    {
        System.Console.WriteLine("Taking a picture!!!");
    }
    public void RecordVideo()
    {
        System.Console.WriteLine("Recording a video!!!");
    }
    public void TakeSelfie()
    {
        System.Console.WriteLine("Taking a selfie!!!");
    }

}

class GamePlay
{
    public void PlayGame(string gameName)
    {
        System.Console.WriteLine($"Playing {gameName}!!!");
    }
}

class MusicPlayer
{
    public void PlayMusic(string Music)
    {
        System.Console.WriteLine($"Playing {Music}!!!");
    }
}

class VideoEditor
{
    public void EditVideo()
    {
        System.Console.WriteLine("Edited Video!!!");
    }
}

class IPhone : AppleDevices
{
    private Camera _camera;
    private GamePlay _playGame;
    private MusicPlayer _playMusic;
    private CPU _cpu;
    private Memory _memory;


    public IPhone(string name, string cpu, int memory) : base(name)
    {

        _camera = new Camera();
        _playGame = new GamePlay();
        _playMusic = new MusicPlayer();
        _cpu = new CPU(cpu);
        _memory = new Memory(memory);
    }
    public void TakePhoto()
    {
        _camera.TakePicture();
    }
    public void PlayGame(string gameName)
    {
        _playGame.PlayGame(gameName);
    }
    public void PlayMusic(string songName)
    {
        _playMusic.PlayMusic(songName);
    }
}


class MacBook : AppleDevices
{
    private Camera _camera;
    private GamePlay _gamePlay;
    private MusicPlayer _playMusic;
    private VideoEditor _videoEditor;
    private CPU _cpu;
    private Memory _memory;
    public MacBook(string name, string cpu, int memory) : base(name)
    {
        _camera = new Camera();
        _gamePlay = new GamePlay();
        _playMusic = new MusicPlayer();
        _videoEditor = new VideoEditor();
        _cpu = new CPU(cpu);
        _memory = new Memory(memory);
    }

    public void TakePhoto()
    {
        _camera.TakePicture();
    }
    public void PlayGame(string gameName)
    {
        _gamePlay.PlayGame(gameName);
    }
    public void PlayMusic(string songName)
    {
        _playMusic.PlayMusic(songName);
    }
    public void EditVideo()
    {
        _videoEditor.EditVideo();
    }

}
class MagicMouse : AppleDevices
{
    private Scroller _scroller;
    public MagicMouse(string name) : base(name)
    {
        _scroller = new Scroller();
    }

    public void ScrollUp()
    {
        _scroller.ScrollUp();
    }
    public void ScrollDown()
    {
        _scroller.ScrollDown();
    }
    public void ScrollSideways()
    {
        _scroller.ScrollSideways();
    }
}

public class program
{
    public static void Main(string[] args)
    {
        IPhone iphone13 = new IPhone("iphone13", "A18", 12);
        iphone13.PlayGame("Elden Ring");
        iphone13.TakePhoto();

        MagicMouse mouse = new MagicMouse("Magic Mouse");
        mouse.ScrollSideways();

        MacBook macbook = new MacBook("MacBook pro", "M4", 128);
        macbook.EditVideo();
    }
}
```

> This is a way better way of writing code. It prevents potential issues and removes unexpected behaviours.