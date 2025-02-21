﻿using WeatherApp.Converters;
using WeatherApp.Models.Weather;

namespace WeatherApp.Models
{
    public class WeatherForecast
    {
        public Temperature Temperature { get; private set; }
        public DetailedInfo DetailedInfo { get; private set; }
        public string IconPath { get; private set; }

        public Date MyDate { get; private set; }
        public string DateDisplay => MyDate.Short;

        public WeatherForecast(Temperature Temperature, DetailedInfo DetailedInfo, double unixTime, string icon = null)
        {
            this.Temperature = Temperature;
            this.DetailedInfo = DetailedInfo;
            this.MyDate = new Date(Time.UnixTimeStampToDateTime(unixTime));
            if (icon != null) this.IconPath = Icons.GetWeatherIcon(icon);
        }
    }
}