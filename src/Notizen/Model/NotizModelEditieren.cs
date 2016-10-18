﻿using System;
using System.ComponentModel.DataAnnotations;
using Notizen.DbModel;

namespace Notizen.Model
{
    public class NotizModelEditieren : NotizModelBase
    {
        public NotizModelEditieren()
        {
        }

        public NotizModelEditieren(NotizDbModel u) : base(u)
        {
            Id = u.Id;
            if (u.ErledigtBis != null)
            {
                ErledigtBisDatum = u.ErledigtBis.Value.Date;
                ErledigtBisZeit = u.ErledigtBis.Value.TimeOfDay;
            }
        }
        
        public int Id { get; set; }

        //public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ErledigtBisDatum { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? ErledigtBisZeit { get; set; }
    }
}