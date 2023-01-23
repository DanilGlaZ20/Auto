﻿using Auto.Data.Entities;
using GraphQL.Types;

namespace Auto.Website.GraphQL.GraphTypes
{

    public class OwnerGraphType : ObjectGraphType<Owner>
    {
        public OwnerGraphType()
        {
            Name = "owner";
            Field(e => e.FirstName, nullable: false);
            Field(e => e.MiddleName, nullable: false);
            Field(e => e.LastName, nullable: false);
            Field(e => e.Age, nullable: false);
            Field(e => e.Experience, nullable: false);
            Field(e => e.Serial, nullable: false);
            Field(e => e.Number, nullable: false);
            Field(e => e.Vehicle, nullable: true, type: typeof(VehicleGraphType));
        }
    }
}