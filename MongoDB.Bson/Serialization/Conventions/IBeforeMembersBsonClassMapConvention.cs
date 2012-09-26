﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB.Bson.Serialization.Conventions
{
    /// <summary>
    /// Applies a BsonClassMap modification before any BsonMemberMap modifications have been run.
    /// </summary>
    public interface IBeforeMembersBsonClassMapConvention : IConvention
    {
        /// <summary>
        /// Applies a modification to the class map.
        /// </summary>
        /// <param name="classMap">The class map.</param>
        void Apply(BsonClassMap classMap);
    }
}