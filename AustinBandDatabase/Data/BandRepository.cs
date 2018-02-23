using System;
using System.Collections.Generic;
using System.Linq;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Data
{
    public class BandRepository
    {
        public List<Band> GetBands()
        {
            return Data.Bands;
        }

        public Band GetBand(int id)
        {
            Band band = Data.Bands
               .Where(b => b.Id == id)
               .SingleOrDefault();

            return band;
        }

        public void AddBand(Band band)
        {
            // Get the next available band ID.
            int nextAvailableBandId = Data.Bands
                .Max(e => e.Id) + 1;

            band.Id = nextAvailableBandId;

            Data.Bands.Add(band);
        }
    }
}