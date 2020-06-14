using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
    public class RatQueryType : ObjectType<RatQueries>
    {
        protected override void Configure(IObjectTypeDescriptor<RatQueries> descriptor)
        {
            base.Configure(descriptor);

            descriptor
              .Field(f => f.GetRats()).Description("Search rats.").Type<ListType<RatViewModelType>>();            
        }
    }
}
