﻿using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class TipoPagoConfiguration : EntityTypeConfiguration<TipoPago>
    {
        
        public TipoPagoConfiguration()
        {
            ToTable("TipoPago");
            HasKey(cl => cl.TipoPagoID);


        } 

    }
}