using BestPartsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BestPartsDemo.Data;

public class ContactDbContext : DbContext
{
    public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed initial data
        modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                Id = 1, Name = "Alice Johnson", Email = "alice.johnson@techcorp.com",
                Phone = "+1 (555) 123-4567", Company = "TechCorp Inc.", Role = "Senior Developer"
            },
            new Contact
            {
                Id = 2, Name = "Bob Smith", Email = "bob.smith@innovate.io",
                Phone = "+1 (555) 234-5678", Company = "Innovate.io", Role = "Product Manager"
            },
            new Contact
            {
                Id = 3, Name = "Carol Martinez", Email = "carol.m@designstudio.com",
                Phone = "+1 (555) 345-6789", Company = "Design Studio", Role = "UX Designer"
            },
            new Contact
            {
                Id = 4, Name = "David Chen", Email = "david.chen@cloudservices.net",
                Phone = "+1 (555) 456-7890", Company = "Cloud Services", Role = "DevOps Engineer"
            },
            new Contact
            {
                Id = 5, Name = "Emily Brown", Email = "emily.brown@datainsights.com",
                Phone = "+1 (555) 567-8901", Company = "Data Insights", Role = "Data Scientist"
            },
            new Contact
            {
                Id = 6, Name = "Frank Wilson", Email = "frank.w@startuplab.xyz",
                Phone = "+1 (555) 678-9012", Company = "Startup Lab", Role = "CTO"
            },
            new Contact
            {
                Id = 7, Name = "Grace Lee", Email = "grace.lee@marketpro.com",
                Phone = "+1 (555) 789-0123", Company = "MarketPro", Role = "Marketing Director"
            },
            new Contact
            {
                Id = 8, Name = "Henry Taylor", Email = "henry.taylor@financeplus.com",
                Phone = "+1 (555) 890-1234", Company = "FinancePlus", Role = "Financial Analyst"
            },
            new Contact
            {
                Id = 9, Name = "Iris Thompson", Email = "iris.t@healthtech.io",
                Phone = "+1 (555) 901-2345", Company = "HealthTech", Role = "Medical Director"
            },
            new Contact
            {
                Id = 10, Name = "Jack Rodriguez", Email = "jack.rodriguez@edulearn.com",
                Phone = "+1 (555) 012-3456", Company = "EduLearn", Role = "Education Specialist"
            },
            new Contact
            {
                Id = 11, Name = "Karen White", Email = "karen.white@legalservices.net",
                Phone = "+1 (555) 123-4560", Company = "Legal Services", Role = "Senior Counsel"
            },
            new Contact
            {
                Id = 12, Name = "Leo Kim", Email = "leo.kim@automate.tech",
                Phone = "+1 (555) 234-5601", Company = "Automate Tech", Role = "Automation Engineer"
            },
            new Contact
            {
                Id = 13, Name = "Maya Patel", Email = "maya.patel@socialnetwork.io",
                Phone = "+1 (555) 345-6012", Company = "Social Network", Role = "Community Manager"
            },
            new Contact
            {
                Id = 14, Name = "Noah Garcia", Email = "noah.garcia@retailpro.com",
                Phone = "+1 (555) 456-0123", Company = "RetailPro", Role = "Operations Manager"
            },
            new Contact
            {
                Id = 15, Name = "Olivia Jackson", Email = "olivia.j@creativestudio.co",
                Phone = "+1 (555) 567-1234", Company = "Creative Studio", Role = "Art Director"
            },
            new Contact
            {
                Id = 16, Name = "Peter Anderson", Email = "peter.anderson@logistics.net",
                Phone = "+1 (555) 678-2345", Company = "Logistics Plus", Role = "Supply Chain Manager"
            }
        );
    }
}