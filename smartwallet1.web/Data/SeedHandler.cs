using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data
{
    public class    SeedHandler
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            //Check if the database is populated
            if (!context.Customers.Any())
            {
                //Create Sample Data
                context.Customers.Add(new Customer
                {
                    FirstName = "Edafe",
                    LastName = "Ozumu",
                    Middlename = "Godswill",
                    Country = "Nigeria",
                    Maritalstatus = "single",
                    State = "lagos",
                    city = "lagos",
                    BirthDate = DateTime.Now.AddYears(-2),
                    Gender = GenderEnum.Male,
                    SubmissionDate = DateTime.Now,
                    Active = true
                });

                context.Customers.Add(new Customer
                {
                    FirstName = "Segun",
                    LastName = "Adeolu",
                    Middlename = "Tayo",
                    Country = "Nigeria",
                    Maritalstatus = "single",
                    State = "Ogun",
                    city = "lagos",
                    BirthDate = DateTime.Now.AddYears(-28),
                    Gender = GenderEnum.Female,
                    SubmissionDate = DateTime.Now,
                    Active = false
                });
                await context.SaveChangesAsync();
            }

            //if (!context.Countries.Any())
            //{
            //    context.Countries.AddRange(new List<Country>
            //    {
            //     new Country {Names="Afganisthan",IsoCode="AFG",CallCode="004"},
            //     new Country {Names="Aland Islands",IsoCode="ALA",CallCode="248"},
            //     new Country {Names="Albania",IsoCode="ALB",CallCode="008"}
            //    });
            //    await context.SaveChangesAsync();
            //}

            //if (!context.Languages.Any())
            //{
            //    context.Languages.AddRange(new List<Language>
            //    {
            //     new Language {LanguageName="Yoruba"},
            //      new Language {LanguageName="Igbo"},
            //      new Language {LanguageName="Hausa"}
            //    });
            //    await context.SaveChangesAsync();

            //}
        }
    }
}

