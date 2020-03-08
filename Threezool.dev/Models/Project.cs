using System;
using Microsoft.EntityFrameworkCore;

namespace Threezool.dev.Models
{
    public class Project : BaseEntity
    {
        private DateTime _toDate;

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public DateTime FromDate { get; set; }
        
        public virtual DbSet<Skill> Skills { get; set; }

        public DateTime ToDate
        {
            get => _toDate == DateTime.MinValue ? DateTime.Now : _toDate;
            set => _toDate = value;
        }
        
        public bool IsOngoing => ToDate == DateTime.MinValue;
        public bool IsAvailable => !string.IsNullOrEmpty(ProjectUrl);

        public Project() : base()
        {
            
        }
        
        public Project(int id, string name, string description, string projectUrl, string imageUrl, DateTime from, DateTime to = new DateTime()) : base(id)
        {
            this.Name = name;
            this.Description = description;
            this.ProjectUrl = projectUrl;
            this.ImageUrl = imageUrl;
            this.FromDate = from;
            this.ToDate = to;
        }
    }
}