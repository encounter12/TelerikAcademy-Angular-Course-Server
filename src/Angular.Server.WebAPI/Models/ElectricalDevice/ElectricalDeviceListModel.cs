﻿namespace Angular.Server.WebAPI.Models.ElectricalDevice
{
    public class ElectricalDeviceListModel
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public string ModelName { get; set; }

        public string ManufacturerName { get; set; }

        public double? MeasuringUnitCurrentLevel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public int ElectricalSystemId { get; set; }
    }
}
