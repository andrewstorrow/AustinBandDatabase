using System;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Data
{
    public static class Data
    {
        public static Band[] Bands { get; private set; }

        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            var bands = new Band[]
            {
                new Band()
                {
                    Id = 1,
                    Name = "Forlorn Pickles",
                    YearFormed = DateTime.Parse("2009-1-1"),
                    DescriptionHtml = "The best band in Austin that sings (or screams) about pickles and pickling related topics."
                },
                new Band
                {
                    Id = 2,
                    Name = "Steve's Galaxy",
                    YearFormed = DateTime.Parse("2002-1-1"),
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 3,
                    Name = "Unjust Conquest",
                    YearFormed = DateTime.Parse("2013-1-1"),
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 4,
                    Name = "Once Again",
                    YearFormed = DateTime.Parse("2014-1-1"),
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 5,
                    Name = "Demoman",
                    YearFormed = DateTime.Parse("2007-1-1"),
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                }
            };

            Bands = bands;
        }
    }
}
