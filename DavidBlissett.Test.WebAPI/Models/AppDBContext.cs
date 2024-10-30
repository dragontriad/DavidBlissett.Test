using DavidBlissett.Test.Shared;
using Microsoft.EntityFrameworkCore;

namespace DavidBlissett.Test.WebAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OneToManyRelationshipConfiguration(modelBuilder);
            ManyToManyRelationshipConfiguration(modelBuilder);
            OneToOneRelationshipConfiguration(modelBuilder);
            //Diable when testing or in production
            OnModelCreating_V1(modelBuilder);
        }

        private void OneToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {


        }

        private void ManyToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {

        }

        private void OneToOneRelationshipConfiguration(ModelBuilder modelBuilder)
        {

        }

        protected void OnModelCreating_V1(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            if (true == true)
            {
                modelBuilder.Entity<Customer>().HasData(
                    new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Address1 = "10 Downing Street", Address2 = "Westminster", PostCode = "SW1A 2AA", TelephoneNumber = "020-7123-4567" },
                    new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Smith", Address1 = "1 King Street", Address2 = "St. James's", PostCode = "SW1Y 6QW", TelephoneNumber = "020-7890-1234" },
                    new Customer { CustomerID = 3, FirstName = "Mike", LastName = "Brown", Address1 = "15 Queen Square", Address2 = "", PostCode = "BS1 4NT", TelephoneNumber = "0117-9876-5432" },
                    new Customer { CustomerID = 4, FirstName = "Lucy", LastName = "Williams", Address1 = "3 Great George Street", Address2 = "", PostCode = "BS1 5RH", TelephoneNumber = "0117-6543-2109" },
                    new Customer { CustomerID = 5, FirstName = "Chris", LastName = "Johnson", Address1 = "2 Broad Street", Address2 = "", PostCode = "OX1 3AZ", TelephoneNumber = "01865-987-654" },
                    new Customer { CustomerID = 6, FirstName = "Anna", LastName = "Davis", Address1 = "5 Magdalen Street", Address2 = "", PostCode = "OX1 3AD", TelephoneNumber = "01865-876-543" },
                    new Customer { CustomerID = 7, FirstName = "Tom", LastName = "Clark", Address1 = "1 Albert Square", Address2 = "", PostCode = "M2 5DB", TelephoneNumber = "0161-234-5000" },
                    new Customer { CustomerID = 8, FirstName = "Sara", LastName = "Miller", Address1 = "3 Saint Peter's Square", Address2 = "", PostCode = "M2 3AE", TelephoneNumber = "0161-234-6000" },
                    new Customer { CustomerID = 9, FirstName = "Ben", LastName = "Garcia", Address1 = "30 Dean Street", Address2 = "", PostCode = "W1D 3RF", TelephoneNumber = "020-7323-4400" },
                    new Customer { CustomerID = 10, FirstName = "Emily", LastName = "Martinez", Address1 = "1 Oxford Street", Address2 = "", PostCode = "W1D 2DJ", TelephoneNumber = "020-7450-1234" },
                    new Customer { CustomerID = 11, FirstName = "Oliver", LastName = "Hughes", Address1 = "12 Abbey Road", Address2 = "", PostCode = "NW8 9AY", TelephoneNumber = "020-7231-7654" },
                    new Customer { CustomerID = 12, FirstName = "Charlotte", LastName = "Wilson", Address1 = "25 College Green", Address2 = "", PostCode = "BS1 5TB", TelephoneNumber = "0117-123-4567" },
                    new Customer { CustomerID = 13, FirstName = "George", LastName = "Robinson", Address1 = "7 Oxford Road", Address2 = "", PostCode = "OX1 3PF", TelephoneNumber = "01865-456-789" },
                    new Customer { CustomerID = 14, FirstName = "Sophie", LastName = "Walker", Address1 = "18 Portland Street", Address2 = "", PostCode = "M1 3LA", TelephoneNumber = "0161-456-7890" },
                    new Customer { CustomerID = 15, FirstName = "James", LastName = "Hall", Address1 = "9 Baker Street", Address2 = "", PostCode = "W1U 3AA", TelephoneNumber = "020-3456-7890" },
                    new Customer { CustomerID = 16, FirstName = "Amelia", LastName = "Green", Address1 = "21 Park Row", Address2 = "", PostCode = "BS1 5LJ", TelephoneNumber = "0117-234-5678" },
                    new Customer { CustomerID = 17, FirstName = "Henry", LastName = "Allen", Address1 = "17 Cornmarket Street", Address2 = "", PostCode = "OX1 3HL", TelephoneNumber = "01865-321-987" },
                    new Customer { CustomerID = 18, FirstName = "Isabella", LastName = "Young", Address1 = "45 King Street", Address2 = "", PostCode = "M2 7AY", TelephoneNumber = "0161-567-4321" },
                    new Customer { CustomerID = 19, FirstName = "Jack", LastName = "Harris", Address1 = "62 Charing Cross Road", Address2 = "", PostCode = "WC2H 0BB", TelephoneNumber = "020-9876-5432" },
                    new Customer { CustomerID = 20, FirstName = "Lily", LastName = "Martin", Address1 = "14 George Street", Address2 = "", PostCode = "BS1 5TP", TelephoneNumber = "0117-345-6789" }
                );




            }
            base.OnModelCreating(modelBuilder);


        }
    }
}
