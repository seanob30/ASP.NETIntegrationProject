namespace IntegrationProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IntegrationProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IntegrationProject.Models.ApplicationDbContext context)
        {
            context.Day.AddOrUpdate(m => m.Id,
                 new Models.Days { Id = 1, Day = 1 },
                 new Models.Days { Id = 2, Day = 2 },
                 new Models.Days { Id = 3, Day = 3 },
                 new Models.Days { Id = 4, Day = 4 },
                 new Models.Days { Id = 5, Day = 5 },
                 new Models.Days { Id = 6, Day = 6 },
                 new Models.Days { Id = 7, Day = 7 },
                 new Models.Days { Id = 8, Day = 8 },
                 new Models.Days { Id = 9, Day = 9 },
                 new Models.Days { Id = 10, Day = 10 },
                 new Models.Days { Id = 11, Day = 11 },
                 new Models.Days { Id = 12, Day = 12 },
                 new Models.Days { Id = 13, Day = 13 },
                 new Models.Days { Id = 14, Day = 14 },
                 new Models.Days { Id = 15, Day = 15 },
                 new Models.Days { Id = 16, Day = 16 },
                 new Models.Days { Id = 17, Day = 17 },
                 new Models.Days { Id = 18, Day = 18 },
                 new Models.Days { Id = 19, Day = 19 },
                 new Models.Days { Id = 20, Day = 20 },
                 new Models.Days { Id = 21, Day = 21 },
                 new Models.Days { Id = 22, Day = 22 },
                 new Models.Days { Id = 23, Day = 23 },
                 new Models.Days { Id = 24, Day = 24 },
                 new Models.Days { Id = 25, Day = 25 },
                 new Models.Days { Id = 26, Day = 26 },
                 new Models.Days { Id = 27, Day = 27 },
                 new Models.Days { Id = 28, Day = 28 },
                 new Models.Days { Id = 29, Day = 29 },
                 new Models.Days { Id = 30, Day = 30 },
                 new Models.Days { Id = 31, Day = 31 }
                 );

            context.Months.AddOrUpdate(m => m.Id,
                new Models.Months { Id = 1, Month = "January" },
                new Models.Months { Id = 2, Month = "February" },
                new Models.Months { Id = 3, Month = "March" },
                new Models.Months { Id = 4, Month = "April" },
                new Models.Months { Id = 5, Month = "May" },
                new Models.Months { Id = 6, Month = "June" },
                new Models.Months { Id = 7, Month = "July" },
                new Models.Months { Id = 8, Month = "August" },
                new Models.Months { Id = 9, Month = "September" },
                new Models.Months { Id = 10, Month = "October" },
                new Models.Months { Id = 11, Month = "November" },
                new Models.Months { Id = 12, Month = "December" }
                );

            context.Year.AddOrUpdate(m => m.Id,
                new Models.Years { Id = 1, Year = 1950 },
                new Models.Years { Id = 2, Year = 1951 },
                new Models.Years { Id = 3, Year = 1952 },
                new Models.Years { Id = 4, Year = 1953 },
                new Models.Years { Id = 5, Year = 1954 },
                new Models.Years { Id = 6, Year = 1955 },
                new Models.Years { Id = 7, Year = 1956 },
                new Models.Years { Id = 8, Year = 1957 },
                new Models.Years { Id = 9, Year = 1958 },
                new Models.Years { Id = 10, Year = 1959 },
                new Models.Years { Id = 11, Year = 1960 },
                new Models.Years { Id = 12, Year = 1961 },
                new Models.Years { Id = 13, Year = 1962 },
                new Models.Years { Id = 14, Year = 1963 },
                new Models.Years { Id = 15, Year = 1964 },
                new Models.Years { Id = 16, Year = 1965 },
                new Models.Years { Id = 17, Year = 1966 },
                new Models.Years { Id = 18, Year = 1967 },
                new Models.Years { Id = 19, Year = 1968 },
                new Models.Years { Id = 20, Year = 1969 },
                new Models.Years { Id = 21, Year = 1970 },
                new Models.Years { Id = 22, Year = 1971 },
                new Models.Years { Id = 23, Year = 1972 },
                new Models.Years { Id = 24, Year = 1973 },
                new Models.Years { Id = 25, Year = 1974 },
                new Models.Years { Id = 26, Year = 1975 },
                new Models.Years { Id = 27, Year = 1976 },
                new Models.Years { Id = 28, Year = 1977 },
                new Models.Years { Id = 29, Year = 1978 },
                new Models.Years { Id = 30, Year = 1979 },
                new Models.Years { Id = 31, Year = 1980 },
                new Models.Years { Id = 32, Year = 1981 },
                new Models.Years { Id = 33, Year = 1982 },
                new Models.Years { Id = 34, Year = 1983 },
                new Models.Years { Id = 35, Year = 1984 },
                new Models.Years { Id = 36, Year = 1985 },
                new Models.Years { Id = 37, Year = 1986 },
                new Models.Years { Id = 38, Year = 1987 },
                new Models.Years { Id = 39, Year = 1988 },
                new Models.Years { Id = 40, Year = 1989 },
                new Models.Years { Id = 41, Year = 1990 },
                new Models.Years { Id = 42, Year = 1991 },
                new Models.Years { Id = 43, Year = 1992 },
                new Models.Years { Id = 44, Year = 1993 },
                new Models.Years { Id = 45, Year = 1994 },
                new Models.Years { Id = 46, Year = 1995 },
                new Models.Years { Id = 47, Year = 1996 },
                new Models.Years { Id = 48, Year = 1997 },
                new Models.Years { Id = 49, Year = 1998 },
                new Models.Years { Id = 50, Year = 1999 },
                new Models.Years { Id = 51, Year = 2000 },
                new Models.Years { Id = 52, Year = 2001 },
                new Models.Years { Id = 53, Year = 2002 },
                new Models.Years { Id = 54, Year = 2003 },
                new Models.Years { Id = 55, Year = 2004 },
                new Models.Years { Id = 56, Year = 2005 },
                new Models.Years { Id = 57, Year = 2006 },
                new Models.Years { Id = 58, Year = 2007 },
                new Models.Years { Id = 59, Year = 2008 },
                new Models.Years { Id = 60, Year = 2009 },
                new Models.Years { Id = 61, Year = 2010 },
                new Models.Years { Id = 62, Year = 2011 },
                new Models.Years { Id = 63, Year = 2012 },
                new Models.Years { Id = 64, Year = 2013 },
                new Models.Years { Id = 65, Year = 2014 },
                new Models.Years { Id = 66, Year = 2015 },
                new Models.Years { Id = 67, Year = 2016 },
                new Models.Years { Id = 68, Year = 2017 }
                );

            context.AccountType.AddOrUpdate(m => m.Id,
            new Models.AccountTypes { Id = 1, AccountType = "Customer" },
            new Models.AccountTypes { Id = 2, AccountType = "Administrator" }
            );
        }
    }
}
