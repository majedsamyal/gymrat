using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
   public class RatMutationsType: ObjectType<RatMutations>
    {
        protected override void Configure(IObjectTypeDescriptor<RatMutations> descriptor)
        {
            descriptor.Field(t => t.SaveRat(default))
                .Type<NonNullType<RatViewModelType>>()
                .Argument("ratViewModel", a => a.Type<NonNullType<RatViewModelInputType>>());
        }
    }
}
