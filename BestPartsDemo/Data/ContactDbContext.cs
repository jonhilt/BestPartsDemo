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
            },
            new Contact { Id = 17, Name = "Quinn Roberts", Email = "quinn.roberts@techventures.com", Phone = "+1 (555) 789-3456", Company = "TechVentures", Role = "Venture Capitalist" },
            new Contact { Id = 18, Name = "Rachel Moore", Email = "rachel.moore@webagency.io", Phone = "+1 (555) 890-4567", Company = "Web Agency", Role = "Frontend Developer" },
            new Contact { Id = 19, Name = "Samuel Turner", Email = "samuel.turner@cybersecurity.net", Phone = "+1 (555) 901-5678", Company = "CyberSecurity Co", Role = "Security Analyst" },
            new Contact { Id = 20, Name = "Tina Cooper", Email = "tina.cooper@airesearch.com", Phone = "+1 (555) 012-6789", Company = "AI Research", Role = "ML Engineer" },
            new Contact { Id = 21, Name = "Uma Phillips", Email = "uma.phillips@realestate.pro", Phone = "+1 (555) 123-7890", Company = "RealEstate Pro", Role = "Real Estate Agent" },
            new Contact { Id = 22, Name = "Victor Evans", Email = "victor.evans@consulting.biz", Phone = "+1 (555) 234-8901", Company = "Elite Consulting", Role = "Strategy Consultant" },
            new Contact { Id = 23, Name = "Wendy Hughes", Email = "wendy.hughes@mediagroup.tv", Phone = "+1 (555) 345-9012", Company = "Media Group", Role = "Content Producer" },
            new Contact { Id = 24, Name = "Xavier Price", Email = "xavier.price@biotech.labs", Phone = "+1 (555) 456-0234", Company = "BioTech Labs", Role = "Research Scientist" },
            new Contact { Id = 25, Name = "Yara Bennett", Email = "yara.bennett@fashionhouse.com", Phone = "+1 (555) 567-1345", Company = "Fashion House", Role = "Fashion Designer" },
            new Contact { Id = 26, Name = "Zachary Wood", Email = "zachary.wood@sportsmanagement.net", Phone = "+1 (555) 678-2456", Company = "Sports Management", Role = "Sports Agent" },
            new Contact { Id = 27, Name = "Amanda Foster", Email = "amanda.foster@travelagency.com", Phone = "+1 (555) 789-3567", Company = "Global Travel", Role = "Travel Coordinator" },
            new Contact { Id = 28, Name = "Benjamin Russell", Email = "benjamin.russell@construction.co", Phone = "+1 (555) 890-4678", Company = "BuildCo", Role = "Project Manager" },
            new Contact { Id = 29, Name = "Chloe Griffin", Email = "chloe.griffin@hospitalitygroup.com", Phone = "+1 (555) 901-5789", Company = "Hospitality Group", Role = "Hotel Manager" },
            new Contact { Id = 30, Name = "Daniel Diaz", Email = "daniel.diaz@automotive.tech", Phone = "+1 (555) 012-6890", Company = "Auto Innovations", Role = "Mechanical Engineer" },
            new Contact { Id = 31, Name = "Elena Hayes", Email = "elena.hayes@publishinghouse.com", Phone = "+1 (555) 123-7901", Company = "Publishing House", Role = "Editor-in-Chief" },
            new Contact { Id = 32, Name = "Felix Myers", Email = "felix.myers@gamestudio.io", Phone = "+1 (555) 234-8012", Company = "Game Studio", Role = "Game Designer" },
            new Contact { Id = 33, Name = "Gabriella Ford", Email = "gabriella.ford@architecture.firm", Phone = "+1 (555) 345-9123", Company = "Modern Architecture", Role = "Lead Architect" },
            new Contact { Id = 34, Name = "Harrison Cole", Email = "harrison.cole@aerospace.tech", Phone = "+1 (555) 456-0345", Company = "Aerospace Tech", Role = "Aerospace Engineer" },
            new Contact { Id = 35, Name = "Isabella Ward", Email = "isabella.ward@energysolutions.com", Phone = "+1 (555) 567-1456", Company = "Energy Solutions", Role = "Energy Consultant" },
            new Contact { Id = 36, Name = "Jason Brooks", Email = "jason.brooks@telecom.net", Phone = "+1 (555) 678-2567", Company = "Telecom Networks", Role = "Network Engineer" },
            new Contact { Id = 37, Name = "Kimberly Sanders", Email = "kimberly.sanders@insurance.pro", Phone = "+1 (555) 789-3678", Company = "Insurance Pro", Role = "Insurance Broker" },
            new Contact { Id = 38, Name = "Lucas Perry", Email = "lucas.perry@pharmaceuticals.com", Phone = "+1 (555) 890-4789", Company = "Pharma Corp", Role = "Pharmaceutical Rep" },
            new Contact { Id = 39, Name = "Monica Powell", Email = "monica.powell@nonprofit.org", Phone = "+1 (555) 901-5890", Company = "Global Nonprofit", Role = "Program Director" },
            new Contact { Id = 40, Name = "Nathan Long", Email = "nathan.long@robotics.ai", Phone = "+1 (555) 012-6901", Company = "Robotics AI", Role = "Robotics Engineer" },
            new Contact { Id = 41, Name = "Olivia Barnes", Email = "olivia.barnes@ecommerce.shop", Phone = "+1 (555) 123-8012", Company = "E-Commerce Shop", Role = "E-Commerce Manager" },
            new Contact { Id = 42, Name = "Patrick Ross", Email = "patrick.ross@manufacturing.inc", Phone = "+1 (555) 234-9123", Company = "Manufacturing Inc", Role = "Production Manager" },
            new Contact { Id = 43, Name = "Quincy Henderson", Email = "quincy.henderson@blockchain.tech", Phone = "+1 (555) 345-0234", Company = "Blockchain Tech", Role = "Blockchain Developer" },
            new Contact { Id = 44, Name = "Rebecca Coleman", Email = "rebecca.coleman@foodservices.com", Phone = "+1 (555) 456-1345", Company = "Food Services", Role = "Executive Chef" },
            new Contact { Id = 45, Name = "Steven Jenkins", Email = "steven.jenkins@logistics.express", Phone = "+1 (555) 567-2456", Company = "Express Logistics", Role = "Logistics Coordinator" },
            new Contact { Id = 46, Name = "Theresa Perry", Email = "theresa.perry@hr-solutions.com", Phone = "+1 (555) 678-3567", Company = "HR Solutions", Role = "HR Director" },
            new Contact { Id = 47, Name = "Ulysses Gray", Email = "ulysses.gray@musicproduction.io", Phone = "+1 (555) 789-4678", Company = "Music Production", Role = "Music Producer" },
            new Contact { Id = 48, Name = "Vanessa James", Email = "vanessa.james@veterinary.care", Phone = "+1 (555) 890-5789", Company = "Veterinary Care", Role = "Veterinarian" },
            new Contact { Id = 49, Name = "William Butler", Email = "william.butler@banking.corp", Phone = "+1 (555) 901-6890", Company = "Banking Corp", Role = "Investment Banker" },
            new Contact { Id = 50, Name = "Xena Simmons", Email = "xena.simmons@graphicdesign.co", Phone = "+1 (555) 012-7901", Company = "Graphic Design Co", Role = "Graphic Designer" },
            new Contact { Id = 51, Name = "Yusuf Foster", Email = "yusuf.foster@agriculture.farm", Phone = "+1 (555) 123-9012", Company = "AgriTech Farms", Role = "Agricultural Scientist" },
            new Contact { Id = 52, Name = "Zara Mitchell", Email = "zara.mitchell@eventplanning.pro", Phone = "+1 (555) 234-0123", Company = "Event Planning Pro", Role = "Event Planner" },
            new Contact { Id = 53, Name = "Aaron Stewart", Email = "aaron.stewart@software.dev", Phone = "+1 (555) 345-1234", Company = "Software Dev Inc", Role = "Software Architect" },
            new Contact { Id = 54, Name = "Beatrice Flores", Email = "beatrice.flores@translation.services", Phone = "+1 (555) 456-2345", Company = "Translation Services", Role = "Translator" },
            new Contact { Id = 55, Name = "Cameron Morris", Email = "cameron.morris@cleanenergy.tech", Phone = "+1 (555) 567-3456", Company = "Clean Energy Tech", Role = "Sustainability Manager" },
            new Contact { Id = 56, Name = "Diana Rogers", Email = "diana.rogers@photography.studio", Phone = "+1 (555) 678-4567", Company = "Photography Studio", Role = "Photographer" },
            new Contact { Id = 57, Name = "Ethan Reed", Email = "ethan.reed@fitness.club", Phone = "+1 (555) 789-5678", Company = "Fitness Club", Role = "Fitness Trainer" },
            new Contact { Id = 58, Name = "Fiona Cook", Email = "fiona.cook@recruitment.agency", Phone = "+1 (555) 890-6789", Company = "Recruitment Agency", Role = "Recruitment Specialist" },
            new Contact { Id = 59, Name = "George Morgan", Email = "george.morgan@transportation.net", Phone = "+1 (555) 901-7890", Company = "Transportation Net", Role = "Fleet Manager" },
            new Contact { Id = 60, Name = "Hannah Bell", Email = "hannah.bell@interior.design", Phone = "+1 (555) 012-8901", Company = "Interior Design Co", Role = "Interior Designer" },
            new Contact { Id = 61, Name = "Isaac Murphy", Email = "isaac.murphy@cloudcomputing.io", Phone = "+1 (555) 123-0123", Company = "Cloud Computing", Role = "Cloud Solutions Architect" },
            new Contact { Id = 62, Name = "Julia Rivera", Email = "julia.rivera@quality.assurance", Phone = "+1 (555) 234-1234", Company = "QA Experts", Role = "QA Engineer" },
            new Contact { Id = 63, Name = "Kevin Cooper", Email = "kevin.cooper@security.systems", Phone = "+1 (555) 345-2345", Company = "Security Systems", Role = "Security Specialist" },
            new Contact { Id = 64, Name = "Laura Richardson", Email = "laura.richardson@digital.marketing", Phone = "+1 (555) 456-3456", Company = "Digital Marketing", Role = "SEO Specialist" },
            new Contact { Id = 65, Name = "Marcus Cox", Email = "marcus.cox@financial.planning", Phone = "+1 (555) 567-4567", Company = "Financial Planning", Role = "Financial Planner" },
            new Contact { Id = 66, Name = "Nina Howard", Email = "nina.howard@mobile.apps", Phone = "+1 (555) 678-5678", Company = "Mobile Apps Co", Role = "Mobile Developer" },
            new Contact { Id = 67, Name = "Oscar Ward", Email = "oscar.ward@printing.press", Phone = "+1 (555) 789-6789", Company = "Printing Press", Role = "Print Manager" },
            new Contact { Id = 68, Name = "Paula Torres", Email = "paula.torres@wellness.center", Phone = "+1 (555) 890-7890", Company = "Wellness Center", Role = "Wellness Coach" }
        );
    }
}