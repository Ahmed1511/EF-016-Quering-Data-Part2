﻿namespace C05.SelectMany.QueryData.Entities
{
    public class Office : Entity
    {
        public string? OfficeName { get; set; }
        public string? OfficeLocation { get; set; }

        public Instructor? Instructor { get; set; }
    }
}
