using System.Collections.Generic;
using System;
interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}
interface IObserver
{
    void Update(float temp, float humidity, float pressure);
}
interface DisplayElement
{
    void Display();
}


class WeatherData : ISubject
{
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }
    public void RemoveObserver(IObserver o)
    {
        int index = observers.IndexOf(o);
        if (index >= 0)
        {
            observers.Remove(o);
        }
    }
    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }
    public void MeasurementsChanged()
    {
        NotifyObservers();
    }
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }

    public float GetTemperature()
    {
        return temperature;
    }
    public float GetHumidity()
    {
        return humidity;
    }
    public float GetPressure()
    {
        return pressure;
    }

}
class CurrentConditionsDisplay : IObserver, DisplayElement
{
    private float temperature;
    private float humidity;
    private float pressure;
    private ISubject weatherdata;
    public CurrentConditionsDisplay(ISubject weatherdata)
    {
        this.weatherdata = weatherdata;
        weatherdata.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }
    public void Display()
    {
        System.Console.WriteLine($"Current conditions: {temperature} C degree, {humidity}% humidity and {pressure} pressure");
    }
}

class StatisticsDisplay : IObserver, DisplayElement
{
    private float temperature;
    private float humidity;
    private float pressure;
    private ISubject weatherdata;
    public StatisticsDisplay(ISubject weatherdata)
    {
        this.weatherdata = weatherdata;
        weatherdata.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }
    public void Display()
    {
        System.Console.WriteLine($"Statistics: {temperature} C degree, {humidity}% humidity and {pressure} pressure");

    }
}
class ForecastDisplay : IObserver, DisplayElement
{
    private float temperature;
    private float humidity;
    private float pressure;
    private ISubject weatherdata;

    string[] forcastTexts = { "It'll get better", "Bad day ahead", "Gonna rain", "Scorching heat", "Take an umbrella", "I'd wear a jacket for the cold" };
    public ForecastDisplay(ISubject weatherdata)
    {
        this.weatherdata = weatherdata;
        weatherdata.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }
    public void Display()
    {
        Random random = new Random();
        System.Console.WriteLine($"Forecast: {forcastTexts[random.Next(forcastTexts.Length)]}");

    }
}
public class Station
{
    public static void Main(string[] args)
    {
        WeatherData weather = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weather);
        StatisticsDisplay statistics = new StatisticsDisplay(weather);
        ForecastDisplay forecast = new ForecastDisplay(weather);

        weather.SetMeasurements(40, 76, 56.3f);
        System.Console.WriteLine("");
        weather.SetMeasurements(35, 58, 34.6f);
        System.Console.WriteLine("");
        weather.SetMeasurements(40, 76, 28.9f);
    }
}
