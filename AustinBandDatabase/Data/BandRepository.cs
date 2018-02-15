using System;
using System.Collections.Generic;
using System.Linq;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Data
{
    public class BandRepository
    {
        public Band[] GetBands()
        {
            return Data.Bands;
        }

        public Band GetBand(int id)
        {
            Band band = Data.Bands.Where(b => b.Id == id).SingleOrDefault();

            return band;
        }
    }
}