﻿using System.ComponentModel.DataAnnotations;

namespace InspectionApiApp
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = string.Empty;

        public string Amount { get; set; }

        public string SelectedDate { get; set; }

        public int InspectionTypeId { get; set; }

        public  InspectionType? InspectionType { get; set; }



    }
}