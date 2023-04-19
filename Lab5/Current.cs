using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Current
    {
        public string ObservationTime { get; set; }
        public int Temperature { get; set; }
        public int WeatherCode { get; set; }
        public List<string> WeatherIcons { get; set; }
        public List<string> WeatherDescriptions { get; set; }
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int Feelslike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public string IsDay { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Observation time: {ObservationTime}");
            sb.AppendLine($"Temperature: {Temperature}°C");
            sb.AppendLine($"Weather code: {WeatherCode}");
            sb.AppendLine($"Weather descriptions: {WeatherDescriptions}");
            sb.AppendLine($"Wind speed: {WindSpeed} km/h");
            sb.AppendLine($"Wind degree: {WindDegree}");
            sb.AppendLine($"Wind direction: {WindDir}");
            sb.AppendLine($"Pressure: {Pressure} mb");
            sb.AppendLine($"Humidity: {Humidity}%");
            sb.AppendLine($"Cloud cover: {Cloudcover}%");
            sb.AppendLine($"Feels like: {Feelslike}°C");
            sb.AppendLine($"Visibility: {Visibility} km");

            return sb.ToString();
        }

    }
}
