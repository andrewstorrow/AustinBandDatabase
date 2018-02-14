using System;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Data
{
    public class BandRepository
    {
        public Band[] GetBands()
        {
            return Data.Bands;
        }
    }
}