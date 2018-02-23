using System;
using System.Collections.Generic;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Data
{
    public static class Data
    {
        public static List<Band> Bands { get; private set; }

        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            var bands = new List<Band>()
            {
                new Band()
                {
                    Id = 1,
                    Name = "Forlorn Pickles",
                    YearFormed = "2009",
                    DescriptionHtml = "The best band in Austin that sings (or screams) about pickles and pickling related topics."
                },
                new Band
                {
                    Id = 2,
                    Name = "Steve's Galaxy",
                    YearFormed = "2002",
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 3,
                    Name = "Unjust Conquest",
                    YearFormed = "2013",
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 4,
                    Name = "Once Again",
                    YearFormed = "2014",
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                },
                new Band
                {
                    Id = 5,
                    Name = "Demoman",
                    YearFormed = "2007",
                    DescriptionHtml = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation" +
                    " ullamco laboris nisi ut aliquip ex ea commodoconsequat."
                }
            };

            Bands = bands;
        }
    }
}
