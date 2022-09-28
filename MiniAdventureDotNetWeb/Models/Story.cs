using System;
using System.ComponentModel.DataAnnotations;

namespace MiniAdventureDotNetWeb.Models
{
    public class Page
    {
        [Key]
        public string ActionCode { get; set; } = "";
        public string Title { get; set; } = "";
        public string Segment1 { get; set; } = "";
        public string Segment2 { get; set; } = "";
        public string Segment3 { get; set; } = "";
        public string Segment4 { get; set; } = "";
        public string Segment5 { get; set; } = "";
        public string OptionA { get; set; } = "";
        public string OptionB { get; set; } = "";
        public string OptionC { get; set; } = "";
        public string ActionA { get; set; } = "";
        public string ActionB { get; set; } = "";
        public string ActionC { get; set; } = "";
    }
}

