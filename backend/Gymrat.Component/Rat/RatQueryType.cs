using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
    public class RatQueryType : ObjectType<IRatQueries>
    {
        protected override void Configure(IObjectTypeDescriptor<IRatQueries> descriptor)
        {
            base.Configure(descriptor);

            descriptor
              .Field(f => f.GetRats());
        }
    }
}
